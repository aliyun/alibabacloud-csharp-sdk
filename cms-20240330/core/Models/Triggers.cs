// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Triggers : TeaModel {
        /// <summary>
        /// <para>The comparison operator. This parameter applies to CLOUD_MONITORING_CONDITION.</para>
        /// </summary>
        [NameInMap("comparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// <para>The match expression for SLS_MULTI_CONDITION. This corresponds to the V1 condition parameter and is preserved as-is without parsing.</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The list of sub-conditions. This parameter applies to UMODEL_METRICSET_MULTI and PROMETHEUS_MULTI with expressionType=COMPOSITE. Each item contains queryName, operator, and threshold.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<TriggerConditions> Conditions { get; set; }

        /// <summary>
        /// <para>The count match expression for SLS_MULTI_CONDITION. This corresponds to the V1 countCondition parameter and is preserved as-is without parsing.</para>
        /// </summary>
        [NameInMap("countCondition")]
        [Validation(Required=false)]
        public string CountCondition { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The SLS_MULTI_CONDITION write path is disabled. Use the countCondition parameter instead.</para>
        /// </summary>
        [NameInMap("countOperator")]
        [Validation(Required=false)]
        [Obsolete]
        public string CountOperator { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The SLS_MULTI_CONDITION write path is disabled. Use the countCondition parameter instead.</para>
        /// </summary>
        [NameInMap("countThreshold")]
        [Validation(Required=false)]
        [Obsolete]
        public long? CountThreshold { get; set; }

        /// <summary>
        /// <para>The duration in seconds for which data must continuously meet the condition to trigger an alert. If not specified, the value is inherited from conditionConfig.durationSecs. This parameter is used by UMODEL_METRICSET_MULTI_CONDITION and PROMETHEUS_MULTI_CONDITION.</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// <para>The expression type. Valid values: SIMPLE and COMPOSITE. This parameter applies to UMODEL_METRICSET_MULTI_CONDITION and PROMETHEUS_MULTI_CONDITION.</para>
        /// </summary>
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        /// <summary>
        /// <para>The logical operator. This parameter applies to UMODEL_METRICSET_MULTI and PROMETHEUS_MULTI with expressionType=COMPOSITE. Valid values: AND, OR, and UNLESS.</para>
        /// </summary>
        [NameInMap("logicOperator")]
        [Validation(Required=false)]
        public string LogicOperator { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The SLS_MULTI_CONDITION write path is disabled. Use the condition parameter instead.</para>
        /// </summary>
        [NameInMap("matchField")]
        [Validation(Required=false)]
        [Obsolete]
        public string MatchField { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The SLS_MULTI_CONDITION write path is disabled. Use the condition parameter instead.</para>
        /// </summary>
        [NameInMap("matchOperator")]
        [Validation(Required=false)]
        [Obsolete]
        public string MatchOperator { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The SLS_MULTI_CONDITION write path is disabled. Use the condition parameter instead.</para>
        /// </summary>
        [NameInMap("matchValue")]
        [Validation(Required=false)]
        [Obsolete]
        public string MatchValue { get; set; }

        /// <summary>
        /// <para>The upper bound of the range. This parameter applies to UMODEL_METRICSET_MULTI with expressionType=SIMPLE. This parameter is required when operator is set to IN_RANGE or OUT_OF_RANGE. The value must be greater than or equal to min.</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The metric name. This parameter applies to CLOUD_MONITORING_CONDITION with expressionType=COMPOSITE. For SIMPLE, the metric name is specified at the conditionConfig level by the metricName parameter.</para>
        /// </summary>
        [NameInMap("metricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The lower bound of the range. This parameter applies to UMODEL_METRICSET_MULTI with expressionType=SIMPLE. This parameter is required when operator is set to IN_RANGE or OUT_OF_RANGE.</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The operator. For UMODEL_METRICSET_MULTI and PROMETHEUS_MULTI with expressionType=SIMPLE, this is a comparison operator. Valid values: GT, GE, LT, LE, EQ, NE, IN_RANGE, OUT_OF_RANGE, PRESENT, and NOT_PRESENT. For SLS_MULTI_CONDITION, this is aligned with V1 caseList.type. Valid values: HAS_DATA, HAS_DATA_COUNT, HAS_DATA_MATCH, and HAS_DATA_MATCH_COUNT.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The aggregation period in seconds. This parameter applies to CLOUD_MONITORING_CONDITION with expressionType=COMPOSITE. For SIMPLE, the period is specified at the conditionConfig level by the period parameter.</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The precondition. This parameter applies to CLOUD_MONITORING_CONDITION.</para>
        /// </summary>
        [NameInMap("preCondition")]
        [Validation(Required=false)]
        public string PreCondition { get; set; }

        /// <summary>
        /// <para>The referenced query name. This parameter applies to UMODEL_METRICSET_MULTI and PROMETHEUS_MULTI with expressionType=SIMPLE. The value corresponds to QueryConfigUnified.queries[].name.</para>
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The severity level. Priority order: CRITICAL &gt; ERROR &gt; WARN / WARNING &gt; INFO. Multiple triggers are sorted by this priority, and the first match triggers the alert. This parameter takes effect when the type is SLS_MULTI_CONDITION or CLOUD_MONITORING_CONDITION with expressionType=SIMPLE.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The statistical method. This parameter applies to CLOUD_MONITORING_CONDITION.</para>
        /// </summary>
        [NameInMap("statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// <para>The threshold value. For CLOUD_MONITORING_CONDITION, this is a string. For UMODEL_METRICSET_MULTI and PROMETHEUS_MULTI, this is a numeric value.</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public object Threshold { get; set; }

        /// <summary>
        /// <para>The number of consecutive times the condition must be met to trigger the alert. Each entry has its own setting. This parameter applies to CLOUD_MONITORING_CONDITION with expressionType=SIMPLE.</para>
        /// </summary>
        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
