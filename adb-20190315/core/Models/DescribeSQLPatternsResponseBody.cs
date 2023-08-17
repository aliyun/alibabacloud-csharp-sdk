// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPatternsResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The queried SQL patterns.
        /// </summary>
        [NameInMap("PatternDetails")]
        [Validation(Required=false)]
        public List<DescribeSQLPatternsResponseBodyPatternDetails> PatternDetails { get; set; }
        public class DescribeSQLPatternsResponseBodyPatternDetails : TeaModel {
            /// <summary>
            /// The IP address of the SQL client that commits the SQL pattern.
            /// </summary>
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            /// <summary>
            /// The average execution duration of the SQL pattern within the query time range. Unit: milliseconds.
            /// </summary>
            [NameInMap("AverageExecutionTime")]
            [Validation(Required=false)]
            public double? AverageExecutionTime { get; set; }

            /// <summary>
            /// The average peak memory usage of the SQL pattern within the query time range. Unit: bytes.
            /// </summary>
            [NameInMap("AveragePeakMemory")]
            [Validation(Required=false)]
            public double? AveragePeakMemory { get; set; }

            /// <summary>
            /// The average total amount of time consumed by the SQL pattern within the query time range. Unit: milliseconds.
            /// </summary>
            [NameInMap("AverageQueryTime")]
            [Validation(Required=false)]
            public double? AverageQueryTime { get; set; }

            /// <summary>
            /// The average amount of data scanned based on the SQL pattern within the query time range. Unit: bytes.
            /// </summary>
            [NameInMap("AverageScanSize")]
            [Validation(Required=false)]
            public double? AverageScanSize { get; set; }

            /// <summary>
            /// Indicates whether the execution of the SQL pattern can be blocked. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// > Only SELECT and INSERT statements can be blocked.
            /// </summary>
            [NameInMap("Blockable")]
            [Validation(Required=false)]
            public bool? Blockable { get; set; }

            /// <summary>
            /// The number of failed queries executed in association with the SQL pattern within the query time range.
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }

            /// <summary>
            /// The maximum execution duration of the SQL pattern within the query time range. Unit: milliseconds.
            /// </summary>
            [NameInMap("MaxExecutionTime")]
            [Validation(Required=false)]
            public long? MaxExecutionTime { get; set; }

            /// <summary>
            /// The maximum peak memory usage of the SQL pattern within the query time range. Unit: bytes.
            /// </summary>
            [NameInMap("MaxPeakMemory")]
            [Validation(Required=false)]
            public long? MaxPeakMemory { get; set; }

            /// <summary>
            /// The maximum total amount of time consumed by the SQL pattern within the query time range. Unit: milliseconds.
            /// </summary>
            [NameInMap("MaxQueryTime")]
            [Validation(Required=false)]
            public long? MaxQueryTime { get; set; }

            /// <summary>
            /// The maximum amount of data scanned based on the SQL pattern within the query time range. Unit: bytes.
            /// </summary>
            [NameInMap("MaxScanSize")]
            [Validation(Required=false)]
            public long? MaxScanSize { get; set; }

            /// <summary>
            /// The earliest commit time of the SQL pattern within the query time range. Unit: milliseconds.
            /// </summary>
            [NameInMap("PatternCreationTime")]
            [Validation(Required=false)]
            public string PatternCreationTime { get; set; }

            /// <summary>
            /// The ID of the SQL pattern.
            /// </summary>
            [NameInMap("PatternId")]
            [Validation(Required=false)]
            public string PatternId { get; set; }

            /// <summary>
            /// The number of queries executed in association with the SQL pattern within the query time range.
            /// </summary>
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public long? QueryCount { get; set; }

            /// <summary>
            /// The statement of the SQL pattern.
            /// </summary>
            [NameInMap("SQLPattern")]
            [Validation(Required=false)]
            public string SQLPattern { get; set; }

            /// <summary>
            /// The tables scanned based on the SQL pattern.
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public string Tables { get; set; }

            /// <summary>
            /// The database username that is used to commit the SQL pattern.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
