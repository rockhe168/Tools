using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace CtripDataBaseDictionary
{
    using Microsoft.Practices.EnterpriseLibrary.Data;

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            GlobalContext.ApplicationStartPath = Application.StartupPath;

            BindTreeView();
        }

        /// <summary>
        /// 绑定TreeView
        /// </summary>
        void BindTreeView()
        {
            List<DataBaseContext> dataBaseContextList = GlobalContext.DataBaseContexts;

            this.tvTrees.Nodes.Clear();

            foreach (var databaseContext in dataBaseContextList)
            {
                //加载数据库
                var databaseNode = new TreeNode()
                             {
                                 Text = databaseContext.DataBaseName,
                                 Name = databaseContext.DataBaseName
                             };

                //加载对应表
                //foreach (var tableNode in databaseContext.TableList.Select(tableContext => new TreeNode() { Text = tableContext.TableName, Name = tableContext.TableName }))
                //{
                //    databaseNode.Nodes.Add(tableNode);
                //}

                this.tvTrees.Nodes.Add(databaseNode);

            }

        }

        
        //生成SQL
        private void btnSQL_Click(object sender, EventArgs e)
        {

        }

        private void tvTrees_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //点击一级菜单栏
            if (e.Node.Level == 0)
            {
                this.tvTrees.CollapseAll();//收缩

                var databaseName = e.Node.Name;

                List<TableContext> tableContexts =
                    GlobalContext.DataBaseContexts.First(p => p.DataBaseName.Equals(databaseName)).TableList;

                //加载对应表
                foreach (var tableNode in tableContexts.Select(tableContext => new TreeNode() { Text = tableContext.Name+(string.IsNullOrEmpty(tableContext.Description) ? string.Empty :"【"+tableContext.Description+"】"), Name = tableContext.Name }))
                {
                    e.Node.Nodes.Add(tableNode);
                }

                e.Node.ExpandAll();
            }
            else if (e.Node.Level == 1)//点击表
            {
                var databaseName = e.Node.Parent.Name;
                var tableName = e.Node.Name;

                this.dgvColumn.DataSource = DAOHelper.GetColumnContextListByTableName(databaseName, tableName);
                
            }
        }

        private void btnNormalGenerator_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneratePO_Click(object sender, EventArgs e)
        {
            //获取当前要生成的表
            List<TableContext> tableContexts = GetSelectedTableList();
          
            //生成代码
            foreach (var table in tableContexts)
            {
                //------------------------------->生成PO类
                GeneratorDomainEntity(table);
            }

        }


        /// <summary>
        /// 生成Domain（领域模型） Entity（实体类）
        /// </summary>
        /// <param name="table"></param>
        void GeneratorDomainEntity(TableContext table)
        {

            string templatePath = Path.Combine(GlobalContext.ApplicationStartPath, GlobalContext.DomainEntityTemplateUrl);

            //获取模板
            StringBuilder domainEntityTemplate = Tools.GetTemplate(templatePath);

            var nameSpace = this.txtNameSpace.Text.Trim(); //GlobalContext.Domain + ".Entities." + GlobalContext.CurrentConfigNameSpace;

            //替换命名空间
            domainEntityTemplate.Replace(GlobalContext.NameSpace, nameSpace);
            //替换类名
            domainEntityTemplate.Replace(GlobalContext.TableName, table.Name);
            //替换属性列表

            var strList = new StringBuilder();

            foreach (var column in table.ColumnList)
            {
                strList.AppendLine("/// <summary>");
                strList.AppendLine("///" + column.NameDescription);
                strList.AppendLine("/// </summary>");
                strList.AppendLine("public " + Tools.ConvertVSTypeToString(column.DateType) + " " + column.Name + " { get; set; }");
                strList.AppendLine();
            }

            //替换属性列表
            domainEntityTemplate.Replace(GlobalContext.ProPertyList, strList.ToString());

            //替换数据库属性列表
            domainEntityTemplate.Replace(GlobalContext.DatabaseTag, this.FilterDataBaseName(table.DataBaseName));

            //写入文件的文件夹路径
            string fileWriterFolderPath = Path.Combine(GlobalContext.ApplicationStartPath + "\\CodeGenerator",
                                                 nameSpace.Replace('.', '\\'));

            var fileWriterFilePath = fileWriterFolderPath + "\\" + table.Name + "PO.cs";

            Tools.CheckDirectory(fileWriterFolderPath);

            Tools.WriterTemplateFile(domainEntityTemplate, fileWriterFilePath);

        }


        /// <summary>
        /// 获取当前选中的表
        /// </summary>
        /// <returns></returns>
        List<TableContext> GetSelectedTableList()
        {
            var list = new List<TableContext>();
            foreach (TreeNode dbNode in this.tvTrees.Nodes)
            {
                foreach (TreeNode node in dbNode.Nodes)
                {
                    if (node.Checked)
                    {
                        //list.AddRange(GlobalContext.TableContexts.Where(p => p.Name.Equals(node.Name)));

                        var currentSelectTableContext = new TableContext()
                                                        {
                                                            Name = node.Name,
                                                            DataBaseName = node.Parent.Name
                                                        };

                        list.Add(currentSelectTableContext);
                    }
                }            
            }

            return list;
        }


        string FilterDataBaseName(string databaseName)
        {
            string result = string.Empty;
            switch (databaseName.ToLower())
            {
                case "vbookingdb":
                    result = "VBookingDB";
                    break;
                case "pkgorderdb":
                    result = "PkgOrderDB";
                    break;
                case "pkginputdb":
                    result = "PkgInputDB";
                    break;
                case "pkgpubdb":
                    result = "PkgPubDB";
                    break;
                default:
                    result = databaseName;
                    break;

            }

            return result;
        }

    }
}
