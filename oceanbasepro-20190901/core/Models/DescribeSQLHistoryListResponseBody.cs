// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLHistoryListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SQLHistoryList")]
        [Validation(Required=false)]
        public DescribeSQLHistoryListResponseBodySQLHistoryList SQLHistoryList { get; set; }
        public class DescribeSQLHistoryListResponseBodySQLHistoryList : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeSQLHistoryListResponseBodySQLHistoryListList> List { get; set; }
            public class DescribeSQLHistoryListResponseBodySQLHistoryListList : TeaModel {
                [NameInMap("AffectedRows")]
                [Validation(Required=false)]
                public long? AffectedRows { get; set; }

                [NameInMap("AppWaitTime")]
                [Validation(Required=false)]
                public float? AppWaitTime { get; set; }

                [NameInMap("BlockCacheHit")]
                [Validation(Required=false)]
                public long? BlockCacheHit { get; set; }

                [NameInMap("BlockIndexCacheHit")]
                [Validation(Required=false)]
                public long? BlockIndexCacheHit { get; set; }

                [NameInMap("BloomFilterCacheHit")]
                [Validation(Required=false)]
                public long? BloomFilterCacheHit { get; set; }

                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                [NameInMap("ConcurrencyWaitTime")]
                [Validation(Required=false)]
                public float? ConcurrencyWaitTime { get; set; }

                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public float? CpuTime { get; set; }

                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                [NameInMap("DecodeTime")]
                [Validation(Required=false)]
                public float? DecodeTime { get; set; }

                [NameInMap("DiskRead")]
                [Validation(Required=false)]
                public long? DiskRead { get; set; }

                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public float? ElapsedTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("EndTimeUTCString")]
                [Validation(Required=false)]
                public string EndTimeUTCString { get; set; }

                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                [NameInMap("ExecPerSecond")]
                [Validation(Required=false)]
                public long? ExecPerSecond { get; set; }

                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public float? ExecuteTime { get; set; }

                [NameInMap("Executions")]
                [Validation(Required=false)]
                public long? Executions { get; set; }

                [NameInMap("FailTimes")]
                [Validation(Required=false)]
                public long? FailTimes { get; set; }

                [NameInMap("GetPlanTime")]
                [Validation(Required=false)]
                public float? GetPlanTime { get; set; }

                [NameInMap("IOWaitTime")]
                [Validation(Required=false)]
                public float? IOWaitTime { get; set; }

                [NameInMap("LogicalRead")]
                [Validation(Required=false)]
                public long? LogicalRead { get; set; }

                [NameInMap("MaxCpuTime")]
                [Validation(Required=false)]
                public float? MaxCpuTime { get; set; }

                [NameInMap("MaxElapsedTime")]
                [Validation(Required=false)]
                public float? MaxElapsedTime { get; set; }

                [NameInMap("MemstoreReadRowCount")]
                [Validation(Required=false)]
                public long? MemstoreReadRowCount { get; set; }

                [NameInMap("MissPlans")]
                [Validation(Required=false)]
                public long? MissPlans { get; set; }

                [NameInMap("NetWaitTime")]
                [Validation(Required=false)]
                public float? NetWaitTime { get; set; }

                [NameInMap("NodeIp")]
                [Validation(Required=false)]
                public string NodeIp { get; set; }

                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public float? QueueTime { get; set; }

                [NameInMap("RPCCount")]
                [Validation(Required=false)]
                public long? RPCCount { get; set; }

                [NameInMap("RemotePlans")]
                [Validation(Required=false)]
                public long? RemotePlans { get; set; }

                [NameInMap("RetryCount")]
                [Validation(Required=false)]
                public long? RetryCount { get; set; }

                [NameInMap("ReturnRows")]
                [Validation(Required=false)]
                public long? ReturnRows { get; set; }

                [NameInMap("RowCacheHit")]
                [Validation(Required=false)]
                public long? RowCacheHit { get; set; }

                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public float? ScheduleTime { get; set; }

                [NameInMap("SsstoreReadRowCount")]
                [Validation(Required=false)]
                public long? SsstoreReadRowCount { get; set; }

                [NameInMap("TotalWaitTime")]
                [Validation(Required=false)]
                public float? TotalWaitTime { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
