// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeActiveMetricRuleListResponseBody : TeaModel {
        [NameInMap("AlertList")]
        [Validation(Required=false)]
        public DescribeActiveMetricRuleListResponseBodyAlertList AlertList { get; set; }
        public class DescribeActiveMetricRuleListResponseBodyAlertList : TeaModel {
            [NameInMap("Alert")]
            [Validation(Required=false)]
            public List<DescribeActiveMetricRuleListResponseBodyAlertListAlert> Alert { get; set; }
            public class DescribeActiveMetricRuleListResponseBodyAlertListAlert : TeaModel {
                [NameInMap("AlertState")]
                [Validation(Required=false)]
                public string AlertState { get; set; }

                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public string ContactGroups { get; set; }

                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                [NameInMap("EffectiveInterval")]
                [Validation(Required=false)]
                public string EffectiveInterval { get; set; }

                [NameInMap("EnableState")]
                [Validation(Required=false)]
                public bool? EnableState { get; set; }

                [NameInMap("Escalations")]
                [Validation(Required=false)]
                public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalations Escalations { get; set; }
                public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalations : TeaModel {
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsCritical Critical { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsCritical : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsInfo Info { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsInfo : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                    [NameInMap("Warn")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsWarn Warn { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsWarn : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                }

                [NameInMap("MailSubject")]
                [Validation(Required=false)]
                public string MailSubject { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("NoEffectiveInterval")]
                [Validation(Required=false)]
                public string NoEffectiveInterval { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                [NameInMap("Resources")]
                [Validation(Required=false)]
                public string Resources { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public string SilenceTime { get; set; }

                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeActiveMetricRuleListResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeActiveMetricRuleListResponseBodyDatapoints : TeaModel {
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public List<DescribeActiveMetricRuleListResponseBodyDatapointsAlarm> Alarm { get; set; }
            public class DescribeActiveMetricRuleListResponseBodyDatapointsAlarm : TeaModel {
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public string ContactGroups { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public string EvaluationCount { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public string SilenceTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F82E6667-7811-4BA0-842F-5B2DC42BBAAD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
