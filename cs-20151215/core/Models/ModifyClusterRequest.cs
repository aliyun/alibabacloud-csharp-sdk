// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The access control list for the API server SLB of registered clusters.</para>
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// <para>This parameter adds custom IP addresses or domain names to the SAN field of the API server certificate to control client access.</para>
        /// <para>Only managed clusters support this parameter.</para>
        /// </summary>
        [NameInMap("api_server_custom_cert_sans")]
        [Validation(Required=false)]
        public ModifyClusterRequestApiServerCustomCertSans ApiServerCustomCertSans { get; set; }
        public class ModifyClusterRequestApiServerCustomCertSans : TeaModel {
            /// <summary>
            /// <para>Specifies whether to overwrite or append the SAN configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>overwrite: Overwrites the existing configuration.</para>
            /// </description></item>
            /// <item><description><para>append: Appends to the existing configuration.</para>
            /// </description></item>
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
        /// <para>Specifies whether to bind an EIP to the cluster for public network access to the API server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Binds an EIP to the cluster.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not bind an EIP to the cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("api_server_eip")]
        [Validation(Required=false)]
        public bool? ApiServerEip { get; set; }

        /// <summary>
        /// <para>The EIP instance ID bound to the cluster API server. This parameter takes effect only when <c>api_server_eip</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-wz9fnasl6dsfhmvci****</para>
        /// </summary>
        [NameInMap("api_server_eip_id")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        /// <summary>
        /// <para>The custom cluster name. The name can contain digits, letters, Chinese characters, and hyphens (-). It must be 1 to 63 characters in length and cannot start with a hyphen (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-new-name</para>
        /// </summary>
        [NameInMap("cluster_name")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The cluster specification when you set <c>cluster_type</c> to <c>ManagedKubernetes</c> and configure <c>profile</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ack.pro.small</c>: Pro</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.xlarge</c>: Pro XL</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.2xlarge</c>: Pro 2XL</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.4xlarge</c>: Pro 4XL (requires approval from customer service to enable)</para>
        /// </description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are three tiers provided by &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>. These tiers pre-allocate and dedicate control plane resources to ensure consistent high performance for API concurrency and pod scheduling. They are suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For cluster management fees for Pro and provisioned control plane clusters, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>Control plane configuration for dedicated clusters.</para>
        /// </summary>
        [NameInMap("control_plane_config")]
        [Validation(Required=false)]
        public ModifyClusterRequestControlPlaneConfig ControlPlaneConfig { get; set; }
        public class ModifyClusterRequestControlPlaneConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for control plane node instances. This parameter takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables auto-renewal.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables auto-renewal.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal duration for each renewal of control plane node instances.</para>
            /// <para>Valid values: {1, 2, 3, 6, 12}. Unit: months.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The billing method for control plane node instances. Valid values:</para>
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
            [NameInMap("charge_type")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to install the CloudMonitor agent on control plane nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Installs the CloudMonitor agent.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not install the CloudMonitor agent.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cloud_monitor_flags")]
            [Validation(Required=false)]
            public bool? CloudMonitorFlags { get; set; }

            /// <summary>
            /// <para>The CPU management policy for nodes. Clusters of version 1.12.6 or later support the following policies:</para>
            /// <list type="bullet">
            /// <item><description><para><c>static</c>: Enhances CPU affinity and exclusivity for pods with specific resource characteristics on nodes.</para>
            /// </description></item>
            /// <item><description><para><c>none</c>: Uses the default CPU affinity scheme.</para>
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
            /// <para>The deployment set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp10b35imuam5amw****</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>The custom image ID. Specify this parameter when you use a custom image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20240819.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The operating system image type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>AliyunLinux3</c>: Alinux3 image.</para>
            /// </description></item>
            /// <item><description><para><c>Custom</c>: Custom image.</para>
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
            /// <para>The instance types. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The key pair name. Specify either this parameter or <c>login_password</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>The SSH logon password. Specify either this parameter or <c>key_pair</c>. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. To use password-based logon, specify this parameter during scale-out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ack@2000.</para>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>Valid port range: [30000,65535].</para>
            /// <para>Default value: 30000-32767.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("node_port_range")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>The subscription duration for control plane node instances. This parameter is required and takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para>When <c>period_unit=Month</c>, valid values are {1, 2, 3, 6, 12, 24, 36, 48, 60}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The billing cycle for control plane node instances. This parameter takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para><c>Month</c>: Billing by month. Only monthly billing is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The container runtime. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>containerd</c>: Recommended. Supported by all cluster versions.</description></item>
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
            /// <para>The number of control plane nodes. To scale out the control plane of a dedicated cluster, set this parameter to the target number of control plane nodes, which must be greater than the current number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>MLPS 2.0 security hardening. For more information, see <a href="https://help.aliyun.com/document_detail/196148.html">Use MLPS 2.0 security hardening for ACK</a>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables MLPS 2.0 security hardening.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables MLPS 2.0 security hardening.</para>
            /// </description></item>
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
            /// <para>Specifies whether to enable performance burst for node system disks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables performance burst.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables performance burst.</para>
            /// </description></item>
            /// </list>
            /// <para>You can set this parameter only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The system disk category for nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cloud_efficiency</c>: Ultra disk.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_ssd</c>: Standard SSD.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_essd</c>: ESSD.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_auto</c>: ESSD AutoPL.</para>
            /// </description></item>
            /// <item><description><para><c>cloud_essd_entry</c>: ESSD Entry.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of node system disks. This parameter applies only to ESSDs. The performance level depends on the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS for node system disks. Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}. Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
            /// <para>You can set this parameter only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The system disk size for nodes. Valid values: [40,500]. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The automatic snapshot policy ID for node system disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-2zej1nogjvovnz4z****</para>
            /// </summary>
            [NameInMap("system_disk_snapshot_policy_id")]
            [Validation(Required=false)]
            public string SystemDiskSnapshotPolicyId { get; set; }

        }

        /// <summary>
        /// <para>Cluster connection configuration.</para>
        /// </summary>
        [NameInMap("control_plane_endpoints_config")]
        [Validation(Required=false)]
        public ModifyClusterRequestControlPlaneEndpointsConfig ControlPlaneEndpointsConfig { get; set; }
        public class ModifyClusterRequestControlPlaneEndpointsConfig : TeaModel {
            /// <summary>
            /// <para>Internal domain name configuration for the cluster. This feature is available for ACK managed clusters. Cluster internal domain names allow node-side system components such as kubelet and kube-proxy to access the API server. If this feature is disabled, node-side system components access the API server through the CLB IP address.</para>
            /// </summary>
            [NameInMap("internal_dns_config")]
            [Validation(Required=false)]
            public ModifyClusterRequestControlPlaneEndpointsConfigInternalDnsConfig InternalDnsConfig { get; set; }
            public class ModifyClusterRequestControlPlaneEndpointsConfigInternalDnsConfig : TeaModel {
                /// <summary>
                /// <para>The VPCs where cluster internal domain name resolution takes effect.</para>
                /// </summary>
                [NameInMap("bind_vpcs")]
                [Validation(Required=false)]
                public List<string> BindVpcs { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable cluster internal domain name access. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enables cluster internal domain name access. Node-side components (kubelet, kube-proxy) access the API server through the cluster internal domain name.</description></item>
                /// </list>
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
        /// <para>Enables or disables cluster deletion protection to prevent accidental cluster deletion from the console or using APIs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enables cluster deletion protection. You cannot delete the cluster from the console or using APIs.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables cluster deletion protection. You can delete the cluster from the console or using APIs.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>Enables or disables the RRSA feature. Only managed clusters support this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enables RRSA.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables RRSA.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable_rrsa")]
        [Validation(Required=false)]
        public bool? EnableRrsa { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to rebind the cluster test domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Rebinds the cluster test domain name.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not rebind the cluster test domain name.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ingress_domain_rebinding")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? IngressDomainRebinding { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The SLB instance ID of the cluster to be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-wz97kes8tnndkpodw****</para>
        /// </summary>
        [NameInMap("ingress_loadbalancer_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string IngressLoadbalancerId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Enables or disables instance deletion protection to prevent accidental release of nodes from the console or using APIs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Prevents accidental node deletion from the console or using APIs.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Allows accidental node deletion from the console or using APIs.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("instance_deletion_protection")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? InstanceDeletionProtection { get; set; }

        /// <summary>
        /// <para>The maintenance window of the cluster. This feature is available only for ACK managed clusters Pro.</para>
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// <para>Automatic O\&amp;M policy for the cluster.</para>
        /// </summary>
        [NameInMap("operation_policy")]
        [Validation(Required=false)]
        public ModifyClusterRequestOperationPolicy OperationPolicy { get; set; }
        public class ModifyClusterRequestOperationPolicy : TeaModel {
            /// <summary>
            /// <para>Automatic cluster upgrade.</para>
            /// </summary>
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public ModifyClusterRequestOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class ModifyClusterRequestOperationPolicyClusterAutoUpgrade : TeaModel {
                /// <summary>
                /// <para>The frequency of automatic cluster upgrades. For more information, see <a href="https://help.aliyun.com/document_detail/2712866.html">Upgrade frequency</a>.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>patch: Latest patch version.</para>
                /// </description></item>
                /// <item><description><para>stable: Second latest minor version.</para>
                /// </description></item>
                /// <item><description><para>rapid: Latest minor version.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>patch</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable automatic cluster upgrades.</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enables automatic upgrades.</para>
                /// </description></item>
                /// <item><description><para>false: Disables automatic upgrades.</para>
                /// </description></item>
                /// </list>
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
        /// <para>The security group ID for the control plane.</para>
        /// <list type="bullet">
        /// <item><description><para>If you configure blocking rules in the security group, ensure that the security group rules allow the protocols and ports required by the cluster. For recommended security group rules, see <a href="https://help.aliyun.com/document_detail/353191.html">Configure and manage cluster security groups</a>.</para>
        /// </description></item>
        /// <item><description><para>For non-dedicated ACK clusters, the control plane and installed managed components (such as terway-controlplane) restart briefly during the update. Perform this operation during off-peak hours. After you change the control plane security group, the ENIs used by the control plane and managed components are automatically added to the new security group.</para>
        /// </description></item>
        /// <item><description><para>For ACK dedicated clusters, newly scaled-out master nodes automatically apply the new control plane security group. Existing control plane nodes are unaffected.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1h6rk3pgct2a08***</para>
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>System event logging configuration.</para>
        /// </summary>
        [NameInMap("system_events_logging")]
        [Validation(Required=false)]
        public ModifyClusterRequestSystemEventsLogging SystemEventsLogging { get; set; }
        public class ModifyClusterRequestSystemEventsLogging : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable system event logging.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables system event logging.</para>
            /// </description></item>
            /// <item><description><para>false: Disables system event logging.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The LogProject name for system event logging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-cb95aa626a47740afbf6aa099b65****</para>
            /// </summary>
            [NameInMap("logging_project")]
            [Validation(Required=false)]
            public string LoggingProject { get; set; }

        }

        /// <summary>
        /// <para>The cluster time zone. For more information, see <a href="https://help.aliyun.com/document_detail/354879.html">Supported time zones</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>After you change the time zone, cluster inspection configurations use the new time zone.</para>
        /// </description></item>
        /// <item><description><para>For managed clusters, the control plane and installed managed components (such as terway-controlplane) restart briefly during the update. Perform this operation during off-peak hours. Newly scaled-out nodes automatically apply the new time zone. Existing nodes are unaffected. You can reset nodes in node pools to apply the new time zone to existing nodes.</para>
        /// </description></item>
        /// <item><description><para>For dedicated clusters, newly scaled-out nodes (including control plane nodes) automatically apply the new time zone. Existing nodes (including control plane nodes) are unaffected. You can reset nodes in node pools to apply the new time zone to existing nodes. For control plane nodes, scale out and then scale in to apply the new time zone to all control plane nodes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The vSwitches for the cluster control plane. For dedicated clusters, the change applies only to newly scaled-out control plane nodes. When you change the control plane vSwitches for managed clusters, note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter performs an overwrite update. You must specify the complete target vSwitch list.</para>
        /// </description></item>
        /// <item><description><para>Control plane components restart briefly during the update. Proceed with caution.</para>
        /// </description></item>
        /// <item><description><para>Ensure that all security groups (including those for the control plane, all node pools, and container networking) allow inbound and outbound traffic for the IP CIDR blocks of the new vSwitches. Otherwise, nodes and containers cannot connect to the API server.</para>
        /// </description></item>
        /// <item><description><para>If the new control plane vSwitches have ACL rules configured, ensure that these rules allow communication between the vSwitches and the IP CIDR blocks of cluster nodes and container networks.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

    }

}
