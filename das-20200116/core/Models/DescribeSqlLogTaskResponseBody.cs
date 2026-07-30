// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogTaskResponseBodyData Data { get; set; }
        public class DescribeSqlLogTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the task was created, which is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681363254423</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The end of the query time range, which is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1608888296000</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// <para>Indicates whether the task has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The task has expired.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The task has not expired.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public bool? Expire { get; set; }

            /// <summary>
            /// <para>The download URL of the exported file. This parameter is returned only if the value of <c>TaskType</c> is <c>Export</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;<a href="https://das-sqllog-download-cn-hongkong.oss-cn-hongkong.aliyuncs.com/">https://das-sqllog-download-cn-hongkong.oss-cn-hongkong.aliyuncs.com/</a>****&quot;</para>
            /// </summary>
            [NameInMap("Export")]
            [Validation(Required=false)]
            public string Export { get; set; }

            /// <summary>
            /// <para>The filter conditions.</para>
            /// </summary>
            [NameInMap("Filters")]
            [Validation(Required=false)]
            public List<DescribeSqlLogTaskResponseBodyDataFilters> Filters { get; set; }
            public class DescribeSqlLogTaskResponseBodyDataFilters : TeaModel {
                /// <summary>
                /// <para>The name of the filter parameter.</para>
                /// <remarks>
                /// <para>For more information about the supported filter parameters and their valid values, see the &quot;Additional information about response parameters&quot; section.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>keyWords</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the filter parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL audit export 1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The results of the offline query task. This parameter is returned only if the value of <c>TaskType</c> is <c>Query</c>.</para>
            /// </summary>
            [NameInMap("Queries")]
            [Validation(Required=false)]
            public List<DescribeSqlLogTaskResponseBodyDataQueries> Queries { get; set; }
            public class DescribeSqlLogTaskResponseBodyDataQueries : TeaModel {
                /// <summary>
                /// <para>The database account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testname</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The affected columns.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;col1&quot;]</para>
                /// </summary>
                [NameInMap("AffectColumns")]
                [Validation(Required=false)]
                public string AffectColumns { get; set; }

                /// <summary>
                /// <para>The client IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.1xx</para>
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// <para>The client port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("ClientPort")]
                [Validation(Required=false)]
                public long? ClientPort { get; set; }

                /// <summary>
                /// <para>This parameter is reserved.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("Collection")]
                [Validation(Required=false)]
                public string Collection { get; set; }

                /// <summary>
                /// <para>The connection ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ld-******</para>
                /// </summary>
                [NameInMap("ConnectionId")]
                [Validation(Required=false)]
                public string ConnectionId { get; set; }

                /// <summary>
                /// <para>The execution duration. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>58</para>
                /// </summary>
                [NameInMap("Consume")]
                [Validation(Required=false)]
                public long? Consume { get; set; }

                /// <summary>
                /// <para>The CPU execution time. Unit: microseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public long? CpuTime { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testdb01</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The time when the SQL statement was executed. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-12-07T02:15:32Z</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public string ExecuteTime { get; set; }

                /// <summary>
                /// <para>Reserved for future use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public string Ext { get; set; }

                /// <summary>
                /// <para>The number of rows that are fetched by the compute nodes of a PolarDB-X 2.0 instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Frows")]
                [Validation(Required=false)]
                public long? Frows { get; set; }

                /// <summary>
                /// <para>The client IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11.197.XX.XX</para>
                /// </summary>
                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                /// <summary>
                /// <para>The lock wait time. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LockTime")]
                [Validation(Required=false)]
                public long? LockTime { get; set; }

                /// <summary>
                /// <para>The number of logical reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LogicRead")]
                [Validation(Required=false)]
                public long? LogicRead { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pi-bp1o58x3ib7e6****</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The time when the SQL statement was executed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1701886532000</para>
                /// </summary>
                [NameInMap("OriginTime")]
                [Validation(Required=false)]
                public long? OriginTime { get; set; }

                /// <summary>
                /// <para>The degree of parallelism (DOP) for the PolarDB for MySQL instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ParallelDegree")]
                [Validation(Required=false)]
                public string ParallelDegree { get; set; }

                /// <summary>
                /// <para>The parallel queuing time for the PolarDB for MySQL instance. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ParallelQueueTime")]
                [Validation(Required=false)]
                public string ParallelQueueTime { get; set; }

                /// <summary>
                /// <para>The query parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[1, &quot;das&quot;]</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public string Params { get; set; }

                /// <summary>
                /// <para>The number of physical asynchronous reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PhysicAsyncRead")]
                [Validation(Required=false)]
                public long? PhysicAsyncRead { get; set; }

                /// <summary>
                /// <para>The number of physical reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PhysicRead")]
                [Validation(Required=false)]
                public long? PhysicRead { get; set; }

                /// <summary>
                /// <para>The number of physical synchronous reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PhysicSyncRead")]
                [Validation(Required=false)]
                public long? PhysicSyncRead { get; set; }

                /// <summary>
                /// <para>Indicates whether the query is protected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Protected")]
                [Validation(Required=false)]
                public string Protected { get; set; }

                /// <summary>
                /// <para>The number of returned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReturnRows")]
                [Validation(Required=false)]
                public long? ReturnRows { get; set; }

                /// <summary>
                /// <para>The row key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("RowKey")]
                [Validation(Required=false)]
                public string RowKey { get; set; }

                /// <summary>
                /// <para>The total number of rows that are updated or returned by the compute nodes of a PolarDB-X 2.0 instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Rows")]
                [Validation(Required=false)]
                public long? Rows { get; set; }

                /// <summary>
                /// <para>The number of scanned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ScanRows")]
                [Validation(Required=false)]
                public long? ScanRows { get; set; }

                /// <summary>
                /// <para>The number of requests that are sent from compute nodes (CNs) to data nodes (DNs) for a PolarDB-X 2.0 instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Scnt")]
                [Validation(Required=false)]
                public long? Scnt { get; set; }

                /// <summary>
                /// <para>The SQL command in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sql</para>
                /// </summary>
                [NameInMap("SqlCommand")]
                [Validation(Required=false)]
                public long? SqlCommand { get; set; }

                /// <summary>
                /// <para>The SQL ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a4111670e80596c5bf42cf5154438a91</para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// <para>The SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT @@session.transaction_read_only</para>
                /// </summary>
                [NameInMap("SqlText")]
                [Validation(Required=false)]
                public string SqlText { get; set; }

                /// <summary>
                /// <para>The type of the SQL statement. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>SELECT</b></para>
                /// </description></item>
                /// <item><description><para><b>UPDATE</b></para>
                /// </description></item>
                /// <item><description><para><b>DELETE</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT</para>
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// <para>The execution state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: The execution was successful.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: The execution failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>das</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The thread ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("ThreadId")]
                [Validation(Required=false)]
                public long? ThreadId { get; set; }

                /// <summary>
                /// <para>The trace ID of a PolarDB-X 2.0 instance. The trace ID is the execution ID of the SQL statement on data nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14c93b7c7bf00000</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

                /// <summary>
                /// <para>The transaction ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200000</para>
                /// </summary>
                [NameInMap("TrxId")]
                [Validation(Required=false)]
                public string TrxId { get; set; }

                /// <summary>
                /// <para>The number of updated rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UpdateRows")]
                [Validation(Required=false)]
                public long? UpdateRows { get; set; }

                /// <summary>
                /// <para>Indicates whether an In-Memory Column Index (IMCI) is used for the PolarDB for MySQL instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("UseImciEngine")]
                [Validation(Required=false)]
                public string UseImciEngine { get; set; }

                /// <summary>
                /// <para>The IP address that the query endpoint resolves to.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.146.XX.XX</para>
                /// </summary>
                [NameInMap("Vip")]
                [Validation(Required=false)]
                public string Vip { get; set; }

                /// <summary>
                /// <para>The number of writes for the ApsaraDB RDS for SQL Server instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Writes")]
                [Validation(Required=false)]
                public long? Writes { get; set; }

            }

            /// <summary>
            /// <para>The beginning of the query time range, which is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1596177993000</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>INIT</b>: The task is pending.</para>
            /// </description></item>
            /// <item><description><para><b>RUNNING</b>: The task is running.</para>
            /// </description></item>
            /// <item><description><para><b>FAILED</b>: The task failed.</para>
            /// </description></item>
            /// <item><description><para><b>CANCELED</b>: The task was canceled.</para>
            /// </description></item>
            /// <item><description><para><b>COMPLETED</b>: The task is complete.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The results of an offline task are available only when the status is <b>COMPLETED</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9a4f5c4494dbd6713185d87a97aa53e8</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Export</b>: an export task.</para>
            /// </description></item>
            /// <item><description><para><b>Query</b>: a query task.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Query</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The total number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. Otherwise, an error message is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
