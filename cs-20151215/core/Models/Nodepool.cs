// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class Nodepool : TeaModel {
        /// <summary>
        /// <para>The auto-scaling configurations for the node pool.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public NodepoolAutoScaling AutoScaling { get; set; }
        public class NodepoolAutoScaling : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated.</para>
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
            /// <para>This parameter is deprecated.</para>
            /// <para>The billing method of the EIP. Valid values:</para>
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
            /// <para>Specifies whether to enable auto-scaling.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables auto-scaling for the node pool.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables auto-scaling. If you set this parameter to false, other parameters in the <c>auto_scaling</c> object do not take effect.</para>
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
            /// <para>This parameter is deprecated.</para>
            /// <para>Specifies whether to associate an EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Associates an EIP.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not associate an EIP.</para>
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
            /// <para>The maximum number of instances in the scaling group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of instances in the scaling group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// <para>The type of auto-scaling, which is determined by the instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cpu</c>: Standard instances.</para>
            /// </description></item>
            /// <item><description><para><c>gpu</c>: GPU-accelerated instances.</para>
            /// </description></item>
            /// <item><description><para><c>gpushare</c>: Shared GPU instances.</para>
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
        /// <para>This parameter is deprecated. Use desired_size instead.</para>
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
        /// <para>This parameter is deprecated.</para>
        /// <para>The edge node pool configurations.</para>
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        [Obsolete]
        public NodepoolInterconnectConfig InterconnectConfig { get; set; }
        public class NodepoolInterconnectConfig : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated.</para>
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
            /// <para>This parameter is deprecated.</para>
            /// <para>The CCN instance ID (CCNID) bound to the enhanced edge node pool.</para>
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
            /// <para>This parameter is deprecated.</para>
            /// <para>The region where the CCN instance bound to the enhanced edge node pool is located.</para>
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
            /// <para>This parameter is deprecated.</para>
            /// <para>The CEN instance ID (CENID) bound to the enhanced edge node pool.</para>
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
            /// <para>This parameter is deprecated.</para>
            /// <para>The subscription duration of the enhanced edge node pool. Unit: month.</para>
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
        /// <para>The network type of the edge node pool. This parameter is only meaningful for node pools of type <c>edge</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>basic</c>: Basic.</para>
        /// </description></item>
        /// <item><description><para><c>private</c>: Private. Supported in versions 1.22 and later.</para>
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
        /// <para>The cluster configurations.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public NodepoolKubernetesConfig KubernetesConfig { get; set; }
        public class NodepoolKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to install Cloud Monitor on ECS nodes. After installation, you can view monitoring information about the created ECS instances in the Cloud Monitor console. We recommend that you enable this feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Installs Cloud Monitor on ECS nodes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not install Cloud Monitor on ECS nodes.</para>
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
            /// <para>The CPU management policy for the node. The following policies are supported for clusters of Kubernetes v1.12.6 or later:</para>
            /// <list type="bullet">
            /// <item><description><para><c>static</c>: Allows pods with specific resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.</para>
            /// </description></item>
            /// <item><description><para><c>none</c>: Indicates that the existing default CPU affinity scheme is enabled.</para>
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
            /// <para>The node labels. Adds labels to the nodes of the Kubernetes cluster.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>The node name consists of three parts: a prefix, the node IP address, and a suffix.</para>
            /// <list type="bullet">
            /// <item><description><para>The prefix and suffix can each consist of one or more parts separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). The node name must start and end with a lowercase letter or a digit.</para>
            /// </description></item>
            /// <item><description><para>The node IP address is the complete private IP address of the node.</para>
            /// </description></item>
            /// </list>
            /// <para>The parameter consists of four parts separated by commas. For example, if you pass the string &quot;customized,aliyun,ip,com&quot;, the node name is aliyun.192.168.xxx.xxx.com. In this example, &quot;customized&quot; and &quot;ip&quot; are fixed strings, &quot;aliyun&quot; is the prefix, and &quot;com&quot; is the suffix.</para>
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
            /// <item><description><para><c>containerd</c>: Recommended. This option is supported for all cluster versions.</para>
            /// </description></item>
            /// <item><description><para><c>Sandboxed-Container.runv</c>: A sandboxed container that provides higher isolation. This option is supported for clusters of Kubernetes v1.24 or earlier.</para>
            /// </description></item>
            /// <item><description><para><c>docker</c>: This option is supported for clusters of Kubernetes v1.22 or earlier.</para>
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
            /// <para>The taint configurations.</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>The custom data of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MXM=</para>
            /// </summary>
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The managed node pool configurations.</para>
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public NodepoolManagement Management { get; set; }
        public class NodepoolManagement : TeaModel {
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>Auto repair. This takes effect only when <c>enable=true</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables auto repair.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables auto repair.</para>
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
            /// <para>The auto-repair policy for nodes.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public NodepoolManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class NodepoolManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow restarting nodes.</para>
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
            public class NodepoolManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow auto-upgrading the kubelet.</para>
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
            /// <para>The auto-fix policy for CVEs.</para>
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public NodepoolManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class NodepoolManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow restarting nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// <para>The vulnerability levels that are allowed to be automatically fixed, separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asap,nntf</para>
                /// </summary>
                [NameInMap("vul_level")]
                [Validation(Required=false)]
                public string VulLevel { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the managed node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables the managed node pool.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables the managed node pool. Other related configurations take effect only when <c>enable=true</c>.</para>
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
            /// <para>The auto-upgrade configurations. This takes effect only when <c>enable=true</c>.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public NodepoolManagementUpgradeConfig UpgradeConfig { get; set; }
            public class NodepoolManagementUpgradeConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable auto-upgrade. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enables auto-upgrade.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disables auto-upgrade.</para>
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
                /// <para>The maximum number of unavailable nodes. Value range: [1, 1000].</para>
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
        /// <para>The maximum number of nodes that the edge node pool can contain. This parameter must be greater than or equal to 0. A value of 0 indicates no extra limit (limited only by the total number of nodes the cluster can accommodate, with no additional limit on the node pool itself). The value of this parameter for an edge node pool is often greater than 0. For ess type node pools and default edge type node pools, this parameter is 0.</para>
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
        public class NodepoolNodeComponents : TeaModel {
            /// <summary>
            /// <para>The configuration of the node component.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public NodepoolNodeComponentsConfig Config { get; set; }
            public class NodepoolNodeComponentsConfig : TeaModel {
                /// <summary>
                /// <para>The custom configuration of the node component.</para>
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
        public NodepoolNodeConfig NodeConfig { get; set; }
        public class NodepoolNodeConfig : TeaModel {
            /// <summary>
            /// <para>The Kubelet parameter settings.</para>
            /// </summary>
            [NameInMap("kubelet_configuration")]
            [Validation(Required=false)]
            public KubeletConfig KubeletConfiguration { get; set; }

        }

        /// <summary>
        /// <para>The node pool configurations.</para>
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
            /// <item><description><para><c>ess</c>: A regular node pool.</para>
            /// </description></item>
            /// <item><description><para><c>edge</c>: An edge node pool.</para>
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
        /// <para>The configurations of the scaling group for the node pool.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public NodepoolScalingGroup ScalingGroup { get; set; }
        public class NodepoolScalingGroup : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for the node pool. This parameter takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables auto-renewal.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables auto-renewal.</para>
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
            /// <para>The auto-renewal period for the node pool. This parameter is required and takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para>If <c>PeriodUnit=Month</c>, valid values are 1, 2, 3, 6, and 12.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>When <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c>, specifies whether to automatically attempt to create on-demand instances to meet the required number of ECS instances if enough spot instances cannot be created due to price or inventory reasons. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Allows automatically attempting to create on-demand instances to meet the required number of ECS instances.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not allow automatically attempting to create on-demand instances to meet the required number of ECS instances.</para>
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
            /// <para>The data disk configurations for the nodes in the node pool.</para>
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
            /// <para>The block device initialization configurations.</para>
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
            /// <para>The type of OS image. You must specify this parameter or the platform parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>AliyunLinux</c>: Alinux2 image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3</c>: Alinux3 image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3Arm64</c>: Alinux3 image for ARM.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinuxUEFI</c>: Alinux2 image for UEFI.</para>
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
            /// <item><description><para><c>PrePaid</c>: Subscription.</para>
            /// </description></item>
            /// <item><description><para><c>PostPaid</c>: Pay-as-you-go.</para>
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
            /// <para>The metadata access configuration for the ECS instance.
            /// This feature is currently available only to whitelisted users. Submit a ticket to request access.</para>
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
            /// <para>The billing method for the public IP address. Valid values:</para>
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
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The maximum outbound bandwidth of the public IP address for the node. Unit: Mbit/s. Value range: [1, 100].</para>
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
            /// <para>If you create a managed node pool, you can only specify <c>key_pair</c>.</para>
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
            /// <para>The SSH logon password. You must specify this parameter or <c>key_pair</c>. The password must be 8 to 30 characters long and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello1234</para>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The scaling policy for ECS instances in a multi-zone scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PRIORITY</c>: Scales instances based on the virtual switches (VSwitchIds.N) you define. If an ECS instance cannot be created in the zone of the higher-priority virtual switch, the system automatically uses the next-priority virtual switch to create the instance.</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>: Attempts to create instances with the lowest vCPU unit price. When multiple instance types are specified for a spot instance in the scaling configuration, the system prioritizes creating the corresponding spot instance. You can use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically try creating on-demand instances if spot instances cannot be created due to inventory or other reasons.</para>
            /// <remarks>
            /// <para><c>COST_OPTIMIZED</c> takes effect only when multiple instance types are set in the scaling configuration or when spot instances are selected.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>: Evenly distributes ECS instances across the specified multiple zones in the scaling group. If the zones become unbalanced due to inventory shortages or other reasons, you can use the RebalanceInstances API to balance the resources. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a>.</para>
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
            /// <para>The minimum number of on-demand instances required by the scaling group. Value range: [0, 1000]. When the number of on-demand instances is less than this value, on-demand instances will be created first.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of on-demand instances among the instances that exceed the minimum on-demand instance count (<c>on_demand_base_capacity</c>). Value range: [0, 100].</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The subscription duration of the nodes in the node pool. This parameter is required and takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. If <c>period_unit</c> is set to Month, valid values for <c>period</c> are 1, 2, 3, 6, and 12.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The billing cycle of the nodes in the node pool. You must specify this parameter when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
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
            /// <para>The private node pool configurations.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public NodepoolScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class NodepoolScalingGroupPrivatePoolOptions : TeaModel {
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
                /// <para>The private node pool type, which is the capacity option for the private pool where the instance is launched. An elastic assurance service or capacity reservation service generates a private pool capacity for instance startup. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Open</c>: Open mode. Automatically matches open-type private pool capacity. If no eligible private pool capacity is available, it uses public pool resources to start.</para>
                /// </description></item>
                /// <item><description><para><c>Target</c>: Specified mode. Uses the specified private pool capacity to start the instance. If the private pool capacity is unavailable, the instance fails to start.</para>
                /// </description></item>
                /// <item><description><para><c>None</c>: No mode used. The instance will not use private pool capacity to start.</para>
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
            /// <para>The name of the Worker RAM role.</para>
            /// <remarks>
            /// <para>Notice: This parameter is supported only for ACK managed clusters of v1.22 or later when creating a node pool.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>example-role</para>
            /// </summary>
            [NameInMap("ram_role_name")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The list of RDS instances.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>The resource pool and resource pool policy used when creating an instance. Note the following when setting this parameter:
            /// This parameter is effective only when creating pay-as-you-go instances.
            /// This parameter cannot be set at the same time as private_pool_options.match_criteria and private_pool_options.id.</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public NodepoolScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class NodepoolScalingGroupResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>The list of private pool IDs, which are the IDs of elastic assurance services or capacity reservation services. This parameter can only pass Target mode private pool IDs. The value of N ranges from 1 to 20.</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>The resource pool policy used when creating an instance. Resource pools include private pools generated by elastic assurance services or capacity reservation services, along with public pools, for instance startup. Valid values:
                /// PrivatePoolFirst: Private pool first. When this policy is selected and resource_pool_options.private_pool_ids is specified, the specified private pool is used first. If no private pool is specified or the specified private pool has insufficient capacity, the system automatically matches an open-type private pool. If no eligible private pool is found, the instance is created from the public pool.
                /// PrivatePoolOnly: Private pool only. When this policy is selected, you must specify resource_pool_options.private_pool_ids. If the specified private pool has insufficient capacity, the instance fails to start.
                /// None: Do not use a resource pool policy.
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
            /// <item><description><para><c>release</c>: Standard mode. Creates and releases ECS instances to meet resource demands.</para>
            /// </description></item>
            /// <item><description><para><c>recycle</c>: Fast mode. Creates, stops, and starts ECS instances to accelerate scaling. When an instance is stopped, you are not charged for its compute resources, but you are still charged for storage fees. This does not apply to instance types with local disks.</para>
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
            /// <para>The ID of the security group for the node pool. You must specify this parameter or <c>security_group_ids</c>. We recommend using <c>security_group_ids</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2zeihch86ooz9io4****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The list of security group IDs. You must specify this parameter or <c>security_group_id</c>. We recommend using <c>security_group_ids</c>. If both <c>security_group_id</c> and <c>security_group_ids</c> are specified, <c>security_group_ids</c> takes precedence.</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>Specifies the number of available instance types. The scaling group will create spot instances in a balanced manner across multiple types with the lowest cost. Value range: [1, 10].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable replenishment for spot instances. When enabled, the scaling group will attempt to create new instances to replace spot instances that are about to be reclaimed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables replenishment for spot instances.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables replenishment for spot instances.</para>
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
            /// <para>The market price range configuration for a single spot instance type.</para>
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
            /// <para>The preemption policy for the spot instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NoSpot: A regular on-demand instance.</para>
            /// </description></item>
            /// <item><description><para>SpotWithPriceLimit: Sets the maximum hourly price for the spot instance.</para>
            /// </description></item>
            /// <item><description><para>SpotAsPriceGo: The system automatically bids, following the current market price.</para>
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
            /// <para>Specifies whether to enable performance burst for the system disk of the nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes.</para>
            /// </description></item>
            /// <item><description><para>false: No.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter can be set only when <c>SystemDiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>Multiple disk types for the system disk. When a disk type with a higher priority is unavailable, the system automatically tries the next lower-priority disk type to create the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud: Basic disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: Ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: Standard SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The type of the system disk for the nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cloud_efficiency</c>: Ultra disk.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_ssd</c>: Standard SSD.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_essd</c>: ESSD.</para>
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
            /// <para>The encryption algorithm used by the system disk of the node. Valid value: aes-256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes-256</para>
            /// </summary>
            [NameInMap("system_disk_encrypt_algorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. Valid values: true: Encrypts the disk. false: Does not encrypt the disk.</para>
            /// </summary>
            [NameInMap("system_disk_encrypted")]
            [Validation(Required=false)]
            public bool? SystemDiskEncrypted { get; set; }

            /// <summary>
            /// <para>The KMS key ID used by the system disk of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("system_disk_kms_key_id")]
            [Validation(Required=false)]
            public string SystemDiskKmsKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the system disk for the nodes. This parameter is only effective for ESSDs.</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: Medium concurrent I/O performance, stable read and write latency.</para>
            /// </description></item>
            /// <item><description><para>PL1: Medium concurrent I/O performance, stable read and write latency.</para>
            /// </description></item>
            /// <item><description><para>PL2: High concurrent I/O performance, stable read and write latency.</para>
            /// </description></item>
            /// <item><description><para>PL3: Extremely high concurrent I/O performance, extremely stable read and write latency.</para>
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
            /// <para>The pre-configured read and write IOPS of the system disk for the nodes. Possible values: 0 to min{50,000, 1000 × capacity - baseline performance}. Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
            /// <para>This parameter can be set only when <c>SystemDiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk for the nodes. Unit: GiB.</para>
            /// <para>Value range: [40, 500].</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>Adds tags only to ECS instances.</para>
            /// <para>Tag keys cannot be repeated and can be up to 128 characters long. Tag keys and values cannot start with &quot;aliyun&quot; or &quot;acs:&quot;, or contain &quot;https\://&quot;&quot; or &quot;http\://&quot;.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<NodepoolScalingGroupTags> Tags { get; set; }
            public class NodepoolScalingGroupTags : TeaModel {
                /// <summary>
                /// <para>The name of the tag.</para>
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
            /// <para>The virtual switch ID.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The confidential computing node pool configurations.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public NodepoolTeeConfig TeeConfig { get; set; }
        public class NodepoolTeeConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether it is a confidential computing node pool.</para>
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
