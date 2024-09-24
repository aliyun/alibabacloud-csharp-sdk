// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDiagnosisDimensionsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bt6u59zcmd945****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

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
        /// <para>1625220213000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b> (default): simplified Chinese.</description></item>
        /// <item><description><b>en-US</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The query condition for SQL statements, which can contain the <c>Type</c>, <c>Value</c>, <c>Min</c>, and <c>Max</c> fields. Specify the condition in the JSON format. <c>Type</c> specifies the query dimension. Valid values for Type: <c>maxCost</c>, <c>status</c>, and <c>cost</c>. <c>Value</c>, <c>Min</c>, or <c>Max</c> specifies the query range for the dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>{&quot;Type&quot;:&quot;maxCost&quot;,&quot;Value&quot;:&quot;100&quot;}</c>: queries the top 100 most time-consuming SQL statements. Set <c>Value</c> to 100.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;finished&quot;}</c>: queries the executed SQL statements. You can set <c>Value</c> to <c>running</c> to query the SQL statements that are being executed. You can also set Value to <c>failed</c> to query the SQL statements that failed to be executed.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;cost&quot;,&quot;Min&quot;:&quot;10&quot;,&quot;Max&quot;:&quot;200&quot;}</c>: queries the SQL statements whose execution duration is in the range of 10 to 200 milliseconds. You can also specify custom values for the Min and Max fields.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;:&quot;maxCost&quot;,&quot;Value&quot;:&quot;100&quot;}</para>
        /// </summary>
        [NameInMap("QueryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The beginning of the time range to query. Set the time to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para> You can query data only within the last 14 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1625220210000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
