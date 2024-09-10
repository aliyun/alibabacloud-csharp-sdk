// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutGroupMetricRuleRequest : TeaModel {
        [NameInMap("Escalations")]
        [Validation(Required=false)]
        public PutGroupMetricRuleRequestEscalations Escalations { get; set; }
        public class PutGroupMetricRuleRequestEscalations : TeaModel {
            [NameInMap("Critical")]
            [Validation(Required=false)]
            public PutGroupMetricRuleRequestEscalationsCritical Critical { get; set; }
            public class PutGroupMetricRuleRequestEscalationsCritical : TeaModel {
                /// <summary>
                /// The operator that is used to compare the metric value with the threshold for Critical-level alerts. Valid values:
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
                /// The statistical methods for Critical-level alerts. Separate multiple statistical methods with commas (,).
                /// 
                /// The value of this parameter is determined by the `Statistics` column corresponding to the `MetricName` parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
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

            [NameInMap("Info")]
            [Validation(Required=false)]
            public PutGroupMetricRuleRequestEscalationsInfo Info { get; set; }
            public class PutGroupMetricRuleRequestEscalationsInfo : TeaModel {
                /// <summary>
                /// The operator that is used to compare the metric value with the threshold for Info-level alerts. Valid values:
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
                /// The statistical methods for Info-level alerts. Separate multiple statistical methods with commas (,).
                /// 
                /// The value of this parameter is determined by the `Statistics` column corresponding to the `MetricName` parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
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

            [NameInMap("Warn")]
            [Validation(Required=false)]
            public PutGroupMetricRuleRequestEscalationsWarn Warn { get; set; }
            public class PutGroupMetricRuleRequestEscalationsWarn : TeaModel {
                /// <summary>
                /// The operator that is used to compare the metric value with the threshold for Warn-level alerts. Valid values:
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
                /// The statistical methods for Warn-level alerts. Separate multiple statistical methods with commas (,).
                /// 
                /// The value of this parameter is determined by the `Statistics` column corresponding to the `MetricName` parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
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
        /// The abbreviation of the cloud service name.
        /// 
        /// For more information about how to obtain the abbreviation of a cloud service name, see `metricCategory` in the response parameter `Labels` of the [DescribeProjectMeta](https://help.aliyun.com/document_detail/114916.html) operation.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The alert contact group.
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

        /// <summary>
        /// The first-level dimension of the alert rule in the application group.
        /// 
        /// Set the value to a set of key-value pairs, for example, `userId:120886317861****` or `instanceId:i-m5e1qg6uo38rztr4****`.
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
        /// The subject of the alert notification email.
        /// </summary>
        [NameInMap("EmailSubject")]
        [Validation(Required=false)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// The second-level or third-level dimension of the alert rule in the application group.
        /// 
        /// Set the value to a set of key-value pairs, for example, `port:80` or `/dev/xvda:d-m5e6yphgzn3aprwu****`.
        /// 
        /// If the first-level dimension of the alert rule is `instanceId:i-m5e1qg6uo38rztr4****`, its second-level dimension is the `/dev/xvda:d-m5e6yphgzn3aprwu****` disk in the instance.
        /// </summary>
        [NameInMap("ExtraDimensionJson")]
        [Validation(Required=false)]
        public string ExtraDimensionJson { get; set; }

        /// <summary>
        /// The application group ID.
        /// 
        /// For more information about how to obtain the ID of an application group, see [DescribeMonitorGroups](https://help.aliyun.com/document_detail/115032.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The interval at which CloudMonitor checks whether the alert rule is triggered. Unit: seconds.
        /// 
        /// >  We recommend that you set the interval to the data aggregation period. If the interval is shorter than the data aggregation period, alerts cannot be triggered due to insufficient data.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The tags of the alert rule.
        /// 
        /// The specified tag is contained in alert notifications.
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<PutGroupMetricRuleRequestLabels> Labels { get; set; }
        public class PutGroupMetricRuleRequestLabels : TeaModel {
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

        /// <summary>
        /// The metric name.
        /// 
        /// For more information about how to obtain the name of a metric, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html) or [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// For more information about how to obtain the namespace of a cloud service, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html) or [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The method that is used to handle alerts when no monitoring data is found. Valid values:
        /// 
        /// *   KEEP_LAST_STATE (default): No operation is performed.
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

        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// The aggregation period of the metric data.
        /// 
        /// Set the `Period` parameter to an integral multiple of 60. Unit: seconds. Default value: 300.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// *   When you create an alert rule for the application group, enter the ID of the alert rule.
        /// *   When you modify a specified alert rule in the application group, you must obtain the ID of the alert rule. For information about how to obtain the ID of an alert rule, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// The name of the alert rule.
        /// 
        /// *   When you create an alert rule for the application group, enter the name of the alert rule.
        /// *   When you modify a specified alert rule in the application group, you must obtain the name of the alert rule. For more information about how to obtain the name of an alert rule, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The mute period during which new alerts are not sent even if the trigger conditions are met.
        /// 
        /// Unit: seconds. Default value: 86400.
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// The callback URL.
        /// 
        /// The callback URL must be accessible over the Internet. CloudMonitor sends a POST request to push an alert notification to the callback URL that you specify. Only HTTP requests are supported.
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
