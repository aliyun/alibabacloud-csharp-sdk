// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DescribeApplicationScalingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The Auto Scaling rules for the application.</para>
        /// </summary>
        [NameInMap("AppScalingRules")]
        [Validation(Required=false)]
        public DescribeApplicationScalingRulesResponseBodyAppScalingRules AppScalingRules { get; set; }
        public class DescribeApplicationScalingRulesResponseBodyAppScalingRules : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of scaling rules returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The details of the Auto Scaling rules.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResult> Result { get; set; }
            public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResult : TeaModel {
                /// <summary>
                /// <para>The ID of the application to which the scaling rule belongs.</para>
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
                public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviour Behaviour { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviour : TeaModel {
                    /// <summary>
                    /// <para>The configuration of the scale-in behavior.</para>
                    /// </summary>
                    [NameInMap("ScaleDown")]
                    [Validation(Required=false)]
                    public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleDown ScaleDown { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleDown : TeaModel {
                        /// <summary>
                        /// <para>The policy configuration.</para>
                        /// </summary>
                        [NameInMap("Policies")]
                        [Validation(Required=false)]
                        public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleDownPolicies> Policies { get; set; }
                        public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleDownPolicies : TeaModel {
                            /// <summary>
                            /// <para>The execution interval. Unit: seconds. Valid values: 0 to 1800.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>15</para>
                            /// </summary>
                            [NameInMap("PeriodSeconds")]
                            [Validation(Required=false)]
                            public int? PeriodSeconds { get; set; }

                            /// <summary>
                            /// <para>The type of the policy. Valid values: \<c>Pods\\</c> and \<c>Percent\\</c>.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Pods</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>The value for the policy. The value must be an integer greater than 0. If \<c>Type\\</c> is \<c>Pods\\</c>, this parameter specifies the number of pods. If \<c>Type\\</c> is \<c>Percent\\</c>, this parameter specifies a percentage. The value can be greater than 100%.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The policy for the scaling step size for scale-in events. Valid values: \<c>Max\\</c>, \<c>Min\\</c>, and \<c>Disable\\</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Max</para>
                        /// </summary>
                        [NameInMap("SelectPolicy")]
                        [Validation(Required=false)]
                        public string SelectPolicy { get; set; }

                        /// <summary>
                        /// <para>The cooldown period for a scale-in event. Unit: seconds. Valid values: 0 to 3600. Default value: 300.</para>
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
                    public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleUp ScaleUp { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleUp : TeaModel {
                        /// <summary>
                        /// <para>The policy configuration.</para>
                        /// </summary>
                        [NameInMap("Policies")]
                        [Validation(Required=false)]
                        public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleUpPolicies> Policies { get; set; }
                        public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleUpPolicies : TeaModel {
                            /// <summary>
                            /// <para>The execution interval. Unit: seconds. Valid values: 0 to 1800.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>15</para>
                            /// </summary>
                            [NameInMap("PeriodSeconds")]
                            [Validation(Required=false)]
                            public int? PeriodSeconds { get; set; }

                            /// <summary>
                            /// <para>The type of the policy. Valid values: \<c>Pods\\</c> and \<c>Percent\\</c>.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Pods</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>The value for the policy. The value must be an integer greater than 0. If \<c>Type\\</c> is \<c>Pods\\</c>, this parameter specifies the number of pods. If \<c>Type\\</c> is \<c>Percent\\</c>, this parameter specifies a percentage. The value can be greater than 100%.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The policy for the scaling step size for scale-out events. Valid values: \<c>Max\\</c>, \<c>Min\\</c>, and \<c>Disable\\</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Max</para>
                        /// </summary>
                        [NameInMap("SelectPolicy")]
                        [Validation(Required=false)]
                        public string SelectPolicy { get; set; }

                        /// <summary>
                        /// <para>The cooldown period for a scale-out event. Unit: seconds. Valid values: 0 to 3600. Default value: 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>15</para>
                        /// </summary>
                        [NameInMap("StabilizationWindowSeconds")]
                        [Validation(Required=false)]
                        public int? StabilizationWindowSeconds { get; set; }

                    }

                }

                /// <summary>
                /// <para>The UNIX timestamp when the scaling rule was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23212323123</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp when the scaling rule was last disabled.</para>
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
                public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetric Metric { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetric : TeaModel {
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
                    public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetricMetrics> Metrics { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetricMetrics : TeaModel {
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
                        /// <para>asd</para>
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
                /// <para>Indicates whether the scaling rule is enabled.</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The scaling rule is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The scaling rule is disabled.</para>
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
                /// <para>The name of the scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu-trigger</para>
                /// </summary>
                [NameInMap("ScaleRuleName")]
                [Validation(Required=false)]
                public string ScaleRuleName { get; set; }

                /// <summary>
                /// <para>The type of the scaling rule. Only \<c>trigger\\</c> is supported.</para>
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
                public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTrigger Trigger { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTrigger : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of replicas. The value cannot exceed 1000.</para>
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
                    /// <para>A list of trigger configurations.</para>
                    /// </summary>
                    [NameInMap("Triggers")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTriggerTriggers> Triggers { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTriggerTriggers : TeaModel {
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
                        /// <para>cron-trigger</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The type of the trigger. Valid values: \<c>cron\\</c> and \<c>app_metric\\</c>.</para>
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
                /// <para>The UNIX timestamp when the scaling rule was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23212323123</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The total number of scaling rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

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
