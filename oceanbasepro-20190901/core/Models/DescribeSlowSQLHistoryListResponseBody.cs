// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSlowSQLHistoryListResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The execution history of the slow SQL statement.
        /// </summary>
        [NameInMap("SlowSQLHistoryList")]
        [Validation(Required=false)]
        public DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryList SlowSQLHistoryList { get; set; }
        public class DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryList : TeaModel {
            /// <summary>
            /// The quantity.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The return result of the request.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryListList> List { get; set; }
            public class DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryListList : TeaModel {
                /// <summary>
                /// The number of rows affected.
                /// </summary>
                [NameInMap("AffectedRows")]
                [Validation(Required=false)]
                public double? AffectedRows { get; set; }

                /// <summary>
                /// The wait time of the client.
                /// </summary>
                [NameInMap("AppWaitTime")]
                [Validation(Required=false)]
                public double? AppWaitTime { get; set; }

                /// <summary>
                /// The number of block cache hits.
                /// </summary>
                [NameInMap("BlockCacheHit")]
                [Validation(Required=false)]
                public double? BlockCacheHit { get; set; }

                /// <summary>
                /// The number of block index cache hits.
                /// </summary>
                [NameInMap("BlockIndexCacheHit")]
                [Validation(Required=false)]
                public double? BlockIndexCacheHit { get; set; }

                /// <summary>
                /// The number of Bloom filter cache hits.
                /// </summary>
                [NameInMap("BloomFilterCacheHit")]
                [Validation(Required=false)]
                public double? BloomFilterCacheHit { get; set; }

                /// <summary>
                /// The IP address of the client.
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// The wait time in concurrent execution.
                /// </summary>
                [NameInMap("ConcurrencyWaitTime")]
                [Validation(Required=false)]
                public double? ConcurrencyWaitTime { get; set; }

                /// <summary>
                /// The average CPU time.
                /// </summary>
                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public double? CpuTime { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// The time to wait for decoding.
                /// </summary>
                [NameInMap("DecodeTime")]
                [Validation(Required=false)]
                public double? DecodeTime { get; set; }

                /// <summary>
                /// The number of physical reads.
                /// </summary>
                [NameInMap("DiskRead")]
                [Validation(Required=false)]
                public double? DiskRead { get; set; }

                /// <summary>
                /// The average response time.
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public double? ElapsedTime { get; set; }

                /// <summary>
                /// The end time.
                /// </summary>
                [NameInMap("EndTimeUTCString")]
                [Validation(Required=false)]
                public string EndTimeUTCString { get; set; }

                /// <summary>
                /// The wait event.
                /// </summary>
                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                /// <summary>
                /// The number of executions per second.
                /// </summary>
                [NameInMap("ExecPerSecond")]
                [Validation(Required=false)]
                public double? ExecPerSecond { get; set; }

                /// <summary>
                /// The internal execution time.
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public double? ExecuteTime { get; set; }

                /// <summary>
                /// The number of executions.
                /// </summary>
                [NameInMap("Executions")]
                [Validation(Required=false)]
                public double? Executions { get; set; }

                /// <summary>
                /// The number of failures.
                /// </summary>
                [NameInMap("FailTimes")]
                [Validation(Required=false)]
                public double? FailTimes { get; set; }

                /// <summary>
                /// Hard parsing time.
                /// </summary>
                [NameInMap("GetPlanTime")]
                [Validation(Required=false)]
                public double? GetPlanTime { get; set; }

                /// <summary>
                /// The I/O wait time.
                /// </summary>
                [NameInMap("IOWaitTime")]
                [Validation(Required=false)]
                public double? IOWaitTime { get; set; }

                /// <summary>
                /// The number of logical reads.
                /// </summary>
                [NameInMap("LogicalRead")]
                [Validation(Required=false)]
                public double? LogicalRead { get; set; }

                /// <summary>
                /// The maximum CPU time.
                /// </summary>
                [NameInMap("MaxCpuTime")]
                [Validation(Required=false)]
                public double? MaxCpuTime { get; set; }

                /// <summary>
                /// The maximum response time.
                /// </summary>
                [NameInMap("MaxElapsedTime")]
                [Validation(Required=false)]
                public double? MaxElapsedTime { get; set; }

                /// <summary>
                /// The number of rows read from the memory.
                /// </summary>
                [NameInMap("MemstoreReadRowCount")]
                [Validation(Required=false)]
                public double? MemstoreReadRowCount { get; set; }

                /// <summary>
                /// The number of plan misses.
                /// </summary>
                [NameInMap("MissPlans")]
                [Validation(Required=false)]
                public double? MissPlans { get; set; }

                /// <summary>
                /// The wait time for network.
                /// </summary>
                [NameInMap("NetWaitTime")]
                [Validation(Required=false)]
                public double? NetWaitTime { get; set; }

                /// <summary>
                /// The IP address of the node.
                /// </summary>
                [NameInMap("NodeIp")]
                [Validation(Required=false)]
                public string NodeIp { get; set; }

                /// <summary>
                /// The queuing time.
                /// </summary>
                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public double? QueueTime { get; set; }

                /// <summary>
                /// The number of RPCs.
                /// </summary>
                [NameInMap("RPCCount")]
                [Validation(Required=false)]
                public double? RPCCount { get; set; }

                /// <summary>
                /// The number of remote plans.
                /// </summary>
                [NameInMap("RemotePlans")]
                [Validation(Required=false)]
                public double? RemotePlans { get; set; }

                /// <summary>
                /// The number of retries.
                /// </summary>
                [NameInMap("RetryCount")]
                [Validation(Required=false)]
                public double? RetryCount { get; set; }

                /// <summary>
                /// The number of rows returned.
                /// </summary>
                [NameInMap("ReturnRows")]
                [Validation(Required=false)]
                public double? ReturnRows { get; set; }

                /// <summary>
                /// The number of row cache hits.
                /// </summary>
                [NameInMap("RowCacheHit")]
                [Validation(Required=false)]
                public double? RowCacheHit { get; set; }

                /// <summary>
                /// The scheduling duration.
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public double? ScheduleTime { get; set; }

                /// <summary>
                /// SQLID.
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// The SQL type.
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// The number of rows read from the disk.
                /// </summary>
                [NameInMap("SsstoreReadRowCount")]
                [Validation(Required=false)]
                public double? SsstoreReadRowCount { get; set; }

                /// <summary>
                /// The name of the tenant.
                /// </summary>
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                /// <summary>
                /// The internal wait time.
                /// </summary>
                [NameInMap("TotalWaitTime")]
                [Validation(Required=false)]
                public double? TotalWaitTime { get; set; }

                /// <summary>
                /// The username.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
