// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>Auto scaling configuration.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class ModifyClusterNodePoolRequestAutoScaling : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>[This field is deprecated] Please use internet_charge_type and internet_max_bandwidth_out instead.
            /// EIP peak bandwidth.</para>
            /// <para>Valid values: [1,100]. Unit: Mbps.</para>
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
            /// <para>[This field is deprecated] Please use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <para>EIP billing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>: Pay by fixed bandwidth.</description></item>
            /// <item><description><c>PayByTraffic</c>: Pay by traffic usage.</description></item>
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
            /// <para>Whether to enable auto scaling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enable node pool auto scaling. When the cluster\&quot;s capacity planning cannot meet application Pod scheduling requirements, ACK automatically scales node resources based on the configured minimum and maximum instance counts. Clusters with version 1.24 and above enable instant node elasticity by default;
            /// clusters with versions below 1.24 enable node auto scaling by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node Scaling</a>.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disable auto scaling. ACK adjusts the number of nodes in the node pool according to the configured desired node count, always maintaining the node count at the desired number.</para>
            /// </description></item>
            /// </list>
            /// <para>When the value is false, other configuration parameters in <c>auto_scaling</c> will not take effect.</para>
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
            /// <para>[This field is deprecated] This field is deprecated. Please use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Bindpublic EIP.</description></item>
            /// <item><description><c>false</c>: Do not bind EIP.</description></item>
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
            /// <para>The maximum number of scalable instances in the node pool, excluding your existing instances. Only takes effect when <c>enable=true</c>.</para>
            /// <para>Valid values: [min_instances, 2000]. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of scalable instances in the node pool, excluding your existing instances. Only takes effect when <c>enable=true</c>.</para>
            /// <para>Valid values: [0, max_instances]. Default value: 0.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>When the minimum number of instances is not 0, the corresponding number of ECS instances will be automatically created after the scaling group takes effect.</description></item>
            /// <item><description>It is recommended that the configured maximum number of instances is not less than the current number of nodes in the node pool. Otherwise, the elastic scaling function will directly cause the node pool to scale in after taking effect.</description></item>
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
            /// <para>Auto scaling type, classified by auto scaling instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cpu</c>: Regular instance type.</description></item>
            /// <item><description><c>gpu</c>: GPU instance type.</description></item>
            /// <item><description><c>gpushare</c>: GPU sharing type.</description></item>
            /// <item><description><c>spot</c>: Preemptible instance type.</description></item>
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
        /// <para>Cluster-related configuration.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class ModifyClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>Whether to install CloudMonitor on ECS nodes. After installation, you can view monitoring information of the created ECS instances in the CloudMonitor console. Recommended to enable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Install CloudMonitor on ECS nodes.</description></item>
            /// <item><description><c>false</c>: Do not install CloudMonitor on ECS nodes.</description></item>
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
            /// <para>Node CPU management policy. Supported when the cluster version is 1.12.6 or above:</para>
            /// <list type="bullet">
            /// <item><description><c>static</c>: Allows enhancing CPU affinity and exclusivity for Pods with certain resource characteristics on the node.</description></item>
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
            /// <para>Node labels. Add labels to Kubernetes cluster nodes. Label definition rules:</para>
            /// <list type="bullet">
            /// <item><description>Labels are case-sensitive key-value pairs. You can set up to 20 labels.</description></item>
            /// <item><description>Label keys cannot be duplicated and can be up to 64 characters. Label values can be empty and up to 128 characters. Label keys and values cannot start with <c>aliyun</c>, <c>acs:</c>, <c>https://</c>, or <c>http://</c>. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>Custom node name parameter. The node name consists of three parts: prefix + node IP + suffix.</para>
            /// <para>Both the prefix and suffix can consist of one or more parts separated by &quot;.&quot;. Each part can use lowercase letters, digits, and &quot;-&quot;. The node name must start and end with a lowercase letter or digit. The node IP is the complete private IP address of the node.</para>
            /// <para>The parameter includes four parts separated by commas. For example, passing &quot;customized,aliyun,ip,com&quot; (where &quot;customized&quot; and &quot;ip&quot; are fixed strings, aliyun is the prefix, and com is the suffix), the node name will be: aliyun.192.168.xxx.xxx.com.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customized,aliyun,ip,com</para>
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// <para>Instance pre-custom data. Before the node joins the cluster, the specified instance pre-custom data script will be run. See <a href="https://help.aliyun.com/document_detail/49121.html">User-Data scripts</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFDSyEi</para>
            /// </summary>
            [NameInMap("pre_user_data")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>Container runtime name. ACK supports the following three container runtimes:</para>
            /// <list type="bullet">
            /// <item><description>containerd: Recommended. Supports all cluster versions.</description></item>
            /// <item><description>Sandboxed-Container.runv: Sandboxed container, providing higher isolation. Supports clusters with version 1.31 and below.</description></item>
            /// <item><description>docker: Maintenance discontinued. Supports clusters with version 1.22 and below.</description></item>
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
            /// <para>Container runtime version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.6.38</para>
            /// </summary>
            [NameInMap("runtime_version")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }

            /// <summary>
            /// <para>Node taint configuration.</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>Whether the node is unschedulable after scaling out.</para>
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
            /// <para>Instance custom data. After the node joins the cluster, the specified instance custom data script will be run. See <a href="https://help.aliyun.com/document_detail/49121.html">User-Data scripts</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFDSyEi</para>
            /// </summary>
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>Managed node pool configuration.</para>
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestManagement Management { get; set; }
        public class ModifyClusterNodePoolRequestManagement : TeaModel {
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>Whether to automatically repair nodes. Only takes effect when <c>enable=true</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Auto repair.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Do not auto repair.</para>
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
            /// <para>Auto repair node policy.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>Whether node repair requires manual approval.</para>
                /// </summary>
                [NameInMap("approval_required")]
                [Validation(Required=false)]
                public bool? ApprovalRequired { get; set; }

                /// <summary>
                /// <para>Auto repair policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("auto_repair_policy_id")]
                [Validation(Required=false)]
                public string AutoRepairPolicyId { get; set; }

                /// <summary>
                /// <para>Whether to allow restarting nodes. Only takes effect when <c>auto_repair=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allow restarting nodes.</description></item>
                /// <item><description><c>false</c>: Do not allow restarting nodes.</description></item>
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
            /// <para>Whether to automatically upgrade nodes. Only takes effect when <c>enable=true</c>.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enable auto upgrade.</description></item>
            /// <item><description><c>false</c>: Disable auto upgrade.</description></item>
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
            /// <para>Auto upgrade policy.</para>
            /// </summary>
            [NameInMap("auto_upgrade_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>Whether to allow auto upgrading kubelet. Only takes effect when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allow auto upgrading kubelet.</description></item>
                /// <item><description><c>false</c>: Do not allow auto upgrading kubelet.</description></item>
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
                /// <para>Whether to allow auto upgrading the operating system. Only takes effect when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allow auto upgrading the operating system.</description></item>
                /// <item><description><c>false</c>: Do not allow auto upgrading the operating system.</description></item>
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
                /// <para>Whether to allow auto upgrading the runtime. Only takes effect when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allow auto upgrading the runtime.</description></item>
                /// <item><description><c>false</c>: Do not allow auto upgrading the runtime.</description></item>
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
            /// <para>Whether to automatically fix CVE vulnerabilities. Only takes effect when <c>enable=true</c>.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Allow automatic CVE fixing.</description></item>
            /// <item><description><c>false</c>: Do not allow automatic CVE fixing.</description></item>
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
            /// <para>Auto CVE fix policy.</para>
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies the packages to be excluded during vulnerability fix.</para>
                /// <para>Default value: <c>kernel</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kernel</para>
                /// </summary>
                [NameInMap("exclude_packages")]
                [Validation(Required=false)]
                public string ExcludePackages { get; set; }

                /// <summary>
                /// <para>Whether to allow restarting nodes. Only takes effect when <c>auto_vul_fix=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Allow restarting nodes.</description></item>
                /// <item><description><c>false</c>: Do not allow restarting nodes.</description></item>
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
                /// <para>Vulnerability levels allowed for automatic fixing, separated by commas. For example: <c>asap,later</c>. Supported vulnerability levels:</para>
                /// <list type="bullet">
                /// <item><description><c>asap</c>: High</description></item>
                /// <item><description><c>later</c>: Medium</description></item>
                /// <item><description><c>nntf</c>: Low</description></item>
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
            /// <para>Whether to enable managed node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enable managed node pool.</description></item>
            /// <item><description><c>false</c>: Disable managed node pool. Other related configurations only take effect when <c>enable=true</c>.</description></item>
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
            /// <para>[This field is deprecated] Please use the <c>auto_upgrade</c> parameter at the parent level instead.</para>
            /// <para>Auto upgrade configuration. Only takes effect when <c>enable=true</c>.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public ModifyClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class ModifyClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>[This field is deprecated] Please use the <c>auto_upgrade</c> parameter at the parent level instead.</para>
                /// <para>Whether to enable auto upgrade:</para>
                /// <list type="bullet">
                /// <item><description>true: Enable.</description></item>
                /// <item><description>false: Disable.</description></item>
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
                /// <para>Maximum number of unavailable nodes.</para>
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
                /// <para>Number of extra nodes. Mutually exclusive with <c>surge_percentage</c>.</para>
                /// <para>During upgrade, nodes will be unavailable. You can create extra nodes to compensate for the cluster workload.</para>
                /// <remarks>
                /// <para>It is recommended that the number of extra nodes does not exceed the current number of nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>Percentage of extra nodes. Mutually exclusive with <c>surge</c>.</para>
                /// <para>Number of extra nodes = percentage of extra nodes × number of nodes. For example, if the percentage of extra nodes is set to 50% and there are 6 existing nodes, the number of extra nodes = 50% × 6, which produces 3 extra nodes.</para>
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
        /// <para>Node pool configuration.</para>
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class ModifyClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// <para>Node pool name.</para>
            /// <para>Naming rules: The name can contain digits, Chinese characters, English letters, or hyphens (-), must be 1 to 63 characters in length, and cannot start with a hyphen (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-nodepool</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource group ID of the node pool. Instances created by the node pool will belong to this resource group.</para>
            /// <para>A resource can only belong to one resource group. Depending on different business scenarios, you can map a resource group to concepts such as projects, applications, or organizations.</para>
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
            /// <para>Whether to enable auto renewal for nodes. Only takes effect when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enable auto renewal.</description></item>
            /// <item><description><c>false</c>: Disable auto renewal.</description></item>
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
            /// <para>Duration of each auto renewal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When PeriodUnit=Week: 1, 2, 3.</description></item>
            /// <item><description>When PeriodUnit=Month: 1, 2, 3, 6, 12, 24, 36, 48, 60.</description></item>
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
            /// <para>When <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c>, whether to allow automatically creating pay-as-you-go instances to meet ECS instance count requirements when sufficient preemptible instances cannot be created due to price, inventory, or other reasons. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Allow automatically creating pay-as-you-go instances to meet ECS instance count requirements.</description></item>
            /// <item><description><c>false</c>: Do not allow automatically creating pay-as-you-go instances to meet ECS instance count requirements.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("compensate_with_on_demand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// <para>Node data disk configuration. Valid values: [0,10\]. You can add up to 10 data disks.</para>
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// <para>The deployment set that the ECS instances created by the node pool belong to. Only takes effect for incremental nodes; the deployment set of existing nodes will not be changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1d19mmbsv3jf6xxxxx</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>Desired number of nodes in the node pool.</para>
            /// <para>The total number of nodes that the node pool should maintain. It is recommended to configure at least 2 nodes to ensure cluster components run normally. You can scale the node pool in or out by adjusting the desired node count.</para>
            /// <para>If you do not need to create nodes, you can set this to 0 and manually adjust it later to add nodes.</para>
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
            /// <para>Custom image ID. You can query system-supported images through <c>DescribeKubernetesVersionMetadata</c>. The latest system image is used by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20241218.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>Operating system distribution type. It is recommended to use this field to specify the node operating system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>AliyunLinux</c>: Alinux2 image.</description></item>
            /// <item><description><c>AliyunLinuxSecurity</c>: Alinux2 image UEFI version.</description></item>
            /// <item><description><c>AliyunLinux3</c>: Alinux3 image.</description></item>
            /// <item><description><c>AliyunLinux3Arm64</c>: Alinux3 image ARM version.</description></item>
            /// <item><description><c>AliyunLinux3Security</c>: Alinux3 image UEFI version.</description></item>
            /// <item><description><c>CentOS</c>: CentOS image.</description></item>
            /// <item><description><c>Windows</c>: Windows image.</description></item>
            /// <item><description><c>WindowsCore</c>: WindowsCore image.</description></item>
            /// <item><description><c>ContainerOS</c>: Container-optimized image.</description></item>
            /// <item><description><c>AliyunLinux3ContainerOptimized</c>: Alinux3 image container-optimized version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux3</para>
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>Billing type for node pool nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PrePaid</c>: Subscription.</description></item>
            /// <item><description><c>PostPaid</c>: Pay-as-you-go.</description></item>
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
            /// <para>Instance attribute configuration.</para>
            /// </summary>
            [NameInMap("instance_patterns")]
            [Validation(Required=false)]
            public List<InstancePatterns> InstancePatterns { get; set; }

            /// <summary>
            /// <para>List of node instance types. You can select multiple instance types as alternatives. When creating each node, the system attempts to purchase starting from the first type until successful. The final purchased instance type may vary depending on inventory.</para>
            /// <para>Supported number of instance types: [1,10].</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>Public IP billing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>: Pay by fixed bandwidth.</description></item>
            /// <item><description><c>PayByTraffic</c>: Pay by traffic usage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>Maximum outbound bandwidth for node public IP, in Mbps (Mega bit per second). Valid values: [1,100\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>Key pair name. Mutually exclusive with <c>login_password</c>. When the node pool is a managed node pool, only <c>key_pair</c> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pro-nodepool</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>SSH login password. Mutually exclusive with <c>key_pair</c>. Password must be 8 to 30 characters and contain at least three of the following: uppercase letters, lowercase letters, digits, and special characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello1234</para>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>Multi-AZ scaling group ECS instance scaling policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PRIORITY</c>: Scale based on the vSwitches (VSwitchIds.N) you defined. When ECS instances cannot be created in the availability zone of the higher-priority vSwitch, the next priority vSwitch is automatically used to create ECS instances.</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>: Create instances by trying from the lowest vCPU unit price. When the scaling configuration has set preemptible billing with multiple instance types, preemptible instances are created preferentially. You can further use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically try creating pay-as-you-go instances when preemptible instances cannot be created due to inventory or other reasons.</para>
            /// <remarks>
            /// <para><c>COST_OPTIMIZED</c> only takes effect when the scaling configuration has set multiple instance types or selected preemptible instances.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>: Evenly distribute ECS instances across multiple availability zones specified by the scaling group. If the zones become unbalanced due to insufficient inventory or other reasons, you can use the API <c>RebalanceInstances</c> to rebalance resources. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a>.</para>
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
            /// <para>Minimum number of pay-as-you-go instances required by the scaling group. Valid values: [0,1000\]. Pay-as-you-go instances are created preferentially when the number of pay-as-you-go instances is less than this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>After the scaling group meets the minimum pay-as-you-go instance requirement (<c>on_demand_base_capacity</c>), the proportion of pay-as-you-go instances among the excess instances. Valid values: [0,100\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>Subscription duration for node pool nodes. Only takes effect when <c>instance_charge_type</c> is set to <c>PrePaid</c>, and is required.</para>
            /// <list type="bullet">
            /// <item><description>When <c>period_unit=Week</c>, valid values for <c>period</c>: {1, 2, 3, 4}.</description></item>
            /// <item><description>When <c>period_unit=Month</c>, valid values for <c>period</c>: {1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, 60}.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>Billing cycle for node pool nodes. Only takes effect when <c>instance_charge_type</c> is set to <c>PrePaid</c>, and is required.</para>
            /// <list type="bullet">
            /// <item><description><c>Month</c>: Billed by month.</description></item>
            /// <item><description><c>Week</c>: Billed by week.</description></item>
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
            /// <para>[This field is deprecated] Please use the <c>image_type</c> parameter instead.</para>
            /// <para>Operating system platform. Valid values:</para>
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
            /// <para>Private node pool configuration.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// <para>Private node pool ID. When <c>match_criteria</c> is <c>Target</c>, you need to further specify the private pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Private node pool type. Private pool capacity option for instance launch. After an Elasticity Assurance or Capacity Reservation takes effect, a private pool capacity is generated for instance launch selection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>Open</c>: Open mode. Automatically matches open-type private pool capacity. If no matching private pool capacity is available, public pool resources are used for launch.</description></item>
                /// <item><description><c>Target</c>: Targeted mode. Uses specified private pool capacity to launch instances. If the private pool capacity is unavailable, instance launch fails.</description></item>
                /// <item><description><c>None</c>: Do not use mode. Instance launch will not use private pool capacity.</description></item>
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
            /// <para>RDS instance list.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>Resource pool and resource pool policy used when creating instances. Note the following when setting this parameter:
            /// This parameter only takes effect when creating pay-as-you-go instances.
            /// This parameter cannot be set together with private_pool_options.match_criteria or private_pool_options.id.</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>List of private pool IDs, i.e., Elasticity Assurance IDs or Capacity Reservation IDs. Only Target mode private pool IDs can be passed. Valid values for N: 1~20.</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>Resource pool policy used when creating instances. Resource pools include private pools generated after Elasticity Assurance or Capacity Reservation takes effect, as well as public pools, for instance launch selection. Valid values:
                /// PrivatePoolFirst: Private pool first. When specified private_pool_ids are set, the specified private pools are used preferentially. If no private pool is specified or the specified private pool capacity is insufficient, open-type private pools are automatically matched. If no matching private pool is available, public pool resources are used to create instances.
                /// PrivatePoolOnly: Private pool only. private_pool_ids must be specified. If the specified private pool capacity is insufficient, instance launch fails.
                /// None: Do not use resource pool policy.
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
            /// <para>Scaling group mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>release</c>: Standard mode. Scale by creating and releasing ECS instances based on resource usage.</description></item>
            /// <item><description><c>recycle</c>: Swift mode. Scale by creating, stopping, and starting instances to improve subsequent scaling speed (compute resources are not charged during shutdown, only storage fees apply, except for local disk instance types).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>release</para>
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// <para>List of security group IDs.</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>Number of available instance types. The scaling group creates preemptible instances evenly across the lowest-cost instance types. Valid values: [1,10\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Whether to enable supplementing preemptible instances. When enabled, the scaling group attempts to create new instances to replace preemptible instances that are about to be reclaimed upon receiving a system notification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enable supplementing preemptible instances.</description></item>
            /// <item><description><c>false</c>: Disable supplementing preemptible instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// <para>Preemptible instance market price range configuration.</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
                /// <summary>
                /// <para>Preemptible instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c6.large</para>
                /// </summary>
                [NameInMap("instance_type")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>Maximum price per instance.</para>
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
            /// <para>Preemptible instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>NoSpot</c>: Non-preemptible instance.</description></item>
            /// <item><description><c>SpotWithPriceLimit</c>: Set a maximum price for the preemptible instance.</description></item>
            /// <item><description><c>SpotAsPriceGo</c>: System automatically bids, following the current market price.</description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/157759.html">Preemptible instances</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SpotWithPriceLimit</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>Whether to enable burst (performance burst) for the node system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enable. When enabled, cloud disks can temporarily boost performance based on actual business conditions when facing sudden data read/write pressure from volatile workloads, until the business returns to a steady state.</description></item>
            /// <item><description>false: Disable.</description></item>
            /// </list>
            /// <para>Only supported when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>Multiple disk types for the system disk. When the higher-priority disk type is unavailable, the system automatically tries the next priority disk type to create the system disk.</para>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>Node system disk type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_efficiency</c>: Ultra disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: SSD disk.</description></item>
            /// <item><description><c>cloud_essd</c>: ESSD disk.</description></item>
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
            /// <para>Encryption algorithm used for the system disk. Valid values: aes-256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes-256</para>
            /// </summary>
            [NameInMap("system_disk_encrypt_algorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Whether to encrypt the system disk. Valid values:</para>
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
            /// <para>KMS key ID used for the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("system_disk_kms_key_id")]
            [Validation(Required=false)]
            public string SystemDiskKmsKeyId { get; set; }

            /// <summary>
            /// <para>Node system disk performance level. Only takes effect for ESSD disks. The performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD disks</a>.</para>
            /// <list type="bullet">
            /// <item><description>PL0: Medium concurrent extreme I/O performance, relatively stable read/write latency.</description></item>
            /// <item><description>PL1: Medium concurrent extreme I/O performance, relatively stable read/write latency.</description></item>
            /// <item><description>PL2: High concurrent extreme I/O performance, stable read/write latency.</description></item>
            /// <item><description>PL3: Extremely high concurrent extreme I/O performance, extremely stable read/write latency.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>Provisioned read/write IOPS for the node system disk.</para>
            /// <para>Valid values: 0~min{50,000, 1000\*capacity-baseline performance}. Baseline performance=min{1,800+50\*capacity, 50000}.</para>
            /// <para>Only supported when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>Node system disk size, in GiB.</para>
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
            /// <para>System disk snapshot policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-0jl6xnmme8v7o935****</para>
            /// </summary>
            [NameInMap("system_disk_snapshot_policy_id")]
            [Validation(Required=false)]
            public string SystemDiskSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Tags added only to ECS instances.</para>
            /// <para>Tag keys cannot be duplicated and can be up to 128 characters. Tag keys and tag values cannot start with &quot;aliyun&quot; or &quot;acs:&quot;, or contain &quot;https://&quot; or &quot;http://&quot;.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>List of vSwitch IDs. Valid values: [1,8\].</para>
            /// <remarks>
            /// <para>To ensure high availability, it is recommended to select vSwitches in different availability zones.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>Confidential computing cluster configuration.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class ModifyClusterNodePoolRequestTeeConfig : TeaModel {
            /// <summary>
            /// <para>Whether to enable confidential computing cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enable.</description></item>
            /// <item><description><c>false</c>: Disable.</description></item>
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
