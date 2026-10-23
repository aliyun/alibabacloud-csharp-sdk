// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetEmonMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D184B55-FA51-43F7-A1EF-E68A0545****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetEmonMonitorDataResponseBodyResult> Result { get; set; }
        public class GetEmonMonitorDataResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The real-time metric monitoring data. The format is <c>{timestamp:data}</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;1586249280&quot;: 465.1980465119913, &quot;1586249300&quot;: 213.45243650423305 }</para>
            /// </summary>
            [NameInMap("dps")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dps { get; set; }

            /// <summary>
            /// <para>The completeness of the time series curve data points in the result returned by the metric query. A value of 1.0 indicates 100% completeness.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("integrity")]
            [Validation(Required=false)]
            public float? Integrity { get; set; }

            /// <summary>
            /// <para>The timestamp when the request reaches the server. This parameter is used for troubleshooting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1522127381471</para>
            /// </summary>
            [NameInMap("messageWatermark")]
            [Validation(Required=false)]
            public long? MessageWatermark { get; set; }

            /// <summary>
            /// <para>The metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>elasticbuild.elasticsearch.source.total_doc_count</para>
            /// </summary>
            [NameInMap("metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <para>If the queries contain wildcards, the result includes multiple matched time series data records. The summary is the aggregation of the value sets of these time series at each time point based on the aggregator type provided in the query. Currently, only the avg aggregation method is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public float? Summary { get; set; }

            /// <summary>
            /// <para>The query tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;taskName&quot;:&quot;et-xxx&quot;,&quot;userId&quot;:&quot;123456&quot;}</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Unsuccessful.</description></item>
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
