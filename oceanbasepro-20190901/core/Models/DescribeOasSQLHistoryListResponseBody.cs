// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasSQLHistoryListResponseBody : TeaModel {
        /// <summary>
        /// The list of SQL execution history.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOasSQLHistoryListResponseBodyData> Data { get; set; }
        public class DescribeOasSQLHistoryListResponseBodyData : TeaModel {
            /// <summary>
            /// Average updated rows during the execution period.
            /// </summary>
            [NameInMap("AvgAffectedRows")]
            [Validation(Required=false)]
            public long? AvgAffectedRows { get; set; }

            /// <summary>
            /// Average Application event wait time (in milliseconds) during the client waiting period.
            /// </summary>
            [NameInMap("AvgApplicationWaitTime")]
            [Validation(Required=false)]
            public double? AvgApplicationWaitTime { get; set; }

            /// <summary>
            /// Average BlockCache hit count during the execution period.
            /// </summary>
            [NameInMap("AvgBlockCacheHit")]
            [Validation(Required=false)]
            public long? AvgBlockCacheHit { get; set; }

            /// <summary>
            /// Average BlockIndexCache hit count during the execution period.
            /// </summary>
            [NameInMap("AvgBlockIndexCacheHit")]
            [Validation(Required=false)]
            public long? AvgBlockIndexCacheHit { get; set; }

            /// <summary>
            /// Average BloomFilterCache hit count during the execution period.
            /// </summary>
            [NameInMap("AvgBloomFilterCacheHit")]
            [Validation(Required=false)]
            public long? AvgBloomFilterCacheHit { get; set; }

            /// <summary>
            /// Average Concurrency event wait time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("AvgConcurrencyWaitTime")]
            [Validation(Required=false)]
            public double? AvgConcurrencyWaitTime { get; set; }

            /// <summary>
            /// Average CPU time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("AvgCpuTime")]
            [Validation(Required=false)]
            public double? AvgCpuTime { get; set; }

            /// <summary>
            /// Average syntax parsing time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("AvgDecodeTime")]
            [Validation(Required=false)]
            public double? AvgDecodeTime { get; set; }

            /// <summary>
            /// Average physical read count during the execution period.
            /// </summary>
            [NameInMap("AvgDiskReads")]
            [Validation(Required=false)]
            public long? AvgDiskReads { get; set; }

            /// <summary>
            /// Average response time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("AvgElapsedTime")]
            [Validation(Required=false)]
            public double? AvgElapsedTime { get; set; }

            /// <summary>
            /// Average plan execution time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("AvgExecuteTime")]
            [Validation(Required=false)]
            public double? AvgExecuteTime { get; set; }

            /// <summary>
            /// Average number of RPC requests executed during the execution period.
            /// </summary>
            [NameInMap("AvgExecutorRpcCount")]
            [Validation(Required=false)]
            public double? AvgExecutorRpcCount { get; set; }

            /// <summary>
            /// Average degree of parallelism during the execution period.
            /// </summary>
            [NameInMap("AvgExpectedWorkerCount")]
            [Validation(Required=false)]
            public double? AvgExpectedWorkerCount { get; set; }

            /// <summary>
            /// Average plan generation time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("AvgGetPlanTime")]
            [Validation(Required=false)]
            public double? AvgGetPlanTime { get; set; }

            /// <summary>
            /// Average logical reads during the execution period.
            /// </summary>
            [NameInMap("AvgLogicalReads")]
            [Validation(Required=false)]
            public long? AvgLogicalReads { get; set; }

            /// <summary>
            /// Average Memstore read rows during the execution period.
            /// </summary>
            [NameInMap("AvgMemstoreReadRows")]
            [Validation(Required=false)]
            public long? AvgMemstoreReadRows { get; set; }

            /// <summary>
            /// Average network transmission time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("AvgNetTime")]
            [Validation(Required=false)]
            public double? AvgNetTime { get; set; }

            /// <summary>
            /// Average network enqueue time (in milliseconds) during the network waiting period.
            /// </summary>
            [NameInMap("AvgNetWaitTime")]
            [Validation(Required=false)]
            public double? AvgNetWaitTime { get; set; }

            /// <summary>
            /// Average number of partition accessed during the execution period.
            /// </summary>
            [NameInMap("AvgPartitionCount")]
            [Validation(Required=false)]
            public double? AvgPartitionCount { get; set; }

            /// <summary>
            /// Average queueing time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("AvgQueueTime")]
            [Validation(Required=false)]
            public double? AvgQueueTime { get; set; }

            /// <summary>
            /// Average number of rows returned during the execution period.
            /// </summary>
            [NameInMap("AvgReturnRows")]
            [Validation(Required=false)]
            public long? AvgReturnRows { get; set; }

            /// <summary>
            /// Average RowCache hit count during the execution period.
            /// </summary>
            [NameInMap("AvgRowCacheHit")]
            [Validation(Required=false)]
            public long? AvgRowCacheHit { get; set; }

            /// <summary>
            /// Average number of RPC sent during the execution.
            /// </summary>
            [NameInMap("AvgRpcCount")]
            [Validation(Required=false)]
            public long? AvgRpcCount { get; set; }

            /// <summary>
            /// Average Schedule event wait time (in milliseconds) during the scheduling period.
            /// </summary>
            [NameInMap("AvgScheduleTime")]
            [Validation(Required=false)]
            public double? AvgScheduleTime { get; set; }

            /// <summary>
            /// Average Ssstore read rows during the execution period.
            /// </summary>
            [NameInMap("AvgSsstoreReadRows")]
            [Validation(Required=false)]
            public long? AvgSsstoreReadRows { get; set; }

            /// <summary>
            /// Average number of threads used of the SQL during the execution period.
            /// </summary>
            [NameInMap("AvgUsedWorkerCount")]
            [Validation(Required=false)]
            public double? AvgUsedWorkerCount { get; set; }

            /// <summary>
            /// Average UserIO event wait time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("AvgUserIoWaitTime")]
            [Validation(Required=false)]
            public double? AvgUserIoWaitTime { get; set; }

            /// <summary>
            /// Average number of waits during the execution period.
            /// </summary>
            [NameInMap("AvgWaitCount")]
            [Validation(Required=false)]
            public double? AvgWaitCount { get; set; }

            /// <summary>
            /// Average wait time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("AvgWaitTime")]
            [Validation(Required=false)]
            public double? AvgWaitTime { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// Distributed plan percentage during the execution period.
            /// </summary>
            [NameInMap("DistPlanPercentage")]
            [Validation(Required=false)]
            public double? DistPlanPercentage { get; set; }

            /// <summary>
            /// Average execution count per second during the execution period.
            /// </summary>
            [NameInMap("ExecPs")]
            [Validation(Required=false)]
            public double? ExecPs { get; set; }

            /// <summary>
            /// Total number of executions during the execution period.
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            /// <summary>
            /// The total number of errors during the execution period.
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// Error percentage during the execution period.
            /// </summary>
            [NameInMap("FailPercentage")]
            [Validation(Required=false)]
            public double? FailPercentage { get; set; }

            /// <summary>
            /// Local plan percentage during the execution period.
            /// </summary>
            [NameInMap("LocalPlanPercentage")]
            [Validation(Required=false)]
            public double? LocalPlanPercentage { get; set; }

            /// <summary>
            /// Max updated rows during the execution period.
            /// </summary>
            [NameInMap("MaxAffectedRows")]
            [Validation(Required=false)]
            public double? MaxAffectedRows { get; set; }

            /// <summary>
            /// Max Application event wait time (in milliseconds) during the execution period
            /// </summary>
            [NameInMap("MaxApplicationWaitTime")]
            [Validation(Required=false)]
            public double? MaxApplicationWaitTime { get; set; }

            /// <summary>
            /// Max Concurrency event wait time (in milliseconds) during the execution period
            /// </summary>
            [NameInMap("MaxConcurrencyWaitTime")]
            [Validation(Required=false)]
            public double? MaxConcurrencyWaitTime { get; set; }

            /// <summary>
            /// Max CPU time.
            /// </summary>
            [NameInMap("MaxCpuTime")]
            [Validation(Required=false)]
            public double? MaxCpuTime { get; set; }

            /// <summary>
            /// Max physical read count during the execution period.
            /// </summary>
            [NameInMap("MaxDiskReads")]
            [Validation(Required=false)]
            public double? MaxDiskReads { get; set; }

            /// <summary>
            /// Max response time.
            /// </summary>
            [NameInMap("MaxElapsedTime")]
            [Validation(Required=false)]
            public double? MaxElapsedTime { get; set; }

            /// <summary>
            /// Max returned rows during the execution period.
            /// </summary>
            [NameInMap("MaxReturnRows")]
            [Validation(Required=false)]
            public double? MaxReturnRows { get; set; }

            /// <summary>
            /// Max UserIO event wait time (in milliseconds) during the execution period
            /// </summary>
            [NameInMap("MaxUserIoWaitTime")]
            [Validation(Required=false)]
            public double? MaxUserIoWaitTime { get; set; }

            /// <summary>
            /// Max wait time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("MaxWaitTime")]
            [Validation(Required=false)]
            public double? MaxWaitTime { get; set; }

            /// <summary>
            /// Plan hit rage during the execution period.
            /// </summary>
            [NameInMap("MissPlanPercentage")]
            [Validation(Required=false)]
            public double? MissPlanPercentage { get; set; }

            /// <summary>
            /// Missed plan count.
            /// </summary>
            [NameInMap("MissPlans")]
            [Validation(Required=false)]
            public long? MissPlans { get; set; }

            /// <summary>
            /// Remote plan percentage during the execution period.
            /// </summary>
            [NameInMap("RemotePlanPercentage")]
            [Validation(Required=false)]
            public double? RemotePlanPercentage { get; set; }

            /// <summary>
            /// Remote plan count.
            /// </summary>
            [NameInMap("RemotePlans")]
            [Validation(Required=false)]
            public long? RemotePlans { get; set; }

            /// <summary>
            /// Number of occurrences of code 4012 during the execution period.
            /// </summary>
            [NameInMap("RetCode4012Count")]
            [Validation(Required=false)]
            public double? RetCode4012Count { get; set; }

            /// <summary>
            /// Number of occurrences of code 4013 during the execution period.
            /// </summary>
            [NameInMap("RetCode4013Count")]
            [Validation(Required=false)]
            public double? RetCode4013Count { get; set; }

            /// <summary>
            /// Number of occurrences of code 5001 during the execution period.
            /// </summary>
            [NameInMap("RetCode5001Count")]
            [Validation(Required=false)]
            public double? RetCode5001Count { get; set; }

            /// <summary>
            /// Number of occurrences of code 5024 during the execution period.
            /// </summary>
            [NameInMap("RetCode5024Count")]
            [Validation(Required=false)]
            public double? RetCode5024Count { get; set; }

            /// <summary>
            /// Number of occurrences of code 5167 during the execution period.
            /// </summary>
            [NameInMap("RetCode5167Count")]
            [Validation(Required=false)]
            public double? RetCode5167Count { get; set; }

            /// <summary>
            /// Number of occurrences of code 5217 during the execution period.
            /// </summary>
            [NameInMap("RetCode5217Count")]
            [Validation(Required=false)]
            public double? RetCode5217Count { get; set; }

            /// <summary>
            /// Number of occurrences of code 6002 during the execution period.
            /// </summary>
            [NameInMap("RetCode6002Count")]
            [Validation(Required=false)]
            public double? RetCode6002Count { get; set; }

            /// <summary>
            /// Total number of retries during the execution period.
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public long? RetryCount { get; set; }

            /// <summary>
            /// SQL ID.
            /// </summary>
            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public string SQLId { get; set; }

            /// <summary>
            /// The server where the SQL is executed.
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// Strong consistent transaction percentage during the execution period.
            /// </summary>
            [NameInMap("StrongConsistencyPercentage")]
            [Validation(Required=false)]
            public double? StrongConsistencyPercentage { get; set; }

            /// <summary>
            /// Total response time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("SumElapsedTime")]
            [Validation(Required=false)]
            public double? SumElapsedTime { get; set; }

            /// <summary>
            /// Total logical reads.
            /// </summary>
            [NameInMap("SumLogicalReads")]
            [Validation(Required=false)]
            public double? SumLogicalReads { get; set; }

            /// <summary>
            /// The total wait time (in milliseconds) during the internal waiting period.
            /// </summary>
            [NameInMap("SumWaitTime")]
            [Validation(Required=false)]
            public double? SumWaitTime { get; set; }

            /// <summary>
            /// Table scan percentage during the execution period.
            /// </summary>
            [NameInMap("TableScanPercentage")]
            [Validation(Required=false)]
            public double? TableScanPercentage { get; set; }

            /// <summary>
            /// Timestamp for the sample.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// Username.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// Eventually consistent transaction percentage during the execution period.
            /// </summary>
            [NameInMap("WeakConsistencyPercentage")]
            [Validation(Required=false)]
            public double? WeakConsistencyPercentage { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
