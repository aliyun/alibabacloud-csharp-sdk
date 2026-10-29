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
        /// <para>Format: a collection of <c>key:value</c> pairs. Example: <c>{&quot;userId&quot;:&quot;120886317861****&quot;}</c> or <c>{&quot;instanceId&quot;:&quot;i-2ze2d6j5uhg20x47****&quot;}</c>.</para>
        /// <remarks>
        /// <para>A maximum of 50 instances can be queried in a single request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;:&quot;i-2ze2d6j5uhg20x47****&quot;}]</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The end time for querying the metric.</para>
        /// <para>The system automatically limits the query start time (query window size) based on data granularity:</para>
        /// <ol>
        /// <item><description>Second-level data: The maximum query span is 20 minutes (start time = Max(startTime, EndTime - 20min)).</description></item>
        /// <item><description>Minute-level data: The maximum query span is 2 hours (start time = Max(startTime, EndTime - 2h)).</description></item>
        /// <item><description>Hour-level data: The maximum query span is 2 days (start time = Max(startTime, EndTime - 2d)).</description></item>
        /// </ol>
        /// <remarks>
        /// <para>If the specified startTime is earlier than the limit, the system automatically uses the limit as the actual query start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-31 10:10:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The expression for real-time computation on existing query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;groupby&quot;:[&quot;userId&quot;,&quot;instanceId&quot;]}</para>
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// <para>The number of entries per page for monitoring data. This parameter is used for paged query.</para>
        /// <para>Default value: 1000, which indicates 1000 entries of monitoring data per page.</para>
        /// <remarks>
        /// <para>The maximum value of Length in a single request is 1440.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <para>The metric name of the cloud service.</para>
        /// <para>For information about metric names, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
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
        /// <para>For information about namespaces of cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
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
        /// <list type="bullet">
        /// <item><description>If the query results that match the filter conditions exceed the page size, a pagination cursor is returned.</description></item>
        /// <item><description>To retrieve the next page of data, use the returned cursor value as the request parameter until no cursor value is returned, which indicates that all data has been retrieved.</description></item>
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
        /// <list type="bullet">
        /// <item><description>If you do not set the statistical period, monitoring data is queried based on the reporting period that was specified when the metric was registered.<list type="bullet">
        /// <item><description>The statistical period varies by metric (<c>MetricName</c>) for each cloud service. For more information, see the <c>Min Periods</c> column on the metric list page of the target cloud service in <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
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
        /// <para>The start time.</para>
        /// <para>Two formats are supported: 1. A UNIX timestamp string in milliseconds (ms), which represents the number of milliseconds elapsed since 1970-01-01 00:00:00 UTC. 2. A time string in the ISO 8601 format of YYYY-MM-DDThh:mm:ssZ in UTC.</para>
        /// <remarks>
        /// <para>The query range uses a left-exclusive and right-inclusive mode. StartTime cannot be equal to or greater than EndTime, and the interval between them must be less than or equal to 31 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-31 10:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
