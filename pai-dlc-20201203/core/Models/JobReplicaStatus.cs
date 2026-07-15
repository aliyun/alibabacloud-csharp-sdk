// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobReplicaStatus : TeaModel {
        /// <summary>
        /// <para>The number of active pods for this replica type.</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public int? Active { get; set; }

        /// <summary>
        /// <para>The type of spot instance in use, if any.</para>
        /// </summary>
        [NameInMap("CurrentSpotInstanceType")]
        [Validation(Required=false)]
        public string CurrentSpotInstanceType { get; set; }

        /// <summary>
        /// <para>The number of dequeued pods.</para>
        /// </summary>
        [NameInMap("Dequeued")]
        [Validation(Required=false)]
        public int? Dequeued { get; set; }

        /// <summary>
        /// <para>The estimated auto scaling specification.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EstimatedAutoScalingSpec")]
        [Validation(Required=false)]
        public AutoScalingSpec EstimatedAutoScalingSpec { get; set; }

        /// <summary>
        /// <para>The estimated number of pods for this replica type, used for auto scaling.</para>
        /// </summary>
        [NameInMap("EstimatedPodCount")]
        [Validation(Required=false)]
        public long? EstimatedPodCount { get; set; }

        /// <summary>
        /// <para>The estimated resource configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EstimatedResourceConfig")]
        [Validation(Required=false)]
        public ResourceConfig EstimatedResourceConfig { get; set; }

        /// <summary>
        /// <para>The number of queued pods.</para>
        /// </summary>
        [NameInMap("Queuing")]
        [Validation(Required=false)]
        public int? Queuing { get; set; }

        /// <summary>
        /// <para>The type of the job replica.</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
