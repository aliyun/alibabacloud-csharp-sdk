// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListDashboardMetricsFlowsResponseBody : TeaModel {
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

        /// <summary>
        /// <para>The ID of the request.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDashboardMetricsFlowsResponseBodyResult> Result { get; set; }
        public class ListDashboardMetricsFlowsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para><b>null</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("metricData")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetricData { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("metricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

        }

    }

}
