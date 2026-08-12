// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Triggers : TeaModel {
        /// <summary>
        /// <para>The comparison operator for CLOUD_MONITORING_CONDITION.</para>
        /// </summary>
        [NameInMap("comparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// <para>The list of sub-conditions for UMODEL_METRICSET_MULTI or PROMETHEUS_MULTI with expressionType=COMPOSITE. Each item contains queryName, operator, and threshold.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<TriggerConditions> Conditions { get; set; }

        /// <summary>
        /// <para>The count comparison operator for SLS_MULTI_CONDITION. Valid values: GTE, GT, EQ, LTE, and LT.</para>
        /// </summary>
        [NameInMap("countOperator")]
        [Validation(Required=false)]
        public string CountOperator { get; set; }

        /// <summary>
        /// <para>The count threshold for SLS_MULTI_CONDITION. An alert is triggered when this threshold is met.</para>
        /// </summary>
        [NameInMap("countThreshold")]
        [Validation(Required=false)]
        public long? CountThreshold { get; set; }

        /// <summary>
        /// <para>The duration in seconds during which data must continuously meet the condition before an alert is triggered. If this parameter is not specified, the value of conditionConfig.durationSecs is inherited. This parameter is used by UMODEL_METRICSET_MULTI_CONDITION and PROMETHEUS_MULTI_CONDITION.</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// <para>The expression type. Valid values: SIMPLE and COMPOSITE. This parameter takes effect for UMODEL_METRICSET_MULTI_CONDITION and PROMETHEUS_MULTI_CONDITION.</para>
        /// </summary>
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        /// <summary>
        /// <para>The logical operator for UMODEL_METRICSET_MULTI or PROMETHEUS_MULTI with expressionType=COMPOSITE. Valid values: AND, OR, and UNLESS.</para>
        /// </summary>
        [NameInMap("logicOperator")]
        [Validation(Required=false)]
        public string LogicOperator { get; set; }

        /// <summary>
        /// <para>The log field name for SLS_MULTI_CONDITION. This parameter is required when matchOperator is set to CONTAINS, EQUALS, or REGEX. When matchOperator is set to PRESENT or NOT_PRESENT, specify the field name.</para>
        /// </summary>
        [NameInMap("matchField")]
        [Validation(Required=false)]
        public string MatchField { get; set; }

        /// <summary>
        /// <para>The log match operator for SLS_MULTI_CONDITION. Valid values: PRESENT, NOT_PRESENT, CONTAINS, EQUALS, and REGEX. If this parameter is left empty, any data matches.</para>
        /// </summary>
        [NameInMap("matchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        /// <summary>
        /// <para>The log match value for SLS_MULTI_CONDITION. This parameter is required when matchOperator is set to CONTAINS, EQUALS, or REGEX.</para>
        /// </summary>
        [NameInMap("matchValue")]
        [Validation(Required=false)]
        public string MatchValue { get; set; }

        /// <summary>
        /// <para>The upper bound of the range for UMODEL_METRICSET_MULTI with expressionType=SIMPLE. This parameter is required when operator is set to IN_RANGE or OUT_OF_RANGE. The value must be greater than or equal to min.</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The metric name. This parameter is used for CLOUD_MONITORING_CONDITION with expressionType=COMPOSITE. For SIMPLE, the metric name is specified at the conditionConfig level by the metricName parameter.</para>
        /// </summary>
        [NameInMap("metricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The lower bound of the range for UMODEL_METRICSET_MULTI with expressionType=SIMPLE. This parameter is required when operator is set to IN_RANGE or OUT_OF_RANGE.</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The comparison operator for UMODEL_METRICSET_MULTI or PROMETHEUS_MULTI with expressionType=SIMPLE.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The aggregation period in seconds. This parameter is used for CLOUD_MONITORING_CONDITION with expressionType=COMPOSITE. For SIMPLE, the period is specified at the conditionConfig level by the period parameter.</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The precondition for CLOUD_MONITORING_CONDITION.</para>
        /// </summary>
        [NameInMap("preCondition")]
        [Validation(Required=false)]
        public string PreCondition { get; set; }

        /// <summary>
        /// <para>The referenced query name for UMODEL_METRICSET_MULTI or PROMETHEUS_MULTI with expressionType=SIMPLE. This corresponds to QueryConfigUnified.queries[].name.</para>
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The severity level. Priority order: CRITICAL &gt; ERROR &gt; WARN / WARNING &gt; INFO. When multiple triggers exist, they are sorted by this priority, and the first match triggers the alert. This parameter takes effect for SLS_MULTI_CONDITION and CLOUD_MONITORING_CONDITION with expressionType=SIMPLE.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The statistical method for CLOUD_MONITORING_CONDITION.</para>
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
        /// <para>The number of consecutive times the condition must be met before an alert is triggered. This parameter is used for CLOUD_MONITORING_CONDITION with expressionType=SIMPLE and is set independently for each entry.</para>
        /// </summary>
        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
