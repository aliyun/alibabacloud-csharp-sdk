// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLSamplesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSQLSamplesResponseBodyData> Data { get; set; }
        public class DescribeSQLSamplesResponseBodyData : TeaModel {
            [NameInMap("AffectedRows")]
            [Validation(Required=false)]
            public double? AffectedRows { get; set; }

            [NameInMap("ApplicationWaitTime")]
            [Validation(Required=false)]
            public double? ApplicationWaitTime { get; set; }

            [NameInMap("BlockCacheHit")]
            [Validation(Required=false)]
            public double? BlockCacheHit { get; set; }

            [NameInMap("BlockIndexCacheHit")]
            [Validation(Required=false)]
            public double? BlockIndexCacheHit { get; set; }

            [NameInMap("BloomFilterCacheHit")]
            [Validation(Required=false)]
            public double? BloomFilterCacheHit { get; set; }

            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public string ClientPort { get; set; }

            [NameInMap("ConcurrencyWaitTime")]
            [Validation(Required=false)]
            public double? ConcurrencyWaitTime { get; set; }

            [NameInMap("ConsistencyLevel")]
            [Validation(Required=false)]
            public string ConsistencyLevel { get; set; }

            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public double? CpuTime { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("DecodeTime")]
            [Validation(Required=false)]
            public double? DecodeTime { get; set; }

            [NameInMap("DiskReads")]
            [Validation(Required=false)]
            public double? DiskReads { get; set; }

            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public double? ElapsedTime { get; set; }

            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public double? ExecuteTime { get; set; }

            [NameInMap("ExecutorRpc")]
            [Validation(Required=false)]
            public double? ExecutorRpc { get; set; }

            [NameInMap("ExpectedWorkerCount")]
            [Validation(Required=false)]
            public double? ExpectedWorkerCount { get; set; }

            [NameInMap("GetPlanTime")]
            [Validation(Required=false)]
            public double? GetPlanTime { get; set; }

            [NameInMap("HitPlan")]
            [Validation(Required=false)]
            public double? HitPlan { get; set; }

            [NameInMap("Inner")]
            [Validation(Required=false)]
            public bool? Inner { get; set; }

            [NameInMap("MemstoreReadRows")]
            [Validation(Required=false)]
            public double? MemstoreReadRows { get; set; }

            [NameInMap("NetTime")]
            [Validation(Required=false)]
            public double? NetTime { get; set; }

            [NameInMap("NetWaitTime")]
            [Validation(Required=false)]
            public double? NetWaitTime { get; set; }

            [NameInMap("ObDbId")]
            [Validation(Required=false)]
            public double? ObDbId { get; set; }

            /// <summary>
            /// server  ID。
            /// </summary>
            [NameInMap("ObServerId")]
            [Validation(Required=false)]
            public double? ObServerId { get; set; }

            [NameInMap("ObUserId")]
            [Validation(Required=false)]
            public double? ObUserId { get; set; }

            [NameInMap("PartitionCount")]
            [Validation(Required=false)]
            public double? PartitionCount { get; set; }

            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public double? PlanId { get; set; }

            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            [NameInMap("QueueTime")]
            [Validation(Required=false)]
            public double? QueueTime { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public string RequestTime { get; set; }

            [NameInMap("RetCode")]
            [Validation(Required=false)]
            public double? RetCode { get; set; }

            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public double? RetryCount { get; set; }

            [NameInMap("ReturnRows")]
            [Validation(Required=false)]
            public double? ReturnRows { get; set; }

            [NameInMap("RowCacheHit")]
            [Validation(Required=false)]
            public double? RowCacheHit { get; set; }

            [NameInMap("RpcCount")]
            [Validation(Required=false)]
            public double? RpcCount { get; set; }

            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public double? ScheduleTime { get; set; }

            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            [NameInMap("SsstoreReadRows")]
            [Validation(Required=false)]
            public double? SsstoreReadRows { get; set; }

            [NameInMap("Statement")]
            [Validation(Required=false)]
            public string Statement { get; set; }

            [NameInMap("TableScan")]
            [Validation(Required=false)]
            public double? TableScan { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// transaction hash。
            /// </summary>
            [NameInMap("TransHash")]
            [Validation(Required=false)]
            public string TransHash { get; set; }

            [NameInMap("UsedWorkerCount")]
            [Validation(Required=false)]
            public double? UsedWorkerCount { get; set; }

            [NameInMap("UserIoWaitTime")]
            [Validation(Required=false)]
            public double? UserIoWaitTime { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("WaitCount")]
            [Validation(Required=false)]
            public double? WaitCount { get; set; }

            [NameInMap("WaitEvent")]
            [Validation(Required=false)]
            public string WaitEvent { get; set; }

            [NameInMap("WaitTime")]
            [Validation(Required=false)]
            public double? WaitTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
