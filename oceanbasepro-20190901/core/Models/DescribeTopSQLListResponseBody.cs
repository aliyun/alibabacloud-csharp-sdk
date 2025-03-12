// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTopSQLListResponseBody : TeaModel {
        /// <summary>
        /// <para>Alibaba Cloud CLI</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The I/O wait time, in ms.</para>
        /// </summary>
        [NameInMap("TopSQLList")]
        [Validation(Required=false)]
        public List<DescribeTopSQLListResponseBodyTopSQLList> TopSQLList { get; set; }
        public class DescribeTopSQLListResponseBodyTopSQLList : TeaModel {
            /// <summary>
            /// <para>The internal wait time, in ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AffectedRows")]
            [Validation(Required=false)]
            public long? AffectedRows { get; set; }

            /// <summary>
            /// <para>The wait time in concurrent execution, in ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("AppWaitTime")]
            [Validation(Required=false)]
            public float? AppWaitTime { get; set; }

            /// <summary>
            /// <para>The average CPU time, in ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("BlockCacheHit")]
            [Validation(Required=false)]
            public long? BlockCacheHit { get; set; }

            /// <summary>
            /// <para>$.parameters[16].schema.example</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("BlockIndexCacheHit")]
            [Validation(Required=false)]
            public long? BlockIndexCacheHit { get; set; }

            /// <summary>
            /// <para>$.parameters[14].schema.enumValueTitles</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BloomFilterCacheHit")]
            [Validation(Required=false)]
            public long? BloomFilterCacheHit { get; set; }

            /// <summary>
            /// <para>$.parameters[14].schema.description</para>
            /// 
            /// <b>Example:</b>
            /// <para>1<em>2.</em><b>.1<em>3.</em></b></para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The number of rows returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("ConcurrencyWaitTime")]
            [Validation(Required=false)]
            public float? ConcurrencyWaitTime { get; set; }

            /// <summary>
            /// <para>The maximum CPU time, in ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50.13</para>
            /// </summary>
            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public float? CpuTime { get; set; }

            /// <summary>
            /// <para>The number of remote plans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The number of rows to return on each page.   </para>
            /// <list type="bullet">
            /// <item><description>Maximum value: 100   </description></item>
            /// <item><description>Default value: 10</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("DecodeTime")]
            [Validation(Required=false)]
            public float? DecodeTime { get; set; }

            /// <summary>
            /// <para>The IP address of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DiskRead")]
            [Validation(Required=false)]
            public long? DiskRead { get; set; }

            /// <summary>
            /// <para>The sorting rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>76.382</para>
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public float? ElapsedTime { get; set; }

            /// <summary>
            /// <para>The number of rows read from the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql response wait client</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The operation that you want to perform.<br>Set the value to <b>DescribeTopSQLList</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>163.0</para>
            /// </summary>
            [NameInMap("ExecPerSecond")]
            [Validation(Required=false)]
            public float? ExecPerSecond { get; set; }

            /// <summary>
            /// <para>The number of rows read from the memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>61.044</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public float? ExecuteTime { get; set; }

            /// <summary>
            /// <para>The number of executions per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89403</para>
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            /// <summary>
            /// <para>$.parameters[12].schema.description</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailTimes")]
            [Validation(Required=false)]
            public long? FailTimes { get; set; }

            /// <summary>
            /// <para>The queuing time, in ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.052</para>
            /// </summary>
            [NameInMap("GetPlanTime")]
            [Validation(Required=false)]
            public float? GetPlanTime { get; set; }

            /// <summary>
            /// <para>$.parameters[15].schema.example</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("IOWaitTime")]
            [Validation(Required=false)]
            public float? IOWaitTime { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public long? Key { get; set; }

            /// <summary>
            /// <para>You can call this operation to query SQL execution performance data collected by the diagnostic system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("LogicalRead")]
            [Validation(Required=false)]
            public long? LogicalRead { get; set; }

            /// <summary>
            /// <para>SQLID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>257.967</para>
            /// </summary>
            [NameInMap("MaxCpuTime")]
            [Validation(Required=false)]
            public float? MaxCpuTime { get; set; }

            /// <summary>
            /// <para>The sequence number of the returned SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>260.044</para>
            /// </summary>
            [NameInMap("MaxElapsedTime")]
            [Validation(Required=false)]
            public float? MaxElapsedTime { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>527</para>
            /// </summary>
            [NameInMap("MemstoreReadRowCount")]
            [Validation(Required=false)]
            public long? MemstoreReadRowCount { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MissPlans")]
            [Validation(Required=false)]
            public long? MissPlans { get; set; }

            /// <summary>
            /// <para>The end time of the time range for querying TOP SQL statements.<br>The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("NetWaitTime")]
            [Validation(Required=false)]
            public float? NetWaitTime { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp18qljorblo8es*****</para>
            /// </summary>
            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            /// <summary>
            /// <para>$.parameters[12].schema.enumValueTitles</para>
            /// 
            /// <b>Example:</b>
            /// <para>15.275</para>
            /// </summary>
            [NameInMap("QueueTime")]
            [Validation(Required=false)]
            public float? QueueTime { get; set; }

            /// <summary>
            /// <para>The start time of the time range for querying TOP SQL statements.<br>The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RPCCount")]
            [Validation(Required=false)]
            public long? RPCCount { get; set; }

            /// <summary>
            /// <para>The return result of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemotePlans")]
            [Validation(Required=false)]
            public long? RemotePlans { get; set; }

            /// <summary>
            /// <para>$.parameters[13].schema.description</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public long? RetryCount { get; set; }

            /// <summary>
            /// <para>The wait event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReturnRows")]
            [Validation(Required=false)]
            public long? ReturnRows { get; set; }

            /// <summary>
            /// <pre><c>http(s)://[Endpoint]/?Action=DescribeTopSQLList
            /// &amp;TenantId=t2mr3oae0****
            /// &amp;StartTime=2021-06-13 15:40:43
            /// &amp;EndTime=2021-09-13 15:40:43
            /// &amp;DbName=testdb
            /// &amp;SearchKeyWord=update
            /// &amp;SearchParameter=cputime
            /// &amp;SearchRule=&gt;
            /// &amp;SearchValue=0.01
            /// &amp;SQLId=8D6E84****0B8FB1823D199E2CA1****
            /// &amp;NodeIp=i-bp19y05uq6xpacyqnlrc
            /// &amp;PageNumber=1
            /// &amp;PageSize=10
            /// &amp;SortColumn=cputime
            /// &amp;SortOrder=desc
            /// &amp;Common request parameters
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RowCacheHit")]
            [Validation(Required=false)]
            public long? RowCacheHit { get; set; }

            /// <summary>
            /// <para>$.parameters[13].schema.example</para>
            /// 
            /// <b>Example:</b>
            /// <para>8D6E84<b><b>0B8FB1823D199E2CA1</b></b></para>
            /// </summary>
            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public string SQLId { get; set; }

            /// <summary>
            /// <para>The list of top SQL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT  ****   FROM ****   WHERE **** = ? AND **** = ?   ORDER BY **** ASC</para>
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SQLType")]
            [Validation(Required=false)]
            public long? SQLType { get; set; }

            /// <summary>
            /// <para>The search keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public float? ScheduleTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>43086</para>
            /// </summary>
            [NameInMap("SsstoreReadRowCount")]
            [Validation(Required=false)]
            public long? SsstoreReadRowCount { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10.966</para>
            /// </summary>
            [NameInMap("TotalWaitTime")]
            [Validation(Required=false)]
            public float? TotalWaitTime { get; set; }

            /// <summary>
            /// <para>The number of Bloom filter cache hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tester</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>It is an online CLI tool that allows you to quickly retrieve and debug APIs. It can dynamically generate executable SDK code samples.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
