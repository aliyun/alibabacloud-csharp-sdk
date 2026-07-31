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
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to view the resource groups, database names, usernames, and source IP addresses for the SQL statements that meet the specified query conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>59.82.XX.XX</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <para>The ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/612397.html">DescribeDBClusters</a> operation to view the details of all clusters in your account, including cluster IDs.</para>
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
        /// <para>The database where the SQL statement is executed.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to view the resource groups, database names, usernames, and source IP addresses for the SQL statements that meet the specified query conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the UNIX timestamp format. The time must be in milliseconds.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The end time must be later than the start time.</para>
        /// </description></item>
        /// <item><description><para>The interval between the start time and the end time cannot exceed 24 hours.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1633017540000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Filters the queries by the keywords contained in the SQL statements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the file title and some error messages in the downloaded file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Simplified Chinese (default).</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// <item><description><para><b>ja</b>: Japanese.</para>
        /// </description></item>
        /// <item><description><para><b>zh-tw</b>: Traditional Chinese.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum peak memory of the SQL statement. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89000000</para>
        /// </summary>
        [NameInMap("MaxPeakMemory")]
        [Validation(Required=false)]
        public long? MaxPeakMemory { get; set; }

        /// <summary>
        /// <para>The maximum scan size of the target SQL statement. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024000000</para>
        /// </summary>
        [NameInMap("MaxScanSize")]
        [Validation(Required=false)]
        public long? MaxScanSize { get; set; }

        /// <summary>
        /// <para>The minimum peak memory of the SQL statement. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinPeakMemory")]
        [Validation(Required=false)]
        public long? MinPeakMemory { get; set; }

        /// <summary>
        /// <para>The minimum scan size of the SQL statement. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinScanSize")]
        [Validation(Required=false)]
        public long? MinScanSize { get; set; }

        /// <summary>
        /// <para>The sorting order of the SQL statements. This parameter is a JSON array that is ordered by the sequence of the input array. It contains the <c>Field</c> and <c>Type</c> fields. Example: <c>[{&quot;Field&quot;:&quot;StartTime&quot;, &quot;Type&quot;: &quot;desc&quot; }]</c>. The fields are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c> specifies the field by which to sort the SQL statements. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>StartTime</c>: the start time of the execution.</para>
        /// </description></item>
        /// <item><description><para><c>Status</c>: the execution state.</para>
        /// </description></item>
        /// <item><description><para><c>UserName</c>: the username.</para>
        /// </description></item>
        /// <item><description><para><c>Cost</c>: the execution duration.</para>
        /// </description></item>
        /// <item><description><para><c>PeakMemory</c>: the peak memory.</para>
        /// </description></item>
        /// <item><description><para><c>ScanSize</c>: the amount of scanned data.</para>
        /// </description></item>
        /// <item><description><para><c>Database</c>: the database name.</para>
        /// </description></item>
        /// <item><description><para><c>ClientIp</c>: the source IP address.</para>
        /// </description></item>
        /// <item><description><para><c>ResourceGroup</c>: the resource group.</para>
        /// </description></item>
        /// <item><description><para><c>QueueTime</c>: the amount of time that the query waited in a queue.</para>
        /// </description></item>
        /// <item><description><para><c>OutputRows</c>: the number of output rows.</para>
        /// </description></item>
        /// <item><description><para><c>OutputDataSize</c>: the amount of output data.</para>
        /// </description></item>
        /// <item><description><para><c>ResourceCostRank</c>: the ranking of the execution duration of an operator in the SQL statement. This field is returned only when <c>QueryCondition</c> is set to <c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;running&quot;}</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c> specifies the sorting type. Valid values (case-insensitive):</para>
        /// <list type="bullet">
        /// <item><description><para><c>Desc</c>: descending order.</para>
        /// </description></item>
        /// <item><description><para><c>Asc</c>: ascending order.</para>
        /// </description></item>
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
        /// <para>The page number. The value must be an integer that is greater than 0. Default value: 1.</para>
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
        /// <item><description><para><b>30</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the SQL pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5575924945138******</para>
        /// </summary>
        [NameInMap("PatternId")]
        [Validation(Required=false)]
        public string PatternId { get; set; }

        /// <summary>
        /// <para>The conditions for the SQL query. This parameter is a JSON string that contains fields such as Type, <c>Value</c>, <c>Min</c>, and <c>Max</c>. The <c>Type</c> field indicates the query dimension. Valid values for <c>Type</c>: <c>maxCost</c>, <c>status</c>, and <c>cost</c>. The <c>Value</c>, <c>Min</c>, and <c>Max</c> fields specify the query range for the dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>{&quot;Type&quot;:&quot;maxCost&quot;,&quot;Value&quot;:&quot;100&quot;}</c>: queries the details of the top 100 SQL statements that have the longest execution durations. The <c>Value</c> field can only be set to 100.</para>
        /// </description></item>
        /// <item><description><para><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;finished&quot;}</c>: queries the details of completed SQL statements. You can also set <c>Value</c> to <c>running</c> or <c>failed</c> to query SQL statements that are running or have failed.</para>
        /// </description></item>
        /// <item><description><para><c>{&quot;Type&quot;:&quot;cost&quot;,&quot;Min&quot;:&quot;10&quot;,&quot;Max&quot;:&quot;200&quot;}</c>: queries the details of SQL statements whose execution durations are between 10 ms and 200 ms. You can customize the minimum and maximum execution durations. Unit: milliseconds.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;finished&quot;}</para>
        /// </summary>
        [NameInMap("QueryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to view the regions and zones supported by AnalyticDB for MySQL, including region IDs.</para>
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
        /// <para>The resource group to which the SQL statement belongs.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to view the resource groups, database names, usernames, and source IP addresses for the SQL statements that meet the specified query conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Specify the time in the UNIX timestamp format. The time must be in milliseconds.</para>
        /// <remarks>
        /// <para>Only data from the last 14 days can be queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1632931200000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The username used to execute the SQL statement.
        /// Call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to view the resource groups, database names, usernames, and source IP addresses for the SQL statements that meet the specified query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
