// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ApmCompositeCompareConfig : TeaModel {
        /// <summary>
        /// <para>The aggregation method for metric data. For example, <c>AVG</c>, <c>SUM</c>, or <c>MAX</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <summary>
        /// <para>The operator for comparing the aggregated metric data against the <c>threshold</c>. For example, <c>GREATER_THAN</c> or <c>LESS_THAN</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The value to compare the aggregated metric data against. An alert is triggered when the metric data meets the condition defined by the <c>operator</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        /// <summary>
        /// <para>The time unit for the year-over-year (YoY) comparison. Use this parameter with <c>yoyTimeValue</c> to define the comparison period. Valid values are <c>day</c> and <c>week</c>.</para>
        /// </summary>
        [NameInMap("yoyTimeUnit")]
        [Validation(Required=false)]
        public string YoyTimeUnit { get; set; }

        /// <summary>
        /// <para>The time value for the YoY comparison. For example, if <c>yoyTimeUnit</c> is <c>day</c> and <c>yoyTimeValue</c> is <c>7</c>, the system compares current data with data from 7 days ago.</para>
        /// </summary>
        [NameInMap("yoyTimeValue")]
        [Validation(Required=false)]
        public int? YoyTimeValue { get; set; }

    }

}
