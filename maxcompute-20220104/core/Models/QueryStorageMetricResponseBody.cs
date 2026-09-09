// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryStorageMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryStorageMetricResponseBodyData Data { get; set; }
        public class QueryStorageMetricResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The category of the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>storage</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The metric values.</para>
            /// </summary>
            [NameInMap("metrics")]
            [Validation(Required=false)]
            public List<QueryStorageMetricResponseBodyDataMetrics> Metrics { get; set; }
            public class QueryStorageMetricResponseBodyDataMetrics : TeaModel {
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
            /// <para>summary</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The step size of the monitoring data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
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
        /// <para>0A3B1FD2006A24C8D8BE65CDAC028298</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para>1xx: Informational - The request was received and is being processed.</para>
        /// </description></item>
        /// <item><description><para>2xx: Success - The request was successfully received, understood, and accepted by the server.</para>
        /// </description></item>
        /// <item><description><para>3xx: Redirection - The request was redirected. Further action is needed to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: Client error - The request contains incorrect parameters or syntax, or cannot be fulfilled.</para>
        /// </description></item>
        /// <item><description><para>5xx: Server error - The server failed to fulfill the request for other reasons.</para>
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
        /// <para>0be3e0bb16654558425251398e27a9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
