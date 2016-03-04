// -----------------------------------------------------------------------
// <copyright file="City.cs" company="Microsoft">
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
    public class CityPO : ITableEntity
    {
        public const string TABLE_NAME_SELECT = "PkgPubDB_SELECT.City";
        public const string TABLE_NAME_INSERT = "PkgPubDB_SAVE.City";

        /// <summary>
///
/// </summary>
public int City { get; set; }

/// <summary>
///
/// </summary>
public string CityName { get; set; }

/// <summary>
///
/// </summary>
public int Province { get; set; }

/// <summary>
///
/// </summary>
public int Country { get; set; }

/// <summary>
///
/// </summary>
public char Citycode { get; set; }

/// <summary>
///
/// </summary>
public char ToTrain { get; set; }

/// <summary>
///
/// </summary>
public char ToShip { get; set; }

/// <summary>
///
/// </summary>
public char TripStatus { get; set; }

/// <summary>
///
/// </summary>
public char ename { get; set; }

/// <summary>
///
/// </summary>
public char weather { get; set; }

/// <summary>
///
/// </summary>
public int hotelprovince { get; set; }

/// <summary>
///
/// </summary>
public DateTime DataChange_LastTime { get; set; }


    }
}

