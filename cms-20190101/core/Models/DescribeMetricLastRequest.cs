// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricLastRequest : TeaModel {
        /// <summary>
        /// <para>The monitoring dimensions of the specified resource.</para>
        /// <para>Set the value to a collection of <c>key:value</c> pairs. Example: <c>{&quot;userId&quot;:&quot;120886317861****&quot;}</c> or <c>{&quot;instanceId&quot;:&quot;i-2ze2d6j5uhg20x47****&quot;}</c>.</para>
        /// <remarks>
        /// <para> You can query a maximum of 50 instances in each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;:&quot;i-abcdefgh12****&quot;}]</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The end of the time range to query monitoring data.</para>
        /// <list type="bullet">
        /// <item><description>For second-level data, the start time is obtained by comparing the time that is specified by the StartTime parameter and 20 minutes earlier of the time that is specified by the EndTime parameter. The earlier one of the compared points in time is used as the start time.</description></item>
        /// <item><description>For minute-level data, the start time is obtained by comparing the time that is specified by the StartTime parameter and 2 hours earlier of the time that is specified by the EndTime parameter. The earlier one of the compared points in time is used as the start time.</description></item>
        /// <item><description>For hour-level data, the start time is obtained by comparing the time that is specified by the StartTime parameter and two days earlier of the time that is specified by the EndTime parameter. The earlier one of the compared points in time is used as the start time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-31 10:10:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The expression that is used to calculate the query results in real time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;groupby&quot;:[&quot;userId&quot;,&quot;instanceId&quot;]}</para>
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Default value: 1000. This value indicates that a maximum of 1,000 entries of monitoring data can be returned on each page.</para>
        /// <remarks>
        /// <para> The maximum value of the Length parameter for each request is 1440.</para>
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
        /// <para>For more information about metric names, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPUUtilization</para>
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
        /// <para>The pagination token.</para>
        /// <list type="bullet">
        /// <item><description>If the number of results exceeds the maximum number of entries allowed on a single page, a pagination token is returned.</description></item>
        /// <item><description>This token can be used as an input parameter to obtain the next page of results. If all results are obtained, no token is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>15761432850009dd70bb64cff1f0fff6c0b08ffff073be5fb1e785e2b020f7fed9b5e137bd810a6d6cff5ae****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The statistical period of the monitoring data.</para>
        /// <para>Valid values: 15, 60, 900, and 3600.</para>
        /// <para>Unit: seconds.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified, monitoring data is queried based on the period in which metric values are reported. The statistical period of metrics (<c>MetricName</c>) varies for each cloud service. The statistical period of metrics is displayed in the <c>MinPeriods</c> column on the <b>Metrics</b> page for each cloud service. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-31 10:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
