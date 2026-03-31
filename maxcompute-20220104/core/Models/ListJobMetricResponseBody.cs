// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListJobMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListJobMetricResponseBodyData Data { get; set; }
        public class ListJobMetricResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The category of the metrics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Metric details.</para>
            /// </summary>
            [NameInMap("metrics")]
            [Validation(Required=false)]
            public List<ListJobMetricResponseBodyDataMetrics> Metrics { get; set; }
            public class ListJobMetricResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>Metric related information.</para>
                /// </summary>
                [NameInMap("metric")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metric { get; set; }

                /// <summary>
                /// <para>Metric values information.</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<List<double?>> Values { get; set; }

            }

            /// <summary>
            /// <para>The name of observation metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>num</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The monitoring statistical period.Unit:Second(s).</para>
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
        /// <para>OBJECT_NOT_EXIST</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This object does not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>1xx: Informational response - Request received, processing continues.</description></item>
        /// <item><description>2xx: Success - The request has been successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: Redirection - Further action must be taken to complete the request.</description></item>
        /// <item><description>4xx: Client error - The request contains bad syntax or cannot be fulfilled.</description></item>
        /// <item><description>5xx: Server error - The server failed to fulfill an apparently valid request.</description></item>
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
        /// <para>0be3e0aa16667684362147582e038f</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
