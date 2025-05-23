// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>The configurations about auto scaling.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class ModifyClusterNodePoolRequestAutoScaling : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated. Use the internet_charge_type and internet_max_bandwidth_out parameters instead. The maximum bandwidth of the EIP.</para>
            /// <para>Valid values: 1 to 100. Unit: Mbit/s.</para>
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
            /// <para>This parameter is deprecated. Use the internet_charge_type and internet_max_bandwidth_out parameters instead.</para>
            /// <para>The metering method of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>: pay-by-bandwidth.</description></item>
            /// <item><description><c>PayByTraffic</c>: pay-by-data-transfer.</description></item>
            /// </list>
            /// <para>Default value: <c>PayByBandwidth</c>.</para>
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
            /// <item><description><c>true</c>: enables auto scaling for the node pool. When the capacity planning of the cluster cannot meet the requirements of pod scheduling, ACK automatically scales out nodes based on the configured minimum and maximum number of instances. By default, node instant scaling is enabled for clusters that run Kubernetes 1.24. By default, node auto scaling is enabled for clusters that run Kubernetes versions earlier than 1.24. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Auto scaling of nodes</a>.</description></item>
            /// <item><description><c>false</c>: disables auto scaling. Container Service for Kubernetes (ACK) adjusts the number of nodes in the node pool based on the value of the Expected Nodes parameter. The number of nodes is always the same as the value of the Expected Nodes parameter.</description></item>
            /// </list>
            /// <para>If you set this parameter to false, other parameters in the <c>auto_scaling</c> section do not take effect.</para>
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
            /// <para>This parameter is deprecated. Use the internet_charge_type and internet_max_bandwidth_out parameters instead.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: associates an elastic IP address (EIP) with the node pool.</description></item>
            /// <item><description><c>false</c>: does not associate an EIP with the node pool.</description></item>
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
            /// <para>The maximum number of nodes that can be created in the node pool. Existing instances are excluded. This parameter takes effect only when <c>enable=true</c> is specified.</para>
            /// <para>The value must be at least the value of min_instances and cannot exceed 2000. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of nodes that must be kept in the node pool. Existing instances are excluded. This parameter takes effect only when <c>enable=true</c> is specified.</para>
            /// <para>The value must be at least 0 and cannot exceed the value of max_instances. Default value: 0.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>When the minimum number of instances is greater than 0 and a scaling group is set up, ECS instances are automatically created based on the minimum number.</para>
            /// </description></item>
            /// <item><description><para>We recommend that the value of max_instances is equal to or larger than the current number of nodes in the node pool. If the value of max_instances is less than the current number of nodes in the node pool, the node pool will be scaled in after you enable auto scaling for the node pool.</para>
            /// </description></item>
            /// </list>
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
            /// <para>The instance type that is used for auto scaling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cpu</c>: regular instance.</description></item>
            /// <item><description><c>gpu</c>: GPU-accelerated instance.</description></item>
            /// <item><description><c>gpushare</c>: shared GPU-accelerated instance.</description></item>
            /// <item><description><c>spot</c>: preemptible instance.</description></item>
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
        /// <para>Specifies whether concurrency is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public bool? Concurrency { get; set; }

        /// <summary>
        /// <para>The configurations of the cluster.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class ModifyClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to install the CloudMonitor agent on ECS nodes. After the CloudMonitor agent is installed on ECS nodes, you can view monitoring information about the instances in the CloudMonitor console. We recommend that you install the CloudMonitor agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: installs the CloudMonitor agent on ECS nodes.</description></item>
            /// <item><description><c>false</c>: does not install the CloudMonitor agent on ECS nodes.</description></item>
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
            /// <para>The CPU management policy of nodes in the node pool. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later:</para>
            /// <list type="bullet">
            /// <item><description><c>static</c>: allows pods with specific resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.</description></item>
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
            /// <para>The labels that are added to the nodes in the cluster. You must add the label based on the following rules:</para>
            /// <list type="bullet">
            /// <item><description>A label is a case-sensitive key-value pair. You can add up to 20 labels.</description></item>
            /// <item><description>The key must be unique and cannot exceed 64 characters in length. The value can be empty and cannot exceed 128 characters in length. Keys and values cannot start with <c>aliyun</c>, <c>acs:</c>, <c>https://</c>, or <c>http://</c>. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>Predefined custom data. Nodes automatically run predefined scripts before they are added to the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User-Data script</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFDSyEi</para>
            /// </summary>
            [NameInMap("pre_user_data")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>The name of the container runtime. The following types of runtime are supported by ACK:</para>
            /// <list type="bullet">
            /// <item><description>containerd: containerd is the recommended runtime and supports all Kubernetes versions.</description></item>
            /// <item><description>Sandboxed-Container.runv: The Sandbox-Container runtime provides improved isolation and supports Kubernetes 1.31 and earlier.</description></item>
            /// <item><description>docker: discontinued. The Docker runtime supports Kubernetes 1.22 and earlier.</description></item>
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
            /// <para>The configurations of node taints.</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>Specifies whether the nodes are unschedulable after a scale-out activity is performed.</para>
            /// <list type="bullet">
            /// <item><description>true: The nodes are unschedulable after a scale-out activity is performed.</description></item>
            /// <item><description>false: The nodes are schedulable after a scale-out activity is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("unschedulable")]
            [Validation(Required=false)]
            public bool? Unschedulable { get; set; }

            /// <summary>
            /// <para>The user data of the instance. Nodes automatically run user-data scripts after they are added to the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User-Data script</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFDSyEi</para>
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
        public ModifyClusterNodePoolRequestManagement Management { get; set; }
        public class ModifyClusterNodePoolRequestManagement : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto node repair. This parameter takes effect only if <c>enable</c> is set to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables auto repair.</description></item>
            /// <item><description><c>false</c>: disables auto repair.</description></item>
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
            /// <para>The auto node repair policy.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether ACK is allowed to automatically restart nodes after repairing the nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: yes.</description></item>
                /// <item><description><c>false</c>: no.</description></item>
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
            /// <para>Specifies whether to enable auto upgrade. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables auto upgrade.</description></item>
            /// <item><description><c>false</c>: disables auto upgrade.</description></item>
            /// </list>
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
                /// <para>Specifies whether ACK is allowed to automatically upgrade the kubelet. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: yes.</description></item>
                /// <item><description><c>false</c>: no.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

                /// <summary>
                /// <para>Specifies whether ACK is allowed to automatically upgrade the operating system. This parameter takes effect only when you specify <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: yes.</description></item>
                /// <item><description><c>false</c>: no.</description></item>
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
                /// <para>Specifies whether ACK is allowed to automatically upgrade the runtime. This parameter takes effect only when you specify <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: yes.</description></item>
                /// <item><description><c>false</c>: no.</description></item>
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
            /// <para>Specifies whether ACK is allowed to automatically patch CVE vulnerabilities. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables auto CVE patching.</description></item>
            /// <item><description><c>true</c>: disables auto CVE patching.</description></item>
            /// </list>
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
            public ModifyClusterNodePoolRequestManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether ACK is allowed to automatically restart nodes after repairing the nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: yes.</description></item>
                /// <item><description><c>false</c>: no.</description></item>
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
                /// <para>If <c>auto_vul_fix=true</c> is specified, the default value is <c>asap</c>.</para>
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
            /// <item><description><c>false</c>: disables the managed node pool feature. Other parameters in this section take effect only when <c>enable=true</c> is specified.</description></item>
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
            /// <para>This parameter is deprecated. Use the preceding <c>auto_upgrade</c> parameter instead.</para>
            /// <para>The configurations of auto upgrade. The configurations take effect only when <c>enable</c> is set to true.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public ModifyClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class ModifyClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>This parameter is deprecated. Use the preceding <c>auto_upgrade</c> parameter instead.</para>
                /// <para>Specifies whether to enable auto upgrade. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: enables auto upgrade.</description></item>
                /// <item><description>false: disables auto upgrade.</description></item>
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
                /// <para>The maximum number of nodes that can be in the Unavailable state.</para>
                /// <para>Valid values: 1 to 1000.</para>
                /// <para>Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// <para>The number of additional nodes that are temporarily added to the node pool during an auto upgrade. Specify this parameter or <c>surge_percentage</c>.</para>
                /// <para>A node is unavailable during an upgrade. Additional nodes are used to temporarily host the workloads of nodes that are being upgraded.</para>
                /// <remarks>
                /// <para> We recommend that you specify a value that does not exceed the current number of nodes in the node pool.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>The percentage of additional nodes in the node pool. Specify this parameter or the <c>surge</c> parameter is specified.</para>
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
        /// <para>The configurations of the node pool.</para>
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
            /// <para>The ID of the resource group to which the node pool belongs. Instances that are added to the node pool belong to this resource group.</para>
            /// <para>Each resource can belong only to one resource group. You can regard a resource group as a project, an application, or an organization based on your business scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjm****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the scaling group that is used by the node pool.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class ModifyClusterNodePoolRequestScalingGroup : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for the nodes in the node pool. This parameter takes effect only when you set <c>instance_charge_type</c> to <c>PrePaid</c>. Valid values:</para>
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
            /// <item><description>Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60</description></item>
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
            /// <para>The configurations of the data disks that are mounted to nodes in the node pool. Valid values: 0 to 10. You can mount at most 10 data disks to the nodes in the node pool.</para>
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds-bp1d19mmbsv3jf6xxxxx</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>The expected number of nodes in the node pool.</para>
            /// <para>The expected number of nodes in the node pool. We recommend that you configure at least two nodes to ensure that cluster components run as expected. You can modify the Expected Nodes parameter to adjust the number of nodes in the node pool.</para>
            /// <para>If you do not want to create nodes in the node pool, set this parameter to 0. You can manually modify this parameter to add nodes later.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("desired_size")]
            [Validation(Required=false)]
            public long? DesiredSize { get; set; }

            /// <summary>
            /// <para>The custom image ID. You can call the <c>DescribeKubernetesVersionMetadata</c> operation to query the images supported by ACK. By default, the latest image is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_2_1903_x64_20G_alibase_20200904.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The type of operating system distribution that you want to use. We recommend that you use this parameter to specify the node operating system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>AliyunLinux</c>: Alibaba Cloud Linux 2.</description></item>
            /// <item><description><c>AliyunLinuxSecurity</c>: Alibaba Cloud Linux 2 (UEFI).</description></item>
            /// <item><description><c>AliyunLinux3</c>: Alibaba Cloud Linux 3.</description></item>
            /// <item><description><c>AliyunLinux3Arm64</c>: Alibaba Cloud Linux 3 for ARM.</description></item>
            /// <item><description><c>AliyunLinux3Security</c>: Alibaba Cloud Linux 3 (UEFI).</description></item>
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
            /// <para>Default value: <c>PostPaid</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>.The instance attributes.</para>
            /// </summary>
            [NameInMap("instance_patterns")]
            [Validation(Required=false)]
            public List<InstancePatterns> InstancePatterns { get; set; }

            /// <summary>
            /// <para>The instance types. You can specify multiple instance types. A node is assigned the instance type from the first instance type of the list until the node is created. The instance type that is used to create the node varies based on the actual instance stock.</para>
            /// <para>You can specify 1 to 10 instance types.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The metering method of the public IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>: pay-by-bandwidth.</description></item>
            /// <item><description><c>PayByTraffic</c>: pay-by-data-transfer.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The maximum outbound bandwidth of the public IP address of the node. Unit: Mbit/s. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>The name of the key pair. You must specify this parameter or <c>login_password</c>. You must specify the <c>key_pair</c> parameter if the node pool is a managed node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pro-nodepool</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>The password for SSH logon. You must specify this parameter or <c>key_pair</c>. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
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
            /// <item><description><para><c>BALANCE</c>: ECS instances are evenly distributed across multiple zones specified by the scaling group. If ECS instances become imbalanced among multiple zones due to insufficient inventory, you can call the <c>RebalanceInstances</c> operation of Auto Scaling to balance the instance distribution among zones. For more information, see <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a>.</para>
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
            /// <para>The billing cycle of nodes in the node pool. This parameter takes effect and is required if you set <c>instance_charge_type</c> to <c>PrePaid</c>. Valid values:</para>
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
            /// <para>This parameter is obsolete. Use the <c>image_type</c> parameter instead.</para>
            /// <para>The OS platform. Valid values:</para>
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
            /// <para>The configurations of the private node pool.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// <para>The private node pool ID. This parameter is available only when <c>match_criteria</c> is set to <c>Target</c>.</para>
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
                /// <item><description><c>Open</c>: open private pool. The system selects an open private pool to start instances. If no matching open private pools are available, the resources in the public pool are used.</description></item>
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
            /// <para>The IDs of ApsaraDB RDS instances.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>The scaling mode of the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>release</c>: the standard mode. ECS instances are created and released based on resource usage.</description></item>
            /// <item><description><c>recycle</c>: the swift mode. ECS instances are created, stopped, or started during scaling events. This reduces the time required for the next scale-out event. When the instance is stopped, you are charged only for the storage service. This does not apply to ECS instances that are attached with local disks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>release</para>
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

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
            /// <para>Specifies whether to enable the supplementation of preemptible instances. If you set this parameter to true, when the scaling group receives a system message indicating that a preemptible instance is to be reclaimed, the scaling group attempts to create a new instance to replace the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: supplements preemptible instances.</description></item>
            /// <item><description><c>false</c>: does not supplement preemptible instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// <para>The bid configurations of preemptible instances.</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
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
                /// <para>The price cap of a preemptible instance.</para>
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
            /// <para>The bidding policy of preemptible instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>NoSpot</c>: non-preemptible instance.</description></item>
            /// <item><description><c>SpotWithPriceLimit</c>: specifies the highest bid.</description></item>
            /// <item><description><c>SpotAsPriceGo</c>: automatically submits bids based on the up-to-date market price.</description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/157759.html">Create a preemptible elastic container instance</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SpotWithPriceLimit</para>
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
            /// <para>This parameter is effective only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The categories of the system disk. The system attempts to create system disks of a disk category with a lower priority if the disk category with a higher priority is unavailable.</para>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The category of the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_efficiency</c>: ultra disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
            /// <item><description><c>cloud_essd</c>: Enterprise ESSD (ESSD).</description></item>
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
            /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: encrypts the system disk.</description></item>
            /// <item><description>false: does not encrypt the system disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
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
            /// <para>The performance level (PL) of the system disk. This parameter takes effect only for an ESSD. You can specify a higher PL if you increase the size of the data disk. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// <list type="bullet">
            /// <item><description>PL0: moderate maximum concurrent I/O performance and low I/O latency.</description></item>
            /// <item><description>PL1: moderate maximum concurrent I/O performance and low I/O latency.</description></item>
            /// <item><description>PL2: high maximum concurrent I/O performance and low I/O latency.</description></item>
            /// <item><description>PL3: ultra-high maximum concurrent I/O performance and ultra-low I/O latency.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The preset IOPS of the system disk.</para>
            /// <para>Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
            /// <para>This parameter is effective only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB</para>
            /// <para>Valid values: 20 to 2048.</para>
            /// <para>The value of this parameter must be at least 20 and greater than or equal to the size of the image.</para>
            /// <para>Default value: the greater value between 40 and the image size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The tags that you want to add only to ECS instances.</para>
            /// <para>The tag key must be unique and cannot exceed 128 characters in length. The tag key and value cannot start with aliyun or acs: or contain https:// or http://.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>The vSwitch IDs. You can specify one to eight vSwitch IDs.</para>
            /// <remarks>
            /// <para> To ensure high availability, we recommend that you select vSwitches that reside in different zones.</para>
            /// </remarks>
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
        public ModifyClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class ModifyClusterNodePoolRequestTeeConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable confidential computing for the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables confidential computing for the cluster.</description></item>
            /// <item><description><c>false</c>: disables confidential computing for the cluster.</description></item>
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
        /// <para>Specifies whether to update node information, such as labels and taints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("update_nodes")]
        [Validation(Required=false)]
        public bool? UpdateNodes { get; set; }

    }

}
