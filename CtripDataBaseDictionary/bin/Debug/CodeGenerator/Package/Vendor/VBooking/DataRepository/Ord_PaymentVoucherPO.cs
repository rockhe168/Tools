// -----------------------------------------------------------------------
// <copyright file="Ord_PaymentVoucher.cs" company="Microsoft">
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
    public class Ord_PaymentVoucherPO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "VBookingDB_SELECT.Ord_PaymentVoucher";
        public const string TABLE_NAME_INSERT = "VBookingDB_SAVE.Ord_PaymentVoucher";

        /// <summary>
///主键
/// </summary>
public long PaymentVoucherID { get; set; }

/// <summary>
///引用4126结算流水表的主键
/// </summary>
public long PaymentVourcherRef { get; set; }

/// <summary>
///订单编号
/// </summary>
public long OrderID { get; set; }

/// <summary>
///采购单ID
/// </summary>
public long PurchaseOrderID { get; set; }

/// <summary>
///供应商ID
/// </summary>
public long ProviderID { get; set; }

/// <summary>
///携程产品ID
/// </summary>
public long CtripProductId { get; set; }

/// <summary>
///产品名称。来自VBK的Prd_Resource
/// </summary>
public string ProductName { get; set; }

/// <summary>
///资源名称。来自VBK的Prd_Resource。
/// </summary>
public string ResourceName { get; set; }

/// <summary>
///预订原始名称。来自4126的采购单
/// </summary>
public string BookingResourceName { get; set; }

/// <summary>
///卖价
/// </summary>
public decimal SalePrice { get; set; }

/// <summary>
///底价
/// </summary>
public decimal CostPrice { get; set; }

/// <summary>
///币种
/// </summary>
public string Currency { get; set; }

/// <summary>
///数量
/// </summary>
public int Quantity { get; set; }

/// <summary>
///成人数量
/// </summary>
public int AdultQuantity { get; set; }

/// <summary>
///儿童数量
/// </summary>
public int ChildQuantity { get; set; }

/// <summary>
///交易时间。如果是正常流水为预订时间，否则是退补款或者优惠代码的流水操作日期。
/// </summary>
public DateTime TransactionTime { get; set; }

/// <summary>
///订单日期
/// </summary>
public DateTime OrderDate { get; set; }

/// <summary>
///出发日期
/// </summary>
public DateTime DepartureDate { get; set; }

/// <summary>
///使用日期
/// </summary>
public DateTime UseDate { get; set; }

/// <summary>
///返程日期
/// </summary>
public DateTime ReturnDate { get; set; }

/// <summary>
///汇率。
/// </summary>
public decimal Exchange { get; set; }

/// <summary>
///出发城市名称
/// </summary>
public string StartCityName { get; set; }

/// <summary>
///结算方式。’W’-月结 ‘B’-单结 ‘W’-周结
/// </summary>
public char ProviderBlncPeriod { get; set; }

/// <summary>
///优惠代码特殊供应商ID。默认为0
/// </summary>
public long SpecialProviderID { get; set; }

/// <summary>
///结算处理批次号码
/// </summary>
public string BatchNumbe { get; set; }

/// <summary>
///结算流水操作时间
/// </summary>
public DateTime BalanceOperateTime { get; set; }

/// <summary>
///结算流水操作时间（精确到小时）
/// </summary>
public DateTime BalanceOperateTimeH { get; set; }

/// <summary>
///客人姓名
/// </summary>
public string ClientNames { get; set; }

/// <summary>
///创建时间
/// </summary>
public DateTime DataChange_CreateTime { get; set; }

/// <summary>
///修改时间
/// </summary>
public DateTime DataChange_LastTime { get; set; }

/// <summary>
///结算数据类型。1-正常结算数据 2-退补款结算数据 3-优惠代码
/// </summary>
public int VoucherType { get; set; }


    }
}

