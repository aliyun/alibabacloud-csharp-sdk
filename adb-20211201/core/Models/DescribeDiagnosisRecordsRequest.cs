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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to query the resource group, database name, username, and source IP address of the SQL statements that meet the specified search conditions.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/612397.html">DescribeDBClusters</a> operation to query the details of all clusters under your account, including the cluster IDs.</para>
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
        /// <para>The database in which the SQL statement is executed.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to query the resource group, database name, username, and source IP address of the SQL statements that meet the specified search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is a UNIX timestamp in milliseconds.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The end time must be later than the start time.</description></item>
        /// <item><description>The interval between the start time and the end time cannot exceed 24 hours.</description></item>
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
        /// <para>The keyword used to filter SQL statements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the downloaded file title and some error messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Simplified Chinese (default).</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// <item><description><b>zh-tw</b>: Traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The Peak Volume of memory for the SQL statement. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89000000</para>
        /// </summary>
        [NameInMap("MaxPeakMemory")]
        [Validation(Required=false)]
        public long? MaxPeakMemory { get; set; }

        /// <summary>
        /// <para>The maximum scan size of the SQL statement. Unit: bytes.</para>
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
        /// <para>The sorting rules for SQL statements based on specified fields. The value is a JSON array that contains the Field and Type fields. The SQL statements are sorted in the order of the fields in the array. Example: <c>[{&quot;Field&quot;:&quot;StartTime&quot;, &quot;Type&quot;: &quot;desc&quot; }]</c>.</para>
        /// <list type="bullet">
        /// <item><description>Field: the name of the field by which you want to sort the SQL statements. Valid values:<list type="bullet">
        /// <item><description>StartTime: the start time of the execution.</description></item>
        /// <item><description>Status: the execution status.</description></item>
        /// <item><description>UserName: the username.</description></item>
        /// <item><description>Cost: the execution duration.</description></item>
        /// <item><description>PeakMemory: the peak memory.</description></item>
        /// <item><description>ScanSize: the scan size.</description></item>
        /// <item><description>Database: the database name.</description></item>
        /// <item><description>ClientIp: the source IP address.</description></item>
        /// <item><description>ResourceGroup: the resource group.</description></item>
        /// <item><description>QueueTime: the queue time.</description></item>
        /// <item><description>OutputRows: the number of output rows.</description></item>
        /// <item><description>OutputDataSize: the output data size.</description></item>
        /// <item><description>ResourceCostRank: the ranking of the execution duration of internal operators in the SQL statement. This field is supported only when QueryCondition is set to <c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;running&quot;}</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Type: the sorting type. Valid values (case-insensitive):<list type="bullet">
        /// <item><description>Desc: descending order.</description></item>
        /// <item><description>Asc: ascending order.</description></item>
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
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the INTEGER data type. Default value: 1.</para>
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
        /// <para>The ID of the SQL pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5575924945138******</para>
        /// </summary>
        [NameInMap("PatternId")]
        [Validation(Required=false)]
        public string PatternId { get; set; }

        /// <summary>
        /// <para>The conditions for the SQL query. The value is a JSON string that contains fields such as Type, Value, Min, and Max. The Type field specifies the query dimension. Valid values: maxCost, status, and cost. The Value, Min, or Max field specifies the query range for the dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>{&quot;Type&quot;:&quot;maxCost&quot;,&quot;Value&quot;:&quot;100&quot;}</c>: queries the details of the top 100 SQL statements with the longest execution duration. Currently, the Value field can only be set to 100.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;finished&quot;}</c>: queries the details of completed SQL statements. You can also set Value to running or failed to query the details of running or failed SQL statements.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;cost&quot;,&quot;Min&quot;:&quot;10&quot;,&quot;Max&quot;:&quot;200&quot;}</c>: queries the details of SQL statements whose execution duration is between 10 milliseconds and 200 milliseconds. You can also customize the maximum and minimum execution duration in milliseconds.</description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the regions and zones supported by AnalyticDB for MySQL, including the region IDs.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to query the resource group, database name, username, and source IP address of the SQL statements that meet the specified search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is a UNIX timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>You can only query data within the last 14 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1632931200000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The username that executes the SQL statement.
        /// You can call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to query the resource group, database name, username, and source IP address of the SQL statements that meet the specified search conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
