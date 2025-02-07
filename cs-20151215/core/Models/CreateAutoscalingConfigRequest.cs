// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoscalingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The waiting time before the auto scaling feature performs a scale-in activity. It is an interval between the time when the scale-in threshold is reached and the time when the scale-in activity (reduce the number of pods) starts. Unit: minutes. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10 m</para>
        /// </summary>
        [NameInMap("cool_down_duration")]
        [Validation(Required=false)]
        public string CoolDownDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to evict pods created by DaemonSets when the cluster autoscaler performs a scale-in activity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: evicts DaemonSet pods.</description></item>
        /// <item><description><c>false</c>: does not evict DaemonSet pods.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("daemonset_eviction_for_nodes")]
        [Validation(Required=false)]
        public bool? DaemonsetEvictionForNodes { get; set; }

        /// <summary>
        /// <para>The node pool scale-out policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>least-waste</c>: the default policy. If multiple node pools meet the requirement, this policy selects the node pool that will have the least idle resources after the scale-out activity is completed.</description></item>
        /// <item><description><c>random</c>: the random policy. If multiple node pools meet the requirement, this policy selects a random node pool for the scale-out activity.</description></item>
        /// <item><description><c>priority</c>: the priority-based policy If multiple node pools meet the requirement, this policy selects the node pool with the highest priority for the scale-out activity. The priority setting is stored in the ConfigMap named <c>cluster-autoscaler-priority-expander</c> in the kube-system namespace. When a scale-out activity is triggered, the policy obtains the node pool priorities from the ConfigMap based on the node pool IDs and then selects the node pool with the highest priority for the scale-out activity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>least-waste</para>
        /// </summary>
        [NameInMap("expander")]
        [Validation(Required=false)]
        public string Expander { get; set; }

        /// <summary>
        /// <para>The scale-in threshold of GPU utilization. This threshold specifies the ratio of the GPU resources that are requested by pods to the total GPU resources on the node.</para>
        /// <para>A scale-in activity is performed only when the CPU utilization, memory utilization, and GPU utilization of a GPU-accelerated node are lower than the scale-in threshold of GPU utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("gpu_utilization_threshold")]
        [Validation(Required=false)]
        public string GpuUtilizationThreshold { get; set; }

        /// <summary>
        /// <para>The maximum amount of time to wait for pods on a node to terminate during a scale-in activity. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14400s</para>
        /// </summary>
        [NameInMap("max_graceful_termination_sec")]
        [Validation(Required=false)]
        public int? MaxGracefulTerminationSec { get; set; }

        /// <summary>
        /// <para>The minimum number of pods allowed in each ReplicaSet before a scale-in activity is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("min_replica_count")]
        [Validation(Required=false)]
        public int? MinReplicaCount { get; set; }

        /// <summary>
        /// <para>Auto-scaling priority configuration. After creating a node pool with elasticity enabled, you can choose whether to configure a priority strategy and priority settings through <a href="https://help.aliyun.com/document_detail/119099.html">Enabling Node Auto-scaling</a>. This allows you to set priorities for the specified auto-scaling node pool scaling group. The priority value range is [1, 100] and must be a positive integer.</para>
        /// </summary>
        [NameInMap("priorities")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> Priorities { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the corresponding Kubernetes node objects after nodes are removed in swift mode. For more information about the swift mode, see <a href="https://help.aliyun.com/document_detail/119099.html">Scaling mode</a>. Default value: false Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: deletes the corresponding Kubernetes node objects after nodes are removed in swift mode. We recommend that you do not set the value to true because data inconsistency may occur in Kubernetes objects.</description></item>
        /// <item><description><c>false</c>: retains the corresponding Kubernetes node objects after nodes are removed in swift mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("recycle_node_deletion_enabled")]
        [Validation(Required=false)]
        public bool? RecycleNodeDeletionEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow node scale-in activities. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: allows node scale-in activities.</description></item>
        /// <item><description><c>false</c>: does not allow node scale-in activities.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("scale_down_enabled")]
        [Validation(Required=false)]
        public bool? ScaleDownEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether the cluster autoscaler performs a scale-out activity when the number of ready nodes in the cluster is 0. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: performs a scale-out activity.</description></item>
        /// <item><description><c>false</c>: does not perform a scale-out activity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("scale_up_from_zero")]
        [Validation(Required=false)]
        public bool? ScaleUpFromZero { get; set; }

        /// <summary>
        /// <para>Elastic component type, default is goatscaler for cluster version 1.24 and above, and cluster-autoscaler below that. Values:</para>
        /// <list type="bullet">
        /// <item><description><c>goatscaler</c>: Instant elasticity. </description></item>
        /// <item><description><c>cluster-autoscaler</c>: Auto-scaling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>goatscaler</para>
        /// </summary>
        [NameInMap("scaler_type")]
        [Validation(Required=false)]
        public string ScalerType { get; set; }

        /// <summary>
        /// <para>The interval at which the system scans for events that trigger scaling activities. Unit: seconds. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30s</para>
        /// </summary>
        [NameInMap("scan_interval")]
        [Validation(Required=false)]
        public string ScanInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether the cluster autoscaler scales in nodes that host pods mounted with local volumes, such as EmptyDir or HostPath volumes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: does not allow the cluster autoscaler to scale in these nodes.</description></item>
        /// <item><description><c>false</c>: allows the cluster autoscaler to scale in these nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("skip_nodes_with_local_storage")]
        [Validation(Required=false)]
        public bool? SkipNodesWithLocalStorage { get; set; }

        /// <summary>
        /// <para>Specifies whether the cluster autoscaler scales in nodes that host pods in the kube-system namespace. This parameter does not take effect on pods created by DaemonSets and mirror pods. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: does not allow the cluster autoscaler to scale in these nodes.</description></item>
        /// <item><description><c>false</c>: allows the cluster autoscaler to scale in these nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("skip_nodes_with_system_pods")]
        [Validation(Required=false)]
        public bool? SkipNodesWithSystemPods { get; set; }

        /// <summary>
        /// <para>The cooldown period. After the autoscaler performs a scale-out activity, the autoscaler waits a cooldown period before it can perform a scale-in activity. Newly added nodes can be removed in scale-in activities only after the cooldown period ends. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10 m</para>
        /// </summary>
        [NameInMap("unneeded_duration")]
        [Validation(Required=false)]
        public string UnneededDuration { get; set; }

        /// <summary>
        /// <para>The scale-in threshold. This threshold specifies the ratio of the resources that are requested by pods to the total resources on the node.</para>
        /// <para>A scale-in activity is performed only when the CPU utilization and memory utilization of a node are lower than the scale-in threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("utilization_threshold")]
        [Validation(Required=false)]
        public string UtilizationThreshold { get; set; }

    }

}
