// -----------------------------------------------------------------------
// <copyright file="O_PkgOrder.cs" company="Microsoft">
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
    public class O_PkgOrderPO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "PkgOrderDB_SELECT.O_PkgOrder";
        public const string TABLE_NAME_INSERT = "PkgOrderDB_SAVE.O_PkgOrder";

        /// <summary>
///订单id
/// </summary>
public int OrderID { get; set; }

/// <summary>
///bbbb
/// </summary>
public int Pkg { get; set; }

/// <summary>
///度假产品名
/// </summary>
public string PkgName { get; set; }

/// <summary>
///订单时间
/// </summary>
public DateTime OrderDate { get; set; }

/// <summary>
///Ctrip用户名
/// </summary>
public string Uid { get; set; }

/// <summary>
///ctrip卡号
/// </summary>
public string CtripCardNo { get; set; }

/// <summary>
///订单操作员
/// </summary>
public string Eid { get; set; }

/// <summary>
///订单状态S 成交 P 处理中 C 取消 U 未提交 W 已提交待处理
/// </summary>
public char OrderStatus { get; set; }

/// <summary>
///处理状态0未操作1确认产品2确认客户4已发件 8已收款 16已付款64已取件128已出票 256已发
/// </summary>
public int ProcessStatus { get; set; }

/// <summary>
///底价货币
/// </summary>
public char Currency { get; set; }

/// <summary>
///房间折扣
/// </summary>
public decimal RoomDiscount { get; set; }

/// <summary>
///订单卖价
/// </summary>
public decimal Amount { get; set; }

/// <summary>
///订单底价
/// </summary>
public decimal Cost { get; set; }

/// <summary>
///收款方式
/// </summary>
public char PrepayType { get; set; }

/// <summary>
///出发日期
/// </summary>
public DateTime TakeoffDate { get; set; }

/// <summary>
///返回日期
/// </summary>
public DateTime ReturnDate { get; set; }

/// <summary>
///入住时间
/// </summary>
public DateTime Arrival { get; set; }

/// <summary>
///离店时间
/// </summary>
public DateTime Departure { get; set; }

/// <summary>
///包含酒店
/// </summary>
public char IncludingHotel { get; set; }

/// <summary>
///包含航班
/// </summary>
public char IncludingFlight { get; set; }

/// <summary>
///出发城市
/// </summary>
public int StartCity { get; set; }

/// <summary>
///酒店
/// </summary>
public int Hotel { get; set; }

/// <summary>
///房型
/// </summary>
public int Room { get; set; }

/// <summary>
///房间数
/// </summary>
public int RoomQty { get; set; }

/// <summary>
///航班选项
/// </summary>
public int FlightOption { get; set; }

/// <summary>
///成人数
/// </summary>
public int numAdult { get; set; }

/// <summary>
///儿童数
/// </summary>
public int numChild { get; set; }

/// <summary>
///婴儿数
/// </summary>
public int numBaby { get; set; }

/// <summary>
///不占床儿童数
/// </summary>
public int NumChildNoBed { get; set; }

/// <summary>
///联系人确认方式 NON不用确认 CSM短信确认 TEL电话确认 EML邮件确认 FAX传真确认
/// </summary>
public char ConfirmType { get; set; }

/// <summary>
///联系人姓名
/// </summary>
public string ContactName { get; set; }

/// <summary>
///联系人电话
/// </summary>
public string ContactTel { get; set; }

/// <summary>
///联系人传真
/// </summary>
public string ContactFax { get; set; }

/// <summary>
///联系人手机
/// </summary>
public string ContactMobile { get; set; }

/// <summary>
///联系人email
/// </summary>
public string ContactEmail { get; set; }

/// <summary>
///联系人地址
/// </summary>
public string ContactAddress { get; set; }

/// <summary>
///取票方式 SND市内配送 NUL不取不送 JOU邮寄行程单 EMS GET市内自取
/// </summary>
public char GetTicketType { get; set; }

