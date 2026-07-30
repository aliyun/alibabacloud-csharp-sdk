// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
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
        public DescribeSqlLogRecordsResponseBodyData Data { get; set; }
        public class DescribeSqlLogRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The end time of the query. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1608888296000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: The task is in progress.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: The task is complete.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If this parameter is <b>0</b> and the <b>JobId</b> parameter is returned, the current request is an asynchronous request and you cannot obtain the returned results. You must use the value of <b>JobId</b> to initiate another request. Set the <b>Filters</b> parameter to the value of <b>JobId</b>. Example: <c>Filters=[{&quot;Key&quot;: &quot;JobId&quot;, &quot;Value&quot;: &quot;******&quot;}]</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Finish")]
            [Validation(Required=false)]
            public string Finish { get; set; }

            /// <summary>
            /// <para>The details of the SQL logs.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public DescribeSqlLogRecordsResponseBodyDataItems Items { get; set; }
            public class DescribeSqlLogRecordsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The SQL log data.</para>
                /// </summary>
                [NameInMap("SQLLogRecord")]
                [Validation(Required=false)]
                public List<DescribeSqlLogRecordsResponseBodyDataItemsSQLLogRecord> SQLLogRecord { get; set; }
                public class DescribeSqlLogRecordsResponseBodyDataItemsSQLLogRecord : TeaModel {
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
                    /// <para>The execution duration. Unit: microseconds (μs).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>58</para>
                    /// </summary>
                    [NameInMap("Consume")]
                    [Validation(Required=false)]
                    public long? Consume { get; set; }

                    /// <summary>
                    /// <para>The CPU execution time. Unit: microseconds (μs).</para>
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
                    /// <para>testdb</para>
                    /// </summary>
                    [NameInMap("DBName")]
                    [Validation(Required=false)]
                    public string DBName { get; set; }

                    /// <summary>
                    /// <para>The execution time. The time is in UTC. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-12-07T02:15:32Z</para>
                    /// </summary>
                    [NameInMap("ExecuteTime")]
                    [Validation(Required=false)]
                    public string ExecuteTime { get; set; }

                    /// <summary>
                    /// <para>The extended information. This parameter is reserved.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public string Ext { get; set; }

                    /// <summary>
                    /// <para>The number of rows fetched by the compute node (CN) in a PolarDB-X 2.0 instance.</para>
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
                    /// <para>pi-uf6k5f6g3912i****</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <para>The execution time. This value is a UNIX timestamp. Unit: milliseconds.</para>
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
                    /// <para>The parallel queue time for the PolarDB for MySQL instance. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("ParallelQueueTime")]
                    [Validation(Required=false)]
                    public string ParallelQueueTime { get; set; }

                    /// <summary>
                    /// <para>The SQL parameters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[1, &quot;das&quot;]</para>
                    /// </summary>
                    [NameInMap("Params")]
                    [Validation(Required=false)]
                    public string Params { get; set; }

                    /// <summary>
                    /// <para>The number of asynchronous physical reads.</para>
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
                    /// <para>The number of synchronous physical reads.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PhysicSyncRead")]
                    [Validation(Required=false)]
                    public long? PhysicSyncRead { get; set; }

                    /// <summary>
                    /// <para>The protocol type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

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
                    /// <para>The row key of the SQL log record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23</para>
                    /// </summary>
                    [NameInMap("RowKey")]
                    [Validation(Required=false)]
                    public string RowKey { get; set; }

                    /// <summary>
                    /// <para>The total number of rows updated or returned by the compute node (CN) of a PolarDB-X 2.0 instance.</para>
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
                    /// <para>The number of requests sent from a compute node (CN) to data nodes (DNs) in a PolarDB-X 2.0 instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Scnt")]
                    [Validation(Required=false)]
                    public long? Scnt { get; set; }

                    /// <summary>
                    /// <para>The SQL ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c67649d4a7fb62c4f8c7a447c52b5b17</para>
                    /// </summary>
                    [NameInMap("SqlId")]
                    [Validation(Required=false)]
                    public string SqlId { get; set; }

                    /// <summary>
                    /// <para>The SQL statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>select resource_id as cluster_id, tpl_name \n\tfrom dbfree_alert_resource_tpl_ref\n\twhere user_id=? and type=\&quot;cluster\&quot; group by resource_id, tpl_name</para>
                    /// </summary>
                    [NameInMap("SqlText")]
                    [Validation(Required=false)]
                    public string SqlText { get; set; }

                    /// <summary>
                    /// <para>The type of the SQL statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>select</para>
                    /// </summary>
                    [NameInMap("SqlType")]
                    [Validation(Required=false)]
                    public string SqlType { get; set; }

                    /// <summary>
                    /// <para>The execution status. Valid values:</para>
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
                    /// <para>The name of the table that the SQL statement references.</para>
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
                    /// <para>The trace ID for a PolarDB-X 2.0 instance. This is the ID of the SQL statement that was executed on a data node (DN).</para>
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
                    /// <para>Indicates whether an In-Memory Column Index (IMCI) is used for the PolarDB for MySQL instance.</para>
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
                    /// <para>The endpoint that is resolved from the query connection string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.115.XX.XX</para>
                    /// </summary>
                    [NameInMap("Vip")]
                    [Validation(Required=false)]
                    public string Vip { get; set; }

                    /// <summary>
                    /// <para>The number of write operations on an ApsaraDB RDS for SQL Server instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Writes")]
                    [Validation(Required=false)]
                    public long? Writes { get; set; }

                }

            }

            /// <summary>
            /// <para>The asynchronous task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MzI4NTZfUUlOR0RBT19DTTlfTlUyMF9NWVNRTF9PREJTX0xWU18zMjg1Nl9teXNxbF9XZWQgTWFyIDA2IDE0OjUwOjQ3IENTVCAyMDI0XzBfMzBfRXhlY3V0ZVRpbWVfREVTQ19XZWQgTWFyIDA2IDE0OjM1OjQ3IENTVCAyMDI0Xw==_1709708406465</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The start time of the query. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1596177993000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>F43E7FB3-CE67-5FFD-A59C-EFD278BCD7BE</para>
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
