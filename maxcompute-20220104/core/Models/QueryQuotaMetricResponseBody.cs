// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryQuotaMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryQuotaMetricResponseBodyData Data { get; set; }
        public class QueryQuotaMetricResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>不支持。</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The metric values.</para>
            /// </summary>
            [NameInMap("metrics")]
            [Validation(Required=false)]
            public List<QueryQuotaMetricResponseBodyDataMetrics> Metrics { get; set; }
            public class QueryQuotaMetricResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>The metadata of the metric.</para>
                /// </summary>
                [NameInMap("metric")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metric { get; set; }

                /// <summary>
                /// <para>The time series data.</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<List<double?>> Values { get; set; }

            }

            /// <summary>
            /// <para>The name of the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The step size of the monitoring data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan \&quot;***\&quot; does not exist</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para>1xx: informational response. The request was received and is being processed.</para>
        /// </description></item>
        /// <item><description><para>2xx: success. The request was successfully received, understood, and accepted by the server.</para>
        /// </description></item>
        /// <item><description><para>3xx: redirection. The request was redirected. Further action needs to be taken to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: client error. The request contains incorrect request parameters or syntax, or specific request conditions cannot be met.</para>
        /// </description></item>
        /// <item><description><para>5xx: server error. The server failed to fulfill the request for other reasons.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b87b7b316643495896551555e855b</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
