// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeActiveMetricRuleListResponseBody : TeaModel {
        /// <summary>
        /// The details of the alert rules.
        /// </summary>
        [NameInMap("AlertList")]
        [Validation(Required=false)]
        public DescribeActiveMetricRuleListResponseBodyAlertList AlertList { get; set; }
        public class DescribeActiveMetricRuleListResponseBodyAlertList : TeaModel {
            [NameInMap("Alert")]
            [Validation(Required=false)]
            public List<DescribeActiveMetricRuleListResponseBodyAlertListAlert> Alert { get; set; }
            public class DescribeActiveMetricRuleListResponseBodyAlertListAlert : TeaModel {
                /// <summary>
                /// The status of the alert rule. Valid values:
                /// 
                /// *   OK: The alert rule has no active alert.
                /// *   ALARM: The alert rule has at least one active alert.
                /// *   INSUFFICIENT_DATA: The alert rule has no data.
                /// </summary>
                [NameInMap("AlertState")]
                [Validation(Required=false)]
                public string AlertState { get; set; }

                /// <summary>
                /// The alert group that receives alert notifications.
                /// </summary>
                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public string ContactGroups { get; set; }

                /// <summary>
                /// The dimensions that specify the resources for which you want to query monitoring data.
                /// 
                /// The value is a collection of key-value pairs. A typical key-value pair is `instanceId:XXXXXX`.
                /// 
                /// The key and value must be 1 to 64 bytes in length, respectively. Excessive bytes are truncated from the string.
                /// 
                /// The key and value can contain letters, digits, periods (.), hyphens (-), underscores (\_), forward slashes (/), and backslashes (\\).
                /// 
                /// >  Dimensions must be organized in a JSON string and follow the required order.
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
                public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalations Escalations { get; set; }
                public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalations : TeaModel {
                    /// <summary>
                    /// The condition for triggering critical-level alerts.
                    /// </summary>
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsCritical Critical { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsCritical : TeaModel {
                        /// <summary>
                        /// The comparison operator of the threshold for critical-level alerts. Valid values:
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
                        /// The statistical aggregation method for critical-level alerts.
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// The threshold for critical-level alerts.
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// The consecutive number of times for which the metric value meets the alert condition before a Critical-level alert is triggered.
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                    /// <summary>
                    /// The condition for triggering info-level alerts.
                    /// </summary>
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsInfo Info { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsInfo : TeaModel {
                        /// <summary>
                        /// The comparison operator of the threshold for info-level alerts. Valid values:
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
                        /// The statistical aggregation method for info-level alerts.
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// The threshold for info-level alerts.
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// The consecutive number of times for which the metric value meets the alert condition before an info-level alert is triggered.
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                    /// <summary>
                    /// The condition for triggering warn-level alerts.
                    /// </summary>
                    [NameInMap("Warn")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsWarn Warn { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsWarn : TeaModel {
                        /// <summary>
                        /// The comparison operator of the threshold for critical-level alerts. Valid values:
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
                        /// The statistical aggregation method for warn-level alerts.
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// The threshold of warn-level alerts.
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// The consecutive number of times for which the metric value meets the alert condition before a warn-level alert is triggered.
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                }

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
                /// The namespace of the service. For more information, see [Appendix 1: Metrics](~~163515~~).
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The time period during which the alert rule is ineffective.
                /// </summary>
                [NameInMap("NoEffectiveInterval")]
                [Validation(Required=false)]
                public string NoEffectiveInterval { get; set; }

                /// <summary>
                /// The aggregation period of the monitoring data. Unit: seconds. The default value is the minimum aggregation period, indicating that the metric is polled at the highest frequency. Typically, you do not need to specify the minimum aggregation period.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// The resources that are associated with the alert rule. A one-click alert rule is associated with all resources. The return value is fixed.
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
                /// The mute period during which new alerts are not sent even if the trigger conditions are met. Unit: seconds. Default value: 86400.
                /// </summary>
                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public string SilenceTime { get; set; }

                /// <summary>
                /// The callback URL.
                /// </summary>
                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the alert rules.
        /// </summary>
        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeActiveMetricRuleListResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeActiveMetricRuleListResponseBodyDatapoints : TeaModel {
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public List<DescribeActiveMetricRuleListResponseBodyDatapointsAlarm> Alarm { get; set; }
            public class DescribeActiveMetricRuleListResponseBodyDatapointsAlarm : TeaModel {
                /// <summary>
                /// The comparison operator that is used in the alert rule. Valid values:
                /// 
                /// *   `>`
                /// *   `<`
                /// *   `>=`
                /// *   `<=`
                /// *   `=`
                /// *   `=`
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The alert group that receives alert notifications.
                /// </summary>
                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public string ContactGroups { get; set; }

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
                /// The beginning of the time period during which the alert rule is effective. Unit: hours. For example, the value 23 indicates `23:59:59`.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public string EvaluationCount { get; set; }

                /// <summary>
                /// The name of the metric.
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The namespace of the service. For more information, see [Appendix 1: Metrics](~~163515~~).
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The aggregation period of the monitoring data. Unit: seconds. The default value is the minimum aggregation period, indicating that the metric is polled at the highest frequency. Typically, you do not need to specify the minimum aggregation period.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

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
                /// The mute period during which new alerts are not sent even if the trigger conditions are met. Unit: seconds. Default value: 86400.
                /// </summary>
                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public string SilenceTime { get; set; }

                /// <summary>
                /// The end of the time period during which the alert rule is effective. Unit: hours. For example, the value 00 indicates `00:00:00`.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// Indicates whether the alert rule is enabled.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The statistical aggregation method.
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The threshold of the metric value.
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// The callback URL.
                /// </summary>
                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

        }

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

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
