// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertingMetricRuleResourcesResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resources that are associated with the alert rule.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeAlertingMetricRuleResourcesResponseBodyResources Resources { get; set; }
        public class DescribeAlertingMetricRuleResourcesResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeAlertingMetricRuleResourcesResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResource : TeaModel {
                /// <summary>
                /// The dimensions based on which the resources are queried.
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// Indicates whether the alert rule is enabled. Valid values:
                /// 
                /// *   true: The alert rule is enabled.
                /// *   false: The alert rule is disabled.
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// The alert rule based on which the alert is triggered.
                /// </summary>
                [NameInMap("Escalation")]
                [Validation(Required=false)]
                public DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalation Escalation { get; set; }
                public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalation : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public List<DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResource> Resource { get; set; }
                    public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResource : TeaModel {
                        /// <summary>
                        /// The operator that is used to compare the metric value with the threshold. Valid values:
                        /// 
                        /// *   GreaterThanOrEqualToThreshold: greater than or equal to the threshold
                        /// *   GreaterThanThreshold: greater than the threshold
                        /// *   LessThanOrEqualToThreshold: less than or equal to the threshold
                        /// *   LessThanThreshold: less than the threshold
                        /// *   NotEqualToThreshold: not equal to the threshold
                        /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday
                        /// *   LessThanYesterday: less than the metric value at the same time yesterday
                        /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
                        /// *   LessThanLastWeek: less than the metric value at the same time last week
                        /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
                        /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// The description of the alert rule.
                        /// 
                        /// >  This parameter indicates the content of the alert rule. If the metric value meets the alert condition, an alert is triggered.
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// The description of the multi-metric alert rule.
                        /// </summary>
                        [NameInMap("ExpressionList")]
                        [Validation(Required=false)]
                        public DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionList ExpressionList { get; set; }
                        public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionList : TeaModel {
                            [NameInMap("ExpressionList")]
                            [Validation(Required=false)]
                            public List<DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionListExpressionList> ExpressionList { get; set; }
                            public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionListExpressionList : TeaModel {
                                /// <summary>
                                /// The operator that is used to compare the metric value with the threshold. Valid values:
                                /// 
                                /// *   GreaterThanOrEqualToThreshold: greater than or equal to the threshold
                                /// *   GreaterThanThreshold: greater than the threshold
                                /// *   LessThanOrEqualToThreshold: less than or equal to the threshold
                                /// *   LessThanThreshold: less than the threshold
                                /// *   NotEqualToThreshold: not equal to the threshold
                                /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday
                                /// *   LessThanYesterday: less than the metric value at the same time yesterday
                                /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
                                /// *   LessThanLastWeek: less than the metric value at the same time last week
                                /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
                                /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
                                /// </summary>
                                [NameInMap("ComparisonOperator")]
                                [Validation(Required=false)]
                                public string ComparisonOperator { get; set; }

                                /// <summary>
                                /// The metric name.
                                /// </summary>
                                [NameInMap("MetricName")]
                                [Validation(Required=false)]
                                public string MetricName { get; set; }

                                /// <summary>
                                /// The statistical period of the metric. Unit: seconds. The default value is the interval at which the monitoring data of the metric is collected.
                                /// </summary>
                                [NameInMap("Period")]
                                [Validation(Required=false)]
                                public string Period { get; set; }

                                /// <summary>
                                /// The statistical method of the alert level. Valid values:
                                /// 
                                /// *   Maximum
                                /// *   Minimum
                                /// *   Average
                                /// </summary>
                                [NameInMap("Statistics")]
                                [Validation(Required=false)]
                                public string Statistics { get; set; }

                                /// <summary>
                                /// The alert threshold.
                                /// </summary>
                                [NameInMap("Threshold")]
                                [Validation(Required=false)]
                                public string Threshold { get; set; }

                            }

                        }

                        /// <summary>
                        /// The relationship between multiple metrics. Valid values:
                        /// 
                        /// *   &&: If all metrics meet the alert conditions, CloudMonitor sends alert notifications.
                        /// *   ||: If one of the metrics meets the alert conditions, CloudMonitor sends alert notifications.
                        /// </summary>
                        [NameInMap("ExpressionListJoin")]
                        [Validation(Required=false)]
                        public string ExpressionListJoin { get; set; }

                        /// <summary>
                        /// The trigger conditions that are created by using expressions. You can use expressions to create trigger conditions in the following scenarios:
                        /// 
                        /// *   Set an alert blacklist for specific resources. For example, if you specify `$instanceId != \\"i-io8kfvcpp7x5****\\" ``&&`` $Average > 50`, no alert is triggered when the `average metric value` of the `i-io8kfvcpp7x5****` instance exceeds 50.
                        /// *   Set a special alert threshold for a specified instance in the rule. For example, if you specify `$Average > ($instanceId == \\"i-io8kfvcpp7x5****\\"? 80: 50)`, an alert is triggered when the `average metric value` of the `i-io8kfvcpp7x5****` instance exceeds 80 or the `average metric value` of other instances exceeds 50.
                        /// *   Limit the number of instances whose metric values exceed the threshold. For example, if you specify `count($Average > 20) > 3`, an alert is triggered only when the `average metric value` of more than three instances exceeds 20.
                        /// </summary>
                        [NameInMap("ExpressionRaw")]
                        [Validation(Required=false)]
                        public string ExpressionRaw { get; set; }

                        /// <summary>
                        /// The severity level and notification methods of the alert. Valid values:
                        /// 
                        /// *   4: Alert notifications are sent by using emails and DingTalk chatbots.
                        /// *   OK: No alert is generated.
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public int? Level { get; set; }

                        /// <summary>
                        /// The operator that is used to compare the metric value with the threshold. Valid values:
                        /// 
                        /// *   `>=`
                        /// *   `=`
                        /// *   `<=`
                        /// *   `>`
                        /// *   `<`
                        /// *   `!=`
                        /// </summary>
                        [NameInMap("PreCondition")]
                        [Validation(Required=false)]
                        public string PreCondition { get; set; }

                        /// <summary>
                        /// This parameter is deprecated.
                        /// </summary>
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        /// <summary>
                        /// The alert threshold.
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the application group.
                /// 
                /// >  If the alert rule is associated with an application group, the ID of the application group is returned in this parameter.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The time when the last alert was triggered for the resource based on the alert rule. The value is a timestamp.
                /// 
                /// Unit: milliseconds.
                /// </summary>
                [NameInMap("LastAlertTime")]
                [Validation(Required=false)]
                public string LastAlertTime { get; set; }

                /// <summary>
                /// The time when the alert rule was last modified. The value is a timestamp.
                /// 
                /// Unit: milliseconds.
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public string LastModifyTime { get; set; }

                /// <summary>
                /// The severity level and notification methods of the alert. Valid values:
                /// 
                /// *   4: Alert notifications are sent by using emails and DingTalk chatbots.
                /// *   OK: No alert is generated.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                /// <summary>
                /// The metric name.
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The metric value that triggered the alert based on the alert rule. The value is a JSON string.
                /// </summary>
                [NameInMap("MetricValues")]
                [Validation(Required=false)]
                public string MetricValues { get; set; }

                /// <summary>
                /// The namespace of the cloud service.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The type of the cloud service.
                /// </summary>
                [NameInMap("ProductCategory")]
                [Validation(Required=false)]
                public string ProductCategory { get; set; }

                /// <summary>
                /// The resources that are monitored.
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                /// <summary>
                /// The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.
                /// </summary>
                [NameInMap("RetryTimes")]
                [Validation(Required=false)]
                public string RetryTimes { get; set; }

                /// <summary>
                /// The ID of the alert rule.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The name of the alert rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The time when the resource was associated with the alert rule. The value is a timestamp.
                /// 
                /// Unit: milliseconds.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The method used to calculate the metric values that trigger alerts.
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The alert threshold.
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
