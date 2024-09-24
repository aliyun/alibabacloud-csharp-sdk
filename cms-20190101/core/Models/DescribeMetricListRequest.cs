// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricListRequest : TeaModel {
        /// <summary>
        /// <para>The dimensions that specify the resources whose monitoring data you want to query.</para>
        /// <para>Set the value to a collection of key-value pairs. A typical key-value pair is <c>instanceId:i-2ze2d6j5uhg20x47****</c>.</para>
        /// <remarks>
        /// <para> You can query a maximum of 50 instances in a single request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;: &quot;i-abcdefgh12****&quot;}]</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 Thursday, January 1, 1970</description></item>
        /// <item><description>UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-30 00:10:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The expression that is used to compute the query results in real time.</para>
        /// <remarks>
        /// <para> Only the groupby expression is supported. This expression is similar to the GROUP BY statement that is used in databases.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;groupby&quot;:[&quot;userId&quot;,&quot;instanceId&quot;]}</para>
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <remarks>
        /// <para> The maximum value of the Length parameter in a request is 1440.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <para>The name of the metric.</para>
        /// <para>For more information about metric names, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_idle</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service. Format: acs_service name.</para>
        /// <para>For more information about the namespaces of cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The paging token.</para>
        /// <remarks>
        /// <para> If this parameter is not specified, the data on the first page is returned. A return value other than Null of this parameter indicates that not all entries have been returned. You can use this value as an input parameter to obtain entries on the next page. The value Null indicates that all query results have been returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15761485350009dd70bb64cff1f0fff750b08ffff073be5fb1e785e2b020f1a949d5ea14aea7fed82f01dd8****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The interval at which the monitoring data is queried.</para>
        /// <para>Valid values: 60, 300, and 900.</para>
        /// <para>Unit: seconds.</para>
        /// <remarks>
        /// <para> Configure this parameter based on your business scenario.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 Thursday, January 1, 1970</description></item>
        /// <item><description>UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format</description></item>
        /// </list>
        /// <remarks>
        /// <para> The specified period includes the end time and excludes the start time. The start time must be earlier than the end time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-30 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
