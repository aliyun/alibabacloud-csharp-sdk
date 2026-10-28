// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobReplicaStatus : TeaModel {
        /// <summary>
        /// <para>The number of replicas of this role that are currently running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public int? Active { get; set; }

        /// <summary>
        /// <para>The currently selected spot instance type (applies only to elastic spot tasks).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.gn6e-c12g1.3xlarge</para>
        /// </summary>
        [NameInMap("CurrentSpotInstanceType")]
        [Validation(Required=false)]
        public string CurrentSpotInstanceType { get; set; }

        /// <summary>
        /// <para>The number of replicas of this role that have been dequeued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Dequeued")]
        [Validation(Required=false)]
        public int? Dequeued { get; set; }

        /// <summary>
        /// <para>The estimated auto-scaling configuration for this role.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EstimatedAutoScalingSpec")]
        [Validation(Required=false)]
        public AutoScalingSpec EstimatedAutoScalingSpec { get; set; }

        /// <summary>
        /// <para>The estimated number of pods for this role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EstimatedPodCount")]
        [Validation(Required=false)]
        public long? EstimatedPodCount { get; set; }

        /// <summary>
        /// <para>The estimated resource configuration for this role.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EstimatedResourceConfig")]
        [Validation(Required=false)]
        public ResourceConfig EstimatedResourceConfig { get; set; }

        /// <summary>
        /// <para>The number of replicas of this role that are still in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Queuing")]
        [Validation(Required=false)]
        public int? Queuing { get; set; }

        /// <summary>
        /// <para>The role type to which the task replicas belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Worker</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
