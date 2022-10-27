// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSlowSQLHistoryListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlowSQLHistoryList")]
        [Validation(Required=false)]
        public DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryList SlowSQLHistoryList { get; set; }
        public class DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryList : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryListList> List { get; set; }
            public class DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryListList : TeaModel {
                [NameInMap("AffectedRows")]
                [Validation(Required=false)]
                public double? AffectedRows { get; set; }

                [NameInMap("AppWaitTime")]
                [Validation(Required=false)]
                public double? AppWaitTime { get; set; }

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

                [NameInMap("ConcurrencyWaitTime")]
                [Validation(Required=false)]
                public double? ConcurrencyWaitTime { get; set; }

                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public double? CpuTime { get; set; }

                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                [NameInMap("DecodeTime")]
                [Validation(Required=false)]
                public double? DecodeTime { get; set; }

                [NameInMap("DiskRead")]
                [Validation(Required=false)]
                public double? DiskRead { get; set; }

                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public double? ElapsedTime { get; set; }

                [NameInMap("EndTimeUTCString")]
                [Validation(Required=false)]
                public string EndTimeUTCString { get; set; }

                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                [NameInMap("ExecPerSecond")]
                [Validation(Required=false)]
                public double? ExecPerSecond { get; set; }

                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public double? ExecuteTime { get; set; }

                [NameInMap("Executions")]
                [Validation(Required=false)]
                public double? Executions { get; set; }

                [NameInMap("FailTimes")]
                [Validation(Required=false)]
                public double? FailTimes { get; set; }

                [NameInMap("GetplanTime")]
                [Validation(Required=false)]
                public double? GetplanTime { get; set; }

                [NameInMap("IOWaitTime")]
                [Validation(Required=false)]
                public double? IOWaitTime { get; set; }

                [NameInMap("LogicalRead")]
                [Validation(Required=false)]
                public double? LogicalRead { get; set; }

                [NameInMap("MaxCpuTime")]
                [Validation(Required=false)]
                public double? MaxCpuTime { get; set; }

                [NameInMap("MaxElapsedTime")]
                [Validation(Required=false)]
                public double? MaxElapsedTime { get; set; }

                [NameInMap("MemstoreReadRowCount")]
                [Validation(Required=false)]
                public double? MemstoreReadRowCount { get; set; }

                [NameInMap("MissPlans")]
                [Validation(Required=false)]
                public double? MissPlans { get; set; }

                [NameInMap("NetwaitTime")]
                [Validation(Required=false)]
                public double? NetwaitTime { get; set; }

                [NameInMap("NodeIp")]
                [Validation(Required=false)]
                public string NodeIp { get; set; }

                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public double? QueueTime { get; set; }

                [NameInMap("RPCCount")]
                [Validation(Required=false)]
                public double? RPCCount { get; set; }

                [NameInMap("RemotePlans")]
                [Validation(Required=false)]
                public double? RemotePlans { get; set; }

                [NameInMap("RetryCount")]
                [Validation(Required=false)]
                public double? RetryCount { get; set; }

                [NameInMap("ReturnRows")]
                [Validation(Required=false)]
                public double? ReturnRows { get; set; }

                [NameInMap("RowCacheHit")]
                [Validation(Required=false)]
                public double? RowCacheHit { get; set; }

                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public double? ScheduleTime { get; set; }

                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                [NameInMap("SsstoreReadRowCount")]
                [Validation(Required=false)]
                public double? SsstoreReadRowCount { get; set; }

                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                [NameInMap("TotalWaitTime")]
                [Validation(Required=false)]
                public double? TotalWaitTime { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
