// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>The auto scaling configurations.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class ModifyClusterNodePoolRequestAutoScaling : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated. Use internet_charge_type and internet_max_bandwidth_out instead.
            /// The peak bandwidth of the EIP.</para>
            /// <para>Valid values: [1, 100]. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            [Obsolete]
            public long? EipBandwidth { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated. Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <para>The billing method of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PayByBandwidth</c>: pay-by-bandwidth.</para>
            /// </description></item>
            /// <item><description><para><c>PayByTraffic</c>: pay-by-traffic.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>PayByBandwidth</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            [Obsolete]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto scaling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables auto scaling for the node pool. If the resources in the cluster do not meet the scheduling requirements of application pods, ACK automatically scales the nodes based on the configured minimum and maximum numbers of instances. For clusters of Kubernetes 1.24 or later, instant elasticity is enabled by default. For clusters of a Kubernetes version earlier than 1.24, node autoscaling is enabled by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node scaling</a>.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables auto scaling. ACK adjusts the number of nodes in the node pool to the value of \<c>desired_size\\</c> and keeps the number of nodes unchanged.</para>
            /// </description></item>
            /// </list>
            /// <para>If this parameter is set to false, other parameters in <c>auto_scaling</c> do not take effect.</para>
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
            /// <para>This parameter is deprecated. Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: associates an EIP.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: does not associate an EIP.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// <para>The maximum number of instances that can be created in the node pool. This parameter does not include existing instances. This parameter takes effect only when <c>enable=true</c>.</para>
            /// <para>Valid values: [min_instances, 2000]. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of instances that can be created in the node pool. This parameter does not include existing instances. This parameter takes effect only when <c>enable=true</c>.</para>
            /// <para>Valid values: [0, max_instances]. Default value: 0.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>If the minimum number of instances is not 0, the specified number of ECS instances are automatically created after the scaling group is created.</para>
            /// </description></item>
            /// <item><description><para>Set the maximum number of instances to a value that is not smaller than the current number of nodes in the node pool. Otherwise, a scale-in event is triggered after auto scaling is enabled.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The type of auto scaling. This parameter is specified based on the instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cpu</c>: regular instance.</para>
            /// </description></item>
            /// <item><description><para><c>gpu</c>: GPU-accelerated instance.</para>
            /// </description></item>
            /// <item><description><para><c>gpushare</c>: shared GPU-accelerated instance.</para>
            /// </description></item>
            /// <item><description><para><c>spot</c>: spot instance.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>cpu</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            [Obsolete]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to run the task in parallel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public bool? Concurrency { get; set; }

        /// <summary>
        /// <para>The Kubernetes-related configurations.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class ModifyClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to install Cloud Monitor on the ECS nodes. After Cloud Monitor is installed, you can view the monitoring information of the created ECS instances in the Cloud Monitor console. We recommend that you enable this feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: installs Cloud Monitor on ECS nodes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: does not install Cloud Monitor on ECS nodes.</para>
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
            /// <para>The CPU management policy of the node. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later:</para>
            /// <list type="bullet">
            /// <item><description><para><c>static</c>: allows pods with specific resource characteristics on the node to be granted with enhanced CPU affinity and exclusivity.</para>
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
            /// <para>The labels that you want to add to the nodes. The following rules apply:</para>
            /// <list type="bullet">
            /// <item><description><para>A label is a case-sensitive key-value pair. You can add up to 20 labels.</para>
            /// </description></item>
            /// <item><description><para>The key must be unique and can be up to 64 characters in length. The value can be empty and can be up to 128 characters in length. The key and the value cannot start with <c>aliyun</c>, <c>acs:</c>, <c>https://</c>, or <c>http://</c>. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>The custom node name parameter. A node name consists of three parts: a prefix, the node IP address, and a suffix.</para>
            /// <para>The prefix and suffix can contain one or more parts that are separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). The node name must start and end with a lowercase letter or a digit. The node IP address is the complete private IP address of the node.</para>
            /// <para>The parameter consists of four parts that are separated by commas. For example, if you pass the &quot;customized,aliyun,ip,com&quot; string (where &quot;customized&quot; and &quot;ip&quot; are fixed strings, &quot;aliyun&quot; is the prefix, and &quot;com&quot; is the suffix), the node name is aliyun.192.168.xxx.xxx.com.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customized,aliyun,ip,com</para>
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// <para>The pre-customized instance data. Before a node is added to the cluster, the specified pre-customized instance data script is run. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User data</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFDSyEi</para>
            /// </summary>
            [NameInMap("pre_user_data")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>The name of the container runtime. ACK supports the following three container runtimes.</para>
            /// <list type="bullet">
            /// <item><description><para>containerd: We recommend that you use this runtime. It is supported by all cluster versions.</para>
            /// </description></item>
            /// <item><description><para>Sandboxed-Container.runv: a sandboxed container that provides higher isolation. It is supported by clusters of Kubernetes 1.31 and earlier.</para>
            /// </description></item>
            /// <item><description><para>docker: This runtime is no longer maintained. It is supported by clusters of Kubernetes 1.22 and earlier.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: containerd.</para>
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
            /// <para>The node taint configurations.</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>Specifies whether the scaled-out nodes are unschedulable.</para>
            /// <list type="bullet">
            /// <item><description><para>true: The nodes are unschedulable.</para>
            /// </description></item>
            /// <item><description><para>false: The nodes are schedulable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("unschedulable")]
            [Validation(Required=false)]
            public bool? Unschedulable { get; set; }

            /// <summary>
            /// <para>The instance user data. After a node is added to the cluster, the specified user data script is run. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User data</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFDSyEi</para>
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
        public ModifyClusterNodePoolRequestManagement Management { get; set; }
        public class ModifyClusterNodePoolRequestManagement : TeaModel {
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto node repair. This parameter takes effect only when enable is set to <c>true</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Auto repair is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Auto repair is disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>true</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// <para>The auto node repair policy.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether manual approval is required for node repair.</para>
                /// </summary>
                [NameInMap("approval_required")]
                [Validation(Required=false)]
                public bool? ApprovalRequired { get; set; }

                /// <summary>
                /// <para>The ID of the auto repair policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("auto_repair_policy_id")]
                [Validation(Required=false)]
                public string AutoRepairPolicyId { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restart. This parameter takes effect only when auto_repair is set to <c>true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: allows node restart.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: disallows node restart.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: <c>true</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable auto node upgrade. This parameter takes effect only when enable is set to <c>true</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enables auto upgrade.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disables auto upgrade.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>true</c></para>
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
            public ModifyClusterNodePoolRequestManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow auto kubelet upgrade. This parameter takes effect only when auto_upgrade is set to <c>true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: allows auto kubelet upgrade.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: disallows auto kubelet upgrade.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: <c>true</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow auto operating system upgrade. This parameter takes effect only when auto_upgrade is set to <c>true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: allows auto operating system upgrade.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: disallows auto operating system upgrade.</para>
                /// </description></item>
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
                /// <para>Specifies whether to allow auto runtime upgrade. This parameter takes effect only when auto_upgrade is set to <c>true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: allows auto runtime upgrade.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: disallows auto runtime upgrade.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: <c>true</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("auto_upgrade_runtime")]
                [Validation(Required=false)]
                public bool? AutoUpgradeRuntime { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically fix CVE vulnerabilities. This parameter takes effect only when enable is set to <c>true</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: allows automatic CVE fixing.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disallows automatic CVE fixing.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_vul_fix")]
            [Validation(Required=false)]
            public bool? AutoVulFix { get; set; }

            /// <summary>
            /// <para>The policy for automatically fixing CVE vulnerabilities.</para>
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>The packages that should be excluded during vulnerability fixing.</para>
                /// <para>Default value: <c>kernel</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kernel</para>
                /// </summary>
                [NameInMap("exclude_packages")]
                [Validation(Required=false)]
                public string ExcludePackages { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restart. This parameter takes effect only when auto_vul_fix is set to <c>true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: allows node restart.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: disallows node restart.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: <c>true</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// <para>The vulnerability levels that are allowed to be automatically fixed. The value is a comma-separated list. Example: <c>asap,later</c>. Supported vulnerability levels:</para>
                /// <list type="bullet">
                /// <item><description><para><c>asap</c>: high</para>
                /// </description></item>
                /// <item><description><para><c>later</c>: medium</para>
                /// </description></item>
                /// <item><description><para><c>nntf</c>: low</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: <c>asap</c>.</para>
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
            /// <item><description><para><c>false</c>: Disables the managed node pool. Other related configurations are ignored.</para>
            /// </description></item>
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
            /// <para>This parameter is deprecated. Use the <c>auto_upgrade</c> parameter at the upper level instead.</para>
            /// <para>The auto upgrade configurations. This parameter takes effect only when enable is set to <c>true</c>.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public ModifyClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class ModifyClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>This parameter is deprecated. Use the <c>auto_upgrade</c> parameter at the upper level instead.</para>
                /// <para>Specifies whether to enable auto upgrade:</para>
                /// <list type="bullet">
                /// <item><description><para>true: enables auto upgrade.</para>
                /// </description></item>
                /// <item><description><para>false: disables auto upgrade.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: <c>true</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                [Obsolete]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// <para>The maximum number of unavailable nodes.</para>
                /// <para>Valid values: [1, 1000]</para>
                /// <para>Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// <para>The number of extra nodes. You can specify only one of surge and <c>surge_percentage</c>.</para>
                /// <para>Nodes may become unavailable during an upgrade. You can create extra nodes to ensure service continuity.</para>
                /// <remarks>
                /// <para>The number of extra nodes must not exceed the current number of nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>The percentage of extra nodes. You can specify only one of surge and <c>surge_percentage</c>.</para>
                /// <para>Number of extra nodes = Percentage of extra nodes × Number of nodes. For example, if you set the percentage of extra nodes to 50% and the number of existing nodes is 6, three extra nodes are created.</para>
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
        /// <para>The node pool configurations.</para>
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class ModifyClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// <para>The name of the node pool.</para>
            /// <para>The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). It cannot start with a hyphen (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-nodepool</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the resource group for the node pool. Instances created in the node pool belong to this resource group.</para>
            /// <para>A resource can belong to only one resource group. You can use resource groups to categorize resources by project, application, or organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjm****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the node pool scaling group.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class ModifyClusterNodePoolRequestScalingGroup : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for the nodes. This parameter takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Auto-renewal is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Auto-renewal is disabled.</para>
            /// </description></item>
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
            /// <item><description><para>If PeriodUnit=Week, valid values are 1, 2, and 3.</para>
            /// </description></item>
            /// <item><description><para>If PeriodUnit=Month, valid values are 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>If <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c>, this parameter specifies whether to allow the system to automatically create pay-as-you-go instances to meet the required number of ECS instances when spot instances cannot be created due to reasons such as price and stock. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: allows the system to automatically create pay-as-you-go instances to meet the required number of ECS instances.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: does not allow the system to automatically create pay-as-you-go instances to meet the required number of ECS instances.</para>
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
            /// <para>The data disk configurations of the node. You can specify 0 to 10 data disks.</para>
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// <para>The ID of the deployment set to which the ECS instances in the node pool belong. This parameter is valid only for incremental nodes. The deployment sets of existing nodes are not changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1d19mmbsv3jf6xxxxx</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>The expected number of nodes in the node pool.</para>
            /// <para>The total number of nodes that the node pool should maintain. We recommend that you configure at least two nodes to ensure that the cluster components run as expected. You can adjust the expected number of nodes to scale in or scale out the node pool.</para>
            /// <para>If you do not need to create nodes, set this parameter to 0. You can manually adjust the number of nodes later.</para>
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
            /// <para>The ID of the custom image. You can call <c>DescribeKubernetesVersionMetadata</c> to query the images that are supported by the system. By default, the latest image is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20241218.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The distribution of the operating system. We recommend that you use this parameter to specify the operating system of the nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>AliyunLinux</c>: Alinux2 image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinuxSecurity</c>: Alinux2 image with UEFI.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3</c>: Alinux3 image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3Arm64</c>: Alinux3 image for ARM.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3Security</c>: Alinux3 image with UEFI.</para>
            /// </description></item>
            /// <item><description><para><c>CentOS</c>: CentOS image.</para>
            /// </description></item>
            /// <item><description><para><c>Windows</c>: Windows image.</para>
            /// </description></item>
            /// <item><description><para><c>WindowsCore</c>: WindowsCore image.</para>
            /// </description></item>
            /// <item><description><para><c>ContainerOS</c>: container-optimized image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3ContainerOptimized</c>: container-optimized Alinux3 image.</para>
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
            /// <item><description><para><c>PrePaid</c>: subscription</para>
            /// </description></item>
            /// <item><description><para><c>PostPaid</c>: pay-as-you-go</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>PostPaid</c>.</para>
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
            /// <para>A list of node instance types. You can specify multiple instance types as alternatives. When a node is created, the system attempts to purchase the instance types in the order they are specified until one is successfully purchased. The final instance type that is purchased may vary depending on the stock.</para>
            /// <para>You can specify 1 to 10 instance types.</para>
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
            /// <para>The maximum outbound bandwidth of the public IP address of the node. Unit: Mbit/s. Valid values: [1, 100].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>The name of the key pair. You must specify key_pair or <c>login_password</c>. For managed node pools, you can specify only <c>key_pair</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pro-nodepool</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>The SSH logon password. You must specify key_pair or <c>login_password</c>. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
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
            /// <item><description><para><c>PRIORITY</c>: The system scales ECS instances based on the vSwitch priority. The vSwitch priority is specified by the VSwitchIds.N parameter. If the system fails to create an ECS instance in the zone where the vSwitch with the highest priority resides, it attempts to create the ECS instance in the zone where the vSwitch with the next highest priority resides.</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>: The system creates ECS instances of the instance type that has the lowest vCPU price. When the scaling configuration is set to create multiple instance types and the billing method is set to preemptible, the system preferentially creates preemptible instances. You can also use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically create pay-as-you-go instances when the system fails to create preemptible instances due to insufficient stock.</para>
            /// <remarks>
            /// <para>The <c>COST_OPTIMIZED</c> policy is valid only when multiple instance types are specified or preemptible instances are selected in the scaling configuration.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>: The system evenly distributes ECS instances across the zones that are specified in the scaling group. If the distribution of ECS instances becomes unbalanced due to insufficient stock, you can call the <c>RebalanceInstances</c> operation to rebalance the distribution. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a> .</para>
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
            /// <para>The minimum number of on-demand instances that must be contained in the scaling group. Valid values: [0, 1000]. When the number of on-demand instances is less than this value, on-demand instances are preferentially created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of on-demand instances among the instances that exceed the minimum number of on-demand instances (<c>on_demand_base_capacity</c>). Valid values: [0, 100].</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The subscription duration of the nodes in the node pool. This parameter is required and takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>period_unit=Week</c>, valid values of <c>period</c> are {1, 2, 3, 4}.</para>
            /// </description></item>
            /// <item><description><para>If <c>period_unit=Month</c>, valid values of <c>period</c> are {1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, 60}.</para>
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
            /// <para>The billing cycle of the nodes in the node pool. This parameter is required and takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Month</c>: billed by month.</para>
            /// </description></item>
            /// <item><description><para><c>Week</c>: billed by week.</para>
            /// </description></item>
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
            /// <para>This parameter is deprecated. Use the <c>image_type</c> parameter instead.</para>
            /// <para>The OS platform. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>AliyunLinux</c></para>
            /// </description></item>
            /// <item><description><para><c>CentOS</c></para>
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
            [Obsolete]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The private node pool configurations.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// <para>The ID of the private node pool. If <c>match_criteria</c> is set to <c>Target</c>, you must specify the ID of the private pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The type of the private node pool. This parameter specifies the private pool capacity option for instance startup. After an elastic assurance service or a capacity reservation service takes effect, it generates a private pool of capacity for instance startup. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Open</c>: Open mode. The system automatically matches the capacity of private pools in Open mode. If no matching private pool is found, the instance is started using public pool resources.</para>
                /// </description></item>
                /// <item><description><para><c>Target</c>: Specified mode. The instance is started using the capacity of a specified private pool. If the capacity of the specified private pool is unavailable, the instance fails to be started.</para>
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
            /// <para>A list of ApsaraDB RDS instances.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>The resource pool and resource pool policy that are used when you create an instance. If you specify this parameter, note the following points:
            /// This parameter is valid only when you create pay-as-you-go instances.
            /// This parameter cannot be specified at the same time as private_pool_options.match_criteria and private_pool_options.id.</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>A list of private pool IDs. The IDs of elastic assurance services or capacity reservation services. You can specify only the IDs of private pools in Target mode. You can specify 1 to 20 IDs.</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>The resource pool policy that is used when you create an instance. Resource pools include private pools that are generated after elastic assurance services or capacity reservation services take effect, and public pools. You can select a resource pool when you start an instance. Valid values:
                /// PrivatePoolFirst: Private pool first. If you select this policy and specify resouce_pool_options.private_pool_ids, the specified private pool is used first. If you do not specify a private pool or the capacity of the specified private pool is insufficient, the system automatically matches a private pool in Open mode. If no matching private pool is found, a public pool is used to create the instance.
                /// PrivatePoolOnly: Private pool only. If you select this policy, you must specify resouce_pool_options.private_pool_ids. If the capacity of the specified private pool is insufficient, the instance fails to be started.
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
            /// <item><description><para><c>release</c>: standard mode. This mode creates and releases ECS instances to perform scaling.</para>
            /// </description></item>
            /// <item><description><para><c>recycle</c>: fast mode. This mode creates, stops, and starts ECS instances to perform scaling. This improves scaling speed. When an instance is stopped, its computing resources are not billed, but its storage resources are. This does not apply to instance types with local disks.</para>
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
            /// <para>A list of security group IDs.</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The number of available instance types. The scaling group creates spot instances of multiple instance types that are provided at the lowest cost. Valid values: [1, 10].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the feature of supplementing spot instances. If this feature is enabled, the scaling group attempts to create a new instance to replace a spot instance that is reclaimed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enables the feature of supplementing spot instances.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disables the feature of supplementing spot instances.</para>
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
            /// <para>The price range for the spot instance.</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
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
                /// <para>The maximum price of a single instance.</para>
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
            /// <para>The bidding policy for the spot instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>NoSpot</c>: The instance is not a spot instance.</para>
            /// </description></item>
            /// <item><description><para><c>SpotWithPriceLimit</c>: The instance is a spot instance for which you can specify the maximum hourly price.</para>
            /// </description></item>
            /// <item><description><para><c>SpotAsPriceGo</c>: The system automatically bids for the instance. The bid is based on the market price.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/157759.html">Spot instances</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SpotWithPriceLimit</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the performance burst feature for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: enables the performance burst feature. If your business fluctuates and is subject to unexpected data read and write pressure, the cloud disk temporarily improves its performance until your business returns to a stable state.</para>
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
            /// <para>The multi-disk type of the system disk. If a disk of a higher priority disk type cannot be used, the system automatically tries the next priority disk type to create the system disk.</para>
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
            /// <para>The encryption algorithm that is used for the system disk. Valid value: aes-256.</para>
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
            /// <item><description><para>true: encrypts the system disk.</para>
            /// </description></item>
            /// <item><description><para>false: does not encrypt the system disk.</para>
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
            /// <para>The performance level of the system disk. This parameter is valid only for ESSD disks. The performance level of a disk is related to its size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: The maximum concurrent I/O performance is moderate and the read/write latency is relatively stable.</para>
            /// </description></item>
            /// <item><description><para>PL1: The maximum concurrent I/O performance is moderate and the read/write latency is relatively stable.</para>
            /// </description></item>
            /// <item><description><para>PL2: The maximum concurrent I/O performance is high and the read/write latency is stable.</para>
            /// </description></item>
            /// <item><description><para>PL3: The maximum concurrent I/O performance is very high and the read/write latency is very stable.</para>
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
            /// <para>The pre-configured read/write IOPS of the system disk.</para>
            /// <para>Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
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
            /// <para>Valid values: [20, 2048].</para>
            /// <para>The value of this parameter must be greater than or equal to max{20, ImageSize}.</para>
            /// <para>Default value: max{40, The size of the image that corresponds to the ImageId parameter}.</para>
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
            /// <para>sp-0jl6xnmme8v7o935****</para>
            /// </summary>
            [NameInMap("system_disk_snapshot_policy_id")]
            [Validation(Required=false)]
            public string SystemDiskSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>The tags that you want to add only to ECS instances.</para>
            /// <para>Tag keys cannot be repeated. A tag key can be up to 128 characters in length. Tag keys and tag values cannot start with &quot;aliyun&quot; or &quot;acs:&quot; and cannot contain &quot;https\://&quot; or &quot;http\://&quot;.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>A list of vSwitch IDs. You can specify 1 to 8 vSwitch IDs.</para>
            /// <remarks>
            /// <para>For high availability, select vSwitches in different zones.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the Kubernetes cluster for confidential computing.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class ModifyClusterNodePoolRequestTeeConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the confidential computing cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enables the cluster.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disables the cluster.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("tee_enable")]
            [Validation(Required=false)]
            public bool? TeeEnable { get; set; }

        }

        /// <summary>
        /// <para>Synchronously updates node labels and taints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("update_nodes")]
        [Validation(Required=false)]
        public bool? UpdateNodes { get; set; }

    }

}
