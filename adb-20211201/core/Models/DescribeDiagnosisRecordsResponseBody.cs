// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDiagnosisRecordsResponseBody : TeaModel {
        /// <summary>
        /// The page number. Pages start from page 1. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   **30** (default)
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The queried SQL statements.
        /// </summary>
        [NameInMap("Querys")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisRecordsResponseBodyQuerys> Querys { get; set; }
        public class DescribeDiagnosisRecordsResponseBodyQuerys : TeaModel {
            /// <summary>
            /// The source IP address.
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// The total execution duration. Unit: milliseconds.
            /// 
            /// >  This value is the cumulative value of the `QueuedTime`, `TotalPlanningTime`, and `ExecutionTime` parameters.
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public long? Cost { get; set; }

            /// <summary>
            /// The name of the database on which the SQL statement is executed.
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// The number of rows written to the table by an extract-transform-load (ETL) job.
            /// </summary>
            [NameInMap("EtlWriteRows")]
            [Validation(Required=false)]
            public long? EtlWriteRows { get; set; }

            /// <summary>
            /// The execution duration. Unit: milliseconds.
            /// </summary>
            [NameInMap("ExecutionTime")]
            [Validation(Required=false)]
            public long? ExecutionTime { get; set; }

            /// <summary>
            /// The amount of returned data. Unit: bytes.
            /// </summary>
            [NameInMap("OutputDataSize")]
            [Validation(Required=false)]
            public long? OutputDataSize { get; set; }

            /// <summary>
            /// The number of rows returned.
            /// </summary>
            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            /// <summary>
            /// The peak memory. Unit: bytes.
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            /// <summary>
            /// The query ID.
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            [NameInMap("QueryProperties")]
            [Validation(Required=false)]
            public List<DescribeDiagnosisRecordsResponseBodyQuerysQueryProperties> QueryProperties { get; set; }
            public class DescribeDiagnosisRecordsResponseBodyQuerysQueryProperties : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The amount of time that is consumed for queuing. Unit: milliseconds.
            /// </summary>
            [NameInMap("QueueTime")]
            [Validation(Required=false)]
            public long? QueueTime { get; set; }

            /// <summary>
            /// The IP address and port number of the AnalyticDB for MySQL frontend node on which the SQL statement is executed.
            /// </summary>
            [NameInMap("RcHost")]
            [Validation(Required=false)]
            public string RcHost { get; set; }

            /// <summary>
            /// The execution duration rank of operators that are used in the SQL statement.
            /// 
            /// >  This parameter is returned only for SQL statements whose `Status` parameter is `running`.
            /// </summary>
            [NameInMap("ResourceCostRank")]
            [Validation(Required=false)]
            public int? ResourceCostRank { get; set; }

            /// <summary>
            /// The resource group to which the SQL statement belongs.
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// The queried SQL statement.
            /// 
            /// >  For performance considerations, an SQL statement cannot exceed 5,120 characters in length. Otherwise, the SQL statement is truncated. You can call the [DownloadDiagnosisRecords](https://help.aliyun.com/document_detail/308212.html) operation to download the information about SQL statements that meet a query condition for an AnalyticDB for MySQL cluster, including the complete SQL statements.
            /// </summary>
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public string SQL { get; set; }

            /// <summary>
            /// Indicates whether the SQL statement is truncated. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("SQLTruncated")]
            [Validation(Required=false)]
            public bool? SQLTruncated { get; set; }

            /// <summary>
            /// The maximum length of the SQL statement. 5120 is returned. Unit: characters. SQL statements that exceed this limit are truncated.
            /// </summary>
            [NameInMap("SQLTruncatedThreshold")]
            [Validation(Required=false)]
            public long? SQLTruncatedThreshold { get; set; }

            /// <summary>
            /// The number of rows scanned.
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
            /// The execution start time of the SQL statement. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
            /// The amount of time that is consumed to generate an execution plan. Unit: milliseconds.
            /// </summary>
            [NameInMap("TotalPlanningTime")]
            [Validation(Required=false)]
            public long? TotalPlanningTime { get; set; }

            /// <summary>
            /// The total number of stages generated.
            /// </summary>
            [NameInMap("TotalStages")]
            [Validation(Required=false)]
            public int? TotalStages { get; set; }

            /// <summary>
            /// The username that is used to execute the SQL statements.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

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
