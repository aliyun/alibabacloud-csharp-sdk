// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MetricSetTriggerSimpleExpression : TeaModel {
        /// <summary>
        /// <para>The expression type. Fixed as SIMPLE.</para>
        /// </summary>
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        /// <summary>
        /// <para>The upper bound of the range. Required when operator is IN_RANGE or OUT_OF_RANGE. Must be greater than or equal to min.</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The lower bound of the range. Required when operator is IN_RANGE or OUT_OF_RANGE.</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The comparison operator. Valid values: GT (greater than), GE (greater than or equal to), LT (less than), LE (less than or equal to), EQ (equal to), NE (not equal to), IN_RANGE (within range, requires both min and max), OUT_OF_RANGE (outside range, requires both min and max), PRESENT (field exists, does not require threshold/min/max), NOT_PRESENT (field does not exist, does not require threshold/min/max).</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The referenced query name, corresponding to QueryConfigUnified.queries[].name.</para>
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The comparison threshold. Used when operator is GT, GE, LT, LE, EQ, or NE. IN_RANGE and OUT_OF_RANGE use min/max instead. PRESENT and NOT_PRESENT do not require this field.</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
