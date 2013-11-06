using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtripDataBaseDictionary
{
    /// <summary>
    /// 表对象
    /// </summary>
   public  class TableContext
    {
       /// <summary>
       /// 表名
       /// </summary>
        public string Name { get; set; }

       /// <summary>
       /// 表名描述
       /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 表下面所有的集合
        /// </summary>
        public List<ColumnContext> ColumnList
        {
            get
            {
                return DAOHelper.GetColumnContextListByTableName(this.DataBaseName, this.Name);
            }
        }

       /// <summary>
       /// 属于数据库名称
       /// </summary>
        public string DataBaseName { get; set; }
    }
}
