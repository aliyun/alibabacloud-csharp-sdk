// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterNodePoolRequest : Darabonba.Model {
        /// <summary>
        /// <para>The auto scaling configuration.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class ModifyClusterNodePoolRequestAutoScaling : Darabonba.Model {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b> Use internet_charge_type and internet_max_bandwidth_out instead. The peak bandwidth of the EIP.</para>
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
            /// <para><b>[Deprecated]</b> Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <para>The billing method of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>: Pay-by-bandwidth.</description></item>
            /// <item><description><c>PayByTraffic</c>: Pay-by-traffic.</description></item>
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
            /// <item><description><para><c>true</c>: Enables the auto scaling feature for the node pool. When the capacity planning of the cluster cannot meet the scheduling requirements of application pods, ACK automatically scales node resources based on the configured minimum and maximum instance counts. Clusters of version 1.24 or later use instant node scaling by default. Clusters of versions earlier than 1.24 use auto scaling by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node scaling</a>.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables auto scaling. ACK adjusts the number of nodes in the node pool based on the configured desired node count and maintains the node count at the desired value.</para>
            /// </description></item>
            /// </list>
            /// <para>When this parameter is set to false, other configuration parameters in <c>auto_scaling</c> do not take effect.</para>
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
            /// <para><b>[Deprecated]</b> This parameter is deprecated. Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Associates an EIP.</description></item>
            /// <item><description><c>false</c>: Does not associate an EIP.</description></item>
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
            /// <para>The maximum number of scalable instances in the node pool, excluding your existing instances. This parameter takes effect only when <c>enable=true</c>.</para>
            /// <para>Valid values: [min_instances, 2000]. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of scalable instances in the node pool, excluding your existing instances. This parameter takes effect only when <c>enable=true</c>.</para>
            /// <para>Valid values: [0, max_instances]. Default value: 0.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If the minimum number of instances is not 0, the corresponding number of ECS instances are automatically created after the scaling group takes effect.</description></item>
            /// <item><description>Set the maximum number of instances to a value that is not less than the current number of nodes in the node pool. Otherwise, nodes in the node pool are scaled in after the elastic scaling feature takes effect.</description></item>
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
            /// <para>The auto scaling type, classified by instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cpu</c>: Regular instance type.</description></item>
            /// <item><description><c>gpu</c>: GPU instance type.</description></item>
            /// <item><description><c>gpushare</c>: GPU sharing type.</description></item>
            /// <item><description><c>spot</c>: Spot instance type.</description></item>
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
        /// <para>Specifies whether to enable concurrency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public bool? Concurrency { get; set; }

        /// <summary>
        /// <para>The Lingjun AI Computing Service node pool configuration. (Not effective)</para>
        /// </summary>
        [NameInMap("eflo_node_group")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestEfloNodeGroup EfloNodeGroup { get; set; }
        public class ModifyClusterNodePoolRequestEfloNodeGroup : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to enable automatic addition of the Lingjun AI Computing Service node pool. (Not effective)</para>
            /// </summary>
            [NameInMap("auto_attach_enabled")]
            [Validation(Required=false)]
            public string AutoAttachEnabled { get; set; }

        }

        /// <summary>
        /// <para>The cluster-related configuration.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class ModifyClusterNodePoolRequestKubernetesConfig : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to install the CloudMonitor agent on ECS nodes. After installation, you can view monitoring information about the created ECS instances in the CloudMonitor console. We recommend that you enable this feature. Valid values:</para>
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
            /// <para>The CPU management policy for nodes. The following two policies are supported for clusters of version 1.12.6 and later:</para>
            /// <list type="bullet">
            /// <item><description><c>static</c>: Allows pods with certain resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.</description></item>
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
            /// <para>The node labels. You can add labels to the nodes in the Kubernetes cluster. Label definition rules:</para>
            /// <list type="bullet">
            /// <item><description>Labels are case-sensitive key-value pairs. You can set up to 20 labels.</description></item>
            /// <item><description>Label keys must be unique and can be up to 64 characters in length. Label values can be empty and can be up to 128 characters in length. Label keys and label values cannot start with <c>aliyun</c>, <c>acs:</c>, <c>https://</c>, or <c>http://</c>. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>The custom node name parameter. A node name consists of three parts: prefix + node IP + suffix.</para>
            /// <para>Both the prefix and suffix can consist of one or more parts separated by &quot;.&quot;. Each part can contain lowercase letters, digits, and hyphens (-). The node name must start and end with a lowercase letter or digit. The node IP is the complete private IP address of the node.</para>
            /// <para>The parameter contains four parts separated by commas. For example, if you pass in the string &quot;customized,aliyun,ip,com&quot; (where &quot;customized&quot; and &quot;ip&quot; are fixed strings, &quot;aliyun&quot; is the prefix, and &quot;com&quot; is the suffix), the node name is: aliyun.192.168.xxx.xxx.com.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customized,aliyun,ip,com</para>
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// <para>The pre-user data of the instance. Before a node joins the cluster, the specified pre-user data script is run. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User data scripts</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFDSyEi</para>
            /// </summary>
            [NameInMap("pre_user_data")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>The container runtime name. ACK supports the following three container runtimes:</para>
            /// <list type="bullet">
            /// <item><description>containerd: Recommended. Supported by all cluster versions.</description></item>
            /// <item><description>Sandboxed-Container.runv: Sandboxed container that provides higher isolation. Supported by clusters of version 1.31 and earlier.</description></item>
            /// <item><description>docker: No longer maintained. Supported by clusters of version 1.22 and earlier.</description></item>
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
            /// <para>The taint configuration for nodes.</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>Specifies whether the nodes added after the scale-out are unschedulable.</para>
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
            /// <para>The instance user data. After a node joins the cluster, the specified instance user data script is run. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User data scripts</a>.</para>
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
        public class ModifyClusterNodePoolRequestManagement : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to enable ECS fault detection for node self-healing.</para>
            /// </summary>
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically repair nodes. This parameter takes effect only when <c>enable=true</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables automatic repair.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables automatic repair.</para>
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
            /// <para>The auto repair node policy.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoRepairPolicy : Darabonba.Model {
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
                /// <para>The maximum number of parallel repairs. When a large number of unhealthy nodes exist in the node pool, this specifies the maximum number or percentage of nodes that can be repaired simultaneously. You can specify a quantity (such as 5, valid range: 1 to 100000) or a percentage (such as 10%, valid range: 1% to 100%). Default value on the backend: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("max_parallel_repairing_nodes")]
                [Validation(Required=false)]
                public string MaxParallelRepairingNodes { get; set; }

                /// <summary>
                /// <para>The self-healing circuit breaker condition. When the number or percentage of faulty nodes exceeds this threshold, self-healing enters a circuit breaker state and stops initiating new repair actions. You can specify a quantity (such as 10, valid range: 1 to 100000) or a percentage (such as 20%, valid range: 1% to 100%). Default circuit breaker condition on the backend: 100%.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20%</para>
                /// </summary>
                [NameInMap("max_unhealthy_nodes_threshold")]
                [Validation(Required=false)]
                public string MaxUnhealthyNodesThreshold { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restarts. This parameter takes effect only when <c>auto_repair=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allows node restarts.</description></item>
                /// <item><description><c>false</c>: Does not allow node restarts.</description></item>
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
            /// <para>Specifies whether to automatically upgrade nodes. This parameter takes effect only when <c>enable=true</c>.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables automatic upgrade.</description></item>
            /// <item><description><c>false</c>: Disables automatic upgrade.</description></item>
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
            /// <para>The auto upgrade policy.</para>
            /// </summary>
            [NameInMap("auto_upgrade_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoUpgradePolicy : Darabonba.Model {
                /// <summary>
                /// <para>Specifies whether to allow automatic kubelet upgrade. This parameter takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allows automatic kubelet upgrade.</description></item>
                /// <item><description><c>false</c>: Does not allow automatic kubelet upgrade.</description></item>
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
                /// <para>Specifies whether to allow automatic operating system upgrade. This parameter takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allows automatic operating system upgrade.</description></item>
                /// <item><description><c>false</c>: Does not allow automatic operating system upgrade.</description></item>
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
                /// <para>Specifies whether to allow automatic runtime upgrade. This parameter takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allows automatic runtime upgrade.</description></item>
                /// <item><description><c>false</c>: Does not allow automatic runtime upgrade.</description></item>
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
            /// <para>Specifies whether to automatically fix CVE vulnerabilities. This parameter takes effect only when <c>enable=true</c>.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Allows automatic CVE fixes.</description></item>
            /// <item><description><c>false</c>: Does not allow automatic CVE fixes.</description></item>
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
            /// <para>The auto CVE fix policy.</para>
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoVulFixPolicy : Darabonba.Model {
                /// <summary>
                /// <para>The packages to exclude during vulnerability fix.</para>
                /// <para>Default value: <c>kernel</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kernel</para>
                /// </summary>
                [NameInMap("exclude_packages")]
                [Validation(Required=false)]
                public string ExcludePackages { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restarts. This parameter takes effect only when <c>auto_vul_fix=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allows node restarts.</description></item>
                /// <item><description><c>false</c>: Does not allow node restarts.</description></item>
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
                /// <para>The vulnerability levels allowed for automatic fix, separated by commas. Example: <c>asap,later</c>. Supported vulnerability levels:</para>
                /// <list type="bullet">
                /// <item><description><c>asap</c>: high</description></item>
                /// <item><description><c>later</c>: medium</description></item>
                /// <item><description><c>nntf</c>: low</description></item>
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
            /// <para>Specifies whether to enable node rotation. Only intelligent managed node pools support this feature, and it is enabled by default. Common node pools do not support this feature.</para>
            /// </summary>
            [NameInMap("drift_enabled")]
            [Validation(Required=false)]
            public bool? DriftEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the managed node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables the managed node pool.</description></item>
            /// <item><description><c>false</c>: Disables the managed node pool. Other related configurations take effect only when <c>enable=true</c>.</description></item>
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
            /// <para><b>[Deprecated]</b> Use the <c>auto_upgrade</c> parameter at the upper level instead.</para>
            /// <para>The auto upgrade configuration. This parameter takes effect only when <c>enable=true</c>.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public ModifyClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class ModifyClusterNodePoolRequestManagementUpgradeConfig : Darabonba.Model {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para><b>[Deprecated]</b> Use the <c>auto_upgrade</c> parameter at the upper level instead.</para>
                /// <para>Specifies whether to enable automatic upgrade:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
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
                /// <para>Valid values: [1,1000\]</para>
                /// <para>Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// <para>The number of extra nodes. Specify either this parameter or <c>surge_percentage</c>.</para>
                /// <para>Nodes become unavailable during an upgrade. You can create extra nodes to compensate for the cluster load.</para>
                /// <remarks>
                /// <para>The number of extra nodes should not exceed the current number of nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>The percentage of extra nodes. Specify either this parameter or <c>surge</c>.</para>
                /// <para>Number of extra nodes = percentage of extra nodes × number of nodes. For example, if the percentage of extra nodes is set to 50% and 6 nodes exist, the number of extra nodes = 50% × 6 = 3.</para>
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
        public class ModifyClusterNodePoolRequestNodepoolInfo : Darabonba.Model {
            /// <summary>
            /// <para>The node pool name.</para>
            /// <para>Naming rules: The name must be 1 to 63 characters in length and can contain digits, Chinese characters, letters, and hyphens (-). It cannot start with a hyphen (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-nodepool</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource group ID of the node pool. Instances scaled out from the node pool belong to this resource group.</para>
            /// <para>A resource can belong to only one resource group. You can map resource groups to concepts such as projects, applications, or organizations based on different business scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjm****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// <para>The scaling group configuration of the node pool.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class ModifyClusterNodePoolRequestScalingGroup : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for nodes. This parameter takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Auto-renewal is enabled.</description></item>
            /// <item><description><c>false</c>: Auto-renewal is disabled.</description></item>
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
            /// <para>The auto-renewal period for a single renewal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When PeriodUnit=Week: 1, 2, and 3.</description></item>
            /// <item><description>When PeriodUnit=Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
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
            /// <para>When <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c>, specifies whether to allow the system to automatically create pay-as-you-go instances to meet the required number of ECS instances if spot instances cannot be created due to cost or inventory reasons. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Allows the system to automatically create pay-as-you-go instances to meet the required number of ECS instances.</description></item>
            /// <item><description><c>false</c>: Does not allow the system to automatically create pay-as-you-go instances to meet the required number of ECS instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("compensate_with_on_demand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// <para>The data cloud disk configurations for nodes. Valid values: 0 to 10. You can attach up to 10 data cloud disks.</para>
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// <para>The deployment set to which the ECS instances created by the node pool belong. This setting takes effect only for new nodes. The deployment set of existing nodes is not changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1d19mmbsv3jf6xxxxx</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>The desired number of nodes in the node pool.</para>
            /// <para>The total number of nodes that the node pool should maintain. Configure at least 2 nodes to ensure that cluster components run properly. You can scale the node pool in or out by adjusting the desired number of nodes.</para>
            /// <para>If you do not need to create nodes, set this parameter to 0 and manually adjust the value later to add nodes.</para>
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
            /// <para>Specifies whether to enable high-density cloud disk mode. This is supported only when the node pool uses instance types. When enabled, the total number of system cloud disks and data cloud disks does not exceed the high-density cloud disk count supported by the instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable_high_density_mode")]
            [Validation(Required=false)]
            public bool? EnableHighDensityMode { get; set; }

            /// <summary>
            /// <para>The custom image ID. You can call <c>DescribeKubernetesVersionMetadata</c> to query the images supported by the system. By default, the latest system image is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20241218.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The operating system distribution type. We recommend that you use this field to specify the node operating system. Valid values:</para>
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
            /// <para>The billing method of nodes in the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PrePaid</c>: subscription.</description></item>
            /// <item><description><c>PostPaid</c>: pay-as-you-go.</description></item>
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
            /// <para>The list of node instance types. You can select multiple instance types as alternatives. When each node is created, the system attempts to purchase instances starting from the first instance type until the creation succeeds. The actual instance type purchased may vary depending on inventory availability.</para>
            /// <para>Number of supported instance types: [1,10].</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The billing method for public IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>: billed by fixed bandwidth.</description></item>
            /// <item><description><c>PayByTraffic</c>: billed by traffic usage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The maximum outbound public bandwidth for nodes, in Mbps (Mega bit per second). Valid values: [1,100\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>The key pair name. Specify either this parameter or <c>login_password</c>. If the node pool is a managed node pool, only <c>key_pair</c> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pro-nodepool</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>The SSH logon password. Specify either this parameter or <c>key_pair</c>. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
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
            /// <item><description><para><c>PRIORITY</c>: scales in or out based on the vSwitches (VSwitchIds.N) that you define. When ECS instances cannot be created in the zone of the vSwitch with the highest priority, the system automatically uses the vSwitch with the next highest priority to create ECS instances.</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>: attempts to create instances in ascending order of vCPU unit price. When the scaling configuration sets multiple instance types with the spot billable methods, spot instances are created first. You can use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically attempt to create pay-as-you-go instances when spot instances cannot be created due to insufficient inventory.</para>
            /// <remarks>
            /// <para><c>COST_OPTIMIZED</c> takes effect only when the scaling configuration sets multiple instance types or uses spot instances.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>: evenly allocates ECS instances across the multiple active zones specified in the scaling group. If the zones become unbalanced due to insufficient inventory, you can call the <c>RebalanceInstances</c> API operation to rebalance resources. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a>.</para>
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
            /// <para>The minimum number of pay-as-you-go instances required in the scaling group. Valid values: [0,1000\]. Pay-as-you-go instances are created first when the number of pay-as-you-go instances is less than this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of pay-as-you-go instances among the excess instances after the minimum number of pay-as-you-go instances (<c>on_demand_base_capacity</c>) is met. Valid values: [0,100\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The subscription duration of nodes in the node pool. This parameter takes effect and is required only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <list type="bullet">
            /// <item><description>When <c>period_unit=Week</c>, valid values of <c>period</c>: 1, 2, 3, and 4.</description></item>
            /// <item><description>When <c>period_unit=Month</c>, valid values of <c>period</c>: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The billing cycle of nodes in the node pool. This parameter takes effect and is required only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <list type="bullet">
            /// <item><description><c>Month</c>: the billing cycle is measured in months.</description></item>
            /// <item><description><c>Week</c>: the billing cycle is measured in weeks.</description></item>
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
            /// <para><b>[Deprecated]</b> Use the <c>image_type</c> parameter instead.</para>
            /// <para>The operating system platform. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>AliyunLinux</c></description></item>
            /// <item><description><c>CentOS</c></description></item>
            /// <item><description><c>Windows</c></description></item>
            /// <item><description><c>WindowsCore</c></description></item>
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
            public class ModifyClusterNodePoolRequestScalingGroupPrivatePoolOptions : Darabonba.Model {
                /// <summary>
                /// <para>The private node pool ID. When <c>match_criteria</c> is set to <c>Target</c>, you must specify the private pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The private node pool type, which specifies the private pool capacity option for launching instances. After an elasticity assurance or capacity reservation takes effect, a private pool is generated for instance launches. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>Open</c>: Open mode. The system automatically matches open private pool capacity. If no matching private pool capacity is available, public pool resources are used.</description></item>
                /// <item><description><c>Target</c>: Targeted mode. The instance is launched using the specified private pool capacity. If the specified private pool capacity is unavailable, the instance fails to launch.</description></item>
                /// <item><description><c>None</c>: No private pool. The instance launch does not use private pool capacity.</description></item>
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
            /// <para>The list of ApsaraDB RDS instances.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>The resource pool and resource pool strategy used when creating instances. After you set this parameter, note the following:
            /// This parameter takes effect only when creating pay-as-you-go instances.
            /// This parameter cannot be set together with private_pool_options.match_criteria or private_pool_options.id.</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupResourcePoolOptions : Darabonba.Model {
                /// <summary>
                /// <para>The list of private pool IDs, which are elasticity assurance IDs or capacity reservation IDs. Only Target mode private pool IDs can be specified. Valid values of N: 1 to 20.</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>The resource pool strategy used when creating instances. Resource pools include private pools generated after an elasticity assurance or capacity reservation takes effect, as well as public pools, for instance launches. Valid values:
                /// PrivatePoolFirst: private pool first. When this strategy is selected, if resouce_pool_options.private_pool_ids is specified, the specified private pools are used first. If no private pool is specified or the specified private pool capacity is insufficient, open private pools are automatically matched. If no matching private pool is available, public pool resources are used to create instances.
                /// PrivatePoolOnly: private pool only. When this strategy is selected, you must specify resouce_pool_options.private_pool_ids. If the specified private pool capacity is insufficient, the instance fails to launch.
                /// None: no resource pool strategy is used.
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
            /// <item><description><c>release</c>: standard mode. Scales in or out by creating or releasing ECS instances based on resource usage.</description></item>
            /// <item><description><c>recycle</c>: swift mode. Scales in or out by creating, stopping, or starting ECS instances, which improves the speed of subsequent scaling operations. Stopped instances are not charged for compute resources, but storage fees still apply, except for instances with local disks.</description></item>
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
            /// <para>The number of available instance types. The scaling group creates spot instances of multiple types at the lowest cost. Valid values: [1,10\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable spot instance supplementation. If enabled, when a system message is received indicating that a spot instance will be reclaimed, the scaling group attempts to create a new instance to replace the spot instance that is to be reclaimed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables spot instance supplementation.</description></item>
            /// <item><description><c>false</c>: Disables spot instance supplementation.</description></item>
            /// </list>
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
            public List<ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit : Darabonba.Model {
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
                /// <para>The price limit per instance.</para>
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
            /// <list type="bullet">
            /// <item><description><c>NoSpot</c>: non-spot instance.</description></item>
            /// <item><description><c>SpotWithPriceLimit</c>: spot instance with a price limit.</description></item>
            /// <item><description><c>SpotAsPriceGo</c>: spot instance priced at the market price at the time of purchase.</description></item>
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
            /// <para>Specifies whether to enable burst (performance bursting) for the node system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled. After burst is enabled, the cloud disk temporarily improves its performance to handle sudden data read/write pressure from fluctuating workloads until the workload returns to a steady state.</description></item>
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
            /// <para>The multiple cloud disk types for the system cloud disk. If the cloud disk type with a higher priority cannot be used, the system automatically attempts the next priority cloud disk type to create the system cloud disk.</para>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The type of the node system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_efficiency</c>: ultra cloud disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
            /// <item><description><c>cloud_essd</c>: ESSD.</description></item>
            /// <item><description><c>cloud_auto</c>: ESSD AutoPL cloud disk.</description></item>
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry cloud disk.</description></item>
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
            /// <para>The encryption algorithm used by the system cloud disk. Valid value: aes-256.</para>
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
            /// <para>The KMS key ID used by the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("system_disk_kms_key_id")]
            [Validation(Required=false)]
            public string SystemDiskKmsKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the node system cloud disk. This parameter takes effect only for ESSD cloud disks. The performance level varies based on the cloud disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
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
            /// <para>The provisioned read/write IOPS of the node system cloud disk.</para>
            /// <para>Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}. Baseline performance = min{1,800 + 50 × capacity, 50000}.</para>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the node system cloud disk, in GiB.</para>
            /// <para>Valid values: [20,2048\].</para>
            /// <para>The value of this parameter must be greater than or equal to max{20, ImageSize}.</para>
            /// <para>Default value: max{40, image size corresponding to the ImageId parameter}.</para>
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
            /// <para>The tags that are added only to ECS instances.</para>
            /// <para>Tag keys cannot be duplicated and can be up to 128 characters in length. Tag keys and tag values cannot start with &quot;aliyun&quot; or &quot;acs:&quot;, or contain &quot;https://&quot; or &quot;http://&quot;.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>The list of vSwitch IDs. Valid values: 1 to 8.</para>
            /// <remarks>
            /// <para>To ensure high availability, select vSwitches in different zones.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The confidential computing cluster configuration.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class ModifyClusterNodePoolRequestTeeConfig : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to enable confidential computing for the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enabled.</description></item>
            /// <item><description><c>false</c>: Disabled.</description></item>
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
        /// <para>Specifies whether to synchronously update node labels and taints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("update_nodes")]
        [Validation(Required=false)]
        public bool? UpdateNodes { get; set; }

    }

}

