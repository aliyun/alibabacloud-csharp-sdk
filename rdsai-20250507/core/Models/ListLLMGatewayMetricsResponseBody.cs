// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListLLMGatewayMetricsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>minute</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        [NameInMap("MetricItems")]
        [Validation(Required=false)]
        public List<ListLLMGatewayMetricsResponseBodyMetricItems> MetricItems { get; set; }
        public class ListLLMGatewayMetricsResponseBodyMetricItems : TeaModel {
            [NameInMap("DataPoints")]
            [Validation(Required=false)]
            public List<ListLLMGatewayMetricsResponseBodyMetricItemsDataPoints> DataPoints { get; set; }
            public class ListLLMGatewayMetricsResponseBodyMetricItemsDataPoints : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1779799200000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16022</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>inputTokens</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tokens</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tokenPerMinute</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABCDEF77-41B5-5F9E-81E8-93DFDD379024</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
