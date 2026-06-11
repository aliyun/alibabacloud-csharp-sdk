// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodePoolDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The smart hosting configurations.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyAutoMode AutoMode { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyAutoMode : TeaModel {
            /// <summary>
            /// <para>Indicates whether to enable the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the node pool that is configured for automatic scaling.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyAutoScaling AutoScaling { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyAutoScaling : TeaModel {
            /// <summary>
            /// <para>The peak EIP bandwidth.</para>
            /// <para>Valid values: 1 to 100. Unit: Mbit/s.</para>
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
            /// <item><description><para><c>PayByBandwidth</c>: pay-by-bandwidth.</para>
            /// </description></item>
            /// <item><description><para><c>PayByTraffic</c>: pay-by-traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// <para>Indicates whether to enable automatic scaling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enables automatic scaling for the node pool. If the resources of the cluster cannot meet the scheduling requirements of pods, ACK automatically scales out or in nodes based on the configured minimum and maximum numbers of instances. For clusters of Kubernetes 1.24 or later, node elastic scaling is enabled by default. For clusters of a Kubernetes version earlier than 1.24, node autoscaling is enabled by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node scaling</a>.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disables automatic scaling. ACK adjusts the number of nodes in the node pool to the expected number of nodes. The number of nodes is always the same as the expected number of nodes.</para>
            /// </description></item>
            /// </list>
            /// <para>If this parameter is set to false, other parameters in auto_scaling do not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>Indicates whether to associate an EIP with the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Associates an EIP with the node pool.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not associate an EIP with the node pool.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// <para>The maximum number of instances that can be created in the node pool. This value does not include the existing instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of instances that can be created in the node pool. This value does not include the existing instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// <para>The type of automatic scaling that is configured for the node pool. This parameter is specified based on the instance type for automatic scaling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cpu</c>: regular instances.</para>
            /// </description></item>
            /// <item><description><para><c>gpu</c>: GPU-accelerated instances.</para>
            /// </description></item>
            /// <item><description><para><c>gpushare</c>: shared GPU-accelerated instances.</para>
            /// </description></item>
            /// <item><description><para><c>spot</c>: spot instances.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cpu</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("eflo_node_group")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyEfloNodeGroup EfloNodeGroup { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyEfloNodeGroup : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>i113790071760688002461</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i128147721760688002463</para>
            /// </summary>
            [NameInMap("group_id")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the pod network uses the host network mode.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: host network. Pods directly use the host\&quot;s network stack and share IP addresses and ports with the host.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: container network. Pods have an independent network stack and do not use host network ports.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("host_network")]
        [Validation(Required=false)]
        public bool? HostNetwork { get; set; }

        /// <summary>
        /// <para>[This parameter is deprecated]</para>
        /// <para>The network configurations of the edge node pool. This parameter is valid only for edge node pools.</para>
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyInterconnectConfig InterconnectConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyInterconnectConfig : TeaModel {
            /// <summary>
            /// <para>[This parameter is deprecated]</para>
            /// <para>The network bandwidth of the enhanced edge node pool. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>[This parameter is deprecated]</para>
            /// <para>The ID of the CCN instance that is associated with the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccn-qm5i0i0q9yi*******</para>
            /// </summary>
            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            public string CcnId { get; set; }

            /// <summary>
            /// <para>[This parameter is deprecated]</para>
            /// <para>The region where the CCN instance that is associated with the enhanced edge node pool resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            public string CcnRegionId { get; set; }

            /// <summary>
            /// <para>[This parameter is deprecated]</para>
            /// <para>The ID of the CEN instance that is associated with the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-ey9k9nfhz0f*******</para>
            /// </summary>
            [NameInMap("cen_id")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>[This parameter is deprecated]</para>
            /// <para>The subscription duration of the enhanced edge node pool. Unit: months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("improved_period")]
            [Validation(Required=false)]
            public string ImprovedPeriod { get; set; }

        }

        /// <summary>
        /// <para>The network type of the edge node pool. This parameter is valid only for <c>edge</c> node pools. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>basic</c>: public network. The nodes in the node pool interact with cloud nodes over the Internet. Applications in the node pool cannot directly access the VPC in the cloud.</para>
        /// </description></item>
        /// <item><description><para><c>private</c>: dedicated network. The nodes in the node pool connect to the cloud network through leased lines, VPNs, or CEN. This provides higher communication quality between the cloud and the edge and offers more effective security.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("interconnect_mode")]
        [Validation(Required=false)]
        public string InterconnectMode { get; set; }

        /// <summary>
        /// <para>Indicates whether nodes in the edge node pool have Layer 3 network connectivity.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: connected. All nodes in this node pool have Layer 3 network connectivity.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: not connected. All hosts in this node pool do not have Layer 3 network connectivity.</para>
        /// </description></item>
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
            /// <para>Indicates whether to install Cloud Monitor on the ECS nodes. After you install Cloud Monitor, you can view the monitoring information of the created ECS instances in the Cloud Monitor console. We recommend that you enable this feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Installs Cloud Monitor on the ECS nodes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not install Cloud Monitor on the ECS nodes.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }

            /// <summary>
            /// <para>The CPU management policy for the nodes. The following policies are supported for clusters of Kubernetes 1.12.6 and later:</para>
            /// <list type="bullet">
            /// <item><description><para><c>static</c>: Allows pods with specific resource characteristics on a node to have enhanced CPU affinity and exclusivity.</para>
            /// </description></item>
            /// <item><description><para><c>none</c>: Enables the default CPU affinity scheme.</para>
            /// </description></item>
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
            /// <para>A node name consists of a prefix, the IP address of the node, and a suffix:</para>
            /// <list type="bullet">
            /// <item><description><para>The prefix and suffix can consist of one or more parts separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). The node name must start and end with a lowercase letter or a digit.</para>
            /// </description></item>
            /// <item><description><para>The IP address segment length indicates the number of digits to be truncated from the end of the node IP address. Valid values: 5 to 12.</para>
            /// </description></item>
            /// </list>
            /// <para>For example, if the node IP address is 192.168.0.55, the prefix is aliyun.com, the IP address segment length is 5, and the suffix is test, the node name is aliyun.com00055test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com192.XX.YY.55test</para>
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// <para>The pre-custom data of the node pool. The script is run before the node is initialized. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Generate instance user data</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGhpcyBpcyBhIGV4YW1wbGU</para>
            /// </summary>
            [NameInMap("pre_user_data")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>The name of the container runtime. ACK supports the following container runtimes.</para>
            /// <list type="bullet">
            /// <item><description><para>containerd: recommended. It is supported by all cluster versions.</para>
            /// </description></item>
            /// <item><description><para>Sandboxed-Container.runv: a sandboxed container that provides higher isolation. It is supported by clusters of Kubernetes 1.31 and earlier.</para>
            /// </description></item>
            /// <item><description><para>docker: no longer maintained. It is supported by clusters of Kubernetes 1.22 and earlier.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>The version of the container runtime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.6.38</para>
            /// </summary>
            [NameInMap("runtime_version")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }

            /// <summary>
            /// <para>The node taints. Taints work with tolerations to prevent pods from being scheduled to unsuitable nodes. For more information, see <a href="https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/">taint-and-toleration</a>.</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>Indicates whether the scaled-out nodes are unschedulable.</para>
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
            /// <para>The custom data of the node pool. The script is run after the node is initialized. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Generate instance user data</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyEvYmluL3NoCmVjaG8gIkhlbGxvIEFDSyEi</para>
            /// </summary>
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the managed node pool.</para>
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyManagement Management { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyManagement : TeaModel {
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>Indicates whether to enable auto repair. This parameter takes effect only if enable is set to true.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Auto repair is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Auto repair is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// <para>The policy for automatic node repair.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>Indicates whether manual approval is required for node repair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("approval_required")]
                [Validation(Required=false)]
                public bool? ApprovalRequired { get; set; }

                /// <summary>
                /// <para>The ID of the auto repair policy</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("auto_repair_policy_id")]
                [Validation(Required=false)]
                public string AutoRepairPolicyId { get; set; }

                /// <summary>
                /// <para>Indicates whether to allow node restart. This parameter takes effect only if auto_repair is set to true.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Nodes can be restarted.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Nodes cannot be restarted.</para>
                /// </description></item>
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
            /// <para>Indicates whether to enable automatic node upgrades. This parameter takes effect only if enable is set to true.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Automatic upgrades are enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Automatic upgrades are disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_upgrade")]
            [Validation(Required=false)]
            public bool? AutoUpgrade { get; set; }

            /// <summary>
            /// <para>The policy for automatic upgrades.</para>
            /// </summary>
            [NameInMap("auto_upgrade_policy")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>Indicates whether to allow automatic kubelet upgrades. This parameter takes effect only if auto_upgrade is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Automatic kubelet upgrades are allowed.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Automatic kubelet upgrades are not allowed.</para>
                /// </description></item>
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
            /// <para>Indicates whether to automatically fix CVEs. This parameter takes effect only if enable is set to true.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: CVEs are automatically fixed.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: CVEs are not automatically fixed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_vul_fix")]
            [Validation(Required=false)]
            public bool? AutoVulFix { get; set; }

            /// <summary>
            /// <para>The policy for automatically fixing CVEs.</para>
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>The packages that should be excluded during CVE fixing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kernel</para>
                /// </summary>
                [NameInMap("exclude_packages")]
                [Validation(Required=false)]
                public string ExcludePackages { get; set; }

                /// <summary>
                /// <para>Indicates whether to allow node restart. This parameter takes effect only if auto_vul_fix is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Nodes can be restarted.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Nodes cannot be restarted.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// <para>The levels of CVEs that are allowed to be automatically fixed. The levels are separated by commas.</para>
                /// <list type="bullet">
                /// <item><description><para><c>asap</c>: high</para>
                /// </description></item>
                /// <item><description><para><c>later</c>: medium</para>
                /// </description></item>
                /// <item><description><para><c>nntf</c>: low</para>
                /// </description></item>
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
            /// <para>Indicates whether to enable the managed node pool feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables the managed node pool feature.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables the managed node pool feature. Other parameters in this section take effect only if this parameter is set to true.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The automatic upgrade configurations. This parameter takes effect only if enable is set to true.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyManagementUpgradeConfig UpgradeConfig { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyManagementUpgradeConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether to enable automatic upgrades. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Automatic upgrades are enabled.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Automatic upgrades are disabled.</para>
                /// </description></item>
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
                /// <para>The number of extra nodes. You can specify only one of surge and surge_percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>The percentage of extra nodes. You can specify only one of surge and surge_percentage.</para>
                /// <para>The number of extra nodes = Percentage of extra nodes × Number of nodes. For example, if you set the percentage of extra nodes to 50% and the number of existing nodes is 6, the number of extra nodes is 3 (50% × 6).</para>
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
        /// <para>[This parameter is deprecated]</para>
        /// <para>The maximum number of nodes that the edge node pool can contain.</para>
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
            /// <para>The configurations of the node component.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyNodeComponentsConfig Config { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyNodeComponentsConfig : TeaModel {
                /// <summary>
                /// <para>The custom configurations of the node component.</para>
                /// </summary>
                [NameInMap("custom_config")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomConfig { get; set; }

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
        /// <para>The node configurations.</para>
        /// </summary>
        [NameInMap("node_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyNodeConfig NodeConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyNodeConfig : TeaModel {
            /// <summary>
            /// <para>The Kubelet parameter settings.</para>
            /// </summary>
            [NameInMap("kubelet_configuration")]
            [Validation(Required=false)]
            public KubeletConfig KubeletConfiguration { get; set; }

            /// <summary>
            /// <para>The node OS configurations.</para>
            /// </summary>
            [NameInMap("node_os_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyNodeConfigNodeOsConfig NodeOsConfig { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyNodeConfigNodeOsConfig : TeaModel {
                /// <summary>
                /// <para>The Hugepage configurations.</para>
                /// </summary>
                [NameInMap("hugepage")]
                [Validation(Required=false)]
                public Hugepage Hugepage { get; set; }

            }

        }

        /// <summary>
        /// <para>The node pool configurations.</para>
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
            /// <para>Indicates whether the node pool is the default node pool. A cluster usually has only one default node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: the default node pool.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: not the default node pool.</para>
            /// </description></item>
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
            /// <para>The type of the node pool.</para>
            /// <list type="bullet">
            /// <item><description><para><c>ess</c>: a regular node pool. It includes the features of managed node pools and automatic scaling.</para>
            /// </description></item>
            /// <item><description><para><c>edge</c>: an edge node pool.</para>
            /// </description></item>
            /// <item><description><para><c>lingjun</c>: a Lingjun node pool.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ess</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the node pool was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-15T15:39:45.41+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the scaling group for the node pool.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyScalingGroup ScalingGroup { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyScalingGroup : TeaModel {
            /// <summary>
            /// <para>Indicates whether to enable auto-renewal for the nodes. This parameter takes effect only if instance_charge_type is set to PrePaid. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Auto-renewal is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Auto-renewal is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The duration of each auto-renewal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If PeriodUnit is set to Week: 1, 2, and 3.</para>
            /// </description></item>
            /// <item><description><para>If PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
            /// </description></item>
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
            /// <para>[This parameter is deprecated] Use the security_hardening_os parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("cis_enabled")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? CisEnabled { get; set; }

            /// <summary>
            /// <para>If multi_az_policy is set to COST_OPTIMIZED, this parameter specifies whether to allow the system to automatically create on-demand instances to meet the required number of ECS instances when it is not possible to create a sufficient number of spot instances due to price or stock issues. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Allows the system to automatically create on-demand instances to meet the required number of ECS instances.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not allow the system to automatically create on-demand instances to meet the required number of ECS instances.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("compensate_with_on_demand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// <para>The combination of the configurations, such as the type and size, of the data disks of the nodes.</para>
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
            /// <para>The configurations for block device initialization.</para>
            /// </summary>
            [NameInMap("disk_init")]
            [Validation(Required=false)]
            public List<DiskInit> DiskInit { get; set; }

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
            /// <para>The OS image type.</para>
            /// <list type="bullet">
            /// <item><description><para><c>AliyunLinux</c>: Alinux2 image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinuxSecurity</c>: Alinux2 UEFI image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3</c>: Alinux3 image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3Arm64</c>: Alinux3 ARM image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3Security</c>: Alinux3 UEFI image.</para>
            /// </description></item>
            /// <item><description><para><c>CentOS</c>: CentOS image.</para>
            /// </description></item>
            /// <item><description><para><c>Windows</c>: Windows image.</para>
            /// </description></item>
            /// <item><description><para><c>WindowsCore</c>: WindowsCore image.</para>
            /// </description></item>
            /// <item><description><para><c>ContainerOS</c>: Container-optimized image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3ContainerOptimized</c>: Alinux3 container-optimized image.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux3</para>
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The billing method of the nodes in the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PrePaid</c>: subscription.</para>
            /// </description></item>
            /// <item><description><para><c>PostPaid</c>: pay-as-you-go.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The configurations for accessing the metadata of ECS instances.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>The instance attribute configurations.</para>
            /// </summary>
            [NameInMap("instance_patterns")]
            [Validation(Required=false)]
            public List<InstancePatterns> InstancePatterns { get; set; }

            /// <summary>
            /// <para>The list of node instance types.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The billing method for the public IP address of the nodes.</para>
            /// <list type="bullet">
            /// <item><description><para>PayByBandwidth: pay-by-bandwidth.</para>
            /// </description></item>
            /// <item><description><para>PayByTraffic: pay-by-traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The maximum outbound public bandwidth of the nodes. Unit: Mbit/s. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>The name of the key pair. You must specify either this parameter or login_password. When the node pool is a managed node pool, only key_pair is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pro-nodepool</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>Indicates whether to log on to the created ECS instances as a non-root user.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Logs on as a non-root user (ecs-user).</para>
            /// </description></item>
            /// <item><description><para>false: Logs on as the root user.</para>
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
            /// <para>The SSH logon password. You must specify either this parameter or key_pair. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
            /// <para>For security reasons, the password is encrypted in the query result.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The scaling policy for the ECS instances in the multi-zone scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PRIORITY</c>: Scales instances based on the vSwitches that you define (VSwitchIds.N). If the ECS instances cannot be created in the zone of the vSwitch with a higher priority, the system automatically uses the vSwitch with the next priority to create the instances.</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>: Attempts to create instances at the lowest vCPU unit price. If multiple instance types are specified for the scaling configuration and the preemption policy is configured, the system preferentially creates the corresponding spot instances. You can also use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically try to create on-demand instances when spot instances cannot be created due to reasons such as stock shortages.</para>
            /// <remarks>
            /// <para><c>COST_OPTIMIZED</c> takes effect only when multiple instance types are specified or spot instances are used for the scaling configuration.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>: Evenly distributes ECS instances across the specified zones of the scaling group. If the distribution of ECS instances becomes unbalanced between zones due to stock shortages, you can call the API RebalanceInstances operation to balance the resources. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a> .</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>PRIORITY</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BALANCE</para>
            /// </summary>
            [NameInMap("multi_az_policy")]
            [Validation(Required=false)]
            public string MultiAzPolicy { get; set; }

            /// <summary>
            /// <para>The minimum number of on-demand instances that the scaling group must contain. Valid values: 0 to 1000. If the number of on-demand instances is less than this value, on-demand instances are preferentially created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of on-demand instances among the instances that exceed the minimum number of on-demand instances (on_demand_base_capacity). Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The subscription duration of the nodes. This parameter is required and takes effect only if instance_charge_type is set to PrePaid.</para>
            /// <list type="bullet">
            /// <item><description><para>If period_unit is set to Week, the valid values of period are 1, 2, 3, and 4.</para>
            /// </description></item>
            /// <item><description><para>If period_unit is set to Month, the valid values of period are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The billing cycle of the nodes. This parameter is required if instance_charge_type is set to PrePaid.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Month</c>: The billing cycle is measured in months.</para>
            /// </description></item>
            /// <item><description><para><c>Week</c>: The billing cycle is measured in weeks.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The OS distribution. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>CentOS</c></para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux</c></para>
            /// </description></item>
            /// <item><description><para><c>Windows</c></para>
            /// </description></item>
            /// <item><description><para><c>WindowsCore</c></para>
            /// </description></item>
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
                /// <para>The type of the private node pool. This parameter specifies the capacity option for the private pool that is used to start instances. After an elastic assurance service or a capacity reservation service takes effect, a private pool is generated. You can select the private pool to start instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Open</c>: The system automatically matches the capacity of an open private pool. If no matching private pool is found, the system uses public resources.</para>
                /// </description></item>
                /// <item><description><para><c>Target</c>: The system uses the capacity of a specified private pool to start the instance. If the capacity of the specified private pool is unavailable, the instance fails to start.</para>
                /// </description></item>
                /// <item><description><para><c>None</c>: The system does not use the capacity of a private pool.</para>
                /// </description></item>
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
            /// <para>[This parameter is deprecated] Use ram_role_name instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KubernetesWorkerRole-021dc54f-929b-437a-8ae0-34c24d3e****</para>
            /// </summary>
            [NameInMap("ram_policy")]
            [Validation(Required=false)]
            public string RamPolicy { get; set; }

            /// <summary>
            /// <para>The name of the worker RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KubernetesWorkerRole-4a4fa089-80c1-48a5-b3c6-9349311f****</para>
            /// </summary>
            [NameInMap("ram_role_name")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>If you specify a list of RDS instances, the ECS nodes of the cluster are automatically added to the RDS instance whitelist.</para>
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
                /// <para>The resource pool policy used when creating instances. Valid values: PrivatePoolFirst: The private pool is used first. PrivatePoolOnly: Only the private pool is used. None: No resource pool policy is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrivatePoolFirst</para>
                /// </summary>
                [NameInMap("strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

            }

            /// <summary>
            /// <para>The ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-2zeieod8giqmov7z****</para>
            /// </summary>
            [NameInMap("scaling_group_id")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The scaling group mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>release</c>: standard mode. Instances are created and released based on the resource usage.</para>
            /// </description></item>
            /// <item><description><para><c>recycle</c>: fast mode. Instances are created, stopped, and started to accelerate scaling. Compute resources are not billed when instances are stopped, but storage resources are. This does not apply to instances with local disks.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>release</para>
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// <para>The security group ID of the node pool. If the node pool is associated with multiple security groups, this is the first value in security_group_ids.</para>
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
            /// <para>Alibaba Cloud OS security hardening. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables Alibaba Cloud OS security hardening.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables Alibaba Cloud OS security hardening.</para>
            /// </description></item>
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
            /// <para>Indicates whether to enable classified protection compliance. You can enable classified protection compliance for nodes only when you select Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3 as the OS image. Alibaba Cloud provides baseline check standards and scanning programs for MLPS 2.0 Level 3-compliant Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3 images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// <para>The number of available instance types. The scaling group creates spot instances of multiple types that have the lowest costs in a balanced manner. Valid values: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Indicates whether to enable the feature of supplementing spot instances. If this feature is enabled, the scaling group attempts to create a new instance to replace a spot instance that is reclaimed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables the feature of supplementing spot instances.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables the feature of supplementing spot instances.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// <para>The configurations of the price range for spot instances.</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<DescribeClusterNodePoolDetailResponseBodyScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyScalingGroupSpotPriceLimit : TeaModel {
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
                /// <para>The price of a single instance.</para>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <para>Unit: CNY/hour.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;</para>
                /// <para>Unit: USD/hour.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.39</para>
                /// </summary>
                [NameInMap("price_limit")]
                [Validation(Required=false)]
                public string PriceLimit { get; set; }

            }

            /// <summary>
            /// <para>The preemption policy for the spot instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NoSpot: The instances are not spot instances.</para>
            /// </description></item>
            /// <item><description><para>SpotWithPriceLimit: Sets the maximum price for a spot instance.</para>
            /// </description></item>
            /// <item><description><para>SpotAsPriceGo: The system automatically places bids based on the market price.</para>
            /// </description></item>
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
            /// <para>Indicates whether to enable performance burst for the system disk of the nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables performance burst. If you enable this feature, the cloud disk can temporarily improve its performance to handle sudden data read and write pressure when the business is unstable.</para>
            /// </description></item>
            /// <item><description><para>false: Disables performance burst.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter can be set only when system_disk_category is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The types of system disks. When a disk of a high-priority type is not available, the system automatically tries the next-priority disk type to create the system disk.</para>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The type of the system disk of the nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cloud_efficiency</c>: ultra disk.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_ssd</c>: standard SSD.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_essd</c>: Enhanced SSD (ESSD).</para>
            /// </description></item>
            /// <item><description><para><c>cloud_auto</c>: ESSD AutoPL disk.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_essd_entry</c>: ESSD Entry disk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The encryption algorithm that is used for the system disk. Valid value: aes-256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes-256</para>
            /// </summary>
            [NameInMap("system_disk_encrypt_algorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Indicates whether to encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Encrypts the system disk.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not encrypt the system disk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("system_disk_encrypted")]
            [Validation(Required=false)]
            public bool? SystemDiskEncrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key that is used to encrypt the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("system_disk_kms_key_id")]
            [Validation(Required=false)]
            public string SystemDiskKmsKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the system disk of the nodes. This parameter is valid only for ESSDs. The disk performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: The I/O performance is moderate and the read/write latency is stable.</para>
            /// </description></item>
            /// <item><description><para>PL1: The I/O performance is moderate and the read/write latency is stable.</para>
            /// </description></item>
            /// <item><description><para>PL2: The I/O performance is high and the read/write latency is stable.</para>
            /// </description></item>
            /// <item><description><para>PL3: The I/O performance is very high and the read/write latency is very stable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The pre-configured read and write IOPS of the system disk of the nodes.</para>
            /// <para>Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
            /// <para>This parameter can be set only when system_disk_category is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk of the nodes. Unit: GiB.</para>
            /// <para>Valid values: 20 to 2048.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The system disk snapshot policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp11g8z59rawcud9****</para>
            /// </summary>
            [NameInMap("system_disk_snapshot_policy_id")]
            [Validation(Required=false)]
            public string SystemDiskSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>The ECS instance tags.</para>
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
            /// <para>The current status of the node pool. This parameter indicates the status of the node pool from different dimensions.</para>
            /// </summary>
            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<DescribeClusterNodePoolDetailResponseBodyStatusConditions> Conditions { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyStatusConditions : TeaModel {
                /// <summary>
                /// <para>The time of the last status transition.</para>
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
            /// <para>The number of nodes that are being created.</para>
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
            /// <para>The number of nodes that are being removed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("removing_nodes")]
            [Validation(Required=false)]
            public long? RemovingNodes { get; set; }

            /// <summary>
            /// <para>The number of nodes that are in service.</para>
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
            /// <item><description><para><c>active</c>: The node pool is active.</para>
            /// </description></item>
            /// <item><description><para><c>scaling</c>: The node pool is being scaled.</para>
            /// </description></item>
            /// <item><description><para><c>removing</c>: Nodes are being removed.</para>
            /// </description></item>
            /// <item><description><para><c>deleting</c>: The node pool is being deleted.</para>
            /// </description></item>
            /// <item><description><para><c>updating</c>: The node pool is being updated.</para>
            /// </description></item>
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
        /// <para>The configurations of the confidential computing cluster.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyTeeConfig TeeConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyTeeConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether to enable the confidential computing cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables the confidential computing cluster.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables the confidential computing cluster.</para>
            /// </description></item>
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
