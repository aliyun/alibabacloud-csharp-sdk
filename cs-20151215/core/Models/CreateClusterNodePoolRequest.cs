// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>Node pool intelligent managed configuration.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoMode AutoMode { get; set; }
        public class CreateClusterNodePoolRequestAutoMode : TeaModel {
            /// <summary>
            /// <para>Whether to enable intelligent managed mode.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enable intelligent managed mode. Can only be enabled when the cluster has intelligent managed mode enabled.</description></item>
            /// <item><description>false: disable intelligent managed mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>Auto scaling configuration.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class CreateClusterNodePoolRequestAutoScaling : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>[Deprecated] Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <para>Maximum EIP bandwidth. Unit: Mbps.</para>
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
            /// <para>EIP billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>: pay-by-bandwidth.</description></item>
            /// <item><description><c>PayByTraffic</c>: pay-by-traffic.</description></item>
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
            /// <item><description><para><c>true</c>: enables auto scaling for the node pool. When cluster capacity cannot meet Pod scheduling requirements, ACK automatically scales node resources based on the configured minimum and maximum instance counts. Clusters of version 1.24 or later enable instant node scaling by default;
            /// clusters of versions earlier than 1.24 enable node auto scaling by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node scaling</a>.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disables auto scaling. ACK adjusts the number of nodes in the node pool based on the configured desired node count, always maintaining the node count at the desired number.</para>
            /// </description></item>
            /// </list>
            /// <para>When this parameter is set to false, other configuration parameters in <c>auto_scaling</c> do not take effect.</para>
            /// <para>Default value: <c>false</c>.</para>
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
            /// <para>[Deprecated] This field is deprecated. Use internet_charge_type and internet_max_bandwidth_out instead.</para>
            /// <para>Whether to bind an EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: bind an EIP.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: do not bind an EIP.</para>
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
            /// <para>Maximum number of instances that can be scaled in the node pool, excluding existing instances. Takes effect only when <c>enable=true</c>.</para>
            /// <para>Valid values: [min_instances, 2000]. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>Minimum number of instances that can be scaled in the node pool, excluding existing instances. Takes effect only when <c>enable=true</c>.</para>
            /// <para>Valid values: [0, max_instances]. Default value: 0.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>When the minimum number of instances is not 0, the corresponding number of ECS instances will be automatically created after the scaling group takes effect.</description></item>
            /// <item><description>It is recommended that the maximum number of instances is not smaller than the current number of nodes in the node pool. Otherwise, nodes in the node pool will be directly scaled in after auto scaling takes effect.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// <para>Auto scaling instance type. Takes effect only when <c>enable=true</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cpu</c>: standard instance type.</para>
            /// </description></item>
            /// <item><description><para><c>gpu</c>: GPU instance type.</para>
            /// </description></item>
            /// <item><description><para><c>gpushare</c>: GPU sharing type.</para>
            /// </description></item>
            /// <item><description><para><c>spot</c>: preemptible instance type.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>cpu</c>.</para>
            /// <remarks>
            /// <para>Notice: This field cannot be modified after the node pool is created.</para>
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
        /// <para>[Deprecated] Use desired_size instead.</para>
        /// <para>Number of nodes in the node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Count { get; set; }

        /// <summary>
        /// <para>Lingjun node pool configuration.</para>
        /// </summary>
        [NameInMap("eflo_node_group")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestEfloNodeGroup EfloNodeGroup { get; set; }
        public class CreateClusterNodePoolRequestEfloNodeGroup : TeaModel {
            /// <summary>
            /// <para>Lingjun cluster ID to associate when creating a Lingjun node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i1169130516633730****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Lingjun group ID of the Lingjun cluster to associate when creating a Lingjun node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-ec3c96ff0aa****</para>
            /// </summary>
            [NameInMap("group_id")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        /// <summary>
        /// <para>Whether the Pod network mode uses host network mode.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: host network. Pods directly use the host network stack, sharing the IP address and ports with the host.</description></item>
        /// <item><description><c>false</c>: container network. Pods have an independent network stack and do not occupy host network ports.</description></item>
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
        /// <para>[Deprecated]</para>
        /// <para>Edge node pool configuration.</para>
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        [Obsolete]
        public CreateClusterNodePoolRequestInterconnectConfig InterconnectConfig { get; set; }
        public class CreateClusterNodePoolRequestInterconnectConfig : TeaModel {
            /// <summary>
            /// <para>[Deprecated]</para>
            /// <para>Network bandwidth of the enhanced edge node pool. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>[Deprecated]</para>
            /// <para>CCN instance ID (CCN ID) bound to the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            public string CcnId { get; set; }

            /// <summary>
            /// <para>[Deprecated]</para>
            /// <para>Region of the CCN instance bound to the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            public string CcnRegionId { get; set; }

            /// <summary>
            /// <para>[Deprecated]</para>
            /// <para>CEN instance ID (CEN ID) bound to the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("cen_id")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>[Deprecated]</para>
            /// <para>Subscription duration of the enhanced edge node pool. Unit: months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("improved_period")]
            [Validation(Required=false)]
            public string ImprovedPeriod { get; set; }

        }

        /// <summary>
        /// <para>Network type of the edge node pool. This parameter takes effect only for node pools of <c>edge</c> type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>basic</c>: public network. Nodes in the node pool communicate with cloud nodes over the public network. Applications in the node pool cannot directly access the cloud VPC internal network.</description></item>
        /// <item><description><c>private</c>: private network. Nodes in the node pool connect cloud and on-premises networks through Express Connect, VPN, or CEN, providing higher cloud-edge communication quality and more effective security.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("interconnect_mode")]
        [Validation(Required=false)]
        public string InterconnectMode { get; set; }

        /// <summary>
        /// <para>Whether nodes in the edge node pool have Layer 3 network connectivity.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: connected. All nodes in this node pool have Layer 3 network connectivity.</description></item>
        /// <item><description><c>false</c>: not connected. All hosts in this node pool do not have Layer 3 network connectivity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("intranet")]
        [Validation(Required=false)]
        public bool? Intranet { get; set; }

        /// <summary>
        /// <para>Cluster-related configuration.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class CreateClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>Whether to install CloudMonitor on ECS nodes. After installation, you can view monitoring information for created ECS instances in the CloudMonitor console. We recommend enabling this. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: install CloudMonitor on ECS nodes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: do not install CloudMonitor on ECS nodes.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }

            /// <summary>
            /// <para>Node CPU management policy. The following two policies are supported when the cluster version is 1.12.6 or later:</para>
            /// <list type="bullet">
            /// <item><description><c>static</c>: allows enhanced CPU affinity and exclusivity for Pods with certain resource characteristics on the node.</description></item>
            /// <item><description><c>none</c>: enables the existing default CPU affinity scheme.</description></item>
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
            /// <para>Node labels. Add labels to Kubernetes cluster nodes.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>Custom node name. After setting a custom node name, the node name, ECS instance name, and ECS instance hostname are all changed accordingly.</para>
            /// <remarks>
            /// <para>For Windows instances with custom node names enabled, the hostname is fixed to the IP address with &quot;-&quot; replacing &quot;.&quot; in the IP address, and does not include the prefix or suffix. </para>
            /// </remarks>
            /// <para>A node name consists of three parts: prefix, node IP address, and suffix:</para>
            /// <list type="bullet">
            /// <item><description><para>Total length: 2 to 64 characters. The node name must start and end with a lowercase letter or digit.</para>
            /// </description></item>
            /// <item><description><para>The prefix and suffix can contain uppercase and lowercase letters, digits, hyphens (-), and periods (.). They must start with a letter and cannot start or end with a hyphen (-) or period (.). Consecutive hyphens (-) or periods (.) are not allowed.</para>
            /// </description></item>
            /// <item><description><para>The prefix is required (ECS restriction) and the suffix is optional.</para>
            /// </description></item>
            /// <item><description><para>The node IP is the complete private IP address of the node.</para>
            /// </description></item>
            /// </list>
            /// <para>Example: If the node IP address is 192.XX.YY.55, the prefix is aliyun.com, and the suffix is test:</para>
            /// <list type="bullet">
            /// <item><description><para>For Linux nodes, the node name, ECS instance name, and ECS instance hostname are all aliyun.com192.XX.YY.55test.</para>
            /// </description></item>
            /// <item><description><para>For Windows nodes, the ECS instance hostname is 192-XX-YY-55, and the node name and ECS instance name are both aliyun.com192.XX.YY.55test.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com192.XX.YY.55test</para>
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// <para>Instance pre-custom data. Before a node joins the cluster, the specified instance pre-custom data script is run. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User-Data scripts</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGhpcyBpcyBhIGV4YW1wbGU</para>
            /// </summary>
            [NameInMap("pre_user_data")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>Container runtime name. ACK supports the following three container runtimes.</para>
            /// <list type="bullet">
            /// <item><description>containerd: recommended, supported by all cluster versions.</description></item>
            /// <item><description>Sandboxed-Container.runv: sandboxed container with higher isolation, supported by clusters of version 1.31 or earlier.</description></item>
            /// <item><description>docker: no longer maintained, supported by clusters of version 1.22 or earlier.</description></item>
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
            /// <para>Taint configuration.</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>Whether scaled-out nodes are unschedulable.</para>
            /// <list type="bullet">
            /// <item><description><para>true: unschedulable.</para>
            /// </description></item>
            /// <item><description><para>false: schedulable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("unschedulable")]
            [Validation(Required=false)]
            public bool? Unschedulable { get; set; }

            /// <summary>
            /// <para>Instance custom data. After a node joins the cluster, the specified instance custom data script is run. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User-Data scripts</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGhpcyBpcyBhIGV4YW1wbGU=</para>
            /// </summary>
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>Node pool managed feature configuration.</para>
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestManagement Management { get; set; }
        public class CreateClusterNodePoolRequestManagement : TeaModel {
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>Whether to automatically repair nodes. Takes effect only when <c>enable=true</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: auto repair</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: no auto repair</para>
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
            /// <para>Auto repair node policy.</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>Whether node repair requires manual approval.</para>
                /// </summary>
                [NameInMap("approval_required")]
                [Validation(Required=false)]
                public bool? ApprovalRequired { get; set; }

                /// <summary>
                /// <para>Whether to allow node restart. Takes effect only when <c>auto_repair=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: allow node restart</description></item>
                /// <item><description><c>false</c>: do not allow node restart</description></item>
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
            /// <para>Whether to automatically upgrade nodes. Takes effect only when <c>enable=true</c>.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enable auto upgrade.</description></item>
            /// <item><description><c>false</c>: disable auto upgrade.</description></item>
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
            /// <para>Auto node upgrade policy.</para>
            /// </summary>
            [NameInMap("auto_upgrade_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>Whether to allow automatic kubelet upgrade. Takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: allow automatic kubelet upgrade.</description></item>
                /// <item><description><c>false</c>: do not allow automatic kubelet upgrade.</description></item>
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
                /// <para>Whether to allow automatic OS upgrade. Takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: allow automatic OS upgrade.</description></item>
                /// <item><description><c>false</c>: do not allow automatic OS upgrade.</description></item>
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
                /// <para>Whether to allow automatic runtime upgrade. Takes effect only when <c>auto_upgrade=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: allow automatic runtime upgrade.</description></item>
                /// <item><description><c>false</c>: do not allow automatic runtime upgrade.</description></item>
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
            /// <para>Whether to automatically fix CVE vulnerabilities. Takes effect only when <c>enable=true</c>.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: allow automatic CVE fixing.</description></item>
            /// <item><description><c>false</c>: do not allow automatic CVE fixing.</description></item>
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
            public CreateClusterNodePoolRequestManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>Packages to exclude during vulnerability patching.</para>
                /// <para>Default value: <c>kernel</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kernel</para>
                /// </summary>
                [NameInMap("exclude_packages")]
                [Validation(Required=false)]
                public string ExcludePackages { get; set; }

                /// <summary>
                /// <para>Whether to allow node restart. Takes effect only when <c>auto_vul_fix=true</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: allow node restart</description></item>
                /// <item><description><c>false</c>: do not allow node restart</description></item>
                /// </list>
                /// <para>Default value: <c>true</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// <para>Vulnerability levels allowed for automatic fixing, separated by commas, for example: <c>asap,later</c>. Supported vulnerability levels:</para>
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
            /// <para>Whether to enable the managed feature for the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enable the managed feature.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disable the managed feature. Other related configurations take effect only when enable=true.</para>
            /// </description></item>
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
            /// <para>[Deprecated] Use the <c>auto_upgrade</c> parameter at the parent level instead.</para>
            /// <para>Auto upgrade configuration. Takes effect only when <c>enable=true</c>.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public CreateClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class CreateClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>[Deprecated] Use the <c>auto_upgrade</c> parameter at the parent level instead.</para>
                /// <para>Whether to enable auto upgrade. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: enable auto upgrade.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: disable auto upgrade.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                [Obsolete]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// <para>Maximum number of unavailable nodes.
                /// Valid values: [1,1000\]</para>
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
                /// <para>Nodes become unavailable during upgrade. You can create extra nodes to compensate for the cluster workload.</para>
                /// <remarks>
                /// <para>It is recommended that the number of extra nodes does not exceed the current number of nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>Percentage of extra nodes. Mutually exclusive with <c>surge</c>.</para>
                /// <para>Number of extra nodes = percentage of extra nodes × number of nodes. For example, if the percentage is set to 50% and there are 6 existing nodes, the number of extra nodes = 50% × 6 = 3.</para>
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
        /// <para>[Deprecated]</para>
        /// <para>Maximum number of nodes allowed in the edge node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public long? MaxNodes { get; set; }

        /// <summary>
        /// <para>Node component list.</para>
        /// </summary>
        [NameInMap("node_components")]
        [Validation(Required=false)]
        public List<CreateClusterNodePoolRequestNodeComponents> NodeComponents { get; set; }
        public class CreateClusterNodePoolRequestNodeComponents : TeaModel {
            /// <summary>
            /// <para>Node component configuration.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestNodeComponentsConfig Config { get; set; }
            public class CreateClusterNodePoolRequestNodeComponentsConfig : TeaModel {
                /// <summary>
                /// <para>Node component custom configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cpuManagerPolicy&quot;:&quot;static&quot;}</para>
                /// </summary>
                [NameInMap("custom_config")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomConfig { get; set; }

            }

            /// <summary>
            /// <para>Node component name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubelet</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Node component version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.33.3-aliyun.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>Node configuration.</para>
        /// </summary>
        [NameInMap("node_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestNodeConfig NodeConfig { get; set; }
        public class CreateClusterNodePoolRequestNodeConfig : TeaModel {
            /// <summary>
            /// <para>Kubelet parameter configuration.</para>
            /// </summary>
            [NameInMap("kubelet_configuration")]
            [Validation(Required=false)]
            public KubeletConfig KubeletConfiguration { get; set; }

        }

        /// <summary>
        /// <para>Node pool configuration.</para>
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class CreateClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// <para>Node pool name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nodepool-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Resource group ID of the node pool. Instances created by the node pool will belong to this resource group.</para>
            /// <para>A resource can only belong to one resource group. Based on different business scenarios, you can map resource groups to concepts such as projects, applications, or organizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjmb****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Node pool type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>ess</c>: standard node pool (includes managed and auto scaling features).</description></item>
            /// <item><description><c>edge</c>: edge node pool.</description></item>
            /// <item><description><c>lingjun</c>: Lingjun node pool.</description></item>
            /// <item><description><c>hybrid</c>: hybrid cloud node pool.</description></item>
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
        /// <para>Node pool scaling group configuration.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class CreateClusterNodePoolRequestScalingGroup : TeaModel {
            /// <summary>
            /// <para>Whether to enable auto-renewal for nodes in the node pool. Takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enable auto-renewal.</description></item>
            /// <item><description><c>false</c>: disable auto-renewal.</description></item>
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
            /// <para>Duration of each auto-renewal. Valid values:</para>
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

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>[Deprecated] Use the security_hardening_os parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("cis_enabled")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? CisEnabled { get; set; }

            /// <summary>
            /// <para>When <c>multi_az_policy</c> is set to <c>COST_OPTIMIZED</c>, whether to allow automatic creation of pay-as-you-go instances to meet the required number of ECS instances when preemptible instances cannot be created due to price or inventory constraints. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: allow automatic creation of pay-as-you-go instances.</description></item>
            /// <item><description><c>false</c>: do not allow automatic creation of pay-as-you-go instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("compensate_with_on_demand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// <para>Data disk configuration for nodes in the node pool.</para>
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// <para>Deployment set ID. You can use a deployment set to distribute ECS instances created by the node pool across different physical servers to ensure high availability and disaster recovery capabilities. When creating ECS instances in a deployment set, instances are distributed across the specified region based on the pre-configured deployment policy.</para>
            /// <remarks>
            /// <para>Notice: After a deployment set is selected, the maximum number of nodes in the node pool is limited. The default upper limit for nodes in a deployment set is 20 × number of zones (the number of zones is determined by vSwitches). Choose carefully and ensure sufficient quota in the deployment set to avoid node creation failures.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1d19mmbsv3jf6xxxxx</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>Desired number of nodes in the node pool.</para>
            /// <para>The total number of nodes that the node pool should maintain. We recommend configuring at least 2 nodes to ensure proper running of cluster components. You can scale in or out the node pool by adjusting the desired node count.</para>
            /// <para>If no nodes need to be created, set this to 0 and manually adjust the node count later.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>Custom image ID. The system-provided image is used by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_2_1903_x64_20G_alibase_20200529.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>OS image type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>AliyunLinux</c>: Alinux2 image.</description></item>
            /// <item><description><c>AliyunLinuxSecurity</c>: Alinux2 image UEFI version.</description></item>
            /// <item><description><c>AliyunLinux3</c>: Alinux3 image.</description></item>
            /// <item><description><c>AliyunLinux3Arm64</c>: Alinux3 image ARM version.</description></item>
            /// <item><description><c>AliyunLinux3Security</c>: Alinux3 image UEFI version.</description></item>
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
            /// <para>Billing method for nodes in the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PrePaid</c>: subscription instance.</para>
            /// </description></item>
            /// <item><description><para><c>PostPaid</c>: pay-as-you-go instance.</para>
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
            /// <para>ECS instance metadata access configuration.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>Instance attribute configuration.</para>
            /// </summary>
            [NameInMap("instance_patterns")]
            [Validation(Required=false)]
            public List<InstancePatterns> InstancePatterns { get; set; }

            /// <summary>
            /// <para>List of node instance types for the node pool. When the node pool scales out, instance types that meet the requirements are selected from the specified list to create instances.</para>
            /// <para>Supported number of instance types: [1,10]</para>
            /// <remarks>
            /// <para>To ensure high availability, we recommend that you select multiple instance types.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>Public IP billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
            /// <item><description>PayByTraffic: pay-by-traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByTraffic</para>
            /// </summary>
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>Maximum outbound public bandwidth for nodes. Unit: Mbps (Megabits per second). Valid values: [1,100\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>Key pair name for passwordless login. Mutually exclusive with <c>login_password</c>.</para>
            /// <remarks>
            /// <para>If the node pool uses the ContainerOS operating system, only <c>key_pair</c> is supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>np-key-name</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>Whether the created ECS instances use a non-root user for login.</para>
            /// <list type="bullet">
            /// <item><description><para>true: log on as a non-root user (ecs-user).</para>
            /// </description></item>
            /// <item><description><para>false: log on as the root user.</para>
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
            /// <para>SSH login password. Mutually exclusive with <c>key_pair</c>. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>Multi-zone scaling group ECS instance scaling policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PRIORITY</c>: scales based on the vSwitches (VSwitchIds.N) you defined. When ECS instances cannot be created in the zone of a higher-priority vSwitch, the next-priority vSwitch is automatically used.</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>: attempts to create instances from lowest to highest vCPU unit price. When multiple instance types with preemptible billing are configured, preemptible instances are created first. You can use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically attempt creating pay-as-you-go instances when preemptible instances cannot be created due to insufficient inventory.</para>
            /// <remarks>
            /// <para><c>COST_OPTIMIZED</c> takes effect only when multiple instance types or preemptible instances are configured.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>: evenly distributes ECS instances across the multiple zones specified in the scaling group. If zones become unbalanced due to insufficient inventory, you can use the API <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a> to rebalance resources.</para>
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
            /// <para>Minimum number of pay-as-you-go instances required by the scaling group. Valid values: [0,1000\]. When the number of pay-as-you-go instances is less than this value, pay-as-you-go instances are created first.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>Percentage of pay-as-you-go instances among the excess instances after the scaling group meets the minimum pay-as-you-go instance requirement (<c>on_demand_base_capacity</c>). Valid values: [0,100\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>Subscription duration for nodes in the node pool. Takes effect and is required only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <list type="bullet">
            /// <item><description>When <c>period_unit=Week</c>, valid values of <c>period</c>: {1, 2, 3, 4}.</description></item>
            /// <item><description>When <c>period_unit=Month</c>, valid values of <c>period</c>: {1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, 60}.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>Billing period unit for nodes in the node pool. Takes effect and is required only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <list type="bullet">
            /// <item><description><c>Month</c>: billed on a monthly basis.</description></item>
            /// <item><description><c>Week</c>: billed on a weekly basis.</description></item>
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
            /// <para>OS distribution. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>CentOS</c></description></item>
            /// <item><description><c>AliyunLinux</c></description></item>
            /// <item><description><c>Windows</c></description></item>
            /// <item><description><c>WindowsCore</c></description></item>
            /// </list>
            /// <para>Default value: <c>AliyunLinux</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            [Obsolete]
            public string Platform { get; set; }

            /// <summary>
            /// <para>Private pool configuration.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// <para>Private pool ID. When <c>match_criteria</c> is set to <c>Target</c>, you must further specify the private pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Private pool type. Private pool capacity option for instance startup. After an Elasticity Assurance or Capacity Reservation takes effect, private pool capacity is generated for instance startup. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>Open</c>: open mode. Automatically matches open-type private pool capacity. If no eligible private pool capacity is available, public pool resources are used.</description></item>
                /// <item><description><c>Target</c>: targeted mode. Uses the specified private pool capacity to launch instances. If the specified capacity is unavailable, instance creation fails.</description></item>
                /// <item><description><c>None</c>: do not use mode. Instances will not use private pool capacity.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Target</para>
                /// </summary>
                [NameInMap("match_criteria")]
                [Validation(Required=false)]
                public string MatchCriteria { get; set; }

            }

            /// <summary>
            /// <para>Worker RAM role name.</para>
            /// <list type="bullet">
            /// <item><description>When left empty, the default Worker RAM role created by the cluster is used.</description></item>
            /// <item><description>When specified, the RAM role must be a <b>normal service role</b>, and its <b>trusted service</b> must be set to <b>Elastic Compute Service</b>. For more information, see <a href="https://help.aliyun.com/document_detail/116800.html">Create a normal service role</a>. When the specified RAM role is not the default Worker RAM role created by the cluster, the role name cannot start with <c>KubernetesMasterRole-</c> or <c>KubernetesWorkerRole-</c>.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: This parameter is supported only for ACK managed clusters of version 1.22 or later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>example-role</para>
            /// </summary>
            [NameInMap("ram_role_name")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>RDS instance list.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>Resource pool and resource pool policy used when creating instances. Note the following when you set this parameter:
            /// This parameter takes effect only when creating pay-as-you-go instances.
            /// This parameter cannot be set together with private_pool_options.match_criteria or private_pool_options.id.</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>List of private pool IDs, i.e., Elasticity Assurance IDs or Capacity Reservation IDs. Only Target mode private pool IDs can be passed. Valid values of N: 1 to 20.</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>Resource pool policy used when creating instances. Resource pools include private pools generated after Elasticity Assurance or Capacity Reservation takes effect, and public pools, for instance startup selection. Valid values:
                /// PrivatePoolFirst: private pool first. When this policy is selected and resouce_pool_options.private_pool_ids is specified, the specified private pools are used first. If no private pool is specified or the specified private pool capacity is insufficient, open-type private pools are automatically matched. If no eligible private pool is available, public pools are used to create instances.
                /// PrivatePoolOnly: private pool only. When this policy is selected, resouce_pool_options.private_pool_ids must be specified. If the specified private pool capacity is insufficient, instance creation fails.
                /// None: do not use resource pool policy.
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
            /// <item><description><c>release</c>: standard mode. Scales by creating and releasing ECS instances based on resource usage.</description></item>
            /// <item><description><c>recycle</c>: rapid mode. Scales by creating, stopping, and starting ECS instances, improving the speed of subsequent scaling (compute resources are not charged when stopped, only storage fees are charged, except for local disk instance types).</description></item>
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
            /// <para>Security group ID for the node pool. Mutually exclusive with <c>security_group_ids</c>. We recommend using <c>security_group_ids</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-wz9a8g2mt6x5llu0****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>List of security group IDs. Mutually exclusive with <c>security_group_id</c>. We recommend using <c>security_group_ids</c>. When both <c>security_group_id</c> and <c>security_group_ids</c> are specified, <c>security_group_ids</c> takes priority.</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>Alibaba Cloud OS security hardening. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enable Alibaba Cloud OS security hardening.</description></item>
            /// <item><description><c>false</c>: disable Alibaba Cloud OS security hardening.</description></item>
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
            /// <para>Whether to enable China classified protection of cybersecurity (China MLPS) hardening. China MLPS hardening can be enabled for nodes only when the system image is set to Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3. Alibaba Cloud provides China MLPS 2.0 Level III baseline check standards and scanning programs for Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3 images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// <para>Number of available instance types. The scaling group creates preemptible instances in a balanced manner among the lowest-cost instance types. Valid values: [1,10\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Whether to enable supplementing preemptible instances. When enabled, the scaling group attempts to create new instances to replace preemptible instances that are about to be reclaimed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enable supplementing preemptible instances.</description></item>
            /// <item><description><c>false</c>: disable supplementing preemptible instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// <para>Market price range configuration for a single preemptible instance type.</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
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
                /// <para>Maximum price per instance.
                /// &lt;props=&quot;china&quot;&gt;Unit: CNY/hour.</para>
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
            /// <item><description><para><c>NoSpot</c>: non-preemptible instance.</para>
            /// </description></item>
            /// <item><description><para><c>SpotWithPriceLimit</c>: set a maximum price for preemptible instances.</para>
            /// </description></item>
            /// <item><description><para><c>SpotAsPriceGo</c>: the system automatically bids at the current market price.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/165053.html">Preemptible instances</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>Whether to enable burst (performance bursting) for the node system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enable.</description></item>
            /// <item><description>false: disable.</description></item>
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
            /// <para>Multiple disk types for the system disk. When a higher-priority disk type is unavailable, the next-priority disk type is automatically used to create the system disk.</para>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>Node system disk type. Valid values:</para>
            /// <list type="bullet">
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
            /// <para>Encryption algorithm used by the system disk. Valid values: aes-256.</para>
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
            /// <item><description><para>true: encrypt.</para>
            /// </description></item>
            /// <item><description><para>false: do not encrypt.</para>
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
            /// <para>KMS key ID used by the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("system_disk_kms_key_id")]
            [Validation(Required=false)]
            public string SystemDiskKmsKeyId { get; set; }

            /// <summary>
            /// <para>Node system disk performance level. Only applicable to ESSD disks. The performance level is related to disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// <list type="bullet">
            /// <item><description>PL0: moderate peak concurrent I/O performance with relatively stable read/write latency.</description></item>
            /// <item><description>PL1: moderate peak concurrent I/O performance with relatively stable read/write latency.</description></item>
            /// <item><description>PL2: high peak concurrent I/O performance with stable read/write latency.</description></item>
            /// <item><description>PL3: ultra-high peak concurrent I/O performance with extremely stable read/write latency.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>Pre-configured read/write IOPS for the node system disk.</para>
            /// <para>Valid values: 0 to min{50,000, 1000\*capacity - baseline performance}. Baseline performance = min{1,800+50\*capacity, 50000}.</para>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>Node system disk size. Unit: GiB.</para>
            /// <para>Valid values: [20,2048\].</para>
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
            /// <para>Tag keys cannot be duplicated and can be up to 128 characters in length. Tag keys and tag values cannot start with “aliyun” or “acs:”, or contain “https://” or “http://”.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupTags> Tags { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupTags : TeaModel {
                /// <summary>
                /// <para>Tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-k-1</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-v-1</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>List of vSwitch IDs. Valid values: [1,8\].</para>
            /// <remarks>
            /// <para>To ensure high availability, we recommend that you select vSwitches in different zones.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
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
        public CreateClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class CreateClusterNodePoolRequestTeeConfig : TeaModel {
            /// <summary>
            /// <para>Whether to enable confidential computing for the cluster.</para>
            /// <list type="bullet">
            /// <item><description><para>true: enable confidential computing.</para>
            /// </description></item>
            /// <item><description><para>false: disable confidential computing.</para>
            /// </description></item>
            /// </list>
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
