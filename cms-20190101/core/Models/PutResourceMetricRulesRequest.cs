// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRulesRequest : TeaModel {
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
            /// The error message.
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public string ContactGroups { get; set; }

            /// <summary>
            /// The operation that you want to perform. Set the value to **PutResourceMetricRules**.
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// The HTTP status code.
            /// </summary>
            [NameInMap("EmailSubject")]
            [Validation(Required=false)]
            public string EmailSubject { get; set; }

            /// <summary>
            /// The alert contact group. The alert notifications are sent to the alert contacts in the alert contact group.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// >  An alert contact group can contain one or more alert contacts. For information about how to create alert contacts and alert contact groups, see [PutContact](~~114923~~) and [PutContactGroup](~~114929~~).
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<PutResourceMetricRulesRequestRulesLabels> Labels { get; set; }
            public class PutResourceMetricRulesRequestRulesLabels : TeaModel {
                /// <summary>
                /// The interval at which the alert rule is executed.
                /// 
                /// Unit: seconds.
                /// 
                /// Valid values of N: 1 to 500.
                /// 
                /// >  For information about how to query the statistical period of a metric, see [Appendix 1: Metrics](~~163515~~).
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The subject of the alert notification email.
                /// 
                /// Valid values of N: 1 to 500.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The HTTP status code.
            /// 
            /// >  The status code 200 indicates that the call was successful.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The name of the alert rule.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// You can specify a new name or the name of an existing alert rule. For information about how to query the name of an alert rule, see [DescribeMetricRuleList](~~114941~~).
            /// 
            /// >  If you specify a new name, you create a threshold-triggered alert rule.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// Indicates whether the call was successful. Valid values:
            /// 
            /// *   true: The call was successful.
            /// *   false: The call failed.
            /// </summary>
            [NameInMap("NoDataPolicy")]
            [Validation(Required=false)]
            public string NoDataPolicy { get; set; }

            /// <summary>
            /// The time period during which the alert rule is effective.
            /// 
            /// Valid values of N: 1 to 500.
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// The name of the metric.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// For information about how to query the name of a metric, see [Appendix 1: Metrics](~~163515~~).
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// The statistical methods for Warn-level alerts. Valid values:
            /// 
            /// *   Maximum: the maximum value
            /// *   Minimum: the minimum value
            /// *   Average: the average value
            /// *   Availability: the availability rate
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// >  You must set a collection of the Rules.N.Escalations.Critical.Statistics, Rules.N.Escalations.Critical.ComparisonOperator, Rules.N.Escalations.Critical.Threshold, and Rules.N.Escalations.Critical.Times parameters, a collection of the Rules.N.Escalations.Warn.Statistics, Rules.N.Escalations.Warn.ComparisonOperator, Rules.N.Escalations.Warn.Threshold, and Rules.N.Escalations.Warn.Times parameters, or a collection of the Rules.N.Escalations.Info.Statistics, Rules.N.Escalations.Info.ComparisonOperator, Rules.N.Escalations.Info.Threshold, and Rules.N.Escalations.Info.Times parameters.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The ID of the alert rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The method that is used to handle alerts when no monitoring data is found. Valid values:
            /// 
            /// *   KEEP_LAST_STATE (default value): No operation is performed.
            /// *   INSUFFICIENT_DATA: An alert whose content is "Insufficient data" is triggered.
            /// *   OK: The status is considered normal.
            /// 
            /// Valid values of N: 1 to 500.
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// The mute period during which new alerts are not sent even if the trigger conditions are met.
            /// 
            /// Unit: seconds. Default value: 86400.
            /// 
            /// Valid values of N: 1 to 500.
            /// 
            /// >  If an alert is not cleared after the mute period ends, CloudMonitor resends an alert notification.
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

    }

}
