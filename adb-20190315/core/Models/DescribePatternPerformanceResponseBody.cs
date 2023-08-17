// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribePatternPerformanceResponseBody : TeaModel {
        /// <summary>
        /// The end time of the query. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The queried performance metrics.
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribePatternPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribePatternPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// The performance metric that was queried. Valid values:
            /// 
            /// *   **AnalyticDB_PatternQueryCount**: the total number of queries executed in association with the SQL pattern.
            /// *   **AnalyticDB_PatternQueryTime**: the total amount of time consumed by the queries executed in association with the SQL pattern.
            /// *   **AnalyticDB_PatternExecutionTime**: the total execution duration of the queries executed in association with the SQL pattern.
            /// *   **AnalyticDB_PatternPeakMemory**: the peak memory usage of the queries executed in association with the SQL pattern.
            /// *   **AnalyticDB_PatternScanSize**: the amount of data scanned in the queries executed in association with the SQL pattern.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The queried performance metrics.
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribePatternPerformanceResponseBodyPerformancesSeries> Series { get; set; }
            public class DescribePatternPerformanceResponseBodyPerformancesSeries : TeaModel {
                /// <summary>
                /// The name of the performance metric value. Valid values:
                /// 
                /// *   When the `Key` parameter is set to `AnalyticDB_PatternQueryCount`, `pattern_query_count` is returned, which indicates the number of executions of the SQL statements in association with the SQL pattern.
                /// 
                /// *   When the `Key` parameter is set to `AnalyticDB_PatternQueryTime`, the following values are returned:
                /// 
                ///     *   `average_query_time`, which indicates the average total amount of time consumed by the SQL statements in association with the SQL pattern.
                ///     *   `max_query_time`, which indicates the maximum total amount of time consumed by the SQL statements in association with the SQL pattern.
                /// 
                /// *   When the `Key` parameter is set to `AnalyticDB_PatternExecutionTime`, the following values are returned:
                /// 
                ///     *   `average_execution_time`, which indicates the average execution duration of the SQL statements in association with the SQL pattern.
                ///     *   `max_execution_time`, which indicates the maximum execution duration of the SQL statements in association with the SQL pattern.
                /// 
                /// *   When the `Key` parameter is set to `AnalyticDB_PatternPeakMemory`, the following values are returned:
                /// 
                ///     *   `average_peak_memory`, which indicates the average peak memory usage of the SQL statements in association with the SQL pattern.
                ///     *   `max_peak_memory`, which indicates the maximum peak memory usage of the SQL statements in association with the SQL pattern.
                /// 
                /// *   When the `Key` parameter is set `AnalyticDB_PatternScanSize`, the following values are returned:
                /// 
                ///     *   `average_scan_size`, which indicates the average amount of data scanned by the SQL statements in association with the SQL pattern.
                ///     *   `max_scan_size`, which indicates the maximum amount of data scanned by the SQL statements in association with the SQL pattern.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The queried performance metrics.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// The unit of the performance metric. Valid values:
            /// 
            /// *   When the performance metric is related to the query duration (the `Key` value is `AnalyticDB_PatternQueryTime` or `AnalyticDB_PatternExecutionTime`), **ms** is returned.
            /// *   When the performance metric is related to the memory usage (the `Key` value is `AnalyticDB_PatternPeakMemory`), **MB** is returned.
            /// *   When the performance metric is related to the amount of data scanned (the `Key` value is `AnalyticDB_PatternScanSize`), **MB** is returned.
            /// *   When the performance metric is related to the number of queries (the `Key` value is `AnalyticDB_PatternQueryCount`), this parameter is empty.
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start time of the query. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
