// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutCustomMetricRequest : TeaModel {
        /// <summary>
        /// <para>The list of monitoring data.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MetricList")]
        [Validation(Required=false)]
        public List<PutCustomMetricRequestMetricList> MetricList { get; set; }
        public class PutCustomMetricRequestMetricList : TeaModel {
            /// <summary>
            /// <para>The dimension map, which is used to query monitoring data of a specified resource. Valid values of N: 1 to 21.</para>
            /// <para>Format: a collection of key-value pairs. A commonly used key-value pair collection is: <c>{&quot;Key&quot;:&quot;Value&quot;}</c>.</para>
            /// <para>The length of Key and Value is 1 to 64 characters. Characters beyond the first 64 are truncated.</para>
            /// <para>The values of Key and Value can contain letters, digits, periods (.), hyphens (-), underscores (_), forward slashes (/), and backslashes (\).</para>
            /// <remarks>
            /// <para>Dimensions must be passed in as a JSON string that represents the map object, and must be passed in order.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;sampleName1&quot;:&quot;value1&quot;,&quot;sampleName2&quot;:&quot;value2&quot;}</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public string Dimensions { get; set; }

            /// <summary>
            /// <para>The ID of the application group. Valid values of N: 1 to 21.</para>
            /// <remarks>
            /// <para>If the metric does not belong to any application group, enter 0.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the metric. Valid values of N: 1 to 21. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Metrics of cloud services</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The aggregation period. Valid values of N: 1 to 21. Unit: seconds. Valid values: 60 and 300.</para>
            /// <remarks>
            /// <para>If the type of the reported value is 1, you must set this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <para>The time when the metric occurred. Valid values of N: 1 to 21. The following two types of values are supported:</para>
            /// <list type="bullet">
            /// <item><description>UTC time. Format: YYYY-MM-DDThh:mm:ssZ. For example: 20171012T132456.888+0800.</description></item>
            /// <item><description>A Long-type timestamp. For example: 1508136760000.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1508136760000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The type of the reported value. Valid values of N: 1 to 21. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: raw data.</description></item>
            /// <item><description>1: aggregate data.</description></item>
            /// </list>
            /// <remarks>
            /// <para>When you report aggregate data, we recommend that you report both data with a period of 60 seconds and data with a period of 300 seconds. Otherwise, monitoring data cannot be queried for a time span of more than 7 days.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The collection of metric values. Valid values of N: 1 to 21.</para>
            /// <remarks>
            /// <para>If the type of the reported value is 0, the raw values are reported. CloudMonitor aggregates raw values into multiple values, such as maximum, count, and sum, by period.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;value&quot;:10.5}</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
