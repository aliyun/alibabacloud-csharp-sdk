// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterRequest : TeaModel {
        /// <summary>
        /// <para>The network access control list (ACL) of the SLB instance associated with the API server if the cluster is a registered cluster.</para>
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// <para>The custom subject alternative names (SANs) for the API server certificate to accept requests from specified IP addresses or domain names. This parameter is available only for ACK managed clusters.</para>
        /// </summary>
        [NameInMap("api_server_custom_cert_sans")]
        [Validation(Required=false)]
        public ModifyClusterRequestApiServerCustomCertSans ApiServerCustomCertSans { get; set; }
        public class ModifyClusterRequestApiServerCustomCertSans : TeaModel {
            /// <summary>
            /// <para>Specifies whether to overwrite or add SANs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>overwrite: overwrites SANs.</description></item>
            /// <item><description>append: adds SANs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>append</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The list of SANs.</para>
            /// </summary>
            [NameInMap("subject_alternative_names")]
            [Validation(Required=false)]
            public List<string> SubjectAlternativeNames { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to associate an elastic IP address (EIP) with the cluster. This EIP is used to enable access to the API server over the Internet. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: associates an EIP with the cluster.</description></item>
        /// <item><description><c>false</c>: does not associate an EIP with the cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("api_server_eip")]
        [Validation(Required=false)]
        public bool? ApiServerEip { get; set; }

        /// <summary>
        /// <para>The ID of the EIP that you want to associate with the API server of the cluster. This parameter takes effect when <c>api_server_eip</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-wz9fnasl6dsfhmvci****</para>
        /// </summary>
        [NameInMap("api_server_eip_id")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// <para>The cluster name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). The cluster name cannot start with a hyphen (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-new-name</para>
        /// </summary>
        [NameInMap("cluster_name")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The control plane configurations of an ACK dedicated cluster.</para>
        /// </summary>
        [NameInMap("control_plane_config")]
        [Validation(Required=false)]
        public ModifyClusterRequestControlPlaneConfig ControlPlaneConfig { get; set; }
        public class ModifyClusterRequestControlPlaneConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for the instance. This parameter takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
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
            /// <para>The auto-renewal period of the instance. Valid values: 1, 2, 3, 6, and 12.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PrePaid</c>: subscription.</description></item>
            /// <item><description><c>PostPaid</c>: pay-as-you-go.</description></item>
            /// </list>
            /// <para>Default value: <c>PostPaid</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("charge_type")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to install the CloudMonitor agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: installs the CloudMonitor agent.</description></item>
            /// <item><description><c>false</c>: does not install the CloudMonitor agent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cloud_monitor_flags")]
            [Validation(Required=false)]
            public bool? CloudMonitorFlags { get; set; }

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
            /// <para>The ID of the deployment set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp10b35imuam5amw****</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>The custom image ID. You must configure this parameter if you use a custom image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20240819.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The type of the OS image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>AliyunLinux3</c>: Alibaba Cloud Linux 3.</description></item>
            /// <item><description><c>Custom</c>: the custom image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux3</para>
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of ECS instance families</a>.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The name of the key pair. You must configure either this parameter or the <c>login_password</c> parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>The password for SSH logon. You must configure either this parameter or the <c>key_pair</c> parameter. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. To log on with a password, you must specify this parameter during the scale-out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ack@2000.</para>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The node port range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("node_port_range")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>The subscription duration of the instance. This parameter takes effect and is required only when <c>charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para>If <c>PeriodUnit=Month</c> is specified, the valid values are 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The billing cycle of the instance. This parameter takes effect only when <c>instance_charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para>Valid value: <c>Month</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The type of the container runtime. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>containerd</c>: supports all Kubernetes versions. We recommend that you set the parameter to this value.</description></item>
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
            /// <para>Specifies whether to enable Alibaba Cloud Linux Security Hardening. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables Alibaba Cloud Linux Security Hardening.</description></item>
            /// <item><description><c>false</c>: disables Alibaba Cloud Linux Security Hardening.</description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("security_hardening_os")]
            [Validation(Required=false)]
            public bool? SecurityHardeningOs { get; set; }

            /// <summary>
            /// <para>The number of control plane nodes. If you want to scale out the control plane in an ACK dedicated cluster, set this parameter to the desired number of nodes. This parameter must be greater than the current number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Multi-Level Protection Scheme (MLPS) security hardening. For more information, see <a href="https://help.aliyun.com/document_detail/196148.html">ACK security hardening based on MLPS</a>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables MLPS security hardening.</description></item>
            /// <item><description><c>false</c>: disables MLPS security hardening.</description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the burst feature for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables the burst feature.</description></item>
            /// <item><description><c>false</c>: disables the burst feature.</description></item>
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
            /// <para>The type of the node system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cloud</c>: basic disk.</description></item>
            /// <item><description><c>cloud_efficiency</c>: ultra disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
            /// <item><description><c>cloud_essd</c>: enhanced SSD (ESSD).</description></item>
            /// <item><description><c>cloud_auto</c>: ESSD AutoPL disk.</description></item>
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the system disk that you want to use for the node. This parameter is effective only for ESSDs. This parameter is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The preset read/write input/output operations per second (IOPS) of the system disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS} Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
            /// <para>This parameter is effective only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The type of the system disk. Valid values: [40,500]. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the node system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-2zej1nogjvovnz4z****</para>
            /// </summary>
            [NameInMap("system_disk_snapshot_policy_id")]
            [Validation(Required=false)]
            public string SystemDiskSnapshotPolicyId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable cluster deletion protection. If you enable this option, the cluster cannot be deleted in the console or by calling API operations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables cluster deletion protection.</description></item>
        /// <item><description><c>false</c>: disables cluster deletion protection.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the RAM Roles for Service Accounts (RRSA) feature. This parameter is available only for ACK managed clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the RRSA feature.</description></item>
        /// <item><description><c>false</c>: disables the RRSA feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable_rrsa")]
        [Validation(Required=false)]
        public bool? EnableRrsa { get; set; }

        /// <summary>
        /// <para>Specifies whether to remap the test domain name of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: remaps the test domain name of the cluster.</description></item>
        /// <item><description><c>false</c>: does not remap the test domain name of the cluster.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ingress_domain_rebinding")]
        [Validation(Required=false)]
        public bool? IngressDomainRebinding { get; set; }

        /// <summary>
        /// <para>The ID of the Server Load Balancer (SLB) instance of the cluster to be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-wz97kes8tnndkpodw****</para>
        /// </summary>
        [NameInMap("ingress_loadbalancer_id")]
        [Validation(Required=false)]
        public string IngressLoadbalancerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable instance deletion protection. If you enable this option, the instance cannot be deleted in the console or by calling API operations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables instance deletion protection.</description></item>
        /// <item><description><c>false</c>: disables instance deletion protection.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("instance_deletion_protection")]
        [Validation(Required=false)]
        public bool? InstanceDeletionProtection { get; set; }

        /// <summary>
        /// <para>The cluster maintenance window. This feature takes effect only for ACK Pro clusters.</para>
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// <para>The automatic O\&amp;M policy of the cluster.</para>
        /// </summary>
        [NameInMap("operation_policy")]
        [Validation(Required=false)]
        public ModifyClusterRequestOperationPolicy OperationPolicy { get; set; }
        public class ModifyClusterRequestOperationPolicy : TeaModel {
            /// <summary>
            /// <para>The configurations of automatic update.</para>
            /// </summary>
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public ModifyClusterRequestOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class ModifyClusterRequestOperationPolicyClusterAutoUpgrade : TeaModel {
                /// <summary>
                /// <para>The frequency of automatic cluster updates. For more information, see <a href="https://help.aliyun.com/document_detail/2712866.html">Update frequency</a>.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>patch: the latest patch version.</description></item>
                /// <item><description>stables: the second-latest minor version.</description></item>
                /// <item><description>rapid: the latest minor version.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>patch</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable automatic update.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

        }

        /// <summary>
        /// <para>The resource group ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyvw3wjm****</para>
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The storage configurations of system events.</para>
        /// </summary>
        [NameInMap("system_events_logging")]
        [Validation(Required=false)]
        public ModifyClusterRequestSystemEventsLogging SystemEventsLogging { get; set; }
        public class ModifyClusterRequestSystemEventsLogging : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable system event storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service project that stores system events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-cb95aa626a47740afbf6aa099b65****</para>
            /// </summary>
            [NameInMap("logging_project")]
            [Validation(Required=false)]
            public string LoggingProject { get; set; }

        }

        /// <summary>
        /// <para>The vSwitches of the control plane. This parameter can be used to change the vSwitches of the control plane in an ACK managed cluster. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter overwrites the existing configuration. You must specify all vSwitches of the control plane.</description></item>
        /// <item><description>The control plane restarts during the change process. Exercise caution when you perform this operation.</description></item>
        /// <item><description>Ensure that all security groups of the cluster, including the security groups of the control plane, all node pools, and container network, are allowed to access the CIDR blocks of the new vSwitches. This ensures that the nodes and containers can connect to the API server.</description></item>
        /// <item><description>If the new vSwitches of the control plane are configured with an ACL, ensure that the ACL allows communication between the new vSwitches and CIDR blocks such as those of the cluster nodes and the container network.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

    }

}
