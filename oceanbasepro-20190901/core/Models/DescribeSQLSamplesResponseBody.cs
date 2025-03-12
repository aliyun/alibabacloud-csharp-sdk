// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLSamplesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of sample data of slow query execution details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSQLSamplesResponseBodyData> Data { get; set; }
        public class DescribeSQLSamplesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Average updated rows during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000.0</para>
            /// </summary>
            [NameInMap("AffectedRows")]
            [Validation(Required=false)]
            public double? AffectedRows { get; set; }

            /// <summary>
            /// <para>Application event waiting time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("ApplicationWaitTime")]
            [Validation(Required=false)]
            public double? ApplicationWaitTime { get; set; }

            /// <summary>
            /// <para>BlockCache hit count</para>
            /// 
            /// <b>Example:</b>
            /// <para>99279.0</para>
            /// </summary>
            [NameInMap("BlockCacheHit")]
            [Validation(Required=false)]
            public double? BlockCacheHit { get; set; }

            /// <summary>
            /// <para>BlockIndexCache hit count</para>
            /// 
            /// <b>Example:</b>
            /// <para>142514.0</para>
            /// </summary>
            [NameInMap("BlockIndexCacheHit")]
            [Validation(Required=false)]
            public double? BlockIndexCacheHit { get; set; }

            /// <summary>
            /// <para>BloomFilterCache hit count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("BloomFilterCacheHit")]
            [Validation(Required=false)]
            public double? BloomFilterCacheHit { get; set; }

            /// <summary>
            /// <para>Client IP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1db****38uemejio</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>Client port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4****</para>
            /// </summary>
            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public string ClientPort { get; set; }

            /// <summary>
            /// <para>Concurrency event waiting time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("ConcurrencyWaitTime")]
            [Validation(Required=false)]
            public double? ConcurrencyWaitTime { get; set; }

            /// <summary>
            /// <para>Consistency level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ConsistencyLevel")]
            [Validation(Required=false)]
            public string ConsistencyLevel { get; set; }

            /// <summary>
            /// <para>CPU time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>3377.57</para>
            /// </summary>
            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public double? CpuTime { get; set; }

            /// <summary>
            /// <para>Database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>Syntax parsing time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("DecodeTime")]
            [Validation(Required=false)]
            public double? DecodeTime { get; set; }

            /// <summary>
            /// <para>Disk read count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>96972.0</para>
            /// </summary>
            [NameInMap("DiskReads")]
            [Validation(Required=false)]
            public double? DiskReads { get; set; }

            /// <summary>
            /// <para>Response time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2182.66</para>
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public double? ElapsedTime { get; set; }

            /// <summary>
            /// <para>Plan execution time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>8262.01</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public double? ExecuteTime { get; set; }

            /// <summary>
            /// <para>Whether to initiate RPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("ExecutorRpc")]
            [Validation(Required=false)]
            public bool? ExecutorRpc { get; set; }

            /// <summary>
            /// <para>Degree of parallelism.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExpectedWorkerCount")]
            [Validation(Required=false)]
            public double? ExpectedWorkerCount { get; set; }

            /// <summary>
            /// <para>The full SQL text. </para>
            /// <remarks>
            /// <para>This parameter is unavailable.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>select * from test where c1 &gt; 1 and c2 &gt; 3;</para>
            /// </summary>
            [NameInMap("FullSqlText")]
            [Validation(Required=false)]
            public string FullSqlText { get; set; }

            /// <summary>
            /// <para>Plan generation time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.19</para>
            /// </summary>
            [NameInMap("GetPlanTime")]
            [Validation(Required=false)]
            public double? GetPlanTime { get; set; }

            /// <summary>
            /// <para>Whether to hit the execution plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HitPlan")]
            [Validation(Required=false)]
            public bool? HitPlan { get; set; }

            /// <summary>
            /// <para>Whether an internal SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Inner")]
            [Validation(Required=false)]
            public bool? Inner { get; set; }

            /// <summary>
            /// <para>Memstore read row count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MemstoreReadRows")]
            [Validation(Required=false)]
            public double? MemstoreReadRows { get; set; }

            /// <summary>
            /// <para>Network transmission time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("NetTime")]
            [Validation(Required=false)]
            public double? NetTime { get; set; }

            /// <summary>
            /// <para>Network enqueue time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("NetWaitTime")]
            [Validation(Required=false)]
            public double? NetWaitTime { get; set; }

            /// <summary>
            /// <para>Database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11006111****4828</para>
            /// </summary>
            [NameInMap("ObDbId")]
            [Validation(Required=false)]
            public double? ObDbId { get; set; }

            /// <summary>
            /// <para>Server  ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ObServerId")]
            [Validation(Required=false)]
            public double? ObServerId { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100010</para>
            /// </summary>
            [NameInMap("ObUserId")]
            [Validation(Required=false)]
            public double? ObUserId { get; set; }

            /// <summary>
            /// <para>The parameter value of the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1****</para>
            /// </summary>
            [NameInMap("ParamsValue")]
            [Validation(Required=false)]
            public string ParamsValue { get; set; }

            /// <summary>
            /// <para>Average number of partition accessed during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("PartitionCount")]
            [Validation(Required=false)]
            public double? PartitionCount { get; set; }

            /// <summary>
            /// <para>The execution plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>590****</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public double? PlanId { get; set; }

            /// <summary>
            /// <para>Plan type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LOCAL</para>
            /// </summary>
            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            /// <summary>
            /// <para>Queueing time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.02</para>
            /// </summary>
            [NameInMap("QueueTime")]
            [Validation(Required=false)]
            public double? QueueTime { get; set; }

            /// <summary>
            /// <para>Request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>SQL request time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-12T04:46:38Z</para>
            /// </summary>
            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public string RequestTime { get; set; }

            /// <summary>
            /// <para>Result code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode")]
            [Validation(Required=false)]
            public double? RetCode { get; set; }

            /// <summary>
            /// <para>Retry count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public double? RetryCount { get; set; }

            /// <summary>
            /// <para>Average returned rows during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("ReturnRows")]
            [Validation(Required=false)]
            public double? ReturnRows { get; set; }

            /// <summary>
            /// <para>RowCache hit count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>498.0</para>
            /// </summary>
            [NameInMap("RowCacheHit")]
            [Validation(Required=false)]
            public double? RowCacheHit { get; set; }

            /// <summary>
            /// <para>Number of RPC sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("RpcCount")]
            [Validation(Required=false)]
            public double? RpcCount { get; set; }

            /// <summary>
            /// <para>Schedule event waiting time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public double? ScheduleTime { get; set; }

            /// <summary>
            /// <para>The server where the SQL is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1db1****8uemejio</para>
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// <para>The SQL text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select ** from t</para>
            /// </summary>
            [NameInMap("SqlText")]
            [Validation(Required=false)]
            public string SqlText { get; set; }

            /// <summary>
            /// <para>SQL type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// <para>Ssstore read row count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>986190</para>
            /// </summary>
            [NameInMap("SsstoreReadRows")]
            [Validation(Required=false)]
            public double? SsstoreReadRows { get; set; }

            /// <summary>
            /// <para>Parameterized SQL text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select a from b</para>
            /// </summary>
            [NameInMap("Statement")]
            [Validation(Required=false)]
            public string Statement { get; set; }

            /// <summary>
            /// <para>Whether to perform full table scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TableScan")]
            [Validation(Required=false)]
            public bool? TableScan { get; set; }

            /// <summary>
            /// <para>Trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YB42C****-0005E303D1****-0-0</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// <para>Transaction hash.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1219<b><b>927</b></b>73791</para>
            /// </summary>
            [NameInMap("TransHash")]
            [Validation(Required=false)]
            public string TransHash { get; set; }

            /// <summary>
            /// <para>Actual number of SQL execution threads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UsedWorkerCount")]
            [Validation(Required=false)]
            public double? UsedWorkerCount { get; set; }

            /// <summary>
            /// <para>UserIO event waiting time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("UserIoWaitTime")]
            [Validation(Required=false)]
            public double? UserIoWaitTime { get; set; }

            /// <summary>
            /// <para>Username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>Wait count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("WaitCount")]
            [Validation(Required=false)]
            public double? WaitCount { get; set; }

            /// <summary>
            /// <para>Longest wait event during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("WaitEvent")]
            [Validation(Required=false)]
            public string WaitEvent { get; set; }

            /// <summary>
            /// <para>Wait time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("WaitTime")]
            [Validation(Required=false)]
            public double? WaitTime { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