/// <summary>
///产品类型 同产品
/// </summary>
public int Attrib1 { get; set; }

/// <summary>
///产品类型2
/// </summary>
public int Attrib2 { get; set; }

/// <summary>
///处理类型 T标准 F1非标准 F2团体 产品中默认T4 所以这里用T4
/// </summary>
public string Standard { get; set; }

/// <summary>
///备注
/// </summary>
public string Remarks { get; set; }

/// <summary>
///下单服务器
/// </summary>
public string ServerFrom { get; set; }

/// <summary>
///是否online
/// </summary>
public char IsOnline { get; set; }

/// <summary>
///紧急程度
/// </summary>
public short UrgencyLevel { get; set; }

/// <summary>
///处理时间
/// </summary>
public DateTime ProcessDeadLine { get; set; }

/// <summary>
///取消原因 MODIORDER重下修改单 CC_CLNT客户原因取消 CC_PRIC变价客户取消 FL
/// </summary>
public string CancelReason { get; set; }

/// <summary>
///操作描述
/// </summary>
public string ProcessDesc { get; set; }

/// <summary>
///处理状态 0未操作 1确认产品 2确认客户 4已发件 8已收款 16已付款 64已取件 128已出票
/// </summary>
public int PostStatus { get; set; }

/// <summary>
///成交日期
/// </summary>
public DateTime FinishDate { get; set; }

/// <summary>
///查询结果页的产品类型分类 All全部 GroupTravel团队游 FreedomToTravel自
/// </summary>
public char PkgType { get; set; }

/// <summary>
///送票时间
/// </summary>
public DateTime SendTicketETime { get; set; }

/// <summary>
///送票时间
/// </summary>
public DateTime SendTicketLTime { get; set; }

/// <summary>
///日期
/// </summary>
public DateTime FRADate { get; set; }

/// <summary>
///酒店描述
/// </summary>
public string HotelRemarks { get; set; }

/// <summary>
///抵用券金额
/// </summary>
public decimal EMoney { get; set; }

/// <summary>
///客户等级 0普通 10金牌 20白金 30钻石
/// </summary>
public short VipGrade { get; set; }

/// <summary>
///送票费用
/// </summary>
public decimal SendTicketFee { get; set; }

/// <summary>
///佣金比率
/// </summary>
public decimal commission { get; set; }

/// <summary>
///成人税
/// </summary>
public decimal adultTax { get; set; }

/// <summary>
///儿童税
/// </summary>
public decimal childTax { get; set; }

/// <summary>
///酒店推荐级别
/// </summary>
public int Recommend { get; set; }

/// <summary>
///供应商确认时间
/// </summary>
public int ProvConfirmTime { get; set; }

/// <summary>
///未知
/// </summary>
public char BalPeriod { get; set; }

/// <summary>
///返佣类型 1扣除 2后返 对应表PkgAgent_Balance的balance字段
/// </summary>
public char CommissionType { get; set; }

/// <summary>
///特殊标志 1南航产品 17招商银行活动产品 18团对行 
/// </summary>
public int SpecType { get; set; }

/// <summary>
///产品形态
/// </summary>
public char TypeDesc { get; set; }

/// <summary>
///付款申请单id
/// </summary>
public int BillheadID { get; set; }

/// <summary>
///机票税
/// </summary>
public decimal flighttax { get; set; }

/// <summary>
///机票卖价
/// </summary>
public decimal FltAmount { get; set; }

/// <summary>
///机票成本
/// </summary>
public decimal FltCost { get; set; }

/// <summary>
///酒店卖价
/// </summary>
public decimal HtlAmount { get; set; }

/// <summary>
///酒店底价
/// </summary>
public decimal HtlCost { get; set; }

/// <summary>
///原价
/// </summary>
public decimal OldAmount { get; set; }

/// <summary>
///底价
/// </summary>
public decimal OldCost { get; set; }

