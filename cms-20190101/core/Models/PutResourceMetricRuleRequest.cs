// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRuleRequest : TeaModel {
        [NameInMap("Escalations")]
        [Validation(Required=false)]
        public PutResourceMetricRuleRequestEscalations Escalations { get; set; }
        public class PutResourceMetricRuleRequestEscalations : TeaModel {
            [NameInMap("Critical")]
            [Validation(Required=false)]
            public PutResourceMetricRuleRequestEscalationsCritical Critical { get; set; }
            public class PutResourceMetricRuleRequestEscalationsCritical : TeaModel {
                /// <summary>
                /// The statistical period of the metric. Unit: seconds. The default value is the interval at which the monitoring data of the metric is collected.
                /// 
                /// >  For information about how to query the statistical period of a metric, see [Appendix 1: Metrics](~~163515~~).
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The Prometheus alert rule.
                /// 
                /// >  This parameter is required only when you create a Prometheus alert rule for Hybrid Cloud Monitoring.
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The aggregation period of the metric.
                /// 
                /// Unit: seconds.
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// The threshold for Warn-level alerts.
                /// 
                /// >  You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for the selected alert level.
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            [NameInMap("Info")]
            [Validation(Required=false)]
            public PutResourceMetricRuleRequestEscalationsInfo Info { get; set; }
            public class PutResourceMetricRuleRequestEscalationsInfo : TeaModel {
                /// <summary>
                /// The PromQL query statement.
                /// 
                /// >  The data obtained by using the PromQL query statement is the monitoring data. You must include the alert threshold in this statement.
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The value of the tag.
                /// 
                /// >  You can use a template parameter to specify a tag value. CloudMonitor replaces the value of the template parameter with an actual tag value.
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The information about the resource. Examples: `[{"instanceId":"i-uf6j91r34rnwawoo****"}]` and `[{"userId":"100931896542****"}]`.
                /// 
                /// For information about the supported dimensions that are used to query resources, see [Appendix 1: Metrics](~~163515~~).
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// The number of consecutive triggers. If the number of times that the metric values meet the trigger conditions reaches the value of this parameter, CloudMonitor sends alert notifications.
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            [NameInMap("Warn")]
            [Validation(Required=false)]
            public PutResourceMetricRuleRequestEscalationsWarn Warn { get; set; }
            public class PutResourceMetricRuleRequestEscalationsWarn : TeaModel {
                /// <summary>
                /// The key of the annotation.
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The name of the metric. For information about how to query the name of a metric, see [Appendix 1: Metrics](~~163515~~).
                /// 
                /// >  If you create a Prometheus alert rule for Hybrid Cloud Monitoring, you must set this parameter to the name of the namespace. For information about how to obtain the name of a namespace, see [DescribeHybridMonitorNamespaceList](~~428880~~).
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

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
                /// 
                /// >  You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for the selected alert level.
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// The processing method of alerts when no monitoring data is found. Valid values:
                /// 
                /// *   KEEP_LAST_STATE (default value): No operation is performed.
                /// *   INSUFFICIENT_DATA: An alert whose content is "Insufficient data" is triggered.
                /// *   OK: The status is considered normal.
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

        }

        /// <summary>
        /// The alert contact group. The alert notifications are sent to the contacts that belong to the alert contact group.
        /// 
        /// >  An alert contact group can contain one or more alert contacts. For information about how to create alert contacts and alert contact groups, see [PutContact](~~114923~~) and [PutContactGroup](~~114929~~).
        /// </summary>
        [NameInMap("CompositeExpression")]
        [Validation(Required=false)]
        public PutResourceMetricRuleRequestCompositeExpression CompositeExpression { get; set; }
        public class PutResourceMetricRuleRequestCompositeExpression : TeaModel {
            /// <summary>
            /// The trigger conditions that are created by using expressions. You can use expressions to create trigger conditions in the following scenarios:
            /// 
            /// *   Set an alert blacklist for specific resources. For example, if you specify ` $instanceId != \"i-io8kfvcpp7x5****\"  ``&&``  $Average > 50 `, no alert is generated even when the `average metric value` of the `i-io8kfvcpp7x5****` instance exceeds 50.
            /// *   Set a special alert threshold for a specified instance in the rule. For example, if you specify `$Average > ($instanceId == \"i-io8kfvcpp7x5****\"? 80: 50)`, an alert is triggered when the `average metric value` of the `i-io8kfvcpp7x5****` instance exceeds 80 or the `average metric value` of other instances exceeds 50.
            /// *   Limits the number of instances whose metric values exceed the threshold. For example, if you specify `count($Average > 20) > 3`, an alert is triggered only when the number of instances whose `average metric value` exceeds 20 exceeds three.
            /// </summary>
            [NameInMap("ExpressionList")]
            [Validation(Required=false)]
            public List<PutResourceMetricRuleRequestCompositeExpressionExpressionList> ExpressionList { get; set; }
            public class PutResourceMetricRuleRequestCompositeExpressionExpressionList : TeaModel {
                /// <summary>
                /// The statistical method of the metric. Valid values:
                /// 
                /// *   $Maximum: the maximum value
                /// *   $Minimum: the minimum value
                /// *   $Average: the average value
                /// *   $Availability: the availability rate (usually used for site monitoring)
                /// 
                /// >  `$` is the prefix of the metric. For information about the Alibaba Cloud services that are supported by CloudMonitor, see [Appendix 1: Metrics](~~163515~~).
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The trigger conditions for multiple metrics.
                /// 
                /// >  The trigger conditions for a single metric and multiple metrics are mutually exclusive. You cannot specify trigger conditions for a single metric and multiple metrics at the same time.
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The statistical methods for Critical-level alerts. Valid values:
                /// 
                /// *   Maximum: the maximum value
                /// *   Minimum: the minimum value
                /// *   Average: the average value
                /// *   Availability: the availability rate
                /// 
                /// >  You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for the selected alert level.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                /// <summary>
                /// The time period during which the alert rule is effective.
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The number of consecutive triggers. If the number of times that the metric values meet the trigger conditions reaches the value of this parameter, CloudMonitor sends alert notifications.
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

            /// <summary>
            /// The alert threshold.
            /// </summary>
            [NameInMap("ExpressionListJoin")]
            [Validation(Required=false)]
            public string ExpressionListJoin { get; set; }

            /// <summary>
            /// The threshold for Info-level alerts.
            /// 
            /// >  You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for the selected alert level.
            /// </summary>
            [NameInMap("ExpressionRaw")]
            [Validation(Required=false)]
            public string ExpressionRaw { get; set; }

            /// <summary>
            /// The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The statistical methods for Warn-level alerts. Valid values:
            /// 
            /// *   Maximum: the maximum value
            /// *   Minimum: the minimum value
            /// *   Average: the average value
            /// *   Availability: the availability rate
            /// 
            /// >  You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for the selected alert level.
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// The statistical methods for Info-level alerts. Valid values:
        /// 
        /// *   Maximum: the maximum value
        /// *   Minimum: the minimum value
        /// *   Average: the average value
        /// *   Availability: the availability rate
        /// 
        /// >  You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for the selected alert level.
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

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
        /// 
        /// >  You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for the selected alert level.
        /// </summary>
        [NameInMap("EffectiveInterval")]
        [Validation(Required=false)]
        public string EffectiveInterval { get; set; }

        /// <summary>
        /// The namespace of the cloud service. For information about how to query the namespace of a cloud service, see [Appendix 1: Metrics](~~163515~~).
        /// 
        /// >  If you create a Prometheus alert rule for Hybrid Cloud Monitoring, you must set this parameter to `acs_prometheus`.
        /// </summary>
        [NameInMap("EmailSubject")]
        [Validation(Required=false)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// The subject of the alert notification email.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<PutResourceMetricRuleRequestLabels> Labels { get; set; }
        public class PutResourceMetricRuleRequestLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The relationship between the trigger conditions for multiple metrics. Valid values:
            /// 
            /// *   `&&`: An alert is triggered only if all metrics meet the trigger conditions. An alert is triggered only if the results of all expressions specified in the ExpressionList parameter are `true`.
            /// *   `||`: If one of the metrics meets the trigger conditions, an alert is triggered.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The trigger conditions that are created in standard mode.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **PutResourceMetricRule**.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("NoDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        /// <summary>
        /// The value of the annotation.
        /// </summary>
        [NameInMap("NoEffectiveInterval")]
        [Validation(Required=false)]
        public string NoEffectiveInterval { get; set; }

        /// <summary>
        /// The name of the alert rule.
        /// 
        /// You can specify a new name or the name of an existing alert rule. For information about how to query the name of an alert rule, see [DescribeMetricRuleList](~~114941~~).
        /// 
        /// >  If you specify a new name, a threshold-triggered alert rule is created.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The time period during which the alert rule is ineffective.
        /// </summary>
        [NameInMap("Prometheus")]
        [Validation(Required=false)]
        public PutResourceMetricRuleRequestPrometheus Prometheus { get; set; }
        public class PutResourceMetricRuleRequestPrometheus : TeaModel {
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
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<PutResourceMetricRuleRequestPrometheusAnnotations> Annotations { get; set; }
            public class PutResourceMetricRuleRequestPrometheusAnnotations : TeaModel {
                /// <summary>
                /// The level of the alert. Valid values:
                /// 
                /// *   Critical
                /// *   Warn
                /// *   Info
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The consecutive number of times for which the metric value meets the trigger condition before an Info-level alert is triggered.
                /// 
                /// >  You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for the selected alert level.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The annotations of the Prometheus alert rule. When a Prometheus alert is triggered, the system renders the annotated keys and values to help you understand the metrics and alert rule.
            /// 
            /// >  This parameter is equivalent to the annotations parameter of open source Prometheus.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The threshold for Critical-level alerts.
            /// 
            /// >  You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for the selected alert level.
            /// </summary>
            [NameInMap("PromQL")]
            [Validation(Required=false)]
            public string PromQL { get; set; }

            /// <summary>
            /// The consecutive number of times for which the metric value meets the trigger condition before a Critical-level alert is triggered.
            /// 
            /// >  You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for the selected alert level.
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

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
        /// 
        /// >  You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for the selected alert level.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// The metric that is used to monitor the cloud service.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// The level of the alert. Valid values:
        /// 
        /// *   Critical
        /// *   Warn
        /// *   Info
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The interval at which the alert is triggered. Unit: seconds.
        /// 
        /// >  For information about how to query the statistical period of a metric, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// You can specify a new ID or the ID of an existing alert rule. For information about how to query the ID of an alert rule, see [DescribeMetricRuleList](~~114941~~).
        /// 
        /// >  If you specify a new ID, a threshold-triggered alert rule is created.
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
