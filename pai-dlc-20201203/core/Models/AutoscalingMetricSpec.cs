// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AutoscalingMetricSpec : TeaModel {
        /// <summary>
        /// <para>The name of the metric for autoscaling. This can be a predefined or a custom metric.</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The cooldown period, in seconds, after a scaling activity. This prevents the service from initiating another scaling action before the effects of the previous one are observable, stabilizing resource fluctuations.</para>
        /// </summary>
        [NameInMap("StabilizationWindowSeconds")]
        [Validation(Required=false)]
        public int? StabilizationWindowSeconds { get; set; }

        /// <summary>
        /// <para>The target value for the specified metric. The autoscaling service tries to maintain the metric at or near this value.</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public int? TargetValue { get; set; }

        /// <summary>
        /// <para>The acceptable deviation from the <c>TargetValue</c>, specified as a percentage string. A scaling action is triggered only if the metric value moves outside the range defined by the <c>TargetValue</c> and this tolerance. This prevents scaling actions based on minor fluctuations.</para>
        /// </summary>
        [NameInMap("Tolerance")]
        [Validation(Required=false)]
        public string Tolerance { get; set; }

    }

}