/// <summary>
///保证金
/// </summary>
public decimal bail { get; set; }

/// <summary>
///报价修正
/// </summary>
public decimal priceAdjust { get; set; }

/// <summary>
///最晚客户确认时间
/// </summary>
public int clientConfirmTime { get; set; }

/// <summary>
///是否有保证金
/// </summary>
public bool IsBail { get; set; }

/// <summary>
///最后备份日期
/// </summary>
public DateTime LateBackDate { get; set; }

/// <summary>
///儿童卖价调整
/// </summary>
public decimal chdPriceAdjust { get; set; }

/// <summary>
///?保证金
/// </summary>
public decimal allbail { get; set; }

/// <summary>
///底价币种
/// </summary>
public char FCurrency { get; set; }

/// <summary>
///个人电子帐户支付金
/// </summary>
public decimal FCost { get; set; }

/// <summary>
///最后收款日期
/// </summary>
public DateTime LastPayDate { get; set; }

/// <summary>
///是否备份订单
/// </summary>
public char IsBankUp { get; set; }

/// <summary>
///是否确认
/// </summary>
public char IsConfirm { get; set; }

/// <summary>
///是否有子定单
/// </summary>
public char IsSuperOrder { get; set; }

/// <summary>
///是否有酒店子定单
/// </summary>
public char IsNoHotelsuborer { get; set; }

/// <summary>
///ems邮编
/// </summary>
public string CntactEMSZip { get; set; }

/// <summary>
///内部id
/// </summary>
public char IsIncUid { get; set; }

/// <summary>
///下单ip
/// </summary>
public string IP { get; set; }

/// <summary>
///分期付款
/// </summary>
public int CardMonth { get; set; }

/// <summary>
///分期付款佣金
/// </summary>
public float MonthCommission { get; set; }

/// <summary>
///是否团队订单
/// </summary>
public char IsTour { get; set; }

/// <summary>
///1现金 32信用卡 1和32 33现金和信用卡
/// </summary>
public int PaymentType { get; set; }

/// <summary>
///行政区
/// </summary>
public int Canton { get; set; }

/// <summary>
///操作描述
/// </summary>
public string OperateModule { get; set; }

/// <summary>
///带驾用车成人数
/// </summary>
public int TaxiAdultNum { get; set; }

/// <summary>
///外国手机
/// </summary>
public string ForeignMobile { get; set; }

/// <summary>
///语言
/// </summary>
public string lang { get; set; }

/// <summary>
///是否领队订单
/// </summary>
public char IsLeadorder { get; set; }

/// <summary>
///是否国程订单
/// </summary>
public char isAirChina { get; set; }

/// <summary>
///卡系统
/// </summary>
public char CCardSystem { get; set; }

/// <summary>
///渠道id
/// </summary>
public int Sourceid { get; set; }

/// <summary>
///销售员id
/// </summary>
public string Sales { get; set; }

/// <summary>
///是否机酒套餐订单
/// </summary>
public char IsFlightelOrder { get; set; }

/// <summary>
///未知
/// </summary>
public char UnSystemOrder { get; set; }

/// <summary>
///未知
/// </summary>
public DateTime SetOutTime { get; set; }

/// <summary>
///收银唯一标识 现在不用
/// </summary>
public Guid ReceiptGuid { get; set; }

/// <summary>
///支付方式 支付方式编码 TravelMoney=游票 EMoney=抵用券
/// </summary>
public string PaymentWayID { get; set; }

/// <summary>
///支付子系统ID 1=CASH 现金类支付 2=CARD 银行卡支付 3=THIRD 第三方支付 4=
/// </summary>
public int SubPaySystem { get; set; }

/// <summary>
///游票
/// </summary>
public decimal TMoney { get; set; }

/// <summary>
///预定类型 欧铁预定-EUR机票 酒店预订-AHD度假预定-PKG
/// </summary>
public char BookingType { get; set; }

