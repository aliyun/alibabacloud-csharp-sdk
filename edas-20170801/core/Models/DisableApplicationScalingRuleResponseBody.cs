// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DisableApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// The information about the auto scaling policy.
        /// </summary>
        [NameInMap("AppScalingRule")]
        [Validation(Required=false)]
        public DisableApplicationScalingRuleResponseBodyAppScalingRule AppScalingRule { get; set; }
        public class DisableApplicationScalingRuleResponseBodyAppScalingRule : TeaModel {
            /// <summary>
            /// The ID of the application to which the auto scaling policy belongs.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The time when the auto scaling policy was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The time when the auto scaling policy was last disabled.
            /// </summary>
            [NameInMap("LastDisableTime")]
            [Validation(Required=false)]
            public long? LastDisableTime { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("MaxReplicas")]
            [Validation(Required=false)]
            public int? MaxReplicas { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public DisableApplicationScalingRuleResponseBodyAppScalingRuleMetric Metric { get; set; }
            public class DisableApplicationScalingRuleResponseBodyAppScalingRuleMetric : TeaModel {
                /// <summary>
                /// This parameter is deprecated.
                /// </summary>
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// This parameter is deprecated.
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<DisableApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics> Metrics { get; set; }
                public class DisableApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics : TeaModel {
                    /// <summary>
                    /// This parameter is deprecated.
                    /// </summary>
                    [NameInMap("MetricTargetAverageUtilization")]
                    [Validation(Required=false)]
                    public int? MetricTargetAverageUtilization { get; set; }

                    /// <summary>
                    /// This parameter is deprecated.
                    /// </summary>
                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                }

                /// <summary>
                /// This parameter is deprecated.
                /// </summary>
                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

            }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("MinReplicas")]
            [Validation(Required=false)]
            public int? MinReplicas { get; set; }

            /// <summary>
            /// Indicates whether the auto scaling policy is enabled. Valid values:
            /// 
            /// *   **true**: The auto scaling policy is enabled.
            /// *   **false**: The auto scaling policy is disabled.
            /// </summary>
            [NameInMap("ScaleRuleEnabled")]
            [Validation(Required=false)]
            public bool? ScaleRuleEnabled { get; set; }

            /// <summary>
            /// The name of the auto scaling policy.
            /// </summary>
            [NameInMap("ScaleRuleName")]
            [Validation(Required=false)]
            public string ScaleRuleName { get; set; }

            /// <summary>
            /// The type of the auto scaling policy. The value is fixed to trigger.
            /// </summary>
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }

            /// <summary>
            /// The configurations of the trigger.
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public DisableApplicationScalingRuleResponseBodyAppScalingRuleTrigger Trigger { get; set; }
            public class DisableApplicationScalingRuleResponseBodyAppScalingRuleTrigger : TeaModel {
                /// <summary>
                /// The maximum number of replicas. The upper limit is 1000.
                /// </summary>
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// The minimum number of replicas. The lower limit is 0.
                /// </summary>
                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

                /// <summary>
                /// The information about the trigger.
                /// </summary>
                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<DisableApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers> Triggers { get; set; }
                public class DisableApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers : TeaModel {
                    /// <summary>
                    /// The metadata of the trigger.
                    /// </summary>
                    [NameInMap("MetaData")]
                    [Validation(Required=false)]
                    public string MetaData { get; set; }

                    /// <summary>
                    /// The name of the trigger.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The type of the trigger. Valid values: cron and app_metric.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The time when the auto scaling policy was last modified.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
