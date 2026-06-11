// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodePoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node pools.</para>
        /// </summary>
        [NameInMap("nodepools")]
        [Validation(Required=false)]
        public List<DescribeClusterNodePoolsResponseBodyNodepools> Nodepools { get; set; }
        public class DescribeClusterNodePoolsResponseBodyNodepools : TeaModel {
            /// <summary>
            /// <para>The intelligent hosting configurations.</para>
            /// </summary>
            [NameInMap("auto_mode")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsAutoMode AutoMode { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsAutoMode : TeaModel {
                /// <summary>
                /// <para>Indicates whether to enable intelligent hosting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            /// <summary>
            /// <para>The auto scaling configuration.</para>
            /// </summary>
            [NameInMap("auto_scaling")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsAutoScaling AutoScaling { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsAutoScaling : TeaModel {
                /// <summary>
                /// <para>The maximum bandwidth of the EIP.</para>
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
                /// <para>Indicates whether auto scaling is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables auto scaling for the node pool. When cluster resources are insufficient for pod scheduling, ACK automatically scales nodes based on the configured minimum and maximum number of instances. For clusters running Kubernetes 1.24 or later, on-demand node scaling is enabled by default. For clusters running Kubernetes versions earlier than 1.24, node autoscaling is enabled by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node scaling</a>.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Auto scaling is disabled. ACK adjusts the number of nodes in the node pool to the expected number of nodes.</para>
                /// </description></item>
                /// </list>
                /// <para>If this parameter is set to false, other parameters in the auto_scaling object do not take effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>Indicates whether to associate an EIP with the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Associates an EIP with the node.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Does not associate an EIP with the node.</para>
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
                /// <para>The maximum number of instances that can be created in the node pool. This value does not include existing instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("max_instances")]
                [Validation(Required=false)]
                public long? MaxInstances { get; set; }

                /// <summary>
                /// <para>The minimum number of instances that must be kept in the node pool. This value does not include existing instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("min_instances")]
                [Validation(Required=false)]
                public long? MinInstances { get; set; }

                /// <summary>
                /// <para>The type of auto scaling. This parameter specifies the type of instances that are used for auto scaling. Valid values:</para>
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

            /// <summary>
            /// <para>The information about the Lingjun node group.</para>
            /// </summary>
            [NameInMap("eflo_node_group")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsEfloNodeGroup EfloNodeGroup { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsEfloNodeGroup : TeaModel {
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

            }

            /// <summary>
            /// <para>[This parameter is deprecated]</para>
            /// <para>The network configurations of the edge node pool. This parameter is valid only for edge node pools.</para>
            /// </summary>
            [NameInMap("interconnect_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsInterconnectConfig InterconnectConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsInterconnectConfig : TeaModel {
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
                /// <para>The ID of the Cloud Connect Network (CCN) instance that is associated with the enhanced edge node pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccn-qm5i0i0q9yi*******</para>
                /// </summary>
                [NameInMap("ccn_id")]
                [Validation(Required=false)]
                public string CcnId { get; set; }

                /// <summary>
                /// <para>[This parameter is deprecated]</para>
                /// <para>The region where the CCN instance associated with the enhanced edge node pool resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("ccn_region_id")]
                [Validation(Required=false)]
                public string CcnRegionId { get; set; }

                /// <summary>
                /// <para>[This parameter is deprecated]</para>
                /// <para>The ID of the Cloud Enterprise Network (CEN) instance that is associated with the enhanced edge node pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-ey9k9nfhz0f*******</para>
                /// </summary>
                [NameInMap("cen_id")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>[This parameter is deprecated]</para>
                /// <para>The subscription duration of the enhanced edge node pool. Unit: month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("improved_period")]
                [Validation(Required=false)]
                public string ImprovedPeriod { get; set; }

            }

            /// <summary>
            /// <para>The network type of the edge node pool. This parameter is valid only for node pools of the <c>edge</c> type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>basic</c>: public network. The nodes in the node pool interact with cloud nodes over the Internet. Applications in the node pool cannot directly access the VPC on the cloud.</para>
            /// </description></item>
            /// <item><description><para><c>private</c>: private network. The nodes in the node pool are connected to the cloud over a leased line, a VPN connection, or a CEN instance. This provides higher cloud-to-edge communication quality and enhanced security.</para>
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
            /// <para>The cluster-related configurations.</para>
            /// </summary>
            [NameInMap("kubernetes_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsKubernetesConfig KubernetesConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsKubernetesConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether to install CloudMonitor on the ECS nodes. After CloudMonitor is installed, you can view the monitoring information of the created ECS instances in the CloudMonitor console. We recommend that you enable this feature. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Installs CloudMonitor on the ECS nodes.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Does not install CloudMonitor on the ECS nodes</para>
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
                /// <para>The CPU management policy of the node. The following policies are supported for clusters of Kubernetes 1.12.6 and later:</para>
                /// <list type="bullet">
                /// <item><description><para><c>static</c>: allows pods with specific resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.</para>
                /// </description></item>
                /// <item><description><para><c>none</c>: indicates that the default CPU affinity scheme is enabled.</para>
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
                /// <para>A node name consists of three parts: a prefix, the middle part of an IP address, and a suffix:</para>
                /// <list type="bullet">
                /// <item><description><para>The prefix and suffix can contain one or more parts that are separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). The node name must start and end with a lowercase letter or a digit.</para>
                /// </description></item>
                /// <item><description><para>The IP address segment length specifies the number of digits to be truncated from the end of the node IP address. Valid values: 5 to 12.</para>
                /// </description></item>
                /// </list>
                /// <para>For example, if the node IP address is 192.1.168.0.55, the prefix is aliyun.com, the IP address segment length is 5, and the suffix is test, the node name is aliyun.com00055test.</para>
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
                /// <para>IyEvYmluL3NoCmVjaG8gIkhlbGxvIEFD</para>
                /// </summary>
                [NameInMap("pre_user_data")]
                [Validation(Required=false)]
                public string PreUserData { get; set; }

                /// <summary>
                /// <para>The name of the container runtime. ACK supports the following container runtimes.</para>
                /// <list type="bullet">
                /// <item><description><para>containerd: recommended. This runtime is supported by all cluster versions.</para>
                /// </description></item>
                /// <item><description><para>Sandboxed-Container.runv: a sandboxed container that provides higher isolation. This runtime is supported by clusters of Kubernetes 1.31 and earlier.</para>
                /// </description></item>
                /// <item><description><para>docker: no longer maintained. This runtime is supported by clusters of Kubernetes 1.22 and earlier.</para>
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
                /// <para>The node taints. Taints and tolerations work together to prevent pods from being scheduled to unsuitable nodes. For more information, see <a href="https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/">Taints and Tolerations</a>.</para>
                /// </summary>
                [NameInMap("taints")]
                [Validation(Required=false)]
                public List<Taint> Taints { get; set; }

                /// <summary>
                /// <para>Indicates whether the scaled-out nodes are unschedulable.</para>
                /// <list type="bullet">
                /// <item><description><para>true: The scaled-out nodes are unschedulable.</para>
                /// </description></item>
                /// <item><description><para>false: The scaled-out nodes are schedulable.</para>
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
                /// <para>IyEvYmluL3NoCmVjaG8gIkhlbGxvIEFD****</para>
                /// </summary>
                [NameInMap("user_data")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <para>The configurations of the managed node pool. This parameter takes effect only in ACK Pro clusters.</para>
            /// </summary>
            [NameInMap("management")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsManagement Management { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsManagement : TeaModel {
                [NameInMap("auto_fault_diagnosis")]
                [Validation(Required=false)]
                public bool? AutoFaultDiagnosis { get; set; }

                /// <summary>
                /// <para>Indicates whether to enable auto repair. This parameter takes effect only when enable is set to true.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables auto repair.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables auto repair.</para>
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
                /// <para>The auto repair policy for nodes.</para>
                /// </summary>
                [NameInMap("auto_repair_policy")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoRepairPolicy : TeaModel {
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
                    /// <para>r-xxxxxxxxx</para>
                    /// </summary>
                    [NameInMap("auto_repair_policy_id")]
                    [Validation(Required=false)]
                    public string AutoRepairPolicyId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to allow node restart. This parameter takes effect only when auto_repair is set to true.</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>true</c>: Allows node restart.</para>
                    /// </description></item>
                    /// <item><description><para><c>false</c>: Does not allow node restart.</para>
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
                /// <para>Indicates whether to enable auto update. This parameter takes effect only when enable is set to true.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables auto update.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables auto update.</para>
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
                /// <para>The auto update policy.</para>
                /// </summary>
                [NameInMap("auto_upgrade_policy")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoUpgradePolicy : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether to allow auto update of the kubelet. This parameter takes effect only when auto_upgrade is set to true. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>true</c>: Allows auto update of the kubelet.</para>
                    /// </description></item>
                    /// <item><description><para><c>false</c>: Does not allow auto update of the kubelet.</para>
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
                /// <para>Indicates whether to automatically fix CVEs. This parameter takes effect only when enable is set to true.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Allows CVEs to be automatically fixed.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Does not allow CVEs to be automatically fixed.</para>
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
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoVulFixPolicy : TeaModel {
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
                    /// <para>Indicates whether to allow node restart. This parameter takes effect only when auto_vul_fix is set to true. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>true</c>: Allows node restart.</para>
                    /// </description></item>
                    /// <item><description><para><c>false</c>: Does not allow node restart.</para>
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
                    /// <para>The CVE levels that are allowed to be automatically fixed. Separate multiple CVE levels with commas.</para>
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
                /// <item><description><para><c>false</c>: The managed node pool feature is disabled. If you set this parameter to true, the other parameters take effect.</para>
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
                /// <para>The auto update configurations. This parameter takes effect only when enable is set to true.</para>
                /// </summary>
                [NameInMap("upgrade_config")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementUpgradeConfig UpgradeConfig { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementUpgradeConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether to enable auto update. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>true</c>: Enables auto update.</para>
                    /// </description></item>
                    /// <item><description><para><c>false</c>: Disables auto update.</para>
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
                    /// <para>The maximum number of unavailable nodes. Valid values: 1 to 1000</para>
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
                    /// <para>The number of extra nodes = Percentage of extra nodes × Number of nodes. For example, if you set the percentage of extra nodes to 50% and the number of existing nodes is 6, three extra nodes are created.</para>
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
            /// <para>The maximum number of nodes that the edge node pool can contain. The value of this parameter must be greater than or equal to 0. A value of 0 indicates that no limit is imposed on the number of nodes in the node pool, except for the limit on the total number of nodes in the cluster. The value of this parameter is usually greater than 0 for edge node pools. The value is 0 for ess node pools and default edge node pools</para>
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
            public List<DescribeClusterNodePoolsResponseBodyNodepoolsNodeComponents> NodeComponents { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsNodeComponents : TeaModel {
                /// <summary>
                /// <para>The configurations of the node component.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsNodeComponentsConfig Config { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsNodeComponentsConfig : TeaModel {
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
            public DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfig NodeConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfig : TeaModel {
                /// <summary>
                /// <para>The Kubelet parameter configurations.</para>
                /// </summary>
                [NameInMap("kubelet_configuration")]
                [Validation(Required=false)]
                public KubeletConfig KubeletConfiguration { get; set; }

                /// <summary>
                /// <para>The node OS configurations.</para>
                /// </summary>
                [NameInMap("node_os_config")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfigNodeOsConfig NodeOsConfig { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfigNodeOsConfig : TeaModel {
                    /// <summary>
                    /// <para>The Hugepage configuration.</para>
                    /// </summary>
                    [NameInMap("hugepage")]
                    [Validation(Required=false)]
                    public Hugepage Hugepage { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the node pool.</para>
            /// </summary>
            [NameInMap("nodepool_info")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsNodepoolInfo NodepoolInfo { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsNodepoolInfo : TeaModel {
                /// <summary>
                /// <para>The time when the node pool was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-15T16:33:29.362888807+08:00</para>
                /// </summary>
                [NameInMap("created")]
                [Validation(Required=false)]
                public string Created { get; set; }

                /// <summary>
                /// <para>Indicates whether the node pool is the default node pool. A cluster has only one default node pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: The node pool is the default node pool.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: The node pool is not the default node pool.</para>
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
                /// <para>rg-acfmyvw3wjm****</para>
                /// </summary>
                [NameInMap("resource_group_id")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The type of the node pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>ess</c>: a regular node pool. This type of node pool provides managed features and supports automatic scaling.</para>
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
                /// <para>2025-04-15T16:33:32.823+08:00</para>
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
            public DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroup ScalingGroup { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroup : TeaModel {
                /// <summary>
                /// <para>Indicates whether to enable auto-renewal for the nodes. This parameter takes effect only when instance_charge_type is set to PrePaid. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables auto-renewal.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables auto-renewal.</para>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("auto_renew_period")]
                [Validation(Required=false)]
                public long? AutoRenewPeriod { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>[This parameter is deprecated]</para>
                /// <para>Use the security_hardening_os parameter instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("cis_enabled")]
                [Validation(Required=false)]
                [Obsolete]
                public bool? CisEnabled { get; set; }

                /// <summary>
                /// <para>If multi_az_policy is set to <c>COST_OPTIMIZED</c>, this parameter specifies whether to allow the system to automatically create pay-as-you-go instances to meet the required number of ECS instances when preemptible instances cannot be created due to reasons such as price and inventory. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Allows the system to automatically create pay-as-you-go instances to meet the required number of ECS instances.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Does not allow the system to automatically create pay-as-you-go instances to meet the required number of ECS instances.</para>
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
                /// <para>The combination of the configurations of the data disks of the node, such as the disk type and size.</para>
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
                /// <para>The block device initialization configuration.</para>
                /// </summary>
                [NameInMap("disk_init")]
                [Validation(Required=false)]
                public List<DiskInit> DiskInit { get; set; }

                /// <summary>
                /// <para>The custom image ID. You can call the <c>DescribeKubernetesVersionMetadata</c> operation to query the images supported by the system.</para>
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
                /// <item><description><para><c>AliyunLinux</c>: Alibaba Cloud Linux 2 image.</para>
                /// </description></item>
                /// <item><description><para><c>AliyunLinuxSecurity</c>: Alibaba Cloud Linux 2 UEFI image.</para>
                /// </description></item>
                /// <item><description><para><c>AliyunLinux3</c>: Alibaba Cloud Linux 3 image.</para>
                /// </description></item>
                /// <item><description><para><c>AliyunLinux3Arm64</c>: Alibaba Cloud Linux 3 ARM image.</para>
                /// </description></item>
                /// <item><description><para><c>AliyunLinux3Security</c>: Alibaba Cloud Linux 3 UEFI image.</para>
                /// </description></item>
                /// <item><description><para><c>CentOS</c>: CentOS image.</para>
                /// </description></item>
                /// <item><description><para><c>Windows</c>: Windows image.</para>
                /// </description></item>
                /// <item><description><para><c>WindowsCore</c>: WindowsCore image.</para>
                /// </description></item>
                /// <item><description><para><c>ContainerOS</c>: Container-optimized image.</para>
                /// </description></item>
                /// <item><description><para><c>AliyunLinux3ContainerOptimized</c>: Alibaba Cloud Linux 3 container-optimized image.</para>
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
                /// <para>The instance attribute configurations.</para>
                /// </summary>
                [NameInMap("instance_patterns")]
                [Validation(Required=false)]
                public List<InstancePatterns> InstancePatterns { get; set; }

                /// <summary>
                /// <para>The list of node instance types. You can select multiple instance types as alternatives. When a node is created, the system starts from the first instance type until the node is created. The instance type that is used to create the node may vary based on the inventory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.n4.large</para>
                /// </summary>
                [NameInMap("instance_types")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                /// <summary>
                /// <para>The billing method of the public IP address of the node.</para>
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
                /// <para>The maximum outbound bandwidth of the public IP address of the node. Unit: Mbit/s. Valid values: 1 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("internet_max_bandwidth_out")]
                [Validation(Required=false)]
                public long? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// <para>The name of the key pair. You must set one of key_pair and login_password.</para>
                /// <para>You can set only <c>key_pair</c> for managed node pools.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pro-nodepool</para>
                /// </summary>
                [NameInMap("key_pair")]
                [Validation(Required=false)]
                public string KeyPair { get; set; }

                /// <summary>
                /// <para>Indicates whether to log on to the created ECS instance as a non-root user.</para>
                /// <list type="bullet">
                /// <item><description><para>true: Log on as a non-root user (ecs-user).</para>
                /// </description></item>
                /// <item><description><para>false: Log on as the root user.</para>
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
                /// <para>The SSH logon password. You must set one of key_pair and login_password. The password must be 8 to 30 characters in length, and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
                /// <para>For security reasons, the password is encrypted.</para>
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
                /// <item><description><para><c>PRIORITY</c>: The system scales ECS instances based on the vSwitches that you specify (VSwitchIds.N). If an ECS instance cannot be created in the zone where the vSwitch with a higher priority resides, the system uses the vSwitch with the next priority to create the ECS instance.</para>
                /// </description></item>
                /// <item><description><para><c>COST_OPTIMIZED</c>: The system creates ECS instances at the lowest vCPU price. If multiple instance types are specified in the scaling configuration and the preemptible instance feature is enabled, the system preferentially creates preemptible instances. You can use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically create pay-as-you-go instances when preemptible instances cannot be created due to reasons such as insufficient inventory.</para>
                /// <remarks>
                /// <para><c>COST_OPTIMIZED</c> takes effect only if the scaling configuration uses multiple instance types or spot instances.</para>
                /// </remarks>
                /// </description></item>
                /// <item><description><para><c>BALANCE</c>: The system evenly distributes ECS instances across the specified zones of the scaling group. If the distribution of ECS instances becomes unbalanced due to insufficient inventory, you can call the API <c>RebalanceInstances</c> operation to balance the resource distribution. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a> .</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COST_OPTIMIZED</para>
                /// </summary>
                [NameInMap("multi_az_policy")]
                [Validation(Required=false)]
                public string MultiAzPolicy { get; set; }

                /// <summary>
                /// <para>The minimum number of pay-as-you-go instances that must be contained in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than this value, the system preferentially creates pay-as-you-go instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("on_demand_base_capacity")]
                [Validation(Required=false)]
                public long? OnDemandBaseCapacity { get; set; }

                /// <summary>
                /// <para>The percentage of pay-as-you-go instances among the extra instances that are created after the minimum number of pay-as-you-go instances (<c>on_demand_base_capacity</c>) is met. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("on_demand_percentage_above_base_capacity")]
                [Validation(Required=false)]
                public long? OnDemandPercentageAboveBaseCapacity { get; set; }

                /// <summary>
                /// <para>The subscription duration of the nodes. This parameter is required and takes effect only when instance_charge_type is set to PrePaid.</para>
                /// <list type="bullet">
                /// <item><description><para>If period_unit is set to Week, the valid values of period are 1, 2, 3, and 4.</para>
                /// </description></item>
                /// <item><description><para>If period_unit is set to Month, the valid values of period are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                /// <summary>
                /// <para>The billing cycle of the nodes. This parameter is required when instance_charge_type is set to PrePaid.</para>
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
                /// <para>[This parameter is deprecated]</para>
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
                /// <para>The private pool options.</para>
                /// </summary>
                [NameInMap("private_pool_options")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupPrivatePoolOptions : TeaModel {
                    /// <summary>
                    /// <para>The private pool ID. This is the ID of the elasticity assurance or capacity reservation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eap-bp67acfmxazb4****</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The type of the private node pool. This parameter specifies the capacity of the private pool that is used to start an instance. The capacity of a private pool is generated after an elasticity assurance or a capacity reservation takes effect. You can select a capacity option when you start an instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Open</c>: The system automatically matches the capacity of an open private pool. If no matching private pool is found, the resources in the public pool are used.</para>
                    /// </description></item>
                    /// <item><description><para><c>Target</c>: The system uses the capacity of the specified private pool to start the instance. If the capacity of the private pool is unavailable, the instance fails to be started.</para>
                    /// </description></item>
                    /// <item><description><para><c>None</c>: The instance is started without using the capacity of a private pool.</para>
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
                /// <para>This parameter is deprecated. Use ram_role_name instead.</para>
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
                /// <para>If you specify a list of RDS instances, the ECS instances of the cluster nodes are automatically added to the RDS instance whitelist.</para>
                /// </summary>
                [NameInMap("rds_instances")]
                [Validation(Required=false)]
                public List<string> RdsInstances { get; set; }

                /// <summary>
                /// <para>The resource pool and resource pool policy that are used when an instance is created.</para>
                /// </summary>
                [NameInMap("resource_pool_options")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupResourcePoolOptions : TeaModel {
                    /// <summary>
                    /// <para>The list of private pool IDs.</para>
                    /// </summary>
                    [NameInMap("private_pool_ids")]
                    [Validation(Required=false)]
                    public List<string> PrivatePoolIds { get; set; }

                    /// <summary>
                    /// <para>The resource pool policy that is used when an instance is created. Valid values:
                    /// PrivatePoolFirst: The private pool is used first.
                    /// PrivatePoolOnly: Only the private pool is used.
                    /// None: No resource pool policy is used.</para>
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
                /// <para>asg-2ze8n5qw4atggut8****</para>
                /// </summary>
                [NameInMap("scaling_group_id")]
                [Validation(Required=false)]
                public string ScalingGroupId { get; set; }

                /// <summary>
                /// <para>The scaling mode of the scaling group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>release</c>: standard mode. The system creates and releases ECS instances to scale resources based on the resource usage.</para>
                /// </description></item>
                /// <item><description><para><c>recycle</c>: fast mode. The system creates, stops, and starts ECS instances to scale resources. This improves the scaling speed. When an instance is stopped, its computing resources are not billed, but its storage resources are. This does not apply to instance types with local disks.</para>
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
                /// <para>[This parameter is deprecated]</para>
                /// <para>The ID of the security group for the node pool. If the node pool is associated with multiple security groups, this parameter returns the first security group ID in the <c>security_group_ids</c> list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-2ze1iuk12m2sb4c4****</para>
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
                /// <para>Indicates whether to enable MLPS 2.0 security hardening. You can enable MLPS 2.0 security hardening for nodes only when you select Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3 as the OS image. Alibaba Cloud provides classified protection compliance baseline check standards and scanning programs for MLPS 2.0 Level 3-compliant versions of Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("soc_enabled")]
                [Validation(Required=false)]
                public bool? SocEnabled { get; set; }

                /// <summary>
                /// <para>The number of available instance types. The scaling group creates preemptible instances of multiple instance types that are available at the lowest cost. Valid values: 1 to 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("spot_instance_pools")]
                [Validation(Required=false)]
                public long? SpotInstancePools { get; set; }

                /// <summary>
                /// <para>Indicates whether to enable the feature of supplementing preemptible instances. If this feature is enabled, the scaling group attempts to create a new instance to replace a preemptible instance when the scaling group receives a system message that the preemptible instance is to be reclaimed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables the feature of supplementing preemptible instances.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables the feature of supplementing preemptible instances.</para>
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
                /// <para>The configurations of the price range for the spot instances.</para>
                /// </summary>
                [NameInMap("spot_price_limit")]
                [Validation(Required=false)]
                public List<DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupSpotPriceLimit : TeaModel {
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
                    /// <para>The price range for a single instance.</para>
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
                /// <para>The bidding policy for the spot instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>NoSpot: The instances are not spot instances.</para>
                /// </description></item>
                /// <item><description><para>SpotWithPriceLimit: The maximum bid price is specified for the spot instances.</para>
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
                /// <para>Indicates whether to enable bursting for the system disk of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: enables bursting. After bursting is enabled, the performance of the cloud disk is temporarily improved to handle sudden data read and write pressure when the business is unstable. The performance of the cloud disk is restored after the business becomes stable.</para>
                /// </description></item>
                /// <item><description><para>false: disables bursting.</para>
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
                /// <para>The multi-disk type of the system disk. When a disk of a higher priority is unavailable, the system automatically uses a disk of a lower priority to create the system disk.</para>
                /// </summary>
                [NameInMap("system_disk_categories")]
                [Validation(Required=false)]
                public List<string> SystemDiskCategories { get; set; }

                /// <summary>
                /// <para>The type of the system disk of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>cloud_efficiency</c>: ultra disk.</para>
                /// </description></item>
                /// <item><description><para><c>cloud_ssd</c>: standard SSD.</para>
                /// </description></item>
                /// <item><description><para><c>cloud_essd</c>: ESSD.</para>
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
                /// <para>The encryption algorithm that is used to encrypt the system disk. Valid value: aes-256.</para>
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
                /// <item><description><para>true: Encrypts the system disk.</para>
                /// </description></item>
                /// <item><description><para>false: Does not encrypt the system disk.</para>
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
                /// <para>The performance level of the system disk of the node. This parameter is valid only for ESSDs. The performance level of the disk is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
                /// <list type="bullet">
                /// <item><description><para>PL0: The disk has medium concurrent I/O performance and stable read and write latency.</para>
                /// </description></item>
                /// <item><description><para>PL1: The disk has medium concurrent I/O performance and stable read and write latency.</para>
                /// </description></item>
                /// <item><description><para>PL2: The disk has high concurrent I/O performance and stable read and write latency.</para>
                /// </description></item>
                /// <item><description><para>PL3: The disk has ultra-high concurrent I/O performance and ultra-stable read and write latency.</para>
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
                /// <para>The pre-configured read and write IOPS of the system disk of the node. This parameter is configured when the disk type is cloud_auto.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("system_disk_provisioned_iops")]
                [Validation(Required=false)]
                public long? SystemDiskProvisionedIops { get; set; }

                /// <summary>
                /// <para>The size of the system disk of the node. Unit: GiB.</para>
                /// <para>Valid values: 20 to 2048.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("system_disk_size")]
                [Validation(Required=false)]
                public long? SystemDiskSize { get; set; }

                /// <summary>
                /// <para>The snapshot policy for the system disk</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-0jl6xnmme8v7o935****</para>
                /// </summary>
                [NameInMap("system_disk_snapshot_policy_id")]
                [Validation(Required=false)]
                public string SystemDiskSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>The tags of the ECS instances.</para>
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
            public DescribeClusterNodePoolsResponseBodyNodepoolsStatus Status { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsStatus : TeaModel {
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
                /// <para>The number of running nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("serving_nodes")]
                [Validation(Required=false)]
                public long? ServingNodes { get; set; }

                /// <summary>
                /// <para>The status of the node pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>active</c>: The node pool is active.</para>
                /// </description></item>
                /// <item><description><para><c>scaling</c>: The node pool is being scaled.</para>
                /// </description></item>
                /// <item><description><para><c>removing</c>: Nodes are being removed from the node pool.</para>
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
            /// <para>The confidential computing configurations.</para>
            /// </summary>
            [NameInMap("tee_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsTeeConfig TeeConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsTeeConfig : TeaModel {
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

}
