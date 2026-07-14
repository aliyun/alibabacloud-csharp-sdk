// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeModelOperatorUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time of the query. The time is in the <i>YYYY-MM-DDThh:mmZ</i> format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-02T00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of metric values.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<DescribeModelOperatorUsageResponseBodyKeys> Keys { get; set; }
        public class DescribeModelOperatorUsageResponseBodyKeys : TeaModel {
            /// <summary>
            /// <para>The metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>request_count</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The collection of metric values.</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeModelOperatorUsageResponseBodyKeysSeries> Series { get; set; }
            public class DescribeModelOperatorUsageResponseBodyKeysSeries : TeaModel {
                /// <summary>
                /// <para>The API key ID. This value is returned only when GroupBy contains api_key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ApiKeyId")]
                [Validation(Required=false)]
                public int? ApiKeyId { get; set; }

                /// <summary>
                /// <para>The model name when GroupBy contains model. The api_key_id string when GroupBy contains only api_key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen3.6-plus</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The normalized GroupBy value: model, api_key, or model,api_key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>model</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The list of metric values. Each value corresponds to a collection time point.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeModelOperatorUsageResponseBodyKeysSeriesValues> Values { get; set; }
                public class DescribeModelOperatorUsageResponseBodyKeysSeriesValues : TeaModel {
                    /// <summary>
                    /// <para>The specific metric information, consisting of a timestamp and a metric value.</para>
                    /// </summary>
                    [NameInMap("Point")]
                    [Validation(Required=false)]
                    public List<string> Point { get; set; }

                }

            }

            /// <summary>
            /// <para>The unit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>requests</description></item>
            /// <item><description>tokens</description></item>
            /// <item><description>%</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>requests</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The actual bucket size used, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is in the <i>YYYY-MM-DDThh:mmZ</i> format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-01T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
