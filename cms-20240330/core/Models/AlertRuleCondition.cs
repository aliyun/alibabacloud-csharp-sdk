// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleCondition : TeaModel {
        /// <summary>
        /// <para>Applicable condition type: SLS_CONDITION.</para>
        /// <para>The number of times the condition must be met before an alert is triggered. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("alertCount")]
        [Validation(Required=false)]
        public int? AlertCount { get; set; }

        /// <summary>
        /// <para>Applicable condition type: SLS_CONDITION.</para>
        /// <para>The list of Simple Log Service (SLS) alert conditions.</para>
        /// </summary>
        [NameInMap("caseList")]
        [Validation(Required=false)]
        public List<AlertRuleConditionCaseList> CaseList { get; set; }
        public class AlertRuleConditionCaseList : TeaModel {
            /// <summary>
            /// <para>The match expression. Example: logLevel: error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logLevel: error</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The count match expression. Examples:
            /// Range combination: <b>count</b> &gt;= 3 &amp;&amp; <b>count</b> &lt;= 10
            /// Single range: __count__ &gt;= 3</para>
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
            /// <para>The match type: has data, has specific count of data, has data match, or has specific count of data match.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HasData: has data</description></item>
            /// <item><description>HasDataCount: has specific count of data</description></item>
            /// <item><description>HasDataMatch: has data match</description></item>
            /// <item><description>HasDataMatchCount: has specific count of data match</description></item>
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
        /// <para>Applicable condition type: APM_CONDITION.</para>
        /// <para>The list of Application Performance Monitoring (APM) alert comparison conditions.</para>
        /// </summary>
        [NameInMap("compareList")]
        [Validation(Required=false)]
        public List<AlertRuleConditionCompareList> CompareList { get; set; }
        public class AlertRuleConditionCompareList : TeaModel {
            /// <summary>
            /// <para>The aggregation function applied after time series.</para>
            /// <list type="bullet">
            /// <item><description>count</description></item>
            /// <item><description>sum</description></item>
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
            /// <para>The data unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("baseUnit")]
            [Validation(Required=false)]
            public string BaseUnit { get; set; }

            /// <summary>
            /// <para>The display unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("displayUnit")]
            [Validation(Required=false)]
            public string DisplayUnit { get; set; }

            /// <summary>
            /// <para>The comparison operator. Determines whether year-over-year or period-over-period comparison is used.</para>
            /// <list type="bullet">
            /// <item><description>Greater than: GT</description></item>
            /// <item><description>Greater than or equal to: GTE</description></item>
            /// <item><description>Less than: LT</description></item>
            /// <item><description>Less than or equal to: LTE</description></item>
            /// <item><description>Equal to: EQ</description></item>
            /// <item><description>Not equal to: NE</description></item>
            /// <item><description>Year-over-year increase: YOY_UP</description></item>
            /// <item><description>Year-over-year decrease: YOY_DOWN</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GT</para>
            /// </summary>
            [NameInMap("oper")]
            [Validation(Required=false)]
            public string Oper { get; set; }

            /// <summary>
            /// <para>The comparison threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

            /// <summary>
            /// <para>The list of alert levels for different values.</para>
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
                /// <para>The comparison threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// <para>The year-over-year time unit. Valid only when oper is set to YOY_UP or YOY_DOWN.
            /// Valid values: minute, hour, day, week, month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>month</para>
            /// </summary>
            [NameInMap("yoyTimeUnit")]
            [Validation(Required=false)]
            public string YoyTimeUnit { get; set; }

            /// <summary>
            /// <para>The year-over-year time value. Used together with yoyTimeUnit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("yoyTimeValue")]
            [Validation(Required=false)]
            public int? YoyTimeValue { get; set; }

        }

        /// <summary>
        /// <para>Applicable condition type: CMS_BASIC_CONDITION.</para>
        /// <para>Valid when escalationType is set to composite. The composite metric alert condition.</para>
        /// </summary>
        [NameInMap("compositeEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionCompositeEscalation CompositeEscalation { get; set; }
        public class AlertRuleConditionCompositeEscalation : TeaModel {
            /// <summary>
            /// <para>The list of composite conditions for multiple metrics.</para>
            /// </summary>
            [NameInMap("escalations")]
            [Validation(Required=false)]
            public List<AlertRuleConditionCompositeEscalationEscalations> Escalations { get; set; }
            public class AlertRuleConditionCompositeEscalationEscalations : TeaModel {
                /// <summary>
                /// <para>The threshold comparison operator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: Greater than or equal to.</description></item>
                /// <item><description>GreaterThanThreshold: Greater than.</description></item>
                /// <item><description>LessThanOrEqualToThreshold: Less than or equal to.</description></item>
                /// <item><description>LessThanThreshold: Less than.</description></item>
                /// <item><description>NotEqualToThreshold: Not equal to.</description></item>
                /// <item><description>EqualToThreshold: Equal to.</description></item>
                /// <item><description>GreaterThanYesterday: Year-over-year increase compared with the same time yesterday.</description></item>
                /// <item><description>LessThanYesterday: Year-over-year decrease compared with the same time yesterday.</description></item>
                /// <item><description>GreaterThanLastWeek: Year-over-year increase compared with the same time last week.</description></item>
                /// <item><description>LessThanLastWeek: Year-over-year decrease compared with the same time last week.</description></item>
                /// <item><description>GreaterThanLastPeriod: Period-over-period increase compared with the previous period.</description></item>
                /// <item><description>LessThanLastPeriod: Period-over-period decrease compared with the previous period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("comparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_total</para>
                /// </summary>
                [NameInMap("metricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The time window of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                /// <summary>
                /// <para>The statistical method. The value of this parameter is determined by the Statistics column corresponding to the MetricName of the specified cloud service. Example values for the statistical method of a metric:</para>
                /// <list type="bullet">
                /// <item><description>$Maximum: maximum value.</description></item>
                /// <item><description>$Minimum: minimum value.</description></item>
                /// <item><description>$Average: average value.</description></item>
                /// <item><description>$Availability: availability rate (typically used for site monitoring).</description></item>
                /// </list>
                /// <para>Note: $ is the unified prefix symbol for metrics.</para>
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
            /// <para>The alert level triggered when the condition is met. Composite metric alerts support only one level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The relationship between multiple metric conditions. Valid values: and, or.</para>
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

        /// <summary>
        /// <para>The count comparison operator, specified when type=LOG_SET_CONDITION. Valid values: GTE / GT / EQ / LTE / LT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GTE</para>
        /// </summary>
        [NameInMap("countOperator")]
        [Validation(Required=false)]
        public string CountOperator { get; set; }

        /// <summary>
        /// <para>The count threshold, specified when type=LOG_SET_CONDITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("countThreshold")]
        [Validation(Required=false)]
        public long? CountThreshold { get; set; }

        /// <summary>
        /// <para>Used when type=UMODEL_METRICSET_MULTI_CONDITION. Specifies whether to enable severity suppression to the highest level. Default value: true. Only the highest severity level is reported for the same entity.</para>
        /// </summary>
        [NameInMap("enableSeveritySuppression")]
        [Validation(Required=false)]
        public bool? EnableSeveritySuppression { get; set; }

        /// <summary>
        /// <para>Applicable condition type: CMS_BASIC_CONDITION.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>simple: simple metric condition</description></item>
        /// <item><description>composite: composite metric condition</description></item>
        /// <item><description>express: expression condition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>simple</para>
        /// </summary>
        [NameInMap("escalationType")]
        [Validation(Required=false)]
        public string EscalationType { get; set; }

        /// <summary>
        /// <para>Applicable condition type: CMS_BASIC_CONDITION.</para>
        /// <para>Valid when escalationType=composite. Specifies the multi-metric composite alert conditions.</para>
        /// </summary>
        [NameInMap("expressEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionExpressEscalation ExpressEscalation { get; set; }
        public class AlertRuleConditionExpressEscalation : TeaModel {
            /// <summary>
            /// <para>The alert level triggered when the condition is met. Expression-based alerts support only one level.</para>
            /// <list type="bullet">
            /// <item><description>CRITICAL</description></item>
            /// <item><description>WARNING</description></item>
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
            /// <para>The alert conditional expression.</para>
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
        /// <para>The log field name, specified when type=LOG_SET_CONDITION and matchOperator=CONTAINS/EQUALS/REGEX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logLevel</para>
        /// </summary>
        [NameInMap("matchField")]
        [Validation(Required=false)]
        public string MatchField { get; set; }

        /// <summary>
        /// <para>The match operator, specified when type=LOG_SET_CONDITION. Valid values: PRESENT / NOT_PRESENT / CONTAINS / EQUALS / REGEX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTAINS</para>
        /// </summary>
        [NameInMap("matchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        /// <summary>
        /// <para>The match value, specified when type=LOG_SET_CONDITION and matchOperator=CONTAINS/EQUALS/REGEX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("matchValue")]
        [Validation(Required=false)]
        public string MatchValue { get; set; }

        /// <summary>
        /// <para>The upper bound of the range specified when type=BASIC_CONDITION and oper=IN_RANGE/OUT_OF_RANGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The lower bound of the range specified when type=BASIC_CONDITION and oper=IN_RANGE/OUT_OF_RANGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>Applicable condition type: APM_CONDITION.</para>
        /// <para>The alert level when no data is available. If not specified, no alert is triggered for no-data scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("noDataAlertLevel")]
        [Validation(Required=false)]
        public string NoDataAlertLevel { get; set; }

        /// <summary>
        /// <para>Applicable condition type: APM_CONDITION.</para>
        /// <para>The value to use as compensation when no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("noDataAppendValue")]
        [Validation(Required=false)]
        public string NoDataAppendValue { get; set; }

        /// <summary>
        /// <para>Applicable condition type: CMS_BASIC_CONDITION.</para>
        /// <para>Specifies how to handle alerts when no monitoring data is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KEEP_LAST_STATE (default): No action is taken.</description></item>
        /// <item><description>INSUFFICIENT_DATA: The alert content indicates no data.</description></item>
        /// <item><description>OK: Normal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KEEP_LAST_STATE</para>
        /// </summary>
        [NameInMap("noDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        /// <summary>
        /// <para>The comparison operator. Determines whether year-over-year or period-over-period comparison is used.</para>
        /// <list type="bullet">
        /// <item><description>Greater than: GT</description></item>
        /// <item><description>Greater than or equal to: GTE</description></item>
        /// <item><description>Less than: LT</description></item>
        /// <item><description>Less than or equal to: LTE</description></item>
        /// <item><description>Equal to: EQ</description></item>
        /// <item><description>Not equal to: NE</description></item>
        /// <item><description>Year-over-year increase: YOY_UP</description></item>
        /// <item><description>Year-over-year decrease: YOY_DOWN</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LT</para>
        /// </summary>
        [NameInMap("oper")]
        [Validation(Required=false)]
        public string Oper { get; set; }

        /// <summary>
        /// <para>Applicable condition type: APM_CONDITION.</para>
        /// <para>The logical relationship between multiple conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>and</description></item>
        /// <item><description>or</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>Applicable condition type: CMS_BASIC_CONDITION.</para>
        /// <para>Valid only when escalationType is set to simple. The alert condition for a single metric.</para>
        /// </summary>
        [NameInMap("simpleEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionSimpleEscalation SimpleEscalation { get; set; }
        public class AlertRuleConditionSimpleEscalation : TeaModel {
            /// <summary>
            /// <para>The list of conditions. If an alert rule corresponds to multiple levels, each level has a condition object.</para>
            /// </summary>
            [NameInMap("escalations")]
            [Validation(Required=false)]
            public List<AlertRuleConditionSimpleEscalationEscalations> Escalations { get; set; }
            public class AlertRuleConditionSimpleEscalationEscalations : TeaModel {
                /// <summary>
                /// <para>The threshold comparison operator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: Greater than or equal to.</description></item>
                /// <item><description>GreaterThanThreshold: Greater than.</description></item>
                /// <item><description>LessThanOrEqualToThreshold: Less than or equal to.</description></item>
                /// <item><description>LessThanThreshold: Less than.</description></item>
                /// <item><description>NotEqualToThreshold: Not equal to.</description></item>
                /// <item><description>EqualToThreshold: Equal to.</description></item>
                /// <item><description>GreaterThanYesterday: Year-over-year increase compared with the same time yesterday.</description></item>
                /// <item><description>LessThanYesterday: Year-over-year decrease compared with the same time yesterday.</description></item>
                /// <item><description>GreaterThanLastWeek: Year-over-year increase compared with the same time last week.</description></item>
                /// <item><description>LessThanLastWeek: Year-over-year decrease compared with the same time last week.</description></item>
                /// <item><description>GreaterThanLastPeriod: Period-over-period increase compared with the previous period.</description></item>
                /// <item><description>LessThanLastPeriod: Period-over-period decrease compared with the previous period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("comparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The alert level triggered when the condition is met. Expression-based alerts support only one level.</para>
                /// <list type="bullet">
                /// <item><description>CRITICAL</description></item>
                /// <item><description>WARNING</description></item>
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
                /// <para>The statistical method. The valid values of this parameter are determined by the Statistics column corresponding to the MetricName of the specified cloud service. Examples: Maximum, Minimum, and Average.</para>
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
            /// <para>Applicable condition type: CMS_BASIC_CONDITION.</para>
            /// <para>The metric associated with the alert condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The time window of the metric, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

        }

        /// <summary>
        /// <para>The list of multi-level thresholds and severity levels, used to map different thresholds to corresponding alert levels.</para>
        /// </summary>
        [NameInMap("thresholdList")]
        [Validation(Required=false)]
        public List<AlertRuleConditionThresholdList> ThresholdList { get; set; }
        public class AlertRuleConditionThresholdList : TeaModel {
            /// <summary>
            /// <para>The upper bound of the range (required when operator=IN_RANGE/OUT_OF_RANGE).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("max")]
            [Validation(Required=false)]
            public double? Max { get; set; }

            /// <summary>
            /// <para>The lower bound of the range (required when operator=IN_RANGE/OUT_OF_RANGE).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("min")]
            [Validation(Required=false)]
            public double? Min { get; set; }

            /// <summary>
            /// <para>The severity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The threshold (required when the operator is not a range operator).</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("threshold")]
            [Validation(Required=false)]
            public double? Threshold { get; set; }

        }

        /// <summary>
        /// <para>Specified when type=UMODEL_METRICSET_MULTI_CONDITION. The list of trigger conditions. Each item contains severity, durationSecs, and an expression (SIMPLE for single-metric or COMPOSITE for multi-metric AND/OR/UNLESS).</para>
        /// </summary>
        [NameInMap("triggers")]
        [Validation(Required=false)]
        public List<AlertRuleConditionTriggers> Triggers { get; set; }
        public class AlertRuleConditionTriggers : TeaModel {
            /// <summary>
            /// <para>The duration in seconds that the condition must be continuously met before an alert is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("durationSecs")]
            [Validation(Required=false)]
            public int? DurationSecs { get; set; }

            /// <summary>
            /// <para>The expression of the trigger condition. Supports two forms: SIMPLE (single-metric) and COMPOSITE (multi-metric AND/OR/UNLESS combination).</para>
            /// </summary>
            [NameInMap("expression")]
            [Validation(Required=false)]
            public AlertRuleConditionTriggersExpression Expression { get; set; }
            public class AlertRuleConditionTriggersExpression : TeaModel {
                /// <summary>
                /// <para>The list of sub-conditions for the trigger condition. Multiple sub-conditions are evaluated based on the logicOperator of the parent expression.</para>
                /// </summary>
                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<AlertRuleConditionTriggersExpressionConditions> Conditions { get; set; }
                public class AlertRuleConditionTriggersExpressionConditions : TeaModel {
                    /// <summary>
                    /// <para>The conditional expression type of the sub-condition, typically SIMPLE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SIMPLE</para>
                    /// </summary>
                    [NameInMap("expressionType")]
                    [Validation(Required=false)]
                    public string ExpressionType { get; set; }

                    /// <summary>
                    /// <para>The comparison operator of the sub-condition, used to compare the query result with the threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GT</para>
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The query name referenced by the sub-condition, corresponding to the name in queries.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cpuUsageQuery</para>
                    /// </summary>
                    [NameInMap("queryName")]
                    [Validation(Required=false)]
                    public string QueryName { get; set; }

                    /// <summary>
                    /// <para>The threshold value of the sub-condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("threshold")]
                    [Validation(Required=false)]
                    public double? Threshold { get; set; }

                }

                /// <summary>
                /// <para>The expression type. SIMPLE indicates a single-metric condition. COMPOSITE indicates a multi-metric composite condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SIMPLE</para>
                /// </summary>
                [NameInMap("expressionType")]
                [Validation(Required=false)]
                public string ExpressionType { get; set; }

                /// <summary>
                /// <para>The multi-metric composite operator. Valid only when expressionType=COMPOSITE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("logicOperator")]
                [Validation(Required=false)]
                public string LogicOperator { get; set; }

            }

            /// <summary>
            /// <para>The alert severity level that corresponds to this trigger condition when it is met.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

        }

        /// <summary>
        /// <para>The rule condition type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SLS_CONDITION: SLS alert condition.</description></item>
        /// <item><description>APM_CONDITION: APM alert condition.</description></item>
        /// <item><description>CMS_BASIC_CONDITION: CloudMonitor Basic CloudMonitor alerts condition.</description></item>
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
        /// <para>The threshold for triggering an alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public double? Value { get; set; }

    }

}
