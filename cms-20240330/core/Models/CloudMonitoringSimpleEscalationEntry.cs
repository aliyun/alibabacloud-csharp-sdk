// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringSimpleEscalationEntry : TeaModel {
        /// <summary>
        /// <para>The minimum deviation or absolute deviation dead zone for dynamic baselines (effective only for baseline comparison operators). No alert is triggered if |current value - boundary| &lt; absDeviation. The unit is the same as the metric. The value must be greater than or equal to 0. A value of 0 means no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("absDeviation")]
        [Validation(Required=false)]
        public double? AbsDeviation { get; set; }

        /// <summary>
        /// <para>The baseline period (effective only for baseline comparison operators). Valid values: AUTO for automatic identification, DAILY for daily, WEEKLY for weekly, and NONE for no period. For weekly periods, the backend automatically expands the historical training window to 14 days or more. Automatic identification cannot return specific identification results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("baselinePeriod")]
        [Validation(Required=false)]
        public string BaselinePeriod { get; set; }

        /// <summary>
        /// <para>The comparison operator. GreaterThanThreshold or LessThanThreshold is used for static thresholds. ABOVE_UPPER, BELOW_LOWER, or OUT_OF_BAND is used for dynamic baseline spikes, drops, or bidirectional changes, which requires the sensitivity parameter. The threshold parameter is not used for baselines and can be omitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GT</para>
        /// </summary>
        [NameInMap("comparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// <para>The precondition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>连续3次</para>
        /// </summary>
        [NameInMap("preCondition")]
        [Validation(Required=false)]
        public string PreCondition { get; set; }

        /// <summary>
        /// <para>The dynamic baseline sensitivity (effective only for baseline comparison operators). Valid values: HIGH for the narrowest and most sensitive band, MEDIUM for medium, and LOW for the widest and least sensitive band.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("sensitivity")]
        [Validation(Required=false)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// <para>The severity level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CRITICAL</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The statistical method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Average</para>
        /// </summary>
        [NameInMap("statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// <para>The threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public string Threshold { get; set; }

        /// <summary>
        /// <para>The number of consecutive triggers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
