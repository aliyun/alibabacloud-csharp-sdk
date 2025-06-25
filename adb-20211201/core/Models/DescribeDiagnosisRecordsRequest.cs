// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDiagnosisRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The source IP address.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to query the resource groups, database names, usernames, and source IP addresses of the SQL statements that meet a query condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>59.82.XX.XX</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <para>The Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612397.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1scs48yc125****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the database on which the SQL statements are executed.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to query the resource groups, database names, usernames, and source IP addresses of the SQL statements that meet a query condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Set the time to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The end time must be later than the start time.</para>
        /// </description></item>
        /// <item><description><para>The maximum time range that can be specified is 24 hours.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1633017540000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The query keyword of the SQL statements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of file titles and error messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): simplified Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// <item><description><b>zh-tw</b>: traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum peak memory of the SQL statements. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89000000</para>
        /// </summary>
        [NameInMap("MaxPeakMemory")]
        [Validation(Required=false)]
        public long? MaxPeakMemory { get; set; }

        /// <summary>
        /// <para>The maximum scan size of the SQL statements. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024000000</para>
        /// </summary>
        [NameInMap("MaxScanSize")]
        [Validation(Required=false)]
        public long? MaxScanSize { get; set; }

        /// <summary>
        /// <para>The minimum peak memory of the SQL statements. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinPeakMemory")]
        [Validation(Required=false)]
        public long? MinPeakMemory { get; set; }

        /// <summary>
        /// <para>The minimum scan size of the SQL statements. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinScanSize")]
        [Validation(Required=false)]
        public long? MinScanSize { get; set; }

        /// <summary>
        /// <para>The order in which to sort the SQL statements by field, which contains the <c>Field</c> and <c>Type</c> fields. Specify the order in the JSON format. Example: <c>[{&quot;Field&quot;:&quot;StartTime&quot;, &quot;Type&quot;: &quot;desc&quot;}]</c>. Fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c> specifies the field that is used to sort the SQL statements. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>StartTime</c>: the execution start time.</description></item>
        /// <item><description><c>Status</c>: the execution status.</description></item>
        /// <item><description><c>UserName</c>: the username.</description></item>
        /// <item><description><c>Cost</c>: the execution duration.</description></item>
        /// <item><description><c>PeakMemory</c>: the peak memory.</description></item>
        /// <item><description><c>ScanSize</c>: the amount of data that is scanned.</description></item>
        /// <item><description><c>Database</c>: the name of the database.</description></item>
        /// <item><description><c>ClientIp</c>: the source IP address.</description></item>
        /// <item><description><c>ResourceGroup</c>: the name of the resource group.</description></item>
        /// <item><description><c>QueueTime</c>: the amount of time that is consumed for queuing.</description></item>
        /// <item><description><c>OutputRows</c>: the number of output rows.</description></item>
        /// <item><description><c>OutputDataSize</c>: the amount of output data.</description></item>
        /// <item><description><c>ResourceCostRank</c>: the execution duration rank of operators that are used in the SQL statements. This value takes effect only when <c>QueryCondition</c> is set to <c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;running&quot;}</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c> specifies the sorting order. Valid values (case-insensitive):</para>
        /// <list type="bullet">
        /// <item><description><c>Desc</c>: descending order.</description></item>
        /// <item><description><c>Asc</c>: ascending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;StartTime&quot;, &quot;Type&quot;: &quot;desc&quot; }]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The SQL pattern ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5575924945138******</para>
        /// </summary>
        [NameInMap("PatternId")]
        [Validation(Required=false)]
        public string PatternId { get; set; }

        /// <summary>
        /// <para>The query condition for SQL statements, which can contain the <c>Type</c>, <c>Value</c>, <c>Min</c>, and <c>Max</c> fields. Specify the condition in the JSON format. <c>Type</c> specifies the query dimension. Valid values for Type: <c>maxCost</c>, <c>status</c>, and <c>cost</c>. <c>Value</c>, <c>Min</c>, or <c>Max</c> specifies the query range for the dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>{&quot;Type&quot;:&quot;maxCost&quot;,&quot;Value&quot;:&quot;100&quot;}</c>: queries the top 100 most time-consuming SQL statements. Set <c>Value</c> to 100.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;finished&quot;}</c>: queries the executed SQL statements. You can set <c>Value</c> to <c>running</c> to query the SQL statements that are being executed. You can also set Value to <c>failed</c> to query the SQL statements that failed to be executed.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;cost&quot;,&quot;Min&quot;:&quot;10&quot;,&quot;Max&quot;:&quot;200&quot;}</c>: queries the SQL statements whose execution duration is in the range of 10 to 200 milliseconds. You can also specify custom values for the Min and Max fields.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;finished&quot;}</para>
        /// </summary>
        [NameInMap("QueryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group to which the SQL statements belong.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to query the resource groups, database names, usernames, and source IP addresses of the SQL statements that meet a query condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Set the time to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para> You can query data only within the last 14 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1632931200000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The username that is used to execute the SQL statements. You can call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to query the resource groups, database names, usernames, and source IP addresses of the SQL statements that meet a query condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
