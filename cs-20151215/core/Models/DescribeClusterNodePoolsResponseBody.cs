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
                /// <para>Specifies whether intelligent management is enabled.</para>
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
                /// <para>The peak bandwidth of the EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("eip_bandwidth")]
                [Validation(Required=false)]
                public long? EipBandwidth { get; set; }

                /// <summary>
                /// <para>The billing method for EIPs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>PayByBandwidth</c>: pay-by-bandwidth.</description></item>
                /// <item><description><c>PayByTraffic</c>: pay-by-data-transfer.</description></item>
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
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>Indicates whether an EIP is associated. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_bond_eip")]
                [Validation(Required=false)]
                public bool? IsBondEip { get; set; }

                /// <summary>
                /// <para>The maximum number of instances that can be scaled in the node pool, excluding your existing instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("max_instances")]
                [Validation(Required=false)]
                public long? MaxInstances { get; set; }

                /// <summary>
                /// <para>The minimum number of instances that can be scaled in the node pool, excluding your existing instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("min_instances")]
                [Validation(Required=false)]
                public long? MinInstances { get; set; }

                /// <summary>
                /// <para>The auto scaling type, classified by instance type. Valid values:</para>
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
                /// <para>Specifies whether automatic node addition is enabled for the Lingjun node pool (not effective).</para>
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
                /// <para>The Worker RAM role used by the Lingjun node pool.</para>
                /// </summary>
                [NameInMap("worker_ram_role_name")]
                [Validation(Required=false)]
                public string WorkerRamRoleName { get; set; }

            }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("interconnect_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsInterconnectConfig InterconnectConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsInterconnectConfig : TeaModel {
                /// <summary>
                /// <para><b>[Deprecated]</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>ccn-qm5i0i0q9yi*******</para>
                /// </summary>
                [NameInMap("ccn_id")]
                [Validation(Required=false)]
                public string CcnId { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("ccn_region_id")]
                [Validation(Required=false)]
                public string CcnRegionId { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-ey9k9nfhz0f*******</para>
                /// </summary>
                [NameInMap("cen_id")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("improved_period")]
                [Validation(Required=false)]
                public string ImprovedPeriod { get; set; }

            }

            /// <summary>
            /// <para>The network type of the edge node pool. This parameter takes effect only for node pools whose <c>type</c> is <c>edge</c>. Valid values:</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("cms_enabled")]
                [Validation(Required=false)]
                public bool? CmsEnabled { get; set; }

                /// <summary>
                /// <para>The node CPU management policy. The following two policies are supported for clusters of version 1.12.6 or later:</para>
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
                /// <para>The container runtime name. ACK supports the following three container runtimes.</para>
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
                /// <para>Specifies whether to enable node self-healing ECS fault detection.</para>
                /// </summary>
                [NameInMap("auto_fault_diagnosis")]
                [Validation(Required=false)]
                public bool? AutoFaultDiagnosis { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable automatic repair. This parameter takes effect only when <c>enable=true</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Automatic repair is enabled.</description></item>
                /// <item><description><c>false</c>: Automatic repair is disabled.</description></item>
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
                    /// <para>Specifies whether manual approval is required for node repair.</para>
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
                    /// <para>The maximum number of nodes that can be repaired in parallel. When a large number of abnormal nodes exist in the node pool, this specifies the maximum number or proportion of nodes that can be repaired simultaneously.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("max_parallel_repairing_nodes")]
                    [Validation(Required=false)]
                    public string MaxParallelRepairingNodes { get; set; }

                    /// <summary>
                    /// <para>The self-healing circuit breaker threshold. When the number or proportion of faulty nodes exceeds this threshold, self-healing enters a circuit breaker state and stops initiating new repair actions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10%</para>
                    /// </summary>
                    [NameInMap("max_unhealthy_nodes_threshold")]
                    [Validation(Required=false)]
                    public string MaxUnhealthyNodesThreshold { get; set; }

                    /// <summary>
                    /// <para>Specifies whether node restart is allowed. This parameter takes effect only when <c>auto_repair=true</c>.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// <para>The automatic upgrade policy.</para>
                /// </summary>
                [NameInMap("auto_upgrade_policy")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoUpgradePolicy : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow automatic kubelet upgrade. This parameter takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("auto_upgrade_kubelet")]
                    [Validation(Required=false)]
                    public bool? AutoUpgradeKubelet { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to automatically fix CVEs. This parameter takes effect only when <c>enable=true</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Automatically fix CVEs.</description></item>
                /// <item><description><c>false</c>: Do not automatically fix CVEs.</description></item>
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
                    /// <para>Specifies whether to allow node restarts. This parameter takes effect only when <c>auto_vul_fix=true</c>. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("restart_node")]
                    [Validation(Required=false)]
                    public bool? RestartNode { get; set; }

                    /// <summary>
                    /// <para>The vulnerability levels that are allowed for automatic fixing, separated by commas.</para>
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

                /// <summary>
                /// <para>Specifies whether to enable node rotation. Only intelligent managed node pools support this feature, and it is enabled by default. Regular node pools do not support this feature.</para>
                /// </summary>
                [NameInMap("drift_enabled")]
                [Validation(Required=false)]
                public bool? DriftEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the managed node pool is enabled. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The automatic upgrade configuration. This parameter takes effect only when <c>enable=true</c>.</para>
                /// </summary>
                [NameInMap("upgrade_config")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementUpgradeConfig UpgradeConfig { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementUpgradeConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable automatic upgrade. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("auto_upgrade")]
                    [Validation(Required=false)]
                    public bool? AutoUpgrade { get; set; }

                    /// <summary>
                    /// <para>The maximum number of unavailable nodes. Valid values: [1,1000\].</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("max_unavailable")]
                    [Validation(Required=false)]
                    public long? MaxUnavailable { get; set; }

                    /// <summary>
                    /// <para>The number of extra nodes. You must set this parameter or <c>surge_percentage</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("surge")]
                    [Validation(Required=false)]
                    public long? Surge { get; set; }

                    /// <summary>
                    /// <para>The percentage of additional nodes. This parameter is mutually exclusive with <c>surge</c>.</para>
                    /// <para>Additional nodes = surge percentage × number of existing nodes. For example, if the surge percentage is set to 50% and there are 6 existing nodes, the number of additional nodes = 50% × 6, which means 3 additional nodes are created.</para>
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
            /// <para>The maximum number of nodes allowed in the edge node pool. The maximum number of nodes that the node pool can contain. This parameter is greater than or equal to 0. A value of 0 indicates no additional limit (limited only by the maximum number of nodes the cluster can contain, with no additional limit on the node pool itself). This value is typically greater than 0 for edge node pools. For ess-type node pools and default edge-type node pools, this value is 0.</para>
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
                    /// <para>The node component custom configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;cpuManagerPolicy&quot;:&quot;static&quot;}</para>
                    /// </summary>
                    [NameInMap("custom_config")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> CustomConfig { get; set; }

                }

                /// <summary>
                /// <para>The node component custom configuration revision number.</para>
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
                /// <para>Indicates whether this is the default node pool. Typically, a cluster has only one default node pool. Valid values:</para>
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
                /// <para>Specifies whether to enable auto-renewal for nodes. This parameter takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("auto_renew")]
                [Validation(Required=false)]
                public bool? AutoRenew { get; set; }

                /// <summary>
                /// <para>The duration of each auto-renewal cycle. Valid values:</para>
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
                /// <para><b>[Deprecated]</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("cis_enabled")]
                [Validation(Required=false)]
                [Obsolete]
                public bool? CisEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the required number of ECS instances when spot instances cannot be created due to cost or inventory reasons, if <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allows automatic creation of pay-as-you-go instances to meet the required number of ECS instances.</description></item>
                /// <item><description><c>false</c>: Does not allow automatic creation of pay-as-you-go instances to meet the required number of ECS instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("compensate_with_on_demand")]
                [Validation(Required=false)]
                public bool? CompensateWithOnDemand { get; set; }

                /// <summary>
                /// <para>The CPU configuration options.</para>
                /// </summary>
                [NameInMap("cpu_options")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupCpuOptions CpuOptions { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupCpuOptions : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether nested virtualization is enabled. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enabled</para>
                    /// </summary>
                    [NameInMap("nested_virtualization")]
                    [Validation(Required=false)]
                    public string NestedVirtualization { get; set; }

                }

                /// <summary>
                /// <para>The combination of configurations for node data cloud disks, such as disk type and size.</para>
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
                /// <para>Specifies whether to enable high-density cloud disk mode. This is supported only when the node pool uses instance types. When enabled, the total number of system cloud disks and data cloud disks does not exceed the maximum number of high-density cloud disks supported by the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable_high_density_mode")]
                [Validation(Required=false)]
                public bool? EnableHighDensityMode { get; set; }

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
                /// <para>The instance attribute configurations.</para>
                /// </summary>
                [NameInMap("instance_patterns")]
                [Validation(Required=false)]
                public List<InstancePatterns> InstancePatterns { get; set; }

                /// <summary>
                /// <para>The list of node instance types. You can select multiple instance types as alternatives. During node creation, the system attempts to purchase instances starting from the first specification until successful. The actual purchased instance type may vary depending on inventory availability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.n4.large</para>
                /// </summary>
                [NameInMap("instance_types")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                /// <summary>
                /// <para>The billing method for the public IP addresses of nodes.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
                /// <item><description>PayByTraffic: pay-by-data-transfer.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayByBandwidth</para>
                /// </summary>
                [NameInMap("internet_charge_type")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// <para>The maximum outbound bandwidth for node public IP addresses, in Mbps (Mega bit per second). Valid values: 1 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("internet_max_bandwidth_out")]
                [Validation(Required=false)]
                public long? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// <para>The name of the key pair. You must specify either this parameter or <c>login_password</c>.</para>
                /// <para>When the node pool is a managed node pool, only <c>key_pair</c> is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pro-nodepool</para>
                /// </summary>
                [NameInMap("key_pair")]
                [Validation(Required=false)]
                public string KeyPair { get; set; }

                /// <summary>
                /// <para>Indicates whether the scaled-out ECS instances use a non-root user for logon.</para>
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
                /// <para>The SSH logon password. Specify either this parameter or <c>key_pair</c>. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
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
                /// <item><description><para><c>PRIORITY</c>: Scales ECS instances based on the virtual switches (VSwitchIds.N) that you define. When ECS instances cannot be created in the zone of the highest-priority vSwitch, the system automatically uses the next-priority vSwitch to create ECS instances.</para>
                /// </description></item>
                /// <item><description><para><c>COST_OPTIMIZED</c>: Attempts to create ECS instances in ascending order of vCPU unit price. When the scaling configuration specifies multiple instance types with the spot billing method, spot instances are created first. You can use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically attempt to create pay-as-you-go instances when spot instances cannot be created due to insufficient inventory.</para>
                /// <remarks>
                /// <para><c>COST_OPTIMIZED</c> takes effect only when the scaling configuration specifies multiple instance types or uses spot instances.</para>
                /// </remarks>
                /// </description></item>
                /// <item><description><para><c>BALANCE</c>: Evenly distributes ECS instances across the multiple zones specified in the scaling group. If zones become unbalanced due to insufficient inventory, you can use the <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a> API operation to rebalance resources.</para>
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
                /// <para>The minimum number of pay-as-you-go instances required in the scaling group. Valid values: [0,1000\]. When the number of pay-as-you-go instances is less than this value, pay-as-you-go instances are preferentially created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("on_demand_base_capacity")]
                [Validation(Required=false)]
                public long? OnDemandBaseCapacity { get; set; }

                /// <summary>
                /// <para>The percentage of pay-as-you-go instances among the extra instances that exceed the minimum number of pay-as-you-go instances (<c>on_demand_base_capacity</c>) required in the scaling group. Valid values: [0,100\].</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("on_demand_percentage_above_base_capacity")]
                [Validation(Required=false)]
                public long? OnDemandPercentageAboveBaseCapacity { get; set; }

                /// <summary>
                /// <para>The subscription duration of nodes. This parameter takes effect and is required only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                /// <summary>
                /// <para>The unit of the subscription period. This parameter must be specified when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Month</para>
                /// </summary>
                [NameInMap("period_unit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b></para>
                /// <para>The operating system distribution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CentOS</description></item>
                /// <item><description>AliyunLinux</description></item>
                /// <item><description>Windows</description></item>
                /// <item><description>WindowsCore</description></item>
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
                    /// <para>The type of the private node pool. The private pool capacity option for instance startup. After an elasticity assurance or capacity reservation takes effect, a private pool capacity is generated for instances to select during startup. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Open</c>: open mode. Automatically matches open-type private pool capacity. If no eligible private pool capacity is available, public pool resources are used to start the instance.</para>
                    /// </description></item>
                    /// <item><description><para><c>Target</c>: specified mode. Uses the specified private pool capacity to start the instance. If the private pool capacity is unavailable, the instance fails to start.</para>
                    /// </description></item>
                    /// <item><description><para><c>None</c>: not used mode. The instance startup does not use private pool capacity.</para>
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
                /// <para>If RDS instances are specified, the ECS instances in the cluster nodes are automatically added to the RDS whitelist.</para>
                /// </summary>
                [NameInMap("rds_instances")]
                [Validation(Required=false)]
                public List<string> RdsInstances { get; set; }

                /// <summary>
                /// <para>The resource pools and resource pool policies used when creating instances.</para>
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
                    /// <para>The resource pool policy used when creating instances. Valid values:</para>
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
                /// <item><description><c>release</c>: standard mode. Elastic Compute Service (ECS) instances are created and released based on resource usage.</description></item>
                /// <item><description><c>recycle</c>: swift mode. ECS instances are created, stopped, and started for scaling, which improves the speed of subsequent scaling events. In this mode, stopped instances are not charged for compute resources but are still charged for storage resources, except for instances that use local disks.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>release</para>
                /// </summary>
                [NameInMap("scaling_policy")]
                [Validation(Required=false)]
                public string ScalingPolicy { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b></para>
                /// <para>The security group ID of the node pool. When the node pool is associated with multiple security groups, this is the first value in security_group_ids.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("security_hardening_os")]
                [Validation(Required=false)]
                public bool? SecurityHardeningOs { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable MLPS 2.0 security hardening. MLPS 2.0 security hardening can be enabled only when the system image is Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3. Alibaba Cloud provides classified protection compliance baseline check standards and scanning programs for Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3 MLPS 2.0 Level 3 images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("soc_enabled")]
                [Validation(Required=false)]
                public bool? SocEnabled { get; set; }

                /// <summary>
                /// <para>The number of available instance types. The scaling group creates spot instances of multiple types at the lowest cost. Valid values: [1,10\].</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("spot_instance_pools")]
                [Validation(Required=false)]
                public long? SpotInstancePools { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable supplementation of spot instances. When enabled, the scaling group attempts to create new instances to replace spot instances that are about to be reclaimed. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("spot_instance_remedy")]
                [Validation(Required=false)]
                public bool? SpotInstanceRemedy { get; set; }

                /// <summary>
                /// <para>The price limit configurations for spot instances.</para>
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
                    /// <para>The price limit for a single instance.</para>
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
                /// <para>The type of spot instance. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("spot_strategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable burst (performance burst) for the system cloud disk. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("system_disk_bursting_enabled")]
                [Validation(Required=false)]
                public bool? SystemDiskBurstingEnabled { get; set; }

                /// <summary>
                /// <para>The multiple disk types for the system cloud disk. When a higher-priority disk type is unavailable, the system automatically attempts the next-priority disk type to create the system cloud disk.</para>
                /// </summary>
                [NameInMap("system_disk_categories")]
                [Validation(Required=false)]
                public List<string> SystemDiskCategories { get; set; }

                /// <summary>
                /// <para>The type of the system cloud disk. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("system_disk_category")]
                [Validation(Required=false)]
                public string SystemDiskCategory { get; set; }

                /// <summary>
                /// <para>The encryption algorithm used by the system cloud disk. Valid values: aes-256.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aes-256</para>
                /// </summary>
                [NameInMap("system_disk_encrypt_algorithm")]
                [Validation(Required=false)]
                public string SystemDiskEncryptAlgorithm { get; set; }

                /// <summary>
                /// <para>Specifies whether to encrypt the system cloud disk. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("system_disk_encrypted")]
                [Validation(Required=false)]
                public bool? SystemDiskEncrypted { get; set; }

                /// <summary>
                /// <para>The KMS key ID used by the system cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("system_disk_kms_key_id")]
                [Validation(Required=false)]
                public string SystemDiskKmsKeyId { get; set; }

                /// <summary>
                /// <para>The performance level of the system cloud disk. This parameter takes effect only for ESSD cloud disks. The performance level varies based on the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("system_disk_performance_level")]
                [Validation(Required=false)]
                public string SystemDiskPerformanceLevel { get; set; }

                /// <summary>
                /// <para>The provisioned read/write IOPS of the system cloud disk. This parameter is configured when the disk type is cloud_auto.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("system_disk_provisioned_iops")]
                [Validation(Required=false)]
                public long? SystemDiskProvisionedIops { get; set; }

                /// <summary>
                /// <para>The size of the system cloud disk, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("system_disk_size")]
                [Validation(Required=false)]
                public long? SystemDiskSize { get; set; }

                /// <summary>
                /// <para>The snapshot policy for the system cloud disk.</para>
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
                /// <para>The node pool status. Valid values:</para>
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
