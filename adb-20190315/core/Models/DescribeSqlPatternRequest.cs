// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSqlPatternRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the details of all AnalyticDB for MySQL clusters within a specified region, including cluster IDs.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The order by which to sort query results. Specify the parameter value in the JSON string format. Example: `[{"Field":"Pattern","Type":"Asc"}]`.
        /// 
        /// *   `Field` indicates the field that is used to sort the retrieved entries. Valid values:
        /// 
        ///     *   `Pattern` : the SQL pattern.
        ///     *   `AccessIP`: the IP address of the client.
        ///     *   `User`: the username.
        ///     *   `QueryCount`: the total number of queries.
        ///     *   `AvgPeakMemory`: the average peak memory. Unit: KB.
        ///     *   `MaxPeakMemory`: the maximum peak memory. Unit: KB.
        ///     *   `AvgCpuTime`: the average CPU time. Unit: milliseconds.
        ///     *   `MaxCpuTime`: the maximum CPU time. Unit: milliseconds.
        ///     *   `AvgStageCount`: the average number of stages.
        ///     *   `MaxStageCount`: the maximum number of stages.
        ///     *   `AvgTaskCount`: the average number of tasks.
        ///     *   `MaxTaskCount`: the maximum number of tasks.
        ///     *   `AvgScanSize`: the average scan size. Unit: KB.
        ///     *   `MaxScanSize`: the maximum scan size. Unit: KB.
        /// 
        /// *   `Type` indicates the sorting method. Valid values:
        /// 
        ///     *   `Asc`: ascending order.
        ///     *   `Desc`: descending order.
        /// 
        /// > *   If this parameter is not specified, query results are sorted in ascending order of `Pattern`.
        /// > *   If you need to sort query results by `AccessIP`, you must set the `Type` parameter to `accessip`. If you need to sort query results by `User`, you must leave the `Type` parameter empty or set it to `user`.
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
        /// The keyword contained in the SQL pattern.
        /// 
        /// >  If this parameter is not specified, all SQL patterns within an AnalyticDB for MySQL cluster for a date specified by `StartTime` are returned.
        /// </summary>
        [NameInMap("SqlPattern")]
        [Validation(Required=false)]
        public string SqlPattern { get; set; }

        /// <summary>
        /// The date to query. Specify the time in the *yyyy-MM-dd* format. The time must be in UTC.
        /// 
        /// >  Only data for the last 30 days can be queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The dimension by which to aggregate the SQL pattern. Valid values:
        /// 
        /// *   `user`: the user.
        /// *   `accessip`: the IP address of the client.
        /// 
        /// >  If this parameter is not specified, the SQL pattern is aggregated by `user`.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
