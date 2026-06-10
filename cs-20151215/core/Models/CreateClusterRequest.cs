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
        /// <para><b>[Deprecated]</b> Access control list for the registered cluster API Server SLB.</para>
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// <para>List of cluster components. Specify components to install during cluster creation using the <c>addons</c> parameter.</para>
        /// <para><b>Network components</b>: Required. Choose between Flannel and Terway:</para>
        /// <list type="bullet">
        /// <item><description><para>Flannel network: [{&quot;name&quot;:&quot;flannel&quot;,&quot;config&quot;:&quot;&quot;}].</para>
        /// </description></item>
        /// <item><description><para>Terway network: [{&quot;name&quot;: &quot;terway-eniip&quot;,&quot;config&quot;: &quot;&quot;}].</para>
        /// </description></item>
        /// </list>
        /// <para><b>Storage components</b>: Optional. Only <c>csi</c> is supported:</para>
        /// <para><c>csi</c>: [{&quot;name&quot;:&quot;csi-plugin&quot;,&quot;config&quot;: &quot;&quot;},{&quot;name&quot;: &quot;csi-provisioner&quot;,&quot;config&quot;: &quot;&quot;}].</para>
        /// <para><b>Logging components</b>: Optional. We recommend enabling this. Without SLS, you cannot use cluster audit features.</para>
        /// <list type="bullet">
        /// <item><description><para>Use an existing <c>SLS Project</c>: [{&quot;name&quot;: &quot;loongcollector&quot;,&quot;config&quot;: &quot;{&quot;IngressDashboardEnabled&quot;:&quot;true&quot;,&quot;sls_project_name&quot;:&quot;your_sls_project_name&quot;}&quot;}].</para>
        /// </description></item>
        /// <item><description><para>Create a new <c>SLS Project</c>: [{&quot;name&quot;: &quot;loongcollector&quot;,&quot;config&quot;: &quot;{&quot;IngressDashboardEnabled&quot;:&quot;true&quot;}&quot;}].</para>
        /// </description></item>
        /// </list>
        /// <para><b>Ingress components</b>: Optional. ACK dedicated clusters install the <c>nginx-ingress-controller</c> by default.</para>
        /// <list type="bullet">
        /// <item><description><para>Install Ingress with public network access: [{&quot;name&quot;:&quot;nginx-ingress-controller&quot;,&quot;config&quot;:&quot;{&quot;IngressSlbNetworkType&quot;:&quot;internet&quot;}&quot;}].</para>
        /// </description></item>
        /// <item><description><para>Disable default Ingress installation: [{&quot;name&quot;: &quot;nginx-ingress-controller&quot;,&quot;config&quot;: &quot;&quot;,&quot;disabled&quot;: true}].</para>
        /// </description></item>
        /// </list>
        /// <para><b>Event Hub</b>: Optional. Enabled by default.</para>
        /// <para>Event Hub provides storage, querying, and alerting for Kubernetes events. The associated Logstore is free for 90 days. For more information about the free policy, see <a href="https://help.aliyun.com/document_detail/150476.html">Create and use Kubernetes Event Hub</a>.</para>
        /// <para>Example to enable Event Hub: [{&quot;name&quot;:&quot;ack-node-problem-detector&quot;,&quot;config&quot;:&quot;{&quot;sls_project_name&quot;:&quot;your_sls_project_name&quot;}&quot;}].</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<Addon> Addons { get; set; }

        /// <summary>
        /// <para>ServiceAccount is the access credential used by pods to communicate with the cluster API Server. The <c>api-audiences</c> specifies valid <c>token</c> identities for authenticating requests on the <c>apiserver</c> side. You can configure multiple <c>audience</c> values separated by commas (,).</para>
        /// <para>For more information about <c>ServiceAccount</c>, see <a href="https://help.aliyun.com/document_detail/160384.html">Deploy service account token volume projection</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes.default.svc</para>
        /// </summary>
        [NameInMap("api_audiences")]
        [Validation(Required=false)]
        public string ApiAudiences { get; set; }

        /// <summary>
        /// <para>Cluster audit log configuration.</para>
        /// </summary>
        [NameInMap("audit_log_config")]
        [Validation(Required=false)]
        public CreateClusterRequestAuditLogConfig AuditLogConfig { get; set; }
        public class CreateClusterRequestAuditLogConfig : TeaModel {
            /// <summary>
            /// <para>Whether to enable cluster audit logging.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable.</para>
            /// </description></item>
            /// <item><description><para>false: Disable.</para>
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
            /// <para>The <a href="https://help.aliyun.com/document_detail/48873.html">SLS Project</a> containing the <a href="https://help.aliyun.com/document_detail/48873.html">Logstore</a> for cluster audit logs.</para>
            /// <list type="bullet">
            /// <item><description><para>Default value: <c>k8s-log-{clusterid}</c>.</para>
            /// </description></item>
            /// <item><description><para>When audit logging is enabled, a Logstore for audit logs is created in the specified SLS Project.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-c2345xxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("sls_project_name")]
            [Validation(Required=false)]
            public string SlsProjectName { get; set; }

        }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2938898.html">Intelligent Managed Mode</a> configuration.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public CreateClusterRequestAutoMode AutoMode { get; set; }
        public class CreateClusterRequestAutoMode : TeaModel {
            /// <summary>
            /// <para>Whether to enable Intelligent Managed Mode.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable.</para>
            /// </description></item>
            /// <item><description><para>false: Disable.</para>
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// <para>Whether to enable auto-renewal. Valid only when <c>charge_type</c> is <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enable auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disable auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>This parameter changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on Changes to CreateCluster API Parameters</a>.</para>
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
        /// <para>Auto-renewal period in months. Valid only when prepaid and auto-renewal are enabled. When <c>PeriodUnit=Month</c>, valid values are {1, 2, 3, 6, 12}.</para>
        /// <para>Default value: 1.</para>
        /// <para>This parameter changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on Changes to CreateCluster API Parameters</a>.</para>
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
        /// <para>Billing type for the CLB instance used by the API Server. Default value: PostPaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PostPaid: Pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para>PrePaid: Subscription. New CLB instances no longer support subscription billing, but existing instances are unaffected.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on Changes to CreateCluster API Parameters</a>.</para>
        /// </description></item>
        /// <item><description><para>Starting December 1, 2024, new CLB instances will no longer support subscription billing and will incur an instance fee.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;For details, see <a href="~~2851191~~">[Product Announcement] Discontinuation of Subscription Billing for API Server CLB in New Clusters</a> and <a href="https://help.aliyun.com/document_detail/2839797.html">Adjustment of Classic Load Balancer Billing Items</a>.
        /// &lt;props=&quot;intl&quot;&gt;For details, see <a href="https://help.aliyun.com/document_detail/2839797.html">Adjustment of Classic Load Balancer Billing Items</a>.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>security_hardening_os</c> parameter under <c>control_plane_config</c>. For node pool configuration, use the <c>security_hardening_os</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
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
        /// <para><b>[Deprecated]</b> For control plane node configuration, use the cloud_monitor_flags parameter under <c>control_plane_config</c>. For node pool configuration, use the <c>cms_enabled</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c>.</para>
        /// <para>Whether to install the CloudMonitor agent on the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Install the CloudMonitor agent.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Do not install the CloudMonitor agent.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? CloudMonitorFlags { get; set; }

        /// <summary>
        /// <para>Cluster local domain name.</para>
        /// <para>Naming rules: The domain name consists of one or more parts separated by dots (.). Each part can be up to 63 characters long and can contain lowercase letters, digits, and hyphens (-). Each part must start and end with a lowercase letter or digit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster.local</para>
        /// </summary>
        [NameInMap("cluster_domain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// <para>When you set <c>cluster_type</c> to <c>ManagedKubernetes</c> and configure <c>profile</c>, you can further specify the cluster specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ack.standard</c>: Basic Edition (default when this parameter is empty)</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.small</c>: Pro Edition</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.xlarge</c>: Pro XL</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.2xlarge</c>: Pro 2XL</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.4xlarge</c>: Pro 4XL (requires whitelist approval from customer service)</para>
        /// </description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are three tiers provided by &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>. These tiers pre-allocate and dedicate control plane resources to ensure consistently high API concurrency and pod scheduling performance. They are suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For cluster management fees for Pro Edition and provisioned control plane clusters, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para><c>Kubernetes</c>: ACK dedicated cluster.</para>
        /// </description></item>
        /// <item><description><para><c>ManagedKubernetes</c>: ACK managed clusters, including ACK managed clusters (Pro Edition, Basic Edition), ACK serverless clusters (Pro Edition, Basic Edition), ACK Edge clusters (Pro Edition, Basic Edition), and ACK LINGJUN clusters (Pro Edition).</para>
        /// </description></item>
        /// <item><description><para><c>ExternalKubernetes</c>: registered cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Pod network CIDR block. It must be a valid private CIDR block: 10.0.0.0/8, 172.16.0.0/12 to 172.31.0.0/16, or 192.168.0.0/16. It cannot overlap with the VPC or existing Kubernetes cluster CIDR blocks in the VPC. This cannot be modified after cluster creation.</para>
        /// <para>For cluster network planning, see <a href="https://help.aliyun.com/document_detail/86500.html">Network planning for ACK managed clusters</a>.</para>
        /// <remarks>
        /// <para>This field is required for Flannel clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.0.0/16</para>
        /// </summary>
        [NameInMap("container_cidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        /// <summary>
        /// <para>Control plane configuration for ACK dedicated clusters.</para>
        /// </summary>
        [NameInMap("control_plane_config")]
        [Validation(Required=false)]
        public CreateClusterRequestControlPlaneConfig ControlPlaneConfig { get; set; }
        public class CreateClusterRequestControlPlaneConfig : TeaModel {
            /// <summary>
            /// <para>Whether to enable auto-renewal for control plane nodes. Valid only when charge_type is <c>PrePaid</c>.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable auto-renewal.</para>
            /// </description></item>
            /// <item><description><para>false: Disable auto-renewal.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>Auto-renewal duration for control plane nodes in months.</para>
            /// <para>Valid values: {1, 2, 3, 6, 12}.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>Control plane node billing type.</para>
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
            /// <para>Whether to install Cloud Monitor on nodes.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Install the CloudMonitor agent.</para>
            /// </description></item>
            /// <item><description><para>false: Do not install the CloudMonitor agent.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("cloud_monitor_flags")]
            [Validation(Required=false)]
            public bool? CloudMonitorFlags { get; set; }

            /// <summary>
            /// <para>Node CPU management policy.</para>
            /// <list type="bullet">
            /// <item><description><para>static: Enhances CPU affinity and exclusivity for pods with specific resource characteristics on the node.</para>
            /// </description></item>
            /// <item><description><para>none: Uses the default CPU affinity scheme.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: none.</para>
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
            /// <para>Image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20240819.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>Operating system image type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux3</para>
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>ECS instance metadata access configuration.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>Node instance types.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>Key pair name. Choose either this parameter or login_password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>SSH login password. Password rules: 8–30 characters, containing at least three of the following: uppercase letters, lowercase letters, digits, and special characters. Choose either this parameter or key_pair.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> Node service port range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("node_port_range")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>Subscription duration for control plane nodes in months. Required and valid only when charge_type is <c>PrePaid</c>.</para>
            /// <para>Valid values: {1, 2, 3, 6, 12, 24, 36, 48, 60}.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>Billing cycle unit for control plane nodes. Required and valid only when charge_type is <c>PrePaid</c>.</para>
            /// <para>Valid value: <c>Month</c>. Only monthly billing is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> Control plane node runtime name. Valid value:</para>
            /// <para>containerd: Containerd runtime, supported for all cluster versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>Whether to enable Alibaba Cloud OS security hardening.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable Alibaba Cloud OS security hardening.</para>
            /// </description></item>
            /// <item><description><para>false: Disable Alibaba Cloud OS security hardening.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("security_hardening_os")]
            [Validation(Required=false)]
            public bool? SecurityHardeningOs { get; set; }

            /// <summary>
            /// <para>Number of control plane nodes.</para>
            /// <para>Valid values: <c>3</c> or <c>5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>Whether to enable MLPS 2.0 security hardening.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable MLPS 2.0 security hardening.</para>
            /// </description></item>
            /// <item><description><para>false: Disable MLPS 2.0 security hardening.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// <para>Whether to enable performance burst for node system disks.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable.</para>
            /// </description></item>
            /// <item><description><para>false: Disable.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is <c>cloud_auto</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>Node system disk type.</para>
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
            /// <para>Default value: <c>cloud_ssd</c>. The default may vary by zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>Node system disk performance level. Applies only to ESSD disks.</para>
            /// <para>Disk performance levels depend on disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>Provisioned read/write IOPS for node system disks.</para>
            /// <para>Valid range: 0 to min{50,000, 1000 × capacity - baseline performance}. Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is <c>cloud_auto</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>Node system disk size in GiB.</para>
            /// <para>Valid range: [40,500].</para>
            /// <para>Default value: <c>120</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>Automatic snapshot backup policy for node system disks.</para>
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
        public CreateClusterRequestControlPlaneEndpointsConfig ControlPlaneEndpointsConfig { get; set; }
        public class CreateClusterRequestControlPlaneEndpointsConfig : TeaModel {
            /// <summary>
            /// <para>Internal domain name configuration for the cluster, applicable to ACK managed clusters. Internal domain names allow node-side system components such as kubelet and kube-proxy to access the API Server. Without internal domain name access, node-side components access the API Server through the CLB IP address.</para>
            /// </summary>
            [NameInMap("internal_dns_config")]
            [Validation(Required=false)]
            public CreateClusterRequestControlPlaneEndpointsConfigInternalDnsConfig InternalDnsConfig { get; set; }
            public class CreateClusterRequestControlPlaneEndpointsConfigInternalDnsConfig : TeaModel {
                /// <summary>
                /// <para>VPCs where the internal domain name resolution takes effect.</para>
                /// </summary>
                [NameInMap("bind_vpcs")]
                [Validation(Required=false)]
                public List<string> BindVpcs { get; set; }

            }

        }

        /// <summary>
        /// <para>List of component names specifying which control plane component logs to collect.</para>
        /// <para>By default, logs are collected for kube-apiserver, kube-controller-manager, kube-scheduler, and cloud-controller-manager.</para>
        /// </summary>
        [NameInMap("controlplane_log_components")]
        [Validation(Required=false)]
        public List<string> ControlplaneLogComponents { get; set; }

        /// <summary>
        /// <para>SLS Project for control plane component logs. You can use an existing Project for log storage or let the system automatically create one. If auto-created, the Project name will be <c>k8s-log-{ClusterID}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-log-xxx</para>
        /// </summary>
        [NameInMap("controlplane_log_project")]
        [Validation(Required=false)]
        public string ControlplaneLogProject { get; set; }

        /// <summary>
        /// <para>Number of days to retain control plane component logs.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>cpu_policy</c> parameter under <c>control_plane_config</c>. For node pool configuration, use the <c>cpu_policy</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c>.</para>
        /// <para>Node CPU management policy. Supported for cluster versions 1.12.6 and later:</para>
        /// <list type="bullet">
        /// <item><description><para><c>static</c>: Enhances CPU affinity and exclusivity for pods with specific resource characteristics on the node.</para>
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
        [Obsolete]
        public string CpuPolicy { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the <c>extra_sans</c> parameter instead.</para>
        /// <para>Custom certificate SAN. Separate multiple IP addresses or domain names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs.aliyun.com</para>
        /// </summary>
        [NameInMap("custom_san")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustomSan { get; set; }

        /// <summary>
        /// <para>Cluster deletion protection prevents accidental cluster deletion through the console or API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enable deletion protection. You cannot delete the cluster through the console or API.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disable deletion protection. You can delete the cluster through the console or API.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
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
        /// <para><b>[Deprecated]</b> By default, clusters are not rolled back on creation failure. You must manually clean up failed clusters.</para>
        /// <para>Whether to roll back on cluster creation failure. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Roll back on failure.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Do not roll back on failure.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
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
        /// <para>Whether to enable RRSA.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable.</para>
        /// </description></item>
        /// <item><description><para>false: Disable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable_rrsa")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? EnableRrsa { get; set; }

        /// <summary>
        /// <para>KMS key ID used to encrypt data disks. For more information, see <a href="https://help.aliyun.com/document_detail/28935.html">Key Management Service</a>.</para>
        /// <remarks>
        /// <para>This feature is available only for professional managed clusters (ACK Pro clusters).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0fe64791-55eb-4fc7-84c5-c6c7cdca****</para>
        /// </summary>
        [NameInMap("encryption_provider_key")]
        [Validation(Required=false)]
        public string EncryptionProviderKey { get; set; }

        /// <summary>
        /// <para>Whether to enable public network access. Expose the API Server through an EIP to allow public network access to the cluster.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enable public network access.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disable public network access. If disabled, you cannot access the cluster API Server from external networks.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("endpoint_public_access")]
        [Validation(Required=false)]
        public bool? EndpointPublicAccess { get; set; }

        /// <summary>
        /// <para>Custom API Server certificate SAN (Subject Alternative Name).</para>
        /// </summary>
        [NameInMap("extra_sans")]
        [Validation(Required=false)]
        public List<string> ExtraSans { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Adding existing nodes during cluster creation is not supported. To add existing nodes to a cluster, first create a node pool and then call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> API.</para>
        /// <para>When using existing instances to create a cluster, whether to mount data disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Store containers and images on the data disk. Existing data on the data disk will be lost. Back up your data.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Do not store containers and images on the data disk.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>Data disk mounting rules:</para>
        /// <list type="bullet">
        /// <item><description><para>If the ECS instance has a mounted data disk and the file system of the last data disk is uninitialized, the system automatically formats it as ext4 to store /var/lib/docker and /var/lib/kubelet.</para>
        /// </description></item>
        /// <item><description><para>If the ECS instance has no mounted data disks, no new data disks are mounted.</para>
        /// </description></item>
        /// </list>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>image_id</c> parameter under <c>control_plane_config</c>. For node pool configuration, use the <c>image_id</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Custom node image. By default, the system image is used. When you select a custom image, it replaces the default system image. See <a href="https://help.aliyun.com/document_detail/146647.html">Custom images</a>.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>image_type</c> parameter under <c>control_plane_config</c>. For node pool configuration, use the <c>image_type</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Operating system distribution type. We recommend using this parameter to specify the node operating system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CentOS</para>
        /// </description></item>
        /// <item><description><para>AliyunLinux</para>
        /// </description></item>
        /// <item><description><para>AliyunLinux Qboot</para>
        /// </description></item>
        /// <item><description><para>AliyunLinuxUEFI</para>
        /// </description></item>
        /// <item><description><para>AliyunLinux3</para>
        /// </description></item>
        /// <item><description><para>Windows</para>
        /// </description></item>
        /// <item><description><para>WindowsCore</para>
        /// </description></item>
        /// <item><description><para>AliyunLinux3Arm64</para>
        /// </description></item>
        /// <item><description><para>ContainerOS</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>CentOS</c>.</para>
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
        /// <para><b>[Deprecated]</b> Adding existing nodes during cluster creation is not supported. To add existing nodes to a cluster, first create a node pool and then call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> API.</para>
        /// <para>When using existing nodes to create a cluster, specify the ECS instance list. These instances are added as worker nodes to the cluster.</para>
        /// <remarks>
        /// <para>This field is required when using existing instances to create a cluster.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>Cluster IP stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>可选值：
        /// ipv4（单栈）
        /// dual（双栈），默认值为ipv4。</para>
        /// </summary>
        [NameInMap("ip_stack")]
        [Validation(Required=false)]
        public string IpStack { get; set; }

        /// <summary>
        /// <para>Automatically create an advanced security group. This takes effect when <c>security_group_id</c> is empty.</para>
        /// <remarks>
        /// <para>With basic security groups, the total number of nodes and Terway pods in a cluster cannot exceed 2,000. We recommend using advanced security groups for Terway network clusters.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Create and use an advanced security group.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Use a basic security group.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
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
        /// <para><b>[Deprecated]</b> Adding existing nodes during cluster creation is not supported. To add existing nodes to a cluster, first create a node pool and then call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> API.</para>
        /// <para>When using existing instances to create a cluster, whether to keep the instance names.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Keep.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Replace with system-generated names.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>key_pair</c> parameter under <c>control_plane_config</c>. For node pool configuration, use the <c>key_pair</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Key pair name. Choose either this parameter or <c>login_password</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>security-key</para>
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        [Obsolete]
        public string KeyPair { get; set; }

        /// <summary>
        /// <para>Cluster version, aligned with the Kubernetes community baseline version. We recommend selecting the latest version. If not specified, the latest version is used by default.</para>
        /// <para>You can create clusters using any of the three most recent versions. Use the <a href="https://help.aliyun.com/document_detail/2667899.html">DescribeKubernetesVersionMetadata</a> API to query supported cluster versions.</para>
        /// <para>For more information about Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Overview of Kubernetes version releases</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>Specify the CLB instance ID for API Server access. If specified, no new API Server CLB is automatically created.</para>
        /// <remarks>
        /// <para>Ensure the CLB instance has no dependencies (such as listeners or backend servers). Shared and public CLB instances are not supported.</para>
        /// </remarks>
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
        /// <para><b>[Deprecated]</b> CLB is billed based on usage. This parameter has no effect.</para>
        /// <para>Load Balancer specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>slb.s1.small</para>
        /// </description></item>
        /// <item><description><para>slb.s2.small</para>
        /// </description></item>
        /// <item><description><para>slb.s2.medium</para>
        /// </description></item>
        /// <item><description><para>slb.s3.small</para>
        /// </description></item>
        /// <item><description><para>slb.s3.medium</para>
        /// </description></item>
        /// <item><description><para>slb.s3.large</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>slb.s2.small</c>.</para>
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
        /// <para><b>[Deprecated]</b> Enables SLS for the cluster. Applies only to ACK Serverless clusters and must be set to <c>SLS</c>.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>login_password</c> parameter under <c>control_plane_config</c>. For node pool configuration, use the <c>login_password</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>SSH login password. Choose either this parameter or <c>key_pair</c>. Password rules: 8–30 characters, containing at least three of the following: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        [Obsolete]
        public string LoginPassword { get; set; }

        /// <summary>
        /// <para>Cluster maintenance window.</para>
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>auto_renew</c> parameter under <c>control_plane_config</c>.</para>
        /// <para>Whether to enable auto-renewal for master nodes. Valid only when <c>master_instance_charge_type</c> is <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enable auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disable auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>auto_renew_period</c> parameter under <c>control_plane_config</c>.</para>
        /// <para>Auto-renewal period for master nodes in months. Required and valid only when subscription billing is selected.</para>
        /// <para>Valid values: {1, 2, 3, 6, 12}.</para>
        /// <para>Default value: 1.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>size</c> parameter under <c>control_plane_config</c>.</para>
        /// <para>Number of master nodes. Valid values: <c>3</c> or <c>5</c>.</para>
        /// <para>Default value: <c>3</c>.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>instance_charge_type</c> parameter under <c>control_plane_config</c>.</para>
        /// <para>Master node billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PrePaid</c>: Subscription.</para>
        /// </description></item>
        /// <item><description><para><c>PostPaid</c>: Pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>PostPaid</c>.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>instance_types</c> parameter under <c>control_plane_config</c>.</para>
        /// <para>Master node instance types. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// </summary>
        [NameInMap("master_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MasterInstanceTypes { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>unit</c> parameter under <c>control_plane_config</c>.</para>
        /// <para>Subscription duration for master nodes in months. Required and valid only when <c>master_instance_charge_type</c> is <c>PrePaid</c>.</para>
        /// <para>Valid values: {1, 2, 3, 6, 12, 24, 36, 48, 60}.</para>
        /// <para>Default value: 1.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>period_unit</c> parameter under <c>control_plane_config</c>.</para>
        /// <para>Master node billing cycle. Required when master_instance_charge_type is <c>PrePaid</c>.</para>
        /// <para>Valid value: <c>Month</c>. Only monthly billing is supported.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>system_disk_category</c> parameter under <c>control_plane_config</c>.</para>
        /// <para>Master node system disk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cloud_efficiency</c>: Ultra disk.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_ssd</c>: Standard SSD.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_essd</c>: ESSD.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>cloud_ssd</c>. The default may vary by zone.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>system_disk_performance_level</c> parameter under <c>control_plane_config</c>.</para>
        /// <para>Performance level for master node system disks. Applies only to ESSD disks. Disk performance levels depend on disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>system_disk_size</c> parameter under <c>control_plane_config</c>.</para>
        /// <para>Valid range: [40,500].</para>
        /// <para>Default value: <c>120</c>.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>system_disk_snapshot_policy_id</c> parameter under <c>control_plane_config</c>.</para>
        /// <para>Automatic snapshot policy ID for master node system disks.</para>
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
        /// <para>List of master node vSwitch IDs. The number of vSwitches must be in the range [1,3]. For high availability, we recommend selecting three vSwitches in different zones.</para>
        /// <para>The number of specified instance types must match <c>master_count</c> and correspond one-to-one with elements in <c>master_vswitch_ids</c>.</para>
        /// </summary>
        [NameInMap("master_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MasterVswitchIds { get; set; }

        /// <summary>
        /// <para>Custom cluster name. It can contain digits, letters, Chinese characters, or hyphens (-). The name must be 1 to 63 characters long and cannot start with a hyphen (-).</para>
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
        /// <para>Number of node IP addresses, determined by the specified CIDR mask. This applies only to Flannel network clusters.</para>
        /// <para>Default value: <c>26</c>.</para>
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
        /// <para><b>[Deprecated]</b> Use the <c>node_name_mode</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead.</para>
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
        /// <para>Node service port range: [30000,65535].</para>
        /// <para>Default value: <c>30000-32767</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000~32767</para>
        /// </summary>
        [NameInMap("node_port_range")]
        [Validation(Required=false)]
        [Obsolete]
        public string NodePortRange { get; set; }

        /// <summary>
        /// <para>List of node pools.</para>
        /// </summary>
        [NameInMap("nodepools")]
        [Validation(Required=false)]
        public List<Nodepool> Nodepools { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>desired_size</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Number of worker nodes. Range: [0,100].</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("num_of_nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public long? NumOfNodes { get; set; }

        /// <summary>
        /// <para>Cluster automated operations policy.</para>
        /// </summary>
        [NameInMap("operation_policy")]
        [Validation(Required=false)]
        public CreateClusterRequestOperationPolicy OperationPolicy { get; set; }
        public class CreateClusterRequestOperationPolicy : TeaModel {
            /// <summary>
            /// <para>Cluster automatic upgrade.</para>
            /// </summary>
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public CreateClusterRequestOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class CreateClusterRequestOperationPolicyClusterAutoUpgrade : TeaModel {
                /// <summary>
                /// <para>Cluster automatic upgrade frequency. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>patch: Automatically upgrade to the latest patch version within the current minor version. New Kubernetes versions do not include breaking changes.</para>
                /// </description></item>
                /// <item><description><para>stable: Automatically upgrade to the latest patch version of the second-newest minor version. New Kubernetes versions may include API and feature changes but have undergone extensive stability validation.</para>
                /// </description></item>
                /// <item><description><para>rapid: Automatically upgrade to the latest patch version of the newest minor version to quickly access new Kubernetes community features.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>stable</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Whether to enable cluster automatic upgrade.</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enable.</para>
                /// </description></item>
                /// <item><description><para>false: Disable.</para>
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For control plane node configuration, use the <c>image_type</c> parameter under <c>control_plane_config</c>. For node pool configuration, use the <c>image_type</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Operating system platform type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Windows</para>
        /// </description></item>
        /// <item><description><para>Linux</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>Linux</c>.</para>
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
        /// <para>Subscription duration in months. Required and valid only when charge_type is PrePaid.</para>
        /// <para>Valid values: {1, 2, 3, 6, 12, 24, 36, 48, 60}.</para>
        /// <para>Default value: 1.</para>
        /// <para>This parameter changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on Changes to CreateCluster API Parameters</a>.</para>
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
        /// <para>Billing cycle. Required when the billing type is PrePaid.</para>
        /// <para>Valid value: Month. Only monthly billing is supported.</para>
        /// <para>This parameter changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on Changes to CreateCluster API Parameters</a>.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>platform</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Operating system distribution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CentOS</para>
        /// </description></item>
        /// <item><description><para>AliyunLinux</para>
        /// </description></item>
        /// <item><description><para>QbootAliyunLinux</para>
        /// </description></item>
        /// <item><description><para>Qboot</para>
        /// </description></item>
        /// <item><description><para>Windows</para>
        /// </description></item>
        /// <item><description><para>WindowsCore</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>CentOS</c>.</para>
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
        /// <para><b>[Deprecated]</b> When using the Terway network plugin, specify virtual switches to assign IP addresses to pods. Each pod virtual switch corresponds to a worker node virtual switch, and both must be in the same zone.</para>
        /// <remarks>
        /// <para>We recommend that the pod virtual switch CIDR mask not exceed /19 and must not exceed /25. Otherwise, the number of assignable pod IP addresses becomes very limited, affecting normal cluster operation.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("pod_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// <para>When you set <c>cluster_type</c> to <c>ManagedKubernetes</c> (ACK managed cluster), you can further specify the cluster subtype.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Default</c>: ACK managed cluster, including ACK clusters (Pro Edition, Basic Edition).</para>
        /// </description></item>
        /// <item><description><para><c>Edge</c>: ACK Edge cluster, including ACK Edge clusters (Pro Edition, Basic Edition).</para>
        /// </description></item>
        /// <item><description><para><c>Serverless</c>: ACK serverless cluster, including ACK serverless clusters (Pro Edition, Basic Edition).</para>
        /// </description></item>
        /// <item><description><para><c>Lingjun</c>: ACK LINGJUN cluster, available only in Pro Edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>kube-proxy proxy mode</para>
        /// <list type="bullet">
        /// <item><description><para><c>iptables</c>: A mature and stable kube-proxy mode. Kubernetes Service discovery and load balancing use iptables rules. Performance is moderate and scales poorly with large numbers of Services. Suitable for clusters with few Services.</para>
        /// </description></item>
        /// <item><description><para><c>ipvs</c>: A high-performance kube-proxy mode. Kubernetes Service discovery and load balancing use the Linux IPVS module. Suitable for clusters with many Services requiring high-performance load balancing.</para>
        /// </description></item>
        /// <item><description><para><c>nftables</c>: A next-generation kube-proxy mode based on Linux nftables for Service discovery and load balancing. It is the modern replacement for iptables. Compared to iptables, nftables offers better network performance, faster rule updates, and superior scalability for large numbers of Services.<br>
        /// Supported only for clusters running Kubernetes version 1.35 or later. The Kubernetes community deprecated IPVS starting in version 1.35. We recommend using nftables for new clusters to ensure long-term community support.<br></para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>ipvs</c>.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>rds_instances</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>List of RDS instances to add to the whitelist. We recommend adding the pod and node CIDR blocks of your container cluster to the RDS whitelist. Setting RDS instances might fail if they are not in the Running state.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// <para>The region ID where the cluster is deployed. For more information, see <a href="https://help.aliyun.com/document_detail/216938.html">Regions supported by Container Service for Kubernetes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID to which the cluster belongs, used to isolate different resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3mkrure****</para>
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>RRSA feature configuration.</para>
        /// </summary>
        [NameInMap("rrsa_config")]
        [Validation(Required=false)]
        public CreateClusterRequestRrsaConfig RrsaConfig { get; set; }
        public class CreateClusterRequestRrsaConfig : TeaModel {
            /// <summary>
            /// <para>Whether to enable RRSA.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable.</para>
            /// </description></item>
            /// <item><description><para>false: Disable.</para>
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Container runtime for the cluster. Supports containerd, sandboxed containers, and Docker.</para>
        /// <remarks>
        /// <para>Kubernetes 1.24 no longer supports Docker as a built-in container runtime.</para>
        /// </remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/160313.html">Comparison of Docker, containerd, and sandboxed container runtimes</a>.</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        [Obsolete]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// <para>Specify an existing security group ID when creating a cluster. Choose either this parameter or <c>is_enterprise_security_group</c>. Cluster nodes are automatically added to this security group.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configuration, use the <c>security_hardening_os</c> parameter under <c>control_plane_config</c>. For node pool configuration, use the <c>security_hardening_os</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Alibaba Cloud OS security hardening. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enable Alibaba Cloud OS security hardening.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disable Alibaba Cloud OS security hardening.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("security_hardening_os")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? SecurityHardeningOs { get; set; }

        /// <summary>
        /// <para>ServiceAccount is the access credential used by pods to communicate with the cluster API Server. The <c>service-account-issuer</c> is the issuer identity in the <c>serviceaccount token</c>, represented by the <c>iss</c> field in the <c>token payload</c>.</para>
        /// <para>For more information about <c>ServiceAccount</c>, see <a href="https://help.aliyun.com/document_detail/160384.html">Deploy service account token volume projection</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes.default.svc</para>
        /// </summary>
        [NameInMap("service_account_issuer")]
        [Validation(Required=false)]
        public string ServiceAccountIssuer { get; set; }

        /// <summary>
        /// <para>Service network CIDR block. Valid ranges: 10.0.0.0/16-24, 172.16.0.0/16-24 to 172.31.0.0/16-24, 192.168.0.0/16-24.
        /// It cannot overlap with the VPC CIDR block 10.1.0.0/21 or existing Kubernetes cluster CIDR blocks in the VPC. This cannot be modified after cluster creation.</para>
        /// <para>Default value: 172.19.0.0/20.</para>
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
        /// <para><b>[Deprecated]</b> Service discovery type for the cluster, used to specify the service discovery method in <c>ACK Serverless</c> clusters.</para>
        /// <list type="bullet">
        /// <item><description><para><c>CoreDNS</c>: Uses the standard Kubernetes service discovery component CoreDNS. Requires deploying a set of containers for DNS resolution. Defaults to two ECI instances with 0.25 vCPU and 512 MiB memory each.</para>
        /// </description></item>
        /// <item><description><para><c>PrivateZone</c>: Uses Alibaba Cloud PrivateZone for service discovery. Requires enabling the PrivateZone service.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Disabled.</para>
        /// </summary>
        [NameInMap("service_discovery_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> ServiceDiscoveryTypes { get; set; }

        /// <summary>
        /// <para>Configure SNAT for the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Automatically create a NAT Gateway and configure SNAT rules. Set this to <c>true</c> if nodes or applications in the cluster need public network access.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Do not create a NAT Gateway or SNAT rules. Nodes and applications in the cluster cannot access the public network.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not enable this during cluster creation but later need public network access, you can <a href="https://help.aliyun.com/document_detail/178480.html">enable it manually</a>.</para>
        /// </remarks>
        /// <para>Default value: <c>false</c>.</para>
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
        /// <para><b>[Deprecated]</b> For control plane node configuration, use the <c>soc_enabled</c> parameter under <c>control_plane_config</c>. For node pool configuration, use the <c>soc_enabled</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>MLPS 2.0 security hardening. For more information, see <a href="https://help.aliyun.com/document_detail/196148.html">Using MLPS 2.0 security hardening in ACK</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enable MLPS 2.0 security hardening.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disable MLPS 2.0 security hardening.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("soc_enabled")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? SocEnabled { get; set; }

        /// <summary>
        /// <para>Whether to enable public SSH logon. Used to log on to master nodes of ACK dedicated clusters. This parameter does not take effect for managed clusters.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enable.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disable.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ssh_flags")]
        [Validation(Required=false)]
        public bool? SshFlags { get; set; }

        /// <summary>
        /// <para>Node labels. Label rules:</para>
        /// <list type="bullet">
        /// <item><description><para>Labels consist of case-sensitive key-value pairs. You can add up to 20 tags.</para>
        /// </description></item>
        /// <item><description><para>Tag keys must be unique and up to 64 characters long. Tag values can be empty and up to 128 characters long. Neither tag keys nor tag values can start with &quot;aliyun&quot;, &quot;acs:&quot;, &quot;https\://&quot;, or &quot;http\://&quot;. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>taints</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c>.</para>
        /// <para>Node taint information. Taints and tolerations work together to prevent pods from being scheduled onto unsuitable nodes. For more information, see <a href="https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/">taint-and-toleration</a>.</para>
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        [Obsolete]
        public List<Taint> Taints { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> By default, clusters are not rolled back on creation failure. You must manually clean up failed clusters.</para>
        /// <para>Cluster creation timeout in minutes.</para>
        /// <para>Default value: <c>60</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("timeout_mins")]
        [Validation(Required=false)]
        [Obsolete]
        public long? TimeoutMins { get; set; }

        /// <summary>
        /// <para>Time zone used by the cluster. See <a href="https://help.aliyun.com/document_detail/354879.html">Supported time zones</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>Custom cluster CA.</para>
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
        /// <para><b>[Deprecated]</b> Custom node data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFD****</para>
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        [Obsolete]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The VPC used by the cluster. You must provide this when creating a cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zeik9h3ahvv2zz95****</para>
        /// </summary>
        [NameInMap("vpcid")]
        [Validation(Required=false)]
        public string Vpcid { get; set; }

        /// <summary>
        /// <para>Virtual switches for cluster nodes. This field is required when creating a zero-node managed cluster.</para>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>auto_renew</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Whether to enable auto-renewal for worker nodes. Valid only when <c>worker_instance_charge_type</c> is <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enable auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disable auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>auto_renew_period</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Auto-renewal period for worker nodes in months. Required and valid only when subscription billing is selected.</para>
        /// <para>Valid values: {1, 2, 3, 6, 12}.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>data_disks</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Configuration for worker node data disks, including type and size.</para>
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        [Obsolete]
        public List<CreateClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class CreateClusterRequestWorkerDataDisks : TeaModel {
            /// <summary>
            /// <para>Data disk type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Whether to encrypt the data disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Encrypt the data disk.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Do not encrypt the data disk.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>Data disk performance level. Applies only to <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("performance_level")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>Data disk size in GiB. Valid range: 40–32767.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>instance_charge_type</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Worker node billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PrePaid</c>: Subscription.</para>
        /// </description></item>
        /// <item><description><para><c>PostPaid</c>: Pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Pay-as-you-go.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>instance_types</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Worker node instance configuration.</para>
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>period</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Subscription duration for worker nodes in months. Required and valid only when <c>worker_instance_charge_type</c> is <c>PrePaid</c>.</para>
        /// <para>Valid values: {1, 2, 3, 6, 12, 24, 36, 48, 60}.</para>
        /// <para>Default value: 1.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>period_unit</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Worker node billing cycle. Required when worker_instance_charge_type is <c>PrePaid</c>.</para>
        /// <para>Valid value: <c>Month</c>. Only monthly billing is supported.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>system_disk_category</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Worker node system disk type. For more information, see <a href="https://help.aliyun.com/document_detail/63136.html">Overview of Elastic Block Storage</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cloud_efficiency</c>: Ultra disk.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_ssd</c>: Standard SSD.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>cloud_ssd</c>.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>system_disk_performance_level</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>When the system disk is an ESSD, you can set the performance level (PL). For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PL0</para>
        /// </description></item>
        /// <item><description><para>PL1</para>
        /// </description></item>
        /// <item><description><para>PL2</para>
        /// </description></item>
        /// <item><description><para>PL3</para>
        /// </description></item>
        /// </list>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>system_disk_size</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Worker node system disk size in GiB.</para>
        /// <para>Valid range: [40,500].</para>
        /// <para>This value must be greater than or equal to max{40, ImageSize}.</para>
        /// <para>Default value: <c>120</c>.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>system_disk_snapshot_policy_id</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>Automatic snapshot policy ID for worker node system disks.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the <c>vswitch_ids</c> parameter under <c>scaling_group</c> in <c>nodepool</c>.</para>
        /// <para>List of vSwitches used by cluster nodes. One node corresponds to one value.</para>
        /// <para>When creating a zero-node managed cluster, <c>worker_vswitch_ids</c> is optional, but you must provide <c>vswitch_ids</c>.</para>
        /// </summary>
        [NameInMap("worker_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerVswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the <c>zone_ids</c> parameter instead.</para>
        /// <para>The zone ID in the cluster region. This parameter applies only to ACK managed clusters.</para>
        /// <para>When creating an ACK managed cluster, if you do not specify <c>vpc_id</c> and <c>vswitch_ids</c>, you must specify <c>zone_id</c> to automatically create VPC network resources in this zone. This parameter is ignored if you specify <c>vpc_id</c> and <c>vswitch_ids</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beiji****</para>
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>A list of zone IDs in the cluster region. This parameter applies only to ACK managed clusters.</para>
        /// </summary>
        [NameInMap("zone_ids")]
        [Validation(Required=false)]
        public List<string> ZoneIds { get; set; }

    }

}
