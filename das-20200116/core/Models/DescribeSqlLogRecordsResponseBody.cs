// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogRecordsResponseBodyData Data { get; set; }
        public class DescribeSqlLogRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The end of the time range to query. This value is a UNIX timestamp. Unit: millisecond.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1608888296000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the task was complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no</description></item>
            /// <item><description><b>1</b>: yes</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the value of <b>Finish</b> is 0 and the value of <b>JobId</b> is returned, the request is an asynchronous request and the return result cannot be directly obtained. You must query the return result based on the value of <b>JobId</b>. Specify JobId as the key of <b>Filters</b> and the value of <b>JobId</b> as the value of Filters. Example: <c>Filters=[{&quot;Key&quot;: &quot;JobId&quot;, &quot;Value&quot;: &quot;******&quot;}]</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Finish")]
            [Validation(Required=false)]
            public string Finish { get; set; }

            /// <summary>
            /// <para>The data.</para>
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
                    /// <para>The account of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testname</para>
                    /// </summary>
                    [NameInMap("AccountName")]
                    [Validation(Required=false)]
                    public string AccountName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[&quot;col1&quot;]</para>
                    /// </summary>
                    [NameInMap("AffectColumns")]
                    [Validation(Required=false)]
                    public string AffectColumns { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10.0.0.1xx</para>
                    /// </summary>
                    [NameInMap("ClientIp")]
                    [Validation(Required=false)]
                    public string ClientIp { get; set; }

                    /// <summary>
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
                    /// <b>Example:</b>
                    /// <para>ld-******</para>
                    /// </summary>
                    [NameInMap("ConnectionId")]
                    [Validation(Required=false)]
                    public string ConnectionId { get; set; }

                    /// <summary>
                    /// <para>The amount of time that is consumed to execute the SQL statement. Unit: millisecond.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>58</para>
                    /// </summary>
                    [NameInMap("Consume")]
                    [Validation(Required=false)]
                    public long? Consume { get; set; }

                    /// <summary>
                    /// <para>The CPU execution duration. Unit: microsecond.</para>
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
                    /// <para>The time when the SQL statement was executed. The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-12-07T02:15:32Z</para>
                    /// </summary>
                    [NameInMap("ExecuteTime")]
                    [Validation(Required=false)]
                    public string ExecuteTime { get; set; }

                    /// <summary>
                    /// <para>The extended information. This parameter is a reserved parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public string Ext { get; set; }

                    /// <summary>
                    /// <para>The number of rows that are pulled by the compute nodes of the PolarDB-X 2.0 instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Frows")]
                    [Validation(Required=false)]
                    public long? Frows { get; set; }

                    /// <summary>
                    /// <para>The IP address of the client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11.197.XX.XX</para>
                    /// </summary>
                    [NameInMap("HostAddress")]
                    [Validation(Required=false)]
                    public string HostAddress { get; set; }

                    /// <summary>
                    /// <para>The lock wait duration. Unit: millisecond.</para>
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
                    /// <para>The timestamp generated when the SQL statement was executed. The value of this parameter is a UNIX timestamp. Unit: millisecond.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1701886532000</para>
                    /// </summary>
                    [NameInMap("OriginTime")]
                    [Validation(Required=false)]
                    public long? OriginTime { get; set; }

                    /// <summary>
                    /// <para>The parallel queue time of the PolarDB for MySQL instance. Unit: millisecond.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("ParallelDegree")]
                    [Validation(Required=false)]
                    public string ParallelDegree { get; set; }

                    /// <summary>
                    /// <para>The parallelism of the PolarDB for MySQL cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("ParallelQueueTime")]
                    [Validation(Required=false)]
                    public string ParallelQueueTime { get; set; }

                    /// <summary>
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
                    /// <para>The total number of physical reads.</para>
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
                    /// <b>Example:</b>
                    /// <para>MySQL</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The number of rows returned by the SQL statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ReturnRows")]
                    [Validation(Required=false)]
                    public long? ReturnRows { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>23</para>
                    /// </summary>
                    [NameInMap("RowKey")]
                    [Validation(Required=false)]
                    public string RowKey { get; set; }

                    /// <summary>
                    /// <para>The total number of rows that are updated or returned by the compute nodes of the PolarDB-X 2.0 instance.</para>
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
                    /// <para>The number of requests that are sent from the compute nodes to the data nodes of the PolarDB-X 2.0 instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Scnt")]
                    [Validation(Required=false)]
                    public long? Scnt { get; set; }

                    /// <summary>
                    /// <para>The SQL statement ID.</para>
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
                    /// <para>The execution status of the SQL statement.</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: The execution was successful.</description></item>
                    /// <item><description><b>1</b>: The execution failed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    /// <summary>
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
                    /// <para>The trace ID of the PolarDB-X 2.0 instance. The value is the execution ID of the SQL statement on the data node.</para>
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
                    /// <para>The number of rows that are updated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UpdateRows")]
                    [Validation(Required=false)]
                    public long? UpdateRows { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the In-Memory Column Index (IMCI) feature is enabled for the PolarDB for MySQL cluster. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("UseImciEngine")]
                    [Validation(Required=false)]
                    public string UseImciEngine { get; set; }

                    /// <summary>
                    /// <para>The IP address that is resolved from the endpoint of the query link.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.115.XX.XX</para>
                    /// </summary>
                    [NameInMap("Vip")]
                    [Validation(Required=false)]
                    public string Vip { get; set; }

                    /// <summary>
                    /// <para>The number of writes to the ApsaraDB RDS for SQL Server instance.</para>
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
            /// <para>The ID of the asynchronous task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MzI4NTZfUUlOR0RBT19DTTlfTlUyMF9NWVNRTF9PREJTX0xWU18zMjg1Nl9teXNxbF9XZWQgTWFyIDA2IDE0OjUwOjQ3IENTVCAyMDI0XzBfMzBfRXhlY3V0ZVRpbWVfREVTQ19XZWQgTWFyIDA2IDE0OjM1OjQ3IENTVCAyMDI0Xw==_1709708406465</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The beginning of the time range to query. This value is a UNIX timestamp. Unit: millisecond.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1596177993000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// <remarks>
        /// <para> If the request is successful, <b>Successful</b> is returned. If the request fails, an error message that contains information such as an error code is returned.</para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
