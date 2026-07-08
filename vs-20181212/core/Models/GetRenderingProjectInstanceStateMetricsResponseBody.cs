// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class GetRenderingProjectInstanceStateMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of project instance state statistics</para>
        /// </summary>
        [NameInMap("StateMetrics")]
        [Validation(Required=false)]
        public List<GetRenderingProjectInstanceStateMetricsResponseBodyStateMetrics> StateMetrics { get; set; }
        public class GetRenderingProjectInstanceStateMetricsResponseBodyStateMetrics : TeaModel {
            /// <summary>
            /// <para>Number of instances</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <para>Project instance state</para>
            /// 
            /// <b>Example:</b>
            /// <para>Idle</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
