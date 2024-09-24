// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The dimensions based on which the resources are queried.</para>
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
        /// <para>The end of the time range to query monitoring data.</para>
        /// <list type="bullet">
        /// <item><description><para>If the <c>StartTime</c> and <c>EndTime</c> parameters are not specified, the monitoring data of the last statistical period is queried.``</para>
        /// </description></item>
        /// <item><description><para>If the <c>StartTime</c> and <c>EndTime</c> parameters are specified, the monitoring data of the last statistical period in the specified time range is queried.```` The following examples demonstrate how to determine the period in which monitoring data is queried:</para>
        /// <list type="bullet">
        /// <item><description>If you set the <c>Period</c> parameter to 15, the specified time range must be less than or equal to 20 minutes. For example, if you set the StartTime parameter to 2021-05-08 08:10:00 and the EndTime parameter to 2021-05-08 08:30:00, the monitoring data of the last 15 seconds in the time range is queried.</description></item>
        /// <item><description>If you set the <c>Period</c> to 60 or 900, the specified time range must be less than or equal to 2 hours. For example, if you set the Period parameter to 60, the StartTime parameter to 2021-05-08 08:00:00, and the EndTime parameter to 2021-05-08 10:00:00, the monitoring data of the last 60 seconds in the time range is queried.</description></item>
        /// <item><description>If you set the <c>Period</c> parameter to 3600, the specified time range must be less than or equal to 2 days. For example, if you set the StartTime parameter to 2021-05-08 08:00:00 and the EndTime parameter to 2021-05-10 08:00:00, the monitoring data of the last 3,600 seconds in the time range is queried.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 UTC on Thursday, January 1, 1970.</description></item>
        /// <item><description>UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format.</description></item>
        /// </list>
        /// <remarks>
        /// <para> We recommend that you use UNIX timestamps to prevent time zone-related issues.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1618368960000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The expression that is used to compute the query results in real time.</para>
        /// <remarks>
        /// <para> Only the <c>groupby</c> expression is supported. This expression is similar to the <c>GROUP BY</c> statement that is used in databases.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;groupby&quot;:[&quot;userId&quot;,&quot;instanceId&quot;]}</para>
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Default value: 1000.</para>
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
        /// <para>The metric that is used to monitor the cloud service.</para>
        /// <para>For more information about the metrics of cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_idle</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service.</para>
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
        /// <para>The statistical period of the metric.</para>
        /// <para>Valid values: 15, 60, 900, and 3600.</para>
        /// <para>Unit: seconds.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified, monitoring data is queried based on the period in which metric values are reported.</para>
        /// </description></item>
        /// <item><description><para>For more information about the statistical period of a metric that is specified by the <c>MetricName</c> parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The start of the time range to query monitoring data.</para>
        /// <list type="bullet">
        /// <item><description><para>If the <c>StartTime</c> and <c>EndTime</c> parameters are not specified, the monitoring data of the last statistical period is queried.``</para>
        /// </description></item>
        /// <item><description><para>If the <c>StartTime</c> and <c>EndTime</c> parameters are specified, the monitoring data of the last statistical period in the specified time range is queried.```` The following examples demonstrate how to determine the period in which monitoring data is queried:</para>
        /// <list type="bullet">
        /// <item><description>If you set the <c>Period</c> parameter to 15, the specified time range must be less than or equal to 20 minutes. For example, if you set the StartTime parameter to 2021-05-08 08:10:00 and the EndTime parameter to 2021-05-08 08:30:00, the monitoring data of the last 15 seconds in the time range is queried.</description></item>
        /// <item><description>If you set the <c>Period</c> to 60 or 900, the specified time range must be less than or equal to 2 hours. For example, if you set the Period parameter to 60, the StartTime parameter to 2021-05-08 08:00:00, and the EndTime parameter to 2021-05-08 10:00:00, the monitoring data of the last 60 seconds in the time range is queried.</description></item>
        /// <item><description>If you set the <c>Period</c> parameter to 3600, the specified time range must be less than or equal to 2 days. For example, if you set the StartTime parameter to 2021-05-08 08:00:00 and the EndTime parameter to 2021-05-10 08:00:00, the monitoring data of the last 3,600 seconds in the time range is queried.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 UTC on Thursday, January 1, 1970.</description></item>
        /// <item><description>UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You must set the <c>StartTime</c> parameter to a point in time that is later than 00:00:00 UTC on Thursday, January 1, 1970. Otherwise, this parameter is invalid.</para>
        /// </description></item>
        /// <item><description><para>We recommend that you use UNIX timestamps to prevent time zone-related issues.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1618368900000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
