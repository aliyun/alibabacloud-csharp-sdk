// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MetricSetMultiTrigger : TeaModel {
        /// <summary>
        /// <para>The list of sub-conditions (used when expressionType=COMPOSITE). Each item contains queryName, operator, and threshold.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<MetricSetTriggerSimpleExpression> Conditions { get; set; }

        /// <summary>
        /// <para>The duration in seconds that data must continuously meet the condition to trigger an alert. If not specified, the value is inherited from conditionConfig.durationSecs.</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// <para>The expression type. Valid values: SIMPLE (single-metric threshold) or COMPOSITE (multi-metric AND/OR/UNLESS combination).</para>
        /// </summary>
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        /// <summary>
        /// <para>The logic operator (used when expressionType=COMPOSITE). Valid values: AND (all conditions met), OR (any condition met), UNLESS (first condition met and all others not met).</para>
        /// </summary>
        [NameInMap("logicOperator")]
        [Validation(Required=false)]
        public string LogicOperator { get; set; }

        /// <summary>
        /// <para>The upper bound of the range. Required when expressionType=SIMPLE and operator is IN_RANGE or OUT_OF_RANGE. The value must be greater than or equal to min.</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The lower bound of the range. Required when expressionType=SIMPLE and operator is IN_RANGE or OUT_OF_RANGE.</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The comparison operator (used when expressionType=SIMPLE). Valid values: GT (greater than), GE (greater than or equal to), LT (less than), LE (less than or equal to), EQ (equal to), NE (not equal to), IN_RANGE (within range, requires min/max), OUT_OF_RANGE (outside range, requires min/max), PRESENT (field exists, no threshold/min/max needed), NOT_PRESENT (field does not exist, no threshold/min/max needed).</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The referenced query name (used when expressionType=SIMPLE), corresponding to QueryConfigUnified.queries[].name.</para>
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The alert severity level: CRITICAL &gt; ERROR &gt; WARN / WARNING &gt; INFO. Multiple triggers are sorted by this priority, and the first match fires.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The comparison threshold. Used when expressionType=SIMPLE and operator is GT/GE/LT/LE/EQ/NE. For IN_RANGE/OUT_OF_RANGE, use min/max instead. For PRESENT/NOT_PRESENT, leave this field empty.</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
