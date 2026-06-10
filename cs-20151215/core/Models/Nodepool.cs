// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class Nodepool : TeaModel {
        /// <summary>
        /// <para>The auto scaling configurations for the node pool.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public NodepoolAutoScaling AutoScaling { get; set; }
        public class NodepoolAutoScaling : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>[This parameter is deprecated.]</para>
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
            /// <para>[This parameter is deprecated.]</para>
            /// <para>The billing method for the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PayByBandwidth</c>: Pay-by-bandwidth.</para>
            /// </description></item>
            /// <item><description><para><c>PayByTraffic</c>: Pay-by-traffic.</para>
            /// </description></item>
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
            /// <para>Whether to enable auto scaling.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enables auto scaling for the node pool.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables auto scaling. If you set this parameter to <c>false</c>, other parameters in the <c>auto_scaling</c> object do not take effect.</para>
            /// </description></item>
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
            /// <para>[This parameter is deprecated.]</para>
            /// <para>Whether to associate an EIP with each node in the pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: associates an EIP.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: does not associate an EIP.</para>
            /// </description></item>
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
            /// <para>The maximum number of instances in the auto scaling group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of instances in the auto scaling group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// <para>The type of instances to which auto scaling applies. This determines the scaling behavior. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cpu</c>: Regular instances.</para>
            /// </description></item>
            /// <item><description><para><c>gpu</c>: GPU-accelerated instances.</para>
            /// </description></item>
            /// <item><description><para><c>gpushare</c>: Shared GPU-accelerated instances.</para>
            /// </description></item>
            /// <item><description><para><c>spot</c>: Spot instances.</para>
            /// </description></item>
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
        /// <para>[This parameter is deprecated. Use desired_size instead.]</para>
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
        /// <para>[This parameter is deprecated.]</para>
        /// <para>The configurations of the edge node pool.</para>
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        [Obsolete]
        public NodepoolInterconnectConfig InterconnectConfig { get; set; }
        public class NodepoolInterconnectConfig : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>【该字段已废弃】</para>
            /// <para>边缘增强型节点池的网络带宽，单位：Mbps。</para>
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
            /// <para>【该字段已废弃】</para>
            /// <para>边缘增强型节点池绑定的云连接网实例 ID(CCNID)。</para>
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
            /// <para>【该字段已废弃】</para>
            /// <para>边缘增强型节点池绑定的云连接网实例所属的地域。</para>
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
            /// <para>[This parameter is deprecated.]</para>
            /// <para>The ID of the Cloud Enterprise Network (C</para>
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
            /// <para>【该字段已废弃】</para>
            /// <para>边缘增强型节点池的购买时长，单位：月。</para>
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
        /// <para>The network mode of the edge node pool. This parameter is valid only for edge node pools. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>basic</c>: basic mode.</para>
        /// </description></item>
        /// <item><description><para><c>private</c>: dedicated mode. This mode is supported in clusters of Kubernetes 1.22 and later.</para>
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
        /// <para>The Kubernetes configurations for the nodes.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public NodepoolKubernetesConfig KubernetesConfig { get; set; }
        public class NodepoolKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>Whether to install CloudMonitor on the nodes. After installation, you can view monitoring information about the instances in the CloudMonitor console. We recommend that you enable this feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: installs CloudMonitor on nodes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: does not install CloudMonitor on nodes.</para>
            /// </description></item>
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
            /// <para>The CPU management policy of the nodes. This parameter is available only for clusters of Kubernetes 1.12.6 and later. The following policies are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><c>static</c>: allows pods with specific resource characteristics to be granted with enhanced CPU affinity and exclusivity on the node.</para>
            /// </description></item>
            /// <item><description><para><c>none</c>: indicates that the default CPU affinity is used.</para>
            /// </description></item>
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
            /// <para>The labels to add to the nodes in the node pool.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>The naming convention of the node. A node name consists of a prefix, an IP address, and a suffix.</para>
            /// <list type="bullet">
            /// <item><description><para>The prefix and suffix can consist of one or more parts that are separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). A node name must start and end with a lowercase letter or a digit.</para>
            /// </description></item>
            /// <item><description><para>The node IP address is the complete private IP address of the node.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter consists of four comma-separated parts. For example, if you set the parameter to <c>customized,aliyun,ip,com</c>, where <c>customized</c> and <c>ip</c> are fixed strings, <c>aliyun</c> is the prefix, and <c>com</c> is the suffix, the node name is in the format of <c>aliyun.192.168.xxx.xxx.com</c>.</para>
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
            /// <item><description><para><c>containerd</c>: Recommended. This runtime is supported in all cluster versions.</para>
            /// </description></item>
            /// <item><description><para><c>Sandboxed-Container.runv</c>: a sandboxed container that provides higher isolation. This runtime is supported in clusters of Kubernetes 1.24 and earlier.</para>
            /// </description></item>
            /// <item><description><para><c>docker</c>: This runtime is supported in clusters of Kubernetes 1.22 and earlier.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>containerd</c></para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>The version of the container runtime.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.6.20</para>
            /// </summary>
            [NameInMap("runtime_version")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }

            /// <summary>
            /// <para>The taints.</para>
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
        /// <para>The configurations of the managed node pool.</para>
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public NodepoolManagement Management { get; set; }
        public class NodepoolManagement : TeaModel {
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto repair. This parameter takes effect only if <c>enable</c> is set to <c>true</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c></para>
            /// </description></item>
            /// <item><description><para><c>false</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// <para>The auto repair policy for nodes.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public NodepoolManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class NodepoolManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow the node to be restarted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable auto upgrade.</para>
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
            public NodepoolManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class NodepoolManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow the kubelet to be automatically upgraded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically fix CVEs.</para>
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
            public NodepoolManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class NodepoolManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow the node to be restarted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// <para>The CVE vulnerability levels to automatically fix. You can specify multiple levels separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asap,nntf</para>
                /// </summary>
                [NameInMap("vul_level")]
                [Validation(Required=false)]
                public string VulLevel { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the managed node pool feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c></para>
            /// </description></item>
            /// <item><description><para><c>false</c>: If you set this parameter to false, the other parameters in the <c>management</c> object are ignored.</para>
            /// </description></item>
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
            /// <para>The auto upgrade configurations. This parameter takes effect only when <c>enable</c> is set to <c>true</c>.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public NodepoolManagementUpgradeConfig UpgradeConfig { get; set; }
            public class NodepoolManagementUpgradeConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable auto upgrade. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c></para>
                /// </description></item>
                /// <item><description><para><c>false</c></para>
                /// </description></item>
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
                /// <para>The percentage of extra nodes. You must specify this parameter or <c>surge</c>.</para>
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
        /// <para>边缘节点池允许容纳的最大节点数量，该参数大于等于 0。0 表示无额外限制（仅受限于集群整体可以容纳的节点数，节点池本身无额外限制）。边缘节点池该参数值往往大于 0；ess 类型节点池和默认的 edge 类型节点池该参数值为 0。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        public long? MaxNodes { get; set; }

        /// <summary>
        /// <para>节点组件列表。</para>
        /// </summary>
        [NameInMap("node_components")]
        [Validation(Required=false)]
        public List<NodepoolNodeComponents> NodeComponents { get; set; }
        public class NodepoolNodeComponents : TeaModel {
            /// <summary>
            /// <para>节点组件配置。</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public NodepoolNodeComponentsConfig Config { get; set; }
            public class NodepoolNodeComponentsConfig : TeaModel {
                /// <summary>
                /// <para>节点组件自定义配置。</para>
                /// </summary>
                [NameInMap("custom_config")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomConfig { get; set; }

            }

            /// <summary>
            /// <para>节点组件名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubelet</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>节点组件版本</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.33.3-aliyun.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>节点配置。</para>
        /// </summary>
        [NameInMap("node_config")]
        [Validation(Required=false)]
        public NodepoolNodeConfig NodeConfig { get; set; }
        public class NodepoolNodeConfig : TeaModel {
            /// <summary>
            /// <para>Kubelet 参数配置。</para>
            /// </summary>
            [NameInMap("kubelet_configuration")]
            [Validation(Required=false)]
            public KubeletConfig KubeletConfiguration { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the node pool.</para>
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public NodepoolNodepoolInfo NodepoolInfo { get; set; }
        public class NodepoolNodepoolInfo : TeaModel {
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
            /// <item><description><para><c>ess</c>: a regular node pool.</para>
            /// </description></item>
            /// <item><description><para><c>edge</c>: an edge node pool.</para>
            /// </description></item>
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
        /// <para>The configurations of the scaling group.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public NodepoolScalingGroup ScalingGroup { get; set; }
        public class NodepoolScalingGroup : TeaModel {
            /// <summary>
            /// <para>Whether to enable auto-renewal for the nodes in the node pool. This parameter takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enables auto-renewal.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disables auto-renewal.</para>
            /// </description></item>
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
            /// <para>The auto-renewal period for the nodes. This parameter is required and takes effect only if <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para>If <c>PeriodUnit</c> is set to <c>Month</c>, the valid values are 1, 2, 3, 6, and 12.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the required number of ECS instances when <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c> and preemptible instances cannot be created due to price or inventory constraints. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c></para>
            /// </description></item>
            /// <item><description><para><c>false</c></para>
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
            /// <para>The configurations of the data disks that are attached to the nodes in the node pool.</para>
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
            /// <para>The configurations of block devices.</para>
            /// </summary>
            [NameInMap("disk_init")]
            [Validation(Required=false)]
            public List<DiskInit> DiskInit { get; set; }

            /// <summary>
            /// <para>The ID of the custom image. If you do not set this parameter, the default system image is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_2_1903_x64_20G_alibase_20200904.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The type of the OS image. You must specify this parameter or <c>platform</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>AliyunLinux</c>: Alinux 2 image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3</c>: Alinux 3 image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3Arm64</c>: Alinux 3 image for ARM.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinuxUEFI</c>: Alinux 2 UEFI image.</para>
            /// </description></item>
            /// <item><description><para><c>CentOS</c>: CentOS image.</para>
            /// </description></item>
            /// <item><description><para><c>Windows</c>: Windows image.</para>
            /// </description></item>
            /// <item><description><para><c>WindowsCore</c>: Windows Core image.</para>
            /// </description></item>
            /// <item><description><para><c>ContainerOS</c>: Container-optimized image.</para>
            /// </description></item>
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
            /// <para>The configurations of metadata access for the ECS instances.
            /// This feature is available only to allowlisted users. To use this feature, submit a ticket.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>The instance types.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The billing method of the public IP address. Valid values:</para>
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
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The maximum outbound public bandwidth of a node. Unit: Mbit/s. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>The name of the key pair. You must specify this parameter or <c>login_password</c>.</para>
            /// <remarks>
            /// <para>If you create a managed node pool, you can specify only <c>key_pair</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>np-key</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>Specifies whether to use a non-root user to log on to the ECS instances that are created.</para>
            /// </summary>
            [NameInMap("login_as_non_root")]
            [Validation(Required=false)]
            public bool? LoginAsNonRoot { get; set; }

            /// <summary>
            /// <para>The password for SSH access. You must specify this parameter or <c>key_pair</c>. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello1234</para>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The scaling policy for the ECS instances in a scaling group that spans multiple zones. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PRIORITY</c>: The system scales instances based on the priority of the vSwitches specified in <c>vswitch_ids</c>. The system preferentially scales instances in the zone where the vSwitch with the highest priority resides. If the scaling fails, the system scales instances in the zone where the vSwitch with the next highest priority resides.</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>: The system scales instances based on the vCPU price from lowest to highest. The system preferentially scales instances that have the lowest vCPU price. If the scaling configuration includes multiple instance types and some of them are preemptible instance types, the system preferentially scales the preemptible instances. You can use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically create pay-as-you-go instances when preemptible instances cannot be created due to reasons such as stock-outs.</para>
            /// <remarks>
            /// <para>The <c>COST_OPTIMIZED</c> policy takes effect only when multiple instance types are specified or preemptible instances are selected in the scaling configuration.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>: The system evenly distributes ECS instances across the specified zones. If the distribution of instances becomes unbalanced due to stock-outs, you can call the <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a> operation to rebalance the resources.</para>
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
            /// <para>The minimum number of pay-as-you-go instances that must be provisioned in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than this value, the system preferentially creates pay-as-you-go instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of pay-as-you-go instances among the instances that exceed the minimum number specified by <c>on_demand_base_capacity</c>. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The subscription duration of the nodes in the node pool. This parameter is required and takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. If <c>period_unit</c> is set to <c>Month</c>, the valid values for <c>period</c> are 1, 2, 3, 6, and 12.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The billing cycle of the subscription nodes in the node pool. This parameter is required when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para><c>Month</c>: The billing cycle is measured in months.</para>
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
            /// <para>The configurations of the private node pool.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public NodepoolScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class NodepoolScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// <para>The ID of the private node pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The type of the private pool that is used to start instances. An elasticity assurance or a capacity reservation service generates a private pool after the service takes effect. You can select a private pool to start instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Open</c>: open mode. The system automatically matches an open private pool. If no matching private pool is found, the resources in the public pool are used.</para>
                /// </description></item>
                /// <item><description><para><c>Target</c>: targeted mode. The instance is started from the specified private pool. If the private pool is unavailable, the instance fails to be started.</para>
                /// </description></item>
                /// <item><description><para><c>None</c>: no mode. The instance is not started from a private pool.</para>
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
            /// <para>Notice: This parameter can be configured only when you create a node pool in an ACK managed cluster of Kubernetes 1.22 or later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>example-role</para>
            /// </summary>
            [NameInMap("ram_role_name")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>A list of ApsaraDB RDS instances.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>The resource pool and resource pool policy that are used to create instances. Note the following when you set this parameter:
            /// This parameter takes effect only when you create pay-as-you-go instances.
            /// You cannot specify this parameter together with <c>private_pool_options.match_criteria</c> or <c>private_pool_options.id</c>.</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public NodepoolScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class NodepoolScalingGroupResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>The list of private pool IDs. The IDs are the IDs of elasticity assurances or capacity reservations. This parameter accepts only IDs of private pools in targeted mode. You can specify up to 20 IDs.</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>The resource pool policy that is used to create instances. Resource pools include private pools generated by an elasticity assurance or a capacity reservation service and public pools. You can select a resource pool to start an instance. Valid values:
                /// PrivatePoolFirst: The system prioritizes the use of private pools. If you specify <c>resource_pool_options.private_pool_ids</c>, the specified private pools are used first. If no private pool is specified or the capacity of the specified private pool is insufficient, the system automatically matches an open private pool. If no matching private pool is found, the resources in the public pool are used.
                /// PrivatePoolOnly: The instance can be created only from a private pool. You must specify <c>resource_pool_options.private_pool_ids</c>. If the capacity of the specified private pool is insufficient, the instance fails to be created.
                /// None: No resource pool policy is used.
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
            /// <para>The scaling mode of the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>release</c>: the standard mode. In this mode, resources are scaled by creating and releasing ECS instances based on the resource usage.</para>
            /// </description></item>
            /// <item><description><para><c>recycle</c>: the rapid mode. In this mode, resources are scaled by creating, stopping, and starting ECS instances. This speeds up the scaling of resources. When an instance is stopped, you are not charged for its computing resources but are charged for its storage resources. This does not apply to instances that have local disks.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>release</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>release</para>
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which you want to add the nodes. You must specify this parameter or <c>security_group_ids</c>. We recommend that you specify <c>security_group_ids</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2zeihch86ooz9io4****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>A list of security group IDs. You must specify this parameter or <c>security_group_id</c>. We recommend that you specify <c>security_group_ids</c>. If you specify both <c>security_group_id</c> and <c>security_group_ids</c>, <c>security_group_ids</c> takes precedence.</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The number of instance types. The scaling group creates preemptible instances of multiple instance types that have the lowest cost in a balanced manner. Valid values: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable replenishment for preemptible instances. If this feature is enabled, the scaling group attempts to create a new instance to replace a preemptible instance that is about to be reclaimed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c></para>
            /// </description></item>
            /// <item><description><para><c>false</c></para>
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
            /// <para>The price limits for specific spot instance types.</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<NodepoolScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class NodepoolScalingGroupSpotPriceLimit : TeaModel {
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
                /// <para>The maximum price of a single instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.39</para>
                /// </summary>
                [NameInMap("price_limit")]
                [Validation(Required=false)]
                public string PriceLimit { get; set; }

            }

            /// <summary>
            /// <para>The bidding policy for the pay-as-you-go instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NoSpot: normal pay-as-you-go instances.</para>
            /// </description></item>
            /// <item><description><para>SpotWithPriceLimit: spot instances with a user-defined maximum hourly price.</para>
            /// </description></item>
            /// <item><description><para>SpotAsPriceGo: spot instances for which the system automatically bids based on the current market price.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/157759.html">Preemptible instances</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the performance burst feature for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: enables the performance burst feature.</para>
            /// </description></item>
            /// <item><description><para>false: disables the performance burst feature.</para>
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
            /// <para>A prioritized list of system disk types. The system attempts to create a system disk of a disk type with a higher priority. If the disk type is unavailable, the system uses the next disk type to create the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud: basic disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: standard SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The type of the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cloud_efficiency</c>: ultra disk.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_ssd</c>: standard SSD.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_essd</c>: enhanced SSD (ESSD).</para>
            /// </description></item>
            /// <item><description><para><c>cloud_auto</c>: ESSD AutoPL disk.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_essd_entry</c>: ESSD Entry disk.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>cloud_efficiency</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The encryption algorithm that is used for the system disk. Set the value to aes-256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes-256</para>
            /// </summary>
            [NameInMap("system_disk_encrypt_algorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. Valid values: true and false.</para>
            /// </summary>
            [NameInMap("system_disk_encrypted")]
            [Validation(Required=false)]
            public bool? SystemDiskEncrypted { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key that is used to encrypt the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("system_disk_kms_key_id")]
            [Validation(Required=false)]
            public string SystemDiskKmsKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD that is used as the system disk. This parameter takes effect only for ESSDs.</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</para>
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
            /// <para>The provisioned read/write IOPS of the system disk. The valid values are 0 to min{50000, 1000 × Capacity - Base IOPS}. The default Base IOPS is min{1800 + 50 × Capacity, 50000}.</para>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB.</para>
            /// <para>Valid values: 40 to 500.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The tags to add to the ECS instances in the node pool.</para>
            /// <para>A tag key must be unique and can be up to 128 characters in length. A tag key and a tag value cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>https://</c> or <c>http://</c>.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<NodepoolScalingGroupTags> Tags { get; set; }
            public class NodepoolScalingGroupTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The IDs of the vSwitches to which the nodes can be added.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the confidential computing node pool.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public NodepoolTeeConfig TeeConfig { get; set; }
        public class NodepoolTeeConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to create a confidential computing node pool.</para>
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
