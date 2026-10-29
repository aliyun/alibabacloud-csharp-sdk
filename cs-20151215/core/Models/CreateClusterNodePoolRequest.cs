// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>The auto mode configuration of the node pool.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoMode AutoMode { get; set; }
        public class CreateClusterNodePoolRequestAutoMode : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables auto mode. This value is valid only when auto mode is enabled for the cluster.</description></item>
            /// <item><description>false: disables auto mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The elastic scaling configuration.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class CreateClusterNodePoolRequestAutoScaling : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b> Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <para>The peak bandwidth of the EIP. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            [Obsolete]
            public long? EipBandwidth { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b> Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <para>The billing method of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>: pay-by-bandwidth.</description></item>
            /// <item><description><c>PayByTraffic</c>: pay-by-data-transfer.</description></item>
            /// </list>
            /// <para>Default value: <c>PayByBandwidth</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            [Obsolete]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto scaling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enables auto scaling for the node pool. When the capacity planning of the cluster cannot meet the scheduling requirements of application pods, ACK automatically scales node resources based on the configured minimum and maximum numbers of instances. For clusters of version 1.24 and later, node instant elasticity is enabled by default. For clusters earlier than version 1.24, node auto scaling is enabled by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node auto scaling</a>.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disables auto scaling. ACK adjusts the number of nodes in the node pool based on the configured expected number of nodes to keep the number of nodes at the expected value.</para>
            /// </description></item>
            /// </list>
            /// <para>If this parameter is set to false, other configuration parameters in <c>auto_scaling</c> do not take effect.</para>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b> Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <para>Specifies whether to associate an EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: associates an EIP.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: does not associate an EIP.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// <para>The maximum number of scalable instances in the node pool, excluding existing instances. This parameter takes effect only when <c>enable</c> is set to true.</para>
            /// <para>Valid values: [min_instances, 2000]. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of scalable instances in the node pool, excluding existing instances. This parameter takes effect only when <c>enable</c> is set to true.</para>
            /// <para>Valid values: [0, max_instances]. Default value: 0.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If the minimum number of instances is not 0, the automatic creation of the corresponding number of ECS instances occurs after the scaling group takes effect.</description></item>
            /// <item><description>The recommended Settings for the maximum number of instances should not be less than the current number of nodes in the node pool. Otherwise, the elastic scaling feature scales in the nodes in the node pool immediately after it takes effect.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// <para>The instance type for elastic scaling. This parameter takes effect only when <c>enable</c> is set to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cpu</c>: regular instance.</para>
            /// </description></item>
            /// <item><description><para><c>gpu</c>: GPU-accelerated instance.</para>
            /// </description></item>
            /// <item><description><para><c>gpushare</c>: GPU-shared instance.</para>
            /// </description></item>
            /// <item><description><para><c>spot</c>: spot instance.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>cpu</c>.</para>
            /// <remarks>
            /// <para>Notice: This parameter cannot be modified after the node pool is created.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cpu</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use desired_size instead.</para>
        /// <para>The number of nodes in the node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The Lingjun node pool configuration.</para>
        /// </summary>
        [NameInMap("eflo_node_group")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestEfloNodeGroup EfloNodeGroup { get; set; }
        public class CreateClusterNodePoolRequestEfloNodeGroup : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-attach for the Lingjun node pool.</para>
            /// </summary>
            [NameInMap("auto_attach_enabled")]
            [Validation(Required=false)]
            public bool? AutoAttachEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the Lingjun cluster to associate when creating the Lingjun node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i1169130516633730****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The ID of the Lingjun group in the Lingjun cluster to associate when creating the Lingjun node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-ec3c96ff0aa****</para>
            /// </summary>
            [NameInMap("group_id")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The worker RAM role used by the Lingjun node pool.</para>
            /// </summary>
            [NameInMap("worker_ram_role_name")]
            [Validation(Required=false)]
            public string WorkerRamRoleName { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the pod network mode uses the host network mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: host network. Pods directly use the network stack of the host and share the IP address and ports with the host.</description></item>
        /// <item><description><c>false</c>: container network. Pods have independent network stacks and do not occupy host network ports.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("host_network")]
        [Validation(Required=false)]
        public bool? HostNetwork { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// <para>The configuration of the edge node pool.</para>
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        [Obsolete]
        public CreateClusterNodePoolRequestInterconnectConfig InterconnectConfig { get; set; }
        public class CreateClusterNodePoolRequestInterconnectConfig : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The network bandwidth of the edge-enhanced node pool. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The instance ID of the Cloud Connect Network (CCN) attached to the edge-enhanced node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            public string CcnId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The region of the CCN instance associated with the edge-enhanced node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            public string CcnRegionId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The instance ID of the Cloud Enterprise Network (CEN) attached to the edge-enhanced node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("cen_id")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The subscription duration of the edge-enhanced node pool. Unit: months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("improved_period")]
            [Validation(Required=false)]
            public string ImprovedPeriod { get; set; }

        }

        /// <summary>
        /// <para>The network type of the edge node pool. This parameter takes effect only when <c>type</c> is set to <c>edge</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>basic</c>: Internet. Nodes in cloud node pool interact with cloud nodes over the Internet. Applications in cloud node pool cannot directly access the internal network of the cloud VPC.</description></item>
        /// <item><description><c>private</c>: private network. Nodes in cloud node pool connect to the cloud network through Express Connect circuits, VPNs, or CEN, which provides higher cloud-edge communication quality and more effective security protection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("interconnect_mode")]
        [Validation(Required=false)]
        public string InterconnectMode { get; set; }

        /// <summary>
        /// <para>Specifies whether Layer 3 network connectivity is enabled between nodes in the edge node pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enabled. Layer 3 network connectivity is enabled between all nodes in the node pool.</description></item>
        /// <item><description><c>false</c>: disabled. Layer 3 network connectivity is disabled between all hosts in the node pool.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("intranet")]
        [Validation(Required=false)]
        public bool? Intranet { get; set; }

        /// <summary>
        /// <para>The cluster configurations.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class CreateClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to install the CloudMonitor agent on ECS nodes. After the agent is installed, you can view the monitoring information of the created ECS instances in the CloudMonitor console. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The CloudMonitor agent is installed on ECS nodes.</description></item>
            /// <item><description><c>false</c>: The CloudMonitor agent is not installed on ECS nodes.
            /// Default value: <c>false</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }

            /// <summary>
            /// <para>The CPU management policy for nodes. The following two policies are supported when the cluster version is 1.12.6 or later:</para>
            /// <list type="bullet">
            /// <item><description><c>static</c>: Allows you to enhance CPU affinity and exclusivity for pods with specific resource characteristics on the node.</description></item>
            /// <item><description><c>none</c>: Uses the default CPU affinity scheme.
            /// Default value: <c>none</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("cpu_policy")]
            [Validation(Required=false)]
            public string CpuPolicy { get; set; }

            /// <summary>
            /// <para>The labels to be added to the nodes in the Kubernetes cluster.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>The custom node name. After you specify a custom node name, the node name, ECS instance name, and ECS instance hostname are changed accordingly.</para>
            /// <remarks>
            /// <para>For Windows instances with custom node names enabled, the hostname is fixed to the IP address, with hyphens (-) replacing periods (.) in the IP address, and without prefixes or suffixes. </para>
            /// </remarks>
            /// <para>The node name consists of a prefix, the node IP address, and a suffix:</para>
            /// <list type="bullet">
            /// <item><description>The total length is 2 to 64 characters. The node name must start and end with a lowercase letter or a digit.</description></item>
            /// <item><description>The prefix and suffix can contain uppercase and lowercase letters, digits, hyphens (-), and periods (.). They must start with a letter and cannot start or end with a hyphen (-) or a period (.). Consecutive hyphens (-) or periods (.) are not allowed.</description></item>
            /// <item><description>The prefix is required due to ECS limits, and the suffix is optional.</description></item>
            /// <item><description>The node IP address is the complete private IP address of the node.</description></item>
            /// </list>
            /// <para>For example, if the node IP address is 192.XX.YY.55, the prefix is aliyun.com, and the suffix is test:</para>
            /// <list type="bullet">
            /// <item><description>If the node is a Linux node, the node name, ECS instance name, and ECS instance hostname are all aliyun.com192.XX.YY.55test.</description></item>
            /// <item><description>If the node is a Windows node, the ECS instance hostname is 192-XX-YY-55, and both the node name and ECS instance name are aliyun.com192.XX.YY.55test.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com192.XX.YY.55test</para>
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// <para>The pre-custom data of the instance. Before the node is added to the cluster, the specified pre-custom data script is run. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User data scripts</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGhpcyBpcyBhIGV4YW1wbGU</para>
            /// </summary>
            [NameInMap("pre_user_data")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>The name of the container runtime. ACK supports the following three container runtimes:</para>
            /// <list type="bullet">
            /// <item><description><c>containerd</c>: Recommended. Supported by all cluster versions.</description></item>
            /// <item><description><c>Sandboxed-Container.runv</c>: Secure sandboxed containers that provide higher isolation. Supported by clusters of version 1.31 and earlier.</description></item>
            /// <item><description><c>docker</c>: Deprecated. Supported by clusters of version 1.22 and earlier.
            /// Default value: <c>containerd</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>The container runtime version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.6.38</para>
            /// </summary>
            [NameInMap("runtime_version")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }

            /// <summary>
            /// <para>The taint configuration.</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>Specifies whether the scaled-out nodes are unschedulable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The nodes are unschedulable.</description></item>
            /// <item><description><c>false</c>: The nodes are schedulable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("unschedulable")]
            [Validation(Required=false)]
            public bool? Unschedulable { get; set; }

            /// <summary>
            /// <para>The instance user data. After the node is added to the cluster, the specified instance user data script is run. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User data scripts</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGhpcyBpcyBhIGV4YW1wbGU=</para>
            /// </summary>
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The configurations for the managed node pool feature.</para>
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestManagement Management { get; set; }
        public class CreateClusterNodePoolRequestManagement : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable ECS fault detection for node auto-healing.</para>
            /// </summary>
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically repair nodes. This parameter takes effect only when enable is set to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Automatically repairs nodes.</description></item>
            /// <item><description><c>false</c>: Does not automatically repair nodes.
            /// Default value: <c>true</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// <para>The auto-repair policy for nodes.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether manual approval is required for node repair.</para>
                /// </summary>
                [NameInMap("approval_required")]
                [Validation(Required=false)]
                public bool? ApprovalRequired { get; set; }

                /// <summary>
                /// <para>The ID of the auto-repair policy. If you do not specify this parameter or specify an empty string, no auto-healing rule is bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("auto_repair_policy_id")]
                [Validation(Required=false)]
                public string AutoRepairPolicyId { get; set; }

                /// <summary>
                /// <para>The maximum number of nodes or the percentage of nodes that can be repaired simultaneously when a large number of abnormal nodes exist in the node pool. You can specify a number (for example, 5, valid values: 1 to 100000) or a percentage (for example, 10%, valid values: 1% to 100%). Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("max_parallel_repairing_nodes")]
                [Validation(Required=false)]
                public string MaxParallelRepairingNodes { get; set; }

                /// <summary>
                /// <para>The circuit breaker threshold for auto-healing. When the number or percentage of faulty nodes exceeds this threshold, auto-healing enters the circuit breaker state and stops initiating new auto-healing repair actions. You can specify a number (for example, 10, valid values: 1 to 100000) or a percentage (for example, 20%, valid values: 1% to 100%). Default value: 100%.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20%</para>
                /// </summary>
                [NameInMap("max_unhealthy_nodes_threshold")]
                [Validation(Required=false)]
                public string MaxUnhealthyNodesThreshold { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restarts. This parameter takes effect only when auto_repair is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allows node restarts.</description></item>
                /// <item><description><c>false</c>: Does not allow node restarts.
                /// Default value: <c>true</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically upgrade nodes. This parameter takes effect only when enable is set to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables auto-upgrade.</description></item>
            /// <item><description><c>false</c>: Disables auto-upgrade.
            /// Default value: <c>true</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_upgrade")]
            [Validation(Required=false)]
            public bool? AutoUpgrade { get; set; }

            /// <summary>
            /// <para>The auto-upgrade policy for nodes.</para>
            /// </summary>
            [NameInMap("auto_upgrade_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow automatic kubelet upgrades. This parameter takes effect only when auto_upgrade is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allows automatic kubelet upgrades.</description></item>
                /// <item><description><c>false</c>: Does not allow automatic kubelet upgrades.
                /// Default value: <c>true</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow automatic operating system upgrades. This parameter takes effect only when auto_upgrade is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allows automatic operating system upgrades.</description></item>
                /// <item><description><c>false</c>: Does not allow automatic operating system upgrades.
                /// Default value: <c>false</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("auto_upgrade_os")]
                [Validation(Required=false)]
                public bool? AutoUpgradeOs { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow automatic runtime upgrades. This parameter takes effect only when auto_upgrade is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allows automatic runtime upgrades.</description></item>
                /// <item><description><c>false</c>: Does not allow automatic runtime upgrades.
                /// Default value: <c>true</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("auto_upgrade_runtime")]
                [Validation(Required=false)]
                public bool? AutoUpgradeRuntime { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically repair CVE vulnerabilities. This parameter takes effect only when enable is set to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Allows automatic CVE repair.</description></item>
            /// <item><description><c>false</c>: Does not allow automatic CVE repair.
            /// Default value: <c>true</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_vul_fix")]
            [Validation(Required=false)]
            public bool? AutoVulFix { get; set; }

            /// <summary>
            /// <para>The auto-repair policy for CVE vulnerabilities.</para>
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>The packages to be excluded during vulnerability repair. Default value: <c>kernel</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kernel</para>
                /// </summary>
                [NameInMap("exclude_packages")]
                [Validation(Required=false)]
                public string ExcludePackages { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restarts. This parameter takes effect only when auto_vul_fix is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allows node restarts.</description></item>
                /// <item><description><c>false</c>: Does not allow node restarts.
                /// Default value: <c>true</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// <para>The vulnerability levels that are allowed for automatic repair, separated by commas. Example: <c>asap,later</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>asap</c>: High.</description></item>
                /// <item><description><c>later</c>: Medium.</description></item>
                /// <item><description><c>nntf</c>: Low.
                /// Default value: <c>asap</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>asap,nntf</para>
                /// </summary>
                [NameInMap("vul_level")]
                [Validation(Required=false)]
                public string VulLevel { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the node rotation feature. This feature is supported only by intelligent managed node pools and is enabled by default. It is not supported by regular node pools.</para>
            /// </summary>
            [NameInMap("drift_enabled")]
            [Validation(Required=false)]
            public bool? DriftEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the managed node pool feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables the managed node pool feature.</description></item>
            /// <item><description><c>false</c>: Disables the managed node pool feature. Other related configurations take effect only when this parameter is set to true.
            /// Default value: <c>false</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b> Use the auto_upgrade parameter at the upper level instead. The auto-upgrade configuration. This parameter takes effect only when enable is set to true.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public CreateClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class CreateClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para><b>[Deprecated]</b> Use the auto_upgrade parameter at the upper level instead. Specifies whether to enable auto-upgrade. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Enables auto-upgrade.</description></item>
                /// <item><description><c>false</c>: Disables auto-upgrade.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                [Obsolete]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// <para>The maximum number of unavailable nodes. Valid values: 1 to 1000. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// <para>The number of extra nodes. This parameter and surge_percentage are mutually exclusive. Nodes become unavailable during upgrades. You can create extra nodes to compensate for the cluster load.</para>
                /// <remarks>
                /// <para>The number of extra nodes should not exceed the current number of nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>The percentage of extra nodes. This parameter and surge are mutually exclusive. Number of extra nodes = Percentage of extra nodes × Number of nodes. For example, if the percentage of extra nodes is set to 50% and the current number of nodes is 6, the number of extra nodes generated is 50% × 6 = 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("surge_percentage")]
                [Validation(Required=false)]
                public long? SurgePercentage { get; set; }

            }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The maximum number of nodes that the edge node pool can accommodate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public long? MaxNodes { get; set; }

        /// <summary>
        /// <para>The list of node components.</para>
        /// </summary>
        [NameInMap("node_components")]
        [Validation(Required=false)]
        public List<CreateClusterNodePoolRequestNodeComponents> NodeComponents { get; set; }
        public class CreateClusterNodePoolRequestNodeComponents : TeaModel {
            /// <summary>
            /// <para>The configuration of the node component.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestNodeComponentsConfig Config { get; set; }
            public class CreateClusterNodePoolRequestNodeComponentsConfig : TeaModel {
                /// <summary>
                /// <para>The custom configuration of the node component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cpuManagerPolicy&quot;:&quot;static&quot;}</para>
                /// </summary>
                [NameInMap("custom_config")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomConfig { get; set; }

                /// <summary>
                /// <para>The environment variables of the node component.</para>
                /// </summary>
                [NameInMap("envs")]
                [Validation(Required=false)]
                public List<CreateClusterNodePoolRequestNodeComponentsConfigEnvs> Envs { get; set; }
                public class CreateClusterNodePoolRequestNodeComponentsConfigEnvs : TeaModel {
                    /// <summary>
                    /// <para>The name of the environment variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LOG_LEVEL</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>info</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the node component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubelet</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version of the node component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.33.3-aliyun.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The node configuration.</para>
        /// </summary>
        [NameInMap("node_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestNodeConfig NodeConfig { get; set; }
        public class CreateClusterNodePoolRequestNodeConfig : TeaModel {
            /// <summary>
            /// <para>The Kubelet parameter settings.</para>
            /// </summary>
            [NameInMap("kubelet_configuration")]
            [Validation(Required=false)]
            public KubeletConfig KubeletConfiguration { get; set; }

            /// <summary>
            /// <para>The operating system configuration of the node.</para>
            /// </summary>
            [NameInMap("node_os_config")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestNodeConfigNodeOsConfig NodeOsConfig { get; set; }
            public class CreateClusterNodePoolRequestNodeConfigNodeOsConfig : TeaModel {
                /// <summary>
                /// <para>The Transparent HugePages configuration.</para>
                /// </summary>
                [NameInMap("hugepage")]
                [Validation(Required=false)]
                public Hugepage Hugepage { get; set; }

                /// <summary>
                /// <para>The sysctl kernel parameter settings. Only specific kernel parameters are supported, and the cluster version must be 1.28 or later.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;fs.file-max&quot;:&quot;1048576&quot;}</para>
                /// </summary>
                [NameInMap("sysctl")]
                [Validation(Required=false)]
                public Dictionary<string, object> Sysctl { get; set; }

            }

        }

        /// <summary>
        /// <para>The node pool configuration.</para>
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class CreateClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// <para>The name of the node pool.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nodepool-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the node pool belongs. Instances added to the node pool belong to this resource group.</para>
            /// <para>A resource can belong to only one resource group. You can map resource groups to concepts such as projects, applications, or organizations based on your business scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjmb****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The type of the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>ess</c>: standard node pool, which supports managed features and automatic elastic scaling.</description></item>
            /// <item><description><c>edge</c>: edge node pool.</description></item>
            /// <item><description><c>lingjun</c>: Lingjun node pool.</description></item>
            /// <item><description><c>hybrid</c>: hybrid cloud node pool.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ess</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The scaling group configuration of the node pool.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class CreateClusterNodePoolRequestScalingGroup : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for nodes in the node pool. This parameter takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables auto-renewal.</description></item>
            /// <item><description><c>false</c>: disables auto-renewal.</description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The duration of each auto-renewal cycle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When PeriodUnit is set to Week: 1, 2, and 3.</description></item>
            /// <item><description>When PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
            /// </list>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b> Use the <c>security_hardening_os</c> parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("cis_enabled")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? CisEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the required number of ECS instances when spot instances cannot be created due to price or inventory issues, provided that <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: automatically creates pay-as-you-go instances to meet the required number of ECS instances.</description></item>
            /// <item><description><c>false</c>: does not automatically create pay-as-you-go instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("compensate_with_on_demand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// <para>The CPU-related configuration options.</para>
            /// </summary>
            [NameInMap("cpu_options")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestScalingGroupCpuOptions CpuOptions { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupCpuOptions : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable nested virtualization. Valid values: disabled: disables nested virtualization. enabled: enables nested virtualization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("nested_virtualization")]
                [Validation(Required=false)]
                public string NestedVirtualization { get; set; }

            }

            /// <summary>
            /// <para>The data cloud disk configuration for nodes in the node pool.</para>
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// <para>The ID of the deployment set. You can use a deployment set to distribute ECS instances created by the node pool across different physical servers to ensure high availability and underlying disaster recovery capabilities. When you create ECS instances in a deployment set, the instances are distributed and started in the specified region based on the predefined deployment policy.</para>
            /// <remarks>
            /// <para>Notice: After you select a deployment set, the maximum number of nodes in the node pool is limited. By default, a deployment set supports a maximum of 20 × the number of zones nodes. The number of zones is determined by the vSwitches. Proceed with caution and ensure that the quota in the deployment set is sufficient to prevent node scale-out failures.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1d19mmbsv3jf6xxxxx</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>The expected number of nodes in the node pool.</para>
            /// <para>This is the total number of nodes that the node pool should maintain. We recommend that you configure at least two nodes to ensure the normal operation of cluster components. You can scale out or scale in the node pool by adjusting the expected number of nodes.</para>
            /// <para>If you do not need to create nodes, set this parameter to 0 and manually increase the number of nodes later.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("desired_size")]
            [Validation(Required=false)]
            public long? DesiredSize { get; set; }

            /// <summary>
            /// <para>The block device initialization configuration.</para>
            /// </summary>
            [NameInMap("disk_init")]
            [Validation(Required=false)]
            public List<DiskInit> DiskInit { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the high-density cloud disk mode. This mode is supported only when the node pool uses instance types. After this mode is enabled, the total number of system cloud disks and data cloud disks does not exceed the maximum number of high-density cloud disks supported by the instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable_high_density_mode")]
            [Validation(Required=false)]
            public bool? EnableHighDensityMode { get; set; }

            /// <summary>
            /// <para>The ID of the custom image. By default, the system-provided image is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_2_1903_x64_20G_alibase_20200529.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The type of the operating system image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>AliyunLinux</c>: Alinux2 image.</description></item>
            /// <item><description><c>AliyunLinuxSecurity</c>: Alinux2 UEFI image.</description></item>
            /// <item><description><c>AliyunLinux3</c>: Alinux3 image.</description></item>
            /// <item><description><c>AliyunLinux3Arm64</c>: Alinux3 ARM image.</description></item>
            /// <item><description><c>AliyunLinux3Security</c>: Alinux3 UEFI image.</description></item>
            /// <item><description><c>CentOS</c>: CentOS image.</description></item>
            /// <item><description><c>Windows</c>: Windows image.</description></item>
            /// <item><description><c>WindowsCore</c>: Windows Core image.</description></item>
            /// <item><description><c>ContainerOS</c>: container-optimized image.</description></item>
            /// <item><description><c>AliyunLinux3ContainerOptimized</c>: Alinux3 container-optimized image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux3</para>
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The billing method of nodes in the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PrePaid</c>: subscription.</para>
            /// </description></item>
            /// <item><description><para><c>PostPaid</c>: pay-as-you-go.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>PostPaid</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The instance metadata access configuration for ECS instances.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>The instance property configuration.</para>
            /// </summary>
            [NameInMap("instance_patterns")]
            [Validation(Required=false)]
            public List<InstancePatterns> InstancePatterns { get; set; }

            /// <summary>
            /// <para>The list of instance types for nodes in the node pool. When the node pool scales out nodes, it selects instance types that meet the requirements from the specified list to create instances.</para>
            /// <para>Valid values for the number of instance types: 1 to 10.</para>
            /// <remarks>
            /// <para>To ensure high availability, we recommend that you select multiple instance types.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The billing method for public IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
            /// <item><description>PayByTraffic: pay-by-data-transfer.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByTraffic</para>
            /// </summary>
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The maximum outbound bandwidth for public IP addresses of nodes. Unit: Mbit/s. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>The name of the key pair used for password-free logon. You must specify either this parameter or <c>login_password</c>.</para>
            /// <remarks>
            /// <para>If the node pool uses the ContainerOS operating system, only <c>key_pair</c> is supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>np-key-name</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>Specifies whether to log on to the created ECS instances as a non-root user.</para>
            /// <list type="bullet">
            /// <item><description><para>true: logs on as a non-root user (ecs-user).</para>
            /// </description></item>
            /// <item><description><para>false: logs on as the root user.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("login_as_non_root")]
            [Validation(Required=false)]
            public bool? LoginAsNonRoot { get; set; }

            /// <summary>
            /// <para>The SSH logon password. You must specify either this parameter or <c>key_pair</c>. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The scaling policy for ECS instances in a multi-zone scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PRIORITY</c>: scales ECS instances based on the vSwitches (VSwitchIds.N) that you specify. If ECS instances cannot be created in the zone of the vSwitch with the highest priority, the system automatically uses the vSwitch with the next highest priority to create ECS instances.</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>: creates ECS instances based on the vCPU unit price in ascending order. When the scaling configuration specifies multiple instance types with the preemptible billing method, the system preferentially creates spot instances. You can use the <c>CompensateWithOnDemand</c> parameter to specify if it is to automatically create pay-as-you-go instances when spot instances cannot be created due to inventory shortages or other reasons.</para>
            /// <remarks>
            /// <para><c>COST_OPTIMIZED</c> takes effect only when the scaling configuration specifies multiple instance types or uses spot instances.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>: evenly allocates ECS instances across the zones specified in the scaling group. If the zones become unbalanced due to inventory shortages or other reasons, you can call the <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a> API operation to balance the resources.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>PRIORITY</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COST_OPTIMIZED</para>
            /// </summary>
            [NameInMap("multi_az_policy")]
            [Validation(Required=false)]
            public string MultiAzPolicy { get; set; }

            /// <summary>
            /// <para>The minimum number of pay-as-you-go instances required by the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than this value, the system preferentially creates pay-as-you-go instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of pay-as-you-go instances among the excess instances after the scaling group meets the minimum number of pay-as-you-go instances (<c>on_demand_base_capacity</c>). Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The subscription duration of nodes in the node pool. This parameter is required and takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <list type="bullet">
            /// <item><description>When <c>period_unit</c> is set to <c>Week</c>, valid values for <c>period</c> are 1, 2, 3, and 4.</description></item>
            /// <item><description>When <c>period_unit</c> is set to <c>Month</c>, valid values for <c>period</c> are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The billing cycle of nodes in the node pool. This parameter is required and takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <list type="bullet">
            /// <item><description><c>Month</c>: month.</description></item>
            /// <item><description><c>Week</c>: week.</description></item>
            /// </list>
            /// <para>Default value: <c>Month</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b> Use the <c>image_type</c> parameter instead.</para>
            /// <para>The operating system distribution. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>CentOS</c></description></item>
            /// <item><description><c>AliyunLinux</c></description></item>
            /// <item><description><c>Windows</c></description></item>
            /// <item><description><c>WindowsCore</c></description></item>
            /// </list>
            /// <para>Default value: <c>AliyunLinux</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            [Obsolete]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The private pool configuration.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// <para>The ID of the private pool. When <c>match_criteria</c> is set to <c>Target</c>, you must specify the private pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The private pool capacity matching mode for instance startup. After an elasticity assurance or capacity reservation takes effect, a private pool is generated for you to select when you start instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>Open</c>: open mode. The system automatically matches the capacity of an open private pool. If no eligible private pool capacity is available, the system uses public pool resources to start the instances.</description></item>
                /// <item><description><c>Target</c>: specified mode. The system uses the capacity of the specified private pool to start instances. If the specified private pool capacity is unavailable, the instances fail to start.</description></item>
                /// <item><description><c>None</c>: no private pool mode. The system does not use private pool capacity to start instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Target</para>
                /// </summary>
                [NameInMap("match_criteria")]
                [Validation(Required=false)]
                public string MatchCriteria { get; set; }

            }

            /// <summary>
            /// <para>The name of the worker RAM role.</para>
            /// <list type="bullet">
            /// <item><description>If this parameter is left empty, the default worker RAM role created for the cluster is used.</description></item>
            /// <item><description>If this parameter is specified, the RAM role must be a <b>normal service role</b> and its <b>trusted service</b> must be set to <b>ECS</b>. For more information, see <a href="https://help.aliyun.com/document_detail/116800.html">Create a normal service role</a>. If the specified RAM role is not the default worker RAM role created for the cluster, the role name cannot start with <c>KubernetesMasterRole-</c> or <c>KubernetesWorkerRole-</c>.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: This parameter is supported only by ACK managed clusters of version 1.22 and later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>example-role</para>
            /// </summary>
            [NameInMap("ram_role_name")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The list of ApsaraDB RDS instances.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>The resource pool and resource pool policy used for instance creation. Take note of the following items when you configure this parameter:
            /// This parameter takes effect only when you create pay-as-you-go instances.
            /// This parameter cannot be specified together with private_pool_options.match_criteria or private_pool_options.id.</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>The list of private pool IDs, which are the IDs of elasticity assurances or capacity reservations. You can specify only the IDs of private pools in Target mode. Valid values of N: 1 to 20.</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>The resource pool strategy used when creating instances. Resource pools include private pools generated after elasticity assurances or capacity reservations take effect, as well as public pools, which are available for selection during instance startup. Valid values:
                /// PrivatePoolFirst: Private pool first. When this strategy is selected and resouce_pool_options.private_pool_ids is specified, the specified private pools are used first. If no private pool is specified or the specified private pools have insufficient capacity, open private pools are automatically matched. If no eligible private pool is available, the public pool is used to create the instance.
                /// PrivatePoolOnly: Private pool only. When this strategy is selected, resouce_pool_options.private_pool_ids must be specified. If the specified private pools have insufficient capacity, the instance fails to start.
                /// None: No resource pool strategy is used.
                /// Default value: None.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrivatePoolFirst</para>
                /// </summary>
                [NameInMap("strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

            }

            /// <summary>
            /// <para>The scaling group mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>release</c>: Standard mode. Instances are scaled by creating and releasing ECS instances based on the requested resource usage.</description></item>
            /// <item><description><c>recycle</c>: Extreme mode. Instances are scaled by creating, stopping, and starting instances to improve the speed of subsequent scaling operations. When an instance is stopped, compute resources are not billed, and only storage fees are charged, except for instances with local disks.
            /// Default value: <c>release</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>release</para>
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The security group ID of the node pool. Specify either this parameter or security_group_ids. We recommend that you use security_group_ids.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-wz9a8g2mt6x5llu0****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The list of security group IDs. Specify either this parameter or security_group_id. We recommend that you use security_group_ids. If both security_group_id and security_group_ids are specified, security_group_ids takes precedence.</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Alibaba Cloud OS security hardening. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables Alibaba Cloud OS security hardening.</description></item>
            /// <item><description><c>false</c>: Does not enable Alibaba Cloud OS security hardening.
            /// Default value: <c>false</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("security_hardening_os")]
            [Validation(Required=false)]
            public bool? SecurityHardeningOs { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable MLPS 2.0 security hardening. You can enable MLPS 2.0 security hardening for nodes only when the system image is Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3. Alibaba Cloud provides baseline check standards and scanning programs for classified protection compliance for Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3 MLPS 2.0 Level 3 images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// <para>The number of available instance types. The scaling group evenly creates spot instances across multiple instance types with the lowest costs. Valid values: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable spot instance replenishment. After this feature is enabled, when the scaling group receives a system message that a spot instance will be reclaimed, it attempts to create a new instance to replace the spot instance to be reclaimed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables spot instance replenishment.</description></item>
            /// <item><description><c>false</c>: Does not enable spot instance replenishment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// <para>The market price range configuration for a single spot instance type.</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
                /// <summary>
                /// <para>The spot instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c6.large</para>
                /// </summary>
                [NameInMap("instance_type")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The maximum price per instance.
                /// &lt;props=&quot;china&quot;&gt;Unit: CNY/hour.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;Unit: USD/hour.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.39</para>
                /// </summary>
                [NameInMap("price_limit")]
                [Validation(Required=false)]
                public string PriceLimit { get; set; }

            }

            /// <summary>
            /// <para>The spot instance strategy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>NoSpot</c>: Non-spot instance.</description></item>
            /// <item><description><c>SpotWithPriceLimit</c>: Sets a maximum price for spot instances.</description></item>
            /// <item><description><c>SpotAsPriceGo</c>: The system automatically bids based on the current market price.
            /// For more information, see <a href="https://help.aliyun.com/document_detail/165053.html">Spot instances</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable performance burst for the node system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.
            /// This parameter is supported only when system_disk_category is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The categories of the system disk. If a higher-priority disk category is unavailable, the system automatically attempts to use the next priority disk category to create the system disk.</para>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The category of the node system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_efficiency</c>: Ultra cloud disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: Standard SSD.</description></item>
            /// <item><description><c>cloud_essd</c>: ESSD.</description></item>
            /// <item><description><c>cloud_auto</c>: ESSD AutoPL cloud disk.</description></item>
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry cloud disk.
            /// Default value: <c>cloud_efficiency</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The encryption algorithm used for the system disk. Valid values: aes-256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes-256</para>
            /// </summary>
            [NameInMap("system_disk_encrypt_algorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Encrypts the system disk.</description></item>
            /// <item><description>false: Does not encrypt the system disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("system_disk_encrypted")]
            [Validation(Required=false)]
            public bool? SystemDiskEncrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key used for the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("system_disk_kms_key_id")]
            [Validation(Required=false)]
            public string SystemDiskKmsKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the node system disk. This parameter takes effect only for ESSD cloud disks. The performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: Medium concurrent I/O performance and relatively stable read/write latency.</description></item>
            /// <item><description>PL1: Medium concurrent I/O performance and relatively stable read/write latency.</description></item>
            /// <item><description>PL2: High concurrent I/O performance and stable read/write latency.</description></item>
            /// <item><description>PL3: Extremely high concurrent I/O performance and highly stable read/write latency.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS for the node system disk. Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}. Baseline performance = min{1,800 + 50 × capacity, 50000}.
            /// This parameter is supported only when system_disk_category is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the node system disk. Unit: GiB. Valid values: 20 to 2048.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The snapshot policy for the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-0jl6xnmme8v7o935****</para>
            /// </summary>
            [NameInMap("system_disk_snapshot_policy_id")]
            [Validation(Required=false)]
            public string SystemDiskSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Adds tags only to ECS instances. Tag keys must be unique and can be up to 128 characters in length. Neither tag keys nor tag values can start with &quot;aliyun&quot; or &quot;acs:&quot;, or contain &quot;https://&quot; or &quot;http://&quot;.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupTags> Tags { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-k-1</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-v-1</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of vSwitch IDs. Valid values: 1 to 8.</para>
            /// <remarks>
            /// <para>To ensure high availability, we recommend that you select vSwitches in different zones.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The confidential computing cluster configuration.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class CreateClusterNodePoolRequestTeeConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the confidential computing cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enables confidential computing.</description></item>
            /// <item><description>false: Does not enable confidential computing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("tee_enable")]
            [Validation(Required=false)]
            public bool? TeeEnable { get; set; }

        }

    }

}
