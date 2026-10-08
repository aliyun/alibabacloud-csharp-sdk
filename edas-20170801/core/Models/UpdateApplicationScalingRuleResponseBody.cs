// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The Auto Scaling policy.</para>
        /// </summary>
        [NameInMap("AppScalingRule")]
        [Validation(Required=false)]
        public UpdateApplicationScalingRuleResponseBodyAppScalingRule AppScalingRule { get; set; }
        public class UpdateApplicationScalingRuleResponseBodyAppScalingRule : TeaModel {
            /// <summary>
            /// <para>The ID of the application to which the Auto Scaling policy belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78194c76-3dca-418e-a263-cccd1ab4****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The scaling behavior configuration.</para>
            /// </summary>
            [NameInMap("Behaviour")]
            [Validation(Required=false)]
            public UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviour Behaviour { get; set; }
            public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviour : TeaModel {
                /// <summary>
                /// <para>The scale-in behavior configuration.</para>
                /// </summary>
                [NameInMap("ScaleDown")]
                [Validation(Required=false)]
                public UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDown ScaleDown { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDown : TeaModel {
                    /// <summary>
                    /// <para>The policy configurations.</para>
                    /// </summary>
                    [NameInMap("Policies")]
                    [Validation(Required=false)]
                    public List<UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDownPolicies> Policies { get; set; }
                    public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDownPolicies : TeaModel {
                        /// <summary>
                        /// <para>The check period. Valid values: 0 to 1,800. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>15</para>
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public int? PeriodSeconds { get; set; }

                        /// <summary>
                        /// <para>The policy type. Valid values: Pods and Percent.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Pods</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The value of the policy for the scaling behavior. The value must be an integer greater than 0. If the policy type is Pods, the value indicates the number of pods. If the policy type is Percent, the value indicates a percentage, which can exceed 100%.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The policy for the scale-in step size. Valid values: Max, Min, and Disable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Max</para>
                    /// </summary>
                    [NameInMap("SelectPolicy")]
                    [Validation(Required=false)]
                    public string SelectPolicy { get; set; }

                    /// <summary>
                    /// <para>The cooldown time for scale-ins. Valid values: 0 to 3,600. Unit: seconds. Default value: 300.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public int? StabilizationWindowSeconds { get; set; }

                }

                /// <summary>
                /// <para>The scale-out behavior configuration.</para>
                /// </summary>
                [NameInMap("ScaleUp")]
                [Validation(Required=false)]
                public UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUp ScaleUp { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUp : TeaModel {
                    /// <summary>
                    /// <para>The policy configurations.</para>
                    /// </summary>
                    [NameInMap("Policies")]
                    [Validation(Required=false)]
                    public List<UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUpPolicies> Policies { get; set; }
                    public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUpPolicies : TeaModel {
                        /// <summary>
                        /// <para>The check period. Valid values: 0 to 1,800. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>15</para>
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public int? PeriodSeconds { get; set; }

                        /// <summary>
                        /// <para>The policy type. Valid values: Pods and Percent.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Pods</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The value of the policy for the scaling behavior. The value must be an integer greater than 0. If the policy type is Pods, the value indicates the number of pods. If the policy type is Percent, the value indicates a percentage, which can exceed 100%.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The policy for the scale-out step size. Valid values: Max, Min, and Disable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Max</para>
                    /// </summary>
                    [NameInMap("SelectPolicy")]
                    [Validation(Required=false)]
                    public string SelectPolicy { get; set; }

                    /// <summary>
                    /// <para>The cooldown time for scale-outs. Valid values: 0 to 3,600. Unit: seconds. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public int? StabilizationWindowSeconds { get; set; }

                }

            }

            /// <summary>
            /// <para>The UNIX timestamp when the Auto Scaling policy was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1574251601785</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp when the Auto Scaling policy was last disabled. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1574251601785</para>
            /// </summary>
            [NameInMap("LastDisableTime")]
            [Validation(Required=false)]
            public long? LastDisableTime { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxReplicas")]
            [Validation(Required=false)]
            public int? MaxReplicas { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public UpdateApplicationScalingRuleResponseBodyAppScalingRuleMetric Metric { get; set; }
            public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleMetric : TeaModel {
                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<UpdateApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics> Metrics { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics : TeaModel {
                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MetricTargetAverageUtilization")]
                    [Validation(Required=false)]
                    public int? MetricTargetAverageUtilization { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cpu</para>
                    /// </summary>
                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                }

                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

            }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinReplicas")]
            [Validation(Required=false)]
            public int? MinReplicas { get; set; }

            /// <summary>
            /// <para>The status of the Auto Scaling policy.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ScaleRuleEnabled")]
            [Validation(Required=false)]
            public bool? ScaleRuleEnabled { get; set; }

            /// <summary>
            /// <para>The name of the Auto Scaling policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu-trigger</para>
            /// </summary>
            [NameInMap("ScaleRuleName")]
            [Validation(Required=false)]
            public string ScaleRuleName { get; set; }

            /// <summary>
            /// <para>The type of the Auto Scaling policy. Only the trigger type is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trigger</para>
            /// </summary>
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }

            /// <summary>
            /// <para>The trigger configuration.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public UpdateApplicationScalingRuleResponseBodyAppScalingRuleTrigger Trigger { get; set; }
            public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleTrigger : TeaModel {
                /// <summary>
                /// <para>The maximum number of replicas. The value cannot exceed 1,000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122</para>
                /// </summary>
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// <para>The minimum number of replicas. The value cannot be less than 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

                /// <summary>
                /// <para>The list of trigger configurations.</para>
                /// </summary>
                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<UpdateApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers> Triggers { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers : TeaModel {
                    /// <summary>
                    /// <para>The metadata of the trigger.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;dryRun&quot;:true}</para>
                    /// </summary>
                    [NameInMap("MetaData")]
                    [Validation(Required=false)]
                    public string MetaData { get; set; }

                    /// <summary>
                    /// <para>The name of the trigger.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cpu</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The trigger type. Only cron and app_metric are supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cron</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The UNIX timestamp when the Auto Scaling policy was updated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1574251601785</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a5281053-08e4-47a5-b2ab-5c0323de7b5a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
