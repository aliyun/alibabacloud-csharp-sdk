// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoscalingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The scale-down trigger delay. The time interval between detecting a scale-down need (reaching the scale-down threshold) and actually performing the scale-down operation (reducing the number of Pods).</para>
        /// <para>Valid values: [1,60]. Unit: minutes.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("cool_down_duration")]
        [Validation(Required=false)]
        public string CoolDownDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether cluster-autoscaler evicts DaemonSet Pods on nodes during scale-down. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: DaemonSet Pods are evicted.</description></item>
        /// <item><description><c>false</c>: DaemonSet Pods are not evicted.</description></item>
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
        /// <item><description><c>least-waste</c>: The default policy. If multiple node pools are available for scale-out, the node pool with the least resource waste is selected.</description></item>
        /// <item><description><c>random</c>: The random policy. If multiple node pools are available for scale-out, a random node pool is selected.</description></item>
        /// <item><description><c>priority</c>: The priority policy. If multiple node pools are available for scale-out, the node pool with the highest priority is selected based on the custom scaling group order you defined. Node pool priorities are defined by the <c>priorities</c> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>least-waste</para>
        /// </summary>
        [NameInMap("expander")]
        [Validation(Required=false)]
        public string Expander { get; set; }

        /// <summary>
        /// <para>The GPU scale-down threshold. The ratio of requested resources to total resources on a node.</para>
        /// <para>A GPU node can be scaled down only when this ratio falls below the configured threshold, meaning the CPU, memory, and GPU utilization of the node are all below the GPU scale-down threshold.</para>
        /// <para>Valid values: [0.1~1].</para>
        /// <para>Default value: 0.3, which indicates 30%.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.3</para>
        /// </summary>
        [NameInMap("gpu_utilization_threshold")]
        [Validation(Required=false)]
        public string GpuUtilizationThreshold { get; set; }

        /// <summary>
        /// <para>The timeout period that cluster-autoscaler waits for Pod termination during node draining in scale-down scenarios.</para>
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
        /// <para>The minimum number of Pods allowed in each ReplicaSet before a node can be scaled down.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("min_replica_count")]
        [Validation(Required=false)]
        public int? MinReplicaCount { get; set; }

        /// <summary>
        /// <para>The priority configuration for automatic scaling. After you create a node pool with auto scaling enabled, you can choose whether to configure a priority policy and priority settings by using <a href="https://help.aliyun.com/document_detail/119099.html">Enable node auto scaling</a> to assign priorities to the scaling groups of specified auto scaling node pools.</para>
        /// <para>Valid values: [1, 100]. The value must be a positive integer. A larger value indicates a higher priority.</para>
        /// </summary>
        [NameInMap("priorities")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> Priorities { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the corresponding Kubernetes Node object after a node is successfully scaled down in swift mode. For more information about swift mode, see <a href="https://help.aliyun.com/document_detail/119099.html">Scaling modes</a>. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The Kubernetes Node object is deleted after the node is stopped in swift mode. Setting this parameter to true is not recommended because it may cause Kubernetes object data inconsistency.</description></item>
        /// <item><description><c>false</c>: The Kubernetes Node object is retained after the node is stopped in swift mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("recycle_node_deletion_enabled")]
        [Validation(Required=false)]
        public bool? RecycleNodeDeletionEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow node scale-down. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Scale-down is allowed.</description></item>
        /// <item><description><c>false</c>: Scale-down is not allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("scale_down_enabled")]
        [Validation(Required=false)]
        public bool? ScaleDownEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether cluster-autoscaler performs scale-out when the number of Ready nodes in the cluster is 0. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Scale-out is performed.</description></item>
        /// <item><description><c>false</c>: Scale-out is not performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("scale_up_from_zero")]
        [Validation(Required=false)]
        public bool? ScaleUpFromZero { get; set; }

        /// <summary>
        /// <para>The type of the auto scaling component. For clusters of version 1.24 and later, the default value is goatscaler. For earlier versions, the default value is cluster-autoscaler. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>goatscaler</c>: instant scaling.</para>
        /// </description></item>
        /// <item><description><para><c>cluster-autoscaler</c>: automatic scaling.</para>
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
        /// <para>The scaling sensitivity, which adjusts the interval at which the system evaluates scaling decisions.</para>
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
        /// <para>Specifies whether cluster-autoscaler skips scaling down nodes that run Pods with local storage (such as EmptyDir or HostPath). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Nodes are not scaled down.</description></item>
        /// <item><description><c>false</c>: Nodes are scaled down.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("skip_nodes_with_local_storage")]
        [Validation(Required=false)]
        public bool? SkipNodesWithLocalStorage { get; set; }

        /// <summary>
        /// <para>Specifies whether cluster-autoscaler skips scaling down nodes that run Pods in the kube-system namespace. This feature does not apply to DaemonSet Pods or Mirror Pods. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Nodes are not scaled down.</description></item>
        /// <item><description><c>false</c>: Nodes are scaled down.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("skip_nodes_with_system_pods")]
        [Validation(Required=false)]
        public bool? SkipNodesWithSystemPods { get; set; }

        /// <summary>
        /// <para>The cool-down period. The time interval after the most recent scale-out during which the auto scaling component does not perform scale-down operations. Nodes added during scale-out can only be evaluated for scale-down after the cool-down period expires.</para>
        /// <para>Valid values: [1,60]. Unit: minutes.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("unneeded_duration")]
        [Validation(Required=false)]
        public string UnneededDuration { get; set; }

        /// <summary>
        /// <para>The scale-down threshold. The ratio of requested resources to total resources on a node.</para>
        /// <para>A node can be scaled down only when this ratio falls below the configured threshold, meaning both the CPU and memory resources utilization of the node are below the scale-down threshold.</para>
        /// <para>Valid values: [0.1~1].</para>
        /// <para>Default value: 0.5, which indicates 50%.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("utilization_threshold")]
        [Validation(Required=false)]
        public string UtilizationThreshold { get; set; }

    }

}
