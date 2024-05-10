// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSqlPatternRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// > You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/454250.html) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The order by which to sort query results. Specify the parameter value in the JSON string format. Example: `[{"Field":"Pattern","Type":"Asc"}]`. Parameters:
        /// 
        /// *   `Field` specifies the field by which to sort the query results. Valid values:
        /// 
        ///     *   `Pattern`: the SQL pattern.
        ///     *   `AccessIP`: the IP address of the client.
        ///     *   `User`: the username.
        ///     *   `QueryCount`: the number of queries performed in association with the SQL pattern within the time range to query.
        ///     *   `AvgPeakMemory`: the average peak memory usage of the SQL pattern within the time range to query. Unit: KB.
        ///     *   `MaxPeakMemory`: the maximum peak memory usage of the SQL pattern within the time range to query. Unit: KB.
        ///     *   `AvgCpuTime`: the average execution duration of the SQL pattern within the time range to query. Unit: milliseconds.
        ///     *   `MaxCpuTime`: the maximum execution duration of the SQL pattern within the time range to query. Unit: milliseconds.
        ///     *   `AvgStageCount`: the average number of stages.
        ///     *   `MaxStageCount`: the maximum number of stages.
        ///     *   `AvgTaskCount`: the average number of tasks.
        ///     *   `MaxTaskCount`: the maximum number of tasks.
        ///     *   `AvgScanSize`: the average amount of data scanned based on the SQL pattern within the time range to query. Unit: KB.
        ///     *   `MaxScanSize`: the maximum amount of data scanned based on the SQL pattern within the time range to query. Unit: KB.
        /// 
        /// *   `Type` specifies the sorting order. Valid values:
        /// 
        ///     *   `Asc`: ascending order.
        ///     *   `Desc`: descending order.
        /// 
        /// > 
        /// 
        /// *   If you do not specify this parameter, query results are sorted in ascending order of `Pattern`.
        /// 
        /// *   If you want to sort query results by `AccessIP`, you must set the `Type` parameter to `accessip`. If you want to sort query results by `User`, you must leave the `Type` parameter empty or set it to `user`.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   **10** (default)
        /// *   **30**
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The keyword that is used for the query.
        /// 
        /// > If you do not specify this parameter, all SQL patterns of the AnalyticDB for MySQL cluster within the time period specified by `StartTime` are returned.
        /// </summary>
        [NameInMap("SqlPattern")]
        [Validation(Required=false)]
        public string SqlPattern { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-dd format. The time must be in UTC.
        /// 
        /// > Only data within the last 30 days can be queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The dimension by which to aggregate the SQL patterns. Valid values:
        /// 
        /// *   `user`: aggregates the SQL patterns by user.
        /// *   `accessip`: aggregates the SQL patterns by client IP address.
        /// 
        /// > If you do not specify this parameter, the SQL patterns are aggregated by `user`.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
