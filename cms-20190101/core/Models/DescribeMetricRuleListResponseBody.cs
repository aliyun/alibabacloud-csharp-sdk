// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleListResponseBody : TeaModel {
        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public DescribeMetricRuleListResponseBodyAlarms Alarms { get; set; }
        public class DescribeMetricRuleListResponseBodyAlarms : TeaModel {
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleListResponseBodyAlarmsAlarm> Alarm { get; set; }
            public class DescribeMetricRuleListResponseBodyAlarmsAlarm : TeaModel {
                public string AlertState { get; set; }
                public DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpression CompositeExpression { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpression : TeaModel {
                    [NameInMap("ExpressionList")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionList ExpressionList { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionList : TeaModel {
                        [NameInMap("ExpressionList")]
                        [Validation(Required=false)]
                        public List<DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionListExpressionList> ExpressionList { get; set; }
                        public class DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionListExpressionList : TeaModel {
                            public string ComparisonOperator { get; set; }
                            public string MetricName { get; set; }
                            public int? Period { get; set; }
                            public string Statistics { get; set; }
                            public string Threshold { get; set; }
                        }
                    };

                    [NameInMap("ExpressionListJoin")]
                    [Validation(Required=false)]
                    public string ExpressionListJoin { get; set; }

                    [NameInMap("ExpressionRaw")]
                    [Validation(Required=false)]
                    public string ExpressionRaw { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }
                public string ContactGroups { get; set; }
                public string Dimensions { get; set; }
                public string EffectiveInterval { get; set; }
                public bool? EnableState { get; set; }
                public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalations Escalations { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalations : TeaModel {
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsCritical Critical { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsCritical : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }
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
                    };

                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsInfo Info { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsInfo : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }
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
                    };

                    [NameInMap("Warn")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsWarn Warn { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsWarn : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }
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
                    };

                }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public DescribeMetricRuleListResponseBodyAlarmsAlarmLabels Labels { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmLabels : TeaModel {
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public List<DescribeMetricRuleListResponseBodyAlarmsAlarmLabelsLabels> Labels { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmLabelsLabels : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string MailSubject { get; set; }
                public string MetricName { get; set; }
                public string Namespace { get; set; }
                public string NoDataPolicy { get; set; }
                public string NoEffectiveInterval { get; set; }
                public string Period { get; set; }
                public DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheus Prometheus { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheus : TeaModel {
                    [NameInMap("Annotations")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotations Annotations { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotations : TeaModel {
                        [NameInMap("Annotations")]
                        [Validation(Required=false)]
                        public List<DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotationsAnnotations> Annotations { get; set; }
                        public class DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotationsAnnotations : TeaModel {
                            public string Key { get; set; }
                            public string Value { get; set; }
                        }
                    };

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("PromQL")]
                    [Validation(Required=false)]
                    public string PromQL { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public long? Times { get; set; }

                }
                public string Resources { get; set; }
                public string RuleId { get; set; }
                public string RuleName { get; set; }
                public int? SilenceTime { get; set; }
                public string SourceType { get; set; }
                public string Webhook { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
