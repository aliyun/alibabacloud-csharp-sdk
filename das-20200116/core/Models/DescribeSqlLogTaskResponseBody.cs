// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogTaskResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogTaskResponseBodyData Data { get; set; }
        public class DescribeSqlLogTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the task was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The end of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// Indicates whether the task has expired. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public bool? Expire { get; set; }

            /// <summary>
            /// The download URL of the export task.
            /// </summary>
            [NameInMap("Export")]
            [Validation(Required=false)]
            public string Export { get; set; }

            /// <summary>
            /// The filter parameters.
            /// </summary>
            [NameInMap("Filters")]
            [Validation(Required=false)]
            public List<DescribeSqlLogTaskResponseBodyDataFilters> Filters { get; set; }
            public class DescribeSqlLogTaskResponseBodyDataFilters : TeaModel {
                /// <summary>
                /// The name of the filter parameter.
                /// 
                /// >  For more information about the filter parameters, see the **Valid values of Key** section of this topic.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the filter parameter.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// The task name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The results of the offline querying task.
            /// </summary>
            [NameInMap("Queries")]
            [Validation(Required=false)]
            public List<DescribeSqlLogTaskResponseBodyDataQueries> Queries { get; set; }
            public class DescribeSqlLogTaskResponseBodyDataQueries : TeaModel {
                /// <summary>
                /// The database account.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// The execution duration. Unit: millisecond.
                /// </summary>
                [NameInMap("Consume")]
                [Validation(Required=false)]
                public long? Consume { get; set; }

                /// <summary>
                /// The CPU execution time. Unit: microsecond.
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
                /// The execution time. The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
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
                /// The number of rows pulled by the CNs of the PolarDB-X 2.0 instance.
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
                /// The lock wait time. Unit: millisecond.
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
                /// The ID of the child node.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The execution timestamp. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("OriginTime")]
                [Validation(Required=false)]
                public long? OriginTime { get; set; }

                /// <summary>
                /// The wait time of parallel queries in the queue in the PolarDB for MySQL instance. Unit: millisecond.
                /// </summary>
                [NameInMap("ParallelDegree")]
                [Validation(Required=false)]
                public string ParallelDegree { get; set; }

                /// <summary>
                /// The degree of parallelism (DOP) value of the PolarDB for MySQL instance.
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
                /// The number of rows returned.
                /// </summary>
                [NameInMap("ReturnRows")]
                [Validation(Required=false)]
                public long? ReturnRows { get; set; }

                /// <summary>
                /// The total number of rows updated or returned by the CNs of the PolarDB-X 2.0 instance.
                /// </summary>
                [NameInMap("Rows")]
                [Validation(Required=false)]
                public long? Rows { get; set; }

                /// <summary>
                /// The number of rows scanned.
                /// </summary>
                [NameInMap("ScanRows")]
                [Validation(Required=false)]
                public long? ScanRows { get; set; }

                /// <summary>
                /// The number of requests from the compute nodes (CNs) to the data nodes (DNs) in the PolarDB-X 2.0 instance.
                /// </summary>
                [NameInMap("Scnt")]
                [Validation(Required=false)]
                public long? Scnt { get; set; }

                /// <summary>
                /// The ID of the SQL statement.
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// The queried SQL statement.
                /// </summary>
                [NameInMap("SqlText")]
                [Validation(Required=false)]
                public string SqlText { get; set; }

                /// <summary>
                /// The type of the SQL statement. Valid values:
                /// 
                /// *   **SELECT**
                /// *   **UPDATE**
                /// *   **DELETE**
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// The execution result of the SQL statement. Valid values:
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
                /// The trace ID of the PolarDB-X 2.0 instance, which is the execution ID of the SQL statement on the DN.
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
                /// The number of rows updated.
                /// </summary>
                [NameInMap("UpdateRows")]
                [Validation(Required=false)]
                public long? UpdateRows { get; set; }

                /// <summary>
                /// Indicates whether the PolarDB for MySQL instance uses In-Memory Column Indexes (IMCIs). Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("UseImciEngine")]
                [Validation(Required=false)]
                public string UseImciEngine { get; set; }

                /// <summary>
                /// The IP address to which the endpoint used for query is resolved.
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

            /// <summary>
            /// The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// The task state. Valid values:
            /// 
            /// *   **INIT**: The task is to be scheduled.
            /// *   **RUNNING**: The task is running.
            /// *   **FAILED**: The task failed.
            /// *   **CANCELED**: The task is canceled.
            /// *   **COMPLETED**: The task is complete.
            /// 
            /// >  If a task is in the **COMPLETED** state, you can view the results of the task.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The task type. Valid values:
            /// 
            /// *   **Export**
            /// *   **Query**
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The total number of tasks.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message is returned.
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
