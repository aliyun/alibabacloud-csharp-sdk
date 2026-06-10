// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>The auto scaling configuration.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class ModifyClusterNodePoolRequestAutoScaling : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This field is deprecated. Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <para>The valid values are 1 to 100. The unit is Mbps.</para>
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
            /// <para>[Deprecated] Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <para>The billing method for the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PayByBandwidth</c>: Pay by bandwidth.</para>
            /// </description></item>
            /// <item><description><para><c>PayByTraffic</c>: Pay by traffic.</para>
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
            /// <para>Enable auto scaling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enable auto scaling. When cluster capacity is insufficient for pod scheduling, ACK automatically scales nodes based on the minimum and maximum instance counts you configure. For clusters running Kubernetes 1.24 or later, instant elasticity is enabled by default. For earlier versions, auto scaling is enabled by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node scaling</a>.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disable auto scaling. ACK adjusts the number of nodes in the node pool to match the desired node count you specify.</para>
            /// </description></item>
            /// </list>
            /// <para>When set to false, other parameters under <c>auto_scaling</c> are ignored.</para>
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
            /// <para>[Deprecated] Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Bind an EIP.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Do not bind an EIP.</para>
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
            /// <para>The maximum number of scalable instances in the node pool, excluding existing instances. This parameter takes effect only when <c>enable=true</c>.</para>
            /// <para>Valid values: [min_instances, 2000]. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of scalable instances in the node pool, excluding existing instances. This parameter takes effect only when <c>enable=true</c>.</para>
            /// <para>Valid values: [0, max_instances]. Default value: 0.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>If the minimum instance count is not zero, the system creates the specified number of ECS instances after the scaling group becomes active.</para>
            /// </description></item>
            /// <item><description><para>To avoid unintended scale-in, set the maximum instance count to at least the current number of nodes in the node pool.</para>
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
            /// <para>The auto scaling type, defined by instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cpu</c>: Standard instance.</para>
            /// </description></item>
            /// <item><description><para><c>gpu</c>: GPU instance.</para>
            /// </description></item>
            /// <item><description><para><c>gpushare</c>: GPU shared instance.</para>
            /// </description></item>
            /// <item><description><para><c>spot</c>: Spot instance.</para>
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
        /// <para>Whether to run concurrently.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public bool? Concurrency { get; set; }

        /// <summary>
        /// <para>The cluster-related configuration.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class ModifyClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>Install Cloud Monitor on ECS nodes. After installation, you can view monitoring information for the created ECS instances in the Cloud Monitor console. We recommend enabling this. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Install Cloud Monitor on ECS nodes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Do not install Cloud Monitor on ECS nodes.</para>
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
            /// <para>The node CPU management policy. The following two policies are supported for clusters of version 1.12.6 and later:</para>
            /// <list type="bullet">
            /// <item><description><para><c>static</c>: Allows pods with certain resource characteristics on the node to have enhanced CPU affinity and exclusivity.</para>
            /// </description></item>
            /// <item><description><para><c>none</c>: Enables the existing default CPU affinity scheme.</para>
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
            /// <para>Node labels. Add labels to Kubernetes cluster nodes. Label rules:</para>
            /// <list type="bullet">
            /// <item><description><para>Labels are case-sensitive key-value pairs. You can set up to 20 labels.</para>
            /// </description></item>
            /// <item><description><para>Tag keys must be unique and up to 64 characters long. Tag values can be empty and up to 128 characters long. Neither tag keys nor tag values can start with <c>aliyun</c>, <c>acs:</c>, <c>https://</c>, or <c>http://</c>. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>The custom node name parameter. A node name consists of three parts: prefix + node IP + suffix.</para>
            /// <para>The prefix and suffix can each consist of one or more parts separated by periods (.). Each part can contain lowercase letters, numbers, and hyphens (-). The node name must start and end with a lowercase letter or a number. The node IP is the complete private IP address of the node.</para>
            /// <para>The parameter is passed as four parts separated by commas. For example, if you pass the string &quot;customized,aliyun,ip,com&quot; (where &quot;customized&quot; and &quot;ip&quot; are fixed strings, &quot;aliyun&quot; is the prefix, and &quot;com&quot; is the suffix), the node name will be: aliyun.192.168.xxx.xxx.com.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customized,aliyun,ip,com</para>
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// <para>The instance pre-customization data. Before a node joins the cluster, it runs the specified pre-customization data script. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User-Data script</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFDSyEi</para>
            /// </summary>
            [NameInMap("pre_user_data")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>The container runtime name. ACK supports the following three container runtimes.</para>
            /// <list type="bullet">
            /// <item><description><para>containerd: Recommended. Supports all cluster versions.</para>
            /// </description></item>
            /// <item><description><para>Sandboxed-Container.runv: Sandboxed container. Provides higher isolation. Supports clusters of version 1.31 and earlier.</para>
            /// </description></item>
            /// <item><description><para>docker: No longer maintained. Supports clusters of version 1.22 and earlier.</para>
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
            /// <para>The container runtime version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.6.38</para>
            /// </summary>
            [NameInMap("runtime_version")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }

            /// <summary>
            /// <para>The node taint configuration.</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>Whether scaled-out nodes are unschedulable.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Unschedulable.</para>
            /// </description></item>
            /// <item><description><para>false: Schedulable.</para>
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
            /// <para>The instance user data. After a node joins the cluster, it runs the specified user data script. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User-Data script</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFDSyEi</para>
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
        public ModifyClusterNodePoolRequestManagement Management { get; set; }
        public class ModifyClusterNodePoolRequestManagement : TeaModel {
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>Enable automatic node repair. This parameter takes effect only when <c>enable=true</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enable automatic repair.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disable automatic repair.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// <para>The automatic node repair policy.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>Require manual approval for node repair.</para>
                /// </summary>
                [NameInMap("approval_required")]
                [Validation(Required=false)]
                public bool? ApprovalRequired { get; set; }

                /// <summary>
                /// <para>The automatic node repair policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("auto_repair_policy_id")]
                [Validation(Required=false)]
                public string AutoRepairPolicyId { get; set; }

                /// <summary>
                /// <para>Allow node restart. This parameter takes effect only when <c>auto_repair=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Allow node restart.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disallow node restart.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: <c>true</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

            }

            /// <summary>
            /// <para>Enable automatic node upgrades. This parameter takes effect only when <c>enable=true</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enable automatic upgrades.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disable automatic upgrades.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>true</c>.</para>
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
            public ModifyClusterNodePoolRequestManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>Enable automatic kubelet upgrades. This parameter takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enable automatic kubelet upgrades.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disable automatic kubelet upgrades.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: <c>true</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

                /// <summary>
                /// <para>Enable automatic operating system upgrades. This parameter takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enable automatic OS upgrades.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disable automatic OS upgrades.</para>
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
                /// <para>Enable automatic runtime upgrades. This parameter takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enable automatic runtime upgrades.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disable automatic runtime upgrades.</para>
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
            /// <para>Enable automatic CVE vulnerability fixes. This parameter takes effect only when <c>enable=true</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enable automatic CVE fixes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disable automatic CVE fixes.</para>
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
            /// <para>The automatic CVE fix policy.</para>
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>Packages to exclude during vulnerability fixes.</para>
                /// <para>Default value: <c>kernel</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kernel</para>
                /// </summary>
                [NameInMap("exclude_packages")]
                [Validation(Required=false)]
                public string ExcludePackages { get; set; }

                /// <summary>
                /// <para>Allow node restart. This parameter takes effect only when <c>auto_vul_fix=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Allow node restart.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disallow node restart.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: <c>true</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// <para>The severity levels of vulnerabilities that can be fixed automatically, separated by commas. Example: <c>asap,later</c>. Supported levels:</para>
                /// <list type="bullet">
                /// <item><description><para><c>asap</c>: High</para>
                /// </description></item>
                /// <item><description><para><c>later</c>: Medium</para>
                /// </description></item>
                /// <item><description><para><c>nntf</c>: Low</para>
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
            /// <para>Enable the managed node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enable the managed node pool.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disable the managed node pool. Other related configurations take effect only when <c>enable=true</c>.</para>
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
            /// <para>[Deprecated] Use the top-level <c>auto_upgrade</c> parameter instead.</para>
            /// <para>The automatic upgrade configuration. This parameter takes effect only when <c>enable=true</c>.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public ModifyClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class ModifyClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>[Deprecated] Use the top-level <c>auto_upgrade</c> parameter instead.</para>
                /// <para>Enable automatic upgrades. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enable.</para>
                /// </description></item>
                /// <item><description><para>false: Disable.</para>
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
                /// <para>Valid values: [1, 1000].</para>
                /// <para>Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// <para>The number of additional nodes. Choose either surge or <c>surge_percentage</c>.</para>
                /// <para>Nodes become unavailable during upgrades. Create extra nodes to maintain cluster load.</para>
                /// <remarks>
                /// <para>Do not create more extra nodes than the current number of nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>The percentage of additional nodes. Choose either surge or surge_percentage. The number of additional nodes equals <c>surge_percentage</c> × the number of nodes. For example, if <c>surge_percentage</c> is 50% and there are 6 nodes, then 3 additional nodes are created.</para>
                /// <para>The number of additional nodes = The percentage of additional nodes × The number of nodes in the node pool. For example, if the percentage of additional nodes is 50% and the number of nodes in the node pool is 6, the number of additional nodes is 3.</para>
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
        /// <para>The node pool configuration.</para>
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class ModifyClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// <para>The node pool name.</para>
            /// <para>Name rules: Use only numbers, letters, or hyphens (-). The name must be 1 to 63 characters long and cannot start with a hyphen (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-nodepool</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource group ID for the node pool. Nodes created from this node pool belong to this resource group.</para>
            /// <para>A resource can belong to only one resource group. Map resource groups to projects, applications, or organizations based on your business needs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjm****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// <para>Node pool scaling group configuration.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class ModifyClusterNodePoolRequestScalingGroup : TeaModel {
            /// <summary>
            /// <para>Enable automatic renewal for nodes. This parameter takes effect only when <c>instance_charge_type</c> is <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enable automatic renewal.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disable automatic renewal.</para>
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
            /// <para>The duration of each automatic renewal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>When PeriodUnit=Week: 1, 2, 3.</para>
            /// </description></item>
            /// <item><description><para>When PeriodUnit=Month: 1, 2, 3, 6, 12, 24, 36, 48, 60.</para>
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
            /// <para>When <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c>, this parameter specifies whether to automatically create on-demand instances to meet the required number of ECS instances if enough spot instances cannot be created due to price or inventory issues. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Allow automatic creation of on-demand instances.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disallow automatic creation of on-demand instances.</para>
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
            /// <para>The data disk configuration for nodes. Valid values: [0, 10]. You can attach up to 10 data disks.</para>
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// <para>The deployment set to which the ECS instances created in the node pool belong. This setting applies only to new nodes. The deployment set of existing nodes is not changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1d19mmbsv3jf6xxxxx</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>The desired number of nodes in the node pool.</para>
            /// <para>This is the total number of nodes the node pool should maintain. Configure at least 2 nodes to ensure cluster components run properly. Adjust this number to scale the node pool in or out.</para>
            /// <para>If you do not need to create nodes, set this to 0 and adjust it manually later.</para>
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
            /// <para>The custom image ID. Query supported images using <c>DescribeKubernetesVersionMetadata</c>. By default, the latest system image is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20241218.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The operating system distribution type. We recommend using this field to specify the node OS. Valid values:</para>
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
            /// <item><description><para><c>WindowsCore</c>: Windows Core image.</para>
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
            /// <para>The billing method for nodes in the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PrePaid</c>: Subscription.</para>
            /// </description></item>
            /// <item><description><para><c>PostPaid</c>: Pay-as-you-go.</para>
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
            /// <para>The instance attribute configuration.</para>
            /// </summary>
            [NameInMap("instance_patterns")]
            [Validation(Required=false)]
            public List<InstancePatterns> InstancePatterns { get; set; }

            /// <summary>
            /// <para>The list of instance types for the nodes. You can specify multiple instance types as fallback options. When creating a node, the system tries each instance type in order until it succeeds. The final instance type may vary depending on inventory.</para>
            /// <para>Valid values: [1, 10].</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The billing method for public IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PayByBandwidth</c>: Pay by bandwidth.</para>
            /// </description></item>
            /// <item><description><para><c>PayByTraffic</c>: Pay by traffic.</para>
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
            /// <para>The maximum outbound bandwidth for the public IP address of a node, measured in megabits per second (Mbps). The value must be an integer from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>The key pair name. Specify either key_pair or <c>login_password</c>. For managed node pools, only <c>key_pair</c> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pro-nodepool</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>The SSH login password. Specify either login_password or <c>key_pair</c>. Password rules: 8 to 30 characters, including at least three of the following: uppercase letters, lowercase letters, digits, and special characters.</para>
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
            /// <item><description><para><c>PRIORITY</c>: Scales instances based on the virtual switches (VSwitchIds.N) you define. If an ECS instance cannot be created in the zone of a higher-priority virtual switch, the system automatically uses the next-priority virtual switch.</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>: Tries to create instances starting with the lowest vCPU unit price. If multiple instance types are configured with a spot instance billing method, it prioritizes creating spot instances. Use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically create on-demand instances if spot instances cannot be created due to inventory or other reasons.</para>
            /// <remarks>
            /// <para><c>COST_OPTIMIZED</c> takes effect only when multiple instance types or spot instances are configured.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>: Evenly distributes ECS instances across the specified zones in the scaling group. If the distribution becomes unbalanced due to inventory shortages or other reasons, you can use the API <c>RebalanceInstances</c> to rebalance the resources. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a>.</para>
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
            /// <para>The minimum number of on-demand instances required in the scaling group. Valid values: [0, 1000]. When the number of on-demand instances is below this value, the system prioritizes creating on-demand instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of on-demand instances among the instances that exceed the minimum on-demand instance count (<c>on_demand_base_capacity</c>). Valid values: [0, 100].</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The subscription duration for nodes in the node pool. This parameter takes effect only when <c>instance_charge_type</c> is <c>PrePaid</c>, and is required in that case.</para>
            /// <list type="bullet">
            /// <item><description><para>When <c>period_unit=Week</c>, valid values: {1, 2, 3, 4}.</para>
            /// </description></item>
            /// <item><description><para>When <c>period_unit=Month</c>, valid values: {1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, 60}.</para>
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
            /// <para>The billing cycle for nodes in the node pool. This parameter takes effect only when <c>instance_charge_type</c> is <c>PrePaid</c>, and is required in that case.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Month</c>: Billed monthly.</para>
            /// </description></item>
            /// <item><description><para><c>Week</c>: Billed weekly.</para>
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
            /// <para>[Deprecated] Use the <c>image_type</c> parameter instead.</para>
            /// <para>The operating system platform. Valid values:</para>
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
            /// <para>The private node pool configuration.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// <para>The private node pool ID. This is required when <c>match_criteria</c> is set to <c>Target</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The private node pool type, which determines the capacity option for instance startup. Elastic assurance services or capacity reservation services generate private pool capacity for instance startup. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Open</c>: Open mode. Automatically matches open-type private pool capacity. If no suitable private pool is found, public pool resources are used.</para>
                /// </description></item>
                /// <item><description><para><c>Target</c>: Specified mode. Starts instances using the specified private pool capacity. If the capacity is unavailable, the instance startup fails.</para>
                /// </description></item>
                /// <item><description><para><c>None</c>: No mode. The instance startup does not use private pool capacity.</para>
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
            /// <para>The list of RDS instances.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>The resource pool and policy to use when creating instances. Note: This parameter is effective only when creating pay-as-you-go instances. It cannot be set at the same time as private_pool_options.match_criteria or private_pool_options.id.</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>The list of private pool IDs, which are the IDs of elastic assurance or capacity reservation services. You can only pass Target mode private pool IDs. The value of N can range from 1 to 20.</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>The resource pool policy for instance creation. Resource pools include private pools generated by elastic assurance or capacity reservation services, and public pools. Valid values: PrivatePoolFirst: Prioritizes private pools. If resouce_pool_options.private_pool_ids is specified, it uses the specified private pools first. If no private pool is specified or the specified capacity is insufficient, it automatically matches open-type private pools. If no suitable private pool is found, it uses the public pool. PrivatePoolOnly: Uses only private pools. You must specify resouce_pool_options.private_pool_ids. If the specified private pool capacity is insufficient, the instance startup fails. None: Does not use a resource pool policy. Default value: None.</para>
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
            /// <item><description><para><c>release</c>: Standard mode. Scales by creating and releasing ECS instances based on resource usage.</para>
            /// </description></item>
            /// <item><description><para><c>recycle</c>: Fast mode. Scales by creating, stopping, and starting instances to improve scaling speed. You are not charged for compute resources when instances are stopped, only for storage fees (except for local disk models).</para>
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
            /// <para>The list of security group IDs.</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The number of available instance types. The scaling group creates spot instances in a balanced manner across the specified number of lowest-cost instance types. Valid values: [1, 10].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Enable spot instance replenishment. When enabled, the scaling group attempts to create a new instance to replace a spot instance that is about to be reclaimed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enable spot instance replenishment.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disable spot instance replenishment.</para>
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
            /// <para>The price range configuration for spot instances.</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
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
                /// <para>The maximum hourly price for the instance.</para>
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
            /// <para>The spot instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>NoSpot</c>: On-demand instance.</para>
            /// </description></item>
            /// <item><description><para><c>SpotWithPriceLimit</c>: Set a price limit for spot instances.</para>
            /// </description></item>
            /// <item><description><para><c>SpotAsPriceGo</c>: Let the system automatically bid at the current market price.</para>
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
            /// <para>Enable bursting for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable. During sudden spikes in read/write activity, the disk temporarily boosts performance until workloads return to normal.</para>
            /// </description></item>
            /// <item><description><para>false: Disable.</para>
            /// </description></item>
            /// </list>
            /// <para>You can set this parameter only when <c>system_disk_category</c> is <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disk</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The list of system disk types. If the highest-priority disk type is unavailable, the system tries the next priority disk type.</para>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The system disk type for nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cloud_efficiency</c>: Ultra disk.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_ssd</c>: Standard SSD.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_essd</c>: Enhanced SSD (ESSD).</para>
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
            /// <para>The encryption algorithm for the system disk. Valid value: aes-256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes-256</para>
            /// </summary>
            [NameInMap("system_disk_encrypt_algorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Encrypt.</para>
            /// </description></item>
            /// <item><description><para>false: Do not encrypt.</para>
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
            /// <para>The KMS key ID for the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("system_disk_kms_key_id")]
            [Validation(Required=false)]
            public string SystemDiskKmsKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the system disk. This setting applies only to ESSD disks. Performance level depends on disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">Enhanced SSD (ESSD)</a>.</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: Moderate I/O performance with stable read/write latency.</para>
            /// </description></item>
            /// <item><description><para>PL1: Moderate I/O performance with stable read/write latency.</para>
            /// </description></item>
            /// <item><description><para>PL2: High I/O performance with stable read/write latency.</para>
            /// </description></item>
            /// <item><description><para>PL3: Extremely high I/O performance with extremely stable read/write latency.</para>
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
            /// <para>The provisioned IOPS for the system disk.</para>
            /// <para>Possible values: 0 to min{50,000, 1000 × capacity − baseline performance}. Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
            /// <para>You can set this parameter only when <c>system_disk_category</c> is <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disk</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk for nodes. Unit: GiB.</para>
            /// <para>Valid values: [20, 2048].</para>
            /// <para>This value must be greater than or equal to max{20, ImageSize}.</para>
            /// <para>Default value: max{40, image size corresponding to ImageId}.</para>
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
            /// <para>Add tags to ECS instances only.</para>
            /// <para>Tag keys must be unique and up to 128 characters long. Neither tag keys nor tag values can start with &quot;aliyun&quot;, &quot;acs:&quot;, or contain &quot;https\://&quot; or &quot;http\://&quot;.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>The list of virtual switch IDs. Valid values: [1, 8].</para>
            /// <remarks>
            /// <para>To ensure high availability, select virtual switches from different zones.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The configuration of the Kubernetes cluster for confidential computing.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class ModifyClusterNodePoolRequestTeeConfig : TeaModel {
            /// <summary>
            /// <para>Enable the Kubernetes cluster for confidential computing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enable.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disable.</para>
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
        /// <para>Synchronously update node labels and taints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("update_nodes")]
        [Validation(Required=false)]
        public bool? UpdateNodes { get; set; }

    }

}
