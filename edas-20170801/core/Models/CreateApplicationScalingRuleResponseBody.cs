// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class CreateApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// The information about the auto scaling policy.
        /// </summary>
        [NameInMap("AppScalingRule")]
        [Validation(Required=false)]
        public CreateApplicationScalingRuleResponseBodyAppScalingRule AppScalingRule { get; set; }
        public class CreateApplicationScalingRuleResponseBodyAppScalingRule : TeaModel {
            /// <summary>
            /// The ID of the application to which the auto scaling policy belongs.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("Behaviour")]
            [Validation(Required=false)]
            public CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviour Behaviour { get; set; }
            public class CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviour : TeaModel {
                /// <summary>
                /// 弹性缩容行为配置。
                /// </summary>
                [NameInMap("ScaleDown")]
                [Validation(Required=false)]
                public CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDown ScaleDown { get; set; }
                public class CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDown : TeaModel {
                    /// <summary>
                    /// 策略配置。
                    /// </summary>
                    [NameInMap("Policies")]
                    [Validation(Required=false)]
                    public List<CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDownPolicies> Policies { get; set; }
                    public class CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDownPolicies : TeaModel {
                        /// <summary>
                        /// 检查执行的周期，取值范围[0, 1800]，单位为秒。
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public int? PeriodSeconds { get; set; }

                        /// <summary>
                        /// 策略类型，可为Pods或Percent。
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// 弹性行为的策略值，大于零的整数。若策略类型为Pods，则该值表示Pods数量；若策略类型为Percent，则该值表示百分比，允许超过100%。
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// 弹性缩容步长策略，可选值Max、Min、Disable。
                    /// </summary>
                    [NameInMap("SelectPolicy")]
                    [Validation(Required=false)]
                    public string SelectPolicy { get; set; }

                    /// <summary>
                    /// 缩容冷却时间。取值范围[0, 3600]，单位为秒。默认为300秒。
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public int? StabilizationWindowSeconds { get; set; }

                }

                /// <summary>
                /// 弹性扩容行为配置。
                /// </summary>
                [NameInMap("ScaleUp")]
                [Validation(Required=false)]
                public CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUp ScaleUp { get; set; }
                public class CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUp : TeaModel {
                    /// <summary>
                    /// 策略配置。
                    /// </summary>
                    [NameInMap("Policies")]
                    [Validation(Required=false)]
                    public List<CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUpPolicies> Policies { get; set; }
                    public class CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUpPolicies : TeaModel {
                        /// <summary>
                        /// 检查执行的周期，取值范围[0, 1800]，单位为秒。
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public int? PeriodSeconds { get; set; }

                        /// <summary>
                        /// 策略类型，可为Pods或Percent。
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// 弹性行为的策略值，大于零的整数。若策略类型为Pods，则该值表示Pods数量；若策略类型为Percent，则该值表示百分比，允许超过100%。
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// 弹性扩容步长策略，可选值Max、Min、Disable。
                    /// </summary>
                    [NameInMap("SelectPolicy")]
                    [Validation(Required=false)]
                    public string SelectPolicy { get; set; }

                    /// <summary>
                    /// 扩容冷却时间。取值范围[0, 3600]，单位为秒。默认为0秒。
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public int? StabilizationWindowSeconds { get; set; }

                }

            }

            /// <summary>
            /// The timestamp when the auto scaling policy was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The timestamp when the auto scaling policy was last disabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
            public CreateApplicationScalingRuleResponseBodyAppScalingRuleMetric Metric { get; set; }
            public class CreateApplicationScalingRuleResponseBodyAppScalingRuleMetric : TeaModel {
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
                public List<CreateApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics> Metrics { get; set; }
                public class CreateApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics : TeaModel {
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
            /// The type of the auto scaling policy. The value is trigger.
            /// </summary>
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }

            /// <summary>
            /// The configurations of the trigger.
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public CreateApplicationScalingRuleResponseBodyAppScalingRuleTrigger Trigger { get; set; }
            public class CreateApplicationScalingRuleResponseBodyAppScalingRuleTrigger : TeaModel {
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
                /// The list of triggers.
                /// </summary>
                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<CreateApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers> Triggers { get; set; }
                public class CreateApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers : TeaModel {
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
            /// The timestamp when the auto scaling policy was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