/// <summary>
///未知
/// </summary>
public string ExtLink { get; set; }

/// <summary>
///供应商ID
/// </summary>
public string Supplier { get; set; }

/// <summary>
///支付方式
/// </summary>
public int ConfirmWay { get; set; }

/// <summary>
///收款方式 0 预付费 1 前台现付 默认值为0
/// </summary>
public int ChargeType { get; set; }

/// <summary>
///产品是否返现
/// </summary>
public char IsbackCash { get; set; }

/// <summary>
///自由行套餐类别 1 自由行套餐包低价套餐 2 自由行套餐包常规套餐 3 自由行DIY 
/// </summary>
public int BookingSpecialType { get; set; }

/// <summary>
///开票城市
/// </summary>
public int InvoiceCity { get; set; }

/// <summary>
///存放“PKG_LEDGER_CTRIP”，“PKG_LEDGER_HHTRAVEL” 隐藏模块NAM
/// </summary>
public string Ledger { get; set; }

/// <summary>
///Onilne我的携程中是否可见：T 可见，F不可见；默认可见
/// </summary>
public char DisplayInOnline { get; set; }

/// <summary>
///尽量安排大床（T-大床、F-双床、Null-无要求，默认值）
/// </summary>
public char BigBedFirst { get; set; }

/// <summary>
///订单人工处理标识
/// </summary>
public int ManualFlag { get; set; }

/// <summary>
///尽量安排无烟房（T-无烟房、F-无要求，默认为F）
/// </summary>
public char NoSmokingRoomFirst { get; set; }

/// <summary>
///产品模式 “代理模式” ：S 自研自售;O OEM自售;P 代理模式;G 联合发团;
/// </summary>
public char PkgSaleMode { get; set; }

/// <summary>
///机加车订单机票订单号
/// </summary>
public int MFlightOrder { get; set; }

/// <summary>
///接机牌
/// </summary>
public string PickUpCard { get; set; }

/// <summary>
///风控状态 0 待风控处理（默认新增订单的状态）1 风控申请中（首次风控申请后的状态）2 风控异常(有
/// </summary>
public short RiskStatus { get; set; }

/// <summary>
///订单销售额抵充
/// </summary>
public decimal OrderAmountAgainst { get; set; }

/// <summary>
///过滤处理超时时间，默认为预订时间 5分钟（时长可配置）
/// </summary>
public DateTime AutoFilterOverTime { get; set; }

/// <summary>
///0：待过滤处理（默认新订单的状态）1：过滤处理中2：过滤完成
/// </summary>
public int AutoFilterStatus { get; set; }

/// <summary>
///风控开始时间，用于判断是否需要重置风控状态
/// </summary>
public DateTime RiskStartTime { get; set; }

/// <summary>
///产品内部使用名称
/// </summary>
public string VendorProductName { get; set; }

/// <summary>
///售卖城市ID
/// </summary>
public int SalesCity { get; set; }

/// <summary>
///是否采用Bill单：T，是；F，否
/// </summary>
public char IsBillOrder { get; set; }

/// <summary>
///是否信用卡分期：T，是；F，否
/// </summary>
public char IsCreditCardDivided { get; set; }

/// <summary>
///onlien预订时的临时订单ID
/// </summary>
public int TmpOrderID { get; set; }

/// <summary>
///现金账户金额
/// </summary>
public decimal CachAccount { get; set; }

/// <summary>
///订单售卖模式：0-产品售卖、1-套餐打包售卖（自行行、机酒）、2-资源裸卖
/// </summary>
public int OrderSaleMode { get; set; }

/// <summary>
///是否显示T：显示，F：隐藏，默认显示
/// </summary>
public char IsDisplay { get; set; }

/// <summary>
///目的城市
/// </summary>
public int DestCity { get; set; }

/// <summary>
///
/// </summary>
public DateTime DataChange_LastTime { get; set; }


    }
}

