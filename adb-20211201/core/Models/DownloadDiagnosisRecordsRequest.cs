// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DownloadDiagnosisRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The source IP address.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/308210.html">DescribeDiagnosisDimensions</a> operation to query the resource groups, database names, usernames, and source IP addresses of the SQL statements that meet a query condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>106.11.XX.XX</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1q8bu9a****</para>
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
        /// <para>1662450730000</para>
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
        /// <para>The language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: simplified Chinese.</description></item>
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
        /// <para>88000000</para>
        /// </summary>
        [NameInMap("MaxPeakMemory")]
        [Validation(Required=false)]
        public long? MaxPeakMemory { get; set; }

        /// <summary>
        /// <para>The maximum scan size of the SQL statements. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64424509440</para>
        /// </summary>
        [NameInMap("MaxScanSize")]
        [Validation(Required=false)]
        public long? MaxScanSize { get; set; }

        /// <summary>
        /// <para>The minimum peak memory of the SQL statements. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88000000</para>
        /// </summary>
        [NameInMap("MinPeakMemory")]
        [Validation(Required=false)]
        public long? MinPeakMemory { get; set; }

        /// <summary>
        /// <para>The minimum scan size of the SQL statements. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1073741824</para>
        /// </summary>
        [NameInMap("MinScanSize")]
        [Validation(Required=false)]
        public long? MinScanSize { get; set; }

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
        /// <para>1662364330000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The username that is used to execute the SQL statements.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~~~">DescribeDiagnosisDimensions</a> operation to query the resource groups, database names, usernames, and source IP addresses of the SQL statements that meet a query condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
