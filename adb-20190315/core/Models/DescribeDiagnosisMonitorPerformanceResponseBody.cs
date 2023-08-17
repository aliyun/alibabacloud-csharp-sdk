// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDiagnosisMonitorPerformanceResponseBody : TeaModel {
        /// <summary>
        /// The monitoring information of queries displayed in Gantt charts.
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisMonitorPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribeDiagnosisMonitorPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// The total amount of time consumed by the query. Unit: milliseconds.
            /// 
            /// >  This parameter indicates the sum of `QueuedTime`, `TotalPlanningTime`, and `ExecutionTime`.
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public long? Cost { get; set; }

            /// <summary>
            /// The peak memory of the query. Unit: bytes.
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            /// <summary>
            /// The ID of the query.
            /// 
            /// >  You can call the [DescribeProcessList](~~143382~~) operation to query the IDs of queries that are being executed.
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// The IP address of the AnalyticDB for MySQL frontend node on which the SQL statement is executed.
            /// </summary>
            [NameInMap("RcHost")]
            [Validation(Required=false)]
            public string RcHost { get; set; }

            /// <summary>
            /// The number of entries scanned.
            /// </summary>
            [NameInMap("ScanRows")]
            [Validation(Required=false)]
            public long? ScanRows { get; set; }

            /// <summary>
            /// The amount of scanned data. Unit: bytes.
            /// </summary>
            [NameInMap("ScanSize")]
            [Validation(Required=false)]
            public long? ScanSize { get; set; }

            /// <summary>
            /// The execution start time of the SQL statement. The time is in the UNIX timestamp format. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The state of the SQL statement. Valid values:
            /// 
            /// *   **running**
            /// *   **finished**
            /// *   **failed**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The database account that is used to submit the query.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The threshold for the number of queries displayed in a Gantt chart. The default value is 10000.
        /// 
        /// >  A maximum of 10,000 queries can be displayed in a Gantt chart even if more queries exist.
        /// </summary>
        [NameInMap("PerformancesThreshold")]
        [Validation(Required=false)]
        public int? PerformancesThreshold { get; set; }

        /// <summary>
        /// Indicates whether all queries are returned. Valid values:
        /// 
        /// *   true: All queries are returned.
        /// *   false: Only a specified number of queries are returned.
        /// </summary>
        [NameInMap("PerformancesTruncated")]
        [Validation(Required=false)]
        public bool? PerformancesTruncated { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
