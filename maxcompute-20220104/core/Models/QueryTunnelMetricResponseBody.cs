// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryTunnelMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryTunnelMetricResponseBodyData Data { get; set; }
        public class QueryTunnelMetricResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The category of the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tunnel</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The metric values.</para>
            /// </summary>
            [NameInMap("metrics")]
            [Validation(Required=false)]
            public List<QueryTunnelMetricResponseBodyDataMetrics> Metrics { get; set; }
            public class QueryTunnelMetricResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>The metadata of the metric.</para>
                /// </summary>
                [NameInMap("metric")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metric { get; set; }

                /// <summary>
                /// <para>A list of metric values.</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<List<double?>> Values { get; set; }

            }

            /// <summary>
            /// <para>The name of the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>slot_usage</para>
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
        /// <para>0A3B1E82006A23A918C70905BF08AEC7</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. If this parameter is not empty and the value is not 200, the operation failed.</para>
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
        /// <para>0bc3b4b016674434996033675e71ee</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
