// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleListResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert rules.</para>
        /// </summary>
        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public DescribeMetricRuleListResponseBodyAlarms Alarms { get; set; }
        public class DescribeMetricRuleListResponseBodyAlarms : TeaModel {
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleListResponseBodyAlarmsAlarm> Alarm { get; set; }
            public class DescribeMetricRuleListResponseBodyAlarmsAlarm : TeaModel {
                /// <summary>
                /// <para>The status of the alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OK: The alert rule has no active alerts.</description></item>
                /// <item><description>ALARM: The alert rule has active alerts.</description></item>
                /// <item><description>INSUFFICIENT_DATA: No data is available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("AlertState")]
                [Validation(Required=false)]
                public string AlertState { get; set; }

                /// <summary>
                /// <para>The trigger conditions for multiple metrics.</para>
                /// <remarks>
                /// <para> The trigger conditions for a single metric and multiple metrics are mutually exclusive. You cannot specify trigger conditions for a single metric and multiple metrics at the same time.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("CompositeExpression")]
                [Validation(Required=false)]
                public DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpression CompositeExpression { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpression : TeaModel {
                    /// <summary>
                    /// <para>The trigger conditions that are created in standard mode.</para>
                    /// </summary>
                    [NameInMap("ExpressionList")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionList ExpressionList { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionList : TeaModel {
                        [NameInMap("ExpressionList")]
                        [Validation(Required=false)]
                        public List<DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionListExpressionList> ExpressionList { get; set; }
                        public class DescribeMetricRuleListResponseBodyAlarmsAlarmCompositeExpressionExpressionListExpressionList : TeaModel {
                            /// <summary>
                            /// <para>The operator that is used to compare the metric value with the threshold. Valid values:</para>
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
                            /// <para>GreaterThanOrEqualToThreshold</para>
                            /// </summary>
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

                            /// <summary>
                            /// <para>The metric that is used to monitor the cloud service.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>cpu_total</para>
                            /// </summary>
                            [NameInMap("MetricName")]
                            [Validation(Required=false)]
                            public string MetricName { get; set; }

                            /// <summary>
                            /// <para>The aggregation period of the metric.</para>
                            /// <para>Unit: seconds.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>60</para>
                            /// </summary>
                            [NameInMap("Period")]
                            [Validation(Required=false)]
                            public int? Period { get; set; }

                            /// <summary>
                            /// <para>The statistical method of the metric. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>$Maximum: the maximum value</description></item>
                            /// <item><description>$Minimum: the minimum value</description></item>
                            /// <item><description>$Average: the average value</description></item>
                            /// <item><description>$Availability: the availability rate (usually used for site monitoring)</description></item>
                            /// </list>
                            /// <remarks>
                            /// <para> <c>$</c> is the prefix of the metric. For information about the Alibaba Cloud services that are supported by CloudMonitor, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>$Maximum</para>
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

                        }

                    }

                    /// <summary>
                    /// <para>The relationship between the trigger conditions for multiple metrics. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>&amp;&amp;</c>: An alert is triggered only if all metrics meet the trigger conditions. An alert is triggered only if the results of all expressions specified in the ExpressionList parameter are <c>true</c>.</description></item>
                    /// <item><description><c>||</c>: An alert is triggered if one of the metrics meets the trigger conditions.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>||</para>
                    /// </summary>
                    [NameInMap("ExpressionListJoin")]
                    [Validation(Required=false)]
                    public string ExpressionListJoin { get; set; }

                    /// <summary>
                    /// <para>The trigger conditions that are created by using expressions. You can use expressions to create trigger conditions in the following scenarios:</para>
                    /// <list type="bullet">
                    /// <item><description>Set an alert blacklist for specific resources. For example, if you specify <c>$instanceId != \\&quot;i-io8kfvcpp7x5****\\&quot; ``&amp;&amp;`` $Average &gt; 50</c>, no alert is triggered when the <c>average metric value</c> of the <c>i-io8kfvcpp7x5****</c> instance exceeds 50.</description></item>
                    /// <item><description>Set a special alert threshold for a specified instance in the rule. For example, if you specify <c>$Average &gt; ($instanceId == \\&quot;i-io8kfvcpp7x5****\\&quot;? 80: 50)</c>, an alert is triggered when the <c>average metric value</c> of the <c>i-io8kfvcpp7x5****</c> instance exceeds 80 or the <c>average metric value</c> of other instances exceeds 50.</description></item>
                    /// <item><description>Limit the number of instances whose metric values exceed the threshold. For example, if you specify <c>count($Average &gt; 20) &gt; 3</c>, an alert is triggered only when the number of instances whose <c>average metric value</c> exceeds 20 exceeds three.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$Average &gt; ($instanceId == \&quot;i-io8kfvcpp7x5****\&quot;? 80: 50)</para>
                    /// </summary>
                    [NameInMap("ExpressionRaw")]
                    [Validation(Required=false)]
                    public string ExpressionRaw { get; set; }

                    /// <summary>
                    /// <para>The alert level. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CRITICAL</description></item>
                    /// <item><description>WARN</description></item>
                    /// <item><description>INFO</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Critical</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The number of consecutive triggers. If the number of times that the metric values meet the trigger conditions reaches the value of this parameter, CloudMonitor sends alert notifications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                /// <summary>
                /// <para>The alert contact group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_Alarm</para>
                /// </summary>
                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public string ContactGroups { get; set; }

                /// <summary>
                /// <para>The dimensions of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;instanceId&quot;:&quot;i-2ze2d6j5uhg20x47****&quot;}]</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// <para>The time period during which the alert rule is effective.</para>
                /// 
                /// <b>Example:</b>
                /// <para>05:31-23:59</para>
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
                public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalations Escalations { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalations : TeaModel {
                    /// <summary>
                    /// <para>The conditions for triggering Critical-level alerts.</para>
                    /// </summary>
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsCritical Critical { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsCritical : TeaModel {
                        /// <summary>
                        /// <para>The comparison operator that is used to compare the metric value with the threshold. Valid values:</para>
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
                        /// <para>GreaterThanOrEqualToThreshold</para>
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// <para>The additional conditions for triggering Critical-level alerts. The additional conditions take effect when the value of the ComparisonOperator parameter is GreaterThanYesterday, LessThanYesterday, GreaterThanLastWeek, LessThanLastWeek, GreaterThanLastPeriod, or LessThanLastPeriod.</para>
                        /// <para>For example, the values of the PreCondition, ComparisonOperator, and Threshold parameters are set to $Average&gt;80, GreaterThanYesterday, and 10, respectively. An alert is triggered only when the average metric value is greater than 80 and 10% greater than the average metric value at the same time yesterday.</para>
                        /// <remarks>
                        /// <para> $Average is a placeholder that consists of <c>a dollar sign ($) and the statistical method</c>. CloudMonitor replaces the placeholder with the aggregated value or original value before value comparison.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$Average&gt;80</para>
                        /// </summary>
                        [NameInMap("PreCondition")]
                        [Validation(Required=false)]
                        public string PreCondition { get; set; }

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
                        /// <para>90</para>
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
                        public int? Times { get; set; }

                    }

                    /// <summary>
                    /// <para>The conditions for triggering Info-level alerts.</para>
                    /// </summary>
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsInfo Info { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsInfo : TeaModel {
                        /// <summary>
                        /// <para>The comparison operator that is used to compare the metric value with the threshold. Valid values:</para>
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
                        /// <para>GreaterThanOrEqualToThreshold</para>
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// <para>The additional conditions for triggering Info-level alerts. The additional conditions take effect when the value of the ComparisonOperator parameter is GreaterThanYesterday, LessThanYesterday, GreaterThanLastWeek, LessThanLastWeek, GreaterThanLastPeriod, or LessThanLastPeriod.</para>
                        /// <para>For example, the values of the PreCondition, ComparisonOperator, and Threshold parameters are set to $Average&gt;80, GreaterThanYesterday, and 10, respectively. An alert is triggered only when the average metric value is greater than 80 and 10% greater than the average metric value at the same time yesterday.</para>
                        /// <remarks>
                        /// <para> $Average is a placeholder that consists of <c>a dollar sign ($) and the statistical method</c>. CloudMonitor replaces the placeholder with the aggregated value or original value before value comparison.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$Average&gt;80</para>
                        /// </summary>
                        [NameInMap("PreCondition")]
                        [Validation(Required=false)]
                        public string PreCondition { get; set; }

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
                        /// <para>90</para>
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// <para>The consecutive number of times for which the metric value meets the alert condition before an Info-level alert is triggered.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }

                    }

                    /// <summary>
                    /// <para>The conditions for triggering Warn-level alerts.</para>
                    /// </summary>
                    [NameInMap("Warn")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsWarn Warn { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmEscalationsWarn : TeaModel {
                        /// <summary>
                        /// <para>The comparison operator that is used to compare the metric value with the threshold. Valid values:</para>
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
                        /// <para>GreaterThanOrEqualToThreshold</para>
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// <para>The additional conditions for triggering Warn-level alerts. The additional conditions take effect when the value of the ComparisonOperator parameter is GreaterThanYesterday, LessThanYesterday, GreaterThanLastWeek, LessThanLastWeek, GreaterThanLastPeriod, or LessThanLastPeriod.</para>
                        /// <para>For example, the values of the PreCondition, ComparisonOperator, and Threshold parameters are set to $Average&gt;80, GreaterThanYesterday, and 10, respectively. An alert is triggered only when the average metric value is greater than 80 and 10% greater than the average metric value at the same time yesterday.</para>
                        /// <remarks>
                        /// <para> $Average is a placeholder that consists of <c>a dollar sign ($) and the statistical method</c>. CloudMonitor replaces the placeholder with the aggregated value or original value before value comparison.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$Average&gt;80</para>
                        /// </summary>
                        [NameInMap("PreCondition")]
                        [Validation(Required=false)]
                        public string PreCondition { get; set; }

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
                        /// <para>90</para>
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// <para>The consecutive number of times for which the metric value meets the alert condition before a Warn-level alert is triggered.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the application group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7301****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the application group.</para>
                /// <remarks>
                /// <para> If the alert rule is associated with an application group, the name of the application group is returned in this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_Group</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The tags of the alert rule.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public DescribeMetricRuleListResponseBodyAlarmsAlarmLabels Labels { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmLabels : TeaModel {
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public List<DescribeMetricRuleListResponseBodyAlarmsAlarmLabelsLabels> Labels { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmLabelsLabels : TeaModel {
                        /// <summary>
                        /// <para>The tag key of the alert rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cmsRuleKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value of the alert rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cmsRuleValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The subject of the alert notification email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;${serviceType}-${metricName}-${levelDescription}Notification(${dimensions})&quot;</para>
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
                /// <para>The namespace of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_ecs_dashboard</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The method that is used to handle alerts when no monitoring data is found. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>KEEP_LAST_STATE (default value): No operation is performed.</description></item>
                /// <item><description>INSUFFICIENT_DATA: An alert whose content is &quot;Insufficient data&quot; is triggered.</description></item>
                /// <item><description>OK: The status is considered normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>KEEP_LAST_STATE</para>
                /// </summary>
                [NameInMap("NoDataPolicy")]
                [Validation(Required=false)]
                public string NoDataPolicy { get; set; }

                /// <summary>
                /// <para>The time period during which the alert rule is ineffective.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00-05:30</para>
                /// </summary>
                [NameInMap("NoEffectiveInterval")]
                [Validation(Required=false)]
                public string NoEffectiveInterval { get; set; }

                /// <summary>
                /// <para>The statistical period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// <para>The Prometheus alerts.</para>
                /// <remarks>
                /// <para> This parameter is required only if you create a Prometheus alert rule for Hybrid Cloud Monitoring.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Prometheus")]
                [Validation(Required=false)]
                public DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheus Prometheus { get; set; }
                public class DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheus : TeaModel {
                    /// <summary>
                    /// <para>The annotations of the Prometheus alert rule. When a Prometheus alert is triggered, the system renders the annotated keys and values to help you understand the metrics and alert rule.</para>
                    /// <remarks>
                    /// <para> This parameter is equivalent to the annotations parameter of open source Prometheus.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Annotations")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotations Annotations { get; set; }
                    public class DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotations : TeaModel {
                        [NameInMap("Annotations")]
                        [Validation(Required=false)]
                        public List<DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotationsAnnotations> Annotations { get; set; }
                        public class DescribeMetricRuleListResponseBodyAlarmsAlarmPrometheusAnnotationsAnnotations : TeaModel {
                            /// <summary>
                            /// <para>The key of the annotation.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>summary</para>
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// <para>The value of the annotation.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{{ $labels.instance }} CPU usage above 10% {current value: {{ humanizePercentage $value }} }</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The alert level. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CRITICAL</description></item>
                    /// <item><description>WARN</description></item>
                    /// <item><description>INFO</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Critical</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The PromQL query statement.</para>
                    /// <remarks>
                    /// <para> The data obtained by using the PromQL query statement is the monitoring data. You must include the alert threshold in this statement.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CpuUsage{instanceId=&quot;xxxx&quot;}[1m]&gt;90</para>
                    /// </summary>
                    [NameInMap("PromQL")]
                    [Validation(Required=false)]
                    public string PromQL { get; set; }

                    /// <summary>
                    /// <para>The number of consecutive triggers. If the number of times that the metric values meet the trigger conditions reaches the value of this parameter, CloudMonitor sends alert notifications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public long? Times { get; set; }

                }

                /// <summary>
                /// <para>The resources that are associated with the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;instanceId\&quot;:\&quot;i-2ze2d6j5uhg20x47****\&quot;}]</para>
                /// </summary>
                [NameInMap("Resources")]
                [Validation(Required=false)]
                public string Resources { get; set; }

                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>applyTemplate344cfd42-0f32-4fd6-805a-88d7908a****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Rule_01</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The mute period during which new alert notifications are not sent even if the trigger conditions are met. Unit: seconds. Default value: 86400. Minimum value: 3600.</para>
                /// <para>Only one alert is reported during each mute period even if the metric value consecutively exceeds the alert rule threshold several times.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public int? SilenceTime { get; set; }

                /// <summary>
                /// <para>The type of the alert rule. Valid value: METRIC. This value indicates an alert rule for time series metrics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>METRIC</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The callback URL. CloudMonitor pushes an alert notification to the specified callback URL by sending an HTTP POST request. Only the HTTP protocol is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
                /// </summary>
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
