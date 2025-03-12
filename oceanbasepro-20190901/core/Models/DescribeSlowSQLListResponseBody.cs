// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSlowSQLListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of slow SQL statements.</para>
        /// </summary>
        [NameInMap("SlowSQLList")]
        [Validation(Required=false)]
        public List<DescribeSlowSQLListResponseBodySlowSQLList> SlowSQLList { get; set; }
        public class DescribeSlowSQLListResponseBodySlowSQLList : TeaModel {
            /// <summary>
            /// <para>The number of rows affected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AffectedRows")]
            [Validation(Required=false)]
            public long? AffectedRows { get; set; }

            /// <summary>
            /// <para>The wait time of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AppWaitTime")]
            [Validation(Required=false)]
            public float? AppWaitTime { get; set; }

            /// <summary>
            /// <para>The number of block cache hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("BlockCacheHit")]
            [Validation(Required=false)]
            public long? BlockCacheHit { get; set; }

            /// <summary>
            /// <para>The number of block index cache hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("BlockIndexCacheHit")]
            [Validation(Required=false)]
            public long? BlockIndexCacheHit { get; set; }

            /// <summary>
            /// <para>The number of Bloom filter cache hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BloomFilterCacheHit")]
            [Validation(Required=false)]
            public long? BloomFilterCacheHit { get; set; }

            /// <summary>
            /// <para>The IP address of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1<em>2.</em><b>.1<em>3.</em></b></para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The wait time in concurrent execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("ConcurrencyWaitTime")]
            [Validation(Required=false)]
            public float? ConcurrencyWaitTime { get; set; }

            /// <summary>
            /// <para>The average CPU time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50.13</para>
            /// </summary>
            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public float? CpuTime { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The time to wait for decoding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("DecodeTime")]
            [Validation(Required=false)]
            public float? DecodeTime { get; set; }

            /// <summary>
            /// <para>The number of physical reads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DiskRead")]
            [Validation(Required=false)]
            public long? DiskRead { get; set; }

            /// <summary>
            /// <para>The average response time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>76.382</para>
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public float? ElapsedTime { get; set; }

            /// <summary>
            /// <para>The wait event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql response wait client</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The number of executions per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>163.0</para>
            /// </summary>
            [NameInMap("ExecPerSecond")]
            [Validation(Required=false)]
            public float? ExecPerSecond { get; set; }

            /// <summary>
            /// <para>The internal execution time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>61.044</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public float? ExecuteTime { get; set; }

            /// <summary>
            /// <para>The number of executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89403</para>
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            /// <summary>
            /// <para>The number of failures.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailTimes")]
            [Validation(Required=false)]
            public long? FailTimes { get; set; }

            /// <summary>
            /// <para>The time spent in hard parsing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.052</para>
            /// </summary>
            [NameInMap("GetPlanTime")]
            [Validation(Required=false)]
            public float? GetPlanTime { get; set; }

            /// <summary>
            /// <para>The I/O wait time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("IOWaitTime")]
            [Validation(Required=false)]
            public float? IOWaitTime { get; set; }

            /// <summary>
            /// <para>The sequence number of the returned SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public long? Key { get; set; }

            /// <summary>
            /// <para>The number of logical reads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("LogicalRead")]
            [Validation(Required=false)]
            public long? LogicalRead { get; set; }

            /// <summary>
            /// <para>The maximum CPU time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>257.967</para>
            /// </summary>
            [NameInMap("MaxCpuTime")]
            [Validation(Required=false)]
            public float? MaxCpuTime { get; set; }

            /// <summary>
            /// <para>The maximum response time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>260.044</para>
            /// </summary>
            [NameInMap("MaxElapsedTime")]
            [Validation(Required=false)]
            public float? MaxElapsedTime { get; set; }

            /// <summary>
            /// <para>The number of rows read from the memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>527</para>
            /// </summary>
            [NameInMap("MemstoreReadRowCount")]
            [Validation(Required=false)]
            public long? MemstoreReadRowCount { get; set; }

            /// <summary>
            /// <para>The number of plan misses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MissPlans")]
            [Validation(Required=false)]
            public long? MissPlans { get; set; }

            /// <summary>
            /// <para>The network latency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("NetWaitTime")]
            [Validation(Required=false)]
            public float? NetWaitTime { get; set; }

            /// <summary>
            /// <para>The IP address of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp18qljorblo8es*****</para>
            /// </summary>
            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            /// <summary>
            /// <para>The queuing time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15.275</para>
            /// </summary>
            [NameInMap("QueueTime")]
            [Validation(Required=false)]
            public float? QueueTime { get; set; }

            /// <summary>
            /// <para>The number of RPCs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RPCCount")]
            [Validation(Required=false)]
            public long? RPCCount { get; set; }

            /// <summary>
            /// <para>The number of remote plans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemotePlans")]
            [Validation(Required=false)]
            public long? RemotePlans { get; set; }

            /// <summary>
            /// <para>The number of retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public long? RetryCount { get; set; }

            /// <summary>
            /// <para>The number of rows returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReturnRows")]
            [Validation(Required=false)]
            public long? ReturnRows { get; set; }

            /// <summary>
            /// <para>The number of row cache hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RowCacheHit")]
            [Validation(Required=false)]
            public long? RowCacheHit { get; set; }

            /// <summary>
            /// <para>SQLID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8D6E84<b><b>0B8FB1823D199E2CA1</b></b></para>
            /// </summary>
            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public string SQLId { get; set; }

            /// <summary>
            /// <para>The SQL text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT  ****   FROM ****   WHERE **** = ? AND **** = ?   ORDER BY **** ASC</para>
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// <para>The SQL type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SQLType")]
            [Validation(Required=false)]
            public long? SQLType { get; set; }

            /// <summary>
            /// <para>The scheduling duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public float? ScheduleTime { get; set; }

            /// <summary>
            /// <para>The number of rows read from the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43086</para>
            /// </summary>
            [NameInMap("SsstoreReadRowCount")]
            [Validation(Required=false)]
            public long? SsstoreReadRowCount { get; set; }

            /// <summary>
            /// <para>The internal wait time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.966</para>
            /// </summary>
            [NameInMap("TotalWaitTime")]
            [Validation(Required=false)]
            public float? TotalWaitTime { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tester</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
