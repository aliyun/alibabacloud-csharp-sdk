// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetEmonMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2D184B55-FA51-43F7-A1EF-E68A0545****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetEmonMonitorDataResponseBodyResult> Result { get; set; }
        public class GetEmonMonitorDataResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;1586249280&quot;: 465.1980465119913, &quot;1586249300&quot;: 213.45243650423305 }</para>
            /// </summary>
            [NameInMap("dps")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("integrity")]
            [Validation(Required=false)]
            public float? Integrity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1522127381471</para>
            /// </summary>
            [NameInMap("messageWatermark")]
            [Validation(Required=false)]
            public long? MessageWatermark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>elasticbuild.elasticsearch.source.total_doc_count</para>
            /// </summary>
            [NameInMap("metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public float? Summary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;taskName&quot;:&quot;et-xxx&quot;,&quot;userId&quot;:&quot;123456&quot;}</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
