// -----------------------------------------------------------------------
// <copyright file="Sales_SalesOrder.cs" company="Microsoft">
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
    public class Sales_SalesOrderPO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "PkgOrderDB_SELECT.Sales_SalesOrder";
        public const string TABLE_NAME_INSERT = "PkgOrderDB_SAVE.Sales_SalesOrder";

        /// <summary>
///销售子订单ID
/// </summary>
public int SalesOrderID { get; set; }

/// <summary>
///订单号
/// </summary>
public int OrderID { get; set; }

/// <summary>
///行程段编号
/// </summary>
public int Segment { get; set; }

/// <summary>
///资源编号
/// </summary>
public int ResourceID { get; set; }

/// <summary>
///资源类型（I-非航班单选项、O-可选项、F-航班单选项、S-系统航班、X-其他）
/// </summary>
public char ResourceType { get; set; }

/// <summary>
///资源名称
/// </summary>
public string ResourceName { get; set; }

/// <summary>
///资源描述
/// </summary>
public string ResourceDesc { get; set; }

/// <summary>
///收款代码
/// </summary>
public string ReceiptCode { get; set; }

/// <summary>
///总价（已算上人数）
/// </summary>
public decimal TotalPrice { get; set; }

/// <summary>
///份数;成人份数
/// </summary>
public int Quantity { get; set; }

/// <summary>
///使用日期
/// </summary>
public DateTime UseDate { get; set; }

/// <summary>
///是否需要分配客人（T-需要;F-不需要）
/// </summary>
public char IsClientAssign { get; set; }

/// <summary>
///状态(P-审核通过；C-取消；V-生效；I-作废)
/// </summary>
public char Status { get; set; }

/// <summary>
///操作员
/// </summary>
public string Operator { get; set; }

/// <summary>
///操作时间
/// </summary>
public DateTime OperateTime { get; set; }

/// <summary>
///操作原因
/// </summary>
public string OperateReason { get; set; }

/// <summary>
///非系统订单
/// </summary>
public char UnSystemOrder { get; set; }

/// <summary>
///儿童份数
/// </summary>
public int ChildQuantity { get; set; }

/// <summary>
///婴儿份数
/// </summary>
public int BabyQuantity { get; set; }

/// <summary>
///儿童单价
/// </summary>
public decimal ChildPrice { get; set; }

/// <summary>
///婴儿单价
/// </summary>
public decimal BabyPrice { get; set; }

/// <summary>
///成人单价
/// </summary>
public decimal AdultPrice { get; set; }

/// <summary>
///成人数量
/// </summary>
public int AdultQuantity { get; set; }

/// <summary>
///销货单类型：机票-FLT、酒店-HTL、欧铁-EUR、欧铁服务费-ERS、可选项-OPT
/// </summary>
public char SalesOrderType { get; set; }

/// <summary>
///销货单票务处理状态（通知出票-NOTIFY_INVOICE、已出票-INVOICED、已部分退票-P
/// </summary>
public string TicketStatus { get; set; }

/// <summary>
///销货单结算处理状态（立即扣款-IMMEDIATELY_DEDUCTION，客人已付款-PAYMENT
/// </summary>
public string BalanceStatus { get; set; }

/// <summary>
///拆单的源销货单，销货单拆单时产生的拆单中记录的原单号码
/// </summary>
public string FromSalesOrder { get; set; }

/// <summary>
///Online主键ID
/// </summary>
public Guid OnlinePKID { get; set; }

/// <summary>
///销货单确认状态(T:确认;F:满位;S申请)
/// </summary>
public char ConfirmFill { get; set; }

/// <summary>
///携程产品确认时间间隔（单位：小时）
/// </summary>
public int ConfirmInterval { get; set; }

/// <summary>
///来源单价格
/// </summary>
public decimal SourcePrice { get; set; }

/// <summary>
///租车ID
/// </summary>
public string CarID { get; set; }

/// <summary>
///单位
/// </summary>
public string Unit { get; set; }

/// <summary>
///处理状态（如通知出票、已出票）
/// </summary>
public int SalesProcessStatus { get; set; }

/// <summary>
///资源最晚确认时间
/// </summary>
public DateTime LastConfirmDate { get; set; }

/// <summary>
///到达城市ID
/// </summary>
public int ArrivalCity { get; set; }

/// <summary>
///到达城市名称
/// </summary>
public string ArrivalCityName { get; set; }

/// <summary>
///出发城市ID
/// </summary>
public int DepartureCity { get; set; }

/// <summary>
///出发城市名称
/// </summary>
public string DepartureCityName { get; set; }

/// <summary>
///返回日期
/// </summary>
public DateTime ReturnDate { get; set; }

/// <summary>
///
/// </summary>
public DateTime DataChange_LastTime { get; set; }


    }
}

