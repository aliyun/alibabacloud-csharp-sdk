// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogRecordsResponseBodyData Data { get; set; }
        public class DescribeSqlLogRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// The end of the time range to query. This value is a UNIX timestamp. Unit: millisecond.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// Indicates whether the task was complete. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// 
            /// >  If the value of **Finish** is 0 and the value of **JobId** is returned, the request is an asynchronous request and the return result cannot be directly obtained. You must query the return result based on the value of **JobId**. Specify JobId as the key of **Filters** and the value of **JobId** as the value of Filters. Example: `Filters=[{"Key": "JobId", "Value": "******"}]`.
            /// </summary>
            [NameInMap("Finish")]
            [Validation(Required=false)]
            public string Finish { get; set; }

            /// <summary>
            /// The data.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public DescribeSqlLogRecordsResponseBodyDataItems Items { get; set; }
            public class DescribeSqlLogRecordsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// The SQL log data.
                /// </summary>
                [NameInMap("SQLLogRecord")]
                [Validation(Required=false)]
                public List<DescribeSqlLogRecordsResponseBodyDataItemsSQLLogRecord> SQLLogRecord { get; set; }
                public class DescribeSqlLogRecordsResponseBodyDataItemsSQLLogRecord : TeaModel {
                    /// <summary>
                    /// The account of the database.
                    /// </summary>
                    [NameInMap("AccountName")]
                    [Validation(Required=false)]
                    public string AccountName { get; set; }

                    /// <summary>
                    /// A reserved parameter.
                    /// </summary>
                    [NameInMap("Collection")]
                    [Validation(Required=false)]
                    public string Collection { get; set; }

                    /// <summary>
                    /// The amount of time that is consumed to execute the SQL statement. Unit: millisecond.
                    /// </summary>
                    [NameInMap("Consume")]
                    [Validation(Required=false)]
                    public long? Consume { get; set; }

                    /// <summary>
                    /// The CPU execution duration. Unit: microsecond.
                    /// </summary>
                    [NameInMap("CpuTime")]
                    [Validation(Required=false)]
                    public long? CpuTime { get; set; }

                    /// <summary>
                    /// The database name.
                    /// </summary>
                    [NameInMap("DBName")]
                    [Validation(Required=false)]
                    public string DBName { get; set; }

                    /// <summary>
                    /// The time when the SQL statement was executed. The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
                    /// </summary>
                    [NameInMap("ExecuteTime")]
                    [Validation(Required=false)]
                    public string ExecuteTime { get; set; }

                    /// <summary>
                    /// The extended information. This parameter is a reserved parameter.
                    /// </summary>
                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public string Ext { get; set; }

                    /// <summary>
                    /// The number of rows that are pulled by the compute nodes of the PolarDB-X 2.0 instance.
                    /// </summary>
                    [NameInMap("Frows")]
                    [Validation(Required=false)]
                    public long? Frows { get; set; }

                    /// <summary>
                    /// The IP address of the client.
                    /// </summary>
                    [NameInMap("HostAddress")]
                    [Validation(Required=false)]
                    public string HostAddress { get; set; }

                    /// <summary>
                    /// The lock wait duration. Unit: millisecond.
                    /// </summary>
                    [NameInMap("LockTime")]
                    [Validation(Required=false)]
                    public long? LockTime { get; set; }

                    /// <summary>
                    /// The number of logical reads.
                    /// </summary>
                    [NameInMap("LogicRead")]
                    [Validation(Required=false)]
                    public long? LogicRead { get; set; }

                    /// <summary>
                    /// The node ID.
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// The timestamp generated when the SQL statement was executed. The value of this parameter is a UNIX timestamp. Unit: millisecond.
                    /// </summary>
                    [NameInMap("OriginTime")]
                    [Validation(Required=false)]
                    public long? OriginTime { get; set; }

                    /// <summary>
                    /// The parallel queue time of the PolarDB for MySQL instance. Unit: millisecond.
                    /// </summary>
                    [NameInMap("ParallelDegree")]
                    [Validation(Required=false)]
                    public string ParallelDegree { get; set; }

                    /// <summary>
                    /// The parallelism of the PolarDB for MySQL cluster.
                    /// </summary>
                    [NameInMap("ParallelQueueTime")]
                    [Validation(Required=false)]
                    public string ParallelQueueTime { get; set; }

                    /// <summary>
                    /// The number of physical asynchronous reads.
                    /// </summary>
                    [NameInMap("PhysicAsyncRead")]
                    [Validation(Required=false)]
                    public long? PhysicAsyncRead { get; set; }

                    /// <summary>
                    /// The total number of physical reads.
                    /// </summary>
                    [NameInMap("PhysicRead")]
                    [Validation(Required=false)]
                    public long? PhysicRead { get; set; }

                    /// <summary>
                    /// The number of physical synchronous reads.
                    /// </summary>
                    [NameInMap("PhysicSyncRead")]
                    [Validation(Required=false)]
                    public long? PhysicSyncRead { get; set; }

                    /// <summary>
                    /// The number of rows returned by the SQL statement.
                    /// </summary>
                    [NameInMap("ReturnRows")]
                    [Validation(Required=false)]
                    public long? ReturnRows { get; set; }

                    /// <summary>
                    /// The total number of rows that are updated or returned by the compute nodes of the PolarDB-X 2.0 instance.
                    /// </summary>
                    [NameInMap("Rows")]
                    [Validation(Required=false)]
                    public long? Rows { get; set; }

                    /// <summary>
                    /// The number of scanned rows.
                    /// </summary>
                    [NameInMap("ScanRows")]
                    [Validation(Required=false)]
                    public long? ScanRows { get; set; }

                    /// <summary>
                    /// The number of requests that are sent from the compute nodes to the data nodes of the PolarDB-X 2.0 instance.
                    /// </summary>
                    [NameInMap("Scnt")]
                    [Validation(Required=false)]
                    public long? Scnt { get; set; }

                    /// <summary>
                    /// The SQL statement ID.
                    /// </summary>
                    [NameInMap("SqlId")]
                    [Validation(Required=false)]
                    public string SqlId { get; set; }

                    /// <summary>
                    /// The SQL statement.
                    /// </summary>
                    [NameInMap("SqlText")]
                    [Validation(Required=false)]
                    public string SqlText { get; set; }

                    /// <summary>
                    /// The type of the SQL statement.
                    /// </summary>
                    [NameInMap("SqlType")]
                    [Validation(Required=false)]
                    public string SqlType { get; set; }

                    /// <summary>
                    /// The execution status of the SQL statement.
                    /// 
                    /// *   **0**: The execution was successful.
                    /// *   **1**: The execution failed.
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    /// <summary>
                    /// The thread ID.
                    /// </summary>
                    [NameInMap("ThreadId")]
                    [Validation(Required=false)]
                    public long? ThreadId { get; set; }

                    /// <summary>
                    /// The trace ID of the PolarDB-X 2.0 instance. The value is the execution ID of the SQL statement on the data node.
                    /// </summary>
                    [NameInMap("TraceId")]
                    [Validation(Required=false)]
                    public string TraceId { get; set; }

                    /// <summary>
                    /// The transaction ID.
                    /// </summary>
                    [NameInMap("TrxId")]
                    [Validation(Required=false)]
                    public string TrxId { get; set; }

                    /// <summary>
                    /// The number of rows that are updated.
                    /// </summary>
                    [NameInMap("UpdateRows")]
                    [Validation(Required=false)]
                    public long? UpdateRows { get; set; }

                    /// <summary>
                    /// Indicates whether the In-Memory Column Index (IMCI) feature is enabled for the PolarDB for MySQL cluster. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("UseImciEngine")]
                    [Validation(Required=false)]
                    public string UseImciEngine { get; set; }

                    /// <summary>
                    /// The IP address that is resolved from the endpoint of the query link.
                    /// </summary>
                    [NameInMap("Vip")]
                    [Validation(Required=false)]
                    public string Vip { get; set; }

                    /// <summary>
                    /// The number of writes to the ApsaraDB RDS for SQL Server instance.
                    /// </summary>
                    [NameInMap("Writes")]
                    [Validation(Required=false)]
                    public long? Writes { get; set; }

                }

            }

            /// <summary>
            /// The ID of the asynchronous task.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The beginning of the time range to query. This value is a UNIX timestamp. Unit: millisecond.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The total number of entries.
            /// </summary>
            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// The message that is returned.
        /// 
        /// >  If the request is successful, **Successful** is returned. If the request fails, an error message that contains information such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
