// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoscalingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The cool-down duration for scale-in events. This is the time interval from when the system detects a node is eligible for a scale-in to when the scale-in operation is executed.</para>
        /// <para>Valid values: 1 to 60. Unit: minutes.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("cool_down_duration")]
        [Validation(Required=false)]
        public string CoolDownDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether <c>cluster-autoscaler</c> evicts DaemonSet Pods from nodes during a scale-in event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Perform eviction.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Do not perform eviction.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("daemonset_eviction_for_nodes")]
        [Validation(Required=false)]
        public bool? DaemonsetEvictionForNodes { get; set; }

        /// <summary>
        /// <para>The strategy for selecting a node pool for a scale-out when multiple node pools are available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>least-waste</c>: The default strategy. The scaler selects the node pool that will have the least idle resources after a scale-out.</para>
        /// </description></item>
        /// <item><description><para><c>random</c>: The scaler selects a random node pool from the list of eligible node pools.</para>
        /// </description></item>
        /// <item><description><para><c>priority</c>: The scaler selects the node pool that has the highest priority. You must configure the priority of each scaling group by using the <c>priorities</c> parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>least-waste</para>
        /// </summary>
        [NameInMap("expander")]
        [Validation(Required=false)]
        public string Expander { get; set; }

        /// <summary>
        /// <para>The GPU utilization threshold for a scale-in on GPU nodes, which is the ratio of requested resources to total allocatable resources on a node.</para>
        /// <para>A GPU node is eligible for a scale-in only if its CPU, memory, and GPU utilization all fall below this threshold.</para>
        /// <para>Valid values: [0.1, 1].</para>
        /// <para>Default value: 0.3 (30%).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.3</para>
        /// </summary>
        [NameInMap("gpu_utilization_threshold")]
        [Validation(Required=false)]
        public string GpuUtilizationThreshold { get; set; }

        /// <summary>
        /// <para>The maximum duration in seconds that <c>cluster-autoscaler</c> waits for Pods to terminate during a node drain for a scale-in event.</para>
        /// <para>Unit: seconds.</para>
        /// <para>Default value: 14400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14400</para>
        /// </summary>
        [NameInMap("max_graceful_termination_sec")]
        [Validation(Required=false)]
        public int? MaxGracefulTerminationSec { get; set; }

        /// <summary>
        /// <para>The minimum number of Pods that must remain for any ReplicaSet after a scale-in operation. Nodes will not be scaled-in if doing so would violate this minimum.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("min_replica_count")]
        [Validation(Required=false)]
        public int? MinReplicaCount { get; set; }

        /// <summary>
        /// <para>Configures the priorities for scaling groups. This is used when the <c>expander</c> strategy is set to <c>priority</c>. After you create a node pool and enable autoscaling for it, you can configure the priority of its associated scaling group. For more information, see <a href="https://help.aliyun.com/document_detail/119099.html">Enable node autoscaling</a>.</para>
        /// <para>The priority must be a positive integer from 1 to 100. A larger value indicates a higher priority.</para>
        /// </summary>
        [NameInMap("priorities")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> Priorities { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the Kubernetes Node object after a node is successfully scaled-in using fast scaling mode. For more information, see <a href="https://help.aliyun.com/document_detail/119099.html">Scaling modes</a>. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The Node object is deleted after the instance is stopped. We do not recommend this setting because it can cause data inconsistencies in Kubernetes.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The Node object is retained after the instance is stopped.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("recycle_node_deletion_enabled")]
        [Validation(Required=false)]
        public bool? RecycleNodeDeletionEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow node scale-in operations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Allows scale-in operations.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables scale-in operations.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("scale_down_enabled")]
        [Validation(Required=false)]
        public bool? ScaleDownEnabled { get; set; }

        /// <summary>
        /// <para>Controls whether <c>cluster-autoscaler</c> performs a scale-out operation when there are no ready nodes in the cluster. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: A scale-out operation is performed.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: No scale-out operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("scale_up_from_zero")]
        [Validation(Required=false)]
        public bool? ScaleUpFromZero { get; set; }

        /// <summary>
        /// <para>The type of scaler to use. In clusters that run Kubernetes 1.24 or later, the default is goatscaler. In clusters that run an earlier version, the default is cluster-autoscaler. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>goatscaler</c>: The proprietary scaler for fast scaling.</para>
        /// </description></item>
        /// <item><description><para><c>cluster-autoscaler</c>: The standard Kubernetes cluster autoscaler.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>goatscaler</para>
        /// </summary>
        [NameInMap("scaler_type")]
        [Validation(Required=false)]
        public string ScalerType { get; set; }

        /// <summary>
        /// <para>The frequency at which the system checks for scaling conditions.</para>
        /// <para>Valid values: 15, 30, 60, 120, 180, and 300. Unit: seconds.</para>
        /// <para>Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("scan_interval")]
        [Validation(Required=false)]
        public string ScanInterval { get; set; }

        /// <summary>
        /// <para>Controls whether <c>cluster-autoscaler</c> can scale-in nodes that run Pods using local storage (for example, with <c>emptyDir</c> or <c>hostPath</c> volumes). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Prevents these nodes from being scaled-in.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Allows these nodes to be scaled-in.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("skip_nodes_with_local_storage")]
        [Validation(Required=false)]
        public bool? SkipNodesWithLocalStorage { get; set; }

        /// <summary>
        /// <para>Controls whether <c>cluster-autoscaler</c> can scale-in nodes that run Pods from the <c>kube-system</c> namespace. This setting does not affect DaemonSet or mirror Pods. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Prevents these nodes from being scaled-in.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Allows these nodes to be scaled-in.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("skip_nodes_with_system_pods")]
        [Validation(Required=false)]
        public bool? SkipNodesWithSystemPods { get; set; }

        /// <summary>
        /// <para>The stabilization window. This is the period after a scale-out event during which the scaler does not perform scale-in operations.</para>
        /// <para>Valid values: 1 to 60. Unit: minutes.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("unneeded_duration")]
        [Validation(Required=false)]
        public string UnneededDuration { get; set; }

        /// <summary>
        /// <para>The utilization threshold for a scale-in, which is the ratio of requested resources to the total allocatable resources on a node.</para>
        /// <para>A node is eligible for a scale-in only when both its CPU and memory utilization fall below this threshold.</para>
        /// <para>Valid values: [0.1, 1].</para>
        /// <para>Default value: 0.5 (50%).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("utilization_threshold")]
        [Validation(Required=false)]
        public string UtilizationThreshold { get; set; }

    }

}
