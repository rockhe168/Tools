// -----------------------------------------------------------------------
// <copyright file="O_Mobile_TempOrder.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Ctrip.Mobile.Tour.DataRepository.PO.PkgOnlineOrderDB
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Package.Framework2.Data;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class O_Mobile_TempOrderPO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "PkgOnlineOrderDB_SELECT.O_Mobile_TempOrder";
        public const string TABLE_NAME_INSERT = "PkgOnlineOrderDB_SAVE.O_Mobile_TempOrder";

        /// <summary>
///自增长主键
/// </summary>
public long TempId { get; set; }

/// <summary>
///临时订单号
/// </summary>
public int TempOrderId { get; set; }

/// <summary>
///订单号
/// </summary>
public int OrderId { get; set; }

/// <summary>
///缓存中的Key值
/// </summary>
public string CacheKey { get; set; }

/// <summary>
///用户Id
/// </summary>
public string Uid { get; set; }

/// <summary>
///资源搜索Request 序列化字符
/// </summary>
public string ResourceSearchRequestStr { get; set; }

/// <summary>
///资源搜索Response 序列化结果
/// </summary>
public string ResourceSearchResponseStr { get; set; }

/// <summary>
///OMD Request报文
/// </summary>
public string OrderCreateBaseRequestStr { get; set; }

/// <summary>
///前端Request报文序列化
/// </summary>
public string CreateOrderRequestStr { get; set; }

/// <summary>
///CreateTime
/// </summary>
public DateTime DataChange_CreateTime { get; set; }

/// <summary>
///Last Update Time
/// </summary>
public DateTime DataChange_LastTime { get; set; }

/// <summary>
///OMD Response 序列化报文
/// </summary>
public string OrderCreateBaseResponseStr { get; set; }

/// <summary>
///临时单查询序列化字符串
/// </summary>
public string TmpOrderQueryResponseStr { get; set; }


    }
}

