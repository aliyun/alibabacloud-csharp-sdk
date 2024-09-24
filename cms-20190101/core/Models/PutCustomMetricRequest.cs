// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutCustomMetricRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MetricList")]
        [Validation(Required=false)]
        public List<PutCustomMetricRequestMetricList> MetricList { get; set; }
        public class PutCustomMetricRequestMetricList : TeaModel {
            /// <summary>
            /// <para>The dimensions that specify the resources whose monitoring data you want to query. Valid values of N: 1 to 21.</para>
            /// <para>Set the value to a collection of key-value pairs. Format:<c>{&quot;Key&quot;:&quot;Value&quot;}</c>.</para>
            /// <para>The key or value must be 1 to 64 bytes in length. Excessive characters are truncated.</para>
            /// <para>The key or value can contain letters, digits, periods (.), hyphens (-), underscores (_), forward slashes (/), and backslashes (\\).</para>
            /// <remarks>
            /// <para> Dimensions must be formatted as a JSON string in a specified order.</para>
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
            /// <para> If the metric does not belong to any application group, enter 0.</para>
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
            /// <para>The name of the metric. Valid values of N: 1 to 21. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
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
            /// <para> If the MetricList.N.Type parameter is set to 1, the MetricList.N.Period parameter is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <para>The timestamp when the metric data is generated. Valid values of N: 1 to 21. The timestamp can be in one of the following formats:</para>
            /// <list type="bullet">
            /// <item><description>The UTC timestamp that is in the YYYY-MM-DDThh:mm:ssZ format. Example: 20171012T132456.888+0800.</description></item>
            /// <item><description>The UNIX timestamp of the LONG type. Example: 1508136760000.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1508136760000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The type of the reported data. Valid values of N: 1 to 21. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: reports raw data</description></item>
            /// <item><description>1: reports aggregate data</description></item>
            /// </list>
            /// <remarks>
            /// <para> We recommend that you report aggregate data in both the aggregation periods of 60s and 300s. Otherwise, you cannot query monitoring data in a time span that is more than seven days.</para>
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
            /// <para> If the MetricList.N.Type parameter is set to 0, the keys in this parameter must be set to the specified value. CloudMonitor aggregates raw data in each aggregation period to generate multiple statistical values, such as the maximum value, the count, and the total value.</para>
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
