// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryTunnelMetricDetailResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryTunnelMetricDetailResponseBodyData Data { get; set; }
        public class QueryTunnelMetricDetailResponseBodyData : TeaModel {
            [NameInMap("metrics")]
            [Validation(Required=false)]
            public List<QueryTunnelMetricDetailResponseBodyDataMetrics> Metrics { get; set; }
            public class QueryTunnelMetricDetailResponseBodyDataMetrics : TeaModel {
                [NameInMap("metric")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metric { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;avgValue&quot;:&quot;11.5&quot;</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public Dictionary<string, object> Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tableA</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OBJECT_NOT_EXIST</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>plan \&quot;***\&quot; does not exist</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0a06dd4516687375802853481ec9fd</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
