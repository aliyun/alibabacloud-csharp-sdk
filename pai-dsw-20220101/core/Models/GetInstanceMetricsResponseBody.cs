// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetInstanceMetricsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
                public long? Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            [NameInMap("PodId")]
            [Validation(Required=false)]
            public string PodId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}