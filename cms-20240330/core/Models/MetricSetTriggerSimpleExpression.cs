// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MetricSetTriggerSimpleExpression : TeaModel {
        /// <summary>
        /// <para>The minimum deviation or absolute deviation dead zone for the dynamic baseline. Takes effect only for baseline operators. The unit is the same as the metric. The value must be greater than or equal to 0. A value of 0 indicates no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("absDeviation")]
        [Validation(Required=false)]
        public double? AbsDeviation { get; set; }

        /// <summary>
        /// <para>The baseline period. Takes effect only for baseline operators. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AUTO: Automatically identifies the period.</description></item>
        /// <item><description>DAILY: Daily period.</description></item>
        /// <item><description>WEEKLY: Weekly period. The backend automatically expands the historical training window to at least 14 days.</description></item>
        /// <item><description>NONE: No period.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("baselinePeriod")]
        [Validation(Required=false)]
        public string BaselinePeriod { get; set; }

        /// <summary>
        /// <para>The expression type. Fixed value: SIMPLE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        /// <summary>
        /// <para>The upper bound of the range. Required when operator is set to IN_RANGE or OUT_OF_RANGE. The value must be greater than or equal to min.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The lower bound of the range. Required when operator is set to IN_RANGE or OUT_OF_RANGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The comparison operator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GT: Greater than.</description></item>
        /// <item><description>GE: Greater than or equal to.</description></item>
        /// <item><description>LT: Less than.</description></item>
        /// <item><description>LE: Less than or equal to.</description></item>
        /// <item><description>EQ: Equal to.</description></item>
        /// <item><description>NE: Not equal to.</description></item>
        /// <item><description>IN_RANGE: Within the range. Both min and max must be specified.</description></item>
        /// <item><description>OUT_OF_RANGE: Outside the range. Both min and max must be specified.</description></item>
        /// <item><description>PRESENT: The field exists. The threshold, min, and max parameters are not required.</description></item>
        /// <item><description>NOT_PRESENT: The field does not exist. The threshold, min, and max parameters are not required.</description></item>
        /// <item><description>ABOVE_UPPER: Dynamic baseline spike. The sensitivity parameter is required. The threshold, min, and max parameters are not required.</description></item>
        /// <item><description>BELOW_LOWER: Dynamic baseline drop. The sensitivity parameter is required. The threshold, min, and max parameters are not required.</description></item>
        /// <item><description>OUT_OF_BAND: Dynamic baseline bidirectional deviation. The sensitivity parameter is required. The threshold, min, and max parameters are not required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OUT_OF_BAND</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The referenced query name, corresponding to QueryConfigUnified.queries[].name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpuQuery</para>
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The dynamic baseline sensitivity. Takes effect only for baseline operators. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HIGH: The narrowest band and highest sensitivity.</description></item>
        /// <item><description>MEDIUM: Medium sensitivity.</description></item>
        /// <item><description>LOW: The widest band and lowest sensitivity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("sensitivity")]
        [Validation(Required=false)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// <para>The comparison threshold. Used when operator is set to GT, GE, LT, LE, EQ, or NE. For IN_RANGE or OUT_OF_RANGE, use min and max instead. Not required for PRESENT or NOT_PRESENT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
