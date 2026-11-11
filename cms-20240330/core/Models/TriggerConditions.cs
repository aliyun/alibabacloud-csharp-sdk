// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TriggerConditions : TeaModel {
        /// <summary>
        /// <para>The minimum deviation or absolute deviation dead zone for dynamic baselines, which takes effect only for baseline operators. No alert is triggered if the absolute difference between the current value and the boundary is less than the absDeviation value. The unit is the same as the metric unit. The value must be greater than or equal to 0. A value of 0 indicates no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("absDeviation")]
        [Validation(Required=false)]
        public double? AbsDeviation { get; set; }

        /// <summary>
        /// <para>The baseline period, which takes effect only for baseline operators. Valid values: AUTO for automatic identification, DAILY for daily, WEEKLY for weekly, and NONE for no period. If you set this parameter to WEEKLY, the backend automatically extends the historical training window to at least 14 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("baselinePeriod")]
        [Validation(Required=false)]
        public string BaselinePeriod { get; set; }

        /// <summary>
        /// <para>The expression type. The value is fixed as SIMPLE, which is used for MetricSet multi-threshold triggers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        /// <summary>
        /// <para>The upper bound of the range. This parameter is required when the operator is IN_RANGE or OUT_OF_RANGE, and the value must be greater than or equal to the min value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The lower bound of the range. This parameter is required when the operator is IN_RANGE or OUT_OF_RANGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The comparison operator. Valid values: GT, GE, LT, LE, EQ, NE, IN_RANGE (requires both min and max), OUT_OF_RANGE (requires both min and max), PRESENT, and NOT_PRESENT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GT</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The referenced query name, which corresponds to QueryConfigUnified.queries[].name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpuQuery</para>
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The dynamic baseline sensitivity, which takes effect only when the operator is ABOVE_UPPER, BELOW_LOWER, or OUT_OF_BAND. Valid values: HIGH for the narrowest and most sensitive band, MEDIUM for medium sensitivity, and LOW for the widest and least sensitive band. You can configure different sensitivities for multiple subconditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("sensitivity")]
        [Validation(Required=false)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// <para>The comparison threshold. This parameter is used when the operator is GT, GE, LT, LE, EQ, or NE. For IN_RANGE or OUT_OF_RANGE, use the min and max parameters. For PRESENT or NOT_PRESENT, leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
