// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DescribeApplicationScalingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The auto scaling policies of the application.</para>
        /// </summary>
        [NameInMap("AppScalingRules")]
        [Validation(Required=false)]
        public DescribeApplicationScalingRulesResponseBodyAppScalingRules AppScalingRules { get; set; }
        public class DescribeApplicationScalingRulesResponseBodyAppScalingRules : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of auto scaling policies returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The information about auto scaling policies.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResult> Result { get; set; }
            public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResult : TeaModel {
                /// <summary>
                /// <para>The ID of the application to which the auto scaling policy belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>78194c76-3dca-418e-a263-cccd1ab4****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("Behaviour")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviour Behaviour { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviour : TeaModel {
                    [NameInMap("ScaleDown")]
                    [Validation(Required=false)]
                    public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleDown ScaleDown { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleDown : TeaModel {
                        [NameInMap("Policies")]
                        [Validation(Required=false)]
                        public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleDownPolicies> Policies { get; set; }
                        public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleDownPolicies : TeaModel {
                            [NameInMap("PeriodSeconds")]
                            [Validation(Required=false)]
                            public int? PeriodSeconds { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("SelectPolicy")]
                        [Validation(Required=false)]
                        public string SelectPolicy { get; set; }

                        [NameInMap("StabilizationWindowSeconds")]
                        [Validation(Required=false)]
                        public int? StabilizationWindowSeconds { get; set; }

                    }

                    [NameInMap("ScaleUp")]
                    [Validation(Required=false)]
                    public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleUp ScaleUp { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleUp : TeaModel {
                        [NameInMap("Policies")]
                        [Validation(Required=false)]
                        public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleUpPolicies> Policies { get; set; }
                        public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultBehaviourScaleUpPolicies : TeaModel {
                            [NameInMap("PeriodSeconds")]
                            [Validation(Required=false)]
                            public int? PeriodSeconds { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("SelectPolicy")]
                        [Validation(Required=false)]
                        public string SelectPolicy { get; set; }

                        [NameInMap("StabilizationWindowSeconds")]
                        [Validation(Required=false)]
                        public int? StabilizationWindowSeconds { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the auto scaling policy was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23212323123</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the auto scaling policy was last disabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
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
                /// <para>Indicates whether the auto scaling policy is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The auto scaling policy is enabled.</description></item>
                /// <item><description><b>false</b>: The auto scaling policy is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ScaleRuleEnabled")]
                [Validation(Required=false)]
                public bool? ScaleRuleEnabled { get; set; }

                /// <summary>
                /// <para>The name of the auto scaling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu-trigger</para>
                /// </summary>
                [NameInMap("ScaleRuleName")]
                [Validation(Required=false)]
                public string ScaleRuleName { get; set; }

                /// <summary>
                /// <para>The type of the auto scaling policy. The value is fixed to trigger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trigger</para>
                /// </summary>
                [NameInMap("ScaleRuleType")]
                [Validation(Required=false)]
                public string ScaleRuleType { get; set; }

                /// <summary>
                /// <para>The configurations of the trigger.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTrigger Trigger { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTrigger : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of replicas. The upper limit is 1000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>122</para>
                    /// </summary>
                    [NameInMap("MaxReplicas")]
                    [Validation(Required=false)]
                    public int? MaxReplicas { get; set; }

                    /// <summary>
                    /// <para>The minimum number of replicas. The lower limit is 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinReplicas")]
                    [Validation(Required=false)]
                    public int? MinReplicas { get; set; }

                    /// <summary>
                    /// <para>The configurations of the trigger.</para>
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
                /// <para>The time when the auto scaling policy was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23212323123</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The total number of auto scaling policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message that is returned.</para>
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
