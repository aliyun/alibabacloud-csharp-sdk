// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// The information about the auto scaling policy.
        /// </summary>
        [NameInMap("AppScalingRule")]
        [Validation(Required=false)]
        public UpdateApplicationScalingRuleResponseBodyAppScalingRule AppScalingRule { get; set; }
        public class UpdateApplicationScalingRuleResponseBodyAppScalingRule : TeaModel {
            /// <summary>
            /// The ID of the application to which the auto scaling policy belongs.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("Behaviour")]
            [Validation(Required=false)]
            public UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviour Behaviour { get; set; }
            public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviour : TeaModel {
                [NameInMap("ScaleDown")]
                [Validation(Required=false)]
                public UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDown ScaleDown { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDown : TeaModel {
                    /// <summary>
                    /// The configuration of the policy.
                    /// </summary>
                    [NameInMap("Policies")]
                    [Validation(Required=false)]
                    public List<UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDownPolicies> Policies { get; set; }
                    public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDownPolicies : TeaModel {
                        /// <summary>
                        /// The cycle of the policy check. Valid values: 0 to 1800. Unit: seconds.
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public int? PeriodSeconds { get; set; }

                        /// <summary>
                        /// The type of the policy. Valid values: Pods and Percent.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// The policy value of auto scaling. Set the value to an integer greater than zero. If the policy type is Pods, the value of this parameter indicates the number of pods. If the policy type is Percent, the value of this parameter indicates a percentage, which can exceed 100%.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The step size policy for the scale-in. Valid values: Max, Min, and Disable.
                    /// </summary>
                    [NameInMap("SelectPolicy")]
                    [Validation(Required=false)]
                    public string SelectPolicy { get; set; }

                    /// <summary>
                    /// The cooldown time of the scale-in. Valid values: 0 to 3600. Unit: seconds. Default value: 300.
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public int? StabilizationWindowSeconds { get; set; }

                }

                [NameInMap("ScaleUp")]
                [Validation(Required=false)]
                public UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUp ScaleUp { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUp : TeaModel {
                    /// <summary>
                    /// The configuration of the policy.
                    /// </summary>
                    [NameInMap("Policies")]
                    [Validation(Required=false)]
                    public List<UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUpPolicies> Policies { get; set; }
                    public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUpPolicies : TeaModel {
                        /// <summary>
                        /// The cycle of the policy check. Valid values: 0 to 1800. Unit: seconds.
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public int? PeriodSeconds { get; set; }

                        /// <summary>
                        /// The type of the policy. Valid values: Pods and Percent.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// The policy value of auto scaling. Set the value to an integer greater than zero. If the policy type is Pods, the value of this parameter indicates the number of pods. If the policy type is Percent, the value of this parameter indicates a percentage, which can exceed 100%.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The step size policy for the scale-out. Valid values: Max, Min, and Disable.
                    /// </summary>
                    [NameInMap("SelectPolicy")]
                    [Validation(Required=false)]
                    public string SelectPolicy { get; set; }

                    /// <summary>
                    /// The cooldown time of the scale-out. Valid values: 0 to 3600. Unit: seconds. Default value: 0.
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public int? StabilizationWindowSeconds { get; set; }

                }

            }

            /// <summary>
            /// The time when the auto scaling policy was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The time when the auto scaling policy was last disabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
            public UpdateApplicationScalingRuleResponseBodyAppScalingRuleMetric Metric { get; set; }
            public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleMetric : TeaModel {
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
                public List<UpdateApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics> Metrics { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics : TeaModel {
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
            public UpdateApplicationScalingRuleResponseBodyAppScalingRuleTrigger Trigger { get; set; }
            public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleTrigger : TeaModel {
                /// <summary>
                /// The maximum number of replicas. The maximum value is 1000.
                /// </summary>
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// The minimum number of replicas. The minimum value is 0.
                /// </summary>
                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

                /// <summary>
                /// The configurations of the trigger.
                /// </summary>
                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<UpdateApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers> Triggers { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers : TeaModel {
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
            /// The time when the auto scaling policy was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The message that is returned.
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
