// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListDashboardDetailsFlowsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InternalServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>An internal server error occurred</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public ListDashboardDetailsFlowsResponseBodyResult Result { get; set; }
        public class ListDashboardDetailsFlowsResponseBodyResult : TeaModel {
            [NameInMap("metricData")]
            [Validation(Required=false)]
            public List<ListDashboardDetailsFlowsResponseBodyResultMetricData> MetricData { get; set; }
            public class ListDashboardDetailsFlowsResponseBodyResultMetricData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("metricRes")]
                [Validation(Required=false)]
                public Dictionary<string, object> MetricRes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("sceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("traceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USERACTIONUV_COUNT</para>
            /// </summary>
            [NameInMap("metricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

        }

    }

}
