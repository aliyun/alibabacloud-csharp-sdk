// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoscalingConfigRequest : TeaModel {
        /// <summary>
        /// The waiting time before the auto scaling feature performs a scale-in activity. It is an interval between the time when the scale-in threshold is reached and the time when the scale-in activity (reduce the number of pods) starts. Unit: minutes. Default value: 10.
        /// </summary>
        [NameInMap("cool_down_duration")]
        [Validation(Required=false)]
        public string CoolDownDuration { get; set; }

        /// <summary>
        /// Specifies whether to evict pods created by DaemonSets when the cluster autoscaler performs a scale-in activity. Valid values:
        /// 
        /// *   `true`: evicts DaemonSet pods.
        /// *   `false`: does not evict DaemonSet pods.
        /// </summary>
        [NameInMap("daemonset_eviction_for_nodes")]
        [Validation(Required=false)]
        public bool? DaemonsetEvictionForNodes { get; set; }

        /// <summary>
        /// The node pool scale-out policy. Valid values:
        /// 
        /// *   `least-waste`: the default policy. If multiple node pools meet the requirement, this policy selects the node pool that will have the least idle resources after the scale-out activity is completed.
        /// *   `random`: the random policy. If multiple node pools meet the requirement, this policy selects a random node pool for the scale-out activity.
        /// *   `priority`: the priority-based policy If multiple node pools meet the requirement, this policy selects the node pool with the highest priority for the scale-out activity. The priority setting is stored in the ConfigMap named `cluster-autoscaler-priority-expander` in the kube-system namespace. When a scale-out activity is triggered, the policy obtains the node pool priorities from the ConfigMap based on the node pool IDs and then selects the node pool with the highest priority for the scale-out activity.
        /// </summary>
        [NameInMap("expander")]
        [Validation(Required=false)]
        public string Expander { get; set; }

        /// <summary>
        /// The scale-in threshold of GPU utilization. This threshold specifies the ratio of the GPU resources that are requested by pods to the total GPU resources on the node.
        /// 
        /// A scale-in activity is performed only when the CPU utilization, memory utilization, and GPU utilization of a GPU-accelerated node are lower than the scale-in threshold of GPU utilization.
        /// </summary>
        [NameInMap("gpu_utilization_threshold")]
        [Validation(Required=false)]
        public string GpuUtilizationThreshold { get; set; }

        /// <summary>
        /// The maximum amount of time to wait for pods on a node to terminate during a scale-in activity. Unit: seconds.
        /// </summary>
        [NameInMap("max_graceful_termination_sec")]
        [Validation(Required=false)]
        public int? MaxGracefulTerminationSec { get; set; }

        /// <summary>
        /// The minimum number of pods allowed in each ReplicaSet before a scale-in activity is performed.
        /// </summary>
        [NameInMap("min_replica_count")]
        [Validation(Required=false)]
        public int? MinReplicaCount { get; set; }

        /// <summary>
        /// Specifies whether to delete the corresponding Kubernetes node objects after nodes are removed in swift mode. For more information about the swift mode, see [Scaling mode](https://help.aliyun.com/document_detail/119099.html). Default value: false. Valid values:
        /// 
        /// *   `true`: deletes the corresponding Kubernetes node objects after nodes are removed in swift mode. We recommend that you do not set the value to true because data inconsistency may occur in Kubernetes objects.
        /// *   `false`: retains the corresponding Kubernetes node objects after nodes are removed in swift mode.
        /// </summary>
        [NameInMap("recycle_node_deletion_enabled")]
        [Validation(Required=false)]
        public bool? RecycleNodeDeletionEnabled { get; set; }

        /// <summary>
        /// Specifies whether to allow node scale-in activities. Valid values:
        /// 
        /// *   `true`: allows node scale-in activities.
        /// *   `false`: does not allow node scale-in activities.
        /// </summary>
        [NameInMap("scale_down_enabled")]
        [Validation(Required=false)]
        public bool? ScaleDownEnabled { get; set; }

        /// <summary>
        /// Specifies whether the cluster autoscaler performs a scale-out activity when the number of ready nodes in the cluster is 0. Default value: true. Valid values:
        /// 
        /// *   `true`: performs a scale-out activity.
        /// *   `false`: does not perform a scale-out activity.
        /// </summary>
        [NameInMap("scale_up_from_zero")]
        [Validation(Required=false)]
        public bool? ScaleUpFromZero { get; set; }

        /// <summary>
        /// The interval at which the system scans for events that trigger scaling activities. Unit: seconds. Default value: 60.
        /// </summary>
        [NameInMap("scan_interval")]
        [Validation(Required=false)]
        public string ScanInterval { get; set; }

        /// <summary>
        /// Specifies whether the cluster autoscaler scales in nodes that host pods mounted with local volumes, such as EmptyDir or HostPath volumes. Valid values:
        /// 
        /// *   `true`: does not allow the cluster autoscaler to scale in these nodes.
        /// *   `false`: allows the cluster autoscaler to scale in these nodes.
        /// </summary>
        [NameInMap("skip_nodes_with_local_storage")]
        [Validation(Required=false)]
        public bool? SkipNodesWithLocalStorage { get; set; }

        /// <summary>
        /// Specifies whether the cluster autoscaler scales in nodes that host pods in the kube-system namespace. This parameter does not take effect on pods created by DaemonSets and mirror pods. Valid values:
        /// 
        /// *   `true`: does not allow the cluster autoscaler to scale in these nodes.
        /// *   `false`: allows the cluster autoscaler to scale in these nodes.
        /// </summary>
        [NameInMap("skip_nodes_with_system_pods")]
        [Validation(Required=false)]
        public bool? SkipNodesWithSystemPods { get; set; }

        /// <summary>
        /// The cooldown period. After the autoscaler performs a scale-out activity, the autoscaler waits a cooldown period before it can perform a scale-in activity. Newly added nodes can be removed in scale-in activities only after the cooldown period ends. Unit: minutes.
        /// </summary>
        [NameInMap("unneeded_duration")]
        [Validation(Required=false)]
        public string UnneededDuration { get; set; }

        /// <summary>
        /// The scale-in threshold. This threshold specifies the ratio of the resources that are requested by pods to the total resources on the node.
        /// 
        /// A scale-in activity is performed only when the CPU utilization and memory utilization of a node are lower than the scale-in threshold.
        /// </summary>
        [NameInMap("utilization_threshold")]
        [Validation(Required=false)]
        public string UtilizationThreshold { get; set; }

    }

}
