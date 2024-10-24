// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class GetInstanceMetricsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eais-bj8b53it29hfhj******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PodMetrics")]
        [Validation(Required=false)]
        public List<GetInstanceMetricsResponseBodyPodMetrics> PodMetrics { get; set; }
        public class GetInstanceMetricsResponseBodyPodMetrics : TeaModel {
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<GetInstanceMetricsResponseBodyPodMetricsMetrics> Metrics { get; set; }
            public class GetInstanceMetricsResponseBodyPodMetricsMetrics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1669107528450</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4.536552540058814</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Pod ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>eais-hznzre6ffmz9num4****-579b587ddf-9txr6</para>
            /// </summary>
            [NameInMap("PodId")]
            [Validation(Required=false)]
            public string PodId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
