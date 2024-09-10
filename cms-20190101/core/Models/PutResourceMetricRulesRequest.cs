// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRulesRequest : TeaModel {
        /// <summary>
        /// The threshold-triggered alert rules.
        /// 
        /// Valid values of N: 1 to 500.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<PutResourceMetricRulesRequestRules> Rules { get; set; }
        public class PutResourceMetricRulesRequestRules : TeaModel {
            [NameInMap("Escalations")]
            [Validation(Required=false)]
            public PutResourceMetricRulesRequestRulesEscalations Escalations { get; set; }
            public class PutResourceMetricRulesRequestRulesEscalations : TeaModel {
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public PutResourceMetricRulesRequestRulesEscalationsCritical Critical { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsCritical : TeaModel {
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Info")]
                [Validation(Required=false)]
                public PutResourceMetricRulesRequestRulesEscalationsInfo Info { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsInfo : TeaModel {
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Warn")]
                [Validation(Required=false)]
                public PutResourceMetricRulesRequestRulesEscalationsWarn Warn { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsWarn : TeaModel {
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

            }

            /// <summary>
            /// The alert contact groups. The alert notifications are sent to the alert contacts in the alert contact group.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// >  An alert contact group can contain one or more alert contacts. For information about how to create alert contacts and alert contact groups, see [PutContact](https://help.aliyun.com/document_detail/114923.html) and [PutContactGroup](https://help.aliyun.com/document_detail/114929.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public string ContactGroups { get; set; }

            /// <summary>
            /// The time period during which the alert rule is effective.
            /// 
            /// Valid values of N: 1 to 500.
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// The subject of the alert notification email.
            /// 
            /// Valid values of N: 1 to 500.
            /// </summary>
            [NameInMap("EmailSubject")]
            [Validation(Required=false)]
            public string EmailSubject { get; set; }

            /// <summary>
            /// The interval at which alerts are triggered based on the alert rule.
            /// 
            /// Unit: seconds.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// >  For information about how to query the statistical period of a metric, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            /// <summary>
            /// If the metric meets the specified condition in the alert rule and CloudMonitor sends an alert notification, the tag is also written to the metric and displayed in the alert notification.
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<PutResourceMetricRulesRequestRulesLabels> Labels { get; set; }
            public class PutResourceMetricRulesRequestRulesLabels : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// 
                /// >  You can use a template parameter to specify a tag value. CloudMonitor replaces the value of the template parameter with an actual tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The metric name.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// For information about how to query the name of a metric, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The namespace of the cloud service.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// For information about how to query the namespace of a cloud service, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
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
            /// 
            /// Valid values of N: 1 to 500.
            /// </summary>
            [NameInMap("NoDataPolicy")]
            [Validation(Required=false)]
            public string NoDataPolicy { get; set; }

            /// <summary>
            /// The time period during which the alert rule is ineffective.
            /// 
            /// Valid values of N: 1 to 500.
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// The statistical period of the metric.
            /// 
            /// Unit: seconds. The default value is the interval at which the monitoring data of the metric is collected.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// >  For information about how to query the statistical period of a metric, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// The information about the resource. Example: `[{"instanceId":"i-uf6j91r34rnwawoo****"}]` or `[{"userId":"100931896542****"}]`.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// For more information about the supported dimensions that are used to query resources, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            /// <summary>
            /// The ID of the alert rule.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// You can specify a new ID or the ID of an existing alert rule. For information about how to query the ID of an alert rule, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
            /// 
            /// >  If you specify a new ID, a threshold-triggered alert rule is created.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The name of the alert rule.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// You can specify a new name or the name of an existing alert rule. For information about how to query the name of an alert rule, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
            /// 
            /// >  If you specify a new name, a threshold-triggered alert rule is created.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The mute period during which new alert notifications are not sent even if the trigger conditions are met.
            /// 
            /// Unit: seconds. Default value: 86400.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// >  If an alert is not cleared after the mute period ends, CloudMonitor resends an alert notification.
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.
            /// 
            /// Valid values of N: 1 to 500.
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

    }

}
