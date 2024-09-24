// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeActiveMetricRuleListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the alert rules. The result is in the same structure as that returned by the DescribeMetricRuleList operation.</para>
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
                /// <para>The status of the alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OK: The alert rule has no active alerts.</description></item>
                /// <item><description>ALARM: The alert rule has active alerts.</description></item>
                /// <item><description>INSUFFICIENT_DATA: No data is found.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("AlertState")]
                [Validation(Required=false)]
                public string AlertState { get; set; }

                /// <summary>
                /// <para>The alert contact group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_Group</para>
                /// </summary>
                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public string ContactGroups { get; set; }

                /// <summary>
                /// <para>The monitoring data of the specified resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// <para>The time period during which the alert rule is effective.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00-23:59</para>
                /// </summary>
                [NameInMap("EffectiveInterval")]
                [Validation(Required=false)]
                public string EffectiveInterval { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The alert rule is enabled.</description></item>
                /// <item><description>false: The alert rule is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableState")]
                [Validation(Required=false)]
                public bool? EnableState { get; set; }

                /// <summary>
                /// <para>The conditions for triggering different levels of alerts.</para>
                /// </summary>
                [NameInMap("Escalations")]
                [Validation(Required=false)]
                public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalations Escalations { get; set; }
                public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalations : TeaModel {
                    /// <summary>
                    /// <para>The trigger condition for Critical-level alerts.</para>
                    /// </summary>
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsCritical Critical { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsCritical : TeaModel {
                        /// <summary>
                        /// <para>The operator that is used to compare the metric value with the threshold for Critical-level alerts. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                        /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                        /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                        /// <item><description>LessThanThreshold: less than the threshold</description></item>
                        /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                        /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                        /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                        /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                        /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                        /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                        /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GreaterThanThreshold</para>
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// <para>The statistical methods for Critical-level alerts.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Average</para>
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// <para>The threshold for Critical-level alerts.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>99</para>
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// <para>The consecutive number of times for which the metric value meets the alert condition before a Critical-level alert is triggered.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                    /// <summary>
                    /// <para>The conditions for triggering Info-level alerts.</para>
                    /// </summary>
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsInfo Info { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsInfo : TeaModel {
                        /// <summary>
                        /// <para>The operator that is used to compare the metric value with the threshold for Info-level alerts. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                        /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                        /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                        /// <item><description>LessThanThreshold: less than the threshold</description></item>
                        /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                        /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                        /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                        /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                        /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                        /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                        /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GreaterThanThreshold</para>
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// <para>The statistical methods for Info-level alerts.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Average</para>
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// <para>The threshold for Info-level alerts.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>95</para>
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// <para>The consecutive number of times</para>
                        /// <para>for which the metric value meets the alert condition before an Info-level alert is triggered.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                    /// <summary>
                    /// <para>The conditions for triggering Warn-level alerts.</para>
                    /// </summary>
                    [NameInMap("Warn")]
                    [Validation(Required=false)]
                    public DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsWarn Warn { get; set; }
                    public class DescribeActiveMetricRuleListResponseBodyAlertListAlertEscalationsWarn : TeaModel {
                        /// <summary>
                        /// <para>The operator that is used to compare the metric value with the threshold for Warn-level alerts. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                        /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                        /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                        /// <item><description>LessThanThreshold: less than the threshold</description></item>
                        /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                        /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                        /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                        /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                        /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                        /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                        /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GreaterThanThreshold</para>
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// <para>The statistical methods for Warn-level alerts.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Average</para>
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// <para>The threshold for Warn-level alerts.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80</para>
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// <para>The consecutive number of times</para>
                        /// <para>for which the metric value meets the alert condition before a Warn-level alert is triggered.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                }

                /// <summary>
                /// <para>The subject of the alert notification email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_Bucket</para>
                /// </summary>
                [NameInMap("MailSubject")]
                [Validation(Required=false)]
                public string MailSubject { get; set; }

                /// <summary>
                /// <para>The name of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_total</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The namespace of the Alibaba Cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_ecs_dashboard</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The time period during which the alert rule is ineffective.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00-06:00</para>
                /// </summary>
                [NameInMap("NoEffectiveInterval")]
                [Validation(Required=false)]
                public string NoEffectiveInterval { get; set; }

                /// <summary>
                /// <para>The aggregation period of monitoring data.</para>
                /// <para>Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// <para>The resources that are associated with the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;resource&quot;:&quot;_ALL&quot;}]</para>
                /// </summary>
                [NameInMap("Resources")]
                [Validation(Required=false)]
                public string Resources { get; set; }

                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ruleIdxxxx</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myAlert</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The mute period during which new alerts are not sent even if the trigger conditions are met.</para>
                /// <para>Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public string SilenceTime { get; set; }

                /// <summary>
                /// <para>The callback URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
                /// </summary>
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

        /// <summary>
        /// <para>The details of the alert rules.</para>
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
                /// <para>The comparison operator that is used in the alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>&gt;</c></description></item>
                /// <item><description><c>&lt;</c></description></item>
                /// <item><description><c>&gt;=</c></description></item>
                /// <item><description><c>&lt;=</c></description></item>
                /// <item><description><c>=</c></description></item>
                /// <item><description><c>=</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <remarks>
                /// </remarks>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The alert contact group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_Group</para>
                /// </summary>
                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public string ContactGroups { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The alert rule is enabled.</description></item>
                /// <item><description>false: The alert rule is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The end of the time period during which the alert rule is effective.</para>
                /// <para>Unit: hours. For example, the value 23 indicates <c>23:59:59</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public string EvaluationCount { get; set; }

                /// <summary>
                /// <para>The metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_total</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The namespace of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_ecs_dashboard</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The aggregation period of monitoring data.</para>
                /// <para>Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a151cd6023eacee2f0978e03863cc1697c89508****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SystemDefault_acs_rds_dashboard_CpuUsage</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The mute period during which new alerts are not sent even if the trigger conditions are met.</para>
                /// <para>Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public string SilenceTime { get; set; }

                /// <summary>
                /// <para>The beginning of the time period during which the alert rule is effective.</para>
                /// <para>Unit: hours. For example, the value 00 indicates <c>00:00:00</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert rule is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The statistical method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The alert threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>The callback URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
                /// </summary>
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
