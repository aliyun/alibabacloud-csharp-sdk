// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodePoolDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The auto mode configuration.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyAutoMode AutoMode { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyAutoMode : TeaModel {
            /// <summary>
            /// <para>Specifies whether auto mode is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The auto scaling configuration of the node pool.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyAutoScaling AutoScaling { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyAutoScaling : TeaModel {
            /// <summary>
            /// <para>The peak bandwidth of the elastic IP address (EIP). Valid values: 1 to 100. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            public long? EipBandwidth { get; set; }

            /// <summary>
            /// <para>The billing method of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>: pay-by-bandwidth</description></item>
            /// <item><description><c>PayByTraffic</c>: pay-by-data-transfer</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// <para>Specifies whether auto scaling is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enables auto scaling for the node pool. When the capacity planning of the cluster cannot meet the scheduling requirements of application pods, ACK automatically scales the node resources based on the configured minimum and maximum numbers of instances. For clusters of Kubernetes 1.24 and later, node instant elasticity is enabled by default. For clusters earlier than Kubernetes 1.24, node auto scaling is enabled by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node scaling</a>.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disables auto scaling. ACK adjusts the number of nodes in the node pool based on the configured expected number of nodes and always maintains the number of nodes at the expected value.</para>
            /// </description></item>
            /// </list>
            /// <para>If this parameter is set to false, other configuration parameters in <c>auto_scaling</c> do not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>Specifies whether to associate an EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: associates an EIP.</description></item>
            /// <item><description><c>false</c>: does not associate an EIP.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// <para>The maximum number of scalable instances in the node pool, excluding existing instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of scalable instances in the node pool, excluding existing instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// <para>The auto scaling type, which is classified by the type of auto scaling instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cpu</c>: regular instance</description></item>
            /// <item><description><c>gpu</c>: GPU-accelerated instance</description></item>
            /// <item><description><c>gpushare</c>: shared GPU-accelerated instance</description></item>
            /// <item><description><c>spot</c>: spot instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cpu</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The Lingjun node group information.</para>
        /// </summary>
        [NameInMap("eflo_node_group")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyEfloNodeGroup EfloNodeGroup { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyEfloNodeGroup : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable automatic addition to the Lingjun node pool.</para>
            /// </summary>
            [NameInMap("auto_attach_enabled")]
            [Validation(Required=false)]
            public bool? AutoAttachEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the Lingjun cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i113790071760688002461</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The ID of the Lingjun group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i128147721760688002463</para>
            /// </summary>
            [NameInMap("group_id")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the worker RAM role used by the Lingjun node pool.</para>
            /// </summary>
            [NameInMap("worker_ram_role_name")]
            [Validation(Required=false)]
            public string WorkerRamRoleName { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether pods in the node pool use the host network mode. Valid values:</para>
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

        /// <summary>
        /// <para><b>[Deprecated]</b> The network configuration related to the edge node pool. This parameter is valid only for node pools whose type is edge.</para>
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyInterconnectConfig InterconnectConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyInterconnectConfig : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b> The network bandwidth of the edge-enhanced node pool. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The instance ID of the Cloud Connect Network (CCN) attached to the edge-enhanced node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccn-qm5i0i0q9yi*******</para>
            /// </summary>
            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            public string CcnId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The region of the CCN instance associated with the edge-enhanced node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            public string CcnRegionId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The instance ID of the Cloud Enterprise Network (CEN) attached to the edge-enhanced node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-ey9k9nfhz0f*******</para>
            /// </summary>
            [NameInMap("cen_id")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The subscription duration of the edge-enhanced node pool. Unit: months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("improved_period")]
            [Validation(Required=false)]
            public string ImprovedPeriod { get; set; }

        }

        /// <summary>
        /// <para>The network type of the edge node pool. This parameter takes effect only when <c>type</c> is set to <c>edge</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>basic</c>: Internet. Nodes in cloud node pool interact with cloud nodes over the Internet. Applications in cloud node pool cannot directly access the internal network of the cloud VPC.</description></item>
        /// <item><description><c>private</c>: private network. Nodes in cloud node pool connect the cloud and on-premises networks through Express Connect circuits, VPNs, or CEN. This provides higher cloud-edge communication quality and more effective security protection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("interconnect_mode")]
        [Validation(Required=false)]
        public string InterconnectMode { get; set; }

        /// <summary>
        /// <para>Specifies whether Layer 3 network connectivity is enabled among nodes in the edge node pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enabled. Layer 3 network connectivity is enabled among all nodes in the node pool.</description></item>
        /// <item><description><c>false</c>: disabled. Layer 3 network connectivity is disabled among all hosts in the node pool.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("intranet")]
        [Validation(Required=false)]
        public bool? Intranet { get; set; }

        /// <summary>
        /// <para>The cluster-related configurations.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyKubernetesConfig KubernetesConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to install the CloudMonitor agent on ECS nodes. After the agent is installed, you can view the monitoring information of the created ECS instances in the CloudMonitor console. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: installs the CloudMonitor agent on ECS nodes.</description></item>
            /// <item><description><c>false</c>: does not install the CloudMonitor agent on ECS nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }

            /// <summary>
            /// <para>The CPU management policy for nodes. The following two policies are supported when the cluster version is 1.12.6 or later:</para>
            /// <list type="bullet">
            /// <item><description><c>static</c>: allows you to enhance the CPU affinity and exclusivity for pods with specific resource characteristics on the node.</description></item>
            /// <item><description><c>none</c>: indicates that the existing default CPU affinity scheme is used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("cpu_policy")]
            [Validation(Required=false)]
            public string CpuPolicy { get; set; }

            /// <summary>
            /// <para>The node labels.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>The custom node name.</para>
            /// <para>A node name consists of three parts: prefix + node IP address substring + suffix:</para>
            /// <list type="bullet">
            /// <item><description>The prefix and suffix can each consist of one or more parts separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). The node name must start and end with a lowercase letter or a digit.</description></item>
            /// <item><description>The IP address substring length refers to the number of digits truncated from the end of the node IP address. Valid values: 5 to 12.</description></item>
            /// </list>
            /// <para>For example, if the node IP address is 192.168.0.55, the specified prefix is aliyun.com, the IP address substring length is 5, and the suffix is test, the node name is aliyun.com00055test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com192.XX.YY.55test</para>
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// <para>The pre-custom data of the node pool, which is the script that runs before node initialization. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Generate instance user data</a>.</para>
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
            /// <item><description>containerd: recommended. Supported by all cluster versions.</description></item>
            /// <item><description>Sandboxed-Container.runv: sandboxed container. Provides higher isolation. Supported by clusters of version 1.31 and earlier.</description></item>
            /// <item><description>docker: no longer maintained. Supported by clusters of version 1.22 and earlier.</description></item>
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
            /// <para>The node taint information. Taints and tolerations work together to prevent pods from being scheduled onto inappropriate nodes. For more information, see <a href="https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/">taint-and-toleration</a>.</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>Specifies whether nodes are unschedulable after a scale-out. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The nodes are unschedulable.</para>
            /// </description></item>
            /// <item><description><para>false: The nodes are schedulable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("unschedulable")]
            [Validation(Required=false)]
            public bool? Unschedulable { get; set; }

            /// <summary>
            /// <para>The custom data of the node pool, which is the script that runs after node initialization. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Generate instance user data</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyEvYmluL3NoCmVjaG8gIkhlbGxvIEFDSyEi</para>
            /// </summary>
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The managed node pool configuration.</para>
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyManagement Management { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyManagement : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable ECS fault detection for node self-healing.</para>
            /// </summary>
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>The auto repair feature. This feature takes effect only when <c>enable</c> is set to <c>true</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables auto repair.</description></item>
            /// <item><description><c>false</c>: disables auto repair.</description></item>
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
            public DescribeClusterNodePoolDetailResponseBodyManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether manual approval is required for node repair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("approval_required")]
                [Validation(Required=false)]
                public bool? ApprovalRequired { get; set; }

                /// <summary>
                /// <para>The ID of the auto-repair policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("auto_repair_policy_id")]
                [Validation(Required=false)]
                public string AutoRepairPolicyId { get; set; }

                /// <summary>
                /// <para>The maximum number or percentage of nodes that can be repaired simultaneously when a large number of abnormal nodes exist in the node pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_parallel_repairing_nodes")]
                [Validation(Required=false)]
                public string MaxParallelRepairingNodes { get; set; }

                /// <summary>
                /// <para>The circuit breaker threshold for auto-repair. When the number or percentage of failed nodes exceeds this threshold, the auto-repair process enters the circuit breaker state and stops initiating new repair actions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10%</para>
                /// </summary>
                [NameInMap("max_unhealthy_nodes_threshold")]
                [Validation(Required=false)]
                public string MaxUnhealthyNodesThreshold { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restarts. This parameter takes effect only when auto_repair is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Node restarts are allowed.</description></item>
                /// <item><description>false: Node restarts are not allowed.</description></item>
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
            /// <item><description>true: Auto-upgrade is enabled.</description></item>
            /// <item><description>false: Auto-upgrade is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_upgrade")]
            [Validation(Required=false)]
            public bool? AutoUpgrade { get; set; }

            /// <summary>
            /// <para>The auto-upgrade policy.</para>
            /// </summary>
            [NameInMap("auto_upgrade_policy")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow automatic kubelet upgrades. This parameter takes effect only when auto_upgrade is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Automatic kubelet upgrades are allowed.</description></item>
                /// <item><description>false: Automatic kubelet upgrades are not allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically fix CVEs. This parameter takes effect only when enable is set to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Automatic CVE fixes are allowed.</description></item>
            /// <item><description>false: Automatic CVE fixes are not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_vul_fix")]
            [Validation(Required=false)]
            public bool? AutoVulFix { get; set; }

            /// <summary>
            /// <para>The automatic CVE fix policy.</para>
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>The packages to be excluded during vulnerability fixes.</para>
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
                /// <item><description>true: Node restarts are allowed.</description></item>
                /// <item><description>false: Node restarts are not allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// <para>The vulnerability levels that are allowed for automatic fixes, separated by commas. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>asap: high</description></item>
                /// <item><description>later: medium</description></item>
                /// <item><description>nntf: low</description></item>
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
            /// <para>Specifies whether to enable the node rotation capability. This feature is supported only by intelligent managed node pools and is enabled by default. Common node pools do not support this feature.</para>
            /// </summary>
            [NameInMap("drift_enabled")]
            [Validation(Required=false)]
            public bool? DriftEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the managed node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The managed node pool is enabled.</description></item>
            /// <item><description>false: The managed node pool is disabled. Other related configurations take effect only when enable is set to true.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The auto-upgrade configuration. This parameter takes effect only when enable is set to true.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyManagementUpgradeConfig UpgradeConfig { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyManagementUpgradeConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable auto-upgrade. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Auto-upgrade is enabled.</description></item>
                /// <item><description>false: Auto-upgrade is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// <para>The maximum number of unavailable nodes. Valid values: 1 to 1000.</para>
                /// <para>Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// <para>The number of surge nodes. This parameter and surge_percentage are mutually exclusive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>The percentage of surge nodes. This parameter and surge are mutually exclusive.</para>
                /// <para>The number of surge nodes is calculated by multiplying the surge node percentage by the total number of nodes. For example, if the surge node percentage is set to 50% and the total number of nodes is 6, the number of surge nodes generated is 50% × 6 = 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("surge_percentage")]
                [Validation(Required=false)]
                public long? SurgePercentage { get; set; }

            }

        }

        /// <summary>
        /// <para><b>[Deprecated]</b> The maximum number of nodes that an edge node pool can accommodate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        public long? MaxNodes { get; set; }

        /// <summary>
        /// <para>The list of node components.</para>
        /// </summary>
        [NameInMap("node_components")]
        [Validation(Required=false)]
        public List<DescribeClusterNodePoolDetailResponseBodyNodeComponents> NodeComponents { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyNodeComponents : TeaModel {
            /// <summary>
            /// <para>The configuration of the node component.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyNodeComponentsConfig Config { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyNodeComponentsConfig : TeaModel {
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
                public List<DescribeClusterNodePoolDetailResponseBodyNodeComponentsConfigEnvs> Envs { get; set; }
                public class DescribeClusterNodePoolDetailResponseBodyNodeComponentsConfigEnvs : TeaModel {
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
            /// <para>The version number of the custom configuration for the node component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("config_revision")]
            [Validation(Required=false)]
            public string ConfigRevision { get; set; }

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
        public DescribeClusterNodePoolDetailResponseBodyNodeConfig NodeConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyNodeConfig : TeaModel {
            /// <summary>
            /// <para>The kubelet parameter settings.</para>
            /// </summary>
            [NameInMap("kubelet_configuration")]
            [Validation(Required=false)]
            public KubeletConfig KubeletConfiguration { get; set; }

            /// <summary>
            /// <para>The node operating system configuration.</para>
            /// </summary>
            [NameInMap("node_os_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyNodeConfigNodeOsConfig NodeOsConfig { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyNodeConfigNodeOsConfig : TeaModel {
                /// <summary>
                /// <para>The huge page configuration.</para>
                /// </summary>
                [NameInMap("hugepage")]
                [Validation(Required=false)]
                public Hugepage Hugepage { get; set; }

                /// <summary>
                /// <para>The sysctl kernel parameter settings.</para>
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
        public DescribeClusterNodePoolDetailResponseBodyNodepoolInfo NodepoolInfo { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyNodepoolInfo : TeaModel {
            /// <summary>
            /// <para>The time when the node pool was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-10T14:25:37.285530433+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>Specifies whether the node pool is the default node pool. Typically, a cluster has only one default node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The node pool is the default node pool.</description></item>
            /// <item><description>false: The node pool is not the default node pool.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_default")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The name of the node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-nodepool</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The node pool ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np615c0e0966124216a0412e10afe0****</para>
            /// </summary>
            [NameInMap("nodepool_id")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjmb****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The node pool type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>ess</c>: standard node pool (includes managed and automatic scaling features).</description></item>
            /// <item><description><c>edge</c>: edge node pool.</description></item>
            /// <item><description><c>lingjun</c>: Lingjun node pool.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ess</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the node pool was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-15T15:39:45.41+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

        /// <summary>
        /// <para>The scaling group configurations of the node pool.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyScalingGroup ScalingGroup { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyScalingGroup : TeaModel {
            /// <summary>
            /// <para>Specifies whether auto-renewal is enabled for nodes. This parameter takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables auto-renewal.</description></item>
            /// <item><description><c>false</c>: disables auto-renewal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal duration for a single renewal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When PeriodUnit is set to Week: 1, 2, and 3.</description></item>
            /// <item><description>When PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
            /// </list>
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
            /// <para><b>[Deprecated]</b> Use the security_hardening_os parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("cis_enabled")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? CisEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the required number of ECS instances when <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c> and sufficient spot instances cannot be created due to price or inventory reasons. Valid values:</para>
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
            /// <para>The CPU options.</para>
            /// </summary>
            [NameInMap("cpu_options")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyScalingGroupCpuOptions CpuOptions { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyScalingGroupCpuOptions : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable nested virtualization. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>disabled: disables nested virtualization.</description></item>
                /// <item><description>enabled: enables nested virtualization.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("nested_virtualization")]
                [Validation(Required=false)]
                public string NestedVirtualization { get; set; }

            }

            /// <summary>
            /// <para>The combination of configurations such as the type and size of data cloud disks for nodes.</para>
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// <para>The deployment set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1d19mmbsv3jf6xxxxx</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>The expected number of nodes in the node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("desired_size")]
            [Validation(Required=false)]
            public long? DesiredSize { get; set; }

            /// <summary>
            /// <para>The block device initialization configurations.</para>
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
            /// <para>The custom image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20241218.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The operating system image type. We recommend that you use this field to specify the node operating system. Valid values:</para>
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
            /// <item><description><c>PrePaid</c>: subscription.</description></item>
            /// <item><description><c>PostPaid</c>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The metadata access configurations for ECS instances.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>The instance property configurations.</para>
            /// </summary>
            [NameInMap("instance_patterns")]
            [Validation(Required=false)]
            public List<InstancePatterns> InstancePatterns { get; set; }

            /// <summary>
            /// <para>The list of instance types for nodes.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The billing method for public IP addresses of nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
            /// <item><description>PayByTraffic: pay-by-traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The maximum outbound bandwidth for public IP addresses of nodes. Unit: Mbit/s. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>The key pair name. You must specify either this parameter or <c>login_password</c>. If the node pool is a managed node pool, only <c>key_pair</c> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pro-nodepool</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>Specifies whether to log on to the created ECS instances as a non-root user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: logs on as a non-root user (ecs-user).</description></item>
            /// <item><description>false: logs on as the root user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("login_as_non_root")]
            [Validation(Required=false)]
            public bool? LoginAsNonRoot { get; set; }

            /// <summary>
            /// <para>The SSH logon password. You must specify either this parameter or <c>key_pair</c>. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
            /// For security reasons, the password is encrypted in the query result.</para>
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
            /// <item><description><c>PRIORITY</c>: scales ECS instances based on the vSwitches (VSwitchIds.N) that you specify. If ECS instances cannot be created in the zone of the vSwitch with the highest priority, the system automatically uses the vSwitch with the next highest priority to create ECS instances.</description></item>
            /// <item><description><c>COST_OPTIMIZED</c>: creates ECS instances based on the unit price of vCPUs in ascending order. If the scaling configuration settings specify multiple instance types and the billing method is set to preemptible, the system preferentially creates spot instances. You can use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically create pay-as-you-go instances when spot instances cannot be created due to insufficient inventory.<remarks>
            /// <para><c>COST_OPTIMIZED</c> takes effect only when the scaling configuration settings specify multiple instance types or use spot instances.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><c>BALANCE</c>: evenly allocates ECS instances across the zones specified in the scaling group. If the distribution becomes unbalanced due to insufficient inventory, you can call the RebalanceInstances operation to balance the resources. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a>.
            /// Default value: <c>PRIORITY</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BALANCE</para>
            /// </summary>
            [NameInMap("multi_az_policy")]
            [Validation(Required=false)]
            public string MultiAzPolicy { get; set; }

            /// <summary>
            /// <para>The minimum number of pay-as-you-go instances required by the scaling group. Valid values: [0,1000\]. If the number of pay-as-you-go instances is less than this value, the system preferentially creates pay-as-you-go instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of pay-as-you-go instances among the instances that exceed the minimum number of pay-as-you-go instances (<c>on_demand_base_capacity</c>) required by the scaling group. Valid values: [0,100\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The subscription duration of nodes. This parameter takes effect and is required only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When <c>period_unit</c> is set to <c>Week</c>: 1, 2, 3, and 4.</description></item>
            /// <item><description>When <c>period_unit</c> is set to <c>Month</c>: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The subscription epoch of nodes. This parameter is required when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Month</c>: uses month as the compute unit (CU).</description></item>
            /// <item><description><c>Week</c>: uses week as the compute unit (CU).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The operating system distribution. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>CentOS</c></description></item>
            /// <item><description><c>AliyunLinux</c></description></item>
            /// <item><description><c>Windows</c></description></item>
            /// <item><description><c>WindowsCore</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The private node pool configurations.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// <para>The private node pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The private pool capacity matching criteria for instance startup. After an elasticity assurance or capacity reservation takes effect, a private pool is generated for you to select when you start instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>Open</c>: open mode. The system automatically matches the capacity of an open private pool. If no matching private pool capacity is available, the system uses public pool resources to start the instance. In this mode, you do not need to specify the PrivatePoolOptions.Id parameter.</description></item>
                /// <item><description><c>Target</c>: specified mode. The system uses the capacity of the specified private pool to start the instance. If the specified private pool capacity is unavailable, the instance fails to start. In this mode, you must specify the private pool ID by setting the PrivatePoolOptions.Id parameter.</description></item>
                /// <item><description><c>None</c>: no private pool mode. The system does not use private pool capacity to start the instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Open</para>
                /// </summary>
                [NameInMap("match_criteria")]
                [Validation(Required=false)]
                public string MatchCriteria { get; set; }

            }

            /// <summary>
            /// <para><b>[Deprecated]</b> Use the ram_role_name parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KubernetesWorkerRole-021dc54f-929b-437a-8ae0-34c24d3e****</para>
            /// </summary>
            [NameInMap("ram_policy")]
            [Validation(Required=false)]
            public string RamPolicy { get; set; }

            /// <summary>
            /// <para>The name of the RAM role for worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KubernetesWorkerRole-4a4fa089-80c1-48a5-b3c6-9349311f****</para>
            /// </summary>
            [NameInMap("ram_role_name")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>If ApsaraDB RDS instances are specified, the ECS instances in the cluster are automatically added to the whitelist of the RDS instances.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>The resource pool and resource pool policy used when creating instances.</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyScalingGroupResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>The list of private pool IDs.</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>The resource pool strategy used to create instances. Valid values:
                /// PrivatePoolFirst: Private pools are prioritized.
                /// PrivatePoolOnly: Only private pools are used.
                /// None: No resource pool strategy is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrivatePoolFirst</para>
                /// </summary>
                [NameInMap("strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

            }

            /// <summary>
            /// <para>The scaling group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-2zeieod8giqmov7z****</para>
            /// </summary>
            [NameInMap("scaling_group_id")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The scaling group pattern. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>release</c>: standard pattern. Scales by creating and releasing ECS instances based on the requested resource usage.</description></item>
            /// <item><description><c>recycle</c>: extreme pattern. Scales by creating, stopping, and starting instances to improve scaling speed. When an instance is stopped, compute resources are not billed, but storage resources are billed, except for instances with local disks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>release</para>
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// <para>The security group ID of the node pool. If multiple security groups are bound to the node pool, this is the first value in <c>security_group_ids</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2ze60ockeekspl3d****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The list of security group IDs for the node pool.</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Alibaba Cloud OS security hardening. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables Alibaba Cloud OS security hardening.</description></item>
            /// <item><description><c>false</c>: does not enable Alibaba Cloud OS security hardening.</description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("security_hardening_os")]
            [Validation(Required=false)]
            public bool? SecurityHardeningOs { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable MLPS 2.0 security hardening. You can enable this feature for nodes only when the system image is Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3. Alibaba Cloud provides classified protection compliance baseline check standards and scanning programs for the MLPS 2.0 Level 3 images of Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// <para>The number of available instance types. The scaling group evenly creates spot instances across multiple instance types with the lowest cost. Valid values: [1, 10].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable spot instance replenishment. After this feature is enabled, when a system message indicating that a spot instance will be reclaimed is received, the scaling group attempts to create a new instance to replace the spot instance to be reclaimed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables spot instance replenishment.</description></item>
            /// <item><description><c>false</c>: disables spot instance replenishment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// <para>The market price range configuration for spot instances.</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<DescribeClusterNodePoolDetailResponseBodyScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyScalingGroupSpotPriceLimit : TeaModel {
                /// <summary>
                /// <para>The instance type of the spot instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c6.large</para>
                /// </summary>
                [NameInMap("instance_type")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The market price of a single instance.</para>
                /// <para>&lt;props=&quot;china&quot;&gt;Unit: CNY/hour.</para>
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
            /// <item><description>NoSpot: non-spot instance.</description></item>
            /// <item><description>SpotWithPriceLimit: sets a maximum price for spot instances.</description></item>
            /// <item><description>SpotAsPriceGo: uses automatic system bidding, which follows the actual market price.</description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/157759.html">Spot instances</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the burst mode (performance burst) for the system disk of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the burst mode. After this feature is enabled, when a volatile business faces sudden data read and write pressure, the cloud disk temporarily improves its performance based on the actual business conditions until the business returns to a stable state.</description></item>
            /// <item><description>false: disables the burst mode.</description></item>
            /// </list>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The categories of the system disk. If a high-priority disk category is unavailable, the system automatically attempts to use the next priority disk category to create the system disk.</para>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The category of the node system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_efficiency</c>: ultra disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
            /// <item><description><c>cloud_essd</c>: ESSD.</description></item>
            /// <item><description><c>cloud_auto</c>: ESSD AutoPL cloud disk.</description></item>
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry cloud disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The encryption algorithm used for the system disk. Valid value: aes-256.</para>
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
            /// <item><description><c>true</c>: encrypts the system disk.</description></item>
            /// <item><description><c>false</c>: does not encrypt the system disk.</description></item>
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
            /// <para>The performance level of the node system disk. This parameter takes effect only for ESSD. The performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// <list type="bullet">
            /// <item><description>PL0: provides medium concurrent I/O performance and relatively stable read/write latency.</description></item>
            /// <item><description>PL1: provides medium concurrent I/O performance and relatively stable read/write latency.</description></item>
            /// <item><description>PL2: provides high concurrent I/O performance and stable read/write latency.</description></item>
            /// <item><description>PL3: provides extremely high concurrent I/O performance and highly stable read/write latency.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS for the node system disk.</para>
            /// <para>Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}. Baseline performance = min{1,800 + 50 × capacity, 50000}.</para>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the node system disk. Unit: GiB.</para>
            /// <para>Valid values: [20, 2048].</para>
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
            /// <para>sp-bp11g8z59rawcud9****</para>
            /// </summary>
            [NameInMap("system_disk_snapshot_policy_id")]
            [Validation(Required=false)]
            public string SystemDiskSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>The ECS instance labels.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>The list of vSwitch IDs.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The status of the node pool.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyStatus Status { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyStatus : TeaModel {
            /// <summary>
            /// <para>The current conditions of the node pool, which indicate the status information of the node pool in different dimensions.</para>
            /// </summary>
            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<DescribeClusterNodePoolDetailResponseBodyStatusConditions> Conditions { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyStatusConditions : TeaModel {
                /// <summary>
                /// <para>The time of the last status transition, in ISO 8601 format with time zone information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20**-**-30T10:39:00+08:00</para>
                /// </summary>
                [NameInMap("last_transition_time")]
                [Validation(Required=false)]
                public string LastTransitionTime { get; set; }

                /// <summary>
                /// <para>The detailed information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AutoUpgradeDisabled</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UpgradeDisabled</para>
                /// </summary>
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ImageUpgradeReady</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The number of failed nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("failed_nodes")]
            [Validation(Required=false)]
            public long? FailedNodes { get; set; }

            /// <summary>
            /// <para>The number of healthy nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("healthy_nodes")]
            [Validation(Required=false)]
            public long? HealthyNodes { get; set; }

            /// <summary>
            /// <para>The number of nodes being created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("initial_nodes")]
            [Validation(Required=false)]
            public long? InitialNodes { get; set; }

            /// <summary>
            /// <para>The number of offline nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("offline_nodes")]
            [Validation(Required=false)]
            public long? OfflineNodes { get; set; }

            /// <summary>
            /// <para>The number of nodes being removed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("removing_nodes")]
            [Validation(Required=false)]
            public long? RemovingNodes { get; set; }

            /// <summary>
            /// <para>The number of serving nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("serving_nodes")]
            [Validation(Required=false)]
            public long? ServingNodes { get; set; }

            /// <summary>
            /// <para>The state of the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>active</c>: Activated.</description></item>
            /// <item><description><c>scaling</c>: Scaling.</description></item>
            /// <item><description><c>removing</c>: Removing nodes.</description></item>
            /// <item><description><c>deleting</c>: Deleting.</description></item>
            /// <item><description><c>updating</c>: Updating.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The total number of nodes in the node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("total_nodes")]
            [Validation(Required=false)]
            public long? TotalNodes { get; set; }

        }

        /// <summary>
        /// <para>The TEE cluster configuration.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyTeeConfig TeeConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyTeeConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the TEE cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enabled.</description></item>
            /// <item><description><c>false</c>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("tee_enable")]
            [Validation(Required=false)]
            public bool? TeeEnable { get; set; }

        }

    }

}
