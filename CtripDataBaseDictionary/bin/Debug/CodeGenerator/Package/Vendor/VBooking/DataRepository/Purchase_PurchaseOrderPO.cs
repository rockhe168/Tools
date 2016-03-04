// -----------------------------------------------------------------------
// <copyright file="Purchase_PurchaseOrder.cs" company="Microsoft">
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
    public class Purchase_PurchaseOrderPO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "PkgOrderDB_SELECT.Purchase_PurchaseOrder";
        public const string TABLE_NAME_INSERT = "PkgOrderDB_SAVE.Purchase_PurchaseOrder";

        /// <summary>
///采购子订单ID
/// </summary>
public int PurchaseOrderID { get; set; }

/// <summary>
///来源订单ID（0为没有来源订单）
/// </summary>
public int SourceOrderID { get; set; }

/// <summary>
///来源订单类型（销售子订单S，其它）
/// </summary>
public char SourceOrderType { get; set; }

/// <summary>
///订单ID
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
///资源类型（非航班单选项I、可选项O、航班单选项无子订单F、航班单选项有子订单f、系统航班无子订单S、
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
///付款代码
/// </summary>
public string PaymentCode { get; set; }

/// <summary>
///成本;成人底价
/// </summary>
public decimal Cost { get; set; }

/// <summary>
///份数;成人份数
/// </summary>
public int Quantity { get; set; }

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
///阶梯价格ID
/// </summary>
public int PkgStepCostsID { get; set; }

/// <summary>
///儿童份数
/// </summary>
public int ChildQuantity { get; set; }

/// <summary>
///婴儿份数
/// </summary>
public int BabyQuantity { get; set; }

/// <summary>
///儿童底价
/// </summary>
public decimal ChildCost { get; set; }

/// <summary>
///婴儿底价
/// </summary>
public decimal BabyCost { get; set; }

/// <summary>
///提交状态，控制采购单是否需要供应商确认处理(提交：S，取消提交：C，默认—未提交/不需提交：N)
/// </summary>
public char VbSubmitStatus { get; set; }

/// <summary>
///供应商确认状态(接受：A，拒绝：R，默认--未处理：N)
/// </summary>
public char VbApproveStatus { get; set; }

/// <summary>
///出发城市名称
/// </summary>
public string StartCityName { get; set; }

/// <summary>
///订单联系人
/// </summary>
public string ContactName { get; set; }

/// <summary>
///预订日期
/// </summary>
public DateTime OrderDate { get; set; }

/// <summary>
///使用日期
/// </summary>
public DateTime UseDate { get; set; }

/// <summary>
///抵达日期
/// </summary>
public DateTime ArrivalDate { get; set; }

/// <summary>
///离开日期
/// </summary>
public DateTime DepartureDate { get; set; }

/// <summary>
///OP提交预订时的备注信息
/// </summary>
public string VbRemark { get; set; }

/// <summary>
///供应商处理采购单时的备注信息
/// </summary>
public string ConfirmRemark { get; set; }

/// <summary>
///成人数量
/// </summary>
public int AdultQuantity { get; set; }

/// <summary>
///成人底价
/// </summary>
public decimal AdultCost { get; set; }

/// <summary>
///供应商ID
/// </summary>
public int ProviderID { get; set; }

/// <summary>
///采购单结算币种
/// </summary>
public string Currency { get; set; }

/// <summary>
///汇率
/// </summary>
public decimal Exchange { get; set; }

/// <summary>
///预订单号
/// </summary>
public Guid OnlinePKID { get; set; }

/// <summary>
///vbk核对状态
/// </summary>
public char VbCollateStatus { get; set; }

/// <summary>
///核对时间
/// </summary>
public DateTime CollateDate { get; set; }

/// <summary>
///原始底价
/// </summary>
public decimal SourceCost { get; set; }

/// <summary>
///VBK修改单的原采购单id
/// </summary>
public int SourcePurchaseOrderID { get; set; }

/// <summary>
///
/// </summary>
public DateTime DataChange_LastTime { get; set; }


    }
}

