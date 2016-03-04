// -----------------------------------------------------------------------
// <copyright file="Ord_PaymentVoucherPullLog.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Package.Vendor.VBooking.DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Package.Framework2.Data;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Ord_PaymentVoucherPullLogPO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "VBookingDB_SELECT.Ord_PaymentVoucherPullLog";
        public const string TABLE_NAME_INSERT = "VBookingDB_SAVE.Ord_PaymentVoucherPullLog";

        /// <summary>
///主键，自增。
/// </summary>
public long PaymentVoucherPullLogID { get; set; }

/// <summary>
///供应商ID
/// </summary>
public long ProviderID { get; set; }

/// <summary>
///结算操作起始时间（精确到小时）
/// </summary>
public DateTime BalanceOperateTimeHFrom { get; set; }

/// <summary>
///结算操作截止时间（精确到小时）
/// </summary>
public DateTime BalanceOperateTimeHTo { get; set; }

/// <summary>
///拉操作时间（精确到分钟）
/// </summary>
public DateTime PullTimeM { get; set; }

/// <summary>
///处理状态。0=成功,1=部分成功,2=全部失败
/// </summary>
public int PullStatus { get; set; }

/// <summary>
///错误日志
/// </summary>
public string ErrorDetails { get; set; }

/// <summary>
///执行次数
/// </summary>
public int RetryCount { get; set; }

/// <summary>
///创建时间
/// </summary>
public DateTime DataChange_CreateTime { get; set; }

/// <summary>
///最后一次修改时间
/// </summary>
public DateTime DataChange_LastTime { get; set; }


    }
}

