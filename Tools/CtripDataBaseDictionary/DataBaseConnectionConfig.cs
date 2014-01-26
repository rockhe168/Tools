using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtripDataBaseDictionary
{
    public class DataBaseConnectionConfig
    {
        /// <summary>
        /// 服务器
        /// </summary>
        public static string ServerName { get; set; }


        /// <summary>
        /// 链接类型对应值 如：windows = "integrated security=sspi"
        /// </summary>
        public static string  ConnectionTypeValue { get; set; }


        /// <summary>
        /// 根据数据名称，获取具体数据库两件字符串
        /// </summary>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public static string GetDataBaseConnectionString(string databaseName)
        {
            return string.Format(
                GlobalContext.SqlConnectionStringTemplate,
                ServerName,
                ConnectionTypeValue,string.IsNullOrEmpty(databaseName) ? string.Empty :"database=" + databaseName);
        }
    }
}
