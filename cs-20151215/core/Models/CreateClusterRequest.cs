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
        /// <para><b>[Deprecated]</b> The access control list (ACL) for the Server Load Balancer (SLB) instance of the API server in a registered cluster.</para>
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// <para>The list of cluster components. You can use <c>addons</c> to specify the cluster components that you want to install when you create a cluster.</para>
        /// <para><b>Network components</b>: Required. Includes two options for the network type: Flannel and Terway. You must select one of them when you create a cluster:</para>
        /// <list type="bullet">
        /// <item><description>Flannel: [{&quot;name&quot;:&quot;flannel&quot;,&quot;config&quot;:&quot;&quot;}\].</description></item>
        /// <item><description>Terway: [{&quot;name&quot;: &quot;terway-eniip&quot;,&quot;config&quot;: &quot;&quot;}\].</description></item>
        /// </list>
        /// <para><b>Storage components</b>: Optional. Only <c>csi</c> is supported:</para>
        /// <para><c>csi</c>: [{&quot;name&quot;:&quot;csi-plugin&quot;,&quot;config&quot;: &quot;&quot;},{&quot;name&quot;: &quot;csi-provisioner&quot;,&quot;config&quot;: &quot;&quot;}\].</para>
        /// <para><b>Log components</b>: Optional. We recommend that you enable this component. If you do not enable Log Service, you cannot use the cluster audit feature.</para>
        /// <list type="bullet">
        /// <item><description>Use an existing <c>SLS Project</c>: [{&quot;name&quot;: &quot;loongcollector&quot;,&quot;config&quot;: &quot;{\&quot;IngressDashboardEnabled\&quot;:\&quot;true\&quot;,\&quot;sls_project_name\&quot;:\&quot;your_sls_project_name\&quot;}&quot;}\].</description></item>
        /// <item><description>Create a new <c>SLS Project</c>: [{&quot;name&quot;: &quot;loongcollector&quot;,&quot;config&quot;: &quot;{\&quot;IngressDashboardEnabled\&quot;:\&quot;true\&quot;}&quot;}\].</description></item>
        /// </list>
        /// <para><b>Ingress components</b>: Optional. By default, the <c>nginx-ingress-controller</c> Ingress component is installed in ACK dedicated clusters.</para>
        /// <list type="bullet">
        /// <item><description>Install the Ingress component and enable Internet access: [{&quot;name&quot;:&quot;nginx-ingress-controller&quot;,&quot;config&quot;:&quot;{\&quot;IngressSlbNetworkType\&quot;:\&quot;internet\&quot;}&quot;}\].</description></item>
        /// <item><description>Disable the default installation of the Ingress component: [{&quot;name&quot;: &quot;nginx-ingress-controller&quot;,&quot;config&quot;: &quot;&quot;,&quot;disabled&quot;: true}\].</description></item>
        /// </list>
        /// <para><b>Event center</b>: Optional. Enabled by default.</para>
        /// <para>The event center provides capabilities such as storage, query, and alerting for Kubernetes events. The Logstore associated with the Kubernetes event center is free of charge for 90 days. For more information about the free quota policy, see <a href="https://help.aliyun.com/document_detail/150476.html">Create and use a Kubernetes event center</a>.</para>
        /// <para>Example of enabling the event center: [{&quot;name&quot;:&quot;ack-node-problem-detector&quot;,&quot;config&quot;:&quot;{\&quot;sls_project_name\&quot;:\&quot;your_sls_project_name\&quot;}&quot;}\].</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<Addon> Addons { get; set; }

        /// <summary>
        /// <para>A ServiceAccount is the access credential for communication between pods and the cluster API server. <c>api-audiences</c> specifies the valid identities for request <c>tokens</c> and is used by the <c>apiserver</c> to authenticate whether a request <c>token</c> is valid. You can configure multiple <c>audiences</c> and separate them with commas (,).</para>
        /// <para>For more information about <c>ServiceAccount</c>, see <a href="https://help.aliyun.com/document_detail/160384.html">Deploy service account token volume projection</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes.default.svc</para>
        /// </summary>
        [NameInMap("api_audiences")]
        [Validation(Required=false)]
        public string ApiAudiences { get; set; }

        /// <summary>
        /// <para>The cluster audit log configurations.</para>
        /// </summary>
        [NameInMap("audit_log_config")]
        [Validation(Required=false)]
        public CreateClusterRequestAuditLogConfig AuditLogConfig { get; set; }
        public class CreateClusterRequestAuditLogConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the cluster audit log feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
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
            /// <para>The <a href="https://help.aliyun.com/document_detail/48873.html">SLS Project</a> where the <a href="https://help.aliyun.com/document_detail/48873.html">Logstore</a> for cluster audit logs is located.</para>
            /// <list type="bullet">
            /// <item><description><para>Default value: <c>k8s-log-{clusterid}</c>.</para>
            /// </description></item>
            /// <item><description><para>After you enable the cluster audit log feature, a Logstore for cluster audit logs is created in the specified SLS Project.</para>
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
        /// <para>The <a href="https://help.aliyun.com/document_detail/2938898.html">intelligent managed mode</a> configurations.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public CreateClusterRequestAutoMode AutoMode { get; set; }
        public class CreateClusterRequestAutoMode : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the intelligent managed mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
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
        /// <para><b>[Deprecated]</b> Specifies whether to enable auto-renewal. This parameter takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables auto-renewal.</description></item>
        /// <item><description><c>false</c>: Disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>This parameter was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on parameter behavior changes of the CreateCluster operation for cluster creation</a>.</para>
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
        /// <para><b>[Deprecated]</b> The auto-renewal cycle. This parameter takes effect only when you select subscription and auto-renewal. When <c>PeriodUnit</c> is set to <c>Month</c>, valid values are 1, 2, 3, 6, and 12.</para>
        /// <para>Default value: 1.</para>
        /// <para>This parameter was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on parameter behavior changes of the CreateCluster operation for cluster creation</a>.</para>
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
        /// <para><b>[Deprecated]</b> The billing method of the Classic Load Balancer (CLB) instance used by the API server. Default value: PostPaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: Pay-as-you-go.</description></item>
        /// <item><description>PrePaid: Subscription. This billing method is no longer supported for new CLB instances, but existing instances are not affected.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on parameter behavior changes of the CreateCluster operation for cluster creation</a>.</description></item>
        /// <item><description>Starting December 1, 2024, newly created CLB instances no longer support the subscription billing method, and an instance fee is charged.</notice>
        /// <props="china">For more information, see [Service notices: Deprecation of the subscription billing method for the CLB instance of the API server in newly created clusters](https://help.aliyun.com/document_detail/2851191.html) and [Announcement on billing item adjustments for Classic Load Balancer (CLB)](https://help.aliyun.com/document_detail/2839797.html).
        /// <props="intl">For more information, see [Announcement on billing item adjustments for Classic Load Balancer (CLB)](https://help.aliyun.com/document_detail/2839797.html).</description></item>
        /// </list>
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
        /// <para><b>[Deprecated]</b> To configure the cluster control plane, use the <c>security_hardening_os</c> parameter under <c>control_plane_config</c> instead. To configure node pools, use the <c>security_hardening_os</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("cis_enabled")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? CisEnabled { get; set; }

        /// <summary>
        /// <para>The client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a287651-1277-4c0d-80d2-623a4*****</para>
        /// </summary>
        [NameInMap("client_token")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> To configure control plane nodes of a cluster, use the <c>cloud_monitor_flags</c> parameter under <c>control_plane_config</c> instead. To configure node pools, use the <c>cms_enabled</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead.</para>
        /// <para>Specifies whether to install the CloudMonitor agent on the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Installs the CloudMonitor agent.</description></item>
        /// <item><description><c>false</c>: Does not install the CloudMonitor agent.</description></item>
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
        /// <para>The local domain name of the cluster.</para>
        /// <para>Naming rules: The domain name consists of one or more parts separated by periods (.). Each part can be up to 63 characters in length and can contain lowercase letters, digits, and hyphens (-). It must start and end with a lowercase letter or a digit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster.local</para>
        /// </summary>
        [NameInMap("cluster_domain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// <para>After you set <c>cluster_type</c> to <c>ManagedKubernetes</c> and configure <c>profile</c>, you can further specify the cluster edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ack.standard</c>: Basic Edition. This is the default value if this parameter is left empty.</description></item>
        /// <item><description><c>ack.pro.small</c>: Pro Edition.</description></item>
        /// <item><description><c>ack.pro.xlarge</c>: Pro XL.</description></item>
        /// <item><description><c>ack.pro.2xlarge</c>: Pro 2XL.</description></item>
        /// <item><description><c>ack.pro.4xlarge</c>: Pro 4XL. You must contact customer service to apply for whitelist access.</description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are three tiers provided by &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>. By pre-allocating and reserving control plane resources, these editions ensure that API concurrency and pod scheduling capabilities are always maintained at a consistently high level. They are suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For more information about the cluster management fees for Pro Edition and provisioned control plane editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Kubernetes</c>: ACK dedicated cluster.</description></item>
        /// <item><description><c>ManagedKubernetes</c>: ACK managed cluster, including ACK managed clusters (Pro Edition and Basic Edition), ACK Serverless clusters (Pro Edition and Basic Edition), ACK Edge clusters (Pro Edition and Basic Edition), and ACK Lingjun clusters (Pro Edition).</description></item>
        /// <item><description><c>ExternalKubernetes</c>: Registered cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The CIDR block for pods. It must be a valid private CIDR block, specifically one of the following CIDR blocks or their subnets: 10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16. It cannot overlap with the CIDR block of the VPC or the CIDR blocks used by existing Kubernetes clusters in the VPC. It cannot be modified after the cluster is created.</para>
        /// <para>For more information about cluster network planning, see <a href="https://help.aliyun.com/document_detail/86500.html">Network planning for ACK managed clusters</a>.</para>
        /// <remarks>
        /// <para>This parameter is required for Flannel clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.0.0/16</para>
        /// </summary>
        [NameInMap("container_cidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        /// <summary>
        /// <para>The control plane configuration for an ACK dedicated cluster.</para>
        /// </summary>
        [NameInMap("control_plane_config")]
        [Validation(Required=false)]
        public CreateClusterRequestControlPlaneConfig ControlPlaneConfig { get; set; }
        public class CreateClusterRequestControlPlaneConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for control plane nodes. This parameter takes effect only when the billing method is set to PrePaid. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables auto-renewal.</description></item>
            /// <item><description>false: disables auto-renewal.</description></item>
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
            /// <para>The auto-renewal period for control plane nodes. Valid values: 1, 2, 3, 6, and 12. Unit: months.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The billing method for control plane nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PrePaid: subscription.</description></item>
            /// <item><description>PostPaid: pay-as-you-go.</description></item>
            /// </list>
            /// <para>Default value: PostPaid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("charge_type")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to install the CloudMonitor agent on the nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: installs the CloudMonitor agent.</description></item>
            /// <item><description>false: does not install the CloudMonitor agent.</description></item>
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
            /// <para>The CPU management policy for nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>static: allows you to enhance CPU affinity and exclusivity for pods with specific resource characteristics on the node.</description></item>
            /// <item><description>none: uses the default CPU affinity policy.</description></item>
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
            /// <para>The ID of the deployment set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp10b35imuam5amw****</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20240819.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The type of the operating system image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux3</para>
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The instance metadata access configuration for ECS instances. This parameter is available only to users in the whitelist. To use this parameter, submit a ticket.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>The instance types of the nodes.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The name of the key pair. You must specify this parameter or the login_password parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>The SSH logon password. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. You must specify this parameter or the key_pair parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The service port range of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("node_port_range")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>The subscription period for control plane nodes. This parameter is required and takes effect only when the billing method is set to PrePaid. Valid values: 1, 2, 3, 6, 12, 24, 36, 48, and 60. Unit: months.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription period for control plane nodes. This parameter is required and takes effect only when the billing method is set to PrePaid. Valid value: Month. Currently, only months are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The name of the runtime for control plane nodes. Valid value:</para>
            /// <para>containerd: the containerd runtime, which supports all cluster versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable security hardening for Alibaba Cloud OS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables security hardening for Alibaba Cloud OS.</description></item>
            /// <item><description>false: disables security hardening for Alibaba Cloud OS.</description></item>
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
            /// <para>The number of control plane nodes. Valid values: 3 and 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable MLPS 2.0 security hardening. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables MLPS 2.0 security hardening.</description></item>
            /// <item><description>false: disables MLPS 2.0 security hardening.</description></item>
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
            /// <para>Specifies whether to enable the performance burst feature for the system cloud disk of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the feature.</description></item>
            /// <item><description>false: disables the feature.</description></item>
            /// </list>
            /// <para>This parameter is supported only when system_disk_category is set to cloud_auto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The type of the system cloud disk for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL cloud disk.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry cloud disk.</description></item>
            /// </list>
            /// <para>Default value: cloud_ssd. The default value may vary by zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the system cloud disk for the node. This parameter takes effect only for ESSDs. The performance level varies based on the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD (standard SSD)</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read and write IOPS for the system cloud disk of the node. Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}. Baseline performance = min{1,800 + 50 × capacity, 50,000}. </para>
            /// <para>This parameter is supported only when system_disk_category is set to cloud_auto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk for the node. Valid values: 40 to 500. Unit: GiB.</para>
            /// <para>Default value: 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The ID of the automatic snapshot policy for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-2zej1nogjvovnz4z****</para>
            /// </summary>
            [NameInMap("system_disk_snapshot_policy_id")]
            [Validation(Required=false)]
            public string SystemDiskSnapshotPolicyId { get; set; }

        }

        /// <summary>
        /// <para>The connection configuration of the cluster. If you specify this parameter, the endpoint_public_access and load_balancer_id parameters do not take effect. To specify a CLB or NLB instance, use load_balancers_config to specify the corresponding instance ID.</para>
        /// </summary>
        [NameInMap("control_plane_endpoints_config")]
        [Validation(Required=false)]
        public CreateClusterRequestControlPlaneEndpointsConfig ControlPlaneEndpointsConfig { get; set; }
        public class CreateClusterRequestControlPlaneEndpointsConfig : TeaModel {
            /// <summary>
            /// <para>The internal DNS configuration of the cluster, which applies to ACK managed clusters. The internal domain name is used by node-side system components such as kubelet and kube-proxy to access the API server. If internal domain name access is not enabled, node-side system components access the API server by using the IP address of the CLB instance.</para>
            /// </summary>
            [NameInMap("internal_dns_config")]
            [Validation(Required=false)]
            public CreateClusterRequestControlPlaneEndpointsConfigInternalDnsConfig InternalDnsConfig { get; set; }
            public class CreateClusterRequestControlPlaneEndpointsConfigInternalDnsConfig : TeaModel {
                /// <summary>
                /// <para>The VPCs where the internal DNS records of the cluster take effect.</para>
                /// </summary>
                [NameInMap("bind_vpcs")]
                [Validation(Required=false)]
                public List<string> BindVpcs { get; set; }

            }

            /// <summary>
            /// <para>The connection configuration of the cluster. If you specify this parameter, the endpoint_public_access and load_balancer_id parameters do not take effect. ACK supports only automatic creation of NLB instances. To specify a CLB or NLB instance, use load_balancers_config to specify the corresponding instance ID.</para>
            /// </summary>
            [NameInMap("load_balancers_config")]
            [Validation(Required=false)]
            public List<CreateClusterRequestControlPlaneEndpointsConfigLoadBalancersConfig> LoadBalancersConfig { get; set; }
            public class CreateClusterRequestControlPlaneEndpointsConfigLoadBalancersConfig : TeaModel {
                /// <summary>
                /// <para>The type of the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("endpoint_type")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                /// <summary>
                /// <para>The ID of the NLB instance.</para>
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
        /// <para>The list of component names. This parameter specifies the control plane components whose logs are collected. By default, logs of kube-apiserver, kube-controller-manager, kube-scheduler, and cloud-controller-manager are collected.</para>
        /// </summary>
        [NameInMap("controlplane_log_components")]
        [Validation(Required=false)]
        public List<string> ControlplaneLogComponents { get; set; }

        /// <summary>
        /// <para>The Log Service project for control plane component logs. You can use an existing project for log storage, or use the automatic creation feature to create a project. If you choose automatic creation, a Log Service project named k8s-log-{ClusterID} is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-log-xxx</para>
        /// </summary>
        [NameInMap("controlplane_log_project")]
        [Validation(Required=false)]
        public string ControlplaneLogProject { get; set; }

        /// <summary>
        /// <para>The log retention period for control plane components. Unit: days.</para>
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
        /// <para><b>[Deprecated]</b> Use the cpu_policy parameter under control_plane_config for cluster control plane configuration, and use the cpu_policy parameter under kubernetes_config in nodepool for node pool configuration.</para>
        /// <para>The CPU management policy for nodes. This parameter supports the following policies when the cluster version is 1.12.6 or later:</para>
        /// <list type="bullet">
        /// <item><description>static: allows you to enhance CPU affinity and exclusivity for pods with specific resource characteristics on the node.</description></item>
        /// <item><description>none: uses the default CPU affinity policy.</description></item>
        /// </list>
        /// <para>Default value: none.</para>
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
        /// <para><b>[Deprecated]</b> Use the extra_sans parameter instead.</para>
        /// <para>The SANs of the custom certificate. Separate multiple IP addresses or domain names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs.aliyun.com</para>
        /// </summary>
        [NameInMap("custom_san")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustomSan { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the cluster to prevent accidental deletion through the console or API calls. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables cluster deletion protection. The cluster cannot be deleted through the console or API.</description></item>
        /// <item><description><c>false</c>: Disables cluster deletion protection. The cluster can be deleted through the console or API.</description></item>
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
        /// <para><b>[Deprecated]</b> By default, no rollback is performed when cluster creation fails. You must manually clean up the failed cluster.</para>
        /// <para>Specifies whether to perform a rollback when cluster creation fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Performs a rollback when cluster creation fails.</description></item>
        /// <item><description><c>false</c>: Does not perform a rollback when cluster creation fails.</description></item>
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
        /// <para>Specifies whether to enable RRSA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables RRSA.</description></item>
        /// <item><description>false: Disables RRSA.</description></item>
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
        /// <para>The ID of the KMS key used to encrypt data cloud disks. For more information, see <a href="https://help.aliyun.com/document_detail/28935.html">Key Management Service</a>.</para>
        /// <remarks>
        /// <para>This feature takes effect only in ACK Pro clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0fe64791-55eb-4fc7-84c5-c6c7cdca****</para>
        /// </summary>
        [NameInMap("encryption_provider_key")]
        [Validation(Required=false)]
        public string EncryptionProviderKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public network access. An elastic IP address (EIP) is used to expose the API Server for public network access to the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables public network access.</description></item>
        /// <item><description><c>false</c>: Disables public network access. If you select this value, the cluster API Server cannot be accessed over the Internet.</description></item>
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
        /// <para>The custom Subject Alternative Name (SAN) of the API Server certificate.</para>
        /// </summary>
        [NameInMap("extra_sans")]
        [Validation(Required=false)]
        public List<string> ExtraSans { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> You cannot select existing nodes when creating a cluster. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> operation.</para>
        /// <para>Specifies whether to mount data cloud disks to existing instances when creating a cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Stores containers and images on data cloud disks. Existing data on the data cloud disks will be lost. Back up your data first.</description></item>
        /// <item><description><c>false</c>: Does not store containers and images on data cloud disks.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>Data cloud disk mounting rules:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS instance has data cloud disks attached and the file system of the last data cloud disk is not initialized, the system automatically formats the data cloud disk to ext4 to store /var/lib/docker and /var/lib/kubelet.</description></item>
        /// <item><description>If the ECS instance does not have data cloud disks attached, no new data cloud disk will be attached.</description></item>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>image_id</c> parameter under <c>control_plane_config</c> instead. For node pool configurations, use the <c>image_id</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The custom image for nodes. By default, the system image is used. If you select a custom image, it replaces the default system image. For more information, see <a href="https://help.aliyun.com/document_detail/146647.html">Custom images</a>.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>image_type</c> parameter under <c>control_plane_config</c> instead. For node pool configurations, use the <c>image_type</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The operating system distribution type. We recommend that you use this field to specify the node operating system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CentOS</description></item>
        /// <item><description>AliyunLinux</description></item>
        /// <item><description>AliyunLinux Qboot</description></item>
        /// <item><description>AliyunLinuxUEFI</description></item>
        /// <item><description>AliyunLinux3</description></item>
        /// <item><description>Windows</description></item>
        /// <item><description>WindowsCore</description></item>
        /// <item><description>AliyunLinux3Arm64</description></item>
        /// <item><description>ContainerOS</description></item>
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
        /// <para><b>[Deprecated]</b> You cannot select existing nodes when creating a cluster. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> operation.</para>
        /// <para>The list of existing ECS instances to be added as worker nodes when creating a cluster with existing nodes.</para>
        /// <remarks>
        /// <para>This field is required when you create a cluster with existing instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>The IP stack of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Valid values:
        /// ipv4 (single-stack)
        /// dual (dual-stack). Default value: ipv4</para>
        /// </summary>
        [NameInMap("ip_stack")]
        [Validation(Required=false)]
        public string IpStack { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic creation of an advanced security group. This parameter takes effect when <c>security_group_id</c> is empty.</para>
        /// <remarks>
        /// <para>If you use a basic security group, the total number of nodes and Terway pods in the cluster cannot exceed 2,000. Therefore, we recommend that you use an advanced security group when creating a cluster of the Terway network type.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Creates and uses an advanced security group.</description></item>
        /// <item><description><c>false</c>: Uses a basic security group.</description></item>
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
        /// <para><b>[Deprecated]</b> You cannot select existing nodes when creating a cluster. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> operation.</para>
        /// <para>Specifies whether to retain the instance names when creating a cluster with existing instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Retains the instance names.</description></item>
        /// <item><description><c>false</c>: Does not retain the instance names. The names are replaced based on system rules.</description></item>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>key_pair</c> parameter under <c>control_plane_config</c> instead. For node pool configurations, use the <c>key_pair</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The name of the key pair. You must specify either this parameter or <c>login_password</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>security-key</para>
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        [Obsolete]
        public string KeyPair { get; set; }

        /// <summary>
        /// <para>The cluster version, which is consistent with the Kubernetes community baseline version. We recommend that you select the latest version. If you do not specify this parameter, the latest version is used by default.</para>
        /// <para>You can create clusters of the latest three versions. You can call the <a href="https://help.aliyun.com/document_detail/2667899.html">DescribeKubernetesVersionMetadata</a> operation to query the supported cluster versions.</para>
        /// <para>For more information about the Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Kubernetes version release overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>The instance ID of the Classic Load Balancer (CLB) used for API server access. If you specify this parameter, automatic creation of a CLB instance for the API server is disabled.</para>
        /// <remarks>
        /// <para>Make sure that the CLB instance has no other dependencies, such as listeners or backend servers. Shared-resource and Internet-facing CLB instances are not supported.</para>
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
        /// <para><b>[Deprecated]</b> For CLB instances, billing is based on usage. This parameter does not take effect.</para>
        /// <para>The load balancing specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>slb.s1.small</description></item>
        /// <item><description>slb.s2.small</description></item>
        /// <item><description>slb.s2.medium</description></item>
        /// <item><description>slb.s3.small</description></item>
        /// <item><description>slb.s3.medium</description></item>
        /// <item><description>slb.s3.large</description></item>
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
        /// <para><b>[Deprecated]</b> This parameter enables Simple Log Service for the cluster. It takes effect only for ACK Serverless clusters and must be set to <c>SLS</c>.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>login_password</c> parameter under <c>control_plane_config</c> instead. For node pool configurations, use the <c>login_password</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The SSH logon password. You must specify either this parameter or <c>key_pair</c>. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        [Obsolete]
        public string LoginPassword { get; set; }

        /// <summary>
        /// <para>The maintenance window of the cluster.</para>
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>auto_renew</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Specifies whether to enable auto-renewal for master nodes. This parameter takes effect only when <c>master_instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables auto-renewal.</description></item>
        /// <item><description><c>false</c>: Disables auto-renewal.</description></item>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>auto_renew_period</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The auto-renewal epoch for master nodes. This parameter takes effect and is required only when the subscription billing method is selected.</para>
        /// <para>Valid values: 1, 2, 3, 6, and 12.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>size</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The number of master nodes. Valid values: <c>3</c> and <c>5</c>.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>instance_charge_type</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The billing method of master nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PrePaid</c>: subscription.</description></item>
        /// <item><description><c>PostPaid</c>: pay-as-you-go.</description></item>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>instance_types</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The instance types of master nodes. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// </summary>
        [NameInMap("master_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MasterInstanceTypes { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>unit</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The subscription period of master nodes. This parameter takes effect and is required only when <c>master_instance_charge_type</c> is set to <c>PrePaid</c>.</para>
        /// <para>Valid values: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>period_unit</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The subscription period unit of master nodes. This parameter is required when the billing method is <c>PrePaid</c>.</para>
        /// <para>Valid value: <c>Month</c>. Currently, only month is supported.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>system_disk_category</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The system cloud disk category of master nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cloud_efficiency</c>: ultra disk.</description></item>
        /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
        /// <item><description><c>cloud_essd</c>: ESSD.</description></item>
        /// </list>
        /// <para>Default value: <c>cloud_ssd</c>. The default value may vary by zone.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>system_disk_performance_level</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The performance level of the system cloud disk for master nodes. This parameter takes effect only for ESSDs. The performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD standard SSD</a>.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>system_disk_size</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The system cloud disk size of master nodes. Valid values: 40 to 500. Unit: GiB.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configurations, use the <c>system_disk_snapshot_policy_id</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The ID of the automatic snapshot policy applied to the system cloud disk of master nodes.</para>
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
        /// <para>The list of vSwitch IDs for master nodes. You can specify 1 to 3 vSwitches. To ensure high availability of the cluster, we recommend that you select three vSwitches in different zones.</para>
        /// <para>The number of specified vSwitches must be consistent with the value of <c>master_count</c> and correspond to the elements in <c>master_vswitch_ids</c> one by one.</para>
        /// </summary>
        [NameInMap("master_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MasterVswitchIds { get; set; }

        /// <summary>
        /// <para>The custom name of the cluster. The name must be 1 to 63 characters in length and can contain digits, Chinese characters, English letters, and hyphens (-). It cannot start with a hyphen (-).</para>
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
        /// <para>The maximum number of IP addresses that can be assigned to nodes. This parameter determines the number of IP addresses by specifying the CIDR block of the network. It takes effect only for clusters of the Flannel network type.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>node_name_mode</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead.</para>
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
        /// <para>The node service port. Valid port range: 30000 to 65535.</para>
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
        /// <para>The list of node pools.</para>
        /// </summary>
        [NameInMap("nodepools")]
        [Validation(Required=false)]
        public List<Nodepool> Nodepools { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>desired_size</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead. The number of worker nodes. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("num_of_nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public long? NumOfNodes { get; set; }

        /// <summary>
        /// <para>The automatic O&amp;M policy for the cluster.</para>
        /// </summary>
        [NameInMap("operation_policy")]
        [Validation(Required=false)]
        public CreateClusterRequestOperationPolicy OperationPolicy { get; set; }
        public class CreateClusterRequestOperationPolicy : TeaModel {
            /// <summary>
            /// <para>The automatic cluster upgrade configuration.</para>
            /// </summary>
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public CreateClusterRequestOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class CreateClusterRequestOperationPolicyClusterAutoUpgrade : TeaModel {
                /// <summary>
                /// <para>The automatic cluster upgrade channel. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>patch: Automatically upgrades to the patch version when a patch version is available for the current minor version. The new Kubernetes version does not include breaking changes.</description></item>
                /// <item><description>stable: Automatically upgrades to the latest patch version of the second most recent minor version. The new Kubernetes version may include API and feature changes, but its stability has been widely verified.</description></item>
                /// <item><description>rapid: Automatically upgrades to the latest patch version of the latest minor version to obtain new features from the Kubernetes community faster.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>stable</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable automatic cluster upgrade. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
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
        /// <para><b>[Deprecated]</b> For control plane node configurations, use the <c>image_type</c> parameter under <c>control_plane_config</c> instead. For node pool configurations, use the <c>image_type</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead. The operating system platform type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Windows</description></item>
        /// <item><description>Linux
        /// Default value: <c>Linux</c>.</description></item>
        /// </list>
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
        /// <para><b>[Deprecated]</b> The subscription duration. This parameter takes effect and is required only when <c>charge_type</c> is set to <c>PrePaid</c>. Valid values: 1, 2, 3, 6, 12, 24, 36, 48, and 60. Default value: 1. This field was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on parameter behavior changes of the CreateCluster API operation</a>.</para>
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
        /// <para><b>[Deprecated]</b> The billing cycle. This parameter is required when the billing method is <c>PrePaid</c>. Valid value: <c>Month</c>. Currently, only monthly billing is supported. This field was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on parameter behavior changes of the CreateCluster API operation</a>.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>platform</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead. The operating system distribution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CentOS</description></item>
        /// <item><description>AliyunLinux</description></item>
        /// <item><description>QbootAliyunLinux</description></item>
        /// <item><description>Qboot</description></item>
        /// <item><description>Windows</description></item>
        /// <item><description>WindowsCore
        /// Default value: <c>CentOS</c>.</description></item>
        /// </list>
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
        /// <para><b>[Deprecated]</b> When the Terway network plug-in is selected, you must specify the vSwitches used to assign IP addresses to pods. Each pod vSwitch corresponds to a worker node vSwitch, and they must be in the same zone.</para>
        /// <remarks>
        /// <para>We recommend that the subnet mask length of the pod vSwitch does not exceed 19, and the maximum subnet mask length does not exceed 25. Otherwise, the number of pod IP addresses that can be allocated in the cluster network is very limited, which affects the normal use of the cluster.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("pod_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// <para>The cluster subtype when <c>cluster_type</c> is set to <c>ManagedKubernetes</c>, which indicates an ACK managed cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Default</c>: ACK managed clusters, including ACK Pro and ACK ACK clusters.</description></item>
        /// <item><description><c>Edge</c>: ACK Edge clusters, including ACK Edge Pro and ACK Edge ACK clusters.</description></item>
        /// <item><description><c>Serverless</c>: ACK Serverless clusters, including ACK Serverless Pro and ACK Serverless ACK clusters.</description></item>
        /// <item><description><c>Lingjun</c>: ACK Lingjun clusters, which provide the Pro edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>The kube-proxy mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>iptables</c>: A mature and stable kube-proxy mode. Service discovery and load balancing for Kubernetes Services are configured by using iptables rules. However, the performance is average and greatly affected by the scale. This mode is suitable for clusters with a small number of Services.</description></item>
        /// <item><description><c>ipvs</c>: A high-performance kube-proxy mode. Service discovery and load balancing for Kubernetes Services are configured by using the Linux IPVS module. This mode is suitable for clusters with a large number of Services and scenarios that require high-performance load balancing.</description></item>
        /// <item><description><c>nftables</c>: A next-generation kube-proxy mode. Service discovery and load balancing are implemented based on Linux nftables, which is a modern alternative to iptables. Compared with iptables, nftables provides better network performance, rule update efficiency, and performance in large-scale Service scenarios.
        /// This mode is supported only in clusters of Kubernetes 1.35 and later. The Kubernetes community deprecated IPVS in version 1.35. We recommend that you use nftables for new clusters to obtain long-term community support.
        /// Default value: <c>ipvs</c>.</description></item>
        /// </list>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>rds_instances</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead. The list of ApsaraDB RDS instances to which you want to add the cluster to the whitelist. We recommend that you add the pod CIDR block and node CIDR block to the RDS whitelist. If you specify RDS instances here, nodes may fail to be created because the instances are not in the running state.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// <para>The ID of the region where the cluster is deployed. For details, see <a href="https://help.aliyun.com/document_detail/216938.html">Regions supported by container service</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the cluster belongs. This parameter is used to isolate different resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3mkrure****</para>
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The configuration of the RAM Roles for Service Accounts (RRSA) feature.</para>
        /// </summary>
        [NameInMap("rrsa_config")]
        [Validation(Required=false)]
        public CreateClusterRequestRrsaConfig RrsaConfig { get; set; }
        public class CreateClusterRequestRrsaConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the RRSA feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
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
        /// <para>The container runtime used in the cluster. Valid values: containerd, sandboxed container, and Docker.</para>
        /// <remarks>
        /// <para>Kubernetes 1.24 and later no longer support Docker as a built-in container runtime.
        /// For more information, see <a href="https://help.aliyun.com/document_detail/160313.html">Comparison among Docker, containerd, and sandboxed container runtimes</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        [Obsolete]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// <para>The ID of the security group. Required when you create a cluster by using an existing security group. This parameter and is_enterprise_security_group are mutually exclusive. Cluster nodes are automatically added to this security group.</para>
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
        /// <para><b>[Deprecated]</b> For control plane configurations, use the <c>security_hardening_os</c> parameter under <c>control_plane_config</c> instead. For node pool configurations, use the <c>security_hardening_os</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead. Specifies whether to enable Alibaba Cloud OS security hardening. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enabled.</description></item>
        /// <item><description><c>false</c>: Disabled.
        /// Default value: <c>false</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("security_hardening_os")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? SecurityHardeningOs { get; set; }

        /// <summary>
        /// <para>A ServiceAccount is an access credential for communication between pods and the cluster API server. The <c>service-account-issuer</c> is the issuer identity in the <c>serviceaccount token</c>, which is the <c>iss</c> field in the <c>token payload</c>. For more information about <c>ServiceAccount</c>, see <a href="https://help.aliyun.com/document_detail/160384.html">Deploy service account token volume projection</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes.default.svc</para>
        /// </summary>
        [NameInMap("service_account_issuer")]
        [Validation(Required=false)]
        public string ServiceAccountIssuer { get; set; }

        /// <summary>
        /// <para>The CIDR block of the Service network. Valid values: 10.0.0.0/16 to 10.0.0.0/24, 172.16.0.0/16 to 172.31.0.0/24, and 192.168.0.0/16 to 192.168.0.0/24. The CIDR block cannot overlap with the VPC CIDR block 10.1.0.0/21 or the CIDR blocks used by existing Kubernetes clusters in the VPC. The CIDR block cannot be modified after the cluster is created. Default value: 172.19.0.0/20.</para>
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
        /// <para><b>[Deprecated]</b> The service discovery type used in the cluster. This parameter is used to specify the service discovery method in an <c>ACK Serverless</c> cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>CoreDNS</c>: Uses the standard Kubernetes service discovery component CoreDNS. You must deploy a group of containers in the cluster for DNS resolution. By default, two ECI instances with 0.25 vCPUs and 512 MiB of memory are used.</description></item>
        /// <item><description><c>PrivateZone</c>: Uses Alibaba Cloud PrivateZone to provide service discovery capabilities. You must activate the PrivateZone service.
        /// Default value: None (disabled).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("service_discovery_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> ServiceDiscoveryTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to configure SNAT for the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables automatic creation of a NAT gateway and configures SNAT rules. Settings: <c>true</c> is required if nodes and applications in the cluster need to access the Internet.</description></item>
        /// <item><description><c>false</c>: Does not create a NAT gateway or configure SNAT rules. Nodes and applications in the cluster cannot access the Internet.<remarks>
        /// <para>If you do not enable this feature when you create the cluster, you can <a href="https://help.aliyun.com/document_detail/178480.html">manually enable it</a> later if your business needs to access the Internet.
        /// Default value: <c>false</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para><b>[Deprecated]</b> For control plane node configurations, use the <c>soc_enabled</c> parameter under <c>control_plane_config</c> instead. For node pool configurations, use the <c>soc_enabled</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead. Specifies whether to enable mlps 2.0 security hardening. For more information, see <a href="https://help.aliyun.com/document_detail/196148.html">ACK mlps 2.0 security hardening instructions</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enabled.</description></item>
        /// <item><description><c>false</c>: Disabled.
        /// Default value: <c>false</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("soc_enabled")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? SocEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public SSH access. This parameter is used to log on to the master nodes of an ACK dedicated cluster. This parameter does not take effect in managed clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enabled.</description></item>
        /// <item><description><c>false</c>: Disabled.
        /// Default value: <c>false</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ssh_flags")]
        [Validation(Required=false)]
        public bool? SshFlags { get; set; }

        /// <summary>
        /// <para>The support policy for the cluster version. The value is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: Standard support.</description></item>
        /// <item><description>Extended: Extended support. After the standard support period ends, the cluster enters the extended support period and continues to receive CVE patch versions.
        /// Only ACK Pro managed clusters (where <c>cluster_spec</c> is set to <c>ack.pro.*</c> and <c>profile</c> is set to <c>Default</c>) support the <c>Extended</c> value. Specifying <c>Extended</c> for ACK Basic, ACS, ACK Edge managed, and ACK dedicated clusters will be rejected. Patch versions in the extended support period are also applicable only to ACK Pro managed clusters. Specifying such versions for other cluster types will be rejected. If this parameter is not specified, the default value is determined by the server configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Extended</para>
        /// </summary>
        [NameInMap("support_policy")]
        [Validation(Required=false)]
        public string SupportPolicy { get; set; }

        /// <summary>
        /// <para>The node tags. Tag definition rules:</para>
        /// <list type="bullet">
        /// <item><description>A tag is a case-sensitive key-value pair. You can configure up to 20 tags.</description></item>
        /// <item><description>Tag keys must be unique and can be up to 64 characters in length. Tag values can be empty and can be up to 128 characters in length. Tag keys and values cannot start with &quot;aliyun&quot;, &quot;acs:&quot;, &quot;https://&quot;, or &quot;http://&quot;. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>taints</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead. The taints of the nodes. Taints and tolerations work together to prevent pods from being scheduled to inappropriate nodes. For more information, see <a href="https://kubernetes.io/docs/concepts/scheduling-eviction/taint-and-toleration/">Taints and Tolerations</a>.
        /// <a href="https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/">taint-and-toleration</a></para>
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        [Obsolete]
        public List<Taint> Taints { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> By default, no rollback is performed when cluster creation fails. You must manually clean up the failed cluster. The timeout period for cluster creation, in minutes. Default value: <c>60</c>.</para>
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
        /// <para>The custom cluster CA certificate.</para>
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
        /// <para>The ID of the VPC used by the cluster. This parameter is required when you create the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zeik9h3ahvv2zz95****</para>
        /// </summary>
        [NameInMap("vpcid")]
        [Validation(Required=false)]
        public string Vpcid { get; set; }

        /// <summary>
        /// <para>The vSwitches where the cluster nodes are deployed. This parameter is required when you create a managed cluster with zero nodes.</para>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>auto_renew</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead. Specifies whether to enable auto-renewal for worker nodes. This parameter takes effect only when <c>worker_instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enabled.</description></item>
        /// <item><description><c>false</c>: Disabled.
        /// Default value: <c>true</c>.</description></item>
        /// </list>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>auto_renew_period</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The auto-renewal epoch for worker nodes. This parameter takes effect and is required only when the subscription billing method is selected.</para>
        /// <para>Valid values: 1, 2, 3, 6, and 12.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>data_disks</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The combination of configurations such as the type and size of the data cloud disks for worker nodes.</para>
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        [Obsolete]
        public List<CreateClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class CreateClusterRequestWorkerDataDisks : TeaModel {
            /// <summary>
            /// <para>The type of the data cloud disk.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the data cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Encrypts the data cloud disk.</description></item>
            /// <item><description><c>false</c>: Does not encrypt the data cloud disk.</description></item>
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
            /// <para>The performance level of the data cloud disk. This parameter takes effect only for <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("performance_level")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the data cloud disk. Valid values: 40 to 32767. Unit: GiB.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>instance_charge_type</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The billing method for worker nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PrePaid</c>: Subscription.</description></item>
        /// <item><description><c>PostPaid</c>: Pay-as-you-go.</description></item>
        /// </list>
        /// <para>Default value: <c>PostPaid</c>.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>instance_types</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The instance configurations for worker nodes.</para>
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>period</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The subscription duration for worker nodes. This parameter takes effect and is required only when <c>worker_instance_charge_type</c> is set to <c>PrePaid</c>.</para>
        /// <para>Valid values: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>period_unit</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The subscription period unit for worker nodes. This parameter is required when the billing method is set to <c>PrePaid</c>.</para>
        /// <para>Valid value: <c>Month</c>. Currently, only month is supported.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>system_disk_category</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The type of the system cloud disk for worker nodes. For more information, see <a href="https://help.aliyun.com/document_detail/63136.html">Block Storage overview</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cloud_efficiency</c>: Ultra cloud disk.</description></item>
        /// <item><description><c>cloud_ssd</c>: Standard SSD.</description></item>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>system_disk_performance_level</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>When the system cloud disk is an ESSD, you can configure the performance level (PL). For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0</description></item>
        /// <item><description>PL1</description></item>
        /// <item><description>PL2</description></item>
        /// <item><description>PL3</description></item>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>system_disk_size</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The size of the system cloud disk for worker nodes. Unit: GiB.</para>
        /// <para>Valid values: 40 to 500.</para>
        /// <para>The value of this parameter must be greater than or equal to the maximum of 40 and the image size.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>system_disk_snapshot_policy_id</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The ID of the automatic snapshot policy applied to the system cloud disk of worker nodes.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configurations, use the <c>vswitch_ids</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The list of vSwitches used by cluster nodes. Each node corresponds to one vSwitch.</para>
        /// <para>When you create a managed cluster with zero nodes, the <c>worker_vswitch_ids</c> parameter is not required, but you must specify <c>vswitch_ids</c>.</para>
        /// </summary>
        [NameInMap("worker_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerVswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the <c>zone_ids</c> parameter instead.</para>
        /// <para>The zone ID of the region where the cluster resides. This parameter is specific to managed ACK clusters.</para>
        /// <para>When you create a managed ACK cluster, if <c>vpc_id</c> and <c>vswitch_ids</c> are not specified, you must specify <c>zone_id</c> for the cluster to automatically create a VPC and network resources in this zone. If <c>vpc_id</c> and <c>vswitch_ids</c> are specified, this parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beiji****</para>
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The zone IDs of the region where the cluster resides. This parameter is specific to managed ACK clusters.</para>
        /// </summary>
        [NameInMap("zone_ids")]
        [Validation(Required=false)]
        public List<string> ZoneIds { get; set; }

    }

}
