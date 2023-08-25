// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribePatternPerformanceResponseBody : TeaModel {
        /// <summary>
        /// The end time of the query. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The name of the performance metric value. Valid values:
        /// 
        /// *   When the `Key` parameter is set to `AnalyticDB_PatternQueryCount`, `pattern_query_count` is returned, which indicates the number of executions of the SQL statements in association with the SQL pattern.
        /// 
        /// *   When the `Key` value is `AnalyticDB_PatternQueryTime`, the following values are returned:
        /// 
        ///     *   `average_query_time`, which indicates the average total amount of time consumed by the SQL statements in association with the SQL pattern.
        ///     *   `max_query_time`, which indicates the maximum total amount of time consumed by the SQL statements in association with the SQL pattern.
        /// 
        /// *   When the `Key` value is `AnalyticDB_PatternExecutionTime`, the following values are returned:
        /// 
        ///     *   `average_execution_time`, which indicates the average execution duration of the SQL statements in association with the SQL pattern.
        ///     *   `max_execution_time`, which indicates the maximum execution duration of the SQL statements in association with the SQL pattern.
        /// 
        /// *   When the `Key` value is `AnalyticDB_PatternPeakMemory`, the following values are returned:
        /// 
        ///     *   `average_peak_memory`, which indicates the average peak memory usage of the SQL statements in association with the SQL pattern.
        ///     *   `max_peak_memory`, which indicates the maximum peak memory usage of the SQL statements in association with the SQL pattern.
        /// 
        /// *   When the `Key` value is `AnalyticDB_PatternScanSize`, the following values are returned:
        /// 
        ///     *   `average_scan_size`, which indicates the average amount of data scanned by the SQL statements in association with the SQL pattern.
        ///     *   `max_scan_size`, which indicates the maximum amount of data scanned by the SQL statements in association with the SQL pattern.
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribePatternPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribePatternPerformanceResponseBodyPerformances : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribePatternPerformanceResponseBodyPerformancesSeries> Series { get; set; }
            public class DescribePatternPerformanceResponseBodyPerformancesSeries : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

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
        /// The start time of the query. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
