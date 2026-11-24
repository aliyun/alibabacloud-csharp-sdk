// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoscalingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The delay for triggering scale-in. This is the time interval between detecting a scale-in requirement (reaching the scale-in threshold) and actually executing the scale-in operation (reducing the number of pods). Valid values: 1 to 60. Unit: minutes. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("cool_down_duration")]
        [Validation(Required=false)]
        public string CoolDownDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether cluster-autoscaler evicts DaemonSet pods on nodes during scale-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The pods are evicted.</description></item>
        /// <item><description>false: The pods are not evicted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("daemonset_eviction_for_nodes")]
        [Validation(Required=false)]
        public bool? DaemonsetEvictionForNodes { get; set; }

        /// <summary>
        /// <para>The node pool scale-out order policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>least-waste: the default policy. If multiple node pools can be scaled out, the system selects the node pool that wastes the least resources.</description></item>
        /// <item><description>random: the random policy. If multiple node pools can be scaled out, the system randomly selects a node pool.</description></item>
        /// <item><description>priority: the priority policy. If multiple node pools can be scaled out, the system selects the node pool with the highest priority based on the custom scaling group order. The node pool priority is defined by the priorities parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>least-waste</para>
        /// </summary>
        [NameInMap("expander")]
        [Validation(Required=false)]
        public string Expander { get; set; }

        /// <summary>
        /// <para>The GPU scale-in threshold, which is the ratio of requested resources to total resources on a node. A GPU node can be scaled in only when this ratio is lower than the configured threshold, meaning that the CPU, memory, and GPU utilization of the node are all lower than the GPU scale-in threshold. Valid values: 0.1 to 1. Default value: 0.3, which indicates 30%.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.3</para>
        /// </summary>
        [NameInMap("gpu_utilization_threshold")]
        [Validation(Required=false)]
        public string GpuUtilizationThreshold { get; set; }

        /// <summary>
        /// <para>The timeout period for cluster-autoscaler to wait for pod termination during node draining in a scale-in scenario. Unit: seconds. Default value: 14400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14400</para>
        /// </summary>
        [NameInMap("max_graceful_termination_sec")]
        [Validation(Required=false)]
        public int? MaxGracefulTerminationSec { get; set; }

        /// <summary>
        /// <para>The minimum number of pods allowed in each ReplicaSet before a node is scaled in. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("min_replica_count")]
        [Validation(Required=false)]
        public int? MinReplicaCount { get; set; }

        /// <summary>
        /// <para>The auto scaling priority configuration. After you create a node pool with auto scaling enabled, you can choose whether to configure the priority policy and priority configuration by referring to <a href="https://help.aliyun.com/document_detail/119099.html">Enable auto scaling for nodes</a>. This allows you to configure priorities for the scaling groups of specified auto scaling node pools. Valid values: 1 to 100. The value must be a positive integer. A larger value indicates a higher priority.</para>
        /// </summary>
        [NameInMap("priorities")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> Priorities { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the corresponding Kubernetes node objects after nodes are successfully scaled in fast mode. For more information about fast mode, see <a href="https://help.aliyun.com/document_detail/119099.html">Scaling modes</a>. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Kubernetes node objects are also deleted after nodes are stopped in fast mode. Do not set this parameter to true because it may cause data inconsistency of Kubernetes objects.</description></item>
        /// <item><description>false: Kubernetes node objects are retained after nodes are stopped in fast mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("recycle_node_deletion_enabled")]
        [Validation(Required=false)]
        public bool? RecycleNodeDeletionEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow node scale-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Scale-in is allowed.</description></item>
        /// <item><description>false: Scale-in is prohibited.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("scale_down_enabled")]
        [Validation(Required=false)]
        public bool? ScaleDownEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether cluster-autoscaler performs scale-out when the number of ready nodes in the cluster is 0. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Scale-out is performed.</description></item>
        /// <item><description>false: Scale-out is not performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("scale_up_from_zero")]
        [Validation(Required=false)]
        public bool? ScaleUpFromZero { get; set; }

        /// <summary>
        /// <para>The auto scaling component type. For clusters of version 1.24 and later, the default value is goatscaler. For clusters of earlier versions, the default value is cluster-autoscaler. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>goatscaler: instant elasticity.</description></item>
        /// <item><description>cluster-autoscaler: auto scaling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>goatscaler</para>
        /// </summary>
        [NameInMap("scaler_type")]
        [Validation(Required=false)]
        public string ScalerType { get; set; }

        /// <summary>
        /// <para>The auto scaling sensitivity, which is used to adjust the interval at which the system evaluates scaling. Valid values: 15, 30, 60, 120, 180, and 300. Unit: seconds. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("scan_interval")]
        [Validation(Required=false)]
        public string ScanInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether cluster-autoscaler scales in nodes that contain pods with local storage, such as EmptyDir or HostPath. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The nodes are not scaled in.</description></item>
        /// <item><description>false: The nodes are scaled in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("skip_nodes_with_local_storage")]
        [Validation(Required=false)]
        public bool? SkipNodesWithLocalStorage { get; set; }

        /// <summary>
        /// <para>Specifies whether cluster-autoscaler scales in nodes that run pods in the kube-system namespace. This feature does not take effect for DaemonSet pods and mirror pods. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The nodes are not scaled in.</description></item>
        /// <item><description>false: The nodes are scaled in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("skip_nodes_with_system_pods")]
        [Validation(Required=false)]
        public bool? SkipNodesWithSystemPods { get; set; }

        /// <summary>
        /// <para>The cool-down period. This is the time interval during which the auto scaling component does not perform scale-in after the most recent scale-out is completed. Scaled-out nodes can be evaluated for scale-in only after the cool-down period ends. Valid values: 1 to 60. Unit: minutes. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("unneeded_duration")]
        [Validation(Required=false)]
        public string UnneededDuration { get; set; }

        /// <summary>
        /// <para>The scale-in threshold, which is the ratio of requested resources to total resources on a node. A node can be scaled in only when this ratio is lower than the configured threshold, meaning that the utilization of both CPU and memory resources on the node is lower than the scale-in threshold. Valid values: 0.1 to 1. Default value: 0.5, which indicates 50%.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("utilization_threshold")]
        [Validation(Required=false)]
        public string UtilizationThreshold { get; set; }

    }

}
