// -----------------------------------------------------------------------
// <copyright file="PkgSalesCity.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Ctrip.Mobile.Tour.DataRepository.PO.PkgPubDB
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Package.Framework2.Data;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PkgSalesCityPO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "PkgPubDB_SELECT.PkgSalesCity";
        public const string TABLE_NAME_INSERT = "PkgPubDB_SAVE.PkgSalesCity";

        /// <summary>
///城市编号
/// </summary>
public int City { get; set; }

/// <summary>
///上级城市编号
/// </summary>
public int ParentCity { get; set; }

/// <summary>
///是否上线,T-上线,F-下线
/// </summary>
public string IsOnline { get; set; }

/// <summary>
///创建时间
/// </summary>
public DateTime DataChange_CreateTime { get; set; }

/// <summary>
///更新时间
/// </summary>
public DateTime DataChange_LastTime { get; set; }

/// <summary>
///经度
/// </summary>
public decimal Longitude { get; set; }

/// <summary>
///纬度
/// </summary>
public decimal Latitude { get; set; }


    }
}

