// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DescribeApplicationScalingRulesResponseBody : TeaModel {
        /// <summary>
        /// The auto scaling policies of the application.
        /// </summary>
        [NameInMap("AppScalingRules")]
        [Validation(Required=false)]
        public DescribeApplicationScalingRulesResponseBodyAppScalingRules AppScalingRules { get; set; }
        public class DescribeApplicationScalingRulesResponseBodyAppScalingRules : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of auto scaling policies returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The information about auto scaling policies.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResult> Result { get; set; }
            public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResult : TeaModel {
                /// <summary>
                /// The ID of the application to which the auto scaling policy belongs.
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
                public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetric Metric { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetric : TeaModel {
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
                    public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetricMetrics> Metrics { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetricMetrics : TeaModel {
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
                public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTrigger Trigger { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTrigger : TeaModel {
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
                    /// The configurations of the trigger.
                    /// </summary>
                    [NameInMap("Triggers")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTriggerTriggers> Triggers { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTriggerTriggers : TeaModel {
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
            /// The total number of auto scaling policies.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

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
