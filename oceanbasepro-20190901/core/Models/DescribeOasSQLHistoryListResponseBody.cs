// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasSQLHistoryListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of SQL execution history.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOasSQLHistoryListResponseBodyData> Data { get; set; }
        public class DescribeOasSQLHistoryListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Average updated rows during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9978.75</para>
            /// </summary>
            [NameInMap("AvgAffectedRows")]
            [Validation(Required=false)]
            public double? AvgAffectedRows { get; set; }

            /// <summary>
            /// <para>Average Application event wait time (in milliseconds) during the client waiting period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgApplicationWaitTime")]
            [Validation(Required=false)]
            public double? AvgApplicationWaitTime { get; set; }

            /// <summary>
            /// <para>Average BlockCache hit count during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgBlockCacheHit")]
            [Validation(Required=false)]
            public double? AvgBlockCacheHit { get; set; }

            /// <summary>
            /// <para>Average BlockIndexCache hit count during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgBlockIndexCacheHit")]
            [Validation(Required=false)]
            public double? AvgBlockIndexCacheHit { get; set; }

            /// <summary>
            /// <para>Average BloomFilterCache hit count during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgBloomFilterCacheHit")]
            [Validation(Required=false)]
            public double? AvgBloomFilterCacheHit { get; set; }

            /// <summary>
            /// <para>Average Concurrency event wait time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgConcurrencyWaitTime")]
            [Validation(Required=false)]
            public double? AvgConcurrencyWaitTime { get; set; }

            /// <summary>
            /// <para>Average CPU time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1875.34</para>
            /// </summary>
            [NameInMap("AvgCpuTime")]
            [Validation(Required=false)]
            public double? AvgCpuTime { get; set; }

            /// <summary>
            /// <para>The average DB time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AvgDbTime")]
            [Validation(Required=false)]
            public double? AvgDbTime { get; set; }

            /// <summary>
            /// <para>Average syntax parsing time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgDecodeTime")]
            [Validation(Required=false)]
            public double? AvgDecodeTime { get; set; }

            /// <summary>
            /// <para>Average physical read count during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgDiskReads")]
            [Validation(Required=false)]
            public double? AvgDiskReads { get; set; }

            /// <summary>
            /// <para>Average response time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1876.78</para>
            /// </summary>
            [NameInMap("AvgElapsedTime")]
            [Validation(Required=false)]
            public double? AvgElapsedTime { get; set; }

            /// <summary>
            /// <para>Average plan execution time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1895.7</para>
            /// </summary>
            [NameInMap("AvgExecuteTime")]
            [Validation(Required=false)]
            public double? AvgExecuteTime { get; set; }

            /// <summary>
            /// <para>Average number of RPC requests executed during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AvgExecutorRpcCount")]
            [Validation(Required=false)]
            public double? AvgExecutorRpcCount { get; set; }

            /// <summary>
            /// <para>Average degree of parallelism during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AvgExpectedWorkerCount")]
            [Validation(Required=false)]
            public double? AvgExpectedWorkerCount { get; set; }

            /// <summary>
            /// <para>Average plan generation time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgGetPlanTime")]
            [Validation(Required=false)]
            public double? AvgGetPlanTime { get; set; }

            /// <summary>
            /// <para>Average logical reads during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgLogicalReads")]
            [Validation(Required=false)]
            public double? AvgLogicalReads { get; set; }

            /// <summary>
            /// <para>Average Memstore read rows during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgMemstoreReadRows")]
            [Validation(Required=false)]
            public double? AvgMemstoreReadRows { get; set; }

            /// <summary>
            /// <para>Average network transmission time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("AvgNetTime")]
            [Validation(Required=false)]
            public double? AvgNetTime { get; set; }

            /// <summary>
            /// <para>Average network enqueue time (in milliseconds) during the network waiting period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgNetWaitTime")]
            [Validation(Required=false)]
            public double? AvgNetWaitTime { get; set; }

            /// <summary>
            /// <para>Average number of partition accessed during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AvgPartitionCount")]
            [Validation(Required=false)]
            public double? AvgPartitionCount { get; set; }

            /// <summary>
            /// <para>Average queueing time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("AvgQueueTime")]
            [Validation(Required=false)]
            public double? AvgQueueTime { get; set; }

            /// <summary>
            /// <para>Average number of rows returned during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgReturnRows")]
            [Validation(Required=false)]
            public double? AvgReturnRows { get; set; }

            /// <summary>
            /// <para>Average RowCache hit count during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgRowCacheHit")]
            [Validation(Required=false)]
            public double? AvgRowCacheHit { get; set; }

            /// <summary>
            /// <para>Average number of RPC sent during the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("AvgRpcCount")]
            [Validation(Required=false)]
            public double? AvgRpcCount { get; set; }

            /// <summary>
            /// <para>Average Schedule event wait time (in milliseconds) during the scheduling period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgScheduleTime")]
            [Validation(Required=false)]
            public double? AvgScheduleTime { get; set; }

            /// <summary>
            /// <para>Average Ssstore read rows during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgSsstoreReadRows")]
            [Validation(Required=false)]
            public double? AvgSsstoreReadRows { get; set; }

            /// <summary>
            /// <para>Average number of threads used of the SQL during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AvgUsedWorkerCount")]
            [Validation(Required=false)]
            public double? AvgUsedWorkerCount { get; set; }

            /// <summary>
            /// <para>Average UserIO event wait time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgUserIoWaitTime")]
            [Validation(Required=false)]
            public double? AvgUserIoWaitTime { get; set; }

            /// <summary>
            /// <para>Average number of waits during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AvgWaitCount")]
            [Validation(Required=false)]
            public double? AvgWaitCount { get; set; }

            /// <summary>
            /// <para>Average wait time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1442.49</para>
            /// </summary>
            [NameInMap("AvgWaitTime")]
            [Validation(Required=false)]
            public double? AvgWaitTime { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>Distributed plan percentage during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DistPlanPercentage")]
            [Validation(Required=false)]
            public double? DistPlanPercentage { get; set; }

            /// <summary>
            /// <para>Average execution count per second during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.31</para>
            /// </summary>
            [NameInMap("ExecPs")]
            [Validation(Required=false)]
            public double? ExecPs { get; set; }

            /// <summary>
            /// <para>Total number of executions during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            /// <summary>
            /// <para>The total number of errors during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// <para>Error percentage during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailPercentage")]
            [Validation(Required=false)]
            public double? FailPercentage { get; set; }

            /// <summary>
            /// <para>Local plan percentage during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LocalPlanPercentage")]
            [Validation(Required=false)]
            public double? LocalPlanPercentage { get; set; }

            /// <summary>
            /// <para>Max updated rows during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MaxAffectedRows")]
            [Validation(Required=false)]
            public double? MaxAffectedRows { get; set; }

            /// <summary>
            /// <para>Max Application event wait time (in milliseconds) during the execution period</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxApplicationWaitTime")]
            [Validation(Required=false)]
            public double? MaxApplicationWaitTime { get; set; }

            /// <summary>
            /// <para>Max Concurrency event wait time (in milliseconds) during the execution period</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxConcurrencyWaitTime")]
            [Validation(Required=false)]
            public double? MaxConcurrencyWaitTime { get; set; }

            /// <summary>
            /// <para>Max CPU time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13641.9</para>
            /// </summary>
            [NameInMap("MaxCpuTime")]
            [Validation(Required=false)]
            public double? MaxCpuTime { get; set; }

            /// <summary>
            /// <para>Max physical read count during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxDiskReads")]
            [Validation(Required=false)]
            public double? MaxDiskReads { get; set; }

            /// <summary>
            /// <para>Max response time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13643.3</para>
            /// </summary>
            [NameInMap("MaxElapsedTime")]
            [Validation(Required=false)]
            public double? MaxElapsedTime { get; set; }

            /// <summary>
            /// <para>Max returned rows during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxReturnRows")]
            [Validation(Required=false)]
            public double? MaxReturnRows { get; set; }

            /// <summary>
            /// <para>Max UserIO event wait time (in milliseconds) during the execution period</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxUserIoWaitTime")]
            [Validation(Required=false)]
            public double? MaxUserIoWaitTime { get; set; }

            /// <summary>
            /// <para>Max wait time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.4</para>
            /// </summary>
            [NameInMap("MaxWaitTime")]
            [Validation(Required=false)]
            public double? MaxWaitTime { get; set; }

            /// <summary>
            /// <para>Plan hit rage during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MissPlanPercentage")]
            [Validation(Required=false)]
            public double? MissPlanPercentage { get; set; }

            /// <summary>
            /// <para>Missed plan count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MissPlans")]
            [Validation(Required=false)]
            public long? MissPlans { get; set; }

            /// <summary>
            /// <para>Remote plan percentage during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemotePlanPercentage")]
            [Validation(Required=false)]
            public double? RemotePlanPercentage { get; set; }

            /// <summary>
            /// <para>Remote plan count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemotePlans")]
            [Validation(Required=false)]
            public long? RemotePlans { get; set; }

            /// <summary>
            /// <para>Number of occurrences of code 4012 during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode4012Count")]
            [Validation(Required=false)]
            public long? RetCode4012Count { get; set; }

            /// <summary>
            /// <para>Number of occurrences of code 4013 during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode4013Count")]
            [Validation(Required=false)]
            public long? RetCode4013Count { get; set; }

            /// <summary>
            /// <para>Number of occurrences of code 5001 during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode5001Count")]
            [Validation(Required=false)]
            public long? RetCode5001Count { get; set; }

            /// <summary>
            /// <para>Number of occurrences of code 5024 during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode5024Count")]
            [Validation(Required=false)]
            public long? RetCode5024Count { get; set; }

            /// <summary>
            /// <para>Number of occurrences of code 5167 during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode5167Count")]
            [Validation(Required=false)]
            public long? RetCode5167Count { get; set; }

            /// <summary>
            /// <para>Number of occurrences of code 5217 during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode5217Count")]
            [Validation(Required=false)]
            public long? RetCode5217Count { get; set; }

            /// <summary>
            /// <para>Number of occurrences of code 6002 during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode6002Count")]
            [Validation(Required=false)]
            public long? RetCode6002Count { get; set; }

            /// <summary>
            /// <para>Total number of retries during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public long? RetryCount { get; set; }

            /// <summary>
            /// <para>SQL ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8D6E84<b><b>0B8FB1823D199E2CA1</b></b></para>
            /// </summary>
            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public string SQLId { get; set; }

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
            /// <para>Strong consistent transaction percentage during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StrongConsistencyPercentage")]
            [Validation(Required=false)]
            public double? StrongConsistencyPercentage { get; set; }

            /// <summary>
            /// <para>The total DB time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SumDbTime")]
            [Validation(Required=false)]
            public double? SumDbTime { get; set; }

            /// <summary>
            /// <para>Total response time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11452126.36</para>
            /// </summary>
            [NameInMap("SumElapsedTime")]
            [Validation(Required=false)]
            public double? SumElapsedTime { get; set; }

            /// <summary>
            /// <para>Total logical reads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SumLogicalReads")]
            [Validation(Required=false)]
            public double? SumLogicalReads { get; set; }

            /// <summary>
            /// <para>The total wait time (in milliseconds) during the internal waiting period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9421.73</para>
            /// </summary>
            [NameInMap("SumWaitTime")]
            [Validation(Required=false)]
            public double? SumWaitTime { get; set; }

            /// <summary>
            /// <para>Table scan percentage during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TableScanPercentage")]
            [Validation(Required=false)]
            public double? TableScanPercentage { get; set; }

            /// <summary>
            /// <para>Timestamp for the sample.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-12T04:46:38Z</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

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
            /// <para>The wait event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("WaitEvent")]
            [Validation(Required=false)]
            public string WaitEvent { get; set; }

            /// <summary>
            /// <para>Eventually consistent transaction percentage during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WeakConsistencyPercentage")]
            [Validation(Required=false)]
            public double? WeakConsistencyPercentage { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
