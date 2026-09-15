// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Triggers : TeaModel {
        /// <summary>
        /// <para>The comparison operator when the condition type is CLOUD_MONITORING_CONDITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleValue</para>
        /// </summary>
        [NameInMap("comparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// <para>The match expression when the condition type is SLS_MULTI_CONDITION. This corresponds to the V1 condition and is preserved as-is without parsing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleValue</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The list of sub-conditions when the condition type is UMODEL_METRICSET_MULTI or PROMETHEUS_MULTI with expressionType=COMPOSITE. Each item contains queryName, operator, and threshold.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<TriggerConditions> Conditions { get; set; }

        /// <summary>
        /// <para>The count match expression when the condition type is SLS_MULTI_CONDITION. This corresponds to the V1 countCondition and is preserved as-is without parsing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleValue</para>
        /// </summary>
        [NameInMap("countCondition")]
        [Validation(Required=false)]
        public string CountCondition { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The write path for SLS_MULTI_CONDITION has been disabled. Use countCondition instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GTE</para>
        /// </summary>
        [NameInMap("countOperator")]
        [Validation(Required=false)]
        [Obsolete]
        public string CountOperator { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The write path for SLS_MULTI_CONDITION has been disabled. Use countCondition instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("countThreshold")]
        [Validation(Required=false)]
        [Obsolete]
        public long? CountThreshold { get; set; }

        /// <summary>
        /// <para>The duration in seconds during which data must continuously meet the condition before an alert is triggered. If not specified, the value is inherited from conditionConfig.durationSecs. This parameter is used by UMODEL_METRICSET_MULTI_CONDITION and PROMETHEUS_MULTI_CONDITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// <para>The expression type. Set to SIMPLE or COMPOSITE when the condition type is UMODEL_METRICSET_MULTI_CONDITION or PROMETHEUS_MULTI_CONDITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        /// <summary>
        /// <para>The logical operator when the condition type is UMODEL_METRICSET_MULTI or PROMETHEUS_MULTI with expressionType=COMPOSITE. Valid values: AND, OR, and UNLESS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("logicOperator")]
        [Validation(Required=false)]
        public string LogicOperator { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The write path for SLS_MULTI_CONDITION has been disabled. Use condition instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleValue</para>
        /// </summary>
        [NameInMap("matchField")]
        [Validation(Required=false)]
        [Obsolete]
        public string MatchField { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The write path for SLS_MULTI_CONDITION has been disabled. Use condition instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRESENT</para>
        /// </summary>
        [NameInMap("matchOperator")]
        [Validation(Required=false)]
        [Obsolete]
        public string MatchOperator { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The write path for SLS_MULTI_CONDITION has been disabled. Use condition instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleValue</para>
        /// </summary>
        [NameInMap("matchValue")]
        [Validation(Required=false)]
        [Obsolete]
        public string MatchValue { get; set; }

        /// <summary>
        /// <para>The upper bound of the range when the condition type is UMODEL_METRICSET_MULTI with expressionType=SIMPLE. This parameter is required when operator is set to IN_RANGE or OUT_OF_RANGE. The value must be greater than or equal to min.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The metric name when the condition type is CLOUD_MONITORING_CONDITION with expressionType=COMPOSITE. For SIMPLE expression type, the metric name is specified at the conditionConfig level by the metricName parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleMetricName</para>
        /// </summary>
        [NameInMap("metricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The lower bound of the range when the condition type is UMODEL_METRICSET_MULTI with expressionType=SIMPLE. This parameter is required when operator is set to IN_RANGE or OUT_OF_RANGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The operator. For UMODEL_METRICSET_MULTI or PROMETHEUS_MULTI with expressionType=SIMPLE, this is a comparison operator (GT/GE/LT/LE/EQ/NE/IN_RANGE/OUT_OF_RANGE/PRESENT/NOT_PRESENT/ABOVE_UPPER/BELOW_LOWER/OUT_OF_BAND). For SLS_MULTI_CONDITION, this is aligned with the V1 caseList.type (HAS_DATA/HAS_DATA_COUNT/HAS_DATA_MATCH/HAS_DATA_MATCH_COUNT).</para>
        /// 
        /// <b>Example:</b>
        /// <para>GT</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The collection period in seconds when the condition type is CLOUD_MONITORING_CONDITION with expressionType=COMPOSITE. For SIMPLE expression type, the period is specified at the conditionConfig level by the period parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The precondition when the condition type is CLOUD_MONITORING_CONDITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleValue</para>
        /// </summary>
        [NameInMap("preCondition")]
        [Validation(Required=false)]
        public string PreCondition { get; set; }

        /// <summary>
        /// <para>The referenced query name when the condition type is UMODEL_METRICSET_MULTI or PROMETHEUS_MULTI with expressionType=SIMPLE. This corresponds to QueryConfigUnified.queries[].name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleMetricName</para>
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The severity level. The priority order is CRITICAL &gt; ERROR &gt; WARN / WARNING &gt; INFO. When multiple triggers exist, they are sorted by this priority, and the first match triggers the alert. This parameter takes effect when the condition type is SLS_MULTI_CONDITION or CLOUD_MONITORING_CONDITION with expressionType=SIMPLE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The statistical method when the condition type is CLOUD_MONITORING_CONDITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleValue</para>
        /// </summary>
        [NameInMap("statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// <para>The threshold value. For CLOUD_MONITORING_CONDITION, this is a string. For UMODEL_METRICSET_MULTI and PROMETHEUS_MULTI, this is a numeric value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public object Threshold { get; set; }

        /// <summary>
        /// <para>The number of consecutive times the condition must be met before an alert is triggered when the condition type is CLOUD_MONITORING_CONDITION with expressionType=SIMPLE. Each entry has its own independent setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
