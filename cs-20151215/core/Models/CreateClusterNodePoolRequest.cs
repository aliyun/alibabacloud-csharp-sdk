// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>The intelligent managed node pool configurations.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoMode AutoMode { get; set; }
        public class CreateClusterNodePoolRequestAutoMode : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the intelligent managed mode.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables the intelligent managed mode. You can enable this mode only when the intelligent managed mode is enabled for the cluster.</para>
            /// </description></item>
            /// <item><description><para>false: Disables the intelligent managed mode.</para>
            /// </description></item>
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
        /// <para>The auto scaling configurations.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class CreateClusterNodePoolRequestAutoScaling : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>[This parameter is deprecated] Use \<c>internet_charge_type\\</c> and \<c>internet_max_bandwidth_out\\</c> instead.</para>
            /// <para>The peak bandwidth of the EIP. Unit: Mbps.</para>
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
            /// <para>[This parameter is deprecated] Use \<c>internet_charge_type\\</c> and \<c>internet_max_bandwidth_out\\</c> instead.</para>
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
            /// <item><description><para><c>true</c>: Enables auto scaling for the node pool. If the resources planned for the cluster cannot meet the scheduling requirements of pods, Container Service for Kubernetes (ACK) automatically scales out or scales in nodes based on the configured minimum and maximum numbers of instances. For clusters of Kubernetes 1.24 or later, instant scaling is enabled by default. For clusters of a Kubernetes version earlier than 1.24, node autoscaling is enabled by default. For more information, see <a href="https://help.aliyun.com/document_detail/2746785.html">Node scaling</a>.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables auto scaling. ACK adjusts the number of nodes in the node pool based on the value of \<c>desired_size\\</c> to maintain a specific number of nodes.</para>
            /// </description></item>
            /// </list>
            /// <para>If you set this parameter to false, other parameters in \<c>auto_scaling\\</c> do not take effect.</para>
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
            /// <para>[This parameter is deprecated] This parameter is deprecated. Use \<c>internet_charge_type\\</c> and \<c>internet_max_bandwidth_out\\</c> instead.</para>
            /// <para>Specifies whether to associate an EIP with the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: associates an EIP with the node.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: does not associate an EIP with the node.</para>
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
            /// <para>The maximum number of instances that can be created in the node pool. This does not include existing instances. This parameter takes effect only if \<c>enable\\</c> is set to \<c>true\\</c>.</para>
            /// <para>The value must be in the range of [\<c>min_instances\\</c>, 2000]. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>The minimum number of instances that can be created in the node pool. This does not include existing instances. This parameter takes effect only if \<c>enable\\</c> is set to \<c>true\\</c>.</para>
            /// <para>The value must be in the range of [0, \<c>max_instances\\</c>]. Default value: 0.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>If the minimum number of instances is not 0, the specified number of ECS instances are automatically created after the scaling group is created.</para>
            /// </description></item>
            /// <item><description><para>We recommend that you set the maximum number of instances to a value that is not smaller than the current number of nodes in the node pool. Otherwise, nodes in the node pool are scaled in after auto scaling is enabled.</para>
            /// </description></item>
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
            /// <para>The type of instances that are automatically scaled. This parameter takes effect only if \<c>enable\\</c> is set to \<c>true\\</c>. Valid values:</para>
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
            /// <remarks>
            /// <para>Notice: You cannot change the value of this parameter after the node pool is created.</para>
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
        /// <para>[This parameter is deprecated] Use desired_size instead.</para>
        /// <para>The number of nodes in the node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The Lingjun node pool configurations.</para>
        /// </summary>
        [NameInMap("eflo_node_group")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestEfloNodeGroup EfloNodeGroup { get; set; }
        public class CreateClusterNodePoolRequestEfloNodeGroup : TeaModel {
            /// <summary>
            /// <para>The ID of the Lingjun cluster that you want to associate with the Lingjun node pool when you create the node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i1169130516633730****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The ID of the Lingjun group in the Lingjun cluster that you want to associate with the Lingjun node pool when you create the node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-ec3c96ff0aa****</para>
            /// </summary>
            [NameInMap("group_id")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to use the host network for the pod network.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: host network. Pods directly use the network stack of the host and share the IP address and ports with the host.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: container network. Pods have an independent network stack and do not occupy host network ports.</para>
        /// </description></item>
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
        /// <para>[This parameter is deprecated]</para>
        /// <para>The configurations of the edge node pool.</para>
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        [Obsolete]
        public CreateClusterNodePoolRequestInterconnectConfig InterconnectConfig { get; set; }
        public class CreateClusterNodePoolRequestInterconnectConfig : TeaModel {
            /// <summary>
            /// <para>[This parameter is deprecated]</para>
            /// <para>The network bandwidth of the enhanced edge node pool. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>[This parameter is deprecated]</para>
            /// <para>The ID of the CCN instance that is associated with the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            public string CcnId { get; set; }

            /// <summary>
            /// <para>[This parameter is deprecated]</para>
            /// <para>The region of the CCN instance that is associated with the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            public string CcnRegionId { get; set; }

            /// <summary>
            /// <para>[This parameter is deprecated]</para>
            /// <para>The ID of the CEN instance that is associated with the enhanced edge node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("cen_id")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>[This parameter is deprecated]</para>
            /// <para>The subscription duration of the enhanced edge node pool. Unit: months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("improved_period")]
            [Validation(Required=false)]
            public string ImprovedPeriod { get; set; }

        }

        /// <summary>
        /// <para>The network type of the edge node pool. This parameter takes effect only for node pools of the \<c>edge\\</c> type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>basic</c>: public network. Nodes in the node pool interact with cloud nodes over the Internet. Applications in the node pool cannot directly access the VPC in the cloud.</para>
        /// </description></item>
        /// <item><description><para><c>private</c>: private network. Nodes in the node pool connect to the cloud over a leased line, VPN, or CEN to achieve higher communication quality and better security.</para>
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
        /// <para>Specifies whether nodes in the edge node pool can communicate with each other at Layer 3.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: All nodes in the node pool can communicate with each other at Layer 3.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: All hosts in the node pool cannot communicate with each other at Layer 3.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("intranet")]
        [Validation(Required=false)]
        public bool? Intranet { get; set; }

        /// <summary>
        /// <para>The cluster-related configurations.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class CreateClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to install Cloud Monitor on the ECS nodes. After Cloud Monitor is installed, you can view the monitoring information of the created ECS instances in the Cloud Monitor console. We recommend that you enable this feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Installs Cloud Monitor on the ECS nodes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not install Cloud Monitor on the ECS nodes.</para>
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
            /// <para>The CPU management policy of the node. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later:</para>
            /// <list type="bullet">
            /// <item><description><para><c>static</c>: Allows pods with specific resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.</para>
            /// </description></item>
            /// <item><description><para><c>none</c>: Enables the default CPU affinity scheme.</para>
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
            /// <para>The labels that you want to add to the nodes in the Kubernetes cluster.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>The custom node name. If you customize the node name, the node name, ECS instance name, and ECS instance hostname are changed.</para>
            /// <remarks>
            /// <para>For Windows instances for which custom node names are enabled, the hostname is fixed as the IP address. Hyphens (-) are used to replace periods (.) in the IP address. The hostname does not contain a prefix or a suffix.</para>
            /// </remarks>
            /// <para>A node name consists of a prefix, the node IP address, and a suffix.</para>
            /// <list type="bullet">
            /// <item><description><para>The total length must be 2 to 64 characters. The node name must start and end with a lowercase letter or a digit.</para>
            /// </description></item>
            /// <item><description><para>The prefix and suffix can contain uppercase letters, lowercase letters, digits, hyphens (-), and periods (.). They must start with an uppercase or lowercase letter. They cannot start or end with a hyphen (-) or a period (.). You cannot use consecutive hyphens (-)or periods (.). You cannot use consecutive hyphens (-) or periods (.).</para>
            /// </description></item>
            /// <item><description><para>The prefix is required (due to an ECS limit). The suffix is optional.</para>
            /// </description></item>
            /// <item><description><para>The node IP address is the complete private IP address of the node.</para>
            /// </description></item>
            /// </list>
            /// <para>For example, if the node IP address is 192.XX.YY.55, the prefix is aliyun.com, and the suffix is test.</para>
            /// <list type="bullet">
            /// <item><description><para>If the node is a Linux node, the node name, ECS instance name, and ECS instance hostname are all aliyun.com192.XX.YY.55test.</para>
            /// </description></item>
            /// <item><description><para>If the node is a Windows node, the ECS instance hostname is 192-XX-YY-55, and the node name and ECS instance name are both aliyun.com192.XX.YY.55test.</para>
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
            /// <para>The pre-join instance user data. The specified user data script is run before the node joins the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User-Data scripts</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGhpcyBpcyBhIGV4YW1wbGU</para>
            /// </summary>
            [NameInMap("pre_user_data")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>The name of the container runtime. ACK supports the following three container runtimes.</para>
            /// <list type="bullet">
            /// <item><description><para>containerd: We recommend that you use this runtime. It is supported by all cluster versions.</para>
            /// </description></item>
            /// <item><description><para>Sandboxed-Container.runv: a sandboxed container that provides higher isolation. It is supported by clusters of Kubernetes 1.31 or earlier.</para>
            /// </description></item>
            /// <item><description><para>docker: no longer maintained. It is supported by clusters of Kubernetes 1.22 or earlier.</para>
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
            /// <para>The taint configurations.</para>
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
            /// <para>true</para>
            /// </summary>
            [NameInMap("unschedulable")]
            [Validation(Required=false)]
            public bool? Unschedulable { get; set; }

            /// <summary>
            /// <para>The instance user data. After the node joins the cluster, the specified user data script is run. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">User-Data scripts</a>.</para>
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
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto node repair. This parameter takes effect only if \<c>enable\\</c> is set to \<c>true\\</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables auto node repair.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables auto node repair.</para>
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
            public CreateClusterNodePoolRequestManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether manual approval is required for node repair.</para>
                /// </summary>
                [NameInMap("approval_required")]
                [Validation(Required=false)]
                public bool? ApprovalRequired { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restart. This parameter takes effect only if \<c>auto_repair\\</c> is set to \<c>true\\</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Allows node restart.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disallows node restart.</para>
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
            /// <para>Specifies whether to enable auto node upgrade. This parameter takes effect only if \<c>enable\\</c> is set to \<c>true\\</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables auto node upgrade.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables auto node upgrade.</para>
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
            /// <para>The auto node upgrade policy.</para>
            /// </summary>
            [NameInMap("auto_upgrade_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow auto kubelet upgrade. This parameter takes effect only if \<c>auto_upgrade\\</c> is set to \<c>true\\</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Allows auto kubelet upgrade.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disallows auto kubelet upgrade.</para>
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
                /// <para>Specifies whether to allow auto OS upgrade. This parameter takes effect only if \<c>auto_upgrade\\</c> is set to \<c>true\\</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Allows auto OS upgrade.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disallows auto OS upgrade.</para>
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
                /// <para>Specifies whether to allow auto runtime upgrade. This parameter takes effect only if \<c>auto_upgrade\\</c> is set to \<c>true\\</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Allows auto runtime upgrade.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disallows auto runtime upgrade.</para>
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
            /// <para>Specifies whether to automatically fix CVE vulnerabilities. This parameter takes effect only if \<c>enable\\</c> is set to \<c>true\\</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Automatically fixes CVE vulnerabilities.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not automatically fix CVE vulnerabilities.</para>
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
            public CreateClusterNodePoolRequestManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>The packages that should be excluded from vulnerability fixing.</para>
                /// <para>Default value: <c>kernel</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kernel</para>
                /// </summary>
                [NameInMap("exclude_packages")]
                [Validation(Required=false)]
                public string ExcludePackages { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow node restart. This parameter takes effect only if \<c>auto_vul_fix\\</c> is set to \<c>true\\</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Allows node restart.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disallows node restart.</para>
                /// </description></item>
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
                /// <para>The vulnerability levels that are allowed to be automatically fixed. Separate multiple levels with commas. Example: <c>asap,later</c>. Supported vulnerability levels:</para>
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
            /// <para>Specifies whether to enable the managed node pool feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables the managed node pool feature.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables the managed node pool feature. If you set this parameter to \<c>false\\</c>, the other parameters of \<c>management\\</c> do not take effect.</para>
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
            /// <para>[This parameter is deprecated] Use the \<c>auto_upgrade\\</c> parameter instead.</para>
            /// <para>The auto upgrade configurations. This parameter takes effect only if \<c>enable\\</c> is set to \<c>true\\</c>.</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public CreateClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class CreateClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>[This parameter is deprecated] Use the \<c>auto_upgrade\\</c> parameter instead.</para>
                /// <para>Specifies whether to enable auto upgrade. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: enables auto upgrade.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: disables auto upgrade.</para>
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
                /// <para>The maximum number of unavailable nodes.
                /// The value must be in the range of [1, 1000].</para>
                /// <para>Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// <para>The number of extra nodes. You can specify only one of \<c>surge\\</c> and \<c>surge_percentage\\</c>.</para>
                /// <para>Nodes become unavailable during an upgrade. You can create extra nodes to compensate for the load on the cluster.</para>
                /// <remarks>
                /// <para>We recommend that the number of extra nodes does not exceed the current number of nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>The percentage of extra nodes. You can specify only one of \<c>surge\\</c> and \<c>surge_percentage\\</c>.</para>
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[This parameter is deprecated]</para>
        /// <para>The maximum number of nodes that the edge node pool can contain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public long? MaxNodes { get; set; }

        /// <summary>
        /// <para>A list of node components.</para>
        /// </summary>
        [NameInMap("node_components")]
        [Validation(Required=false)]
        public List<CreateClusterNodePoolRequestNodeComponents> NodeComponents { get; set; }
        public class CreateClusterNodePoolRequestNodeComponents : TeaModel {
            /// <summary>
            /// <para>The configurations of the node component.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestNodeComponentsConfig Config { get; set; }
            public class CreateClusterNodePoolRequestNodeComponentsConfig : TeaModel {
                /// <summary>
                /// <para>The custom configurations of the node component.</para>
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
        public CreateClusterNodePoolRequestNodeConfig NodeConfig { get; set; }
        public class CreateClusterNodePoolRequestNodeConfig : TeaModel {
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
        public CreateClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class CreateClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// <para>The name of the node pool.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nodepool-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the resource group. Instances that are created in the node pool belong to this resource group.</para>
            /// <para>A resource can belong to only one resource group. You can map resource groups to concepts such as projects, applications, or organizations based on your business scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjmb****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The type of the node pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ess</c>: a regular node pool. This type of node pool provides managed features and auto scaling.</para>
            /// </description></item>
            /// <item><description><para><c>edge</c>: an edge node pool.</para>
            /// </description></item>
            /// <item><description><para><c>lingjun</c>: a Lingjun node pool.</para>
            /// </description></item>
            /// <item><description><para><c>hybrid</c>: a hybrid cloud node pool.</para>
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
        public CreateClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class CreateClusterNodePoolRequestScalingGroup : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for the nodes in the node pool. This parameter takes effect only if \<c>instance_charge_type\\</c> is set to \<c>PrePaid\\</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enables auto-renewal.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disables auto-renewal.</para>
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
            /// <item><description><para>If \<c>PeriodUnit\\</c> is set to \<c>Week\\</c>: 1, 2, and 3.</para>
            /// </description></item>
            /// <item><description><para>If \<c>PeriodUnit\\</c> is set to \<c>Month\\</c>: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
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

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>[Deprecated] Use the \<c>security_hardening_os\\</c> parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("cis_enabled")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? CisEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the instance quantity requirement when \<c>multi_az_policy\\</c> is set to \<c>COST_OPTIMIZED\\</c> and spot instances cannot be created due to issues such as price or insufficient inventory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Allows the system to automatically create pay-as-you-go instances to meet the required number of ECS instances.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not allow the system to automatically create pay-as-you-go instances to meet the required number of ECS instances.</para>
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
            /// <para>The data disk configurations of the nodes in the node pool.</para>
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// <para>The ID of the deployment set. You can use a deployment set to distribute the ECS instances created in the node pool across different physical servers to ensure high availability and underlying disaster recovery. When you create ECS instances in a deployment set, the instances are launched in the specified region based on the deployment strategy that you set.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>After you select a deployment set, the maximum number of nodes in the node pool is limited. By default, a deployment set supports a maximum of 20 × Number of zones (the number of zones is determined by the vSwitches) nodes. Select a deployment set with sufficient quota to prevent node creation failures.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1d19mmbsv3jf6xxxxx</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>The expected number of nodes in the node pool.</para>
            /// <para>The total number of nodes that the node pool should maintain. We recommend that you configure at least two nodes to ensure that cluster components run as expected. You can adjust the expected number of nodes to scale out or scale in the node pool.</para>
            /// <para>If you do not need to create nodes, set this parameter to 0. You can manually adjust the number of nodes later.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>aliyun_2_1903_x64_20G_alibase_20200529.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The OS image type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>AliyunLinux</c>: Alinux2 image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinuxSecurity</c>: Alinux2 UEFI image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3</c>: Alinux3 image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3Arm64</c>: Alinux3 ARM image.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3Security</c>: Alinux3 UEFI image.</para>
            /// </description></item>
            /// <item><description><para><c>CentOS</c>: CentOS image.</para>
            /// </description></item>
            /// <item><description><para><c>Windows</c>: Windows image.</para>
            /// </description></item>
            /// <item><description><para><c>WindowsCore</c>: WindowsCore image.</para>
            /// </description></item>
            /// <item><description><para><c>ContainerOS</c>: Container-Optimized OS.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunLinux3ContainerOptimized</c>: Alinux3 Container-Optimized OS.</para>
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
            /// <para>The ECS instance metadata access configurations.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>The instance property configurations.</para>
            /// </summary>
            [NameInMap("instance_patterns")]
            [Validation(Required=false)]
            public List<InstancePatterns> InstancePatterns { get; set; }

            /// <summary>
            /// <para>A list of instance types for the nodes in the node pool. When the system creates nodes in the node pool, it selects an instance type from the list that meets the requirements.</para>
            /// <para>The number of instance types must be in the range of [1, 10].</para>
            /// <remarks>
            /// <para>For high availability, we recommend that you select multiple instance types.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The billing method of the public IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PayByBandwidth: pay-by-bandwidth.</para>
            /// </description></item>
            /// <item><description><para>PayByTraffic: pay-by-traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByTraffic</para>
            /// </summary>
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The maximum outbound public bandwidth of the node. Unit: Mbit/s. The value must be in the range of [1, 100].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>The name of the key pair that is used for passwordless logon. You must specify one of \<c>key_pair\\</c> and \<c>login_password\\</c>.</para>
            /// <remarks>
            /// <para>If you select Container-Optimized OS for the node pool, you can use only \<c>key_pair\\</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>np-key-name</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>Specifies whether to log on to the created ECS instances as a non-root user.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Logs on as the ecs-user.</para>
            /// </description></item>
            /// <item><description><para>false: Logs on as the root user.</para>
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
            /// <para>The SSH logon password. You must specify one of \<c>key_pair\\</c> and \<c>login_password\\</c>. The password must be 8 to 30 characters in length, and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The scaling policy for the ECS instances in the multi-zone scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PRIORITY</c>: Scales instances based on the vSwitch priority. The system scales instances based on the order of vSwitches that you specify in \<c>VSwitchIds.N\\</c>. If the system fails to create an ECS instance in the zone where the vSwitch with the highest priority resides, it automatically uses the vSwitch with the next highest priority to create the instance.</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>: Creates instances based on the vCPU unit price in ascending order. When multiple instance types are specified and the preemptible instance policy is configured, the system gives priority to creating the lowest-cost instance type. You can also use the \<c>CompensateWithOnDemand\\</c> parameter to specify whether to automatically create pay-as-you-go instances when preemptible instances cannot be created due to insufficient inventory.</para>
            /// <remarks>
            /// <para><c>COST_OPTIMIZED</c> takes effect only when multiple instance types are specified or the preemptible instance policy is configured.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>: Evenly distributes ECS instances across the specified zones. If the distribution of ECS instances becomes unbalanced due to insufficient inventory, you can call the API <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a> operation to balance the resource distribution.</para>
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
            /// <para>The minimum number of pay-as-you-go instances that must be included in the scaling group. The value must be in the range of [0, 1000]. If the number of pay-as-you-go instances is less than this value, the system gives priority to creating pay-as-you-go instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of pay-as-you-go instances among the extra instances that are created after the minimum number of pay-as-you-go instances (\<c>on_demand_base_capacity\\</c>) is met. The value must be in the range of [0, 100].</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The subscription duration of the nodes in the node pool. This parameter is required and takes effect only if \<c>instance_charge_type\\</c> is set to \<c>PrePaid\\</c>.</para>
            /// <list type="bullet">
            /// <item><description><para>If \<c>period_unit\\</c> is set to \<c>Week\\</c>, the valid values of \<c>period\\</c> are 1, 2, 3, and 4.</para>
            /// </description></item>
            /// <item><description><para>If \<c>period_unit\\</c> is set to \<c>Month\\</c>, the valid values of \<c>period\\</c> are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</para>
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
            /// <para>The billing cycle of the nodes in the node pool. This parameter is required and takes effect only if \<c>instance_charge_type\\</c> is set to \<c>PrePaid\\</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Month</c>: The billing cycle is measured in months.</para>
            /// </description></item>
            /// <item><description><para><c>Week</c>: The billing cycle is measured in weeks.</para>
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
            /// <para>[This parameter is deprecated] Use the \<c>image_type\\</c> parameter instead.</para>
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
            /// <para>null</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            [Obsolete]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The private pool configurations.</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// <para>The ID of the private pool. You must specify the private pool ID when \<c>match_criteria\\</c> is set to \<c>Target\\</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The type of the private pool. This parameter specifies the capacity of the private pool that you want to use to launch instances. An elastic assurance service or a capacity reservation service takes effect after it is generated. You can select a capacity type when you launch an instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Open</c>: Open mode. The system automatically matches the capacity of open private pools. If no matching private pool is found, the instance is launched using public pool resources.</para>
                /// </description></item>
                /// <item><description><para><c>Target</c>: Target mode. The instance is launched using the capacity of the specified private pool. If the capacity of the private pool is unavailable, the instance fails to be launched.</para>
                /// </description></item>
                /// <item><description><para><c>None</c>: The instance is launched without using the capacity of a private pool.</para>
                /// </description></item>
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
            /// <para>The name of the worker RAM role.</para>
            /// <list type="bullet">
            /// <item><description><para>If this parameter is left empty, the default worker RAM role of the cluster is used.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is not empty, the specified RAM role must be a <b>service role</b>, and its <b>trusted service</b> must be <b>Elastic Compute Service</b>. For more information, see <a href="https://help.aliyun.com/document_detail/116800.html">Create a service role</a>. If the specified RAM role is not the default worker RAM role of the cluster, the name of the role cannot start with \<c>KubernetesMasterRole-\\</c> or \<c>KubernetesWorkerRole-\\</c>.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>This parameter is supported only by ACK managed clusters of Kubernetes 1.22 or later.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-role</para>
            /// </summary>
            [NameInMap("ram_role_name")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>A list of RDS instances.</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>The resource pool and policy used to create instances. Note:
            /// This parameter takes effect only when you create pay-as-you-go instances.
            /// This parameter cannot be set at the same time as \<c>private_pool_options.match_criteria\\</c> and \<c>private_pool_options.id\\</c>.</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>A list of private pool IDs. These are the IDs of elastic assurance services or capacity reservation services. You can only specify the IDs of private pools in Target mode. The number of IDs must be in the range of 1 to 20.</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>The resource pool policy for instance creation. Resource pools include private pools (generated by elastic assurance or capacity reservation services) and public pools. Valid values:
                /// PrivatePoolFirst: Prioritizes private pools. If you specify \<c>resouce_pool_options.private_pool_ids\\</c>, the specified private pools are used first. If no private pool is specified or the specified pools have insufficient capacity, the system automatically tries to use open private pools. If no suitable private pool is found, the public pool is used.
                /// PrivatePoolOnly: Uses only private pools. You must specify \<c>resouce_pool_options.private_pool_ids\\</c>. If the specified private pools have insufficient capacity, the instance fails to launch.
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
            /// <item><description><para><c>release</c>: standard mode. The system creates and releases ECS instances to scale the group.</para>
            /// </description></item>
            /// <item><description><para><c>recycle</c>: accelerated mode. The system creates, stops, and starts ECS instances to scale the group. This improves the scaling speed. When an instance is stopped, its computing resources are not billed, but its storage resources are. This does not apply to instances with local disks.</para>
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

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The ID of the security group for the node pool. You must specify one of \<c>security_group_ids\\</c> and \<c>security_group_id\\</c>. We recommend that you specify \<c>security_group_ids\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-wz9a8g2mt6x5llu0****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>A list of security group IDs. You must specify one of \<c>security_group_ids\\</c> and \<c>security_group_id\\</c>. We recommend that you specify \<c>security_group_ids\\</c>. If you specify both \<c>security_group_id\\</c> and \<c>security_group_ids\\</c>, \<c>security_group_ids\\</c> takes precedence.</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>Alibaba Cloud OS security hardening. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables Alibaba Cloud OS security hardening.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables Alibaba Cloud OS security hardening.</para>
            /// </description></item>
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
            /// <para>Specifies whether to enable MLPS 2.0 security hardening. You can enable MLPS 2.0 security hardening for nodes only when you select Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3 for the OS image. Alibaba Cloud provides baseline check standards and scanning programs for Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3 Level 3 of MLPS 2.0 to ensure classified protection compliance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// <para>The number of instance types that you can specify. The scaling group creates preemptible instances of multiple instance types that are available at the lowest cost. The value must be in the range of [1, 10].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the instance reclaim mode. After this mode is enabled, when the system receives a message that a spot instance is about to be reclaimed, the scaling group attempts to create a new instance to replace the instance that is about to be reclaimed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables the instance reclaim mode.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables the instance reclaim mode.</para>
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
            /// <para>The configurations of the price range for a single spot instance.</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
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
                /// <para>The maximum bid price for a single instance.</para>
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
            /// <para>The bidding policy for the spot instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>NoSpot</c>: The instance is not a spot instance.</para>
            /// </description></item>
            /// <item><description><para><c>SpotWithPriceLimit</c>: Sets the maximum bid price for the spot instance.</para>
            /// </description></item>
            /// <item><description><para><c>SpotAsPriceGo</c>: The system automatically bids based on the current market price.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/165053.html">Spot instances</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the performance burst feature for the system disk of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes.</para>
            /// </description></item>
            /// <item><description><para>false: No.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter can be set only when \<c>system_disk_category\\</c> is set to \<c>cloud_auto\\</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The types of system disks. If a disk of a high-priority type is unavailable, the system automatically uses a disk of the next priority type to create the system disk.</para>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The type of the system disk of the node. Valid values:</para>
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
            /// <para>The encryption algorithm that is used to encrypt the system disk. Valid value: aes-256.</para>
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
            /// <para>The performance level of the system disk for each node. This parameter applies only to Enhanced SSD (ESSD) disks. The performance level of an ESSD is determined by its size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: A moderate maximum concurrent I/O performance and a relatively stable read/write latency.</para>
            /// </description></item>
            /// <item><description><para>PL1: A moderate maximum concurrent I/O performance and a relatively stable read/write latency.</para>
            /// </description></item>
            /// <item><description><para>PL2: A high maximum concurrent I/O performance and a stable read/write latency.</para>
            /// </description></item>
            /// <item><description><para>PL3: A very high maximum concurrent I/O performance and a very stable read/write latency.</para>
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
            /// <para>The provisioned read/write IOPS of the system disk of the node.</para>
            /// <para>Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
            /// <para>This parameter can be set only when \<c>system_disk_category\\</c> is set to \<c>cloud_auto\\</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk of the node. Unit: GiB.</para>
            /// <para>The value must be in the range of [20, 2048].</para>
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
            /// <para>A tag key cannot be repeated. The tag key can be up to 128 characters in length. The tag key and the tag value cannot start with “aliyun” or “acs:”, and cannot contain “https\://” or “http\://”.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupTags> Tags { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupTags : TeaModel {
                /// <summary>
                /// <para>The name of the tag.</para>
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
            /// <para>A list of vSwitch IDs. The number of vSwitch IDs must be in the range of [1, 8].</para>
            /// <remarks>
            /// <para>For high availability, we recommend that you select vSwitches in different zones.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the confidential computing cluster.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class CreateClusterNodePoolRequestTeeConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the confidential computing cluster.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables confidential computing.</para>
            /// </description></item>
            /// <item><description><para>false: Disables confidential computing.</para>
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
