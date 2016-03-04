// -----------------------------------------------------------------------
// <copyright file="O_Mobile_OrderShare.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Ctrip.Mobile.Tour.DataRepository.PO.PkgOnlineDB
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Package.Framework2.Data;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class O_Mobile_OrderSharePO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "PkgOnlineDB_SELECT.O_Mobile_OrderShare";
        public const string TABLE_NAME_INSERT = "PkgOnlineDB_SAVE.O_Mobile_OrderShare";

        /// <summary>
///主键
/// </summary>
public long ShareId { get; set; }

/// <summary>
///分享的订单Id
/// </summary>
public int OrderId { get; set; }

/// <summary>
///MD5加密后的OrderId,用于外露
/// </summary>
public string EncryptOrderId { get; set; }

/// <summary>
///CreateTime
/// </summary>
public DateTime DataChange_CreateTime { get; set; }

/// <summary>
///Last Update Time
/// </summary>
public DateTime DataChange_LastTime { get; set; }

/// <summary>
///分享日期
/// </summary>
public DateTime ShareDate { get; set; }

/// <summary>
///分享次数
/// </summary>
public int SharCount { get; set; }


    }
}

