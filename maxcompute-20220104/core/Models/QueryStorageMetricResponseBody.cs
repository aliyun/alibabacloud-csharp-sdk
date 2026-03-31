// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryStorageMetricResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryStorageMetricResponseBodyData Data { get; set; }
        public class QueryStorageMetricResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>storage</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("metrics")]
            [Validation(Required=false)]
            public List<QueryStorageMetricResponseBodyDataMetrics> Metrics { get; set; }
            public class QueryStorageMetricResponseBodyDataMetrics : TeaModel {
                [NameInMap("metric")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metric { get; set; }

                [NameInMap("values")]
                [Validation(Required=false)]
                public List<List<double?>> Values { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>summary</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0A3B1FD2006A24C8D8BE65CDAC028298</para>
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
        /// <para>0be3e0bb16654558425251398e27a9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
