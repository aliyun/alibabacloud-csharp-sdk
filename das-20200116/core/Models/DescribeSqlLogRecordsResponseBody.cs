// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogRecordsResponseBodyData Data { get; set; }
        public class DescribeSqlLogRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// The end of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// Indicates whether the task was complete. Valid values:
            /// 
            /// *   **0**: The task failed.
            /// *   **1**: The task was complete.
            /// 
            /// >  If the value of **Finish** is 0 and the value of **JobId** is returned, the request is an asynchronous request and the return result cannot be directly obtained. You must query the return result by using the value of **JobId**. Specify JobId as the key of **Filters** and the value of **JobId** as the value of Filters. Example: `Filters=[{"Key": "JobId", "Value": "******"}]`.
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
                    /// This is a reserved parameter.
                    /// </summary>
                    [NameInMap("Collection")]
                    [Validation(Required=false)]
                    public string Collection { get; set; }

                    /// <summary>
                    /// The duration of the query. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("Consume")]
                    [Validation(Required=false)]
                    public long? Consume { get; set; }

                    /// <summary>
                    /// The CPU execution duration. Unit: microseconds.
                    /// </summary>
                    [NameInMap("CpuTime")]
                    [Validation(Required=false)]
                    public long? CpuTime { get; set; }

                    /// <summary>
                    /// The name of the database.
                    /// </summary>
                    [NameInMap("DBName")]
                    [Validation(Required=false)]
                    public string DBName { get; set; }

                    /// <summary>
                    /// The time when the query was performed. The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
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
                    /// The number of rows that are pulled by the compute nodes of the PolarDB-X 2.0 database instance.
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
                    /// The lock wait duration. Unit: milliseconds.
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
                    /// The time when the query was performed. The value of this parameter is a UNIX timestamp. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("OriginTime")]
                    [Validation(Required=false)]
                    public long? OriginTime { get; set; }

                    /// <summary>
                    /// The parallel queue time of the PolarDB for MySQL instance. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("ParallelDegree")]
                    [Validation(Required=false)]
                    public string ParallelDegree { get; set; }

                    /// <summary>
                    /// The parallelism of the PolarDB for MySQL instance.
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
                    /// The number of physical reads.
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
                    /// The number of rows that are returned.
                    /// </summary>
                    [NameInMap("ReturnRows")]
                    [Validation(Required=false)]
                    public long? ReturnRows { get; set; }

                    /// <summary>
                    /// The total number of rows that are updated or returned by the compute nodes of the PolarDB-X 2.0 database instance.
                    /// </summary>
                    [NameInMap("Rows")]
                    [Validation(Required=false)]
                    public long? Rows { get; set; }

                    /// <summary>
                    /// The number of rows that are scanned.
                    /// </summary>
                    [NameInMap("ScanRows")]
                    [Validation(Required=false)]
                    public long? ScanRows { get; set; }

                    /// <summary>
                    /// The number of requests that are sent to the data nodes by the compute nodes of the PolarDB-X 2.0 database instance.
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
                    /// The state of the query. Valid values:
                    /// 
                    /// *   **0**: The query was successful.
                    /// *   **1**: The query failed to be performed.
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
                    /// The trace ID of the PolarDB-X 2.0 database instance. The value is the execution ID of the SQL statement on the data nodes.
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
                    /// Indicates whether the In-Memory Column Index (IMCI) feature is enabled for the PolarDB for MySQL instance. Valid values:
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
                    /// The number of writes that are performed by the ApsaraDB RDS for SQL Server engine.
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
            /// The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, error information such as an error code is returned.
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
