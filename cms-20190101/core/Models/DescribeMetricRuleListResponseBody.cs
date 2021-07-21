// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public DescribeMetricRuleListResponseBodyAlarms Alarms { get; set; }
        public class DescribeMetricRuleListResponseBodyAlarms : TeaModel {
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleListResponseBodyAlarmsAlarm> Alarm { get; set; }
            public class DescribeMetricRuleListResponseBodyAlarmsAlarm : TeaModel {
                public int? SilenceTime { get; set; }
                public string MetricName { get; set; }
                public string Webhook { get; set; }
                public string ContactGroups { get; set; }
                public string SourceType { get; set; }
                public string Namespace { get; set; }
                public string MailSubject { get; set; }
                public string NoEffectiveInterval { get; set; }
                public string EffectiveInterval { get; set; }
                public string RuleName { get; set; }
                public string AlertState { get; set; }
                public string Period { get; set; }
                public string RuleId { get; set; }
                public string GroupName { get; set; }
                public string GroupId { get; set; }
                public string Dimensions { get; set; }
                public bool? EnableState { get; set; }
                public string Resources { get; set; }
                public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalations Escalations { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalations : TeaModel {
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
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }
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
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }
                    };

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
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }
                    };

                }
            }
        };

    }

}
