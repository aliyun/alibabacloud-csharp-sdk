// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodePoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of node pool instances.</para>
        /// </summary>
        [NameInMap("nodepools")]
        [Validation(Required=false)]
        public List<DescribeClusterNodePoolsResponseBodyNodepools> Nodepools { get; set; }
        public class DescribeClusterNodePoolsResponseBodyNodepools : TeaModel {
            /// <summary>
            /// <para>Intelligent management configuration.</para>
            /// </summary>
            [NameInMap("auto_mode")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsAutoMode AutoMode { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsAutoMode : TeaModel {
                /// <summary>
                /// <para>Indicates whether intelligent management is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            /// <summary>
            /// <para>Automatic scaling configuration.</para>
            /// </summary>
            [NameInMap("auto_scaling")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsAutoScaling AutoScaling { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsAutoScaling : TeaModel {
                /// <summary>
                /// <para>Peak bandwidth of the EIP.</para>
                /// <para>Valid values: [1,100]. Unit: Mbps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("eip_bandwidth")]
                [Validation(Required=false)]
                public long? EipBandwidth { get; set; }

                /// <summary>
                /// <para>EIP billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>PayByBandwidth</c>: Pay-by-bandwidth.</para>
                /// </description></item>
                /// <item><description><para><c>PayByTraffic</c>: Pay-by-traffic.</para>
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
                /// <para>Indicates whether automatic scaling is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables automatic scaling for the node pool. When the cluster capacity cannot meet application pod scheduling requirements, ACK automatically scales node resources based on the configured minimum and maximum instance counts. Clusters of version 1.24 or later enable instant elasticity by default. Clusters earlier than version 1.24 enable node autoscaling by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node scaling</a>.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables automatic scaling. ACK adjusts the number of nodes in the node pool to match the desired node count and maintains this count.</para>
                /// </description></item>
                /// </list>
                /// <para>If this parameter is set to false, other parameters in <c>auto_scaling</c> do not take effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>Indicates whether an EIP is bound. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Binds an EIP.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Does not bind an EIP.</para>
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
                /// <para>Maximum number of scalable instances in the node pool, excluding existing instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("max_instances")]
                [Validation(Required=false)]
                public long? MaxInstances { get; set; }

                /// <summary>
                /// <para>Minimum number of scalable instances in the node pool, excluding existing instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("min_instances")]
                [Validation(Required=false)]
                public long? MinInstances { get; set; }

                /// <summary>
                /// <para>Type of automatic scaling, categorized by instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>cpu</c>: Standard instance.</para>
                /// </description></item>
                /// <item><description><para><c>gpu</c>: GPU instance.</para>
                /// </description></item>
                /// <item><description><para><c>gpushare</c>: Shared GPU instance.</para>
                /// </description></item>
                /// <item><description><para><c>spot</c>: Spot instance.</para>
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
            /// <para>Lingjun node group information.</para>
            /// </summary>
            [NameInMap("eflo_node_group")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsEfloNodeGroup EfloNodeGroup { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsEfloNodeGroup : TeaModel {
                /// <summary>
                /// <para>Lingjun cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i113790071760688002461</para>
                /// </summary>
                [NameInMap("cluster_id")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>Lingjun group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i128147721760688002463</para>
                /// </summary>
                [NameInMap("group_id")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

            }

            /// <summary>
            /// <para>[This field is deprecated.]</para>
            /// <para>Network configuration for edge node pools. This parameter applies only to edge-type node pools.</para>
            /// </summary>
            [NameInMap("interconnect_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsInterconnectConfig InterconnectConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsInterconnectConfig : TeaModel {
                /// <summary>
                /// <para>[This field is deprecated.]</para>
                /// <para>Network bandwidth for enhanced edge node pools. Unit: Mbps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// <para>[This field is deprecated.]</para>
                /// <para>CCN instance ID bound to enhanced edge node pools.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccn-qm5i0i0q9yi*******</para>
                /// </summary>
                [NameInMap("ccn_id")]
                [Validation(Required=false)]
                public string CcnId { get; set; }

                /// <summary>
                /// <para>[This field is deprecated.]</para>
                /// <para>Region of the CCN instance bound to enhanced edge node pools.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("ccn_region_id")]
                [Validation(Required=false)]
                public string CcnRegionId { get; set; }

                /// <summary>
                /// <para>[This field is deprecated.]</para>
                /// <para>CEN instance ID bound to enhanced edge node pools.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-ey9k9nfhz0f*******</para>
                /// </summary>
                [NameInMap("cen_id")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>[This field is deprecated.]</para>
                /// <para>Subscription duration for enhanced edge node pools. Unit: months.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("improved_period")]
                [Validation(Required=false)]
                public string ImprovedPeriod { get; set; }

            }

            /// <summary>
            /// <para>Network type for edge node pools. This parameter applies only to node pools where <c>type</c> is <c>edge</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>basic</c>: Public network. Nodes in the node pool interact with cloud nodes over the public network and cannot directly access the VPC intranet.</para>
            /// </description></item>
            /// <item><description><para><c>private</c>: Private network. Nodes in the node pool connect to the cloud through leased lines, VPN, or CEN, providing higher cloud-edge communication quality and better security.</para>
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
            /// <para>Cluster-related configuration.</para>
            /// </summary>
            [NameInMap("kubernetes_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsKubernetesConfig KubernetesConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsKubernetesConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether Cloud Monitor is installed on ECS nodes. After installation, you can view monitoring information for created ECS instances in the Cloud Monitor console. We recommend enabling this feature. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Installs Cloud Monitor on ECS nodes.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Does not install Cloud Monitor on ECS nodes.</para>
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
                /// <para>Node CPU management policy. Clusters of version 1.12.6 or later support the following policies:</para>
                /// <list type="bullet">
                /// <item><description><para><c>static</c>: Enhances CPU affinity and exclusivity for pods with specific resource characteristics on the node.</para>
                /// </description></item>
                /// <item><description><para><c>none</c>: Uses the default CPU affinity scheme.</para>
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
                /// <para>Node labels.</para>
                /// </summary>
                [NameInMap("labels")]
                [Validation(Required=false)]
                public List<Tag> Labels { get; set; }

                /// <summary>
                /// <para>Custom node name.</para>
                /// <para>A node name consists of three parts: prefix + IP address substring + suffix:</para>
                /// <list type="bullet">
                /// <item><description><para>Both prefix and suffix can consist of one or more parts separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). The node name must start and end with a lowercase letter or digit.</para>
                /// </description></item>
                /// <item><description><para>The IP address substring length specifies the number of trailing digits to extract from the node IP address. Valid values: 5 to 12.</para>
                /// </description></item>
                /// </list>
                /// <para>Example: If the node IP address is 192.168.0.55, the prefix is aliyun.com, the IP address substring length is 5, and the suffix is test, the node name is aliyun.com00055test.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun.com192.XX.YY.55test</para>
                /// </summary>
                [NameInMap("node_name_mode")]
                [Validation(Required=false)]
                public string NodeNameMode { get; set; }

                /// <summary>
                /// <para>Pre-custom data for the node pool. This is a script that runs before node initialization. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Generate instance custom data</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IyEvYmluL3NoCmVjaG8gIkhlbGxvIEFD</para>
                /// </summary>
                [NameInMap("pre_user_data")]
                [Validation(Required=false)]
                public string PreUserData { get; set; }

                /// <summary>
                /// <para>Container runtime name. ACK supports the following container runtimes:</para>
                /// <list type="bullet">
                /// <item><description><para>containerd: Recommended. Supported by all cluster versions.</para>
                /// </description></item>
                /// <item><description><para>Sandboxed-Container.runv: Sandboxed container that provides higher isolation. Supported by clusters of version 1.31 or earlier.</para>
                /// </description></item>
                /// <item><description><para>docker: No longer maintained. Supported by clusters of version 1.22 or earlier.</para>
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
                /// <para>Container runtime version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.6.38</para>
                /// </summary>
                [NameInMap("runtime_version")]
                [Validation(Required=false)]
                public string RuntimeVersion { get; set; }

                /// <summary>
                /// <para>Node taint information. Taints and tolerations work together to prevent pods from being scheduled onto unsuitable nodes. For more information, see <a href="https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/">taint-and-toleration</a>.</para>
                /// </summary>
                [NameInMap("taints")]
                [Validation(Required=false)]
                public List<Taint> Taints { get; set; }

                /// <summary>
                /// <para>Indicates whether newly scaled nodes are unschedulable.</para>
                /// <list type="bullet">
                /// <item><description><para>true: Unschedulable.</para>
                /// </description></item>
                /// <item><description><para>false: Schedulable.</para>
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
                /// <para>Custom data for the node pool. This is a script that runs after node initialization. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Generate instance custom data</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IyEvYmluL3NoCmVjaG8gIkhlbGxvIEFD****</para>
                /// </summary>
                [NameInMap("user_data")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <para>Managed node pool configuration. This parameter takes effect only for professional managed clusters.</para>
            /// </summary>
            [NameInMap("management")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsManagement Management { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsManagement : TeaModel {
                [NameInMap("auto_fault_diagnosis")]
                [Validation(Required=false)]
                public bool? AutoFaultDiagnosis { get; set; }

                /// <summary>
                /// <para>Automatic repair. This parameter takes effect only when <c>enable=true</c>.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables automatic repair.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables automatic repair.</para>
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
                /// <para>Automatic node repair policy.</para>
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
                    /// <para>ID of the automatic repair policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>r-xxxxxxxxx</para>
                    /// </summary>
                    [NameInMap("auto_repair_policy_id")]
                    [Validation(Required=false)]
                    public string AutoRepairPolicyId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether node restart is allowed. This parameter takes effect only when <c>auto_repair=true</c>.</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>true</c>: Allows node restart.</para>
                    /// </description></item>
                    /// <item><description><para><c>false</c>: Disallows node restart.</para>
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
                /// <para>Indicates whether node auto-upgrade is enabled. This parameter takes effect only when <c>enable=true</c>.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables auto-upgrade.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables auto-upgrade.</para>
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
                /// <para>Auto-upgrade policy.</para>
                /// </summary>
                [NameInMap("auto_upgrade_policy")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoUpgradePolicy : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether kubelet auto-upgrade is allowed. This parameter takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>true</c>: Allows kubelet auto-upgrade.</para>
                    /// </description></item>
                    /// <item><description><para><c>false</c>: Disallows kubelet auto-upgrade.</para>
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
                /// <para>Indicates whether CVEs are automatically fixed. This parameter takes effect only when <c>enable=true</c>.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables automatic CVE fixing.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables automatic CVE fixing.</para>
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
                /// <para>CVE automatic fix policy.</para>
                /// </summary>
                [NameInMap("auto_vul_fix_policy")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoVulFixPolicy : TeaModel {
                    /// <summary>
                    /// <para>Packages excluded from vulnerability fixes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kernel</para>
                    /// </summary>
                    [NameInMap("exclude_packages")]
                    [Validation(Required=false)]
                    public string ExcludePackages { get; set; }

                    /// <summary>
                    /// <para>Indicates whether node restart is allowed. This parameter takes effect only when <c>auto_vul_fix=true</c>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>true</c>: Allows node restart.</para>
                    /// </description></item>
                    /// <item><description><para><c>false</c>: Disallows node restart.</para>
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
                    /// <para>Vulnerability levels that can be automatically fixed, separated by commas.</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>asap</c>: High</para>
                    /// </description></item>
                    /// <item><description><para><c>later</c>: Medium</para>
                    /// </description></item>
                    /// <item><description><para><c>nntf</c>: Low</para>
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
                /// <para>Indicates whether the managed node pool feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables the managed node pool.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables the managed node pool. Other related configurations take effect only when <c>enable=true</c>.</para>
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
                /// <para>Auto-upgrade configuration. This parameter takes effect only when <c>enable=true</c>.</para>
                /// </summary>
                [NameInMap("upgrade_config")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementUpgradeConfig UpgradeConfig { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementUpgradeConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether auto-upgrade is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>true</c>: Enables auto-upgrade.</para>
                    /// </description></item>
                    /// <item><description><para><c>false</c>: Disables auto-upgrade.</para>
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
                    /// <para>Maximum number of unavailable nodes. Valid values: [1,1000].</para>
                    /// <para>Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("max_unavailable")]
                    [Validation(Required=false)]
                    public long? MaxUnavailable { get; set; }

                    /// <summary>
                    /// <para>Number of extra nodes. Specify either this parameter or <c>surge_percentage</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("surge")]
                    [Validation(Required=false)]
                    public long? Surge { get; set; }

                    /// <summary>
                    /// <para>Percentage of extra nodes. Specify either this parameter or <c>surge</c>.</para>
                    /// <para>Number of extra nodes = surge percentage × number of nodes. For example, if you set the surge percentage to 50% and the current number of nodes is 6, the number of extra nodes is 50% × 6 = 3.</para>
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
            /// <para>Maximum number of nodes allowed in an edge node pool. This parameter is greater than or equal to 0. A value of 0 means no additional limit (only limited by the overall cluster capacity). This parameter is usually greater than 0 for edge node pools, and 0 for ess-type node pools and default edge-type node pools.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_nodes")]
            [Validation(Required=false)]
            public long? MaxNodes { get; set; }

            /// <summary>
            /// <para>List of node components.</para>
            /// </summary>
            [NameInMap("node_components")]
            [Validation(Required=false)]
            public List<DescribeClusterNodePoolsResponseBodyNodepoolsNodeComponents> NodeComponents { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsNodeComponents : TeaModel {
                /// <summary>
                /// <para>Node component configuration.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsNodeComponentsConfig Config { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsNodeComponentsConfig : TeaModel {
                    /// <summary>
                    /// <para>Custom configuration for node components.</para>
                    /// </summary>
                    [NameInMap("custom_config")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> CustomConfig { get; set; }

                }

                /// <summary>
                /// <para>Node component name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kubelet</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Node component version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.33.3-aliyun.1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Node configuration.</para>
            /// </summary>
            [NameInMap("node_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfig NodeConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfig : TeaModel {
                /// <summary>
                /// <para>Kubelet parameter configuration.</para>
                /// </summary>
                [NameInMap("kubelet_configuration")]
                [Validation(Required=false)]
                public KubeletConfig KubeletConfiguration { get; set; }

                /// <summary>
                /// <para>Node operating system configuration.</para>
                /// </summary>
                [NameInMap("node_os_config")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfigNodeOsConfig NodeOsConfig { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfigNodeOsConfig : TeaModel {
                    /// <summary>
                    /// <para>Hugepage configuration.</para>
                    /// </summary>
                    [NameInMap("hugepage")]
                    [Validation(Required=false)]
                    public Hugepage Hugepage { get; set; }

                }

            }

            /// <summary>
            /// <para>Node pool information.</para>
            /// </summary>
            [NameInMap("nodepool_info")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsNodepoolInfo NodepoolInfo { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsNodepoolInfo : TeaModel {
                /// <summary>
                /// <para>Time when the node pool was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-15T16:33:29.362888807+08:00</para>
                /// </summary>
                [NameInMap("created")]
                [Validation(Required=false)]
                public string Created { get; set; }

                /// <summary>
                /// <para>Indicates whether the node pool is the default node pool. A cluster usually has only one default node pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Default node pool.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Non-default node pool.</para>
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
                /// <para>Node pool name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default-nodepool</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Node pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>np615c0e0966124216a0412e10afe0****</para>
                /// </summary>
                [NameInMap("nodepool_id")]
                [Validation(Required=false)]
                public string NodepoolId { get; set; }

                /// <summary>
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("region_id")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmyvw3wjm****</para>
                /// </summary>
                [NameInMap("resource_group_id")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Node pool type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>ess</c>: Standard node pool (supports managed features and automatic elastic scaling).</para>
                /// </description></item>
                /// <item><description><para><c>edge</c>: Edge node pool.</para>
                /// </description></item>
                /// <item><description><para><c>lingjun</c>: Lingjun node pool.</para>
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
                /// <para>Time when the node pool was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-15T16:33:32.823+08:00</para>
                /// </summary>
                [NameInMap("updated")]
                [Validation(Required=false)]
                public string Updated { get; set; }

            }

            /// <summary>
            /// <para>Scaling group configuration for the node pool.</para>
            /// </summary>
            [NameInMap("scaling_group")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroup ScalingGroup { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroup : TeaModel {
                /// <summary>
                /// <para>Indicates whether auto-renewal is enabled for nodes. This parameter takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
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
                /// <para>Duration of each auto-renewal cycle. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>When PeriodUnit=Week: 1, 2, 3.</para>
                /// </description></item>
                /// <item><description><para>When PeriodUnit=Month: 1, 2, 3, 6, 12, 24, 36, 48, 60.</para>
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
                /// <para>[This field is deprecated.]</para>
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
                /// <para>When <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c>, indicates whether to automatically attempt creating pay-as-you-go instances if sufficient spot instances cannot be created due to price or inventory issues. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Allows automatic attempts to create pay-as-you-go instances to meet the required ECS instance count.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disallows automatic attempts to create pay-as-you-go instances to meet the required ECS instance count.</para>
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
                /// <para>Combination of data disk types, sizes, and other configurations for nodes.</para>
                /// </summary>
                [NameInMap("data_disks")]
                [Validation(Required=false)]
                public List<DataDisk> DataDisks { get; set; }

                /// <summary>
                /// <para>Deployment set ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds-bp1d19mmbsv3jf6xxxxx</para>
                /// </summary>
                [NameInMap("deploymentset_id")]
                [Validation(Required=false)]
                public string DeploymentsetId { get; set; }

                /// <summary>
                /// <para>Desired number of nodes in the node pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("desired_size")]
                [Validation(Required=false)]
                public long? DesiredSize { get; set; }

                /// <summary>
                /// <para>Block device initialization configuration.</para>
                /// </summary>
                [NameInMap("disk_init")]
                [Validation(Required=false)]
                public List<DiskInit> DiskInit { get; set; }

                /// <summary>
                /// <para>Custom image ID. You can query supported images using <c>DescribeKubernetesVersionMetadata</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun_3_x64_20G_alibase_20241218.vhd</para>
                /// </summary>
                [NameInMap("image_id")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>Operating system image type.</para>
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
                /// <para>Billing method for nodes in the node pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>PrePaid</c>: Subscription.</para>
                /// </description></item>
                /// <item><description><para><c>PostPaid</c>: Pay-as-you-go.</para>
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
                /// <para>Instance attribute configuration.</para>
                /// </summary>
                [NameInMap("instance_patterns")]
                [Validation(Required=false)]
                public List<InstancePatterns> InstancePatterns { get; set; }

                /// <summary>
                /// <para>List of node instance types. You can select multiple instance types as alternatives. When creating a node, the system attempts to purchase instances starting from the first type until successful. The actual purchased instance type may vary due to inventory availability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.n4.large</para>
                /// </summary>
                [NameInMap("instance_types")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                /// <summary>
                /// <para>Billing method for public network bandwidth of nodes.</para>
                /// <list type="bullet">
                /// <item><description><para>PayByBandwidth: Pay-by-bandwidth.</para>
                /// </description></item>
                /// <item><description><para>PayByTraffic: Pay-by-traffic.</para>
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
                /// <para>Maximum outbound public bandwidth for nodes. Unit: Mbps. Valid values: 1 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("internet_max_bandwidth_out")]
                [Validation(Required=false)]
                public long? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// <para>Key pair name. Specify either this parameter or <c>login_password</c>.</para>
                /// <para>For managed node pools, only <c>key_pair</c> is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pro-nodepool</para>
                /// </summary>
                [NameInMap("key_pair")]
                [Validation(Required=false)]
                public string KeyPair { get; set; }

                /// <summary>
                /// <para>Indicates whether to log on to the ECS instance as a non-root user.</para>
                /// <list type="bullet">
                /// <item><description><para>true: Log on as the non-root user (ecs-user).</para>
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
                /// <para>SSH logon password. Specify either this parameter or <c>key_pair</c>. The password must be 8 to 30 characters long and contain at least three of the following: uppercase letters, lowercase letters, digits, and special characters.</para>
                /// <para>For security reasons, the returned password is encrypted.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("login_password")]
                [Validation(Required=false)]
                public string LoginPassword { get; set; }

                /// <summary>
                /// <para>ECS instance scaling policy for multi-zone scaling groups. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>PRIORITY</c>: Scales based on the virtual switches (VSwitchIds.N) you define. If ECS instances cannot be created in the zone of a higher-priority virtual switch, the system automatically uses the next priority virtual switch.</para>
                /// </description></item>
                /// <item><description><para><c>COST_OPTIMIZED</c>: Attempts to create instances from lowest to highest vCPU price. When multiple instance types or spot billing are configured, spot instances are prioritized. You can use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically attempt pay-as-you-go instance creation if spot instances cannot be created due to inventory or other reasons.</para>
                /// <remarks>
                /// <para><c>COST_OPTIMIZED</c> takes effect only when multiple instance types are configured or spot instances are selected.</para>
                /// </remarks>
                /// </description></item>
                /// <item><description><para><c>BALANCE</c>: Distributes ECS instances evenly across the specified zones. If zones become unbalanced due to inventory shortages, you can use the <c>RebalanceInstances</c> API to rebalance resources. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a>.</para>
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
                /// <para>Minimum number of pay-as-you-go instances required in the scaling group. Valid values: [0,1000]. If the number of pay-as-you-go instances is less than this value, pay-as-you-go instances are prioritized for creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("on_demand_base_capacity")]
                [Validation(Required=false)]
                public long? OnDemandBaseCapacity { get; set; }

                /// <summary>
                /// <para>Percentage of pay-as-you-go instances among instances exceeding the minimum pay-as-you-go instance count (<c>on_demand_base_capacity</c>). Valid values: [0,100].</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("on_demand_percentage_above_base_capacity")]
                [Validation(Required=false)]
                public long? OnDemandPercentageAboveBaseCapacity { get; set; }

                /// <summary>
                /// <para>Subscription duration for nodes. This parameter takes effect and is required only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
                /// <list type="bullet">
                /// <item><description><para>When <c>period_unit=Week</c>, valid values for <c>period</c> are {1, 2, 3, 4}.</para>
                /// </description></item>
                /// <item><description><para>When <c>period_unit=Month</c>, valid values for <c>period</c> are {1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, 60}.</para>
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
                /// <para>Billing cycle for nodes. Specify this parameter when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
                /// <list type="bullet">
                /// <item><description><para><c>Month</c>: Billed monthly.</para>
                /// </description></item>
                /// <item><description><para><c>Week</c>: Billed weekly.</para>
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
                /// <para>[This field is deprecated.]</para>
                /// <para>Operating system distribution. Valid values:</para>
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
                /// <para>Private pool options.</para>
                /// </summary>
                [NameInMap("private_pool_options")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupPrivatePoolOptions : TeaModel {
                    /// <summary>
                    /// <para>Private pool ID. This is the ID of an elasticity assurance service or capacity reservation service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eap-bp67acfmxazb4****</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Private pool type. Specifies how instance startup uses private pool capacity. After an elasticity assurance service or capacity reservation service takes effect, it generates private pool capacity for instance startup. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Open</c>: Open mode. Automatically matches open-type private pool capacity. If no matching private pool capacity is available, public pool resources are used.</para>
                    /// </description></item>
                    /// <item><description><para><c>Target</c>: Target mode. Uses the specified private pool capacity to start instances. If the private pool capacity is unavailable, instance startup fails.</para>
                    /// </description></item>
                    /// <item><description><para><c>None</c>: None mode. Instance startup does not use private pool capacity.</para>
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
                /// <para>Worker RAM role name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KubernetesWorkerRole-4a4fa089-80c1-48a5-b3c6-9349311f****</para>
                /// </summary>
                [NameInMap("ram_role_name")]
                [Validation(Required=false)]
                public string RamRoleName { get; set; }

                /// <summary>
                /// <para>If RDS instances are specified, ECS nodes in the cluster are automatically added to the RDS access whitelist.</para>
                /// </summary>
                [NameInMap("rds_instances")]
                [Validation(Required=false)]
                public List<string> RdsInstances { get; set; }

                /// <summary>
                /// <para>Resource pool and strategy used when creating instances.</para>
                /// </summary>
                [NameInMap("resource_pool_options")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupResourcePoolOptions : TeaModel {
                    /// <summary>
                    /// <para>List of private pool IDs.</para>
                    /// </summary>
                    [NameInMap("private_pool_ids")]
                    [Validation(Required=false)]
                    public List<string> PrivatePoolIds { get; set; }

                    /// <summary>
                    /// <para>Resource pool strategy used when creating instances. Valid values:
                    /// PrivatePoolFirst: Private pool first.
                    /// PrivatePoolOnly: Private pool only.
                    /// None: Do not use resource pool strategy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PrivatePoolFirst</para>
                    /// </summary>
                    [NameInMap("strategy")]
                    [Validation(Required=false)]
                    public string Strategy { get; set; }

                }

                /// <summary>
                /// <para>Scaling group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asg-2ze8n5qw4atggut8****</para>
                /// </summary>
                [NameInMap("scaling_group_id")]
                [Validation(Required=false)]
                public string ScalingGroupId { get; set; }

                /// <summary>
                /// <para>Scaling group mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>release</c>: Standard mode. Scales by creating or releasing ECS instances based on resource usage.</para>
                /// </description></item>
                /// <item><description><para><c>recycle</c>: Fast mode. Scales by creating, stopping, or starting instances to speed up subsequent scaling operations. (Stopped instances incur no compute charges, only storage fees, except for local-disk instance types.)</para>
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
                /// <para>[This field is deprecated.]</para>
                /// <para>Security group ID for the node pool. When multiple security groups are bound to the node pool, this value is the first value in <c>security_group_ids</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-2ze1iuk12m2sb4c4****</para>
                /// </summary>
                [NameInMap("security_group_id")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>List of security group IDs for the node pool.</para>
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
                /// <para>Indicates whether classified protection compliance hardening is enabled. You can enable this feature for nodes only when Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3 is selected as the OS image. Alibaba Cloud provides baseline check standards and scanning programs for MLPS 2.0 Level-3 compliance for Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3 images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("soc_enabled")]
                [Validation(Required=false)]
                public bool? SocEnabled { get; set; }

                /// <summary>
                /// <para>Number of available instance types. The scaling group creates spot instances evenly across the lowest-cost instance types. Valid values: [1,10].</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("spot_instance_pools")]
                [Validation(Required=false)]
                public long? SpotInstancePools { get; set; }

                /// <summary>
                /// <para>Indicates whether to replenish spot instances. When enabled, if the system receives a notification that a spot instance will be reclaimed, the scaling group attempts to create a new instance to replace the instance to be reclaimed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables replenishment.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables replenishment.</para>
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
                /// <para>Market price range configuration for spot instances.</para>
                /// </summary>
                [NameInMap("spot_price_limit")]
                [Validation(Required=false)]
                public List<DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupSpotPriceLimit : TeaModel {
                    /// <summary>
                    /// <para>Spot instance type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs.c6.large</para>
                    /// </summary>
                    [NameInMap("instance_type")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>Market price range per instance.</para>
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
                /// <para>Spot instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>NoSpot: Regular instance.</para>
                /// </description></item>
                /// <item><description><para>SpotWithPriceLimit: Sets a maximum price for spot instances.</para>
                /// </description></item>
                /// <item><description><para>SpotAsPriceGo: Uses the current market price.</para>
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
                /// <para>Indicates whether burst performance is enabled for the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enabled. When facing sudden read/write pressure from fluctuating workloads, the disk temporarily boosts performance based on actual workload conditions until the workload stabilizes.</para>
                /// </description></item>
                /// <item><description><para>false: Disabled.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("system_disk_bursting_enabled")]
                [Validation(Required=false)]
                public bool? SystemDiskBurstingEnabled { get; set; }

                /// <summary>
                /// <para>Multiple system disk types. If the system cannot use a higher-priority disk type, it automatically tries the next priority disk type to create the system disk.</para>
                /// </summary>
                [NameInMap("system_disk_categories")]
                [Validation(Required=false)]
                public List<string> SystemDiskCategories { get; set; }

                /// <summary>
                /// <para>System disk type for nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>cloud_efficiency</c>: Ultra disk.</para>
                /// </description></item>
                /// <item><description><para><c>cloud_ssd</c>: Standard SSD.</para>
                /// </description></item>
                /// <item><description><para><c>cloud_essd</c>: Enterprise SSD.</para>
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
                /// <para>Encryption algorithm used for the system disk. Valid values: aes-256.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aes-256</para>
                /// </summary>
                [NameInMap("system_disk_encrypt_algorithm")]
                [Validation(Required=false)]
                public string SystemDiskEncryptAlgorithm { get; set; }

                /// <summary>
                /// <para>Indicates whether the system disk is encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Encrypted.</para>
                /// </description></item>
                /// <item><description><para>false: Not encrypted.</para>
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
                /// <para>KMS key ID used for the system disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("system_disk_kms_key_id")]
                [Validation(Required=false)]
                public string SystemDiskKmsKeyId { get; set; }

                /// <summary>
                /// <para>Disk performance level for the system disk. This parameter applies only to ESSD disks. Disk performance levels depend on disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD disks</a>.</para>
                /// <list type="bullet">
                /// <item><description><para>PL0: Moderate I/O performance with stable read/write latency.</para>
                /// </description></item>
                /// <item><description><para>PL1: Moderate I/O performance with stable read/write latency.</para>
                /// </description></item>
                /// <item><description><para>PL2: High I/O performance with stable read/write latency.</para>
                /// </description></item>
                /// <item><description><para>PL3: Extremely high I/O performance with highly stable read/write latency.</para>
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
                /// <para>Provisioned read/write IOPS for the system disk. Configure this parameter when the disk type is cloud_auto.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("system_disk_provisioned_iops")]
                [Validation(Required=false)]
                public long? SystemDiskProvisionedIops { get; set; }

                /// <summary>
                /// <para>System disk size for nodes. Unit: GiB.</para>
                /// <para>Valid values: [20,2048].</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("system_disk_size")]
                [Validation(Required=false)]
                public long? SystemDiskSize { get; set; }

                /// <summary>
                /// <para>System disk snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-0jl6xnmme8v7o935****</para>
                /// </summary>
                [NameInMap("system_disk_snapshot_policy_id")]
                [Validation(Required=false)]
                public string SystemDiskSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>ECS instance tags.</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<Tag> Tags { get; set; }

                /// <summary>
                /// <para>List of virtual switch IDs.</para>
                /// </summary>
                [NameInMap("vswitch_ids")]
                [Validation(Required=false)]
                public List<string> VswitchIds { get; set; }

            }

            /// <summary>
            /// <para>Node pool status.</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsStatus Status { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsStatus : TeaModel {
                /// <summary>
                /// <para>Number of failed instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("failed_nodes")]
                [Validation(Required=false)]
                public long? FailedNodes { get; set; }

                /// <summary>
                /// <para>Number of healthy instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("healthy_nodes")]
                [Validation(Required=false)]
                public long? HealthyNodes { get; set; }

                /// <summary>
                /// <para>Number of nodes being created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("initial_nodes")]
                [Validation(Required=false)]
                public long? InitialNodes { get; set; }

                /// <summary>
                /// <para>Number of offline nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("offline_nodes")]
                [Validation(Required=false)]
                public long? OfflineNodes { get; set; }

                /// <summary>
                /// <para>Number of nodes being removed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("removing_nodes")]
                [Validation(Required=false)]
                public long? RemovingNodes { get; set; }

                /// <summary>
                /// <para>Number of active nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("serving_nodes")]
                [Validation(Required=false)]
                public long? ServingNodes { get; set; }

                /// <summary>
                /// <para>Node pool state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>active</c>: Activated.</para>
                /// </description></item>
                /// <item><description><para><c>scaling</c>: Scaling.</para>
                /// </description></item>
                /// <item><description><para><c>removing</c>: Removing nodes.</para>
                /// </description></item>
                /// <item><description><para><c>deleting</c>: Deleting.</para>
                /// </description></item>
                /// <item><description><para><c>updating</c>: Updating.</para>
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
                /// <para>Total number of nodes in the node pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("total_nodes")]
                [Validation(Required=false)]
                public long? TotalNodes { get; set; }

            }

            /// <summary>
            /// <para>Confidential computing configuration.</para>
            /// </summary>
            [NameInMap("tee_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsTeeConfig TeeConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsTeeConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether confidential computing is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disabled.</para>
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
