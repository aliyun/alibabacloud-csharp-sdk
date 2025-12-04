// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class ListAutoScalingRulesResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAutoScalingRulesResponseBodyData Data { get; set; }
        public class ListAutoScalingRulesResponseBodyData : TeaModel {
            [NameInMap("ScaleRules")]
            [Validation(Required=false)]
            public List<ListAutoScalingRulesResponseBodyDataScaleRules> ScaleRules { get; set; }
            public class ListAutoScalingRulesResponseBodyDataScaleRules : TeaModel {
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("ObservationWindow")]
                [Validation(Required=false)]
                public int? ObservationWindow { get; set; }

                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                [NameInMap("ScaleInStep")]
                [Validation(Required=false)]
                public int? ScaleInStep { get; set; }

                [NameInMap("ScaleOutStep")]
                [Validation(Required=false)]
                public int? ScaleOutStep { get; set; }

                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public int? SilenceTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("TargetMetric")]
                [Validation(Required=false)]
                public string TargetMetric { get; set; }

                [NameInMap("TargetNodes")]
                [Validation(Required=false)]
                public int? TargetNodes { get; set; }

                [NameInMap("ThresholdLower")]
                [Validation(Required=false)]
                public int? ThresholdLower { get; set; }

                [NameInMap("ThresholdUpper")]
                [Validation(Required=false)]
                public int? ThresholdUpper { get; set; }

                [NameInMap("TriggerCronExpr")]
                [Validation(Required=false)]
                public string TriggerCronExpr { get; set; }

            }

        }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

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
