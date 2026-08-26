// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TriggerConditions : TeaModel {
        /// <summary>
        /// <para>The expression type, fixed as SIMPLE (used by MetricSet multi-threshold triggers).</para>
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
        /// <para>The comparison operator. Valid values: GT / GE / LT / LE / EQ / NE / IN_RANGE (requires both min and max) / OUT_OF_RANGE (requires both min and max) / PRESENT / NOT_PRESENT.</para>
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
        /// <para>The comparison threshold. Used when operator is GT, GE, LT, LE, EQ, or NE. Use min and max for IN_RANGE or OUT_OF_RANGE. Leave empty for PRESENT or NOT_PRESENT.</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
