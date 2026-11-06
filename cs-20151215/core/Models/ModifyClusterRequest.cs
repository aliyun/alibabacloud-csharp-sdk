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
        /// <para>The access control list of the SLB instance for the API server of the registered cluster.</para>
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// <para>The custom Subject Alternative Names (SANs) for the API server certificate. You can add custom IP addresses or domain names to the SAN field of the API server certificate to implement access control for clients.</para>
        /// <para>Only managed clusters support this parameter.</para>
        /// </summary>
        [NameInMap("api_server_custom_cert_sans")]
        [Validation(Required=false)]
        public ModifyClusterRequestApiServerCustomCertSans ApiServerCustomCertSans { get; set; }
        public class ModifyClusterRequestApiServerCustomCertSans : TeaModel {
            /// <summary>
            /// <para>Specifies whether to overwrite or append the SAN configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>overwrite: overwrites the existing configuration.</description></item>
            /// <item><description>append: appends to the existing configuration.</description></item>
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
        /// <para>Specifies whether an EIP is attached to the cluster for public network access to the API server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: attaches an EIP to the cluster.</description></item>
        /// <item><description><c>false</c>: does not attach an EIP to the cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("api_server_eip")]
        [Validation(Required=false)]
        public bool? ApiServerEip { get; set; }

        /// <summary>
        /// <para>The EIP instance ID attached to the API server of the cluster. This parameter takes effect only when <c>api_server_eip</c> is set to <c>true</c>.</para>
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
        /// <para>The specification of the cluster when <c>cluster_type</c> is set to <c>ManagedKubernetes</c> and <c>profile</c> is configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ack.pro.small</c>: Pro Edition</description></item>
        /// <item><description><c>ack.pro.xlarge</c>: Pro XL</description></item>
        /// <item><description><c>ack.pro.2xlarge</c>: Pro 2XL</description></item>
        /// <item><description><c>ack.pro.4xlarge</c>: Pro 4XL (contact customer service to apply for whitelist access)</description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are the three tiers provided by the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>. By pre-allocating and reserving control plane resources, these tiers ensure that API concurrency and pod scheduling capabilities are always maintained at a consistently high level. They are suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For more information about the cluster management fees for the Pro Edition and provisioned control plane editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>.</para>
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
            /// <para>Specifies whether to enable auto-renewal for the control plane node instances. This parameter takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables auto-renewal.</description></item>
            /// <item><description><c>false</c>: disables auto-renewal.</description></item>
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
            /// <para>The auto-renewal period for the control plane node instances.</para>
            /// <para>Valid values: 1, 2, 3, 6, and 12. Unit: months.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The billing method of the control plane node instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PrePaid</c>: subscription</description></item>
            /// <item><description><c>PostPaid</c>: pay-as-you-go</description></item>
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
            /// <para>Specifies whether to install the CloudMonitor agent on the control plane nodes. Valid values:</para>
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
            /// <para>The CPU management policy for nodes. The following two policies are supported when the cluster version is 1.12.6 or later:</para>
            /// <list type="bullet">
            /// <item><description><c>static</c>: allows pods with specific resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.</description></item>
            /// <item><description><c>none</c>: indicates that the default CPU affinity scheme is used.</description></item>
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
            /// <para>The type of the operating system image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>AliyunLinux3</c>: Alibaba Cloud Linux 3 image.</description></item>
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
            /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The name of the key pair. You must specify this parameter or <c>login_password</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>The SSH logon password. You must specify this parameter or <c>key_pair</c>. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. If you want to use a password for logon, you must specify this parameter during scale-out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ack@2000.</para>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The service port range of the node.
            /// Valid values: 30000 to 65535.</para>
            /// <para>Default value: 30000-32767.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("node_port_range")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>The subscription duration of the control plane node instances. This parameter is required and takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para>When <c>period_unit</c> is set to <c>Month</c>, valid values are 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The billing cycle of the control plane node instances. This parameter takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para><c>Month</c>: months. Currently, only months are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The name of the container runtime. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>containerd</c>: recommended. Supported by all cluster versions.</description></item>
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
            /// <item><description><c>true</c>: enables Alibaba Cloud OS security hardening.</description></item>
            /// <item><description><c>false</c>: disables Alibaba Cloud OS security hardening.</description></item>
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
            /// <para>The number of control plane nodes. If you want to scale out the control plane of a dedicated cluster, set this parameter to the target number of control plane nodes, which must be greater than the current number of control plane nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable MLPS 2.0 security hardening. For more information, see <a href="https://help.aliyun.com/document_detail/196148.html">ACK MLPS 2.0 security hardening instructions</a>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables MLPS 2.0 security hardening.</description></item>
            /// <item><description><c>false</c>: disables MLPS 2.0 security hardening.</description></item>
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
            /// <para>Specifies whether to enable the burst mode for the system cloud disk of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: yes</description></item>
            /// <item><description><c>false</c>: no</description></item>
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
            /// <para>The type of the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_efficiency</c>: ultra disk</description></item>
            /// <item><description><c>cloud_ssd</c>: standard SSD</description></item>
            /// <item><description><c>cloud_essd</c>: ESSD</description></item>
            /// <item><description><c>cloud_auto</c>: ESSD AutoPL cloud disk</description></item>
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry cloud disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the system cloud disk. This parameter takes effect only for ESSDs. The performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read and write IOPS of the system cloud disk. Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}. Baseline performance = min{1,800 + 50 × capacity, 50000}.</para>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Valid values: 40 to 500. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the system cloud disk of the node.</para>
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
            /// <para>The internal DNS configuration for ACK managed clusters. Internal domain names are used by node-side system components such as kubelet and kube-proxy to access the API server. If internal DNS access is not enabled, node-side system components access the API server by using the CLB IP address.</para>
            /// </summary>
            [NameInMap("internal_dns_config")]
            [Validation(Required=false)]
            public ModifyClusterRequestControlPlaneEndpointsConfigInternalDnsConfig InternalDnsConfig { get; set; }
            public class ModifyClusterRequestControlPlaneEndpointsConfigInternalDnsConfig : TeaModel {
                /// <summary>
                /// <para>The VPCs where internal DNS resolution takes effect.</para>
                /// </summary>
                [NameInMap("bind_vpcs")]
                [Validation(Required=false)]
                public List<string> BindVpcs { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable internal DNS access for the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enables internal DNS access. Node-side components such as kubelet and kube-proxy access the API server by using the internal domain name.</description></item>
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
                /// <para>The ID of the Server Load Balancer (SLB) instance associated with the endpoint.</para>
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
        /// <para>Specifies whether to enable deletion protection for the cluster to prevent accidental deletion through the console or API calls. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables deletion protection. The cluster cannot be deleted through the console or API calls.</description></item>
        /// <item><description><c>false</c>: Disables deletion protection. The cluster can be deleted through the console or API calls.</description></item>
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
        /// <para>Specifies whether to enable the RAM Roles for Service Accounts (RRSA) feature. Only managed clusters support this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables the feature.</description></item>
        /// <item><description><c>false</c>: Disables the feature.</description></item>
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
        /// <para>Specifies whether to rebind the test domain name of the cluster to the SLB address of the Ingress. Valid values:</para>
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
        /// <para>The instance ID of the SLB for the Ingress of the cluster to be modified.</para>
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
        /// <para>Specifies whether to enable deletion protection for instances to prevent accidental deletion or release of nodes through the console or API calls. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables deletion protection. Nodes cannot be accidentally deleted or released through the console or API calls.</description></item>
        /// <item><description><c>false</c>: Disables deletion protection. Nodes can be accidentally deleted or released through the console or API calls.</description></item>
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
        /// <para>The maintenance window of the cluster. This feature takes effect only in ACK managed clusters of the Pro edition.</para>
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
                /// <para>The channel for automatic cluster upgrades. For more information, see <a href="https://help.aliyun.com/document_detail/2712866.html">Upgrade channels</a>.</para>
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
                /// <para>Specifies whether to enable automatic cluster upgrades. Valid values:</para>
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
        /// <para>The ID of the resource group to which the cluster belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyvw3wjm****</para>
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the control plane security group.</para>
        /// <list type="bullet">
        /// <item><description>If you have configured blocking rules in the security group, make sure that the security group rules allow the protocols and ports on which the cluster depends. For more information about the recommended security group rules for cluster management, see <a href="https://help.aliyun.com/document_detail/353191.html">Configure and manage cluster security groups</a>.</description></item>
        /// <item><description>For ACK clusters other than dedicated clusters, the cluster control plane and installed managed components such as terway-controlplane will be briefly restarted during the procedure. We recommend that you perform this operation during off-peak hours. After the control plane security group is changed, the elastic network interfaces (ENIs) used by the cluster control plane and installed managed components are automatically added to the new security group.</description></item>
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
        /// <para>The version support policy for the cluster. The value is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: Standard support.</description></item>
        /// <item><description>Extended: Extended support. After the standard support period ends, the cluster enters the extended support period and continues to receive CVE patch versions.
        /// Only ACK managed clusters of the Pro edition (where cluster_spec is set to ack.pro.* and profile is set to Default) support the Extended value. If you specify Extended for ACK standard clusters, ACS clusters, ACK managed clusters of the edge edition, or ACK dedicated clusters, the request will be rejected.
        /// If you do not specify this parameter, the current value of the cluster remains unchanged. After a cluster is upgraded to an extended support patch version, it cannot be changed back to Standard.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Extended</para>
        /// </summary>
        [NameInMap("support_policy")]
        [Validation(Required=false)]
        public string SupportPolicy { get; set; }

        /// <summary>
        /// <para>The system event logging configuration.</para>
        /// </summary>
        [NameInMap("system_events_logging")]
        [Validation(Required=false)]
        public ModifyClusterRequestSystemEventsLogging SystemEventsLogging { get; set; }
        public class ModifyClusterRequestSystemEventsLogging : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable system event logging. Valid values:</para>
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
            /// <para>The name of the LogProject for system event logging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-cb95aa626a47740afbf6aa099b65****</para>
            /// </summary>
            [NameInMap("logging_project")]
            [Validation(Required=false)]
            public string LoggingProject { get; set; }

        }

        /// <summary>
        /// <para>The time zone of the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/354879.html">Supported time zones</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>After the time zone is changed, the cluster inspection configuration adopts the new time zone settings.</para>
        /// </description></item>
        /// <item><description><para>For managed clusters, the cluster control plane and installed managed components such as terway-controlplane will be briefly restarted during the modification. We recommend that you perform this operation during off-peak hours. After the time zone is changed, newly scaled-out nodes automatically apply the new time zone settings. Existing nodes are not affected. You can use the node reset feature in the node pool to apply the new settings to existing nodes.</para>
        /// </description></item>
        /// <item><description><para>For dedicated clusters, after the time zone is changed, newly scaled-out nodes, including control plane nodes, automatically apply the new time zone settings. Existing nodes, including control plane nodes, are not affected. You can use the node reset feature in the node pool to apply the new settings to existing nodes. For control plane nodes, you must scale out and then scale in the nodes to apply the new settings to all control plane nodes.</para>
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
        /// <para>The vSwitches for the cluster control plane. For dedicated clusters, the change takes effect on newly scaled-out control plane nodes. For managed clusters, note the following when changing the control plane vSwitches:</para>
        /// <list type="bullet">
        /// <item><description>This parameter overwrites the existing configuration. You must specify the complete list of target vSwitches.</description></item>
        /// <item><description>Control plane components will be briefly restarted during the modification. Proceed with caution.</description></item>
        /// <item><description>Make sure that the inbound and outbound rules of all security groups in the cluster, including the control plane security group, security groups of all node pools, and security groups used by the container network, allow the CIDR blocks of the new vSwitches. This prevents nodes and containers from failing to connect to the API server.</description></item>
        /// <item><description>If ACL rules are configured for the new control plane vSwitches, make sure that the ACL rules allow communication with the CIDR blocks of cluster nodes and the container network.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

    }

}
