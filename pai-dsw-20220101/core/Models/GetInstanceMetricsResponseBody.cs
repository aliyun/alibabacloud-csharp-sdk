// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetInstanceMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InternalError: an internal error. All errors, except for parameter validation errors, are classified as internal errors.</description></item>
        /// <item><description>ValidationError: a parameter validation error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>400</description></item>
        /// <item><description>404</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsw-730xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;XXX&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The information about the metrics of the pod that corresponds to the instance.</para>
        /// </summary>
        [NameInMap("PodMetrics")]
        [Validation(Required=false)]
        public List<GetInstanceMetricsResponseBodyPodMetrics> PodMetrics { get; set; }
        public class GetInstanceMetricsResponseBodyPodMetrics : TeaModel {
            /// <summary>
            /// <para>The metrics of the pod that corresponds to the instance.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<GetInstanceMetricsResponseBodyPodMetricsMetrics> Metrics { get; set; }
            public class GetInstanceMetricsResponseBodyPodMetricsMetrics : TeaModel {
                /// <summary>
                /// <para>The timestamp corresponding to the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1670890560</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

                /// <summary>
                /// <para>The metric value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25.901031</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the pod that corresponds to the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsw-15870-695f44c5bc-hd6xm</para>
            /// </summary>
            [NameInMap("PodId")]
            [Validation(Required=false)]
            public string PodId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7D55162-4489-1619-AAF5-3F97D5FCA948</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
