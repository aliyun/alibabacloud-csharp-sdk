// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class GetInstanceMetricsResponseBody : TeaModel {
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
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Pod ID。
            /// </summary>
            [NameInMap("PodId")]
            [Validation(Required=false)]
            public string PodId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
