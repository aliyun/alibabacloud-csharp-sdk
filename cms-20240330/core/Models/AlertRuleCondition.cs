// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleCondition : TeaModel {
        /// <summary>
        /// <para>Applicable condition type: SLS_CONDITION.
        /// Number of times the condition must be met before triggering an alert, default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("alertCount")]
        [Validation(Required=false)]
        public int? AlertCount { get; set; }

        /// <summary>
        /// <para>Applicable condition type: SLS_CONDITION.
        /// SLS alert condition list.</para>
        /// </summary>
        [NameInMap("caseList")]
        [Validation(Required=false)]
        public List<AlertRuleConditionCaseList> CaseList { get; set; }
        public class AlertRuleConditionCaseList : TeaModel {
            /// <summary>
            /// <para>Matching expression, example: logLevel: error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logLevel: error</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>Count matching expression, examples: range combination: count &gt;= 3 &amp;&amp; count &lt;= 10; single range: count &gt;= 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>count &gt;= 3</para>
            /// </summary>
            [NameInMap("countCondition")]
            [Validation(Required=false)]
            public string CountCondition { get; set; }

            /// <summary>
            /// <para>Alert severity level after condition is met.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>Matching type: Has data / Has a specific number of data entries / Has matching data / Has a specific number of matching entries.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HasData: Has data.</description></item>
            /// <item><description>HasDataCount: Has a specific number of data entries.</description></item>
            /// <item><description>HasDataMatch: Has matching data.</description></item>
            /// <item><description>HasDataMatchCount: Has a specific number of matching entries.</description></item>
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
        /// <para>Applicable condition type: APM_CONDITION.
        /// APM alert comparison condition list.</para>
        /// </summary>
        [NameInMap("compareList")]
        [Validation(Required=false)]
        public List<AlertRuleConditionCompareList> CompareList { get; set; }
        public class AlertRuleConditionCompareList : TeaModel {
            /// <summary>
            /// <para>Time series post-aggregation functions:</para>
            /// <list type="bullet">
            /// <item><description>count</description></item>
            /// <item><description>sum </description></item>
            /// <item><description>avg</description></item>
            /// <item><description>min</description></item>
            /// <item><description>max</description></item>
            /// <item><description>p90</description></item>
            /// <item><description>p95</description></item>
            /// <item><description>p99</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>count</para>
            /// </summary>
            [NameInMap("aggregate")]
            [Validation(Required=false)]
            public string Aggregate { get; set; }

            /// <summary>
            /// <para>Data unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("baseUnit")]
            [Validation(Required=false)]
            public string BaseUnit { get; set; }

            /// <summary>
            /// <para>Display unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("displayUnit")]
            [Validation(Required=false)]
            public string DisplayUnit { get; set; }

            /// <summary>
            /// <para>Comparison operations to determine whether it is year-over-year (YoY) or month-over-month (MoM):</para>
            /// <list type="bullet">
            /// <item><description>Greater than (GT),</description></item>
            /// <item><description>Greater than or equal to (GTE),</description></item>
            /// <item><description>Less than (LT),</description></item>
            /// <item><description>Less than or equal to (LTE),</description></item>
            /// <item><description>Equal to (EQ),</description></item>
            /// <item><description>Not equal to (NE),</description></item>
            /// <item><description>Year-over-year increase (YOY_UP),</description></item>
            /// <item><description>Year-over-year decrease (YOY_DOWN).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GT</para>
            /// </summary>
            [NameInMap("oper")]
            [Validation(Required=false)]
            public string Oper { get; set; }

            /// <summary>
            /// <para>Comparison threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

            /// <summary>
            /// <para>List of alert severity levels for different values.</para>
            /// </summary>
            [NameInMap("valueLevelList")]
            [Validation(Required=false)]
            public List<AlertRuleConditionCompareListValueLevelList> ValueLevelList { get; set; }
            public class AlertRuleConditionCompareListValueLevelList : TeaModel {
                /// <summary>
                /// <para>Severity level corresponding to the threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>Comparison threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// <para>Year-over-year time unit (only applicable when oper=YOY_UP/YOY_DOWN): minute, hour, day, week, month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>month</para>
            /// </summary>
            [NameInMap("yoyTimeUnit")]
            [Validation(Required=false)]
            public string YoyTimeUnit { get; set; }

            /// <summary>
            /// <para>Year-over-year time value, used in conjunction with yoyTimeUnit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("yoyTimeValue")]
            [Validation(Required=false)]
            public int? YoyTimeValue { get; set; }

        }

        /// <summary>
        /// <para>Applicable condition type: CMS_BASIC_CONDITION.
        /// Valid only when escalationType=composite; composite metric alert condition.</para>
        /// </summary>
        [NameInMap("compositeEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionCompositeEscalation CompositeEscalation { get; set; }
        public class AlertRuleConditionCompositeEscalation : TeaModel {
            /// <summary>
            /// <para>List of multi-metric composite conditions.</para>
            /// </summary>
            [NameInMap("escalations")]
            [Validation(Required=false)]
            public List<AlertRuleConditionCompositeEscalationEscalations> Escalations { get; set; }
            public class AlertRuleConditionCompositeEscalationEscalations : TeaModel {
                /// <summary>
                /// <para>Threshold comparison operator, valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to.</description></item>
                /// <item><description>GreaterThanThreshold: greater than.</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to.</description></item>
                /// <item><description>LessThanThreshold: less than.</description></item>
                /// <item><description>NotEqualToThreshold: not equal to.</description></item>
                /// <item><description>EqualToThreshold: equal to.</description></item>
                /// <item><description>GreaterThanYesterday: increased compared to the same time yesterday.</description></item>
                /// <item><description>LessThanYesterday: decreased compared to the same time yesterday.</description></item>
                /// <item><description>GreaterThanLastWeek: increased compared to the same time last week.</description></item>
                /// <item><description>LessThanLastWeek: decreased compared to the same time last week.</description></item>
                /// <item><description>GreaterThanLastPeriod: increased compared to the previous period (MoM).</description></item>
                /// <item><description>LessThanLastPeriod: decreased compared to the previous period (MoM).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("comparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>Metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_total</para>
                /// </summary>
                [NameInMap("metricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>Metric time window.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                /// <summary>
                /// <para>Statistical method; the value of this parameter is determined by the Statistics column corresponding to the specified cloud product\&quot;s MetricName. This represents the statistical method for the monitoring metric. Example values:</para>
                /// <list type="bullet">
                /// <item><description>$Maximum: maximum value.</description></item>
                /// <item><description>$Minimum: minimum value.</description></item>
                /// <item><description>$Average: average value.</description></item>
                /// <item><description>$Availability: availability (typically used for site monitoring).
                /// Note: &quot;$&quot; is a unified prefix symbol for monitoring metrics.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>$Maximum</para>
                /// </summary>
                [NameInMap("statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>Alert threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("threshold")]
                [Validation(Required=false)]
                public double? Threshold { get; set; }

            }

            /// <summary>
            /// <para>Alert severity level triggered when the condition is met (multi-metric composite alerts support only one level).</para>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>Relationship between multiple metric conditions; valid values are &quot;and&quot; or &quot;or&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>and</para>
            /// </summary>
            [NameInMap("relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            /// <summary>
            /// <para>Number of times the condition must be met to trigger an alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>Applicable condition type: CMS_BASIC_CONDITION.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>simple: Simple metric condition,</description></item>
        /// <item><description>composite: Composite metric condition,</description></item>
        /// <item><description>express: Expression condition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>simple</para>
        /// </summary>
        [NameInMap("escalationType")]
        [Validation(Required=false)]
        public string EscalationType { get; set; }

        /// <summary>
        /// <para>Applicable condition type: CMS_BASIC_CONDITION.
        /// Valid only when escalationType=composite; multi-metric composite alert condition.</para>
        /// </summary>
        [NameInMap("expressEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionExpressEscalation ExpressEscalation { get; set; }
        public class AlertRuleConditionExpressEscalation : TeaModel {
            /// <summary>
            /// <para>Alert severity level triggered when the condition is met (expression-based alerts support only one level): </para>
            /// <list type="bullet">
            /// <item><description>CRITICAL </description></item>
            /// <item><description>WARNING </description></item>
            /// <item><description>INFO</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>Alert condition expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@cpu_total[60].$Average &gt; 60</para>
            /// </summary>
            [NameInMap("rawExpression")]
            [Validation(Required=false)]
            public string RawExpression { get; set; }

            /// <summary>
            /// <para>Number of times the condition must be met to trigger an alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>Applicable condition type: APM_CONDITION.
        /// Alert severity level when no data is available; if not specified, no alert will be triggered for missing data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("noDataAlertLevel")]
        [Validation(Required=false)]
        public string NoDataAlertLevel { get; set; }

        /// <summary>
        /// <para>Applicable condition type: APM_CONDITION.
        /// Fallback value when no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("noDataAppendValue")]
        [Validation(Required=false)]
        public string NoDataAppendValue { get; set; }

        /// <summary>
        /// <para>Applicable condition type: CMS_BASIC_CONDITION.
        /// Handling method when no monitoring data is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KEEP_LAST_STATE (default): No action is taken.</description></item>
        /// <item><description>INSUFFICIENT_DATA: Alert with &quot;insufficient data&quot; message.</description></item>
        /// <item><description>OK: Treat as normal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KEEP_LAST_STATE</para>
        /// </summary>
        [NameInMap("noDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        /// <summary>
        /// <para>Comparison operations to determine whether it is year-over-year (YoY) or month-over-month (MoM):</para>
        /// <list type="bullet">
        /// <item><description>Greater than (GT),</description></item>
        /// <item><description>Greater than or equal to (GTE),</description></item>
        /// <item><description>Less than (LT),</description></item>
        /// <item><description>Less than or equal to (LTE),</description></item>
        /// <item><description>Equal to (EQ),</description></item>
        /// <item><description>Not equal to (NE),</description></item>
        /// <item><description>Year-over-year increase (YOY_UP),</description></item>
        /// <item><description>Year-over-year decrease (YOY_DOWN).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LT</para>
        /// </summary>
        [NameInMap("oper")]
        [Validation(Required=false)]
        public string Oper { get; set; }

        /// <summary>
        /// <para>Applicable condition type: APM_CONDITION.
        /// Logical relationship between multiple conditions. Valid values: and, or.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>Applicable condition type: CMS_BASIC_CONDITION.
        /// Only valid when escalationType=simple; specifies the alert condition for a single metric.</para>
        /// </summary>
        [NameInMap("simpleEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionSimpleEscalation SimpleEscalation { get; set; }
        public class AlertRuleConditionSimpleEscalation : TeaModel {
            /// <summary>
            /// <para>List of conditions; for an alert rule with multiple severity levels, each level corresponds to one condition object.</para>
            /// </summary>
            [NameInMap("escalations")]
            [Validation(Required=false)]
            public List<AlertRuleConditionSimpleEscalationEscalations> Escalations { get; set; }
            public class AlertRuleConditionSimpleEscalationEscalations : TeaModel {
                /// <summary>
                /// <para>Threshold comparison operator, valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to.</description></item>
                /// <item><description>GreaterThanThreshold: greater than.</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to.</description></item>
                /// <item><description>LessThanThreshold: less than.</description></item>
                /// <item><description>NotEqualToThreshold: not equal to.</description></item>
                /// <item><description>EqualToThreshold: equal to.</description></item>
                /// <item><description>GreaterThanYesterday: increased compared to the same time yesterday.</description></item>
                /// <item><description>LessThanYesterday: decreased compared to the same time yesterday.</description></item>
                /// <item><description>GreaterThanLastWeek: increased compared to the same time last week.</description></item>
                /// <item><description>LessThanLastWeek: decreased compared to the same time last week.</description></item>
                /// <item><description>GreaterThanLastPeriod: increased compared to the previous period (MoM).</description></item>
                /// <item><description>LessThanLastPeriod: decreased compared to the previous period (MoM).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("comparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>Alert severity level triggered when the condition is met (expression-based alerts support only one level): </para>
                /// <list type="bullet">
                /// <item><description>CRITICAL </description></item>
                /// <item><description>WARNING </description></item>
                /// <item><description>INFO</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>Statistical method; the value of this parameter is determined by the Statistics column corresponding to the specified cloud product\&quot;s MetricName, for example: Maximum, Minimum, and Average.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>Alert threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("threshold")]
                [Validation(Required=false)]
                public double? Threshold { get; set; }

                /// <summary>
                /// <para>Number of times the condition must be met to trigger an alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            /// <summary>
            /// <para>Applicable condition type: CMS_BASIC_CONDITION.
            /// Metric associated with the alert condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>Metric time window, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

        }

        /// <summary>
        /// <para>Rule condition type, valid values:</para>
        /// <para>SLS_CONDITION (SLS alert condition),
        /// APM_CONDITION (APM alert condition),
        /// CMS_BASIC_CONDITION (Basic Cloud Monitoring alert condition).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS_CONDITION</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Alert triggering threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public double? Value { get; set; }

    }

}
