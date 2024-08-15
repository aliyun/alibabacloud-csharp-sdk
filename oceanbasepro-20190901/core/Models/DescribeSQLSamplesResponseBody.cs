// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLSamplesResponseBody : TeaModel {
        /// <summary>
        /// The list of sample data of slow query execution details.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSQLSamplesResponseBodyData> Data { get; set; }
        public class DescribeSQLSamplesResponseBodyData : TeaModel {
            /// <summary>
            /// Average updated rows during the execution period.
            /// </summary>
            [NameInMap("AffectedRows")]
            [Validation(Required=false)]
            public double? AffectedRows { get; set; }

            /// <summary>
            /// Application event waiting time (in milliseconds).
            /// </summary>
            [NameInMap("ApplicationWaitTime")]
            [Validation(Required=false)]
            public double? ApplicationWaitTime { get; set; }

            /// <summary>
            /// BlockCache hit count
            /// </summary>
            [NameInMap("BlockCacheHit")]
            [Validation(Required=false)]
            public double? BlockCacheHit { get; set; }

            /// <summary>
            /// BlockIndexCache hit count
            /// </summary>
            [NameInMap("BlockIndexCacheHit")]
            [Validation(Required=false)]
            public double? BlockIndexCacheHit { get; set; }

            /// <summary>
            /// BloomFilterCache hit count.
            /// </summary>
            [NameInMap("BloomFilterCacheHit")]
            [Validation(Required=false)]
            public double? BloomFilterCacheHit { get; set; }

            /// <summary>
            /// Client IP.
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// Client port.
            /// </summary>
            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public string ClientPort { get; set; }

            /// <summary>
            /// Concurrency event waiting time (in milliseconds).
            /// </summary>
            [NameInMap("ConcurrencyWaitTime")]
            [Validation(Required=false)]
            public double? ConcurrencyWaitTime { get; set; }

            /// <summary>
            /// Consistency level.
            /// </summary>
            [NameInMap("ConsistencyLevel")]
            [Validation(Required=false)]
            public string ConsistencyLevel { get; set; }

            /// <summary>
            /// CPU time (in milliseconds).
            /// </summary>
            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public double? CpuTime { get; set; }

            /// <summary>
            /// Database name.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// Syntax parsing time (in milliseconds).
            /// </summary>
            [NameInMap("DecodeTime")]
            [Validation(Required=false)]
            public double? DecodeTime { get; set; }

            /// <summary>
            /// Disk read count.
            /// </summary>
            [NameInMap("DiskReads")]
            [Validation(Required=false)]
            public double? DiskReads { get; set; }

            /// <summary>
            /// Response time (in milliseconds).
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public double? ElapsedTime { get; set; }

            /// <summary>
            /// Plan execution time (in milliseconds).
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public double? ExecuteTime { get; set; }

            /// <summary>
            /// Whether to initiate RPC.
            /// </summary>
            [NameInMap("ExecutorRpc")]
            [Validation(Required=false)]
            public bool? ExecutorRpc { get; set; }

            /// <summary>
            /// Degree of parallelism.
            /// </summary>
            [NameInMap("ExpectedWorkerCount")]
            [Validation(Required=false)]
            public double? ExpectedWorkerCount { get; set; }

            [NameInMap("FullSqlText")]
            [Validation(Required=false)]
            public string FullSqlText { get; set; }

            /// <summary>
            /// Plan generation time (in milliseconds).
            /// </summary>
            [NameInMap("GetPlanTime")]
            [Validation(Required=false)]
            public double? GetPlanTime { get; set; }

            /// <summary>
            /// Whether to hit the execution plan.
            /// </summary>
            [NameInMap("HitPlan")]
            [Validation(Required=false)]
            public bool? HitPlan { get; set; }

            /// <summary>
            /// Whether an internal SQL.
            /// </summary>
            [NameInMap("Inner")]
            [Validation(Required=false)]
            public bool? Inner { get; set; }

            /// <summary>
            /// Memstore read row count.
            /// </summary>
            [NameInMap("MemstoreReadRows")]
            [Validation(Required=false)]
            public double? MemstoreReadRows { get; set; }

            /// <summary>
            /// Network transmission time (in milliseconds).
            /// </summary>
            [NameInMap("NetTime")]
            [Validation(Required=false)]
            public double? NetTime { get; set; }

            /// <summary>
            /// Network enqueue time (in milliseconds).
            /// </summary>
            [NameInMap("NetWaitTime")]
            [Validation(Required=false)]
            public double? NetWaitTime { get; set; }

            /// <summary>
            /// Database ID.
            /// </summary>
            [NameInMap("ObDbId")]
            [Validation(Required=false)]
            public double? ObDbId { get; set; }

            /// <summary>
            /// Server  ID.
            /// </summary>
            [NameInMap("ObServerId")]
            [Validation(Required=false)]
            public double? ObServerId { get; set; }

            /// <summary>
            /// User ID.
            /// </summary>
            [NameInMap("ObUserId")]
            [Validation(Required=false)]
            public double? ObUserId { get; set; }

            [NameInMap("ParamsValue")]
            [Validation(Required=false)]
            public string ParamsValue { get; set; }

            /// <summary>
            /// Average number of partition accessed during the execution period.
            /// </summary>
            [NameInMap("PartitionCount")]
            [Validation(Required=false)]
            public double? PartitionCount { get; set; }

            /// <summary>
            /// The execution plan ID.
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public double? PlanId { get; set; }

            /// <summary>
            /// Plan type.
            /// </summary>
            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            /// <summary>
            /// Queueing time (in milliseconds).
            /// </summary>
            [NameInMap("QueueTime")]
            [Validation(Required=false)]
            public double? QueueTime { get; set; }

            /// <summary>
            /// Request ID.
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// SQL request time.
            /// </summary>
            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public string RequestTime { get; set; }

            /// <summary>
            /// Result code.
            /// </summary>
            [NameInMap("RetCode")]
            [Validation(Required=false)]
            public double? RetCode { get; set; }

            /// <summary>
            /// Retry count.
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public double? RetryCount { get; set; }

            /// <summary>
            /// Average returned rows during the execution period.
            /// </summary>
            [NameInMap("ReturnRows")]
            [Validation(Required=false)]
            public double? ReturnRows { get; set; }

            /// <summary>
            /// RowCache hit count.
            /// </summary>
            [NameInMap("RowCacheHit")]
            [Validation(Required=false)]
            public double? RowCacheHit { get; set; }

            /// <summary>
            /// Number of RPC sent.
            /// </summary>
            [NameInMap("RpcCount")]
            [Validation(Required=false)]
            public double? RpcCount { get; set; }

            /// <summary>
            /// Schedule event waiting time (in milliseconds).
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public double? ScheduleTime { get; set; }

            /// <summary>
            /// The server where the SQL is executed.
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            [NameInMap("SqlText")]
            [Validation(Required=false)]
            public string SqlText { get; set; }

            /// <summary>
            /// SQL type.
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// Ssstore read row count.
            /// </summary>
            [NameInMap("SsstoreReadRows")]
            [Validation(Required=false)]
            public double? SsstoreReadRows { get; set; }

            /// <summary>
            /// Parameterized SQL text.
            /// </summary>
            [NameInMap("Statement")]
            [Validation(Required=false)]
            public string Statement { get; set; }

            /// <summary>
            /// Whether to perform full table scan.
            /// </summary>
            [NameInMap("TableScan")]
            [Validation(Required=false)]
            public bool? TableScan { get; set; }

            /// <summary>
            /// Trace ID.
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// Transaction hash.
            /// </summary>
            [NameInMap("TransHash")]
            [Validation(Required=false)]
            public string TransHash { get; set; }

            /// <summary>
            /// Actual number of SQL execution threads.
            /// </summary>
            [NameInMap("UsedWorkerCount")]
            [Validation(Required=false)]
            public double? UsedWorkerCount { get; set; }

            /// <summary>
            /// UserIO event waiting time (in milliseconds).
            /// </summary>
            [NameInMap("UserIoWaitTime")]
            [Validation(Required=false)]
            public double? UserIoWaitTime { get; set; }

            /// <summary>
            /// Username.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// Wait count.
            /// </summary>
            [NameInMap("WaitCount")]
            [Validation(Required=false)]
            public double? WaitCount { get; set; }

            /// <summary>
            /// Longest wait event during the execution period.
            /// </summary>
            [NameInMap("WaitEvent")]
            [Validation(Required=false)]
            public string WaitEvent { get; set; }

            /// <summary>
            /// Wait time (in milliseconds).
            /// </summary>
            [NameInMap("WaitTime")]
            [Validation(Required=false)]
            public double? WaitTime { get; set; }

        }

        /// <summary>
        /// Request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
