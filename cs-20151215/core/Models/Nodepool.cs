// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class Nodepool : Darabonba.Model {
        /// <summary>
        /// <para>The auto-scaling node pool configuration.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public NodepoolAutoScaling AutoScaling { get; set; }
        public class NodepoolAutoScaling : Darabonba.Model {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The peak bandwidth of the EIP. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            [Obsolete]
            public long? EipBandwidth { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The billing method of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>: Pay-by-bandwidth.</description></item>
            /// <item><description><c>PayByTraffic</c>: Pay-by-data-transfer.</description></item>
            /// </list>
            /// <para>Default value: PayByBandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            [Obsolete]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto scaling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables auto scaling for the node pool.</description></item>
            /// <item><description><c>false</c>: Disables auto scaling. If this parameter is set to false, other configuration parameters in auto_scaling do not take effect.</description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>Specifies whether to associate an elastic IP address (EIP). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Associates an EIP.</description></item>
            /// <item><description><c>false</c>: Does not associate an EIP.</description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// <para>The maximum number of instances in the auto-scaling group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of instances in the auto-scaling group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// <para>The auto-scaling type, which is classified by the instance type used for auto scaling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cpu</c>: Regular instance.</description></item>
            /// <item><description><c>gpu</c>: GPU-accelerated instance.</description></item>
            /// <item><description><c>gpushare</c>: GPU-shared instance.</description></item>
            /// <item><description><c>spot</c>: Spot instance.</description></item>
            /// </list>
            /// <para>Default value: <c>cpu</c>.</para>
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
        /// <para><b>[Deprecated]</b> Use <c>desired_size</c> instead.</para>
        /// <para>The number of nodes in the node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Count { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// <para>The configuration of the edge node pool.</para>
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        [Obsolete]
        public NodepoolInterconnectConfig InterconnectConfig { get; set; }
        public class NodepoolInterconnectConfig : Darabonba.Model {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The network bandwidth of the enhanced edge node pool. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            [Obsolete]
            public long? Bandwidth { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The instance ID of the Cloud Connect Network (CCN) attached to the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccn-qm5i0i0q9yi*******</para>
            /// </summary>
            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string CcnId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The region of the CCN instance that is bound to the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string CcnRegionId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The instance ID of the Cloud Enterprise Network (CEN) attached to the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-ey9k9nfhz0f*******</para>
            /// </summary>
            [NameInMap("cen_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string CenId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// <para>The subscription duration of the enhanced edge node pool. Unit: months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("improved_period")]
            [Validation(Required=false)]
            [Obsolete]
            public string ImprovedPeriod { get; set; }

        }

        /// <summary>
        /// <para>The network type of the edge node pool. This parameter is valid only for node pools whose <c>type</c> is <c>edge</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>basic</c>: Basic.</description></item>
        /// <item><description><c>private</c>: Dedicated. Supported in Kubernetes 1.22 and later.</description></item>
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
        public NodepoolKubernetesConfig KubernetesConfig { get; set; }
        public class NodepoolKubernetesConfig : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to install the CloudMonitor agent on ECS nodes. After installation, you can view the monitoring information of the created ECS instances in the CloudMonitor console. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Installs the CloudMonitor agent on ECS nodes.</description></item>
            /// <item><description><c>false</c>: Does not install the CloudMonitor agent on ECS nodes.</description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
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
            /// <item><description><c>static</c>: Allows you to enhance CPU affinity and exclusivity for pods with specific resource characteristics on the node.</description></item>
            /// <item><description><c>none</c>: Enables the existing default CPU affinity scheme.</description></item>
            /// </list>
            /// <para>Default value: <c>none</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("cpu_policy")]
            [Validation(Required=false)]
            public string CpuPolicy { get; set; }

            /// <summary>
            /// <para>The node labels. You can add labels to the nodes in the Kubernetes cluster.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>The node name consists of three parts: prefix + node IP address + suffix.</para>
            /// <list type="bullet">
            /// <item><description>The prefix and suffix can each consist of one or more parts separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). The node name must start and end with a lowercase letter or a digit.</description></item>
            /// <item><description>The node IP address is the complete private IP address of the node.</description></item>
            /// </list>
            /// <para>The parameter value contains four parts separated by commas. For example, if the parameter is set to &quot;customized,aliyun,ip,com&quot; (where &quot;customized&quot; and &quot;ip&quot; are fixed strings, &quot;aliyun&quot; is the prefix, and &quot;com&quot; is the suffix), the node name is aliyun.192.168.xxx.xxx.com.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customized,aliyun,ip,com</para>
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// <para>The container runtime. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>containerd</c>: Recommended. Supported by all cluster versions.</description></item>
            /// <item><description><c>Sandboxed-Container.runv</c>: Sandboxed container. Provides higher isolation. Supported by clusters of version 1.24 and earlier.</description></item>
            /// <item><description><c>docker</c>: Supported by clusters of version 1.22 and earlier.</description></item>
            /// </list>
            /// <para>Default value: <c>containerd</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>The container runtime version.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.6.20</para>
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
            /// <para>The user data of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MXM=</para>
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
        public NodepoolManagement Management { get; set; }
        public class NodepoolManagement : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to enable Elastic Compute Service (ECS) fault detection for node self-healing.</para>
            /// </summary>
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-repair. This parameter takes effect only when <c>enable</c> is set to <c>true</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables auto-repair.</description></item>
            /// <item><description><c>false</c>: Disables auto-repair.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// <para>The auto-repair policy for nodes.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public NodepoolManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class NodepoolManagementAutoRepairPolicy : Darabonba.Model {
                /// <summary>
                /// <para>The maximum number of parallel repairs. When a large number of abnormal nodes exist in the node pool, this parameter specifies the maximum number or percentage of nodes that can be repaired simultaneously. You can specify a number (for example, 5, valid values: 1 to 100000) or a percentage (for example, 10%, valid values: 1% to 100%). Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("max_parallel_repairing_nodes")]
                [Validation(Required=false)]
                public string MaxParallelRepairingNodes { get; set; }

                /// <summary>
                /// <para>The self-healing circuit breaker threshold. When the number or percentage of failed nodes exceeds this threshold, self-healing enters the circuit breaker state and stops initiating new self-healing repair actions. You can specify a number (for example, 10, valid values: 1 to 100000) or a percentage (for example, 20%, valid values: 1% to 100%). Default value: 100%.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20%</para>
                /// </summary>
                [NameInMap("max_unhealthy_nodes_threshold")]
                [Validation(Required=false)]
                public string MaxUnhealthyNodesThreshold { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restarts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable auto-upgrade.</para>
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
            public NodepoolManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class NodepoolManagementAutoUpgradePolicy : Darabonba.Model {
                /// <summary>
                /// <para>Specifies whether to allow automatic kubelet upgrades.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically repair Common Vulnerabilities and Exposures (CVE).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_vul_fix")]
            [Validation(Required=false)]
            public bool? AutoVulFix { get; set; }

            /// <summary>
            /// <para>The policy for automatic CVE repair.</para>
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public NodepoolManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class NodepoolManagementAutoVulFixPolicy : Darabonba.Model {
                /// <summary>
                /// <para>Specifies whether to allow node restarts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// <para>The vulnerability levels that are allowed for automatic repair, separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asap,nntf</para>
                /// </summary>
                [NameInMap("vul_level")]
                [Validation(Required=false)]
                public string VulLevel { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable node rotation. This feature is supported only by intelligent managed node pools and is enabled by default. Common node pools do not support this feature.</para>
            /// </summary>
            [NameInMap("drift_enabled")]
            [Validation(Required=false)]
            public bool? DriftEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the managed node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables the managed node pool.</description></item>
            /// <item><description><c>false</c>: Disables the managed node pool. Other related configurations take effect only when <c>enable</c> is set to <c>true</c>.</description></item>
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
            /// <para>The auto-upgrade configuration. This parameter takes effect only when <c>enable</c> is set to <c>true</c>.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public NodepoolManagementUpgradeConfig UpgradeConfig { get; set; }
            public class NodepoolManagementUpgradeConfig : Darabonba.Model {
                /// <summary>
                /// <para>Specifies whether to enable auto-upgrade. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Enables auto-upgrade.</description></item>
                /// <item><description><c>false</c>: Disables auto-upgrade.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// <para>The maximum number of unavailable nodes. Valid values: 1 to 1000.</para>
                /// <para>Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// <para>The number of extra nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>The percentage of extra nodes. This parameter and <c>surge</c> are mutually exclusive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("surge_percentage")]
                [Validation(Required=false)]
                public long? SurgePercentage { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of nodes that the edge node pool can accommodate. The value must be greater than or equal to 0. A value of 0 indicates no additional limit, meaning the node pool is only limited by the maximum number of nodes that the entire cluster can accommodate. For edge node pools, this value is usually greater than 0. For Auto Scaling (ESS) node pools and default edge node pools, this value is 0.</para>
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
        public List<NodepoolNodeComponents> NodeComponents { get; set; }
        public class NodepoolNodeComponents : Darabonba.Model {
            /// <summary>
            /// <para>The node component configuration.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public NodepoolNodeComponentsConfig Config { get; set; }
            public class NodepoolNodeComponentsConfig : Darabonba.Model {
                /// <summary>
                /// <para>The custom node component configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cpuManagerPolicy&quot;:&quot;static&quot;}</para>
                /// </summary>
                [NameInMap("custom_config")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomConfig { get; set; }

                /// <summary>
                /// <para>The node component environment variables.</para>
                /// </summary>
                [NameInMap("envs")]
                [Validation(Required=false)]
                public List<NodepoolNodeComponentsConfigEnvs> Envs { get; set; }
                public class NodepoolNodeComponentsConfigEnvs : Darabonba.Model {
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
        public NodepoolNodeConfig NodeConfig { get; set; }
        public class NodepoolNodeConfig : Darabonba.Model {
            /// <summary>
            /// <para>The Kubelet parameter settings.</para>
            /// </summary>
            [NameInMap("kubelet_configuration")]
            [Validation(Required=false)]
            public KubeletConfig KubeletConfiguration { get; set; }

        }

        /// <summary>
        /// <para>The node pool configuration.</para>
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public NodepoolNodepoolInfo NodepoolInfo { get; set; }
        public class NodepoolNodepoolInfo : Darabonba.Model {
            /// <summary>
            /// <para>The name of the node pool.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the node pool belongs.</para>
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
            /// <item><description><c>ess</c>: Node pool.</description></item>
            /// <item><description><c>edge</c>: Edge node pool.</description></item>
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
        public NodepoolScalingGroup ScalingGroup { get; set; }
        public class NodepoolScalingGroup : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for the node pool. This parameter takes effect only when instance_charge_type is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables auto-renewal.</description></item>
            /// <item><description><c>false</c>: Disables auto-renewal.</description></item>
            /// </list>
            /// <para>Default value: <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal epoch for the node pool. This parameter takes effect and is required only when instance_charge_type is set to <c>PrePaid</c>.</para>
            /// <para>When PeriodUnit is set to <c>Month</c>, valid values are 1, 2, 3, 6, and 12.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow the system to automatically try to create pay-as-you-go instances to meet the required number of ECS instances when multi_az_policy is set to COST_OPTIMIZED and sufficient spot instances cannot be created due to price, inventory, or other reasons. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Allows the system to automatically try to create pay-as-you-go instances to meet the required number of ECS instances.</description></item>
            /// <item><description>false: Does not allow the system to automatically try to create pay-as-you-go instances to meet the required number of ECS instances.</description></item>
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
            public NodepoolScalingGroupCpuOptions CpuOptions { get; set; }
            public class NodepoolScalingGroupCpuOptions : Darabonba.Model {
                /// <summary>
                /// <para>Specifies whether to enable nested virtualization. Valid values:
                /// disabled: Disables nested virtualization.
                /// enabled: Enables nested virtualization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("nested_virtualization")]
                [Validation(Required=false)]
                public string NestedVirtualization { get; set; }

            }

            /// <summary>
            /// <para>The data cloud disk configuration for the nodes in the node pool.</para>
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// <para>The ID of the deployment set.</para>
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
            /// <para>The ID of the custom image. By default, the system-provided image is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_2_1903_x64_20G_alibase_20200904.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The operating system image type. Specify either this parameter or the platform parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AliyunLinux: Alinux2 image.</description></item>
            /// <item><description>AliyunLinux3: Alinux3 image.</description></item>
            /// <item><description>AliyunLinux3Arm64: Alinux3 ARM image.</description></item>
            /// <item><description>AliyunLinuxUEFI: Alinux2 UEFI image.</description></item>
            /// <item><description>CentOS: CentOS image.</description></item>
            /// <item><description>Windows: Windows image.</description></item>
            /// <item><description>WindowsCore: Windows Core image.</description></item>
            /// <item><description>ContainerOS: Container-optimized image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux</para>
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The billing method of the nodes in the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PrePaid</c>: Subscription.</description></item>
            /// <item><description><c>PostPaid</c>: Pay-as-you-go.</description></item>
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
            /// <para>The metadata access configuration for the ECS instance.
            /// This parameter is available only to users in the whitelist. To use this parameter, submit a ticket.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>The instance attributes.</para>
            /// </summary>
            [NameInMap("instance_patterns")]
            [Validation(Required=false)]
            public List<InstancePatterns> InstancePatterns { get; set; }

            /// <summary>
            /// <para>The instance types.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The billing method for public IP addresses. Valid values:</para>
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
            /// <para>The maximum outbound bandwidth for the public IP address of the node. Unit: Mbit/s. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>The name of the key pair. You must specify this parameter or login_password.</para>
            /// <remarks>
            /// <para>If you create a managed node pool, only key_pair is supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>np-key</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>Specifies whether to log on to the created ECS instances as a non-root user.</para>
            /// </summary>
            [NameInMap("login_as_non_root")]
            [Validation(Required=false)]
            public bool? LoginAsNonRoot { get; set; }

            /// <summary>
            /// <para>The SSH logon password. You must specify this parameter or key_pair. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello1234</para>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The multi-zone scaling policy for ECS instances in the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PRIORITY: Scales based on the vSwitches (VSwitchIds.N) you define. If an ECS instance cannot be created in the zone of a higher-priority vSwitch, the system automatically uses the next-priority vSwitch to create the ECS instance.</para>
            /// </description></item>
            /// <item><description><para>COST_OPTIMIZED: Tries to create instances in ascending order of vCPU unit price. If the scaling configuration specifies the spot billing method for multiple instance types, the system preferentially creates spot instances. You can use the CompensateWithOnDemand parameter to specify whether to automatically try to create pay-as-you-go instances when spot instances cannot be created due to insufficient inventory or other reasons.</para>
            /// <remarks>
            /// <para>COST_OPTIMIZED takes effect only when the scaling configuration specifies multiple instance types or uses spot instances.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para>BALANCE: Evenly allocates ECS instances across the zones specified in the scaling group. If the instances are unevenly distributed across zones due to insufficient inventory or other reasons, you can call the RebalanceInstances API operation to balance the resources. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a>.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: PRIORITY.</para>
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
            /// <para>The percentage of pay-as-you-go instances among the excess instances after the scaling group meets the minimum number of pay-as-you-go instances (on_demand_base_capacity). Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The subscription duration for the nodes in the node pool. This parameter takes effect and is required only when instance_charge_type is set to <c>PrePaid</c>. When period_unit is set to <c>Month</c>, valid values are 1, 2, 3, 6, and 12.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The subscription period unit for the nodes in the node pool. This parameter is required when instance_charge_type is set to <c>PrePaid</c>.</para>
            /// <para><c>Month</c>: Currently, only month is supported.</para>
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
            /// <para>AliyunLinux</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            [Obsolete]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The private pool options.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public NodepoolScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class NodepoolScalingGroupPrivatePoolOptions : Darabonba.Model {
                /// <summary>
                /// <para>The ID of the private pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The match criteria for the private pool. This parameter specifies the private pool capacity option for instance startup. After an elasticity assurance or capacity reservation takes effect, a private pool is generated for you to select when you start an instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Open: Open mode. The system automatically matches an open private pool. If no eligible private pool is available, the system uses the public pool to start the instance.</para>
                /// </description></item>
                /// <item><description><para>Target: Target mode. The system uses the specified private pool to start the instance. If the specified private pool is unavailable, the instance fails to start.</para>
                /// </description></item>
                /// <item><description><para>None: None mode. The system does not use a private pool to start the instance.</para>
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
            /// <para>The name of the worker RAM role.</para>
            /// <remarks>
            /// <para>Notice: This parameter is supported only when you create a node pool in an ACK managed cluster of Kubernetes 1.22 or later.</notice></para>
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
            /// <para>The resource pool and resource pool strategy for instance creation. When you configure this parameter, note the following items:
            /// This parameter takes effect only when you create pay-as-you-go instances.
            /// This parameter cannot be configured at the same time as private_pool_options.match_criteria and private_pool_options.id.</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public NodepoolScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class NodepoolScalingGroupResourcePoolOptions : Darabonba.Model {
                /// <summary>
                /// <para>The list of private pool IDs, which are the IDs of elasticity assurances or capacity reservations. You can specify only the IDs of private pools in Target mode. Valid values of N: 1 to 20.</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>The resource pool strategy for instance creation. Resource pools include private pools generated after an elasticity assurance or capacity reservation takes effect, as well as the public pool. You can select a resource pool when you start an instance. Valid values:
                /// PrivatePoolFirst: Uses the private pool first. If you select this strategy and specify resource_pool_options.private_pool_ids, the system preferentially uses the specified private pools. If no private pool is specified or the specified private pools have insufficient capacity, the system automatically matches an open private pool. If no eligible private pool is available, the system uses the public pool to create the instance.
                /// PrivatePoolOnly: Uses only the private pool. If you select this strategy, you must specify resource_pool_options.private_pool_ids. If the specified private pools have insufficient capacity, the instance fails to start.
                /// None: Does not use a resource pool strategy.
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
            /// <item><description>release: Standard mode. Scales by creating and releasing ECS instances based on the requested resource usage.</description></item>
            /// <item><description>recycle: Swift mode. Scales by creating, stopping, and starting instances to improve scaling speed. When an instance is stopped, you are not charged for compute resources, but you are still charged for storage resources, except for instances with local disks.</description></item>
            /// </list>
            /// <para>Default value: release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>release</para>
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// <para>The ID of the security group for the node pool. Specify either this parameter or security_group_ids. The security_group_ids parameter is recommended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2zeihch86ooz9io4****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The list of security group IDs. Specify either this parameter or security_group_id. The security_group_ids parameter is recommended. If both security_group_id and security_group_ids are specified, security_group_ids takes precedence.</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The number of available instance types. The scaling group evenly creates spot instances based on the most cost-effective instance types. Valid values: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable spot instance replenishment. After this feature is enabled, when the scaling group receives a system message that a spot instance will be reclaimed, the scaling group tries to create a new instance to replace the spot instance to be reclaimed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enables spot instance replenishment.</description></item>
            /// <item><description>false: Disables spot instance replenishment.</description></item>
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
            public List<NodepoolScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class NodepoolScalingGroupSpotPriceLimit : Darabonba.Model {
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
                /// <para>The maximum price for a single instance.</para>
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
            /// <item><description>NoSpot: Pay-as-you-go instance.</description></item>
            /// <item><description>SpotWithPriceLimit: Sets the maximum price for spot instances.</description></item>
            /// <item><description>SpotAsPriceGo: The system automatically bids based on the current market price.</description></item>
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
            /// <para>Specifies whether to enable burst for the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enables burst.</description></item>
            /// <item><description>false: Disables burst.</description></item>
            /// </list>
            /// <para>This parameter is supported only when SystemDiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The multiple system cloud disk types. If a high-priority disk type is unavailable, the system automatically tries the next priority disk type to create the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic disk.</description></item>
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The system cloud disk type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
            /// </list>
            /// <para>Default value: cloud_efficiency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The encryption algorithm used for the system cloud disk. Valid value: aes-256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes-256</para>
            /// </summary>
            [NameInMap("system_disk_encrypt_algorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Encrypts the system cloud disk.</description></item>
            /// <item><description>false: Does not encrypt the system cloud disk.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("system_disk_encrypted")]
            [Validation(Required=false)]
            public bool? SystemDiskEncrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key used for the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("system_disk_kms_key_id")]
            [Validation(Required=false)]
            public string SystemDiskKmsKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the system cloud disk. This parameter takes effect only for ESSDs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: Delivers medium concurrent I/O performance and relatively stable read/write latency.</description></item>
            /// <item><description>PL1: Delivers medium concurrent I/O performance and relatively stable read/write latency.</description></item>
            /// <item><description>PL2: Delivers high concurrent I/O performance and stable read/write latency.</description></item>
            /// <item><description>PL3: Delivers ultra-high concurrent I/O performance and highly stable read/write latency.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS for the system cloud disk. Valid values: 0 to min{50,000, 1000 × Capacity - Baseline performance}. Baseline performance = min{1,800 + 50 × Capacity, 50,000}.</para>
            /// <para>This parameter is supported only when SystemDiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GiB.</para>
            /// <para>Valid values: 40 to 500.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>Adds tags only to ECS instances.</para>
            /// <para>Tag keys must be unique and can be up to 128 characters in length. Neither tag keys nor tag values can start with &quot;aliyun&quot; or &quot;acs:&quot;, or contain &quot;https://&quot; or &quot;http://&quot;.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<NodepoolScalingGroupTags> Tags { get; set; }
            public class NodepoolScalingGroupTags : Darabonba.Model {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The vSwitch IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The confidential computing node pool configuration.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public NodepoolTeeConfig TeeConfig { get; set; }
        public class NodepoolTeeConfig : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether the node pool is a confidential computing node pool.</para>
            /// <para>This parameter is required.</para>
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

