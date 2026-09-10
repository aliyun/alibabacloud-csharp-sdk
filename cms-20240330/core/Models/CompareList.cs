// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CompareList : TeaModel {
        /// <summary>
        /// <para>The dynamic baseline minimum deviation or absolute deviation dead zone. This parameter takes effect only when a baseline operator is used. If |current value − boundary| &lt; absDeviation, no alert is triggered. The unit is the same as the metric unit. The value must be greater than or equal to 0. A value of 0 indicates no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("absDeviation")]
        [Validation(Required=false)]
        public double? AbsDeviation { get; set; }

        /// <summary>
        /// <para>The aggregation function.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVG</para>
        /// </summary>
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <summary>
        /// <para>The baseline period. This parameter takes effect only when a baseline operator is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AUTO: Automatically identifies the period. The specific identification result cannot be displayed.</description></item>
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
        /// <para>The comparison operator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GTE: greater than or equal to.</description></item>
        /// <item><description>LTE: less than or equal to.</description></item>
        /// <item><description>YOY_UP: year-over-year increase. You must also specify yoyTimeUnit and yoyTimeValue.</description></item>
        /// <item><description>YOY_DOWN: year-over-year decrease. You must also specify yoyTimeUnit and yoyTimeValue.</description></item>
        /// <item><description>ABOVE_UPPER: dynamic baseline spike. You must specify sensitivity. When using a baseline operator, threshold is not used for evaluation. Set it to 0 as a placeholder.</description></item>
        /// <item><description>BELOW_LOWER: dynamic baseline drop. You must specify sensitivity. When using a baseline operator, threshold is not used for evaluation. Set it to 0 as a placeholder.</description></item>
        /// <item><description>OUT_OF_BAND: dynamic baseline bidirectional. You must specify sensitivity. When using a baseline operator, threshold is not used for evaluation. Set it to 0 as a placeholder.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OUT_OF_BAND</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The dynamic baseline sensitivity. This parameter takes effect only when a baseline operator is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HIGH: The narrowest band and the most sensitive.</description></item>
        /// <item><description>MEDIUM: Medium sensitivity.</description></item>
        /// <item><description>LOW: The widest band and the least sensitive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("sensitivity")]
        [Validation(Required=false)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// <para>The threshold.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        /// <summary>
        /// <para>The year-over-year time unit. This parameter takes effect only when operator is set to YOY_UP or YOY_DOWN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("yoyTimeUnit")]
        [Validation(Required=false)]
        public string YoyTimeUnit { get; set; }

        /// <summary>
        /// <para>The year-over-year time value. This parameter takes effect only when operator is set to YOY_UP or YOY_DOWN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("yoyTimeValue")]
        [Validation(Required=false)]
        public int? YoyTimeValue { get; set; }

    }

}
