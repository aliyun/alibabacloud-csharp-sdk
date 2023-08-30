// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListFlowRulesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFlowRulesResponseBodyData Data { get; set; }
        public class ListFlowRulesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListFlowRulesResponseBodyDataResult> Result { get; set; }
            public class ListFlowRulesResponseBodyDataResult : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("ControlBehavior")]
                [Validation(Required=false)]
                public int? ControlBehavior { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("FallbackObject")]
                [Validation(Required=false)]
                public string FallbackObject { get; set; }

                [NameInMap("MaxQueueingTimeMs")]
                [Validation(Required=false)]
                public int? MaxQueueingTimeMs { get; set; }

                [NameInMap("MetricType")]
                [Validation(Required=false)]
                public int? MetricType { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

                [NameInMap("TrafficTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> TrafficTags { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
