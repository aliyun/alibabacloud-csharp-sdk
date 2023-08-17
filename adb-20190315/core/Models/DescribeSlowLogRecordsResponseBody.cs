// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Details of the slow query logs.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("SlowLogRecord")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsSlowLogRecord> SlowLogRecord { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsSlowLogRecord : TeaModel {
                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// The time when the execution started. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ExecutionStartTime")]
                [Validation(Required=false)]
                public string ExecutionStartTime { get; set; }

                /// <summary>
                /// The IP address of the client that is used to connect to the database.
                /// </summary>
                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                /// <summary>
                /// The amount of output data in the task. Unit: bytes.
                /// </summary>
                [NameInMap("OutputSize")]
                [Validation(Required=false)]
                public string OutputSize { get; set; }

                /// <summary>
                /// The number of rows parsed by the SQL statement.
                /// </summary>
                [NameInMap("ParseRowCounts")]
                [Validation(Required=false)]
                public long? ParseRowCounts { get; set; }

                /// <summary>
                /// The maximum memory usage when the SQL statement is executed. Unit: KB.
                /// </summary>
                [NameInMap("PeakMemoryUsage")]
                [Validation(Required=false)]
                public string PeakMemoryUsage { get; set; }

                /// <summary>
                /// The amount of time consumed to generate execution plans. Unit: milliseconds.
                /// </summary>
                [NameInMap("PlanningTime")]
                [Validation(Required=false)]
                public long? PlanningTime { get; set; }

                /// <summary>
                /// The ID of the process.
                /// </summary>
                [NameInMap("ProcessID")]
                [Validation(Required=false)]
                public string ProcessID { get; set; }

                /// <summary>
                /// The time consumed to execute the SQL statement. Unit: milliseconds.
                /// </summary>
                [NameInMap("QueryTime")]
                [Validation(Required=false)]
                public long? QueryTime { get; set; }

                /// <summary>
                /// The queuing duration before the query is executed. Unit: milliseconds.
                /// </summary>
                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public long? QueueTime { get; set; }

                /// <summary>
                /// The number of rows returned by the SQL statement.
                /// </summary>
                [NameInMap("ReturnRowCounts")]
                [Validation(Required=false)]
                public long? ReturnRowCounts { get; set; }

                /// <summary>
                /// Details of the SQL statement.
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                /// <summary>
                /// The number of rows scanned from a data source in the task.
                /// </summary>
                [NameInMap("ScanRows")]
                [Validation(Required=false)]
                public long? ScanRows { get; set; }

                /// <summary>
                /// The amount of scanned data. Unit: KB.
                /// </summary>
                [NameInMap("ScanSize")]
                [Validation(Required=false)]
                public string ScanSize { get; set; }

                /// <summary>
                /// The total amount of time consumed to scan data. It is an accumulated value collected from multiple TableScanNode nodes. Unit: milliseconds.
                /// </summary>
                [NameInMap("ScanTime")]
                [Validation(Required=false)]
                public long? ScanTime { get; set; }

                /// <summary>
                /// The execution state of the SQL statement.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The username.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// The accumulated CPU Time value of all operators collected from all nodes. Unit: milliseconds.
                /// </summary>
                [NameInMap("WallTime")]
                [Validation(Required=false)]
                public long? WallTime { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
