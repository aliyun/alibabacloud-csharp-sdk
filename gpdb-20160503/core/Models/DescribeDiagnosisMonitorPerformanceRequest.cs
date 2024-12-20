// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisMonitorPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including instance IDs.</para>
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
        /// <para>The name of the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbtest</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time must be in UTC. The end time must be later than the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-07T07:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The filter condition on queries. Specify the value in the JSON format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>{&quot;Type&quot;:&quot;maxCost&quot;, &quot;Value&quot;:&quot;100&quot;}</c>: filters the top 100 queries that are the most time-consuming.</para>
        /// </description></item>
        /// <item><description><para><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;finished&quot;}</c>: filters completed queries.</para>
        /// </description></item>
        /// <item><description><para><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;running&quot;}</c>: filters running queries.</para>
        /// </description></item>
        /// <item><description><para><c>{&quot;Type&quot;:&quot;cost&quot;,&quot;Min&quot;:&quot;30&quot;,&quot;Max&quot;:&quot;50&quot;}</c>: filters the queries that consume 30 milliseconds or more and less than 50 milliseconds. You can customize a filter condition by setting <b>Min</b> and <b>Max</b>.</para>
        /// <list type="bullet">
        /// <item><description>If only <b>Min</b> is specified, the queries that consume a period of time that is greater than or equal to the Min value are filtered.</description></item>
        /// <item><description>If only <b>Max</b> is specified, the queries that consume a period of time that is less than the Max value are filtered.</description></item>
        /// <item><description>If both <b>Min</b> and <b>Max</b> are specified, the queries that consume a period of time that is greater than or equal to the <b>Min</b> value and less than the <b>Max</b> value are filtered.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;:&quot;maxCost&quot;, &quot;Value&quot;:&quot;100&quot;}</para>
        /// </summary>
        [NameInMap("QueryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-07T06:59Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbpguser</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
