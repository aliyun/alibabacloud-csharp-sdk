// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPatternsRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to query the information about all AnalyticDB for MySQL clusters in a region, including cluster IDs.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The keyword that is used for the query.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The language of file titles and error messages. Valid values:
        /// 
        /// *   **zh** (default): simplified Chinese.
        /// *   **en**: English.
        /// *   **ja**: Japanese.
        /// *   **zh-tw**: traditional Chinese.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The order by which to sort query results. Specify the parameter value in the JSON format. Example: `[{"Field":"AverageQueryTime","Type":"Asc"}]`.
        /// 
        /// *   `Field` specifies the field by which to sort the query results. Valid values:
        /// 
        ///     *   `PatternCreationTime`: the earliest commit time of the SQL pattern within the time range to query.
        ///     *   `AverageQueryTime`: the average total amount of time consumed by the SQL pattern within the time range to query.
        ///     *   `MaxQueryTime`: the maximum total amount of time consumed by the SQL pattern within the time range to query.
        ///     *   `AverageExecutionTime`: the average execution duration of the SQL pattern within the time range to query.
        ///     *   `MaxExecutionTime`: the maximum execution duration of the SQL pattern within the time range to query.
        ///     *   `AveragePeakMemory`: the average peak memory usage of the SQL pattern within the time range to query.
        ///     *   `MaxPeakMemory`: the maximum peak memory usage of the SQL pattern within the time range to query.
        ///     *   `AverageScanSize`: the average amount of data scanned based on the SQL pattern within the time range to query.
        ///     *   `MaxScanSize`: the maximum amount of data scanned based on the SQL pattern within the time range to query.
        ///     *   `QueryCount`: the number of queries performed in association with the SQL pattern within the time range to query.
        ///     *   `FailedCount`: the number of failed queries performed in association with the SQL pattern within the time range to query.
        /// 
        /// *   `Type` specifies the sorting order. Valid values (case-insensitive):
        /// 
        ///     *   `Asc`: ascending order.
        ///     *   `Desc`: descending order.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// 
        /// > If you do not specify this parameter, the value **1** is used.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   **30**
        /// *   **50**
        /// *   **100**
        /// 
        /// > If you do not specify this parameter, the value **30** is used.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// > You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time must be in UTC.
        /// 
        /// > 
        /// 
        /// *   Only data within the last 14 days can be queried. For example, if the current time is 2021-11-22T12:00:00Z, you can query SQL patterns at a point in time as early as 2021-11-09T12:00:00Z.
        /// 
        /// *   The maximum time range that can be specified is 24 hours.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
