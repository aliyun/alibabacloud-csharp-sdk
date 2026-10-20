// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoscalingConfigRequest : Darabonba.Model {
        /// <summary>
        /// <para>The scale-in trigger delay, which is the time interval between when a scale-in need is detected (the scale-in threshold is reached) and when the scale-in operation (reducing the number of Pods) is actually performed.</para>
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
        /// <para>Specifies whether cluster-autoscaler evicts DaemonSet Pods on a node during scale-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Eviction is performed.</description></item>
        /// <item><description><c>false</c>: Eviction is not performed.</description></item>
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
        /// <item><description><c>random</c>: The random policy. If multiple node pools are available for scale-out, a node pool is randomly selected.</description></item>
        /// <item><description><c>priority</c>: The priority policy. If multiple node pools are available for scale-out, the node pool with the highest priority based on your custom scaling group order is selected. Node pool priorities are defined by the <c>priorities</c> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>least-waste</para>
        /// </summary>
        [NameInMap("expander")]
        [Validation(Required=false)]
        public string Expander { get; set; }

        /// <summary>
        /// <para>The GPU scale-in threshold, which is the ratio of requested resources to total resources on a node.</para>
        /// <para>A GPU node can be scaled in only when this ratio falls below the configured threshold, meaning the CPU, memory, and GPU resource utilization of the node are all below the GPU scale-in threshold.</para>
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
        /// <para>The timeout period for cluster-autoscaler to wait for Pod termination during node draining in a scale-in scenario.</para>
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
        /// <para>The minimum number of Pods allowed in each ReplicaSet before a node can be scaled in.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("min_replica_count")]
        [Validation(Required=false)]
        public int? MinReplicaCount { get; set; }

        /// <summary>
        /// <para>The priority configuration for auto scaling. After you create a node pool with elastic scaling enabled, you can configure priority policies and priority settings for the scaling groups of specified auto scaling node pools by using <a href="https://help.aliyun.com/document_detail/119099.html">Enable node auto scaling</a>.</para>
        /// <para>Valid values: [1, 100]. The value must be a positive integer. A larger value indicates a higher priority.</para>
        /// </summary>
        [NameInMap("priorities")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> Priorities { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the corresponding Kubernetes Node object after a node in rapid mode is successfully scaled in. For more information about rapid mode, see <a href="https://help.aliyun.com/document_detail/119099.html">Scaling modes</a>. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The Kubernetes Node object is deleted after the node in rapid mode is stopped. Setting this parameter to true is not recommended because it may cause data inconsistency in Kubernetes objects.</description></item>
        /// <item><description><c>false</c>: The Kubernetes Node object is retained after the node in rapid mode is stopped.</description></item>
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
        /// <item><description><c>true</c>: Scale-in is allowed.</description></item>
        /// <item><description><c>false</c>: Scale-in is prohibited.</description></item>
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
        /// <para>The elastic component type. For clusters running version 1.24 or later, the default value is goatscaler. For earlier versions, the default value is cluster-autoscaler. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>goatscaler</c>: Instant scaling.</para>
        /// </description></item>
        /// <item><description><para><c>cluster-autoscaler</c>: Auto scaling.</para>
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
        /// <para>The scaling sensitivity, which adjusts the interval for the system to evaluate scaling decisions.</para>
        /// <para>Valid values: 15, 30, 60, 120, 180, 300. Unit: seconds.</para>
        /// <para>Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("scan_interval")]
        [Validation(Required=false)]
        public string ScanInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether cluster-autoscaler skips scale-in for nodes that run Pods with local storage (such as EmptyDir or HostPath). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Scale-in is skipped.</description></item>
        /// <item><description><c>false</c>: Scale-in is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("skip_nodes_with_local_storage")]
        [Validation(Required=false)]
        public bool? SkipNodesWithLocalStorage { get; set; }

        /// <summary>
        /// <para>Specifies whether cluster-autoscaler skips scale-in for nodes that run Pods in the kube-system namespace. This feature does not apply to DaemonSet Pods or Mirror Pods. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Scale-in is skipped.</description></item>
        /// <item><description><c>false</c>: Scale-in is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("skip_nodes_with_system_pods")]
        [Validation(Required=false)]
        public bool? SkipNodesWithSystemPods { get; set; }

        /// <summary>
        /// <para>The cool-down period. The time interval after the most recent scale-out event during which the elastic component does not perform scale-in operations. A node that is scaled out can be considered for scale-in only after the cool-down period elapses.</para>
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
        /// <para>The scale-in threshold, which is the ratio of requested resources to total resources on a node.</para>
        /// <para>A node can be scaled in only when this ratio falls below the configured threshold, meaning both the CPU and memory resources utilization of the node are below the scale-in threshold.</para>
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

