// -----------------------------------------------------------------------
// <copyright file="TravelItem.cs" company="Microsoft">
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
    public class TravelItemPO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "PkgInputDB_SELECT.TravelItem";
        public const string TABLE_NAME_INSERT = "PkgInputDB_SAVE.TravelItem";

        /// <summary>
///主键ID
/// </summary>
public int TravelItemID { get; set; }

/// <summary>
///供应商编号
/// </summary>
public int ProviderID { get; set; }

/// <summary>
///资源ID
/// </summary>
public int ResourceId { get; set; }

/// <summary>
///线路的资源ID
/// </summary>
public int LineResourceId { get; set; }

/// <summary>
///团队选项类型(Ride-发车信息, Service-附加服务, Package-套餐)
/// </summary>
public string TravelItemType { get; set; }

/// <summary>
///团队选项名称
/// </summary>
public string TravelItemName { get; set; }

/// <summary>
///团队选项描述
/// </summary>
public string TravelItemRemark { get; set; }

/// <summary>
///适用哪一天
/// </summary>
public int AppliedDay { get; set; }

/// <summary>
///是否人数限制(T-是,F-否)
/// </summary>
public string IsPersonLimit { get; set; }

/// <summary>
///最少人数
/// </summary>
public int MinPerson { get; set; }

/// <summary>
///最多人数
/// </summary>
public int MaxPerson { get; set; }

/// <summary>
///售卖状态(Start-正在售卖,Stop-停止售卖)
/// </summary>
public string SaleStatus { get; set; }

/// <summary>
///上车地点
/// </summary>
public string RideLocation { get; set; }

/// <summary>
///发车时间
/// </summary>
public string RideTime { get; set; }

/// <summary>
///固定价格
/// </summary>
public decimal FixedPrice { get; set; }

/// <summary>
///选项分组
/// </summary>
public string TravelItemGroup { get; set; }

/// <summary>
///供应商原始产品名称/编号
/// </summary>
public string ProviderProductName { get; set; }

/// <summary>
///创建时间
/// </summary>
public DateTime DataChange_CreateTime { get; set; }

/// <summary>
///修改时间
/// </summary>
public DateTime DateChange_LastTime { get; set; }

/// <summary>
///该日行程客人可选择不升级(T-不升级,F-升级)
/// </summary>
public string IsAppliedDayNotUpgrade { get; set; }

/// <summary>
///供应商团队选项编号
/// </summary>
public string VendorItemID { get; set; }

/// <summary>
///是否有效
/// </summary>
public string Active { get; set; }


    }
}

