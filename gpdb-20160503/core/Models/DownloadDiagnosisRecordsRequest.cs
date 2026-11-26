// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DownloadDiagnosisRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to view the details of all AnalyticDB for PostgreSQL instances in a specific region, including the instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbtest</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end time of the query. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-07T07:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The language of the downloaded file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Simplified Chinese.</description></item>
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
        /// <para>The query filter conditions in JSON format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>{&quot;Type&quot;:&quot;maxCost&quot;, &quot;Value&quot;:&quot;100&quot;}</c>: The 100 queries with the longest execution duration.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;finished&quot;}</c>: Completed queries.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;running&quot;}</c>: Running queries.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;cost&quot;,&quot;Max&quot;:&quot;200&quot;}</c>: Short-duration queries, which are queries with an execution duration of less than 200 milliseconds.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;cost&quot;,&quot;Min&quot;:&quot;200&quot;,&quot;Max&quot;:&quot;60000&quot;}</c>: Medium-duration queries, which are queries with an execution duration of 200 milliseconds or more but less than 1 minute.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;cost&quot;,&quot;Min&quot;:&quot;60000&quot;}</c>: Long-duration queries, which are queries with an execution duration of 1 minute or more.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;cost&quot;,&quot;Min&quot;:&quot;30&quot;,&quot;Max&quot;:&quot;50&quot;}</c>: Custom-duration queries. You can specify the minimum and maximum execution duration of the queries. <b>Min</b> specifies the minimum execution duration, and <b>Max</b> specifies the maximum execution duration. Unit: milliseconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Type&quot;:&quot;maxCost&quot;, &quot;Value&quot;:&quot;100&quot; }</para>
        /// </summary>
        [NameInMap("QueryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-07T06:59Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbpguser</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
