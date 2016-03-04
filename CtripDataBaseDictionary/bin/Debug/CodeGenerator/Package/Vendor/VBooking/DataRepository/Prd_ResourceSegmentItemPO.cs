// -----------------------------------------------------------------------
// <copyright file="Prd_ResourceSegmentItem.cs" company="Microsoft">
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
    public class Prd_ResourceSegmentItemPO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "PkgInputDB_SELECT.Prd_ResourceSegmentItem";
        public const string TABLE_NAME_INSERT = "PkgInputDB_SAVE.Prd_ResourceSegmentItem";

        /// <summary>
///自增主键
/// </summary>
public int ID { get; set; }

/// <summary>
///行程段编号,对应Prd_ResourceSegment主键
/// </summary>
public int SegmentID { get; set; }

/// <summary>
///自费项目名称
/// </summary>
public string Name { get; set; }

/// <summary>
///参考价格
/// </summary>
public string ReferencePrice { get; set; }

/// <summary>
///详情/备注
/// </summary>
public string Detail { get; set; }

/// <summary>
///排序号
/// </summary>
public int SequenceNum { get; set; }

/// <summary>
///创建时间
/// </summary>
public DateTime CreateTime { get; set; }

/// <summary>
///更新时间
/// </summary>
public DateTime ModifyTime { get; set; }

/// <summary>
///
/// </summary>
public DateTime DataChange_LastTime { get; set; }


    }
}

