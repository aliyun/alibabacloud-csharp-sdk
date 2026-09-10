// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MetricSetMultiTrigger : TeaModel {
        /// <summary>
        /// <para>The minimum deviation or absolute deviation dead zone for the dynamic baseline. Takes effect only with baseline operators. The unit is the same as the metric. The value must be greater than or equal to 0. A value of 0 means no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("absDeviation")]
        [Validation(Required=false)]
        public double? AbsDeviation { get; set; }

        /// <summary>
        /// <para>The baseline period. Takes effect only with baseline operators. Valid values: AUTO (automatic detection), DAILY (daily), WEEKLY (weekly), and NONE (no period). When set to WEEKLY, the backend automatically expands the historical training window to at least 14 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("baselinePeriod")]
        [Validation(Required=false)]
        public string BaselinePeriod { get; set; }

        /// <summary>
        /// <para>The list of sub-conditions. Used when expressionType is COMPOSITE. Each item contains queryName, operator, and threshold.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<MetricSetTriggerSimpleExpression> Conditions { get; set; }

        /// <summary>
        /// <para>The duration in seconds that data must continuously meet the condition before an alert is triggered. If not specified, the value is inherited from conditionConfig.durationSecs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// <para>The expression type. Valid values: SIMPLE (single-metric threshold) and COMPOSITE (multi-metric AND/OR/UNLESS combination).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        /// <summary>
        /// <para>The logical operator. Used when expressionType is COMPOSITE. Valid values: AND (all conditions met), OR (any condition met), and UNLESS (first condition met and all others not met).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("logicOperator")]
        [Validation(Required=false)]
        public string LogicOperator { get; set; }

        /// <summary>
        /// <para>The upper bound of the range. Required when expressionType is SIMPLE and operator is IN_RANGE or OUT_OF_RANGE. The value must be greater than or equal to min.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The lower bound of the range. Required when expressionType is SIMPLE and operator is IN_RANGE or OUT_OF_RANGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The comparison operator (used when expressionType is SIMPLE). Valid values: GT (greater than), GE (greater than or equal to), LT (less than), LE (less than or equal to), EQ (equal to), NE (not equal to), IN_RANGE (within range, requires min/max), OUT_OF_RANGE (outside range, requires min/max), PRESENT (field exists, no threshold/min/max required), NOT_PRESENT (field does not exist, no threshold/min/max required), ABOVE_UPPER/BELOW_LOWER/OUT_OF_BAND (dynamic baseline spike/drop/bidirectional, requires sensitivity, no threshold/min/max).</para>
        /// 
        /// <b>Example:</b>
        /// <para>OUT_OF_BAND</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The referenced query name (used when expressionType is SIMPLE), corresponding to QueryConfigUnified.queries[].name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName</para>
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The dynamic baseline sensitivity. Takes effect when expressionType is SIMPLE and a baseline operator is used. Valid values: HIGH (narrowest and most sensitive band), MEDIUM, and LOW (widest and least sensitive band).</para>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("sensitivity")]
        [Validation(Required=false)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// <para>The alert severity level: CRITICAL &gt; ERROR &gt; WARN / WARNING &gt; INFO. Multiple triggers are sorted by this priority, and the first match fires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The comparison threshold. Used when expressionType is SIMPLE and operator is GT/GE/LT/LE/EQ/NE. For IN_RANGE/OUT_OF_RANGE, use min/max instead. Not required for PRESENT/NOT_PRESENT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
