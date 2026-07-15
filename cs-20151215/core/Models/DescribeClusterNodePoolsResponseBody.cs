// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodePoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node pool instances.</para>
        /// </summary>
        [NameInMap("nodepools")]
        [Validation(Required=false)]
        public List<DescribeClusterNodePoolsResponseBodyNodepools> Nodepools { get; set; }
        public class DescribeClusterNodePoolsResponseBodyNodepools : TeaModel {
            /// <summary>
            /// <para>The intelligent managed configuration.</para>
            /// </summary>
            [NameInMap("auto_mode")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsAutoMode AutoMode { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsAutoMode : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable intelligent managed mode.</para>
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
                /// <para>The EIP peak bandwidth.</para>
                /// <para>Valid values: [1,100]. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("eip_bandwidth")]
                [Validation(Required=false)]
                public long? EipBandwidth { get; set; }

                /// <summary>
                /// <para>The EIP billing type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>PayByBandwidth</c>: pay-by-bandwidth.</description></item>
                /// <item><description><c>PayByTraffic</c>: pay-by-traffic.</description></item>
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
                /// <item><description><para><c>true</c>: Enables the auto scaling feature for the node pool. When the cluster capacity planning cannot meet Pod scheduling requirements, ACK automatically scales node resources based on the configured minimum and maximum instance counts. Clusters of version 1.24 and later use instant node elasticity by default. Clusters earlier than version 1.24 use node auto scaling by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node scaling</a>.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables auto scaling. ACK adjusts the number of nodes in the node pool based on the configured desired node count to maintain the node count at the desired number.</para>
                /// </description></item>
                /// </list>
                /// <para>When the value is false, other configuration parameters in <c>auto_scaling</c> do not take effect.</para>
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
                /// <item><description><c>true</c>: Associate an EIP.</description></item>
                /// <item><description><c>false</c>: Do not associate an EIP.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_bond_eip")]
                [Validation(Required=false)]
                public bool? IsBondEip { get; set; }

                /// <summary>
                /// <para>The maximum number of scalable instances in the node pool, excluding your existing instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("max_instances")]
                [Validation(Required=false)]
                public long? MaxInstances { get; set; }

                /// <summary>
                /// <para>The minimum number of scalable instances in the node pool, excluding your existing instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("min_instances")]
                [Validation(Required=false)]
                public long? MinInstances { get; set; }

                /// <summary>
                /// <para>The auto scaling type, categorized by instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>cpu</c>: regular instance type.</description></item>
                /// <item><description><c>gpu</c>: GPU instance type.</description></item>
                /// <item><description><c>gpushare</c>: GPU sharing type.</description></item>
                /// <item><description><c>spot</c>: spot instance type.</description></item>
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
            public DescribeClusterNodePoolsResponseBodyNodepoolsEfloNodeGroup EfloNodeGroup { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsEfloNodeGroup : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable automatic node addition for the Lingjun node pool (not effective).</para>
                /// </summary>
                [NameInMap("auto_attach_enabled")]
                [Validation(Required=false)]
                public bool? AutoAttachEnabled { get; set; }

                /// <summary>
                /// <para>The Lingjun cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i113790071760688002461</para>
                /// </summary>
                [NameInMap("cluster_id")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The Lingjun group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i128147721760688002463</para>
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
            /// <para>[This field is deprecated]</para>
            /// <para>The network configuration for edge node pools. This value is meaningful only for edge-type node pools.</para>
            /// </summary>
            [NameInMap("interconnect_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsInterconnectConfig InterconnectConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsInterconnectConfig : TeaModel {
                /// <summary>
                /// <para>[This field is deprecated]</para>
                /// <para>The network bandwidth of the enhanced edge node pool. Unit: Mbps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// <para>[This field is deprecated]</para>
                /// <para>The Cloud Connect Network (CCN) instance ID bound to the enhanced edge node pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccn-qm5i0i0q9yi*******</para>
                /// </summary>
                [NameInMap("ccn_id")]
                [Validation(Required=false)]
                public string CcnId { get; set; }

                /// <summary>
                /// <para>[This field is deprecated]</para>
                /// <para>The region of the Cloud Connect Network instance bound to the enhanced edge node pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("ccn_region_id")]
                [Validation(Required=false)]
                public string CcnRegionId { get; set; }

                /// <summary>
                /// <para>[This field is deprecated]</para>
                /// <para>The Cloud Enterprise Network (CEN) instance ID bound to the enhanced edge node pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-ey9k9nfhz0f*******</para>
                /// </summary>
                [NameInMap("cen_id")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>[This field is deprecated]</para>
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
            /// <para>The network type of the edge node pool. This parameter takes effect only for node pools with <c>type</c> set to <c>edge</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>basic</c>: public network. Nodes in cloud node pool interact with cloud nodes over the Internet. Applications in cloud node pool cannot directly access the cloud VPC internal network.</description></item>
            /// <item><description><c>private</c>: private network. Nodes in cloud node pool connect to the cloud through leased lines, VPN, or CEN, providing higher cloud-edge communication quality and more effective security.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("interconnect_mode")]
            [Validation(Required=false)]
            public string InterconnectMode { get; set; }

            /// <summary>
            /// <para>The cluster-related configuration.</para>
            /// </summary>
            [NameInMap("kubernetes_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsKubernetesConfig KubernetesConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsKubernetesConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to install the CloudMonitor agent on ECS nodes. After installation, you can view monitoring information of the created ECS instances in the CloudMonitor console. We recommend that you enable this feature. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Installs the CloudMonitor agent on ECS nodes.</description></item>
                /// <item><description><c>false</c>: Does not install the CloudMonitor agent on ECS nodes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("cms_enabled")]
                [Validation(Required=false)]
                public bool? CmsEnabled { get; set; }

                /// <summary>
                /// <para>The node CPU management policy. The following two policies are supported for cluster versions 1.12.6 and later:</para>
                /// <list type="bullet">
                /// <item><description><c>static</c>: allows pods with certain resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.</description></item>
                /// <item><description><c>none</c>: enables the existing default CPU affinity scheme.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("cpu_policy")]
                [Validation(Required=false)]
                public string CpuPolicy { get; set; }

                /// <summary>
                /// <para>The node tag.</para>
                /// </summary>
                [NameInMap("labels")]
                [Validation(Required=false)]
                public List<Tag> Labels { get; set; }

                /// <summary>
                /// <para>The custom node name.</para>
                /// <para>The node name consists of three parts: prefix \+ node IP address substring \+ suffix:</para>
                /// <list type="bullet">
                /// <item><description>The prefix and suffix can each consist of one or more parts separated by &quot;.&quot;. Each part can contain lowercase letters, digits, and hyphens (-). The node name must start and end with a lowercase letter or digit.</description></item>
                /// <item><description>The IP address segment length specifies the number of digits taken from the end of the node IP address. Valid values: 5 to 12.</description></item>
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
                /// <para>The node pool pre-custom data, which is a script that runs before node initialization. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Generate instance user data</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IyEvYmluL3NoCmVjaG8gIkhlbGxvIEFD</para>
                /// </summary>
                [NameInMap("pre_user_data")]
                [Validation(Required=false)]
                public string PreUserData { get; set; }

                /// <summary>
                /// <para>The container runtime name. ACK supports the following three container runtimes:</para>
                /// <list type="bullet">
                /// <item><description>containerd: recommended. Supports all cluster versions.</description></item>
                /// <item><description>Sandboxed-Container.runv: sandboxed container that provides higher isolation. Supports cluster versions 1.31 and earlier.</description></item>
                /// <item><description>docker: no longer maintained. Supports cluster versions 1.22 and earlier.</description></item>
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
                /// <para>The node taint information. Taints and tolerations work together to prevent pods from being scheduled to inappropriate nodes. For more information, see <a href="https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/">taint-and-toleration</a>.</para>
                /// </summary>
                [NameInMap("taints")]
                [Validation(Required=false)]
                public List<Taint> Taints { get; set; }

                /// <summary>
                /// <para>Specifies whether scaled-out nodes are unschedulable.</para>
                /// <list type="bullet">
                /// <item><description><para>true: unschedulable.</para>
                /// </description></item>
                /// <item><description><para>false: schedulable.</para>
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
                /// <para>The node pool custom data, which is a script that runs after node initialization. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Generate instance user data</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IyEvYmluL3NoCmVjaG8gIkhlbGxvIEFD****</para>
                /// </summary>
                [NameInMap("user_data")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <para>The managed node pool configuration. This configuration takes effect only in professional managed clusters.</para>
            /// </summary>
            [NameInMap("management")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsManagement Management { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsManagement : TeaModel {
                /// <summary>
                /// <para>Indicates whether ECS fault detection for node self-healing is enabled.</para>
                /// </summary>
                [NameInMap("auto_fault_diagnosis")]
                [Validation(Required=false)]
                public bool? AutoFaultDiagnosis { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable auto repair. This parameter takes effect only when <c>enable=true</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Enable auto repair.</description></item>
                /// <item><description><c>false</c>: Disable auto repair.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_repair")]
                [Validation(Required=false)]
                public bool? AutoRepair { get; set; }

                /// <summary>
                /// <para>The auto repair node policy.</para>
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
                    /// <para>The ID of the auto repair policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>r-xxxxxxxxx</para>
                    /// </summary>
                    [NameInMap("auto_repair_policy_id")]
                    [Validation(Required=false)]
                    public string AutoRepairPolicyId { get; set; }

                    /// <summary>
                    /// <para>Specifies whether node restart is allowed. This parameter takes effect only when <c>auto_repair=true</c>.</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c>: Allow node restart.</description></item>
                    /// <item><description><c>false</c>: Do not allow node restart.</description></item>
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
                /// <para>Specifies whether to enable automatic node upgrade. This parameter takes effect only when <c>enable=true</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Enable auto upgrade.</description></item>
                /// <item><description><c>false</c>: Disable auto upgrade.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// <para>The auto upgrade policy.</para>
                /// </summary>
                [NameInMap("auto_upgrade_policy")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoUpgradePolicy : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether automatic kubelet upgrade is allowed. This parameter takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c>: Allow automatic kubelet upgrade.</description></item>
                    /// <item><description><c>false</c>: Do not allow automatic kubelet upgrade.</description></item>
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
                /// <para>Specifies whether to enable automatic CVE fix. This parameter takes effect only when <c>enable=true</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Enable automatic CVE fix.</description></item>
                /// <item><description><c>false</c>: Disable automatic CVE fix.</description></item>
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
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoVulFixPolicy : TeaModel {
                    /// <summary>
                    /// <para>The packages to exclude during vulnerability fix.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kernel</para>
                    /// </summary>
                    [NameInMap("exclude_packages")]
                    [Validation(Required=false)]
                    public string ExcludePackages { get; set; }

                    /// <summary>
                    /// <para>Specifies whether node restart is allowed. This parameter takes effect only when <c>auto_vul_fix=true</c>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c>: Allow node restart.</description></item>
                    /// <item><description><c>false</c>: Do not allow node restart.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("restart_node")]
                    [Validation(Required=false)]
                    public bool? RestartNode { get; set; }

                    /// <summary>
                    /// <para>The vulnerability levels allowed for automatic fix, separated by commas.</para>
                    /// <list type="bullet">
                    /// <item><description><c>asap</c>: high</description></item>
                    /// <item><description><c>later</c>: medium</description></item>
                    /// <item><description><c>nntf</c>: low</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>asap,nntf</para>
                    /// </summary>
                    [NameInMap("vul_level")]
                    [Validation(Required=false)]
                    public string VulLevel { get; set; }

                }

                [NameInMap("drift_enabled")]
                [Validation(Required=false)]
                public bool? DriftEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the managed node pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Enable the managed node pool.</description></item>
                /// <item><description><c>false</c>: Disable the managed node pool. Other related configurations take effect only when <c>enable=true</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The auto upgrade configuration. This parameter takes effect only when <c>enable=true</c>.</para>
                /// </summary>
                [NameInMap("upgrade_config")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementUpgradeConfig UpgradeConfig { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementUpgradeConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable auto upgrade. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c>: Enable auto upgrade.</description></item>
                    /// <item><description><c>false</c>: Disable auto upgrade.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("auto_upgrade")]
                    [Validation(Required=false)]
                    public bool? AutoUpgrade { get; set; }

                    /// <summary>
                    /// <para>The maximum number of unavailable nodes. Valid values: [1,1000\].</para>
                    /// <para>Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("max_unavailable")]
                    [Validation(Required=false)]
                    public long? MaxUnavailable { get; set; }

                    /// <summary>
                    /// <para>The number of extra nodes. Mutually exclusive with <c>surge_percentage</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("surge")]
                    [Validation(Required=false)]
                    public long? Surge { get; set; }

                    /// <summary>
                    /// <para>The percentage of extra nodes. Mutually exclusive with <c>surge</c>.</para>
                    /// <para>Extra nodes = extra node percentage × number of nodes. For example, if the extra node percentage is 50% and there are 6 existing nodes, the number of extra nodes = 50% × 6 = 3.</para>
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
            /// <para>The maximum number of nodes allowed in the edge node pool. This value must be greater than or equal to 0. A value of 0 indicates no additional limit (limited only by the total number of nodes the cluster can contain, with no additional limit on the node pool itself). Edge node pools typically have a value greater than 0. ESS-type node pools and default edge-type node pools have a value of 0.</para>
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
                /// <para>The node component configuration.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsNodeComponentsConfig Config { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsNodeComponentsConfig : TeaModel {
                    /// <summary>
                    /// <para>The custom configuration of the node component.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;cpuManagerPolicy&quot;:&quot;static&quot;}</para>
                    /// </summary>
                    [NameInMap("custom_config")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> CustomConfig { get; set; }

                }

                /// <summary>
                /// <para>The custom configuration revision number of the node component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("config_revision")]
                [Validation(Required=false)]
                public string ConfigRevision { get; set; }

                /// <summary>
                /// <para>The node component name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kubelet</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node component version.</para>
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
            public DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfig NodeConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfig : TeaModel {
                /// <summary>
                /// <para>The Kubelet parameter settings.</para>
                /// </summary>
                [NameInMap("kubelet_configuration")]
                [Validation(Required=false)]
                public KubeletConfig KubeletConfiguration { get; set; }

                /// <summary>
                /// <para>The node operating system configuration.</para>
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
            /// <para>The node pool information.</para>
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
                /// <para>Indicates whether this is the default node pool. A cluster typically has only one default node pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Default node pool.</description></item>
                /// <item><description><c>false</c>: Non-default node pool.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_default")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The node pool name.</para>
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
                /// <para>The node pool type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>ess</c>: standard node pool (includes managed features and elastic scaling).</description></item>
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
            /// <para>The scaling group configuration of the node pool.</para>
            /// </summary>
            [NameInMap("scaling_group")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroup ScalingGroup { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroup : TeaModel {
                /// <summary>
                /// <para>Specifies whether auto-renewal is enabled for nodes. This parameter takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Enable auto-renewal.</description></item>
                /// <item><description><c>false</c>: Disable auto-renewal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("auto_renew")]
                [Validation(Required=false)]
                public bool? AutoRenew { get; set; }

                /// <summary>
                /// <para>The duration of each auto-renewal cycle. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>When PeriodUnit=Week: 1, 2, 3.</description></item>
                /// <item><description>When PeriodUnit=Month: 1, 2, 3, 6, 12, 24, 36, 48, 60.</description></item>
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
                /// <para>[This field is deprecated]</para>
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
                /// <para>When <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c>, specifies whether to allow automatic creation of pay-as-you-go instances to meet ECS instance quantity requirements when spot instances cannot be created due to cost or inventory reasons. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allowed.</description></item>
                /// <item><description><c>false</c>: Not allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("compensate_with_on_demand")]
                [Validation(Required=false)]
                public bool? CompensateWithOnDemand { get; set; }

                /// <summary>
                /// <para>The combination of data cloud disk type, size, and other configurations for nodes.</para>
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
                /// <para>The desired number of nodes in the node pool.</para>
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
                /// <para>The custom image ID. You can call <c>DescribeKubernetesVersionMetadata</c> to query the images supported by the system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun_3_x64_20G_alibase_20241218.vhd</para>
                /// </summary>
                [NameInMap("image_id")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The operating system image type.</para>
                /// <list type="bullet">
                /// <item><description><c>AliyunLinux</c>: Alinux2 image.</description></item>
                /// <item><description><c>AliyunLinuxSecurity</c>: Alinux2 UEFI image.</description></item>
                /// <item><description><c>AliyunLinux3</c>: Alinux3 image.</description></item>
                /// <item><description><c>AliyunLinux3Arm64</c>: Alinux3 ARM image.</description></item>
                /// <item><description><c>AliyunLinux3Security</c>: Alinux3 UEFI image.</description></item>
                /// <item><description><c>CentOS</c>: CentOS image.</description></item>
                /// <item><description><c>Windows</c>: Windows image.</description></item>
                /// <item><description><c>WindowsCore</c>: WindowsCore image.</description></item>
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
                /// <para>The billing type of nodes in the node pool. Valid values:</para>
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
                /// <para>The instance attribute configurations.</para>
                /// </summary>
                [NameInMap("instance_patterns")]
                [Validation(Required=false)]
                public List<InstancePatterns> InstancePatterns { get; set; }

                /// <summary>
                /// <para>The list of node instance types. You can select multiple instance types as alternatives. During node creation, the system attempts to purchase instances starting from the first specification until successful. The final purchased instance type may vary depending on inventory availability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.n4.large</para>
                /// </summary>
                [NameInMap("instance_types")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                /// <summary>
                /// <para>The billing method for the public IP address of nodes.</para>
                /// <list type="bullet">
                /// <item><description>PayByBandwidth: billed on a fixed bandwidth basis.</description></item>
                /// <item><description>PayByTraffic: billed on a pay-by-traffic basis.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayByBandwidth</para>
                /// </summary>
                [NameInMap("internet_charge_type")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// <para>The maximum outbound bandwidth for the public IP address of nodes, in Mbps (Mega bit per second). Valid values: 1 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("internet_max_bandwidth_out")]
                [Validation(Required=false)]
                public long? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// <para>The key pair name. Mutually exclusive with <c>login_password</c>.</para>
                /// <para>For managed node pools, only <c>key_pair</c> is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pro-nodepool</para>
                /// </summary>
                [NameInMap("key_pair")]
                [Validation(Required=false)]
                public string KeyPair { get; set; }

                /// <summary>
                /// <para>Specifies whether scaled-out ECS instances use non-root user login.</para>
                /// <list type="bullet">
                /// <item><description><para>true: Log on as a non-root user (ecs-user).</para>
                /// </description></item>
                /// <item><description><para>false: Log on as the root user.
                /// [<em>single.resp.200.props.nodepools.items.scaling</em></para>
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
                /// <para>The SSH login password. Mutually exclusive with <c>key_pair</c>. Logon password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
                /// <para>For security purposes, logon password is encrypted in query results.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("login_password")]
                [Validation(Required=false)]
                public string LoginPassword { get; set; }

                /// <summary>
                /// <para>The multi-zone scaling policy for ECS instances in the scaling group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>PRIORITY</c>: Scales based on the vSwitches (VSwitchIds.N) that you define. When ECS instances cannot be created in the zone of the vSwitch with the highest priority, the system automatically uses the next-priority vSwitch to create ECS instances.</para>
                /// </description></item>
                /// <item><description><para><c>COST_OPTIMIZED</c>: Creates instances based on the unit price of vCPUs, from low to high. When the scaling configuration settings specify multiple instance types with preemptible billing methods, spot instances are created first. You can use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically create pay-as-you-go instances when spot instances cannot be created due to insufficient inventory.</para>
                /// <remarks>
                /// <para><c>COST_OPTIMIZED</c> takes effect only when multiple instance types are specified in the scaling configuration or spot instances are selected.</para>
                /// </remarks>
                /// </description></item>
                /// <item><description><para><c>BALANCE</c>: Distributes ECS instances evenly across the active zones specified for the scaling group. If the zones become unbalanced due to insufficient inventory, you can call the <c>RebalanceInstances</c> API operation to allocate resources. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a>.</para>
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
                /// <para>The minimum number of pay-as-you-go instances required in the scaling group. Valid values: [0,1000\]. Pay-as-you-go instances are created first when the number of pay-as-you-go instances is less than this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("on_demand_base_capacity")]
                [Validation(Required=false)]
                public long? OnDemandBaseCapacity { get; set; }

                /// <summary>
                /// <para>The percentage of pay-as-you-go instances among the extra instances that exceed the minimum number of pay-as-you-go instances (<c>on_demand_base_capacity</c>) in the scaling group. Valid values: [0,100\].</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("on_demand_percentage_above_base_capacity")]
                [Validation(Required=false)]
                public long? OnDemandPercentageAboveBaseCapacity { get; set; }

                /// <summary>
                /// <para>The subscription duration of nodes. This parameter takes effect and is required only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
                /// <list type="bullet">
                /// <item><description>When <c>period_unit=Week</c>, valid values of <c>period</c>: {1, 2, 3, 4}.</description></item>
                /// <item><description>When <c>period_unit=Month</c>, valid values of <c>period</c>: {1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, 60}.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                /// <summary>
                /// <para>The subscription period unit. This parameter must be specified when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>Month</c>: month.</description></item>
                /// <item><description><c>Week</c>: week.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Month</para>
                /// </summary>
                [NameInMap("period_unit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>[This field is deprecated]</para>
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
                /// <para>The private pool options.</para>
                /// </summary>
                [NameInMap("private_pool_options")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupPrivatePoolOptions : TeaModel {
                    /// <summary>
                    /// <para>The private pool ID, which is the ID of the elasticity assurance or capacity reservation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eap-bp67acfmxazb4****</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The private node pool type. Specifies the private pool capacity option for instance launch. After an elasticity assurance or capacity reservation takes effect, a private pool is generated for instances to select during launch. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Open</c>: open mode. Automatically matches open-type private pool capacity. If no matching private pool capacity is available, public pool resources are used for launch.</para>
                    /// </description></item>
                    /// <item><description><para><c>Target</c>: specified mode. Uses the specified private pool capacity to launch instances. If the private pool capacity is unavailable, the instance fails to launch.</para>
                    /// </description></item>
                    /// <item><description><para><c>None</c>: not used mode. Instance launch does not use private pool capacity.</para>
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
                /// <para>This field is deprecated. Use ram_role_name instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KubernetesWorkerRole-021dc54f-929b-437a-8ae0-34c24d3e****</para>
                /// </summary>
                [NameInMap("ram_policy")]
                [Validation(Required=false)]
                public string RamPolicy { get; set; }

                /// <summary>
                /// <para>The worker RAM role name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KubernetesWorkerRole-4a4fa089-80c1-48a5-b3c6-9349311f****</para>
                /// </summary>
                [NameInMap("ram_role_name")]
                [Validation(Required=false)]
                public string RamRoleName { get; set; }

                /// <summary>
                /// <para>If RDS instances are specified, the ECS instances in the cluster node are automatically added to the whitelist of the RDS instances.</para>
                /// </summary>
                [NameInMap("rds_instances")]
                [Validation(Required=false)]
                public List<string> RdsInstances { get; set; }

                /// <summary>
                /// <para>The resource pool and resource pool policy used when creating instances.</para>
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
                    /// <para>The resource pool policy used when creating instances. Valid values:
                    /// PrivatePoolFirst: private pool first.
                    /// PrivatePoolOnly: private pool only.
                    /// None: no resource pool policy.</para>
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
                /// <para>The scaling group mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>release</c>: standard mode. Scales by creating and releasing ECS instances based on resource usage.</description></item>
                /// <item><description><c>recycle</c>: swift mode. Scales by creating, stopping, and starting ECS instances, which improves the speed of subsequent scaling operations. Compute resources are not charged during the stop period. Only storage fees are charged, except for instances with local disks.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>release</para>
                /// </summary>
                [NameInMap("scaling_policy")]
                [Validation(Required=false)]
                public string ScalingPolicy { get; set; }

                /// <summary>
                /// <para>[This field is deprecated]</para>
                /// <para>The security group ID of the node pool. When the node pool is associated with multiple security groups, this is the first value in <c>security_group_ids</c>.</para>
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
                /// <para>Specifies whether to enable Alibaba Cloud OS security hardening. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Enabled.</description></item>
                /// <item><description><c>false</c>: Disabled.</description></item>
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
                /// <para>Specifies whether to enable MLPS 2.0 security hardening. You can enable MLPS 2.0 security hardening for nodes only when the system image is Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3. Alibaba Cloud provides baseline check standards and scanning programs for classified protection compliance for Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3 MLPS 2.0 Level 3 images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("soc_enabled")]
                [Validation(Required=false)]
                public bool? SocEnabled { get; set; }

                /// <summary>
                /// <para>The number of active instance types. The scaling group creates spot instances across multiple types with the lowest cost. Valid values: [1,10\].</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("spot_instance_pools")]
                [Validation(Required=false)]
                public long? SpotInstancePools { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable supplementing of spot instances. When enabled, the scaling group attempts to create new instances to replace spot instances that are about to be reclaimed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Enabled.</description></item>
                /// <item><description><c>false</c>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("spot_instance_remedy")]
                [Validation(Required=false)]
                public bool? SpotInstanceRemedy { get; set; }

                /// <summary>
                /// <para>The spot instance market price range configuration.</para>
                /// </summary>
                [NameInMap("spot_price_limit")]
                [Validation(Required=false)]
                public List<DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupSpotPriceLimit : TeaModel {
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
                    /// <para>The market price range per instance.</para>
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
                /// <para>The spot instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSpot: non-spot instance.</description></item>
                /// <item><description>SpotWithPriceLimit: spot instance with a price limit.</description></item>
                /// <item><description>SpotAsPriceGo: system automatically bids at the current market price.</description></item>
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
                /// <para>Specifies whether burst (performance burst) is enabled for the node system cloud disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled. When enabled, the cloud disk temporarily boosts performance during sudden data read/write pressure until the workload stabilizes.</description></item>
                /// <item><description>false: Disabled.</description></item>
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
                /// <para>The multiple system cloud disk types. When a higher-priority disk type is unavailable, the system automatically attempts the next-priority disk type to create the system cloud disk.</para>
                /// </summary>
                [NameInMap("system_disk_categories")]
                [Validation(Required=false)]
                public List<string> SystemDiskCategories { get; set; }

                /// <summary>
                /// <para>The node system cloud disk type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>cloud_efficiency</c>: ultra cloud disk.</description></item>
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
                /// <para>The encryption algorithm used for the system cloud disk. Valid values: aes-256.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aes-256</para>
                /// </summary>
                [NameInMap("system_disk_encrypt_algorithm")]
                [Validation(Required=false)]
                public string SystemDiskEncryptAlgorithm { get; set; }

                /// <summary>
                /// <para>Specifies whether the system cloud disk is encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Encrypted.</description></item>
                /// <item><description>false: Not encrypted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("system_disk_encrypted")]
                [Validation(Required=false)]
                public bool? SystemDiskEncrypted { get; set; }

                /// <summary>
                /// <para>The KMS key ID used for the system cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("system_disk_kms_key_id")]
                [Validation(Required=false)]
                public string SystemDiskKmsKeyId { get; set; }

                /// <summary>
                /// <para>The performance level of the node system cloud disk. This parameter takes effect only for ESSD disks. The performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
                /// <list type="bullet">
                /// <item><description>PL0: moderate maximum concurrent I/O performance with relatively stable read/write latency.</description></item>
                /// <item><description>PL1: moderate maximum concurrent I/O performance with relatively stable read/write latency.</description></item>
                /// <item><description>PL2: high maximum concurrent I/O performance with stable read/write latency.</description></item>
                /// <item><description>PL3: ultra-high maximum concurrent I/O performance with extremely stable read/write latency.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("system_disk_performance_level")]
                [Validation(Required=false)]
                public string SystemDiskPerformanceLevel { get; set; }

                /// <summary>
                /// <para>The provisioned read/write IOPS for the node system cloud disk. This parameter is configured when the disk type is cloud_auto.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("system_disk_provisioned_iops")]
                [Validation(Required=false)]
                public long? SystemDiskProvisionedIops { get; set; }

                /// <summary>
                /// <para>The node system cloud disk size, in GiB.</para>
                /// <para>Valid values: [20,2048\].</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("system_disk_size")]
                [Validation(Required=false)]
                public long? SystemDiskSize { get; set; }

                /// <summary>
                /// <para>The system cloud disk snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-0jl6xnmme8v7o935****</para>
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
            /// <para>The node pool status.</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsStatus Status { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsStatus : TeaModel {
                /// <summary>
                /// <para>The number of failed instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("failed_nodes")]
                [Validation(Required=false)]
                public long? FailedNodes { get; set; }

                /// <summary>
                /// <para>The number of healthy instances.</para>
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
                /// <para>The number of nodes in the serving state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("serving_nodes")]
                [Validation(Required=false)]
                public long? ServingNodes { get; set; }

                /// <summary>
                /// <para>The node pool state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>active</c>: Active.</description></item>
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
            /// <para>The confidential computing configuration.</para>
            /// </summary>
            [NameInMap("tee_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsTeeConfig TeeConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsTeeConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable confidential computing for the cluster. Valid values:</para>
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

}
