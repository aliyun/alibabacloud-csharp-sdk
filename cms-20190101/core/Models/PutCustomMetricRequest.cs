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
            /// <para>The dimension map used to query the monitoring data of a specified resource. Valid values of N: 1 to 21.</para>
            /// <para>Format: a set of key-value pairs. A common key-value pair is <c>{&quot;Key&quot;:&quot;Value&quot;}</c>.</para>
            /// <para>The key and value must be 1 to 64 characters in length. If the length exceeds 64 characters, the string is truncated to 64 characters.</para>
            /// <para>The key and value can contain letters, digits, periods (.), hyphens (-), underscores (_), forward slashes (/), and backslashes (\).</para>
            /// <remarks>
            /// <para>You must specify the Dimensions parameter as a JSON string to represent the map object. The key-value pairs must be specified in order.</para>
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
            /// <para>If the metric does not belong to an application group, set this parameter to 0.</para>
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
            /// <para>The name of the metric. Valid values of N: 1 to 21. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service metrics</a>.</para>
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
            /// <para>If the type of the reported value is 1, you must specify this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <para>The time when the metric was generated. Valid values of N: 1 to 21. Supported formats:</para>
            /// <list type="bullet">
            /// <item><description>UTC time. Format: YYYY-MM-DDThh:mm:ssZ. Example: 20171012T132456.888+0800.</description></item>
            /// <item><description>Long timestamp. Example: 1508136760000.</description></item>
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
            /// <item><description>0: Raw data.</description></item>
            /// <item><description>1: Aggregate data.</description></item>
            /// </list>
            /// <remarks>
            /// <para>When reporting aggregate data, report data for both the 60-second and 300-second periods. Otherwise, you cannot query monitoring data that spans more than 7 days.</para>
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
            /// <para>The set of metric values. Valid values of N: 1 to 21.</para>
            /// <remarks>
            /// <para>If the type of the reported value is 0, the reported values are raw values. CloudMonitor aggregates the raw values into multiple values such as maximum, count, and sum based on the period.</para>
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
