// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class EnableFlowRuleResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EnableFlowRuleResponseBodyData Data { get; set; }
        public class EnableFlowRuleResponseBodyData : TeaModel {
            [NameInMap("RefResource")]
            [Validation(Required=false)]
            public string RefResource { get; set; }
            [NameInMap("ClusterFallbackThreshold")]
            [Validation(Required=false)]
            public int? ClusterFallbackThreshold { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("LimitOrigin")]
            [Validation(Required=false)]
            public string LimitOrigin { get; set; }
            [NameInMap("StatDurationMs")]
            [Validation(Required=false)]
            public int? StatDurationMs { get; set; }
            [NameInMap("ClusterThresholdType")]
            [Validation(Required=false)]
            public int? ClusterThresholdType { get; set; }
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }
            [NameInMap("RelationStrategy")]
            [Validation(Required=false)]
            public int? RelationStrategy { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }
            [NameInMap("MaxQueueingTimeMs")]
            [Validation(Required=false)]
            public int? MaxQueueingTimeMs { get; set; }
            [NameInMap("ClusterEstimatedMaxQps")]
            [Validation(Required=false)]
            public float? ClusterEstimatedMaxQps { get; set; }
            [NameInMap("ControlBehavior")]
            [Validation(Required=false)]
            public int? ControlBehavior { get; set; }
            [NameInMap("WarmUpPeriodSec")]
            [Validation(Required=false)]
            public int? WarmUpPeriodSec { get; set; }
            [NameInMap("ClusterFallbackStrategy")]
            [Validation(Required=false)]
            public int? ClusterFallbackStrategy { get; set; }
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }
            [NameInMap("ClusterMode")]
            [Validation(Required=false)]
            public bool? ClusterMode { get; set; }
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
