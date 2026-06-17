// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricListRequest : TeaModel {
        /// <summary>
        /// <para>The dimensions that specify the resources to be monitored.</para>
        /// <para>Format: a collection of key-value pairs, such as <c>{&quot;userId&quot;:&quot;120886317861****&quot;}</c> and <c>{&quot;instanceId&quot;:&quot;i-2ze2d6j5uhg20x47****&quot;}</c>.</para>
        /// <remarks>
        /// <para>A single request can be used to query a maximum of 50 instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;:&quot;i-2ze2d6j5uhg20x47****&quot;}]</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970.</para>
        /// </description></item>
        /// <item><description><para>Format: YYYY-MM-DD hh:mm:ss.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The interval between \<c>StartTime\\</c> and \<c>EndTime\\</c> must be less than or equal to 31 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-30 00:10:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The expression that is used for real-time computing based on the query results.</para>
        /// <remarks>
        /// <para>Only the groupby expression is supported. This expression is similar to the GROUP BY statement in databases.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;groupby&quot;:[&quot;userId&quot;,&quot;instanceId&quot;]}</para>
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query.</para>
        /// <remarks>
        /// <para>The maximum value of \<c>Length\\</c> in a single request is 1440.</para>
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
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Metrics</a>.</para>
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
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Metrics</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The pagination cursor.</para>
        /// <remarks>
        /// <para>If you do not set this parameter, the first page of data is returned. If a value is returned for this parameter, it indicates that more data is available. To retrieve the next page, use the returned value as the \<c>NextToken\\</c> in your next request. A null value indicates that all data has been retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15761485350009dd70bb64cff1f0fff750b08ffff073be5fb1e785e2b020f1a949d5ea14aea7fed82f01dd8****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The statistical period of the monitoring data.</para>
        /// <para>Valid values: 15, 60, 900, and 3600.</para>
        /// <para>Unit: seconds.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not set this parameter, the reporting period that was specified when the metric was registered is used.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The statistical period of each metric (<c>MetricName</c>) of a cloud service is different. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Metrics</a>.</description></item>
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
        /// <para>The beginning of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970.</para>
        /// </description></item>
        /// <item><description><para>Format: YYYY-MM-DD hh:mm:ss.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The time range is a left-open and right-closed interval. The value of \<c>StartTime\\</c> must be earlier than the value of \<c>EndTime\\</c>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The interval between \<c>StartTime\\</c> and \<c>EndTime\\</c> must be less than or equal to 31 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-30 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
