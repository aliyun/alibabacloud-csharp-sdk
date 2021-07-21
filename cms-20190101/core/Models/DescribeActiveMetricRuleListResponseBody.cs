// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeActiveMetricRuleListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeActiveMetricRuleListResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeActiveMetricRuleListResponseBodyDatapoints : TeaModel {
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public List<DescribeActiveMetricRuleListResponseBodyDatapointsAlarm> Alarm { get; set; }
            public class DescribeActiveMetricRuleListResponseBodyDatapointsAlarm : TeaModel {
                public string SilenceTime { get; set; }
                public string MetricName { get; set; }
                public string EvaluationCount { get; set; }
                public string Webhook { get; set; }
                public string State { get; set; }
                public string ContactGroups { get; set; }
                public string Namespace { get; set; }
                public string RuleName { get; set; }
                public string RuleId { get; set; }
                public string Period { get; set; }
                public string ComparisonOperator { get; set; }
                public string EndTime { get; set; }
                public string StartTime { get; set; }
                public string Threshold { get; set; }
                public string Statistics { get; set; }
                public string Enable { get; set; }
            }
        };

        [NameInMap("AlertList")]
        [Validation(Required=false)]
        public DescribeActiveMetricRuleListResponseBodyAlertList AlertList { get; set; }
        public class DescribeActiveMetricRuleListResponseBodyAlertList : TeaModel {
            [NameInMap("Alert")]
            [Validation(Required=false)]
            public List<DescribeActiveMetricRuleListResponseBodyAlertListAlert> Alert { get; set; }
            public class DescribeActiveMetricRuleListResponseBodyAlertListAlert : TeaModel {
                public string SilenceTime { get; set; }
                public string MetricName { get; set; }
                public string Webhook { get; set; }
                public string ContactGroups { get; set; }
                public string Namespace { get; set; }
                public string EffectiveInterval { get; set; }
                public string NoEffectiveInterval { get; set; }
                public string MailSubject { get; set; }
                public string RuleName { get; set; }
                public string RuleId { get; set; }
                public string Period { get; set; }
                public string AlertState { get; set; }
                public string Dimensions { get; set; }
                public bool? EnableState { get; set; }
                public string Resources { get; set; }
                public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalations Escalations { get; set; }
                public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalations : TeaModel {
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsInfo Info { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsInfo : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }
                    };

                    [NameInMap("Warn")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsWarn Warn { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsWarn : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }
                    };

                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsCritical Critical { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsCritical : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }
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
