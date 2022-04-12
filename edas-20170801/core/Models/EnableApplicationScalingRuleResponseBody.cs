// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class EnableApplicationScalingRuleResponseBody : TeaModel {
        [NameInMap("AppScalingRule")]
        [Validation(Required=false)]
        public EnableApplicationScalingRuleResponseBodyAppScalingRule AppScalingRule { get; set; }
        public class EnableApplicationScalingRuleResponseBodyAppScalingRule : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("LastDisableTime")]
            [Validation(Required=false)]
            public long? LastDisableTime { get; set; }
            [NameInMap("MaxReplicas")]
            [Validation(Required=false)]
            public int? MaxReplicas { get; set; }
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public EnableApplicationScalingRuleResponseBodyAppScalingRuleMetric Metric { get; set; }
            public class EnableApplicationScalingRuleResponseBodyAppScalingRuleMetric : TeaModel {
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<EnableApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics> Metrics { get; set; }
                public class EnableApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics : TeaModel {
                    [NameInMap("MetricTargetAverageUtilization")]
                    [Validation(Required=false)]
                    public int? MetricTargetAverageUtilization { get; set; }

                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                }

                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

            }
            [NameInMap("MinReplicas")]
            [Validation(Required=false)]
            public int? MinReplicas { get; set; }
            [NameInMap("ScaleRuleEnabled")]
            [Validation(Required=false)]
            public bool? ScaleRuleEnabled { get; set; }
            [NameInMap("ScaleRuleName")]
            [Validation(Required=false)]
            public string ScaleRuleName { get; set; }
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public EnableApplicationScalingRuleResponseBodyAppScalingRuleTrigger Trigger { get; set; }
            public class EnableApplicationScalingRuleResponseBodyAppScalingRuleTrigger : TeaModel {
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<EnableApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers> Triggers { get; set; }
                public class EnableApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers : TeaModel {
                    [NameInMap("MetaData")]
                    [Validation(Required=false)]
                    public string MetaData { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
