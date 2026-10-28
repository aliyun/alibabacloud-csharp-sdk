// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AutoScalingSpec : TeaModel {
        /// <summary>
        /// <para>The monitoring metrics configuration for autoscaling.</para>
        /// </summary>
        [NameInMap("AutoscalingMetricSpec")]
        [Validation(Required=false)]
        public AutoscalingMetricSpec AutoscalingMetricSpec { get; set; }

        /// <summary>
        /// <para>The maximum number of replicas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxReplicas")]
        [Validation(Required=false)]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// <para>The minimum number of replicas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinReplicas")]
        [Validation(Required=false)]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// <para>The Pods to delete for scale-in. This can only be modified through UpdateJob, and the number of Pods to delete must match PodCount.</para>
        /// </summary>
        [NameInMap("PodsToDelete")]
        [Validation(Required=false)]
        public List<string> PodsToDelete { get; set; }

        /// <summary>
        /// <para>The autoscaling policy. Valid values: Default, ScaleByAPI, RayAutoscaler, and CloudMonitorMetric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("ScalingStrategy")]
        [Validation(Required=false)]
        public string ScalingStrategy { get; set; }

    }

}
