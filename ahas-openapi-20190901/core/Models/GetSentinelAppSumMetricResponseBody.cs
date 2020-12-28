// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class GetSentinelAppSumMetricResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("MetricData")]
        [Validation(Required=false)]
        public GetSentinelAppSumMetricResponseBodyMetricData MetricData { get; set; }
        public class GetSentinelAppSumMetricResponseBodyMetricData : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public float? PassCount { get; set; }
            [NameInMap("MachineCount")]
            [Validation(Required=false)]
            public long? MachineCount { get; set; }
            [NameInMap("AvgRt")]
            [Validation(Required=false)]
            public float? AvgRt { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public float? TotalCount { get; set; }
            [NameInMap("BlockCount")]
            [Validation(Required=false)]
            public float? BlockCount { get; set; }
        };

    }

}
