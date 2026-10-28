// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AutoscalingMetricSpec : TeaModel {
        /// <summary>
        /// <para>The name of the monitoring metrics used for auto scaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POD_CPU_UTIL</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The duration of the stabilization window for the auto scaling metric, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("StabilizationWindowSeconds")]
        [Validation(Required=false)]
        public int? StabilizationWindowSeconds { get; set; }

        /// <summary>
        /// <para>The target value of the monitoring metrics for auto scaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public int? TargetValue { get; set; }

        /// <summary>
        /// <para>The allowed bias ratio for the target value of the monitoring metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("Tolerance")]
        [Validation(Required=false)]
        public string Tolerance { get; set; }

    }

}
