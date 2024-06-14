// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasSlowSQLListResponseBody : TeaModel {
        /// <summary>
        /// The list of slow queries.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOasSlowSQLListResponseBodyData> Data { get; set; }
        public class DescribeOasSlowSQLListResponseBodyData : TeaModel {
            /// <summary>
            /// Average updated rows during the execution period.
            /// </summary>
            [NameInMap("AvgAffectedRows")]
            [Validation(Required=false)]
            public double? AvgAffectedRows { get; set; }

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
            public double? AvgBlockCacheHit { get; set; }

            /// <summary>
            /// Average BlockIndexCache hit count during the execution period.
            /// </summary>
            [NameInMap("AvgBlockIndexCacheHit")]
            [Validation(Required=false)]
            public double? AvgBlockIndexCacheHit { get; set; }

            /// <summary>
            /// Average BloomFilterCache hit count during the execution period.
            /// </summary>
            [NameInMap("AvgBloomFilterCacheHit")]
            [Validation(Required=false)]
            public double? AvgBloomFilterCacheHit { get; set; }

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

            [NameInMap("AvgDbTime")]
            [Validation(Required=false)]
            public double? AvgDbTime { get; set; }

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
            public double? AvgDiskReads { get; set; }

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
            /// Average logical reads of the SQL during the execution period.
            /// </summary>
            [NameInMap("AvgLogicalReads")]
            [Validation(Required=false)]
            public double? AvgLogicalReads { get; set; }

            /// <summary>
            /// Strong consistent transaction percentage during the execution period.
            /// </summary>
            [NameInMap("AvgMemstoreReadRows")]
            [Validation(Required=false)]
            public double? AvgMemstoreReadRows { get; set; }

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
            public double? AvgReturnRows { get; set; }

            /// <summary>
            /// Average RowCache hit count during the execution period.
            /// </summary>
            [NameInMap("AvgRowCacheHit")]
            [Validation(Required=false)]
            public double? AvgRowCacheHit { get; set; }

            /// <summary>
            /// Average number of RPC sent during the execution.
            /// </summary>
            [NameInMap("AvgRpcCount")]
            [Validation(Required=false)]
            public double? AvgRpcCount { get; set; }

            /// <summary>
            /// Average Schedule event wait time (in milliseconds) during the scheduling period.
            /// </summary>
            [NameInMap("AvgScheduleTime")]
            [Validation(Required=false)]
            public double? AvgScheduleTime { get; set; }

            /// <summary>
            /// Eventually consistent transaction percentage during the execution period.
            /// </summary>
            [NameInMap("AvgSsstoreReadRows")]
            [Validation(Required=false)]
            public double? AvgSsstoreReadRows { get; set; }

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
            /// Client IP.
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

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

            [NameInMap("DynamicSql")]
            [Validation(Required=false)]
            public bool? DynamicSql { get; set; }

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
            public double? Executions { get; set; }

            /// <summary>
            /// Average number of partition accessed during the execution period.
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public double? FailCount { get; set; }

            /// <summary>
            /// Error percentage during the execution period.
            /// </summary>
            [NameInMap("FailPercentage")]
            [Validation(Required=false)]
            public double? FailPercentage { get; set; }

            /// <summary>
            /// Whether an internal SQL.
            /// </summary>
            [NameInMap("Inner")]
            [Validation(Required=false)]
            public bool? Inner { get; set; }

            /// <summary>
            /// Local plan percentage during the execution period.
            /// </summary>
            [NameInMap("LocalPlanPercentage")]
            [Validation(Required=false)]
            public double? LocalPlanPercentage { get; set; }

            /// <summary>
            /// Max affected rows during the execution period.
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
            /// Max response time during the execution period.
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
            /// Max UserIO event wait time (in milliseconds) during the execution period.
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
            /// Missed hit count of the execution plan during the execution period.
            /// </summary>
            [NameInMap("MissPlans")]
            [Validation(Required=false)]
            public double? MissPlans { get; set; }

            /// <summary>
            /// Remote plan percentage during the execution period.
            /// </summary>
            [NameInMap("RemotePlanPercentage")]
            [Validation(Required=false)]
            public double? RemotePlanPercentage { get; set; }

            /// <summary>
            /// Remote execution count during the execution period.
            /// </summary>
            [NameInMap("RemotePlans")]
            [Validation(Required=false)]
            public double? RemotePlans { get; set; }

            /// <summary>
            /// Number of occurrences of code 4012 during the execution period.
            /// </summary>
            [NameInMap("RetCode4012Count")]
            [Validation(Required=false)]
            public long? RetCode4012Count { get; set; }

            /// <summary>
            /// Number of occurrences of code 4013 during the execution period.
            /// </summary>
            [NameInMap("RetCode4013Count")]
            [Validation(Required=false)]
            public long? RetCode4013Count { get; set; }

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
            public double? RetryCount { get; set; }

            /// <summary>
            /// RPC count during the execution period.
            /// </summary>
            [NameInMap("RpcCount")]
            [Validation(Required=false)]
            public double? RpcCount { get; set; }

            /// <summary>
            /// The server where the SQL is executed.
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// The IP address of the server.
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// The server port where the SQL is executed.
            /// </summary>
            [NameInMap("ServerPort")]
            [Validation(Required=false)]
            public long? ServerPort { get; set; }

            /// <summary>
            /// SQL ID.
            /// </summary>
            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            [NameInMap("SqlList")]
            [Validation(Required=false)]
            public List<DescribeOasSlowSQLListResponseBodyDataSqlList> SqlList { get; set; }
            public class DescribeOasSlowSQLListResponseBodyDataSqlList : TeaModel {
                [NameInMap("AvgAffectedRows")]
                [Validation(Required=false)]
                public double? AvgAffectedRows { get; set; }

                [NameInMap("AvgApplicationWaitTime")]
                [Validation(Required=false)]
                public double? AvgApplicationWaitTime { get; set; }

                [NameInMap("AvgBlockCacheHit")]
                [Validation(Required=false)]
                public double? AvgBlockCacheHit { get; set; }

                [NameInMap("AvgBlockIndexCacheHit")]
                [Validation(Required=false)]
                public double? AvgBlockIndexCacheHit { get; set; }

                [NameInMap("AvgBloomFilterCacheHit")]
                [Validation(Required=false)]
                public double? AvgBloomFilterCacheHit { get; set; }

                [NameInMap("AvgConcurrencyWaitTime")]
                [Validation(Required=false)]
                public double? AvgConcurrencyWaitTime { get; set; }

                [NameInMap("AvgCpuTime")]
                [Validation(Required=false)]
                public double? AvgCpuTime { get; set; }

                [NameInMap("AvgDbTime")]
                [Validation(Required=false)]
                public double? AvgDbTime { get; set; }

                [NameInMap("AvgDecodeTime")]
                [Validation(Required=false)]
                public double? AvgDecodeTime { get; set; }

                [NameInMap("AvgDiskReads")]
                [Validation(Required=false)]
                public double? AvgDiskReads { get; set; }

                [NameInMap("AvgElapsedTime")]
                [Validation(Required=false)]
                public double? AvgElapsedTime { get; set; }

                [NameInMap("AvgExecuteTime")]
                [Validation(Required=false)]
                public double? AvgExecuteTime { get; set; }

                [NameInMap("AvgExecutorRpcCount")]
                [Validation(Required=false)]
                public double? AvgExecutorRpcCount { get; set; }

                [NameInMap("AvgExpectedWorkerCount")]
                [Validation(Required=false)]
                public double? AvgExpectedWorkerCount { get; set; }

                [NameInMap("AvgGetPlanTime")]
                [Validation(Required=false)]
                public double? AvgGetPlanTime { get; set; }

                [NameInMap("AvgLogicalReads")]
                [Validation(Required=false)]
                public double? AvgLogicalReads { get; set; }

                [NameInMap("AvgMemstoreReadRows")]
                [Validation(Required=false)]
                public double? AvgMemstoreReadRows { get; set; }

                [NameInMap("AvgNetTime")]
                [Validation(Required=false)]
                public double? AvgNetTime { get; set; }

                [NameInMap("AvgNetWaitTime")]
                [Validation(Required=false)]
                public double? AvgNetWaitTime { get; set; }

                [NameInMap("AvgPartitionCount")]
                [Validation(Required=false)]
                public double? AvgPartitionCount { get; set; }

                [NameInMap("AvgQueueTime")]
                [Validation(Required=false)]
                public double? AvgQueueTime { get; set; }

                [NameInMap("AvgReturnRows")]
                [Validation(Required=false)]
                public double? AvgReturnRows { get; set; }

                [NameInMap("AvgRowCacheHit")]
                [Validation(Required=false)]
                public double? AvgRowCacheHit { get; set; }

                [NameInMap("AvgRpcCount")]
                [Validation(Required=false)]
                public double? AvgRpcCount { get; set; }

                [NameInMap("AvgScheduleTime")]
                [Validation(Required=false)]
                public double? AvgScheduleTime { get; set; }

                [NameInMap("AvgSsstoreReadRows")]
                [Validation(Required=false)]
                public double? AvgSsstoreReadRows { get; set; }

                [NameInMap("AvgUsedWorkerCount")]
                [Validation(Required=false)]
                public double? AvgUsedWorkerCount { get; set; }

                [NameInMap("AvgUserIoWaitTime")]
                [Validation(Required=false)]
                public double? AvgUserIoWaitTime { get; set; }

                [NameInMap("AvgWaitCount")]
                [Validation(Required=false)]
                public double? AvgWaitCount { get; set; }

                [NameInMap("AvgWaitTime")]
                [Validation(Required=false)]
                public double? AvgWaitTime { get; set; }

                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                [NameInMap("DistPlanPercentage")]
                [Validation(Required=false)]
                public double? DistPlanPercentage { get; set; }

                [NameInMap("ExecPs")]
                [Validation(Required=false)]
                public double? ExecPs { get; set; }

                [NameInMap("Executions")]
                [Validation(Required=false)]
                public double? Executions { get; set; }

                [NameInMap("FailCount")]
                [Validation(Required=false)]
                public double? FailCount { get; set; }

                [NameInMap("FailPercentage")]
                [Validation(Required=false)]
                public double? FailPercentage { get; set; }

                [NameInMap("Inner")]
                [Validation(Required=false)]
                public bool? Inner { get; set; }

                [NameInMap("LocalPlanPercentage")]
                [Validation(Required=false)]
                public double? LocalPlanPercentage { get; set; }

                [NameInMap("MaxAffectedRows")]
                [Validation(Required=false)]
                public double? MaxAffectedRows { get; set; }

                [NameInMap("MaxApplicationWaitTime")]
                [Validation(Required=false)]
                public double? MaxApplicationWaitTime { get; set; }

                [NameInMap("MaxConcurrencyWaitTime")]
                [Validation(Required=false)]
                public double? MaxConcurrencyWaitTime { get; set; }

                [NameInMap("MaxCpuTime")]
                [Validation(Required=false)]
                public double? MaxCpuTime { get; set; }

                [NameInMap("MaxDiskReads")]
                [Validation(Required=false)]
                public double? MaxDiskReads { get; set; }

                [NameInMap("MaxElapsedTime")]
                [Validation(Required=false)]
                public double? MaxElapsedTime { get; set; }

                [NameInMap("MaxReturnRows")]
                [Validation(Required=false)]
                public double? MaxReturnRows { get; set; }

                [NameInMap("MaxUserIoWaitTime")]
                [Validation(Required=false)]
                public double? MaxUserIoWaitTime { get; set; }

                [NameInMap("MaxWaitTime")]
                [Validation(Required=false)]
                public double? MaxWaitTime { get; set; }

                [NameInMap("MissPlanPercentage")]
                [Validation(Required=false)]
                public double? MissPlanPercentage { get; set; }

                [NameInMap("MissPlans")]
                [Validation(Required=false)]
                public double? MissPlans { get; set; }

                [NameInMap("RemotePlanPercentage")]
                [Validation(Required=false)]
                public double? RemotePlanPercentage { get; set; }

                [NameInMap("RemotePlans")]
                [Validation(Required=false)]
                public double? RemotePlans { get; set; }

                [NameInMap("RetCode4012Count")]
                [Validation(Required=false)]
                public long? RetCode4012Count { get; set; }

                [NameInMap("RetCode4013Count")]
                [Validation(Required=false)]
                public long? RetCode4013Count { get; set; }

                [NameInMap("RetCode5001Count")]
                [Validation(Required=false)]
                public long? RetCode5001Count { get; set; }

                [NameInMap("RetCode5024Count")]
                [Validation(Required=false)]
                public long? RetCode5024Count { get; set; }

                [NameInMap("RetCode5167Count")]
                [Validation(Required=false)]
                public long? RetCode5167Count { get; set; }

                [NameInMap("RetCode5217Count")]
                [Validation(Required=false)]
                public long? RetCode5217Count { get; set; }

                [NameInMap("RetCode6002Count")]
                [Validation(Required=false)]
                public long? RetCode6002Count { get; set; }

                [NameInMap("RetryCount")]
                [Validation(Required=false)]
                public double? RetryCount { get; set; }

                [NameInMap("RpcCount")]
                [Validation(Required=false)]
                public double? RpcCount { get; set; }

                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                [NameInMap("ServerPort")]
                [Validation(Required=false)]
                public long? ServerPort { get; set; }

                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                [NameInMap("SqlTextShort")]
                [Validation(Required=false)]
                public string SqlTextShort { get; set; }

                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                [NameInMap("StrongConsistencyPercentage")]
                [Validation(Required=false)]
                public double? StrongConsistencyPercentage { get; set; }

                [NameInMap("SumDbTime")]
                [Validation(Required=false)]
                public double? SumDbTime { get; set; }

                [NameInMap("SumElapsedTime")]
                [Validation(Required=false)]
                public double? SumElapsedTime { get; set; }

                [NameInMap("SumLogicalReads")]
                [Validation(Required=false)]
                public double? SumLogicalReads { get; set; }

                [NameInMap("SumWaitTime")]
                [Validation(Required=false)]
                public double? SumWaitTime { get; set; }

                [NameInMap("TableScanPercentage")]
                [Validation(Required=false)]
                public double? TableScanPercentage { get; set; }

                [NameInMap("TotalWaitTime")]
                [Validation(Required=false)]
                public double? TotalWaitTime { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("WaitEvent")]
                [Validation(Required=false)]
                public string WaitEvent { get; set; }

                [NameInMap("WeakConsistencyPercentage")]
                [Validation(Required=false)]
                public double? WeakConsistencyPercentage { get; set; }

            }

            /// <summary>
            /// SQL text (the first 100 characters).
            /// </summary>
            [NameInMap("SqlTextShort")]
            [Validation(Required=false)]
            public string SqlTextShort { get; set; }

            /// <summary>
            /// SQL type.
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// Strong consistent transaction percentage during the execution period.
            /// </summary>
            [NameInMap("StrongConsistencyPercentage")]
            [Validation(Required=false)]
            public double? StrongConsistencyPercentage { get; set; }

            [NameInMap("SumDbTime")]
            [Validation(Required=false)]
            public double? SumDbTime { get; set; }

            /// <summary>
            /// Total response time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("SumElapsedTime")]
            [Validation(Required=false)]
            public double? SumElapsedTime { get; set; }

            /// <summary>
            /// Total logical reads of the SQL during the execution period.
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
            /// Total wait time during the execution period.
            /// </summary>
            [NameInMap("TotalWaitTime")]
            [Validation(Required=false)]
            public double? TotalWaitTime { get; set; }

            /// <summary>
            /// Username.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// Longest wait event during the execution period.
            /// </summary>
            [NameInMap("WaitEvent")]
            [Validation(Required=false)]
            public string WaitEvent { get; set; }

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
