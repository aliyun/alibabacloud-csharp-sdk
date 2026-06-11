// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleCondition : TeaModel {
        /// <summary>
        /// <para>Applicable to the SLS_CONDITION type.</para>
        /// <para>The number of times the condition must be met to trigger an alert. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("alertCount")]
        [Validation(Required=false)]
        public int? AlertCount { get; set; }

        /// <summary>
        /// <para>Applicable to the SLS_CONDITION type.</para>
        /// <para>A list of SLS alert conditions.</para>
        /// </summary>
        [NameInMap("caseList")]
        [Validation(Required=false)]
        public List<AlertRuleConditionCaseList> CaseList { get; set; }
        public class AlertRuleConditionCaseList : TeaModel {
            /// <summary>
            /// <para>The matching expression. Example: logLevel: error</para>
            /// 
            /// <b>Example:</b>
            /// <para>logLevel: error</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The expression for matching a quantity. Examples:
            /// Combined range: <b>count</b> &gt;= 3 &amp;&amp; <b>count</b> &lt;= 10
            /// Single range: **count** &gt;= 3</para>
            /// 
            /// <b>Example:</b>
            /// <para>count &gt;= 3</para>
            /// </summary>
            [NameInMap("countCondition")]
            [Validation(Required=false)]
            public string CountCondition { get; set; }

            /// <summary>
            /// <para>The alert level when the condition is met.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The match type. It can be data availability, a specific number of data entries, a data match, or a specific number of data entry matches.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>HasData: Data is available.</para>
            /// </description></item>
            /// <item><description><para>HasDataCount: A specific number of data entries are available.</para>
            /// </description></item>
            /// <item><description><para>HasDataMatch: Data matches the condition.</para>
            /// </description></item>
            /// <item><description><para>HasDataMatchCount: A specific number of data entries match the condition.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HasData</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Applicable to the APM_CONDITION type.</para>
        /// <para>A list of Application Performance Management (APM) alert comparison conditions.</para>
        /// </summary>
        [NameInMap("compareList")]
        [Validation(Required=false)]
        public List<AlertRuleConditionCompareList> CompareList { get; set; }
        public class AlertRuleConditionCompareList : TeaModel {
            /// <summary>
            /// <para>The aggregate function for the time series.</para>
            /// <list type="bullet">
            /// <item><description><para>count</para>
            /// </description></item>
            /// <item><description><para>sum</para>
            /// </description></item>
            /// <item><description><para>avg</para>
            /// </description></item>
            /// <item><description><para>min</para>
            /// </description></item>
            /// <item><description><para>max</para>
            /// </description></item>
            /// <item><description><para>p90</para>
            /// </description></item>
            /// <item><description><para>p95</para>
            /// </description></item>
            /// <item><description><para>p99</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>count</para>
            /// </summary>
            [NameInMap("aggregate")]
            [Validation(Required=false)]
            public string Aggregate { get; set; }

            /// <summary>
            /// <para>The unit of the data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("baseUnit")]
            [Validation(Required=false)]
            public string BaseUnit { get; set; }

            /// <summary>
            /// <para>The unit for display.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("displayUnit")]
            [Validation(Required=false)]
            public string DisplayUnit { get; set; }

            /// <summary>
            /// <para>The comparison operation. It determines whether to perform a year-over-year or period-over-period comparison.</para>
            /// <list type="bullet">
            /// <item><description><para>GT: Greater than.</para>
            /// </description></item>
            /// <item><description><para>GTE: Greater than or equal to.</para>
            /// </description></item>
            /// <item><description><para>LT: Less than.</para>
            /// </description></item>
            /// <item><description><para>LTE: Less than or equal to.</para>
            /// </description></item>
            /// <item><description><para>EQ: Equal to.</para>
            /// </description></item>
            /// <item><description><para>NE: Not equal to.</para>
            /// </description></item>
            /// <item><description><para>YOY_UP: Year-over-year increase.</para>
            /// </description></item>
            /// <item><description><para>YOY_DOWN: Year-over-year decrease.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GT</para>
            /// </summary>
            [NameInMap("oper")]
            [Validation(Required=false)]
            public string Oper { get; set; }

            /// <summary>
            /// <para>The threshold for comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

            /// <summary>
            /// <para>A list of alert levels for different values.</para>
            /// </summary>
            [NameInMap("valueLevelList")]
            [Validation(Required=false)]
            public List<AlertRuleConditionCompareListValueLevelList> ValueLevelList { get; set; }
            public class AlertRuleConditionCompareListValueLevelList : TeaModel {
                /// <summary>
                /// <para>The level corresponding to the threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The threshold for comparison.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// <para>The time unit for year-over-year comparison. This parameter is valid only when oper is set to YOY_UP or YOY_DOWN. Valid values: minute, hour, day, week, and month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>month</para>
            /// </summary>
            [NameInMap("yoyTimeUnit")]
            [Validation(Required=false)]
            public string YoyTimeUnit { get; set; }

            /// <summary>
            /// <para>The time value for year-over-year comparison. Used with yoyTimeUnit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("yoyTimeValue")]
            [Validation(Required=false)]
            public int? YoyTimeValue { get; set; }

        }

        /// <summary>
        /// <para>Applicable to the CMS_BASIC_CONDITION type.</para>
        /// <para>This parameter is valid only when escalationType is set to composite. It specifies the alert condition for composite metrics.</para>
        /// </summary>
        [NameInMap("compositeEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionCompositeEscalation CompositeEscalation { get; set; }
        public class AlertRuleConditionCompositeEscalation : TeaModel {
            /// <summary>
            /// <para>A list of composite conditions for multiple metrics.</para>
            /// </summary>
            [NameInMap("escalations")]
            [Validation(Required=false)]
            public List<AlertRuleConditionCompositeEscalationEscalations> Escalations { get; set; }
            public class AlertRuleConditionCompositeEscalationEscalations : TeaModel {
                /// <summary>
                /// <para>The comparison operator for the threshold. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>GreaterThanOrEqualToThreshold: Greater than or equal to.</para>
                /// </description></item>
                /// <item><description><para>GreaterThanThreshold: Greater than.</para>
                /// </description></item>
                /// <item><description><para>LessThanOrEqualToThreshold: Less than or equal to.</para>
                /// </description></item>
                /// <item><description><para>LessThanThreshold: Less than.</para>
                /// </description></item>
                /// <item><description><para>NotEqualToThreshold: Not equal to.</para>
                /// </description></item>
                /// <item><description><para>EqualToThreshold: Equal to.</para>
                /// </description></item>
                /// <item><description><para>GreaterThanYesterday: Higher than the value at the same time yesterday.</para>
                /// </description></item>
                /// <item><description><para>LessThanYesterday: Lower than the value at the same time yesterday.</para>
                /// </description></item>
                /// <item><description><para>GreaterThanLastWeek: Higher than the value at the same time last week.</para>
                /// </description></item>
                /// <item><description><para>LessThanLastWeek: Lower than the value at the same time last week.</para>
                /// </description></item>
                /// <item><description><para>GreaterThanLastPeriod: Higher than the value in the previous period.</para>
                /// </description></item>
                /// <item><description><para>LessThanLastPeriod: Lower than the value in the previous period.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("comparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The name of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_total</para>
                /// </summary>
                [NameInMap("metricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The time window for the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                /// <summary>
                /// <para>The statistical method. The valid values for this parameter are determined by the Statistics column that corresponds to the MetricName of the specified cloud product. Examples of statistical methods for metrics:</para>
                /// <list type="bullet">
                /// <item><description><para>$Maximum: The maximum value.</para>
                /// </description></item>
                /// <item><description><para>$Minimum: The minimum value.</para>
                /// </description></item>
                /// <item><description><para>$Average: The average value.</para>
                /// </description></item>
                /// <item><description><para>$Availability: The availability rate. This is typically used for site monitoring.</para>
                /// </description></item>
                /// </list>
                /// <para>Note: The dollar sign ($) is a standard prefix for metrics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>$Maximum</para>
                /// </summary>
                [NameInMap("statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The alert threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("threshold")]
                [Validation(Required=false)]
                public double? Threshold { get; set; }

            }

            /// <summary>
            /// <para>The alert level that is triggered when the condition is met. Composite metric alerts support only one level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The relationship between multiple metric conditions. Valid values: and or or.</para>
            /// 
            /// <b>Example:</b>
            /// <para>and</para>
            /// </summary>
            [NameInMap("relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            /// <summary>
            /// <para>The number of times the condition must be met to trigger an alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        [NameInMap("enableSeveritySuppression")]
        [Validation(Required=false)]
        public bool? EnableSeveritySuppression { get; set; }

        /// <summary>
        /// <para>Applicable to the CMS_BASIC_CONDITION type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>simple: A simple metric condition.</para>
        /// </description></item>
        /// <item><description><para>composite: A composite metric condition.</para>
        /// </description></item>
        /// <item><description><para>express: An expression-based condition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>simple</para>
        /// </summary>
        [NameInMap("escalationType")]
        [Validation(Required=false)]
        public string EscalationType { get; set; }

        /// <summary>
        /// <para>This parameter is applicable only to the CMS_BASIC_CONDITION condition type.</para>
        /// <para>This parameter takes effect when escalationType is set to composite. It defines the conditions for a composite alert based on multiple metrics.</para>
        /// </summary>
        [NameInMap("expressEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionExpressEscalation ExpressEscalation { get; set; }
        public class AlertRuleConditionExpressEscalation : TeaModel {
            /// <summary>
            /// <para>The alert level that is triggered when the condition is met. Expression-based alerts support only one level.</para>
            /// <list type="bullet">
            /// <item><description><para>CRITICAL</para>
            /// </description></item>
            /// <item><description><para>WARNING</para>
            /// </description></item>
            /// <item><description><para>INFO</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The alert condition expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@cpu_total[60].$Average &gt; 60</para>
            /// </summary>
            [NameInMap("rawExpression")]
            [Validation(Required=false)]
            public string RawExpression { get; set; }

            /// <summary>
            /// <para>The number of times the condition must be met to trigger an alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>Applicable to the APM_CONDITION type.</para>
        /// <para>The alert level for when no data is available. If you do not specify this parameter, no alert is triggered when no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("noDataAlertLevel")]
        [Validation(Required=false)]
        public string NoDataAlertLevel { get; set; }

        /// <summary>
        /// <para>Applicable to the APM_CONDITION type.</para>
        /// <para>The value to use when no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("noDataAppendValue")]
        [Validation(Required=false)]
        public string NoDataAppendValue { get; set; }

        /// <summary>
        /// <para>Applicable to the CMS_BASIC_CONDITION type.</para>
        /// <para>The method for handling alerts when no monitoring data is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>KEEP_LAST_STATE (default): No action is taken.</para>
        /// </description></item>
        /// <item><description><para>INSUFFICIENT_DATA: The alert content indicates that no data is available.</para>
        /// </description></item>
        /// <item><description><para>OK: The status is normal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KEEP_LAST_STATE</para>
        /// </summary>
        [NameInMap("noDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        /// <summary>
        /// <para>The comparison operation. It determines whether to perform a year-over-year or period-over-period comparison.</para>
        /// <list type="bullet">
        /// <item><description><para>GT: Greater than.</para>
        /// </description></item>
        /// <item><description><para>GTE: Greater than or equal to.</para>
        /// </description></item>
        /// <item><description><para>LT: Less than.</para>
        /// </description></item>
        /// <item><description><para>LTE: Less than or equal to.</para>
        /// </description></item>
        /// <item><description><para>EQ: Equal to.</para>
        /// </description></item>
        /// <item><description><para>NE: Not equal to.</para>
        /// </description></item>
        /// <item><description><para>YOY_UP: Year-over-year increase.</para>
        /// </description></item>
        /// <item><description><para>YOY_DOWN: Year-over-year decrease.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LT</para>
        /// </summary>
        [NameInMap("oper")]
        [Validation(Required=false)]
        public string Oper { get; set; }

        /// <summary>
        /// <para>Applicable to the APM_CONDITION type.</para>
        /// <para>The logical relationship between multiple conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>and</para>
        /// </description></item>
        /// <item><description><para>or</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>Applicable to the CMS_BASIC_CONDITION type.</para>
        /// <para>This parameter is valid only when escalationType is set to simple. It specifies the alert condition for a single metric.</para>
        /// </summary>
        [NameInMap("simpleEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionSimpleEscalation SimpleEscalation { get; set; }
        public class AlertRuleConditionSimpleEscalation : TeaModel {
            /// <summary>
            /// <para>A list of conditions. If an alert rule has multiple levels, each level has a corresponding condition object.</para>
            /// </summary>
            [NameInMap("escalations")]
            [Validation(Required=false)]
            public List<AlertRuleConditionSimpleEscalationEscalations> Escalations { get; set; }
            public class AlertRuleConditionSimpleEscalationEscalations : TeaModel {
                /// <summary>
                /// <para>The comparison operator for the threshold. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>GreaterThanOrEqualToThreshold: Greater than or equal to.</para>
                /// </description></item>
                /// <item><description><para>GreaterThanThreshold: Greater than.</para>
                /// </description></item>
                /// <item><description><para>LessThanOrEqualToThreshold: Less than or equal to.</para>
                /// </description></item>
                /// <item><description><para>LessThanThreshold: Less than.</para>
                /// </description></item>
                /// <item><description><para>NotEqualToThreshold: Not equal to.</para>
                /// </description></item>
                /// <item><description><para>EqualToThreshold: Equal to.</para>
                /// </description></item>
                /// <item><description><para>GreaterThanYesterday: Higher than the value at the same time yesterday.</para>
                /// </description></item>
                /// <item><description><para>LessThanYesterday: Lower than the value at the same time yesterday.</para>
                /// </description></item>
                /// <item><description><para>GreaterThanLastWeek: Higher than the value at the same time last week.</para>
                /// </description></item>
                /// <item><description><para>LessThanLastWeek: Lower than the value at the same time last week.</para>
                /// </description></item>
                /// <item><description><para>GreaterThanLastPeriod: Higher than the value in the previous period.</para>
                /// </description></item>
                /// <item><description><para>LessThanLastPeriod: Lower than the value in the previous period.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("comparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The alert level that is triggered when the condition is met. Expression-based alerts support only one level.</para>
                /// <list type="bullet">
                /// <item><description><para>CRITICAL</para>
                /// </description></item>
                /// <item><description><para>WARNING</para>
                /// </description></item>
                /// <item><description><para>INFO</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The statistical method. The valid values for this parameter are determined by the Statistics column that corresponds to the MetricName of the specified cloud product. Examples: Maximum, Minimum, and Average.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The alert threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("threshold")]
                [Validation(Required=false)]
                public double? Threshold { get; set; }

                /// <summary>
                /// <para>The number of times the condition must be met to trigger an alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            /// <summary>
            /// <para>Applicable to the CMS_BASIC_CONDITION type.</para>
            /// <para>The metric associated with the alert condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The time window for the metric, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

        }

        [NameInMap("triggers")]
        [Validation(Required=false)]
        public List<AlertRuleConditionTriggers> Triggers { get; set; }
        public class AlertRuleConditionTriggers : TeaModel {
            [NameInMap("durationSecs")]
            [Validation(Required=false)]
            public int? DurationSecs { get; set; }

            [NameInMap("expression")]
            [Validation(Required=false)]
            public AlertRuleConditionTriggersExpression Expression { get; set; }
            public class AlertRuleConditionTriggersExpression : TeaModel {
                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<AlertRuleConditionTriggersExpressionConditions> Conditions { get; set; }
                public class AlertRuleConditionTriggersExpressionConditions : TeaModel {
                    [NameInMap("expressionType")]
                    [Validation(Required=false)]
                    public string ExpressionType { get; set; }

                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("queryName")]
                    [Validation(Required=false)]
                    public string QueryName { get; set; }

                    [NameInMap("threshold")]
                    [Validation(Required=false)]
                    public double? Threshold { get; set; }

                }

                [NameInMap("expressionType")]
                [Validation(Required=false)]
                public string ExpressionType { get; set; }

                [NameInMap("logicOperator")]
                [Validation(Required=false)]
                public string LogicOperator { get; set; }

            }

            [NameInMap("severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

        }

        /// <summary>
        /// <para>The type of the rule condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SLS_CONDITION: An SLS alert condition.</para>
        /// </description></item>
        /// <item><description><para>APM_CONDITION: An APM alert condition.</para>
        /// </description></item>
        /// <item><description><para>CMS_BASIC_CONDITION: A basic Cloud Monitor alert condition.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS_CONDITION</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The threshold that triggers an alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public double? Value { get; set; }

    }

}
