// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ConditionConfigUnified : TeaModel {
        /// <summary>
        /// <para>The aggregation method for metric data points over the evaluation period. Valid values include <c>AVG</c>, <c>SUM</c>, and <c>MAX</c>.</para>
        /// </summary>
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <summary>
        /// <para>A list of composite comparison configurations for APM alerts. Each item is an <c>ApmCompositeCompareConfig</c> object.</para>
        /// </summary>
        [NameInMap("compareList")]
        [Validation(Required=false)]
        public List<ApmCompositeCompareConfig> CompareList { get; set; }

        /// <summary>
        /// <para>The number of seconds a condition must be true before triggering an alert.</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// <para>The comparison operator used to evaluate the metric against the threshold.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The logical relationship between multiple conditions. Valid values are <c>AND</c> and <c>OR</c>.</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>The alert severity. Valid values are <c>CRITICAL</c>, <c>WARNING</c>, and <c>INFO</c>.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The value against which the metric is evaluated to trigger an alert.</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

        /// <summary>
        /// <para>A list of threshold configurations for Application Performance Monitoring (APM) alerts. Each item is an <c>ApmThresholdConfig</c> object.</para>
        /// </summary>
        [NameInMap("thresholdList")]
        [Validation(Required=false)]
        public List<ApmThresholdConfig> ThresholdList { get; set; }

        /// <summary>
        /// <para>The type of the alert condition.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
