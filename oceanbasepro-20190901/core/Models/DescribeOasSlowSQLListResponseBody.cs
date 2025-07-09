// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasSlowSQLListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of slow queries.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOasSlowSQLListResponseBodyData> Data { get; set; }
        public class DescribeOasSlowSQLListResponseBodyData : TeaModel {
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
            /// <para>0.0</para>
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
            /// <para>Average logical reads of the SQL during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgLogicalReads")]
            [Validation(Required=false)]
            public double? AvgLogicalReads { get; set; }

            /// <summary>
            /// <para>Strong consistent transaction percentage during the execution period.</para>
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
            /// <para>0.0</para>
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
            /// <para>1.0</para>
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
            /// <para>Eventually consistent transaction percentage during the execution period.</para>
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
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AvgWaitCount")]
            [Validation(Required=false)]
            public double? AvgWaitCount { get; set; }

            /// <summary>
            /// <para>Average wait time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.42</para>
            /// </summary>
            [NameInMap("AvgWaitTime")]
            [Validation(Required=false)]
            public double? AvgWaitTime { get; set; }

            /// <summary>
            /// <para>Client IP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1<em>2.</em><b>.1<em>3.</em></b></para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

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
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("DistPlanPercentage")]
            [Validation(Required=false)]
            public double? DistPlanPercentage { get; set; }

            [NameInMap("DynamicSql")]
            [Validation(Required=false)]
            public bool? DynamicSql { get; set; }

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
            /// <para>Average number of partition accessed during the execution period.</para>
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
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("FailPercentage")]
            [Validation(Required=false)]
            public double? FailPercentage { get; set; }

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
            /// <para>Local plan percentage during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("LocalPlanPercentage")]
            [Validation(Required=false)]
            public double? LocalPlanPercentage { get; set; }

            /// <summary>
            /// <para>Max affected rows during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000.0</para>
            /// </summary>
            [NameInMap("MaxAffectedRows")]
            [Validation(Required=false)]
            public double? MaxAffectedRows { get; set; }

            /// <summary>
            /// <para>Max Application event wait time (in milliseconds) during the execution period</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("MaxApplicationWaitTime")]
            [Validation(Required=false)]
            public double? MaxApplicationWaitTime { get; set; }

            /// <summary>
            /// <para>Max Concurrency event wait time (in milliseconds) during the execution period</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("MaxConcurrencyWaitTime")]
            [Validation(Required=false)]
            public double? MaxConcurrencyWaitTime { get; set; }

            /// <summary>
            /// <para>Max CPU time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>257.967</para>
            /// </summary>
            [NameInMap("MaxCpuTime")]
            [Validation(Required=false)]
            public double? MaxCpuTime { get; set; }

            /// <summary>
            /// <para>Max physical read count during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("MaxDiskReads")]
            [Validation(Required=false)]
            public double? MaxDiskReads { get; set; }

            /// <summary>
            /// <para>Max response time during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>260.044</para>
            /// </summary>
            [NameInMap("MaxElapsedTime")]
            [Validation(Required=false)]
            public double? MaxElapsedTime { get; set; }

            /// <summary>
            /// <para>Max returned rows during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("MaxReturnRows")]
            [Validation(Required=false)]
            public double? MaxReturnRows { get; set; }

            /// <summary>
            /// <para>Max UserIO event wait time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
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
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("MissPlanPercentage")]
            [Validation(Required=false)]
            public double? MissPlanPercentage { get; set; }

            /// <summary>
            /// <para>Missed hit count of the execution plan during the execution period.</para>
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
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("RemotePlanPercentage")]
            [Validation(Required=false)]
            public double? RemotePlanPercentage { get; set; }

            /// <summary>
            /// <para>Remote execution count during the execution period.</para>
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
            /// <para>5</para>
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public long? RetryCount { get; set; }

            /// <summary>
            /// <para>RPC count during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RpcCount")]
            [Validation(Required=false)]
            public double? RpcCount { get; set; }

            /// <summary>
            /// <para>The server where the SQL is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1db1a<b>s038</b>mej**</para>
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// <para>The IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1db1a<b>s038</b>mej**</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The server port where the SQL is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10110</para>
            /// </summary>
            [NameInMap("ServerPort")]
            [Validation(Required=false)]
            public long? ServerPort { get; set; }

            /// <summary>
            /// <para>SQL ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8D6E84<b><b>0B8FB1823D199E2CA1</b></b></para>
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
                public long? Executions { get; set; }

                [NameInMap("FailCount")]
                [Validation(Required=false)]
                public long? FailCount { get; set; }

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
                public long? MissPlans { get; set; }

                [NameInMap("RemotePlanPercentage")]
                [Validation(Required=false)]
                public double? RemotePlanPercentage { get; set; }

                [NameInMap("RemotePlans")]
                [Validation(Required=false)]
                public long? RemotePlans { get; set; }

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
                public long? RetryCount { get; set; }

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
            /// <para>SQL text (the first 100 characters).</para>
            /// 
            /// <b>Example:</b>
            /// <para>select a from b where</para>
            /// </summary>
            [NameInMap("SqlTextShort")]
            [Validation(Required=false)]
            public string SqlTextShort { get; set; }

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
            /// <para>Strong consistent transaction percentage during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("StrongConsistencyPercentage")]
            [Validation(Required=false)]
            public double? StrongConsistencyPercentage { get; set; }

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
            /// <para>Total logical reads of the SQL during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
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
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("TableScanPercentage")]
            [Validation(Required=false)]
            public double? TableScanPercentage { get; set; }

            /// <summary>
            /// <para>Total wait time during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.966</para>
            /// </summary>
            [NameInMap("TotalWaitTime")]
            [Validation(Required=false)]
            public double? TotalWaitTime { get; set; }

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
            /// <para>Longest wait event during the execution period.</para>
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
            /// <para>0.0</para>
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
