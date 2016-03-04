// -----------------------------------------------------------------------
// <copyright file="Finance_PaymentVoucher.cs" company="Microsoft">
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
    public class Finance_PaymentVoucherPO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "PkgOrderDB_SELECT.Finance_PaymentVoucher";
        public const string TABLE_NAME_INSERT = "PkgOrderDB_SAVE.Finance_PaymentVoucher";

        /// <summary>
///应付凭证ID
/// </summary>
public int PaymentVoucherID { get; set; }

/// <summary>
///来源单据号
/// </summary>
public int SourceOrderID { get; set; }

/// <summary>
///来源单据类型（采购子订单P，退款D）
/// </summary>
public char SourceOrderType { get; set; }

/// <summary>
///订单号
/// </summary>
public int OrderID { get; set; }

/// <summary>
///供应商ID
/// </summary>
public int ProviderID { get; set; }

/// <summary>
///金额
/// </summary>
public decimal Amount { get; set; }

/// <summary>
///币种
/// </summary>
public string Currency { get; set; }

/// <summary>
///汇率
/// </summary>
public decimal Exchange { get; set; }

/// <summary>
///结算方式（月结W，单结B，周结W）
/// </summary>
public char ProviderBlncPeriod { get; set; }

/// <summary>
///支付类型
/// </summary>
public int PaymentType { get; set; }

/// <summary>
///支付代码
/// </summary>
public string PaymentCode { get; set; }

/// <summary>
///是否有效（T-有效;F-无效）
/// </summary>
public char IsValid { get; set; }

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
/// 0:根据采购子订单生成的单选项可选项凭证 1:供应商退款 2:供应商补款 
/// </summary>
public int Type { get; set; }

/// <summary>
///结算处理批次号码
/// </summary>
public string BatchNumber { get; set; }

/// <summary>
///激活标志，激活的凭证才能进入结算系统进行结算;
T-激活/F-未激活，默认激活（T或空）
/// </summary>
public char Active { get; set; }

/// <summary>
///结算状态，结算系统根据BatchNumber回写该状态;
T-已结算/F-未结算，默认未结算（F或
/// </summary>
public char BalanceType { get; set; }

/// <summary>
///结算操作人，结算系统回写
/// </summary>
public string BalanceOperator { get; set; }

/// <summary>
///结算操作时间，结算系统回写
/// </summary>
public DateTime BalanceOperateTime { get; set; }

/// <summary>
///对接结算平台的提交状态，T-已提交，F/NULL-未提交
/// </summary>
public char BalanceSubmitStatus { get; set; }

/// <summary>
///
/// </summary>
public DateTime DataChange_LastTime { get; set; }


    }
}

