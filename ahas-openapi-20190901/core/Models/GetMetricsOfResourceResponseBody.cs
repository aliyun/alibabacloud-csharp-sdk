// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class GetMetricsOfResourceResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetricsOfResourceResponseBodyData Data { get; set; }
        public class GetMetricsOfResourceResponseBodyData : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("InnerMetrics")]
            [Validation(Required=false)]
            public List<GetMetricsOfResourceResponseBodyDataInnerMetrics> InnerMetrics { get; set; }
            public class GetMetricsOfResourceResponseBodyDataInnerMetrics : TeaModel {
                public float? RtP99 { get; set; }
                public float? SuccessQpsAvg { get; set; }
                public float? PassedQpsP99 { get; set; }
                public float? RtAvg { get; set; }
                public int? Count { get; set; }
                public float? ThreadStd { get; set; }
                public float? PassedQpsAvg { get; set; }
                public float? ExceptionP95 { get; set; }
                public float? SuccessQpsMax { get; set; }
                public float? RtP95 { get; set; }
                public float? BlockedQpsMin { get; set; }
                public float? BlockedQps { get; set; }
                public long? Timestamp { get; set; }
                public float? ThreadP95 { get; set; }
                public float? RtStd { get; set; }
                public float? PassedQpsMin { get; set; }
                public float? BlockedQpsP99 { get; set; }
                public float? PassedQpsMax { get; set; }
                public float? ExceptionMax { get; set; }
                public float? SuccessQps { get; set; }
                public float? SuccessQpsP75 { get; set; }
                public float? ThreadP75 { get; set; }
                public float? SuccessQpsStd { get; set; }
                public float? ExceptionMin { get; set; }
                public float? PassedQpsP75 { get; set; }
                public float? PassedQps { get; set; }
                public float? ThreadMax { get; set; }
                public float? SuccessQpsP99 { get; set; }
                public float? SuccessQpsMin { get; set; }
                public float? ThreadP99 { get; set; }
                public float? ExceptionStd { get; set; }
                public float? BlockedQpsP95 { get; set; }
                public float? Thread { get; set; }
                public float? ThreadMin { get; set; }
                public float? RtMin { get; set; }
                public float? BlockedQpsAvg { get; set; }
                public float? ThreadAvg { get; set; }
                public float? BlockedQpsP75 { get; set; }
                public float? RtP75 { get; set; }
                public float? ExceptionP99 { get; set; }
                public float? ExceptionP75 { get; set; }
                public float? SuccessQpsP95 { get; set; }
                public float? Rt { get; set; }
                public float? PassedQpsP95 { get; set; }
                public float? RtMax { get; set; }
                public float? BlockedQpsStd { get; set; }
                public float? BlockedQpsMax { get; set; }
                public float? Exception { get; set; }
                public float? ExceptionAvg { get; set; }
                public float? PassedQpsStd { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
