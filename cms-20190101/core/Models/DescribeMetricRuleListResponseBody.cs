// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleListResponseBody : TeaModel {
        /// <summary>
        /// The details of the alert rules.
        /// </summary>
        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public DescribeMetricRuleListResponseBodyAlarms Alarms { get; set; }
        public class DescribeMetricRuleListResponseBodyAlarms : TeaModel {
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleListResponseBodyAlarmsAlarm> Alarm { get; set; }
            public class DescribeMetricRuleListResponseBodyAlarmsAlarm : TeaModel {
                /// <summary>
                /// The status of the alert rule. Valid values:
                /// 
                /// *   OK: The alert rule has no active alerts.
                /// *   ALARM: The alert rule has active alerts.
                /// *   INSUFFICIENT_DATA: No data is available.
                /// </summary>
                [NameInMap("AlertState")]
                [Validation(Required=false)]
                public string AlertState { get; set; }

                /// <summary>
                /// The trigger conditions for multiple metrics.
                /// 
                /// >  The trigger conditions for a single metric and multiple metrics are mutually exclusive. You cannot specify trigger conditions for a single metric and multiple metrics at the same time.
                /// </summary>
                [NameInMap("CompositeExpression")]
                [Validation(Required=false)]
                public DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpression CompositeExpression { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpression : TeaModel {
                    /// <summary>
                    /// The trigger conditions that are created in standard mode.
                    /// </summary>
                    [NameInMap("ExpressionList")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionList ExpressionList { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionList : TeaModel {
                        [NameInMap("ExpressionList")]
                        [Validation(Required=false)]
                        public List<DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionListExpressionList> ExpressionList { get; set; }
                        public class DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionListExpressionList : TeaModel {
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
                            /// The metric that is used to monitor the cloud service.
                            /// </summary>
                            [NameInMap("MetricName")]
                            [Validation(Required=false)]
                            public string MetricName { get; set; }

                            /// <summary>
                            /// The aggregation period of the metric.
                            /// 
                            /// Unit: seconds.
                            /// </summary>
                            [NameInMap("Period")]
                            [Validation(Required=false)]
                            public int? Period { get; set; }

                            /// <summary>
                            /// The statistical method of the metric. Valid values:
                            /// 
                            /// *   $Maximum: the maximum value
                            /// *   $Minimum: the minimum value
                            /// *   $Average: the average value
                            /// *   $Availability: the availability rate (usually used for site monitoring)
                            /// 
                            /// >  `$` is the prefix of the metric. For information about the Alibaba Cloud services that are supported by CloudMonitor, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
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
                    /// The relationship between the trigger conditions for multiple metrics. Valid values:
                    /// 
                    /// *   `&&`: An alert is triggered only if all metrics meet the trigger conditions. An alert is triggered only if the results of all expressions specified in the ExpressionList parameter are `true`.
                    /// *   `||`: An alert is triggered if one of the metrics meets the trigger conditions.
                    /// </summary>
                    [NameInMap("ExpressionListJoin")]
                    [Validation(Required=false)]
                    public string ExpressionListJoin { get; set; }

                    /// <summary>
                    /// The trigger conditions that are created by using expressions. You can use expressions to create trigger conditions in the following scenarios:
                    /// 
                    /// *   Set an alert blacklist for specific resources. For example, if you specify `$instanceId != \\"i-io8kfvcpp7x5****\\" ``&&`` $Average > 50`, no alert is triggered when the `average metric value` of the `i-io8kfvcpp7x5****` instance exceeds 50.
                    /// *   Set a special alert threshold for a specified instance in the rule. For example, if you specify `$Average > ($instanceId == \\"i-io8kfvcpp7x5****\\"? 80: 50)`, an alert is triggered when the `average metric value` of the `i-io8kfvcpp7x5****` instance exceeds 80 or the `average metric value` of other instances exceeds 50.
                    /// *   Limit the number of instances whose metric values exceed the threshold. For example, if you specify `count($Average > 20) > 3`, an alert is triggered only when the number of instances whose `average metric value` exceeds 20 exceeds three.
                    /// </summary>
                    [NameInMap("ExpressionRaw")]
                    [Validation(Required=false)]
                    public string ExpressionRaw { get; set; }

                    /// <summary>
                    /// The level of the alert. Valid values:
                    /// 
                    /// *   Critical
                    /// *   Warn
                    /// *   Info
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// The number of consecutive triggers. If the number of times that the metric values meet the trigger conditions reaches the value of this parameter, CloudMonitor sends alert notifications.
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                /// <summary>
                /// The alert contact group.
                /// </summary>
                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public string ContactGroups { get; set; }

                /// <summary>
                /// The dimensions of the alert rule.
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// The time period during which the alert rule is effective.
                /// </summary>
                [NameInMap("EffectiveInterval")]
                [Validation(Required=false)]
                public string EffectiveInterval { get; set; }

                /// <summary>
                /// Indicates whether the alert rule is enabled. Valid values:
                /// 
                /// *   true: The alert rule is enabled.
                /// *   false: The alert rule is disabled.
                /// </summary>
                [NameInMap("EnableState")]
                [Validation(Required=false)]
                public bool? EnableState { get; set; }

                /// <summary>
                /// The conditions for triggering different levels of alerts.
                /// </summary>
                [NameInMap("Escalations")]
                [Validation(Required=false)]
                public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalations Escalations { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalations : TeaModel {
                    /// <summary>
                    /// The conditions for triggering Critical-level alerts.
                    /// </summary>
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsCritical Critical { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsCritical : TeaModel {
                        /// <summary>
                        /// The comparison operator that is used to compare the metric value with the threshold. Valid values:
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
                        /// The additional conditions for triggering Critical-level alerts. The additional conditions take effect when the value of the ComparisonOperator parameter is GreaterThanYesterday, LessThanYesterday, GreaterThanLastWeek, LessThanLastWeek, GreaterThanLastPeriod, or LessThanLastPeriod.
                        /// 
                        /// For example, the values of the PreCondition, ComparisonOperator, and Threshold parameters are set to $Average>80, GreaterThanYesterday, and 10, respectively. An alert is triggered only when the average metric value is greater than 80 and 10% greater than the average metric value at the same time yesterday.
                        /// 
                        /// >  $Average is a placeholder that consists of `a dollar sign ($) and the statistical method`. CloudMonitor replaces the placeholder with the aggregated value or original value before value comparison.
                        /// </summary>
                        [NameInMap("PreCondition")]
                        [Validation(Required=false)]
                        public string PreCondition { get; set; }

                        /// <summary>
                        /// The statistical methods for Critical-level alerts.
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// The threshold for Critical-level alerts.
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// The consecutive number of times for which the metric value meets the alert condition before a Critical-level alert is triggered.
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }

                    }

                    /// <summary>
                    /// The conditions for triggering Info-level alerts.
                    /// </summary>
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsInfo Info { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsInfo : TeaModel {
                        /// <summary>
                        /// The comparison operator that is used to compare the metric value with the threshold. Valid values:
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
                        /// The additional conditions for triggering Info-level alerts. The additional conditions take effect when the value of the ComparisonOperator parameter is GreaterThanYesterday, LessThanYesterday, GreaterThanLastWeek, LessThanLastWeek, GreaterThanLastPeriod, or LessThanLastPeriod.
                        /// 
                        /// For example, the values of the PreCondition, ComparisonOperator, and Threshold parameters are set to $Average>80, GreaterThanYesterday, and 10, respectively. An alert is triggered only when the average metric value is greater than 80 and 10% greater than the average metric value at the same time yesterday.
                        /// 
                        /// >  $Average is a placeholder that consists of `a dollar sign ($) and the statistical method`. CloudMonitor replaces the placeholder with the aggregated value or original value before value comparison.
                        /// </summary>
                        [NameInMap("PreCondition")]
                        [Validation(Required=false)]
                        public string PreCondition { get; set; }

                        /// <summary>
                        /// The statistical methods for Info-level alerts.
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// The threshold for Info-level alerts.
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// The consecutive number of times for which the metric value meets the alert condition before an Info-level alert is triggered.
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }

                    }

                    /// <summary>
                    /// The conditions for triggering Warn-level alerts.
                    /// </summary>
                    [NameInMap("Warn")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsWarn Warn { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsWarn : TeaModel {
                        /// <summary>
                        /// The comparison operator that is used to compare the metric value with the threshold. Valid values:
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
                        /// The additional conditions for triggering Warn-level alerts. The additional conditions take effect when the value of the ComparisonOperator parameter is GreaterThanYesterday, LessThanYesterday, GreaterThanLastWeek, LessThanLastWeek, GreaterThanLastPeriod, or LessThanLastPeriod.
                        /// 
                        /// For example, the values of the PreCondition, ComparisonOperator, and Threshold parameters are set to $Average>80, GreaterThanYesterday, and 10, respectively. An alert is triggered only when the average metric value is greater than 80 and 10% greater than the average metric value at the same time yesterday.
                        /// 
                        /// >  $Average is a placeholder that consists of `a dollar sign ($) and the statistical method`. CloudMonitor replaces the placeholder with the aggregated value or original value before value comparison.
                        /// </summary>
                        [NameInMap("PreCondition")]
                        [Validation(Required=false)]
                        public string PreCondition { get; set; }

                        /// <summary>
                        /// The statistical methods for Warn-level alerts.
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// The threshold for Warn-level alerts.
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// The consecutive number of times for which the metric value meets the alert condition before a Warn-level alert is triggered.
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the application group.
                /// 
                /// >  If the alert rule is associated with an application group, the name of the application group is returned in this parameter.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The tags of the alert rule.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public DescribeMetricRuleListResponseBodyAlarmsAlarmLabels Labels { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmLabels : TeaModel {
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public List<DescribeMetricRuleListResponseBodyAlarmsAlarmLabelsLabels> Labels { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmLabelsLabels : TeaModel {
                        /// <summary>
                        /// The tag key of the alert rule.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value of the alert rule.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The subject of the alert notification email.
                /// </summary>
                [NameInMap("MailSubject")]
                [Validation(Required=false)]
                public string MailSubject { get; set; }

                /// <summary>
                /// The name of the metric.
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The namespace of the cloud service.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The method that is used to handle alerts when no monitoring data is found. Valid values:
                /// 
                /// *   KEEP_LAST_STATE (default value): No operation is performed.
                /// *   INSUFFICIENT_DATA: An alert whose content is "Insufficient data" is triggered.
                /// *   OK: The status is considered normal.
                /// </summary>
                [NameInMap("NoDataPolicy")]
                [Validation(Required=false)]
                public string NoDataPolicy { get; set; }

                /// <summary>
                /// The time period during which the alert rule is ineffective.
                /// </summary>
                [NameInMap("NoEffectiveInterval")]
                [Validation(Required=false)]
                public string NoEffectiveInterval { get; set; }

                /// <summary>
                /// The statistical period.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// The Prometheus alert rule.
                /// 
                /// >  This parameter is required only when you create a Prometheus alert rule for Hybrid Cloud Monitoring.
                /// </summary>
                [NameInMap("Prometheus")]
                [Validation(Required=false)]
                public DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheus Prometheus { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheus : TeaModel {
                    /// <summary>
                    /// The annotations of the Prometheus alert rule. When a Prometheus alert is triggered, the system renders the annotated keys and values to help you understand the metrics and alert rule.
                    /// 
                    /// >  This parameter is equivalent to the annotations parameter of open source Prometheus.
                    /// </summary>
                    [NameInMap("Annotations")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotations Annotations { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotations : TeaModel {
                        [NameInMap("Annotations")]
                        [Validation(Required=false)]
                        public List<DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotationsAnnotations> Annotations { get; set; }
                        public class DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotationsAnnotations : TeaModel {
                            /// <summary>
                            /// The key of the annotation.
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// The value of the annotation.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// The level of the alert. Valid values:
                    /// 
                    /// *   Critical
                    /// *   Warn
                    /// *   Info
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// The PromQL query statement.
                    /// 
                    /// >  The data obtained by using the PromQL query statement is the monitoring data. You must include the alert threshold in this statement.
                    /// </summary>
                    [NameInMap("PromQL")]
                    [Validation(Required=false)]
                    public string PromQL { get; set; }

                    /// <summary>
                    /// The number of consecutive triggers. If the number of times that the metric values meet the trigger conditions reaches the value of this parameter, CloudMonitor sends alert notifications.
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public long? Times { get; set; }

                }

                /// <summary>
                /// The resources that are associated with the alert rule.
                /// </summary>
                [NameInMap("Resources")]
                [Validation(Required=false)]
                public string Resources { get; set; }

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
                /// The mute period during which new alert notifications are not sent even if the trigger conditions are met. Unit: seconds. Default value: 86400. Minimum value: 3600.
                /// 
                /// Only one alert is reported during each mute period even if the metric value consecutively exceeds the alert rule threshold several times.
                /// </summary>
                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public int? SilenceTime { get; set; }

                /// <summary>
                /// The type of the alert rule. Valid value: METRIC. This value indicates an alert rule for time series metrics.
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The callback URL. CloudMonitor pushes an alert notification to the specified callback URL by sending an HTTP POST request. Only the HTTP protocol is supported.
                /// </summary>
                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call is successful.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
