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
        /// <para>Access control list for the registered cluster API Server SLB.</para>
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// <para>Custom API Server certificate SAN (Subject Alternative Name).
        /// Used to add custom IPs or domain names to the SAN field of the cluster API Server server certificate for client access control.</para>
        /// <para>Only managed clusters support this parameter.</para>
        /// </summary>
        [NameInMap("api_server_custom_cert_sans")]
        [Validation(Required=false)]
        public ModifyClusterRequestApiServerCustomCertSans ApiServerCustomCertSans { get; set; }
        public class ModifyClusterRequestApiServerCustomCertSans : TeaModel {
            /// <summary>
            /// <para>Overwrite or append SAN configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>overwrite: Overwrite.</description></item>
            /// <item><description>append: Append.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>append</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>SAN list.</para>
            /// </summary>
            [NameInMap("subject_alternative_names")]
            [Validation(Required=false)]
            public List<string> SubjectAlternativeNames { get; set; }

        }

        /// <summary>
        /// <para>Whether to associate an EIP with the cluster for public access to API Server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Associate an EIP with the cluster.</description></item>
        /// <item><description><c>false</c>: Do not associate an EIP with the cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("api_server_eip")]
        [Validation(Required=false)]
        public bool? ApiServerEip { get; set; }

        /// <summary>
        /// <para>The ID of the EIP instance associated with the cluster API Server. This parameter takes effect only when <c>api_server_eip</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-wz9fnasl6dsfhmvci****</para>
        /// </summary>
        [NameInMap("api_server_eip_id")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        /// <summary>
        /// <para>Custom cluster name. The name can contain digits, Chinese characters, English characters, or hyphens (-), must be 1 to 63 characters in length, and cannot start with a hyphen (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-new-name</para>
        /// </summary>
        [NameInMap("cluster_name")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>When <c>cluster_type</c> is set to <c>ManagedKubernetes</c> and <c>profile</c> is configured, specifies the cluster specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ack.pro.small</c>: Pro Edition</description></item>
        /// <item><description><c>ack.pro.xlarge</c>: Pro XL</description></item>
        /// <item><description><c>ack.pro.2xlarge</c>: Pro 2XL</description></item>
        /// <item><description><c>ack.pro.4xlarge</c>: Pro 4XL (requires contacting customer service to enable allowlisting)</description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are three tiers provided by &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>. By pre-allocating and fixing control plane resources, it ensures that API concurrency and Pod scheduling capabilities are always at a determined high level, suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For cluster management fees for Pro Edition and Provisioned Control Plane editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster Management Fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster Management Fees</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>Dedicated cluster control plane configuration.</para>
        /// </summary>
        [NameInMap("control_plane_config")]
        [Validation(Required=false)]
        public ModifyClusterRequestControlPlaneConfig ControlPlaneConfig { get; set; }
        public class ModifyClusterRequestControlPlaneConfig : TeaModel {
            /// <summary>
            /// <para>Whether to enable automatic renewal for control plane node instances. This parameter takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enable automatic renewal.</description></item>
            /// <item><description><c>false</c>: Disable automatic renewal.</description></item>
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
            /// <para>Duration for each automatic renewal of control plane node instances.</para>
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
            /// <para>Control plane node instance billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PrePaid</c>: Subscription.</description></item>
            /// <item><description><c>PostPaid</c>: Pay-as-you-go.</description></item>
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
            /// <para>Whether to install the Cloud Monitor agent on control plane nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Install the Cloud Monitor agent.</description></item>
            /// <item><description><c>false</c>: Do not install the Cloud Monitor agent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cloud_monitor_flags")]
            [Validation(Required=false)]
            public bool? CloudMonitorFlags { get; set; }

            /// <summary>
            /// <para>Node CPU management policy. When the cluster version is 1.12.6 or later, the following two policies are supported:</para>
            /// <list type="bullet">
            /// <item><description><c>static</c>: Allows enhanced CPU affinity and exclusivity for Pods with certain resource characteristics on the node.</description></item>
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
            /// <para>Deployment set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp10b35imuam5amw****</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>Custom image ID. Specified when using a custom image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20240819.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>Operating system image type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>AliyunLinux3</c>: Alinux3 image.</description></item>
            /// <item><description><c>Custom</c>: Custom image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux3</para>
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>Instance types. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance Family</a>.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>Key pair name. Mutually exclusive with <c>login_password</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>SSH login password. Mutually exclusive with <c>key_pair</c>. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. If you want to use password login, specify this parameter during scale-out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ack@2000.</para>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>Node service port range.
            /// Available port range: [30000, 65535].</para>
            /// <para>Default value: 30000-32767.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("node_port_range")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>Control plane node instance subscription duration. This parameter takes effect and is required only when <c>charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para>When <c>period_unit=Month</c>, valid values: {1, 2, 3, 6, 12, 24, 36, 48, 60}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>Control plane node instance billing period. This parameter takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>.</para>
            /// <para><c>Month</c>: Billed on a monthly basis. Currently, only monthly billing is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>Container runtime name. Valid values:</para>
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
            /// <item><description><c>true</c>: Enable Alibaba Cloud OS security hardening.</description></item>
            /// <item><description><c>false</c>: Disable Alibaba Cloud OS security hardening.</description></item>
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
            /// <para>Number of control plane nodes. To scale out the dedicated cluster control plane, this parameter specifies the target number of control plane nodes and must be greater than the current number of control plane nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>Security hardening for compliance. For more information, see <a href="https://help.aliyun.com/document_detail/196148.html">ACK Security Hardening for Compliance</a>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enable security hardening for compliance.</description></item>
            /// <item><description><c>false</c>: Disable security hardening for compliance.</description></item>
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
            /// <para>Whether to enable burst (performance bursting) for the node system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enable.</description></item>
            /// <item><description><c>false</c>: Disable.</description></item>
            /// </list>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>Node system disk type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_efficiency</c>: Ultra disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: SSD disk.</description></item>
            /// <item><description><c>cloud_essd</c>: ESSD disk.</description></item>
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
            /// <para>Node system disk performance level. Only applicable to ESSD disks. The performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>Provisioned read/write IOPS for the node system disk. Valid values: 0 to min{50,000, 1000<em>capacity - baseline performance}. Baseline performance = min{1,800 + 50</em>capacity, 50,000}.</para>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>Node system disk size. Valid values: [40, 500]. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>Automatic snapshot policy ID for the node system disk.</para>
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
            /// <para>Cluster internal domain name configuration. Applicable to ACK managed clusters. The cluster internal domain name is used by node-side system components such as kubelet and kube-proxy to access the API Server. When the cluster internal domain name access is not enabled, node-side system components access via the CLB IP.</para>
            /// </summary>
            [NameInMap("internal_dns_config")]
            [Validation(Required=false)]
            public ModifyClusterRequestControlPlaneEndpointsConfigInternalDnsConfig InternalDnsConfig { get; set; }
            public class ModifyClusterRequestControlPlaneEndpointsConfigInternalDnsConfig : TeaModel {
                /// <summary>
                /// <para>VPCs where the cluster internal domain name record resolution takes effect.</para>
                /// </summary>
                [NameInMap("bind_vpcs")]
                [Validation(Required=false)]
                public List<string> BindVpcs { get; set; }

                /// <summary>
                /// <para>Whether to enable cluster internal domain name access. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enable cluster internal domain name access. Node-side components (kubelet, kube-proxy) will access the API Server through the cluster internal domain name.</description></item>
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
        /// <para>Cluster deletion protection, which prevents accidental deletion of the cluster through the console or API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enable cluster deletion protection. The cluster cannot be deleted through the console or API.</description></item>
        /// <item><description><c>false</c>: Disable cluster deletion protection. The cluster can be deleted through the console or API.</description></item>
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
        /// <para>Enable or disable the RRSA feature (only managed clusters support this parameter). Valid values:</para>
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
        /// <para>Rebind the cluster test domain. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Rebind the cluster test domain.</description></item>
        /// <item><description><c>false</c>: Do not rebind the cluster test domain.</description></item>
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
        /// <para>SLB instance ID of the cluster to be modified.</para>
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
        /// <para>Instance deletion protection to prevent accidental deletion and release of nodes through the console or API. Valid values:</para>
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
        /// <para>Cluster maintenance window. This feature only takes effect for ACK Pro managed clusters.</para>
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// <para>Cluster automatic O&amp;M policy.</para>
        /// </summary>
        [NameInMap("operation_policy")]
        [Validation(Required=false)]
        public ModifyClusterRequestOperationPolicy OperationPolicy { get; set; }
        public class ModifyClusterRequestOperationPolicy : TeaModel {
            /// <summary>
            /// <para>Cluster automatic upgrade.</para>
            /// </summary>
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public ModifyClusterRequestOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class ModifyClusterRequestOperationPolicyClusterAutoUpgrade : TeaModel {
                /// <summary>
                /// <para>Cluster automatic upgrade frequency. For more information, see <a href="https://help.aliyun.com/document_detail/2712866.html">Upgrade Frequency</a>.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>patch: Latest patch version.</description></item>
                /// <item><description>stable: Second latest minor version.</description></item>
                /// <item><description>rapid: Latest minor version.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>patch</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Whether to enable cluster automatic upgrade.</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enable automatic upgrade.</para>
                /// </description></item>
                /// <item><description><para>false: Disable automatic upgrade.</para>
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
        /// <para>Cluster resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyvw3wjm****</para>
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Control plane security group ID.</para>
        /// <list type="bullet">
        /// <item><description>If you have configured blocking rules in the security group, ensure that the security group rules allow the protocols and ports required by the cluster. For recommended security group rules, see <a href="https://help.aliyun.com/document_detail/353191.html">Configure and Manage Cluster Security Groups</a>.</description></item>
        /// <item><description>For non-ACK dedicated clusters, during the change process, the cluster control plane and installed managed components (such as terway-controlplane) will briefly restart. We recommend performing this operation during off-peak hours. After the control plane security group is changed, the ENIs used by the cluster control plane and installed managed components will be automatically added to the new security group.</description></item>
        /// <item><description>For ACK dedicated clusters, after the control plane security group is changed, newly scaled-out Master nodes will automatically use the new control plane security group. Existing control plane nodes are not affected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1h6rk3pgct2a08***</para>
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>System event storage configuration.</para>
        /// </summary>
        [NameInMap("system_events_logging")]
        [Validation(Required=false)]
        public ModifyClusterRequestSystemEventsLogging SystemEventsLogging { get; set; }
        public class ModifyClusterRequestSystemEventsLogging : TeaModel {
            /// <summary>
            /// <para>Whether to enable system event storage.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable system event storage.</para>
            /// </description></item>
            /// <item><description><para>false: Disable system event storage.</para>
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
            /// <para>LogProject name for system event storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-cb95aa626a47740afbf6aa099b65****</para>
            /// </summary>
            [NameInMap("logging_project")]
            [Validation(Required=false)]
            public string LoggingProject { get; set; }

        }

        /// <summary>
        /// <para>Cluster timezone. See <a href="https://help.aliyun.com/document_detail/354879.html">Supported Timezones</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>After changing the timezone, cluster inspection configurations will use the new timezone settings.</para>
        /// </description></item>
        /// <item><description><para>For managed clusters, during the change process, the cluster control plane and installed managed components (such as terway-controlplane) will briefly restart. We recommend performing this operation during off-peak hours. After changing the timezone, newly scaled-out nodes will automatically use the new timezone settings. Existing nodes are not affected. You can use the node pool node reset feature to apply the new settings to existing nodes.</para>
        /// </description></item>
        /// <item><description><para>For dedicated clusters, after changing the timezone, newly scaled-out nodes (including control plane nodes) will automatically use the new timezone settings. Existing nodes (including control plane nodes) are not affected. You can use the node pool node reset feature to apply the new settings to existing nodes. For control plane nodes, you need to scale out first and then scale in to apply the settings to all control plane nodes.</para>
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
        /// <para>Cluster control plane vSwitches. For dedicated clusters, this takes effect on newly scaled-out control plane nodes. When modifying control plane vSwitches for managed clusters, note the following:</para>
        /// <list type="bullet">
        /// <item><description>This parameter performs a full overwrite update. You must specify the complete list of target vSwitches.</description></item>
        /// <item><description>During the change, control plane components will briefly restart. Proceed with caution.</description></item>
        /// <item><description>Ensure that all security groups of the cluster (including the control plane security group, all node pool security groups, and container network security groups) allow inbound and outbound traffic for the IP ranges of the new vSwitches to prevent nodes and containers from being unable to connect to the API Server.</description></item>
        /// <item><description>If the new control plane vSwitches have ACL rules configured, ensure that the ACL rules allow communication with the cluster nodes, container network, and other IP ranges.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

    }

}
