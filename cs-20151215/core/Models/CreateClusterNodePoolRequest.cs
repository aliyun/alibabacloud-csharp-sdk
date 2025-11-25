// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterNodePoolRequest : TeaModel {
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoMode AutoMode { get; set; }
        public class CreateClusterNodePoolRequestAutoMode : TeaModel {
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The configurations of auto scaling.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class CreateClusterNodePoolRequestAutoScaling : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// <para>The maximum bandwidth of the EIP. Unit: Mbit/s.</para>
            /// <para>**</para>
            /// <para><b>Important</b> This parameter is deprecated. Use the internet_charge_type and internet_max_bandwidth_out parameters instead.</para>
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
            /// <para>The metering method of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>: pay-by-bandwidth.</description></item>
            /// <item><description><c>PayByTraffic</c>: pay-by-data-transfer.</description></item>
            /// </list>
            /// <para>Default value: <c>PayByBandwidth</c>.</para>
            /// <para>**</para>
            /// <para><b>Important</b> This parameter is deprecated. Use the internet_charge_type and internet_max_bandwidth_out parameters instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            [Obsolete]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto scaling for the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables auto scaling.</description></item>
            /// <item><description><c>false</c>: disables auto scaling. If you set this parameter to false, other parameters in the <c>auto_scaling</c> section do not take effect.</description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
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
            /// <para>Specifies whether to associate an elastic IP address (EIP) with the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: associates an EIP with the node pool.</description></item>
            /// <item><description><c>false</c>: does not associate an EIP with the node pool.</description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// <para>**</para>
            /// <para><b>Important</b> This parameter is deprecated. Use the internet_charge_type and internet_max_bandwidth_out parameters instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// <para>The maximum number to which the Elastic Compute Service (ECS) instances in the node pool can be scaled. The number of nodes in the node pool cannot be greater than this value. This parameter takes effect only when <c>enable</c> is set to true. Valid values: [min_instances, 2000]. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number to which the ECS instances in the node pool can be scaled. The number of nodes in the node pool cannot be smaller than this value. This parameter takes effect only when <c>enable</c> is set to true. Valid values: [0, max_instances]. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// <para>The instance type that is used for auto scaling. This parameter takes effect only when <c>enable</c> is set to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cpu</c>: regular instance.</description></item>
            /// <item><description><c>gpu</c>: GPU-accelerated instance.</description></item>
            /// <item><description><c>gpushare</c>: shared GPU-accelerated instance.</description></item>
            /// <item><description><c>spot</c>: preemptible instance.</description></item>
            /// </list>
            /// <para>Default value: <c>cpu</c>.</para>
            /// <remarks>
            /// <para> You cannot modify this parameter after the node pool is created.</para>
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
        /// <para>This parameter is deprecated. Use the desired_size parameter instead.</para>
        /// <para>The number of nodes in the node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Count { get; set; }

        [NameInMap("eflo_node_group")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestEfloNodeGroup EfloNodeGroup { get; set; }
        public class CreateClusterNodePoolRequestEfloNodeGroup : TeaModel {
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("group_id")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to set the network type of the pod to host network.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: sets to host network.</description></item>
        /// <item><description><c>false</c>: sets to container network.</description></item>
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
        /// <para>This parameter is deprecated.</para>
        /// <para>The configurations of the edge node pool.</para>
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        [Obsolete]
        public CreateClusterNodePoolRequestInterconnectConfig InterconnectConfig { get; set; }
        public class CreateClusterNodePoolRequestInterconnectConfig : TeaModel {
            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// <para>The bandwidth of the enhanced edge node pool. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// <para>The ID of the Cloud Connect Network (CCN) instance that is associated with the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccn-qm5i0i0q9yi*******</para>
            /// </summary>
            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            public string CcnId { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// <para>The region to which the CCN instance that is associated with the enhanced edge node pool belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            public string CcnRegionId { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// <para>The ID of the Cloud Enterprise Network (CEN) instance that is associated with the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-ey9k9nfhz0f*******</para>
            /// </summary>
            [NameInMap("cen_id")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// <para>The subscription duration of the enhanced edge node pool. The duration is measured in months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("improved_period")]
            [Validation(Required=false)]
            public string ImprovedPeriod { get; set; }

        }

        /// <summary>
        /// <para>The network type of the edge node pool. This parameter takes effect only when the <c>type</c> of the node pool is set to <c>edge</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>basic</c>: Internet.</description></item>
        /// <item><description><c>private</c>: private network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("interconnect_mode")]
        [Validation(Required=false)]
        public string InterconnectMode { get; set; }

        /// <summary>
        /// <para>Specifies whether all nodes in the edge node pool can communicate with each other at Layer 3.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The nodes in the edge node pool can communicate with each other at Layer 3.</description></item>
        /// <item><description><c>false</c>: The nodes in the edge node pool cannot communicate with each other at Layer 3.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("intranet")]
        [Validation(Required=false)]
        public bool? Intranet { get; set; }

        /// <summary>
        /// <para>The configurations of the cluster.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class CreateClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to install the CloudMonitor agent on ECS nodes. After the CloudMonitor agent is installed on ECS nodes, you can view monitoring information about the instances in the CloudMonitor console. We recommend that you install the CloudMonitor agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: installs the CloudMonitor agent on ECS nodes.</description></item>
            /// <item><description><c>false</c>: does not install the CloudMonitor agent on ECS nodes.</description></item>
            /// </list>
            /// <para>Default value: <c>false</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }

            /// <summary>
            /// <para>The CPU management policy of nodes in the node pool. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later:</para>
            /// <list type="bullet">
            /// <item><description><c>static</c>: allows pods with specific resource characteristics on the node to be granted with enhanced CPU affinity and exclusivity.</description></item>
            /// <item><description><c>none</c>: specifies that the default CPU affinity is used.</description></item>
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
            /// <para>The labels that you want to add to the nodes in the cluster.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>A custom node name consists of a prefix, a node IP address, and a suffix.</para>
            /// <list type="bullet">
            /// <item><description>The prefix and the suffix can contain multiple parts that are separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). A custom node name must start and end with a digit or lowercase letter.</description></item>
            /// <item><description>The node IP address in a custom node name is the private IP address of the node.</description></item>
            /// </list>
            /// <para>Set the parameter to a value in the customized,aliyun,ip,com format. The value consists of four parts that are separated by commas (,). customized and ip are fixed content. aliyun is the prefix and com is the suffix. Example: aliyun.192.168.xxx.xxx.com.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customized,aliyun,ip,com</para>
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// <para>The user-defined data of nodes. You can specify custom scripts that are automatically executed before the nodes are initialized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGhpcyBpcyBhIGV4YW1wbGU</para>
            /// </summary>
            [NameInMap("pre_user_data")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>The name of the container runtime. The following types of runtime are supported by ACK:</para>
            /// <list type="bullet">
            /// <item><description>containerd: containerd is the recommended runtime and supports all Kubernetes versions.</description></item>
            /// <item><description>Sandboxed-Container.runv: The Sandbox-Container runtime provides improved isolation and supports Kubernetes 1.24 and earlier.</description></item>
            /// <item><description>docker: The Docker runtime supports Kubernetes 1.22 and earlier.</description></item>
            /// </list>
            /// <para>Default value: containerd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docker</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>The version of the container runtime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19.03.5</para>
            /// </summary>
            [NameInMap("runtime_version")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }

            /// <summary>
            /// <para>The configurations of the taints.</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>Specifies whether the nodes are schedulable after a scale-out operation is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("unschedulable")]
            [Validation(Required=false)]
            public bool? Unschedulable { get; set; }

            /// <summary>
            /// <para>The user-defined data of nodes. You can specify custom scripts that are automatically executed after the nodes are initialized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGhpcyBpcyBhIGV4YW1wbGU=</para>
            /// </summary>
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the managed node pool feature.</para>
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestManagement Management { get; set; }
        public class CreateClusterNodePoolRequestManagement : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto node repair. This parameter takes effect only when <c>enable</c> is set to true.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables auto node repair.</description></item>
            /// <item><description><c>false</c>: disables auto node repair.</description></item>
            /// </list>
            /// <para>If <c>enable</c> is set to true, the default value of this parameter is <c>true</c>. If <c>enable</c> is set to false, the default value of this parameter is <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// <para>The auto node repair policy.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoRepairPolicy : TeaModel {
                [NameInMap("approval_required")]
                [Validation(Required=false)]
                public bool? ApprovalRequired { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restart. This parameter takes effect only when <c>auto_repair</c> is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: allows node restart.</description></item>
                /// <item><description><c>false</c>: does not allow node restart.</description></item>
                /// </list>
                /// <para>If <c>auto_repair</c> is set to true, the default value of this parameter is <c>true</c>. If <c>auto_repair</c> is set to false, the default value of this parameter is <c>false</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable auto node upgrade. This parameter takes effect only when <c>enable</c> is set to true.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables auto node upgrade.</description></item>
            /// <item><description><c>false</c>: disables auto node upgrade.</description></item>
            /// </list>
            /// <para>If <c>enable</c> is set to true, the default value of this parameter is <c>true</c>. If <c>enable</c> is set to false, the default value of this parameter is <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_upgrade")]
            [Validation(Required=false)]
            public bool? AutoUpgrade { get; set; }

            /// <summary>
            /// <para>The auto node upgrade policy.</para>
            /// </summary>
            [NameInMap("auto_upgrade_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow the auto upgrade of the kubelet. This parameter takes effect only when <c>auto_upgrade</c> is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: allows the auto upgrade of the kubelet.</description></item>
                /// <item><description><c>false</c>: does not allow the auto upgrade of the kubelet.</description></item>
                /// </list>
                /// <para>If <c>auto_upgrade</c> is set to true, the default value of this parameter is <c>true</c>. If <c>auto_upgrade</c> is set to false, the default value of this parameter is <c>false</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow the auto upgrade of the OS. This parameter takes effect only when <c>auto_upgrade</c> is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: allows the auto upgrade of the OS.</description></item>
                /// <item><description><c>false</c>: does not allow the auto upgrade of the OS.</description></item>
                /// </list>
                /// <para>Default value: <c>false</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("auto_upgrade_os")]
                [Validation(Required=false)]
                public bool? AutoUpgradeOs { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow the auto upgrade of the runtime. This parameter takes effect only when <c>auto_upgrade</c> is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: allows the auto upgrade of the runtime.</description></item>
                /// <item><description><c>false</c>: does not allow the auto upgrade of the runtime.</description></item>
                /// </list>
                /// <para>Default value: <c>false</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("auto_upgrade_runtime")]
                [Validation(Required=false)]
                public bool? AutoUpgradeRuntime { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable auto Common Vulnerabilities and Exposures (CVE) patching. This parameter takes effect only when <c>enable</c> is set to true.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables auto CVE patching.</description></item>
            /// <item><description><c>false</c>: disables auto CVE patching.</description></item>
            /// </list>
            /// <para>If <c>enable</c> is set to true, the default value of this parameter is <c>true</c>. If <c>enable</c> is set to false, the default value of this parameter is <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_vul_fix")]
            [Validation(Required=false)]
            public bool? AutoVulFix { get; set; }

            /// <summary>
            /// <para>The auto CVE patching policy.</para>
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoVulFixPolicy : TeaModel {
                [NameInMap("exclude_packages")]
                [Validation(Required=false)]
                public string ExcludePackages { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restart. This parameter takes effect only when <c>auto_vul_fix</c> is set to true. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: allows node restart.</description></item>
                /// <item><description><c>false</c>: does not allow node restart. If <c>auto_vul_fix</c> is set to true, the default value of this parameter is <c>false</c>. If <c>auto_vul_fix</c> is set to false, the default value of this parameter is <c>false</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// <para>The severity levels of CVEs that can be automatically patched. Separate multiple levels with commas (,). Example: <c>asap,later</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>asap</c>: high.</description></item>
                /// <item><description><c>later</c>: medium.</description></item>
                /// <item><description><c>nntf</c>: low.</description></item>
                /// </list>
                /// <para>If <c>auto_vul_fix</c> is set to true, the default value of this parameter is <c>asap</c>.</para>
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
            /// <item><description><c>true</c>: enables the managed node pool feature.</description></item>
            /// <item><description><c>false</c>: disables the managed node pool feature. Other parameters in this section take effect only when enable is set to true.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
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
            /// <para>The configurations of auto upgrade. The configurations take effect only when <c>enable</c> is set to true.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public CreateClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class CreateClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>Specifies whether to enable auto upgrade. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: enables auto OS upgrade.</description></item>
                /// <item><description><c>false</c>: disables auto OS upgrade.</description></item>
                /// </list>
                /// <para>**</para>
                /// <para><b>Caution</b> This parameter is deprecated. Use the preceding auto_upgrade parameter instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                [Obsolete]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// <para>The maximum number of nodes that can be in the Unavailable state. Valid values: 1 to 1000.</para>
                /// <para>Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// <para>The number of nodes that are temporarily added to the node pool during an auto upgrade.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>The percentage of additional nodes that are temporarily added to the node pool during an auto upgrade. You must set this parameter or <c>surge</c>.</para>
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
        /// <para>This parameter is deprecated.</para>
        /// <para>The maximum number of nodes that can be contained in the edge node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public long? MaxNodes { get; set; }

        [NameInMap("node_components")]
        [Validation(Required=false)]
        public List<CreateClusterNodePoolRequestNodeComponents> NodeComponents { get; set; }
        public class CreateClusterNodePoolRequestNodeComponents : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestNodeComponentsConfig Config { get; set; }
            public class CreateClusterNodePoolRequestNodeComponentsConfig : TeaModel {
                [NameInMap("custom_config")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomConfig { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kubelet</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
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
        public CreateClusterNodePoolRequestNodeConfig NodeConfig { get; set; }
        public class CreateClusterNodePoolRequestNodeConfig : TeaModel {
            /// <summary>
            /// <para>The configurations of the kubelet.</para>
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
        public CreateClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class CreateClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// <para>The name of the node pool.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster-demo</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the node pool belongs. Instances that are added to the node pool belong to this resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjmb****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The type of node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>ess</c>: regular node pool, which supports the managed node pool feature and the auto scaling feature.</description></item>
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

        }

        /// <summary>
        /// <para>The configurations of the scaling group that is used by the node pool.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class CreateClusterNodePoolRequestScalingGroup : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for nodes in the node pool. This parameter takes effect only when you set <c>instance_charge_type</c> to <c>PrePaid</c>. Valid values:</para>
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
            /// <para>The auto-renewal period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Valid values when PeriodUnit is set to Week: 1, 2, and 3.</description></item>
            /// <item><description>Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
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
            /// <para>This parameter is deprecated. Use security_hardening_os instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("cis_enabled")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? CisEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the required number of ECS instances if preemptible instances cannot be created due to reasons such as the price or insufficient inventory. This parameter takes effect when you set <c>multi_az_policy</c> to <c>COST_OPTIMIZED</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: automatically creates pay-as-you-go instances to meet the required number of ECS instances if preemptible instances cannot be created.</description></item>
            /// <item><description><c>false</c>: does not create pay-as-you-go instances to meet the required number of ECS instances if preemptible instances cannot be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("compensate_with_on_demand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// <para>The configurations of the data disks that are attached to nodes in the node pool.</para>
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("desired_size")]
            [Validation(Required=false)]
            public long? DesiredSize { get; set; }

            /// <summary>
            /// <para>The custom image ID. By default, the image provided by Container Service for Kubernetes (ACK) is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_2_1903_x64_20G_alibase_20200529.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The type of the OS image. You must specify this parameter or <c>platform</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>AliyunLinux</c>: Alibaba Cloud Linux 2.</description></item>
            /// <item><description><c>AliyunLinuxSecurity</c>: Alibaba Cloud Linux 2 (UEFI).</description></item>
            /// <item><description><c>AliyunLinux3</c>: Alibaba Cloud Linux 3</description></item>
            /// <item><description><c>AliyunLinux3Arm64</c>: Alibaba Cloud Linux 3 for ARM.</description></item>
            /// <item><description><c>AliyunLinux3Security</c>: Alibaba Cloud Linux 3 for ARM.</description></item>
            /// <item><description><c>CentOS</c>: CentOS.</description></item>
            /// <item><description><c>Windows</c>: Windows.</description></item>
            /// <item><description><c>WindowsCore</c>: Windows Core.</description></item>
            /// <item><description><c>ContainerOS</c>: ContainerOS.</description></item>
            /// <item><description><c>AliyunLinux3ContainerOptimized</c>: Alibaba Cloud Linux 3 Container-optimized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux</para>
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
            /// <para>Default value: <c>PostPaid</c></para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

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
            /// <para>The instance types of nodes in the node pool. When the system adds a node to the node pool, the system selects the most appropriate one from the specified instance types for the node. You can specify 1 to 10 instance types.</para>
            /// <remarks>
            /// <para> To ensure high availability, we recommend that you specify multiple instance types.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The metering method of the public IP address. Valid values:</para>
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
            /// <para>The maximum outbound bandwidth of the public IP address. Unit: Mbit/s. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>The name of the key pair used to log on to nodes in the node pool. You must set this parameter or <c>login_password</c>.</para>
            /// <remarks>
            /// <para> If you select ContainerOS as the OS of nodes in the node pool, you must specify <c>key_pair</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>np-key-name</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow a non-root user to log on to an ECS instance that is added to the node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("login_as_non_root")]
            [Validation(Required=false)]
            public bool? LoginAsNonRoot { get; set; }

            /// <summary>
            /// <para>The password for SSH logon. You must specify this parameter or the <c>key_pair</c> parameter. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello1234</para>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The ECS instance scaling policy for the multi-zone scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PRIORITY</c>: ECS instances are scaled based on the value of VSwitchIds.N. If an ECS instance cannot be created in the zone where the vSwitch that has the highest priority resides, the system creates the ECS instance in the zone where the vSwitch that has the next highest priority resides.</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>: ECS instances are created based on the vCPU unit price in ascending order. Preemptible instances are preferably created if preemptible instance types are specified in the scaling configurations. You can set the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically create pay-as-you-go instances when preemptible instances cannot be created due to insufficient inventory.</para>
            /// <para>**</para>
            /// <para><b>Note</b> <c>COST_OPTIMIZED</c> takes effect only when multiple instance types are specified or at least one preemptible instance type is specified.</para>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>: ECS instances are evenly distributed across multiple zones for the scaling group. If ECS instances become imbalanced among multiple zones due to insufficient inventory, you can call the <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a> operation of Auto Scaling to evenly distribute the ECS instances among zones.</para>
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
            /// <para>The minimum number of pay-as-you-go instances that must be kept in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than the value of this parameter, the system preferably creates pay-as-you-go instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of pay-as-you-go instances among the extra instances that exceed the number specified by <c>on_demand_base_capacity</c>. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The subscription duration of nodes in the node pool. This parameter takes effect and is required if you set <c>instance_charge_type</c> to <c>PrePaid</c>.</para>
            /// <list type="bullet">
            /// <item><description>If <c>period_unit</c> is set to Week, the valid values of <c>period</c> are 1, 2, 3, and 4.</description></item>
            /// <item><description>If <c>period_unit</c> is set to Month, the valid values of <c>period</c> are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The billing cycle of nodes in the node pool. This parameter takes effect and is required only when you set <c>instance_charge_type</c> to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Month</c>: The subscription duration is measured in months.</description></item>
            /// <item><description><c>Week</c>: The subscription duration is measured in weeks.</description></item>
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
            /// <para>The configurations of the private node pool.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupPrivatePoolOptions : TeaModel {
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
                /// <para>The type of private node pool. This parameter specifies the type of private pool that you want to use to create instances. A private pool is generated when an elasticity assurance or a capacity reservation takes effect. The system selects a private pool to start instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>Open</c>: uses an open private pool. The system selects an open private pool to start instances. If no matching open private pools are available, the resources in the public pool are used.</description></item>
                /// <item><description><c>Target</c>: uses a specified private pool. The system uses the resources of the specified private pool to start instances. If the specified private pool is unavailable, instances cannot be started.</description></item>
                /// <item><description><c>None</c>: no private pool is used. The resources of private pools are not used to launch the instances.</description></item>
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
            /// <list type="bullet">
            /// <item><description>If you do not specify this parameter, the default worker RAM role created by the cluster is used.</description></item>
            /// <item><description>The specified RAM role must be a <b>regular service role</b> and the <b>Select Trusted Service</b> parameter must be set to <b>Elastic Compute Service</b>. For more information, see <a href="https://help.aliyun.com/document_detail/116800.html">Create a normal service role</a>. If the specified RAM role is not the default worker RAM role created by the cluster, the name of the RAM role cannot start with <c>KubernetesMasterRole-</c> or <c>KubernetesWorkerRole-</c>.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is available only for ACK managed clusters that run Kubernetes 1.22 or later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>example-role</para>
            /// </summary>
            [NameInMap("ram_role_name")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The IDs of ApsaraDB RDS instances.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupResourcePoolOptions : TeaModel {
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
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
            /// <item><description><c>release</c>: the standard mode. ECS instances are created and released based on resource usage.</description></item>
            /// <item><description><c>recycle</c>: the swift mode. ECS instances are created, stopped, or started during scaling events. This reduces the time required for the next scale-out event. When the instance is stopped, you are charged only for the storage service. This does not apply to ECS instances that are attached with local disks.</description></item>
            /// </list>
            /// <para>Default value: <c>release</c>.</para>
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
            /// <para>The ID of the security group to which you want to add the node pool. You must specify this parameter or the <c>security_group_ids</c> parameter. We recommend that you specify <c>security_group_ids</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-wz9a8g2mt6x5llu0****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of security groups. You must specify this parameter or <c>security_group_id</c>. We recommend that you specify <c>security_group_ids</c>. If you specify both <c>security_group_id</c> and <c>security_group_ids</c>, <c>security_group_ids</c> is used.</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>Indicates whether Alibaba Cloud Linux Security Hardening is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables Alibaba Cloud Linux Security Hardening.</description></item>
            /// <item><description><c>false</c>: disables Alibaba Cloud Linux Security Hardening.</description></item>
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
            /// <para>Specifies whether to enable MLPS Security Hardening. You can enable security hardening based on Multi-Level Protection Scheme (MLPS) only when Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3 is installed on nodes. Alibaba Cloud provides standards for baseline checks and a scanner to ensure the compliance of Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3 images with the level 3 standards of MLPS 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// <para>The number of instance types that are available for creating preemptible instances. Auto Scaling creates preemptible instances of multiple instance types that are available at the lowest cost. Valid values: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Indicates whether preemptible instances can be supplemented. If you set this parameter to true, when the scaling group receives a system message indicating that a preemptible instance is to be reclaimed, the scaling group attempts to create a new instance to replace this instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables the supplementation of preemptible instances.</description></item>
            /// <item><description><c>false</c>: disables the supplementation of preemptible instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// <para>The instance type of preemptible instances and the price cap for the instance type.</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
                /// <summary>
                /// <para>The instance type of preemptible instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c6.large</para>
                /// </summary>
                [NameInMap("instance_type")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The price cap of a preemptible instance of the type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.39</para>
                /// </summary>
                [NameInMap("price_limit")]
                [Validation(Required=false)]
                public string PriceLimit { get; set; }

            }

            /// <summary>
            /// <para>The bidding policy of preemptible instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>NoSpot</c>: non-preemptible.</description></item>
            /// <item><description><c>SpotWithPriceLimit</c>: specifies the highest bid for the preemptible instance.</description></item>
            /// <item><description><c>SpotAsPriceGo</c>: automatically submits bids based on the up-to-date market price.</description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/165053.html">Use preemptible instances</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the burst feature for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the burst feature.</description></item>
            /// <item><description>false: disables the burst feature.</description></item>
            /// </list>
            /// <para>This parameter is available only when <c>SystemDiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The categories of the system disk for nodes. The system attempts to create system disks of a disk category with a lower priority if the disk category with a higher priority is unavailable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cloud</c>: basic disk.</description></item>
            /// <item><description><c>cloud_efficiency</c>: ultra disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
            /// <item><description><c>cloud_essd</c>: ESSD.</description></item>
            /// <item><description><c>cloud_auto</c>: ESSD AutoPL disk.</description></item>
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry disk.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The category of the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cloud</c>: basic disk.</description></item>
            /// <item><description><c>cloud_efficiency</c>: ultra disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
            /// <item><description><c>cloud_essd</c>: ESSD.</description></item>
            /// <item><description><c>cloud_auto</c>: ESSD AutoPL disk.</description></item>
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry disk.</description></item>
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
            /// <para>The encryption algorithm that is used to encrypt the system disk. Set the value to aes-256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes-256</para>
            /// </summary>
            [NameInMap("system_disk_encrypt_algorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. true: encrypts the system disk. false: does not encrypt the system disk.</para>
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
            /// <para>The PL of the system disk. This parameter takes effect only for an ESSD.</para>
            /// <list type="bullet">
            /// <item><description>PL0: moderate maximum concurrent I/O performance and low I/O latency.</description></item>
            /// <item><description>PL1: moderate maximum concurrent I/O performance and low I/O latency.</description></item>
            /// <item><description>PL2: high maximum concurrent I/O performance and low I/O latency.</description></item>
            /// <item><description>PL3: ultra-high maximum concurrent I/O performance and ultra-low I/O latency.</description></item>
            /// </list>
            /// <remarks>
            /// <para> Alibaba Cloud disks support the preceding PLs. However, when you create a disk, the available PLs vary based on the ECS instance type that you selected. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of ECS instance families</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The preset IOPS of the system disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
            /// <para>This parameter is supported only when <c>SystemDiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB.</para>
            /// <para>Valid values: 20 to 20248.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            [NameInMap("system_disk_snapshot_policy_id")]
            [Validation(Required=false)]
            public string SystemDiskSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>The tags that you want to add only to ECS instances.</para>
            /// <para>The tag key must be unique and cannot exceed 128 characters in length. The tag key and value cannot start with aliyun or acs: or contain https:// or http://.</para>
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
            /// <para>The vSwitch IDs. You can specify one to eight vSwitch IDs.</para>
            /// <remarks>
            /// <para> To ensure high availability, we recommend that you select vSwitches that reside in different zones.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The configurations of confidential computing for the cluster.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class CreateClusterNodePoolRequestTeeConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable confidential computing for the cluster.</para>
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
