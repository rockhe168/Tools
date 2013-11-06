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
    }
}
