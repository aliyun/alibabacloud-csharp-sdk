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
        /// <para>The access control list (ACL) for the API server SLB of a registered cluster.</para>
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// <para>The custom API server certificate Subject Alternative Names (SANs). This parameter adds custom IP addresses or domain names to the SAN field of the cluster API server certificate for client access control.</para>
        /// <para>Only managed clusters support this parameter.</para>
        /// </summary>
        [NameInMap("api_server_custom_cert_sans")]
        [Validation(Required=false)]
        public ModifyClusterRequestApiServerCustomCertSans ApiServerCustomCertSans { get; set; }
        public class ModifyClusterRequestApiServerCustomCertSans : TeaModel {
            /// <summary>
            /// <para>Specifies whether to overwrite or append the SAN configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>overwrite: overwrites the existing SAN configuration.</description></item>
            /// <item><description>append: appends to the existing SAN configuration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>append</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The SAN list.</para>
            /// </summary>
            [NameInMap("subject_alternative_names")]
            [Validation(Required=false)]
            public List<string> SubjectAlternativeNames { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the cluster is attached with an EIP for public network access to the API server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The cluster is attached with an EIP.</description></item>
        /// <item><description><c>false</c>: The cluster is not attached with an EIP.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("api_server_eip")]
        [Validation(Required=false)]
        public bool? ApiServerEip { get; set; }

        /// <summary>
        /// <para>The instance ID of the EIP attached to the cluster API server. This parameter takes effect only when <c>api_server_eip</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-wz9fnasl6dsfhmvci****</para>
        /// </summary>
        [NameInMap("api_server_eip_id")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        /// <summary>
        /// <para>The client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af31042c-6355-495b-b6e3-exxb9669</para>
        /// </summary>
        [NameInMap("client_token")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The custom cluster name. The name must be 1 to 63 characters in length and can contain digits, Chinese characters, letters, and hyphens (-). It cannot start with a hyphen (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-new-name</para>
        /// </summary>
        [NameInMap("cluster_name")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The cluster specification when <c>cluster_type</c> is set to <c>ManagedKubernetes</c> and <c>profile</c> is configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ack.pro.small</c>: Pro</description></item>
        /// <item><description><c>ack.pro.xlarge</c>: Pro XL</description></item>
        /// <item><description><c>ack.pro.2xlarge</c>: Pro 2XL</description></item>
        /// <item><description><c>ack.pro.4xlarge</c>: Pro 4XL (contact customer service to be added to the whitelist)</description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are three tiers provided by &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>. By pre-allocating and dedicating control plane resources, these tiers ensure that API concurrency and pod scheduling capabilities remain at a consistently high level. They are suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For information about the cluster management fees for Pro and Provisioned Control Plane editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>The control plane configuration for dedicated clusters.</para>
        /// </summary>
        [NameInMap("control_plane_config")]
        [Validation(Required=false)]
        public ModifyClusterRequestControlPlaneConfig ControlPlaneConfig { get; set; }
        public class ModifyClusterRequestControlPlaneConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for control plane node instances. This parameter takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables auto-renewal.</description></item>
            /// <item><description><c>false</c>: Disables auto-renewal.</description></item>
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
            /// <para>The auto-renewal period for each renewal of control plane node instances.</para>
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
            /// <item><description><c>PrePaid</c>: subscription.</description></item>
            /// <item><description><c>PostPaid</c>: pay-as-you-go.</description></item>
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
            /// <item><description><c>true</c>: Installs the CloudMonitor agent.</description></item>
            /// <item><description><c>false</c>: Does not install the CloudMonitor agent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cloud_monitor_flags")]
            [Validation(Required=false)]
            public bool? CloudMonitorFlags { get; set; }

            /// <summary>
            /// <para>The CPU management policy for nodes. The following policies are supported for clusters running version 1.12.6 or later:</para>
            /// <list type="bullet">
            /// <item><description><c>static</c>: Allows pods with certain resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.</description></item>
            /// <item><description><c>none</c>: Uses the existing default CPU affinity scheme.</description></item>
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
            /// <para>The custom image ID. Specify this parameter when using a custom image.</para>
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
            /// <item><description><c>AliyunLinux3</c>: Alinux3 image.</description></item>
            /// <item><description><c>Custom</c>: custom image.</description></item>
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
            /// <para>The node service port range. Valid port range: [30000, 65535].</para>
            /// <para>Default value: 30000-32767.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("node_port_range")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>The subscription duration for control plane node instances. This parameter takes effect and is required only when <c>charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para>When <c>period_unit=Month</c>, valid values: {1, 2, 3, 6, 12, 24, 36, 48, 60}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The billing period unit for control plane node instances. This parameter takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para><c>Month</c>: The billing period is measured in months. Currently, only months are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The container runtime name. Valid values:</para>
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
            /// <para>Specifies whether to enable Alibaba Cloud OS security hardening. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables Alibaba Cloud OS security hardening.</description></item>
            /// <item><description><c>false</c>: Disables Alibaba Cloud OS security hardening.</description></item>
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
            /// <para>Specifies whether to enable MLPS 2.0 security hardening. For more information, see <a href="https://help.aliyun.com/document_detail/196148.html">China Chinese ACK MLPS 2.0 security hardening</a>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enables MLPS 2.0 security hardening.</description></item>
            /// <item><description><c>false</c>: Disables MLPS 2.0 security hardening.</description></item>
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
            /// <para>Specifies whether to enable burst mode for the node system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enabled.</description></item>
            /// <item><description><c>false</c>: Disabled.</description></item>
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
            /// <para>The type of the node system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_efficiency</c>: ultra cloud disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
            /// <item><description><c>cloud_essd</c>: ESSD.</description></item>
            /// <item><description><c>cloud_auto</c>: ESSD AutoPL cloud disk.</description></item>
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry cloud disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the node system cloud disk. This parameter takes effect only for ESSD cloud disks. The performance level varies based on the cloud disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS for the node system cloud disk. Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}. Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the node system cloud disk. Valid values: 40 to 500. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The ID of the automatic snapshot policy used by the node system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-2zej1nogjvovnz4z****</para>
            /// </summary>
            [NameInMap("system_disk_snapshot_policy_id")]
            [Validation(Required=false)]
            public string SystemDiskSnapshotPolicyId { get; set; }

        }

        /// <summary>
        /// <para>The cluster connection configuration.</para>
        /// </summary>
        [NameInMap("control_plane_endpoints_config")]
        [Validation(Required=false)]
        public ModifyClusterRequestControlPlaneEndpointsConfig ControlPlaneEndpointsConfig { get; set; }
        public class ModifyClusterRequestControlPlaneEndpointsConfig : TeaModel {
            /// <summary>
            /// <para>The internal domain name configuration for the cluster. This applies to ACK managed clusters. The internal domain name is used by node-side system components such as kubelet and kube-proxy to access the API server. If the internal domain name access is not enabled, node-side system components access the API server through the CLB IP address.</para>
            /// </summary>
            [NameInMap("internal_dns_config")]
            [Validation(Required=false)]
            public ModifyClusterRequestControlPlaneEndpointsConfigInternalDnsConfig InternalDnsConfig { get; set; }
            public class ModifyClusterRequestControlPlaneEndpointsConfigInternalDnsConfig : TeaModel {
                /// <summary>
                /// <para>The VPCs in which the internal domain name DNS records take effect.</para>
                /// </summary>
                [NameInMap("bind_vpcs")]
                [Validation(Required=false)]
                public List<string> BindVpcs { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable internal domain name access for the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enables internal domain name access. Node-side components (kubelet, kube-proxy) access the API server through the internal domain name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The load balancing configuration for cluster access.</para>
            /// </summary>
            [NameInMap("load_balancers_config")]
            [Validation(Required=false)]
            public List<ModifyClusterRequestControlPlaneEndpointsConfigLoadBalancersConfig> LoadBalancersConfig { get; set; }
            public class ModifyClusterRequestControlPlaneEndpointsConfigLoadBalancersConfig : TeaModel {
                /// <summary>
                /// <para>The endpoint type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("endpoint_type")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                /// <summary>
                /// <para>The SLB instance associated with the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nlb-xxxx</para>
                /// </summary>
                [NameInMap("load_balancer_id")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

        }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the cluster. This prevents accidental deletion of the cluster through the console or API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables cluster deletion protection. The cluster cannot be deleted through the console or API.</description></item>
        /// <item><description><c>false</c>: Disables cluster deletion protection. The cluster can be deleted through the console or API.</description></item>
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
        /// <para>Specifies whether to enable or disable the RRSA feature. Only managed clusters support this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enable.</description></item>
        /// <item><description><c>false</c>: Disable.</description></item>
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
        /// <para>Specifies whether to rebind the test domain name of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Rebinds the test domain name of the cluster.</description></item>
        /// <item><description><c>false</c>: Does not rebind the test domain name of the cluster.</description></item>
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
        /// <para>The instance ID of the SLB for the cluster to be modified.</para>
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
        /// <para>Specifies whether to enable instance deletion protection. This prevents accidental deletion of nodes through the console or API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Nodes cannot be accidentally deleted through the console or API.</description></item>
        /// <item><description><c>false</c>: Nodes can be deleted through the console or API.</description></item>
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
        /// <para>The O&amp;M window configuration for the cluster. This feature takes effect only in ACK Pro managed clusters.</para>
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// <para>The automatic O&amp;M policy for the cluster.</para>
        /// </summary>
        [NameInMap("operation_policy")]
        [Validation(Required=false)]
        public ModifyClusterRequestOperationPolicy OperationPolicy { get; set; }
        public class ModifyClusterRequestOperationPolicy : TeaModel {
            /// <summary>
            /// <para>The automatic cluster upgrade configuration.</para>
            /// </summary>
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public ModifyClusterRequestOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class ModifyClusterRequestOperationPolicyClusterAutoUpgrade : TeaModel {
                /// <summary>
                /// <para>The automatic cluster upgrade frequency. For more information, see <a href="https://help.aliyun.com/document_detail/2712866.html">Upgrade frequency</a>.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>patch: The latest patch version.</description></item>
                /// <item><description>stable: The second latest minor version.</description></item>
                /// <item><description>rapid: The latest minor version.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>patch</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable automatic cluster upgrade.</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enables automatic upgrade.</para>
                /// </description></item>
                /// <item><description><para>false: Disables automatic upgrade.</para>
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
        /// <para>The control plane security group ID.</para>
        /// <list type="bullet">
        /// <item><description>If you have configured blocking rules in the security group, make sure the security group rules allow the protocols and ports that the cluster depends on. For the recommended security group rule scope, see <a href="https://help.aliyun.com/document_detail/353191.html">Configure and manage cluster security groups</a>.</description></item>
        /// <item><description>For non-ACK dedicated clusters, the cluster control plane and installed managed components (such as terway-controlplane) will briefly restart during the cluster management procedure. Perform this operation during off-peak hours. After the control plane security group is changed, the elastic network interfaces (ENIs) used by the cluster control plane and installed managed components are automatically added to the new security group.</description></item>
        /// <item><description>For ACK dedicated clusters, after the control plane security group is changed, newly scaled-out master nodes automatically apply the new control plane security group. Existing control plane nodes are not affected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1h6rk3pgct2a08***</para>
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The system event storage configuration.</para>
        /// </summary>
        [NameInMap("system_events_logging")]
        [Validation(Required=false)]
        public ModifyClusterRequestSystemEventsLogging SystemEventsLogging { get; set; }
        public class ModifyClusterRequestSystemEventsLogging : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable system event storage.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables system event storage.</para>
            /// </description></item>
            /// <item><description><para>false: Disables system event storage.</para>
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
            /// <para>The name of the LogProject for system event storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-cb95aa626a47740afbf6aa099b65****</para>
            /// </summary>
            [NameInMap("logging_project")]
            [Validation(Required=false)]
            public string LoggingProject { get; set; }

        }

        /// <summary>
        /// <para>The cluster time zone. See <a href="https://help.aliyun.com/document_detail/354879.html">Supported time zones</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>After the time zone is changed, the cluster inspection configuration uses the new time zone settings.</para>
        /// </description></item>
        /// <item><description><para>For managed clusters, the cluster control plane and installed managed components (such as terway-controlplane) will briefly restart during the change. Perform this operation during off-peak hours. After the time zone is changed, newly scaled-out nodes automatically apply the new time zone settings. Existing nodes are not affected. You can use the node pool node reset feature to apply the new settings to existing nodes.</para>
        /// </description></item>
        /// <item><description><para>For dedicated clusters, after the time zone is changed, newly scaled-out nodes (including control plane nodes) automatically apply the new time zone settings. Existing nodes (including control plane nodes) are not affected. You can use the node pool node reset feature to apply the new settings to existing nodes. For control plane nodes, you need to scale out and then scale in to apply the settings to all control plane nodes.</para>
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
        /// <para>The control plane vSwitches of the cluster. For dedicated clusters, the change applies to newly scaled-out control plane nodes. For managed clusters, note the following when changing control plane vSwitches:</para>
        /// <list type="bullet">
        /// <item><description>This parameter performs an overwrite update. You must specify the complete target vSwitch list.</description></item>
        /// <item><description>Control plane components will briefly restart during the change. Proceed with caution.</description></item>
        /// <item><description>Make sure all security groups of the cluster (including the control plane security group, security groups of all node pools, and security groups used by the container network) allow inbound and outbound traffic for the IP CIDR blocks of the new vSwitches. This prevents nodes and containers from being unable to connect to the API server.</description></item>
        /// <item><description>If the new control plane vSwitches have ACL rules configured, make sure the ACL rules allow communication with the IP CIDR blocks of cluster nodes and the container network.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

    }

}
