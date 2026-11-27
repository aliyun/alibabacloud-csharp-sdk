// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListLLMGatewayMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The time granularity of the returned metric data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>minute</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The list of metric series. Each element contains the metric key, model name, unit, and list of data points.</para>
        /// </summary>
        [NameInMap("MetricItems")]
        [Validation(Required=false)]
        public List<ListLLMGatewayMetricsResponseBodyMetricItems> MetricItems { get; set; }
        public class ListLLMGatewayMetricsResponseBodyMetricItems : TeaModel {
            /// <summary>
            /// <para>The list of minute-level data points for the metric series.</para>
            /// </summary>
            [NameInMap("DataPoints")]
            [Validation(Required=false)]
            public List<ListLLMGatewayMetricsResponseBodyMetricItemsDataPoints> DataPoints { get; set; }
            public class ListLLMGatewayMetricsResponseBodyMetricItemsDataPoints : TeaModel {
                /// <summary>
                /// <para>The UNIX timestamp of the minute for the data point, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1779799200000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The metric value, returned as a string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16022</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The metric key. For tokenPerMinute, the returned values can be inputTokens, outputTokens, implicitCachedTokens, explicitCachedTokens, and totalTokens. For requestPerMinute, the returned value is requestPerMinute. For errorRequestPerMinute, the returned value is the HTTP status code. For timeToFirstToken, the returned values can be averageTimeToFirstTokenMs, p50TimeToFirstTokenMs, p90TimeToFirstTokenMs, p95TimeToFirstTokenMs, and p99TimeToFirstTokenMs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inputTokens</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The name of the model corresponding to the metric series.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The unit of the metric value. The unit is tokens for token usage metrics, count for request and error request metrics, and ms for time to first token metrics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tokens</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The metric type for the current request. Valid values: tokenPerMinute, requestPerMinute, errorRequestPerMinute, and timeToFirstToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tokenPerMinute</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABCDEF77-41B5-5F9E-81E8-93DFDD379024</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
