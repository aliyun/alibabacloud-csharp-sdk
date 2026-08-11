// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The access control list for the API Server SLB of the registered cluster.</para>
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// <para>The list of cluster components. Use <c>addons</c> to specify the components to install when creating a cluster.</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<Addon> Addons { get; set; }

        /// <summary>
        /// <para>A ServiceAccount is the access credential for communication between a pod and the cluster API server. The <c>api-audiences</c> parameter specifies the valid request <c>token</c> identities used by the <c>apiserver</c> to authenticate whether a request <c>token</c> is valid. You can specify multiple <c>audience</c> values separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes.default.svc</para>
        /// </summary>
        [NameInMap("api_audiences")]
        [Validation(Required=false)]
        public string ApiAudiences { get; set; }

        /// <summary>
        /// <para>The cluster audit log configuration.</para>
        /// </summary>
        [NameInMap("audit_log_config")]
        [Validation(Required=false)]
        public CreateClusterRequestAuditLogConfig AuditLogConfig { get; set; }
        public class CreateClusterRequestAuditLogConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the cluster audit log feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The <a href="https://help.aliyun.com/document_detail/48873.html">Simple Log Service project</a> that contains the <a href="https://help.aliyun.com/document_detail/48873.html">Logstore</a> for cluster audit logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-c2345xxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("sls_project_name")]
            [Validation(Required=false)]
            public string SlsProjectName { get; set; }

        }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/2938898.html">intelligent managed mode</a> configuration.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public CreateClusterRequestAutoMode AutoMode { get; set; }
        public class CreateClusterRequestAutoMode : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable intelligent managed mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("auto_renew")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AutoRenew { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("auto_renew_period")]
        [Validation(Required=false)]
        [Obsolete]
        public long? AutoRenewPeriod { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("charge_type")]
        [Validation(Required=false)]
        [Obsolete]
        public string ChargeType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>security_hardening_os</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>security_hardening_os</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("cis_enabled")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? CisEnabled { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane node configuration, use the <c>cloud_monitor_flags</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>cms_enabled</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? CloudMonitorFlags { get; set; }

        /// <summary>
        /// <para>The cluster local domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster.local</para>
        /// </summary>
        [NameInMap("cluster_domain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// <para>If you set <c>cluster_type</c> to <c>ManagedKubernetes</c> and configure <c>profile</c>, you can further specify the cluster specifications. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><c>Kubernetes</c>: ACK dedicated cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The pod network CIDR block. It must be a valid private CIDR block, which includes the following CIDR blocks and their subnets: 10.0.0.0/8, 172.16-31.0.0/12-16, and 192.168.0.0/16. It cannot overlap with the CIDR blocks used by the VPC or existing Kubernetes clusters in the VPC. It cannot be modified after the cluster is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.0.0/16</para>
        /// </summary>
        [NameInMap("container_cidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        /// <summary>
        /// <para>The control plane configuration for ACK dedicated clusters.</para>
        /// </summary>
        [NameInMap("control_plane_config")]
        [Validation(Required=false)]
        public CreateClusterRequestControlPlaneConfig ControlPlaneConfig { get; set; }
        public class CreateClusterRequestControlPlaneConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for control plane nodes. This parameter is valid only when charge_type is set to <c>PrePaid</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal duration of control plane nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The billing method of control plane nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("charge_type")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to install CloudMonitor on nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("cloud_monitor_flags")]
            [Validation(Required=false)]
            public bool? CloudMonitorFlags { get; set; }

            /// <summary>
            /// <para>The CPU management policy for nodes.</para>
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
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20240819.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The operating system image type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux3</para>
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The instance metadata access configuration for ECS instances.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>The instance types of nodes.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The name of the key pair. Specify either this parameter or login_password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>The SSH logon password. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Specify either this parameter or key_pair.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The node service port range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("node_port_range")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>The subscription duration of control plane nodes. This parameter is valid and required only when charge_type is set to <c>PrePaid</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription duration of control plane nodes. This parameter is valid and required only when charge_type is set to <c>PrePaid</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The runtime name of control plane nodes. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Alibaba Cloud OS security hardening.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("security_hardening_os")]
            [Validation(Required=false)]
            public bool? SecurityHardeningOs { get; set; }

            /// <summary>
            /// <para>The number of control plane nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable MLPS security hardening.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable burst (performance burst) for the system cloud disk of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The type of the system cloud disk for nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the system cloud disk. This parameter takes effect only for ESSD disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the system cloud disk for nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk for nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The automatic snapshot policy for nodes.</para>
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
        public CreateClusterRequestControlPlaneEndpointsConfig ControlPlaneEndpointsConfig { get; set; }
        public class CreateClusterRequestControlPlaneEndpointsConfig : TeaModel {
            /// <summary>
            /// <para>The internal DNS configuration of the cluster. This applies to ACK managed clusters. The internal domain name is used by node-side system components such as kubelet and kube-proxy to access the API Server. If the internal domain name access is not enabled, node-side system components access the API Server through the CLB IP address.</para>
            /// </summary>
            [NameInMap("internal_dns_config")]
            [Validation(Required=false)]
            public CreateClusterRequestControlPlaneEndpointsConfigInternalDnsConfig InternalDnsConfig { get; set; }
            public class CreateClusterRequestControlPlaneEndpointsConfigInternalDnsConfig : TeaModel {
                /// <summary>
                /// <para>The VPCs in which the internal domain name DNS resolution takes effect.</para>
                /// </summary>
                [NameInMap("bind_vpcs")]
                [Validation(Required=false)]
                public List<string> BindVpcs { get; set; }

            }

            /// <summary>
            /// <para>The cluster connection configuration. When this field is specified, the endpoint_public_access and load_balancer_id parameters do not take effect.</para>
            /// </summary>
            [NameInMap("load_balancers_config")]
            [Validation(Required=false)]
            public List<CreateClusterRequestControlPlaneEndpointsConfigLoadBalancersConfig> LoadBalancersConfig { get; set; }
            public class CreateClusterRequestControlPlaneEndpointsConfigLoadBalancersConfig : TeaModel {
                /// <summary>
                /// <para>The endpoint type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("endpoint_type")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                /// <summary>
                /// <para>The NLB instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nlb-0ogk9aaxxxxxxx</para>
                /// </summary>
                [NameInMap("load_balancer_id")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of component names that specifies which control plane components to collect logs from.</para>
        /// </summary>
        [NameInMap("controlplane_log_components")]
        [Validation(Required=false)]
        public List<string> ControlplaneLogComponents { get; set; }

        /// <summary>
        /// <para>The Simple Log Service project for control plane component logs. You can use an existing project for log storage or allow the system to automatically create a project. If you choose automatic creation, a Simple Log Service project named <c>k8s-log-{ClusterID}</c> is automatically created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-log-xxx</para>
        /// </summary>
        [NameInMap("controlplane_log_project")]
        [Validation(Required=false)]
        public string ControlplaneLogProject { get; set; }

        /// <summary>
        /// <para>The number of days for control plane component log retention.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("controlplane_log_ttl")]
        [Validation(Required=false)]
        public string ControlplaneLogTtl { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the cpu_policy parameter under <c>control_plane_config</c> instead. For node pool configuration, use the cpu_policy parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        [Obsolete]
        public string CpuPolicy { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the <c>extra_sans</c> parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs.aliyun.com</para>
        /// </summary>
        [NameInMap("custom_san")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustomSan { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the cluster to prevent accidental deletion through the console or API. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> When cluster creation fails, rollback is not performed by default. You must manually clean up the failed cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("disable_rollback")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? DisableRollback { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the <c>rrsa_config</c> parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable_rrsa")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? EnableRrsa { get; set; }

        /// <summary>
        /// <para>The KMS key ID used to encrypt data cloud disks. For more information, see <a href="https://help.aliyun.com/document_detail/28935.html">Key Management Service</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0fe64791-55eb-4fc7-84c5-c6c7cdca****</para>
        /// </summary>
        [NameInMap("encryption_provider_key")]
        [Validation(Required=false)]
        public string EncryptionProviderKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to public network access. The API Server is exposed through an EIP to public network access to the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("endpoint_public_access")]
        [Validation(Required=false)]
        public bool? EndpointPublicAccess { get; set; }

        /// <summary>
        /// <para>The custom API Server certificate SAN (Subject Alternative Name).</para>
        /// </summary>
        [NameInMap("extra_sans")]
        [Validation(Required=false)]
        public List<string> ExtraSans { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Selecting existing nodes during cluster creation is not supported. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? FormatDisk { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>image_id</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>image_id</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp16z7xko3vvv8gt****</para>
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string ImageId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>image_type</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>image_type</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunLinux</para>
        /// </summary>
        [NameInMap("image_type")]
        [Validation(Required=false)]
        [Obsolete]
        public string ImageType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Selecting existing nodes during cluster creation is not supported. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> operation.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>The IP stack of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Valid values:</para>
        /// </summary>
        [NameInMap("ip_stack")]
        [Validation(Required=false)]
        public string IpStack { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic creation of an advanced security group. This parameter takes effect only when <c>security_group_id</c> is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("is_enterprise_security_group")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Selecting existing nodes during cluster creation is not supported. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? KeepInstanceName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the key_pair parameter under <c>control_plane_config</c> instead. For node pool configuration, use the key_pair parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>security-key</para>
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        [Obsolete]
        public string KeyPair { get; set; }

        /// <summary>
        /// <para>The cluster version, which is consistent with the Kubernetes community baseline version. Use the latest version. If you do not specify this parameter, the latest version is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>The CLB instance ID used for API Server access. When this parameter is specified, automatic creation of the API Server CLB is skipped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-wz9t256gqa3vbouk****</para>
        /// </summary>
        [NameInMap("load_balancer_id")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> CLB is billed on a pay-by-usage basis. This parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s2.small</para>
        /// </summary>
        [NameInMap("load_balancer_spec")]
        [Validation(Required=false)]
        [Obsolete]
        public string LoadBalancerSpec { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Enables the log service for the cluster. This parameter takes effect only for ACK Serverless clusters, and the value must be <c>SLS</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("logging_type")]
        [Validation(Required=false)]
        [Obsolete]
        public string LoggingType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the login_password parameter under <c>control_plane_config</c> instead. For node pool configuration, use the login_password parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        [Obsolete]
        public string LoginPassword { get; set; }

        /// <summary>
        /// <para>The cluster maintenance window.</para>
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the auto_renew parameter under <c>control_plane_config</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("master_auto_renew")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? MasterAutoRenew { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the auto_renew_period parameter under <c>control_plane_config</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("master_auto_renew_period")]
        [Validation(Required=false)]
        [Obsolete]
        public long? MasterAutoRenewPeriod { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the size parameter under <c>control_plane_config</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("master_count")]
        [Validation(Required=false)]
        [Obsolete]
        public long? MasterCount { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the instance_charge_type parameter under <c>control_plane_config</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("master_instance_charge_type")]
        [Validation(Required=false)]
        [Obsolete]
        public string MasterInstanceChargeType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the instance_types parameter under <c>control_plane_config</c> instead.</para>
        /// </summary>
        [NameInMap("master_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MasterInstanceTypes { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>unit</c> parameter under <c>control_plane_config</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("master_period")]
        [Validation(Required=false)]
        [Obsolete]
        public long? MasterPeriod { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the period_unit parameter under <c>control_plane_config</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("master_period_unit")]
        [Validation(Required=false)]
        [Obsolete]
        public string MasterPeriodUnit { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the system_disk_category parameter under <c>control_plane_config</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("master_system_disk_category")]
        [Validation(Required=false)]
        [Obsolete]
        public string MasterSystemDiskCategory { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the system_disk_performance_level parameter under <c>control_plane_config</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("master_system_disk_performance_level")]
        [Validation(Required=false)]
        [Obsolete]
        public string MasterSystemDiskPerformanceLevel { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the system_disk_size parameter under <c>control_plane_config</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("master_system_disk_size")]
        [Validation(Required=false)]
        [Obsolete]
        public long? MasterSystemDiskSize { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the system_disk_snapshot_policy_id parameter under <c>control_plane_config</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-2zej1nogjvovnz4z****</para>
        /// </summary>
        [NameInMap("master_system_disk_snapshot_policy_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string MasterSystemDiskSnapshotPolicyId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the <c>vswitch_ids</c> parameter instead.</para>
        /// </summary>
        [NameInMap("master_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MasterVswitchIds { get; set; }

        /// <summary>
        /// <para>The custom cluster name. The name must be 1 to 63 characters in length and can contain digits, Chinese characters, letters, and hyphens (-). It cannot start with a hyphen (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the <c>snat_entry</c> parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("nat_gateway")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? NatGateway { get; set; }

        /// <summary>
        /// <para>The number of node IP addresses, determined by specifying the network CIDR block. This parameter takes effect only for Flannel network type clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("node_cidr_mask")]
        [Validation(Required=false)]
        public string NodeCidrMask { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>node_name_mode</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("node_name_mode")]
        [Validation(Required=false)]
        [Obsolete]
        public string NodeNameMode { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The node service port. Valid port range: [30000,65535\].</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000~32767</para>
        /// </summary>
        [NameInMap("node_port_range")]
        [Validation(Required=false)]
        [Obsolete]
        public string NodePortRange { get; set; }

        /// <summary>
        /// <para>The list of node pools.</para>
        /// </summary>
        [NameInMap("nodepools")]
        [Validation(Required=false)]
        public List<Nodepool> Nodepools { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the desired_size parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("num_of_nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public long? NumOfNodes { get; set; }

        /// <summary>
        /// <para>The cluster automatic O&amp;M policy.</para>
        /// </summary>
        [NameInMap("operation_policy")]
        [Validation(Required=false)]
        public CreateClusterRequestOperationPolicy OperationPolicy { get; set; }
        public class CreateClusterRequestOperationPolicy : TeaModel {
            /// <summary>
            /// <para>The cluster auto-upgrade configuration.</para>
            /// </summary>
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public CreateClusterRequestOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class CreateClusterRequestOperationPolicyClusterAutoUpgrade : TeaModel {
                /// <summary>
                /// <para>The cluster auto-upgrade frequency. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>stable</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable cluster auto-upgrade.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane node configuration, use the <c>image_type</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>image_type</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("os_type")]
        [Validation(Required=false)]
        [Obsolete]
        public string OsType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Period { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("period_unit")]
        [Validation(Required=false)]
        [Obsolete]
        public string PeriodUnit { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>platform</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        [Obsolete]
        public string Platform { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> When you select Terway as the network plugin, you must specify vSwitches for pod IP address allocation. Each pod vSwitch corresponds to a worker node vSwitch, and the pod vSwitch and the worker node vSwitch must be in the same zone.</para>
        /// </summary>
        [NameInMap("pod_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// <para>If you set <c>cluster_type</c> to <c>ManagedKubernetes</c>, which indicates an ACK managed cluster, you can further specify the cluster subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>The kube-proxy proxy mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipvs</para>
        /// </summary>
        [NameInMap("proxy_mode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>rds_instances</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster. For details, see <a href="https://help.aliyun.com/document_detail/216938.html">Regions supported by container service</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID of the cluster, which is used to isolate different resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3mkrure****</para>
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The RRSA feature configuration.</para>
        /// </summary>
        [NameInMap("rrsa_config")]
        [Validation(Required=false)]
        public CreateClusterRequestRrsaConfig RrsaConfig { get; set; }
        public class CreateClusterRequestRrsaConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the RRSA feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The container runtime in the cluster. Supported runtimes include containerd, sandboxed containers, and Docker.</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        [Obsolete]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// <para>The security group ID. Specify this parameter when you use an existing security group to create a cluster. This parameter and <c>is_enterprise_security_group</c> are mutually exclusive. Cluster nodes are automatically added to this security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1bdue0qc1g7k****</para>
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>security_hardening_os</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>security_hardening_os</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("security_hardening_os")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? SecurityHardeningOs { get; set; }

        /// <summary>
        /// <para>A ServiceAccount is the access credential for communication between a pod and the cluster API server. The <c>service-account-issuer</c> is the issuer identity in the <c>serviceaccount token</c>, which is the <c>iss</c> field in the <c>token payload</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes.default.svc</para>
        /// </summary>
        [NameInMap("service_account_issuer")]
        [Validation(Required=false)]
        public string ServiceAccountIssuer { get; set; }

        /// <summary>
        /// <para>The Service network CIDR block. Valid ranges: 10.0.0.0/16-24, 172.16-31.0.0/16-24, and 192.168.0.0/16-24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.21.0.0/20</para>
        /// </summary>
        [NameInMap("service_cidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The service discovery types within the cluster, used to specify the service discovery method in <c>ACK Serverless</c> clusters.</para>
        /// </summary>
        [NameInMap("service_discovery_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> ServiceDiscoveryTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to configure SNAT for the VPC. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("snat_entry")]
        [Validation(Required=false)]
        public bool? SnatEntry { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane node configuration, use the <c>soc_enabled</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>soc_enabled</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("soc_enabled")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? SocEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public SSH logon. This is used to log on to the master nodes of ACK dedicated clusters. This parameter does not take effect for managed clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ssh_flags")]
        [Validation(Required=false)]
        public bool? SshFlags { get; set; }

        /// <summary>
        /// <para>The node tags. Tag definition rules:</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>taints</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead.</para>
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        [Obsolete]
        public List<Taint> Taints { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> When cluster creation fails, rollback is not performed by default. You must manually clean up the failed cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("timeout_mins")]
        [Validation(Required=false)]
        [Obsolete]
        public long? TimeoutMins { get; set; }

        /// <summary>
        /// <para>The time zone used by the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/354879.html">Supported time zones</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The custom cluster CA.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----****</para>
        /// </summary>
        [NameInMap("user_ca")]
        [Validation(Required=false)]
        public string UserCa { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The custom node data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFD****</para>
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        [Obsolete]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The VPC used by the cluster. You must provide a VPC when you create a cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zeik9h3ahvv2zz95****</para>
        /// </summary>
        [NameInMap("vpcid")]
        [Validation(Required=false)]
        public string Vpcid { get; set; }

        /// <summary>
        /// <para>The vSwitches for cluster nodes. This field is required when you create a zero-node managed cluster.</para>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the auto_renew parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("worker_auto_renew")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? WorkerAutoRenew { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the auto_renew_period parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("worker_auto_renew_period")]
        [Validation(Required=false)]
        [Obsolete]
        public long? WorkerAutoRenewPeriod { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the data_disks parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        [Obsolete]
        public List<CreateClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class CreateClusterRequestWorkerDataDisks : TeaModel {
            /// <summary>
            /// <para>The type of the data disk.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the data disk. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The performance level of the data cloud disk for nodes. This parameter takes effect only for <a href="https://help.aliyun.com/document_detail/122389.html">standard SSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("performance_level")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the data disk. Valid values: 40 to 32767. Unit: GiB.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the instance_charge_type parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("worker_instance_charge_type")]
        [Validation(Required=false)]
        [Obsolete]
        public string WorkerInstanceChargeType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the instance_types parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the period parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("worker_period")]
        [Validation(Required=false)]
        [Obsolete]
        public long? WorkerPeriod { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the period_unit parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("worker_period_unit")]
        [Validation(Required=false)]
        [Obsolete]
        public string WorkerPeriodUnit { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the system_disk_category parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
        /// </summary>
        [NameInMap("worker_system_disk_category")]
        [Validation(Required=false)]
        [Obsolete]
        public string WorkerSystemDiskCategory { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the system_disk_performance_level parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("worker_system_disk_performance_level")]
        [Validation(Required=false)]
        [Obsolete]
        public string WorkerSystemDiskPerformanceLevel { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the system_disk_size parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("worker_system_disk_size")]
        [Validation(Required=false)]
        [Obsolete]
        public long? WorkerSystemDiskSize { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the system_disk_snapshot_policy_id parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-2zej1nogjvovnz4z****</para>
        /// </summary>
        [NameInMap("worker_system_disk_snapshot_policy_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string WorkerSystemDiskSnapshotPolicyId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the vswitch_ids parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// </summary>
        [NameInMap("worker_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerVswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the <c>zone_ids</c> parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beiji****</para>
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The zone IDs of the cluster region. This parameter is specific to ACK managed clusters.</para>
        /// </summary>
        [NameInMap("zone_ids")]
        [Validation(Required=false)]
        public List<string> ZoneIds { get; set; }

    }

}
