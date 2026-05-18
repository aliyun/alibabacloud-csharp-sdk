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
                [NameInMap("AlertState")]
                [Validation(Required=false)]
                public string AlertState { get; set; }

                [NameInMap("CompositeExpression")]
                [Validation(Required=false)]
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
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

                            [NameInMap("MetricName")]
                            [Validation(Required=false)]
                            public string MetricName { get; set; }

                            [NameInMap("Period")]
                            [Validation(Required=false)]
                            public int? Period { get; set; }

                            [NameInMap("Statistics")]
                            [Validation(Required=false)]
                            public string Statistics { get; set; }

                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public string Threshold { get; set; }

                        }

                    }

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

                    }

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

                    }

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

                    }

                }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtUpdate")]
                [Validation(Required=false)]
                public string GmtUpdate { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
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

                [NameInMap("MailSubject")]
                [Validation(Required=false)]
                public string MailSubject { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("NoDataPolicy")]
                [Validation(Required=false)]
                public string NoDataPolicy { get; set; }

                [NameInMap("NoEffectiveInterval")]
                [Validation(Required=false)]
                public string NoEffectiveInterval { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                [NameInMap("ProductCategory")]
                [Validation(Required=false)]
                public string ProductCategory { get; set; }

                [NameInMap("Prometheus")]
                [Validation(Required=false)]
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
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

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
                public int? SilenceTime { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the call is successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>386C6712-335F-5054-930A-CC92B851ECBA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
