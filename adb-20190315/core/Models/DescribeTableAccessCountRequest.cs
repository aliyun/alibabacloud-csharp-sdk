// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTableAccessCountRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the details of all AnalyticDB for MySQL clusters within a specified region, including cluster IDs.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The order by which to sort query results. Specify the parameter value in the JSON string format. Example: `[{"Field":"TableSchema","Type":"Asc"}]`.
        /// 
        /// *   `Field` indicates the field that is used to sort the retrieved entries. Valid values:
        /// 
        ///     *   `TableSchema`: the name of the database to which the table belongs.
        ///     *   `TableName`: the name of the table.
        ///     *   `AccessCount`: the number of accesses to the table.
        /// 
        /// *   `Type` indicates the sorting method. Valid values:
        /// 
        ///     *   `Asc`: ascending order.
        ///     *   `Desc`: descending order.
        /// 
        /// >  If this parameter is not specified, query results are sorted in ascending order of the database to which a specific table belongs.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. The value must be a positive integer. Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// >  You can call the [DescribeRegions](~~143074~~) operation to query the regions and zones supported by AnalyticDB for MySQL, including region IDs.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The date to query. Specify the time in the *yyyy-MM-dd* format. The time must be in UTC.
        /// 
        /// >  Only data for the last 30 days can be queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The name of the specific table.
        /// 
        /// >  If this parameter is not specified, the number of accesses to all tables within the specified cluster for a specified date is returned.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
