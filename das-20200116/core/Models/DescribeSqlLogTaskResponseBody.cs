// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
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
            /// <para>The task creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681363254423</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The query end time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1608888296000</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// <para>Indicates whether the task has expired.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The task has expired.</description></item>
            /// <item><description><b>false</b>: The task has not expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public bool? Expire { get; set; }

            /// <summary>
            /// <para>The download URL of the export task. This value is returned only when TaskType is set to Export.</para>
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
                /// <para>For supported filter parameters and their values, refer to <b>Supplementary description of response parameters</b>.</para>
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
            /// <para>The task result of the offline query node. This value is returned only when TaskType is set to Query.</para>
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
                /// <para>The client IP address in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.1xx</para>
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// <para>The client port number in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("ClientPort")]
                [Validation(Required=false)]
                public long? ClientPort { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("Collection")]
                [Validation(Required=false)]
                public string Collection { get; set; }

                /// <summary>
                /// <para>The connection ID used in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ld-******</para>
                /// </summary>
                [NameInMap("ConnectionId")]
                [Validation(Required=false)]
                public string ConnectionId { get; set; }

                /// <summary>
                /// <para>The execution duration in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>58</para>
                /// </summary>
                [NameInMap("Consume")]
                [Validation(Required=false)]
                public long? Consume { get; set; }

                /// <summary>
                /// <para>The CPU execution time in microseconds.</para>
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
                /// <para>The execution time in UTC format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-12-07T02:15:32Z</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public string ExecuteTime { get; set; }

                /// <summary>
                /// <para>The extended information field. This is a reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public string Ext { get; set; }

                /// <summary>
                /// <para>The number of rows fetched by the PolarDB-X 2.0 compute node (CN).</para>
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
                /// <para>The lock wait time in milliseconds.</para>
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
                /// <para>The child node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pi-bp1o58x3ib7e6****</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The execution timestamp. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1701886532000</para>
                /// </summary>
                [NameInMap("OriginTime")]
                [Validation(Required=false)]
                public long? OriginTime { get; set; }

                /// <summary>
                /// <para>The parallel queue time of the PolarDB for MySQL instance in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ParallelDegree")]
                [Validation(Required=false)]
                public string ParallelDegree { get; set; }

                /// <summary>
                /// <para>The parallel degree of the PolarDB for MySQL instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ParallelQueueTime")]
                [Validation(Required=false)]
                public string ParallelQueueTime { get; set; }

                /// <summary>
                /// <para>The list of query parameters.</para>
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
                /// <para>Indicates whether the query item is protected.</para>
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
                /// <para>The row key in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("RowKey")]
                [Validation(Required=false)]
                public string RowKey { get; set; }

                /// <summary>
                /// <para>The total number of rows updated or returned by the PolarDB-X 2.0 compute node.</para>
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
                /// <para>The number of DN requests from the PolarDB-X 2.0 compute node (CN).</para>
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
                /// <para>SQL ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>a4111670e80596c5bf42cf5154438a91</para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// <para>The SQL statement details.</para>
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
                /// <item><description><b>SELECT</b></description></item>
                /// <item><description><b>UPDATE</b></description></item>
                /// <item><description><b>DELETE</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT</para>
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// <para>The execution result.</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Execution succeeded.</description></item>
                /// <item><description><b>1</b>: Execution failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The table name used in the query.</para>
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
                /// <para>The trace ID of PolarDB-X 2.0, which is the execution ID of the SQL statement on the data node.</para>
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
                /// <para>Indicates whether the PolarDB for MySQL instance uses the In-Memory Column Index.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The IMCI is used.</description></item>
                /// <item><description><b>false</b>: The IMCI is not used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("UseImciEngine")]
                [Validation(Required=false)]
                public string UseImciEngine { get; set; }

                /// <summary>
                /// <para>The endpoint resolution address of the query link.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.146.XX.XX</para>
                /// </summary>
                [NameInMap("Vip")]
                [Validation(Required=false)]
                public string Vip { get; set; }

                /// <summary>
                /// <para>The number of writes for the RDS SQL Server engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Writes")]
                [Validation(Required=false)]
                public long? Writes { get; set; }

            }

            /// <summary>
            /// <para>The query start time. The value is a UNIX timestamp in milliseconds.</para>
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
            /// <item><description><b>INIT</b>: Pending scheduling.</description></item>
            /// <item><description><b>RUNNING</b>: Running.</description></item>
            /// <item><description><b>FAILED</b>: Failed.</description></item>
            /// <item><description><b>CANCELED</b>: Canceled.</description></item>
            /// <item><description><b>COMPLETED</b>: Completed.<remarks>
            /// <para>When the task is in the <b>COMPLETED</b> state, you can view the results of the offline task.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
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
            /// <item><description><b>Export</b>: export task.</description></item>
            /// <item><description><b>Query</b>: custom query task.</description></item>
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
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, exception information such as an error code is returned.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
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
