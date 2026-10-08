// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class CreateApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The Auto Scaling rule.</para>
        /// </summary>
        [NameInMap("AppScalingRule")]
        [Validation(Required=false)]
        public CreateApplicationScalingRuleResponseBodyAppScalingRule AppScalingRule { get; set; }
        public class CreateApplicationScalingRuleResponseBodyAppScalingRule : TeaModel {
            /// <summary>
            /// <para>The ID of the application for the Auto Scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78194c76-3dca-418e-a263-cccd1ab4****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The scaling behavior.</para>
            /// </summary>
            [NameInMap("Behaviour")]
            [Validation(Required=false)]
            public CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviour Behaviour { get; set; }
            public class CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviour : TeaModel {
                /// <summary>
                /// <para>The configuration of the scale-in behavior.</para>
                /// </summary>
                [NameInMap("ScaleDown")]
                [Validation(Required=false)]
                public CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDown ScaleDown { get; set; }
                public class CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDown : TeaModel {
                    /// <summary>
                    /// <para>The policy configuration.</para>
                    /// </summary>
                    [NameInMap("Policies")]
                    [Validation(Required=false)]
                    public List<CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDownPolicies> Policies { get; set; }
                    public class CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleDownPolicies : TeaModel {
                        /// <summary>
                        /// <para>The period in which the policy is checked for execution. Unit: seconds. Valid values: 0 to 1800.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>15</para>
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public int? PeriodSeconds { get; set; }

                        /// <summary>
                        /// <para>The type of the policy. Valid values: Pods and Percent.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Pods</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The value for the scaling behavior policy. This must be an integer greater than 0. If the policy type is Pods, the value specifies the number of pods. If the policy type is Percent, the value specifies a percentage, which can exceed 100%.</para>
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
                    /// <para>The cooldown period for scale-in events. Unit: seconds. Valid values: 0 to 3600. Default value: 300.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public int? StabilizationWindowSeconds { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the scale-out behavior.</para>
                /// </summary>
                [NameInMap("ScaleUp")]
                [Validation(Required=false)]
                public CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUp ScaleUp { get; set; }
                public class CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUp : TeaModel {
                    /// <summary>
                    /// <para>The policy configuration.</para>
                    /// </summary>
                    [NameInMap("Policies")]
                    [Validation(Required=false)]
                    public List<CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUpPolicies> Policies { get; set; }
                    public class CreateApplicationScalingRuleResponseBodyAppScalingRuleBehaviourScaleUpPolicies : TeaModel {
                        /// <summary>
                        /// <para>The period in which the policy is checked for execution. Unit: seconds. Valid values: 0 to 1800.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>15</para>
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public int? PeriodSeconds { get; set; }

                        /// <summary>
                        /// <para>The type of the policy. Valid values: Pods and Percent.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Pods</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The value for the scaling behavior policy. This must be an integer greater than 0. If the policy type is Pods, the value specifies the number of pods. If the policy type is Percent, the value specifies a percentage, which can exceed 100%.</para>
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
                    /// <para>The cooldown period for scale-out events. Unit: seconds. Valid values: 0 to 3600. Default value: 0.</para>
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
            /// <para>The UNIX timestamp when the Auto Scaling rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23212323123</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp when the Auto Scaling rule was last disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23212323123</para>
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
            public CreateApplicationScalingRuleResponseBodyAppScalingRuleMetric Metric { get; set; }
            public class CreateApplicationScalingRuleResponseBodyAppScalingRuleMetric : TeaModel {
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
                public List<CreateApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics> Metrics { get; set; }
                public class CreateApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics : TeaModel {
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
            /// <para>The state of the Auto Scaling rule.</para>
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
            /// <para>The name of the Auto Scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu</para>
            /// </summary>
            [NameInMap("ScaleRuleName")]
            [Validation(Required=false)]
            public string ScaleRuleName { get; set; }

            /// <summary>
            /// <para>The type of the rule. Only trigger is supported.</para>
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
            public CreateApplicationScalingRuleResponseBodyAppScalingRuleTrigger Trigger { get; set; }
            public class CreateApplicationScalingRuleResponseBodyAppScalingRuleTrigger : TeaModel {
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
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

                /// <summary>
                /// <para>A list of triggers.</para>
                /// </summary>
                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<CreateApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers> Triggers { get; set; }
                public class CreateApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers : TeaModel {
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
                    /// <para>The type of the trigger. Valid values: cron and app_metric.</para>
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
            /// <para>The UNIX timestamp when the Auto Scaling rule was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23212323123</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a5281053-08e4-47a5-b2ab-5c0323de7b5a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
