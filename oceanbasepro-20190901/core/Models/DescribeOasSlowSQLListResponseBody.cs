// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasSlowSQLListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOasSlowSQLListResponseBodyData> Data { get; set; }
        public class DescribeOasSlowSQLListResponseBodyData : TeaModel {
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

            /// <summary>
            /// SQL ID。
            /// </summary>
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
