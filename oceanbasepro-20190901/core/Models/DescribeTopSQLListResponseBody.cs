// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTopSQLListResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of top SQL statements.
        /// </summary>
        [NameInMap("TopSQLList")]
        [Validation(Required=false)]
        public List<DescribeTopSQLListResponseBodyTopSQLList> TopSQLList { get; set; }
        public class DescribeTopSQLListResponseBodyTopSQLList : TeaModel {
            /// <summary>
            /// The number of rows affected.
            /// </summary>
            [NameInMap("AffectedRows")]
            [Validation(Required=false)]
            public long? AffectedRows { get; set; }

            /// <summary>
            /// The wait time of the client, in ms.
            /// </summary>
            [NameInMap("AppWaitTime")]
            [Validation(Required=false)]
            public float? AppWaitTime { get; set; }

            /// <summary>
            /// The number of block cache hits.
            /// </summary>
            [NameInMap("BlockCacheHit")]
            [Validation(Required=false)]
            public long? BlockCacheHit { get; set; }

            /// <summary>
            /// The number of block index cache hits.
            /// </summary>
            [NameInMap("BlockIndexCacheHit")]
            [Validation(Required=false)]
            public long? BlockIndexCacheHit { get; set; }

            /// <summary>
            /// The number of Bloom filter cache hits.
            /// </summary>
            [NameInMap("BloomFilterCacheHit")]
            [Validation(Required=false)]
            public long? BloomFilterCacheHit { get; set; }

            /// <summary>
            /// The IP address of the client.
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// The wait time in concurrent execution, in ms.
            /// </summary>
            [NameInMap("ConcurrencyWaitTime")]
            [Validation(Required=false)]
            public float? ConcurrencyWaitTime { get; set; }

            /// <summary>
            /// The average CPU time, in ms.
            /// </summary>
            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public float? CpuTime { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// The time to wait for decoding, in ms.
            /// </summary>
            [NameInMap("DecodeTime")]
            [Validation(Required=false)]
            public float? DecodeTime { get; set; }

            /// <summary>
            /// The number of physical reads.
            /// </summary>
            [NameInMap("DiskRead")]
            [Validation(Required=false)]
            public long? DiskRead { get; set; }

            /// <summary>
            /// The average response time, in ms.
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public float? ElapsedTime { get; set; }

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
            public float? ExecPerSecond { get; set; }

            /// <summary>
            /// The internal execution time, in ms.
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public float? ExecuteTime { get; set; }

            /// <summary>
            /// The number of executions.
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            /// <summary>
            /// The number of failures.
            /// </summary>
            [NameInMap("FailTimes")]
            [Validation(Required=false)]
            public long? FailTimes { get; set; }

            /// <summary>
            /// The time spent in hard parsing, in ms.
            /// </summary>
            [NameInMap("GetPlanTime")]
            [Validation(Required=false)]
            public float? GetPlanTime { get; set; }

            /// <summary>
            /// The I/O wait time, in ms.
            /// </summary>
            [NameInMap("IOWaitTime")]
            [Validation(Required=false)]
            public float? IOWaitTime { get; set; }

            /// <summary>
            /// The sequence number of the returned SQL statement.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public long? Key { get; set; }

            /// <summary>
            /// The average number of logical reads of the SQL statement during the specified period of time.   
            /// The value covers the numbers of reads of different caches and the number of disk I/Os. It is an important metric for measuring the SQL filtering performance.   
            /// 
            /// > <br> A higher ratio of the number of logical reads to the number of returned rows indicates poorer filtering performance. General causes include non-standard content written by SQL statements, non-standard table indexes created, and non-standard SQL execution plans.
            /// </summary>
            [NameInMap("LogicalRead")]
            [Validation(Required=false)]
            public long? LogicalRead { get; set; }

            /// <summary>
            /// The maximum CPU time, in ms.
            /// </summary>
            [NameInMap("MaxCpuTime")]
            [Validation(Required=false)]
            public float? MaxCpuTime { get; set; }

            /// <summary>
            /// The maximum response time, in ms.
            /// </summary>
            [NameInMap("MaxElapsedTime")]
            [Validation(Required=false)]
            public float? MaxElapsedTime { get; set; }

            /// <summary>
            /// The number of rows read from the memory.
            /// </summary>
            [NameInMap("MemstoreReadRowCount")]
            [Validation(Required=false)]
            public long? MemstoreReadRowCount { get; set; }

            /// <summary>
            /// The number of plan misses.
            /// </summary>
            [NameInMap("MissPlans")]
            [Validation(Required=false)]
            public long? MissPlans { get; set; }

            /// <summary>
            /// The network latency, in ms.
            /// </summary>
            [NameInMap("NetWaitTime")]
            [Validation(Required=false)]
            public float? NetWaitTime { get; set; }

            /// <summary>
            /// The IP address of the node.
            /// </summary>
            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            /// <summary>
            /// The queuing time, in ms.
            /// </summary>
            [NameInMap("QueueTime")]
            [Validation(Required=false)]
            public float? QueueTime { get; set; }

            /// <summary>
            /// The number of RPCs.
            /// </summary>
            [NameInMap("RPCCount")]
            [Validation(Required=false)]
            public long? RPCCount { get; set; }

            /// <summary>
            /// The number of remote plans.
            /// </summary>
            [NameInMap("RemotePlans")]
            [Validation(Required=false)]
            public long? RemotePlans { get; set; }

            /// <summary>
            /// The number of retries.
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public long? RetryCount { get; set; }

            /// <summary>
            /// The number of rows returned.
            /// </summary>
            [NameInMap("ReturnRows")]
            [Validation(Required=false)]
            public long? ReturnRows { get; set; }

            /// <summary>
            /// The number of row cache hits.
            /// </summary>
            [NameInMap("RowCacheHit")]
            [Validation(Required=false)]
            public long? RowCacheHit { get; set; }

            /// <summary>
            /// SQLID.
            /// </summary>
            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public string SQLId { get; set; }

            /// <summary>
            /// The SQL text.
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// The SQL type.
            /// </summary>
            [NameInMap("SQLType")]
            [Validation(Required=false)]
            public long? SQLType { get; set; }

            /// <summary>
            /// The scheduling duration, in ms.
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public float? ScheduleTime { get; set; }

            /// <summary>
            /// The number of rows read from the disk.
            /// </summary>
            [NameInMap("SsstoreReadRowCount")]
            [Validation(Required=false)]
            public long? SsstoreReadRowCount { get; set; }

            /// <summary>
            /// The internal wait time, in ms.
            /// </summary>
            [NameInMap("TotalWaitTime")]
            [Validation(Required=false)]
            public float? TotalWaitTime { get; set; }

            /// <summary>
            /// The username.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The total count.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
