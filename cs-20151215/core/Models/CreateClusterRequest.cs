// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterRequest : Darabonba.Model {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The access control list (ACL) of the SLB instance for the API server of a registered cluster.</para>
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// <para>The list of cluster components. When you create a cluster, use <c>addons</c> to specify the components that you want to install.</para>
        /// <para><b>Network component</b>: Required. Two network types are available: Flannel and Terway. Select one when you create a cluster:</para>
        /// <list type="bullet">
        /// <item><description>Flannel: [{&quot;name&quot;:&quot;flannel&quot;,&quot;config&quot;:&quot;&quot;}\].</description></item>
        /// <item><description>Terway: [{&quot;name&quot;: &quot;terway-eniip&quot;,&quot;config&quot;: &quot;&quot;}\].</description></item>
        /// </list>
        /// <para><b>Storage component</b>: Optional. Only the <c>csi</c> type is supported:</para>
        /// <para><c>csi</c>: [{&quot;name&quot;:&quot;csi-plugin&quot;,&quot;config&quot;: &quot;&quot;},{&quot;name&quot;: &quot;csi-provisioner&quot;,&quot;config&quot;: &quot;&quot;}\].</para>
        /// <para><b>Log component</b>: Optional. We recommend that you enable this component. If you do not enable the log service, you cannot use the cluster auditing feature.</para>
        /// <list type="bullet">
        /// <item><description>Use an existing <c>SLS Project</c>: [{&quot;name&quot;: &quot;loongcollector&quot;,&quot;config&quot;: &quot;{\&quot;IngressDashboardEnabled\&quot;:\&quot;true\&quot;,\&quot;sls_project_name\&quot;:\&quot;your_sls_project_name\&quot;}&quot;}\].</description></item>
        /// <item><description>Create a new <c>SLS Project</c>: [{&quot;name&quot;: &quot;loongcollector&quot;,&quot;config&quot;: &quot;{\&quot;IngressDashboardEnabled\&quot;:\&quot;true\&quot;}&quot;}\].</description></item>
        /// </list>
        /// <para><b>Ingress component</b>: Optional. By default, the Ingress component <c>nginx-ingress-controller</c> is installed for ACK dedicated clusters.</para>
        /// <list type="bullet">
        /// <item><description>Install Ingress and enable Internet access: [{&quot;name&quot;:&quot;nginx-ingress-controller&quot;,&quot;config&quot;:&quot;{\&quot;IngressSlbNetworkType\&quot;:\&quot;internet\&quot;}&quot;}\].</description></item>
        /// <item><description>Disable default Ingress installation: [{&quot;name&quot;: &quot;nginx-ingress-controller&quot;,&quot;config&quot;: &quot;&quot;,&quot;disabled&quot;: true}\].</description></item>
        /// </list>
        /// <para><b>Event Center</b>: Optional. Enabled by default.</para>
        /// <para>Event Center provides the capabilities to store, query, and alert on Kubernetes events. The Logstore associated with Kubernetes Event Center is free of charge for 90 days. For more information about the free policy, see <a href="https://help.aliyun.com/document_detail/150476.html">Create and use Kubernetes Event Center</a>.</para>
        /// <para>Example of enabling Event Center: [{&quot;name&quot;:&quot;ack-node-problem-detector&quot;,&quot;config&quot;:&quot;{\&quot;sls_project_name\&quot;:\&quot;your_sls_project_name\&quot;}&quot;}\].</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<Addon> Addons { get; set; }

        /// <summary>
        /// <para>A ServiceAccount is the access credential used by a pod to communicate with the cluster API server. The <c>api-audiences</c> parameter specifies the valid request <c>token</c> identities used by the <c>apiserver</c> to authenticate whether request <c>tokens</c> are legitimate. You can configure multiple <c>audiences</c> separated by commas (,).</para>
        /// <para>For more information about <c>ServiceAccount</c>, see <a href="https://help.aliyun.com/document_detail/160384.html">Deploy service account token volume projection</a>.</para>
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
        public class CreateClusterRequestAuditLogConfig : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to enable the cluster audit log feature. Valid values:</para>
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
            /// <para>The <a href="https://help.aliyun.com/document_detail/48873.html">SLS Project</a> that contains the <a href="https://help.aliyun.com/document_detail/48873.html">Logstore</a> for cluster audit logs.</para>
            /// <list type="bullet">
            /// <item><description><para>Default value: <c>k8s-log-{clusterid}</c>.</para>
            /// </description></item>
            /// <item><description><para>After the cluster audit log feature is enabled, a Logstore for cluster audit logs is created in the specified SLS Project.</para>
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
        /// <para>The <a href="https://help.aliyun.com/document_detail/2938898.html">intelligent managed mode</a> configuration.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public CreateClusterRequestAutoMode AutoMode { get; set; }
        public class CreateClusterRequestAutoMode : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to enable intelligent managed mode. Valid values:</para>
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
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect only when <c>charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enable auto-renewal.</description></item>
        /// <item><description><c>false</c>: Disable auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>This parameter was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Notice on behavior changes of the CreateCluster parameter</a>.</para>
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
        /// <para>The auto-renewal epoch. This parameter takes effect only when the billing method is subscription and auto-renewal is enabled. When <c>PeriodUnit=Month</c>, valid values: {1, 2, 3, 6, 12}.</para>
        /// <para>Default value: 1.</para>
        /// <para>This parameter was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Notice on behavior changes of the CreateCluster parameter</a>.</para>
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
        /// <para>The billing method of the CLB instance used by the API server. Default value: PostPaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// <item><description>PrePaid: subscription. The subscription billing method is no longer supported for newly created CLB instances. Existing instances are not affected.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Notice on behavior changes of the CreateCluster parameter</a>.</description></item>
        /// <item><description>Starting from December 01, 2024, newly created CLB instances no longer support the subscription billing method, and an instance fee will be charged.</notice>
        /// <props="china">For more information, see [Service notices: Notice on canceling subscription billing for CLB load balancing instances of cluster API servers](https://help.aliyun.com/document_detail/2851191.html) and [Notice on billing item changes for Classic Load Balancer (CLB)](https://help.aliyun.com/document_detail/2839797.html).
        /// <props="intl">For more information, see [Notice on billing item changes for Classic Load Balancer (CLB)](https://help.aliyun.com/document_detail/2839797.html).</description></item>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>security_hardening_os</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>security_hardening_os</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane node configuration, use the <c>cloud_monitor_flags</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>cms_enabled</c> parameter under <c>kubernetes_config</c> in nodepool instead.</para>
        /// <para>Specifies whether to install the CloudMonitor agent on the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Install the CloudMonitor agent.</description></item>
        /// <item><description><c>false</c>: Do not install the CloudMonitor agent.</description></item>
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
        /// <para>The cluster local domain name.</para>
        /// <para>Naming rules: A domain name consists of one or more parts separated by periods (.). Each part can be up to 63 characters long and can contain lowercase letters, digits, and hyphens (-). Each part must start and end with a lowercase letter or digit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster.local</para>
        /// </summary>
        [NameInMap("cluster_domain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// <para>After you set <c>cluster_type</c> to <c>ManagedKubernetes</c> and configure <c>profile</c>, you can further specify the cluster specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ack.standard</c>: Basic Edition (selected by default if the value is empty)</description></item>
        /// <item><description><c>ack.pro.small</c>: Pro Edition</description></item>
        /// <item><description><c>ack.pro.xlarge</c>: Pro XL</description></item>
        /// <item><description><c>ack.pro.2xlarge</c>: Pro 2XL</description></item>
        /// <item><description><c>ack.pro.4xlarge</c>: Pro 4XL (requires contacting customer service to enable the whitelist)</description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are three tiers provided by &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>. By pre-allocating and dedicating control plane resources, these tiers ensure that API concurrency and pod scheduling capabilities remain at a deterministic high level. They are suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For information about the cluster management fees for Pro Edition and Provisioned Control Plane editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fee</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fee</a>.</para>
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
        /// <item><description><c>ManagedKubernetes</c>: ACK managed cluster types, including ACK managed clusters (Pro and Basic editions), ACK Serverless clusters (Pro and Basic editions), ACK Edge clusters (Pro and Basic editions), and ACK Lingjun clusters (Pro Edition).</description></item>
        /// <item><description><c>ExternalKubernetes</c>: registered cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The pod network CIDR block. It must be a valid private CIDR block, specifically the following CIDR blocks and their subnets: 10.0.0.0/8, 172.16-31.0.0/12-16, and 192.168.0.0/16. It cannot overlap with the CIDR blocks used by the VPC or existing Kubernetes clusters in the VPC. This value cannot be modified after the cluster is created.</para>
        /// <para>For more information about cluster network planning, see <a href="https://help.aliyun.com/document_detail/86500.html">ACK managed cluster network planning</a>.</para>
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
        /// <para>The control plane configuration for ACK dedicated clusters.</para>
        /// </summary>
        [NameInMap("control_plane_config")]
        [Validation(Required=false)]
        public CreateClusterRequestControlPlaneConfig ControlPlaneConfig { get; set; }
        public class CreateClusterRequestControlPlaneConfig : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for control plane nodes. This parameter takes effect only when the billing method is set to <c>PrePaid</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enables auto-renewal.</description></item>
            /// <item><description>false: Disables auto-renewal.</description></item>
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
            /// <para>The auto-renewal period for control plane nodes.</para>
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
            /// <para>The billing method for control plane nodes.</para>
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
            /// <para>Specifies whether to install CloudMonitor on nodes.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Installs the CloudMonitor agent.</para>
            /// </description></item>
            /// <item><description><para>false: Does not install the CloudMonitor agent.</para>
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
            /// <para>The CPU management policy for nodes.</para>
            /// <list type="bullet">
            /// <item><description><para>static: Allows pods with certain resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.</para>
            /// </description></item>
            /// <item><description><para>none: Uses the existing default CPU affinity scheme.</para>
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
            /// <para>The instance types for nodes.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The name of the key pair. You must set this parameter or login_password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>The SSH logon password. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. You must set this parameter or key_pair.</para>
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
            /// <para>The subscription duration for control plane nodes. This parameter is required and takes effect only when the billing method is set to <c>PrePaid</c>.</para>
            /// <para>Valid values: {1, 2, 3, 6, 12, 24, 36, 48, 60}. Unit: months.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription duration for control plane nodes. This parameter is required and takes effect only when the billing method is set to <c>PrePaid</c>.</para>
            /// <para>Valid value: <c>Month</c>. Currently, only month-based billing cycles are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The runtime name for control plane nodes. Valid values:</para>
            /// <para>containerd: The Containerd runtime, which is supported by all cluster versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Alibaba Cloud OS security hardening.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables Alibaba Cloud OS security hardening.</para>
            /// </description></item>
            /// <item><description><para>false: Disables Alibaba Cloud OS security hardening.</para>
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
            /// <para>The number of control plane nodes.</para>
            /// <para>Valid values: <c>3</c> or <c>5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable MLPS security hardening.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables MLPS 2.0 security hardening.</para>
            /// </description></item>
            /// <item><description><para>false: Disables MLPS 2.0 security hardening.</para>
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
            /// <para>Specifies whether to enable burst performance for node system cloud disks.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The type of the node system cloud disk.</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_efficiency</c>: ultra cloud disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
            /// <item><description><c>cloud_essd</c>: ESSD.</description></item>
            /// <item><description><c>cloud_auto</c>: ESSD AutoPL cloud disk.</description></item>
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry cloud disk.</description></item>
            /// </list>
            /// <para>Default value: <c>cloud_ssd</c>. The default value may vary by zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the node system cloud disk. This parameter takes effect only for ESSD cloud disks.</para>
            /// <para>The performance level varies based on the cloud disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS for node system cloud disks.</para>
            /// <para>Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}. Baseline performance = min{1,800 + 50 × capacity, 50000}.</para>
            /// <para>This parameter is supported only when <c>system_disk_category</c> is set to <c>cloud_auto</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the node system cloud disk.</para>
            /// <para>Valid values: [40, 500]. Unit: GiB.</para>
            /// <para>Default value: <c>120</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The automatic snapshot policy for node system cloud disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-2zej1nogjvovnz4z****</para>
            /// </summary>
            [NameInMap("system_disk_snapshot_policy_id")]
            [Validation(Required=false)]
            public string SystemDiskSnapshotPolicyId { get; set; }

        }

        /// <summary>
        /// <para>The cluster endpoint configuration.</para>
        /// </summary>
        [NameInMap("control_plane_endpoints_config")]
        [Validation(Required=false)]
        public CreateClusterRequestControlPlaneEndpointsConfig ControlPlaneEndpointsConfig { get; set; }
        public class CreateClusterRequestControlPlaneEndpointsConfig : Darabonba.Model {
            /// <summary>
            /// <para>The internal DNS configuration for the cluster. This parameter applies to ACK managed clusters. The internal domain name is used by node-side system components such as kubelet and kube-proxy to access the API Server. If the internal domain name access is not enabled, node-side system components access the API Server through the CLB IP address.</para>
            /// </summary>
            [NameInMap("internal_dns_config")]
            [Validation(Required=false)]
            public CreateClusterRequestControlPlaneEndpointsConfigInternalDnsConfig InternalDnsConfig { get; set; }
            public class CreateClusterRequestControlPlaneEndpointsConfigInternalDnsConfig : Darabonba.Model {
                /// <summary>
                /// <para>The VPCs where the internal DNS records of the cluster take effect.</para>
                /// </summary>
                [NameInMap("bind_vpcs")]
                [Validation(Required=false)]
                public List<string> BindVpcs { get; set; }

            }

            /// <summary>
            /// <para>The cluster endpoint configuration. When this parameter is specified, the endpoint_public_access and load_balancer_id parameters do not take effect. ACK supports only automatic creation of NLB instances. To specify a CLB or NLB instance, use load_balancers_config to specify the corresponding instance ID.</para>
            /// </summary>
            [NameInMap("load_balancers_config")]
            [Validation(Required=false)]
            public List<CreateClusterRequestControlPlaneEndpointsConfigLoadBalancersConfig> LoadBalancersConfig { get; set; }
            public class CreateClusterRequestControlPlaneEndpointsConfigLoadBalancersConfig : Darabonba.Model {
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
        /// <para>By default, logs are collected from kube-apiserver, kube-controller-manager, kube-scheduler, and cloud-controller-manager.</para>
        /// </summary>
        [NameInMap("controlplane_log_components")]
        [Validation(Required=false)]
        public List<string> ControlplaneLogComponents { get; set; }

        /// <summary>
        /// <para>The Simple Log Service project for control plane component logs. You can use an existing project for log storage or allow the system to automatically create a project. If you choose automatic creation, a Simple Log Service project named <c>k8s-log-{ClusterID}</c> is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-log-xxx</para>
        /// </summary>
        [NameInMap("controlplane_log_project")]
        [Validation(Required=false)]
        public string ControlplaneLogProject { get; set; }

        /// <summary>
        /// <para>The log retention period for control plane component logs, in days.</para>
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
        /// <para><b>[Deprecated]</b> Use the <c>cpu_policy</c> parameter under <c>control_plane_config</c> for cluster control plane configuration, or use the <c>cpu_policy</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> for node pool configuration.</para>
        /// <para>The CPU management policy for nodes. The following policies are supported for clusters of version 1.12.6 or later:</para>
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
        [Obsolete]
        public string CpuPolicy { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the <c>extra_sans</c> parameter instead.</para>
        /// <para>The custom certificate Subject Alternative Name (SAN). Separate multiple IP addresses or domain names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs.aliyun.com</para>
        /// </summary>
        [NameInMap("custom_san")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustomSan { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cluster deletion protection, which prevents the cluster from being accidentally deleted in the console or by calling API operations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables cluster deletion protection. The cluster cannot be deleted in the console or by calling API operations.</description></item>
        /// <item><description><c>false</c>: Disables cluster deletion protection. The cluster can be deleted in the console or by calling API operations.</description></item>
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
        /// <para><b>[Deprecated]</b> When cluster creation fails, no rollback is performed by default. You must manually clean up the failed cluster.</para>
        /// <para>Specifies whether to roll back the cluster if creation fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Rolls back the cluster when creation fails.</description></item>
        /// <item><description><c>false</c>: Does not roll back the cluster when creation fails.</description></item>
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
        /// <para>Specifies whether to enable the RRSA feature.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables the feature.</para>
        /// </description></item>
        /// <item><description><para>false: Does not enable the feature.</para>
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
        /// <para>The ID of the Key Management Service (KMS) key used to encrypt cloud disks. For more information, see <a href="https://help.aliyun.com/document_detail/28935.html">Key Management Service</a>.</para>
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
        /// <para>Specifies whether to enable public network access. An Elastic IP Address (EIP) is used to expose the API Server for public network access to the cluster.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables public network access.</description></item>
        /// <item><description><c>false</c>: Disables public network access. If you select this option, the cluster API Server cannot be accessed over the Internet.</description></item>
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
        /// <para>The custom Subject Alternative Name (SAN) for the API Server certificate.</para>
        /// </summary>
        [NameInMap("extra_sans")]
        [Validation(Required=false)]
        public List<string> ExtraSans { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Selecting existing nodes during cluster creation is not supported. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> operation.</para>
        /// <para>Specifies whether to mount data disks to existing instances when creating a cluster with existing instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Stores containers and images on data disks. Existing data on the data disks will be lost. Back up your data in advance.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not store containers and images on data disks.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>Data disk mounting rules:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS instance has data disks attached and the file system of the last data disk is not initialized, the system automatically formats the data disk as ext4 to store /var/lib/docker and /var/lib/kubelet.</description></item>
        /// <item><description>If the ECS instance has no data disks attached, no new data disks are mounted.</description></item>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>image_id</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>image_id</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The custom image for nodes. The system image is used by default. When a custom image is selected, it replaces the default system image. For more information, see <a href="https://help.aliyun.com/document_detail/146647.html">Custom images</a>.</para>
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
        /// <para><b>[Deprecated]</b> Selecting existing nodes during cluster creation is not supported. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> operation.</para>
        /// <para>The list of ECS instances to use when creating a cluster with existing nodes. These instances are added to the cluster as worker nodes.</para>
        /// <remarks>
        /// <para>This field is required when you create a cluster with existing instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>The IP protocol stack of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Valid values:
        /// ipv4 (single stack)
        /// dual (dual stack). Default value: ipv4</para>
        /// </summary>
        [NameInMap("ip_stack")]
        [Validation(Required=false)]
        public string IpStack { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic creation of an advanced security group. This parameter takes effect when <c>security_group_id</c> is empty.</para>
        /// <remarks>
        /// <para>When a basic security group is used, the total number of nodes and Terway pods in the cluster cannot exceed 2,000. Therefore, when creating a Terway network type cluster, use an advanced security group.</para>
        /// </remarks>
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
        /// <para><b>[Deprecated]</b> Selecting existing nodes during cluster creation is not supported. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> operation.</para>
        /// <para>Specifies whether to retain instance names when creating a cluster with existing instances.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>key_pair</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>key_pair</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The name of the key pair. Mutually exclusive with <c>login_password</c>.</para>
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
        /// <para>You can create clusters of the three most recent versions. Call the <a href="https://help.aliyun.com/document_detail/2667899.html">DescribeKubernetesVersionMetadata</a> operation to query supported cluster versions.</para>
        /// <para>For more information about Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Kubernetes version release overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>The Classic Load Balancer (CLB) instance ID used for API Server access. If this parameter is specified, automatic creation of an API Server CLB instance is skipped.</para>
        /// <remarks>
        /// <para>Ensure that the CLB instance has no other dependencies such as listeners or backend servers. Shared and Internet-facing CLB instances are not supported.</para>
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
        /// <para><b>[Deprecated]</b> CLB uses pay-by-usage billing. This parameter does not take effect.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>login_password</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>login_password</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>The SSH logon password. Mutually exclusive with <c>key_pair</c>. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        [Obsolete]
        public string LoginPassword { get; set; }

        /// <summary>
        /// <para>The cluster O&amp;M window.</para>
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>auto_renew</c> parameter under <c>control_plane_config</c> instead.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>auto_renew_period</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The auto-renewal epoch for master nodes. This parameter takes effect and is required only when the subscription billing method is selected.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>size</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The number of master nodes. Valid values: <c>3</c> or <c>5</c>.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>instance_charge_type</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The billing method for master nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PrePaid</c>: Subscription.</description></item>
        /// <item><description><c>PostPaid</c>: Pay-as-you-go.</description></item>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>instance_types</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The instance types for master nodes. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// </summary>
        [NameInMap("master_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MasterInstanceTypes { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>unit</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The subscription duration for master nodes. This parameter takes effect and is required only when <c>master_instance_charge_type</c> is set to <c>PrePaid</c>.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>period_unit</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The subscription period unit for master nodes. This parameter is required when the billing method is <c>PrePaid</c>.</para>
        /// <para>Valid values: <c>Month</c>. Currently, only monthly billing is supported.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>system_disk_category</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The system cloud disk type for master nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cloud_efficiency</c>: Ultra cloud disk.</description></item>
        /// <item><description><c>cloud_ssd</c>: Standard SSD.</description></item>
        /// <item><description><c>cloud_essd</c>: Enterprise SSD (ESSD).</description></item>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>system_disk_performance_level</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The performance level of the system cloud disk for master nodes. This parameter takes effect only for ESSD cloud disks. The performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>system_disk_size</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The system cloud disk size for master nodes. Valid values: [40,500\]. Unit: GiB.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the <c>system_disk_snapshot_policy_id</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>The ID of the automatic snapshot policy for master node system cloud disks.</para>
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
        /// <para>The list of vSwitch IDs for master nodes. The number of vSwitches must be in the range of [1,3\]. To ensure high availability, select three vSwitches distributed across different zones.</para>
        /// <para>The number of specified instance types must match the value of <c>master_count</c> and correspond one-to-one with the elements in <c>master_vswitch_ids</c>.</para>
        /// </summary>
        [NameInMap("master_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MasterVswitchIds { get; set; }

        /// <summary>
        /// <para>The custom cluster name. The name can contain digits, Chinese characters, letters, and hyphens (-). The name must be 1 to 63 characters in length and cannot start with a hyphen (-).</para>
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
        /// <para>The number of IP addresses per node, determined by specifying the network CIDR block. This parameter takes effect only for Flannel network type clusters.</para>
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
        /// <para>The node service port range. Valid port range: [30000,65535\].</para>
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
        /// <para><b>[Deprecated]</b> Use the desired_size parameter under scaling_group in nodepool instead.</para>
        /// <para>The number of worker nodes. Valid values: 0 to 100.</para>
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
        public class CreateClusterRequestOperationPolicy : Darabonba.Model {
            /// <summary>
            /// <para>The cluster auto upgrade configuration.</para>
            /// </summary>
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public CreateClusterRequestOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class CreateClusterRequestOperationPolicyClusterAutoUpgrade : Darabonba.Model {
                /// <summary>
                /// <para>The cluster auto upgrade frequency. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>patch: Automatically upgrades to the latest available patch version within the current minor version. The new Kubernetes version does not contain breaking changes.</description></item>
                /// <item><description>stable: Automatically upgrades to the latest patch version of the second-latest minor version. The new Kubernetes version may involve API and feature changes, but its stability has been extensively validated.</description></item>
                /// <item><description>rapid: Automatically upgrades to the latest patch version of the latest minor version, allowing faster access to new features from the Kubernetes community.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>stable</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable cluster auto upgrade.</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enabled.</para>
                /// </description></item>
                /// <item><description><para>false: Not enabled.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane node configuration, use the image_type parameter under control_plane_config instead. For node pool configuration, use the image_type parameter under scaling_group in nodepool instead.</para>
        /// <para>The operating system platform type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Windows</description></item>
        /// <item><description>Linux</description></item>
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
        /// <para>The subscription duration. This parameter takes effect and is required only when charge_type is set to PrePaid.</para>
        /// <para>Valid values: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
        /// <para>Default value: 1.</para>
        /// <para>This parameter was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Notice on behavior changes of the CreateCluster API parameters</a>.</para>
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
        /// <para>The billing cycle. This parameter is required when the billing method is set to PrePaid.</para>
        /// <para>Valid values: Month. Currently, only monthly billing cycles are supported.</para>
        /// <para>This parameter was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Notice on behavior changes of the CreateCluster API parameters</a>.</para>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the platform parameter under scaling_group in nodepool instead.</para>
        /// <para>The operating system distribution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CentOS</description></item>
        /// <item><description>AliyunLinux</description></item>
        /// <item><description>QbootAliyunLinux</description></item>
        /// <item><description>Qboot</description></item>
        /// <item><description>Windows</description></item>
        /// <item><description>WindowsCore</description></item>
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
        /// <para><b>[Deprecated]</b> When the Terway network plugin is selected, specify vSwitches for Pod IP address allocation. Each Pod vSwitch corresponds to a worker node vSwitch, and the zones of the Pod vSwitch and the worker node vSwitch must be the same.</para>
        /// <remarks>
        /// <para>The CIDR block mask of the Pod vSwitch should not exceed 19 and must not exceed 25. Otherwise, the number of Pod IP addresses available in the cluster network is very limited, which affects normal cluster usage.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("pod_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// <para>When <c>cluster_type</c> is set to <c>ManagedKubernetes</c> (ACK managed clusters), you can further specify the cluster subtype.</para>
        /// <list type="bullet">
        /// <item><description><c>Default</c>: ACK managed cluster, including ACK clusters (Pro and Basic editions).</description></item>
        /// <item><description><c>Edge</c>: ACK Edge cluster, including ACK Edge clusters (Pro and Basic editions).</description></item>
        /// <item><description><c>Serverless</c>: ACK Serverless cluster, including ACK Serverless clusters (Pro and Basic editions).</description></item>
        /// <item><description><c>Lingjun</c>: ACK Lingjun cluster, available in Pro edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>The kube-proxy mode.</para>
        /// <list type="bullet">
        /// <item><description><c>iptables</c>: A mature and stable kube-proxy mode. Service discovery and load balancing for Kubernetes Services are configured by using iptables rules. Performance is moderate and affected by cluster scale. This mode is suitable for clusters with a small number of Services.</description></item>
        /// <item><description><c>ipvs</c>: A high-performance kube-proxy mode. Service discovery and load balancing for Kubernetes Services are configured by using the Linux IPVS module. This mode is suitable for clusters with a large number of Services that require high load balancing performance.</description></item>
        /// <item><description><c>nftables</c>: A next-generation kube-proxy mode that implements Service discovery and load balancing based on Linux nftables. It is a modern replacement for iptables. Compared with iptables, nftables delivers better network performance, more efficient rule updates, and improved performance in large-scale Service scenarios.<br>Only supported for clusters running version 1.35 or later. The Kubernetes community deprecated IPVS starting from version 1.35. For new clusters, use nftables for longer-term community support.</description></item>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the rds_instances parameter under scaling_group in nodepool instead.</para>
        /// <para>The list of ApsaraDB RDS instances to which you want to add the cluster nodes to the whitelist. Add the container Pod CIDR block and node CIDR block to the RDS whitelist directly. Setting RDS instances may fail if the instances are not in a running state.</para>
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
        /// <para>The ID of the resource group to which the cluster belongs. Use this parameter to isolate different resources.</para>
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
        public class CreateClusterRequestRrsaConfig : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether to enable the RRSA feature.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Not enabled.</para>
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
        /// <para>The container runtime used by the cluster. Supported runtimes include containerd, sandboxed containers, and Docker.</para>
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
        /// <para>The ID of an existing security group. This parameter is mutually exclusive with <c>is_enterprise_security_group</c>. Cluster nodes are automatically added to this security group.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane configuration, use the security_hardening_os parameter under control_plane_config instead. For node pool configuration, use the security_hardening_os parameter under scaling_group in nodepool instead.</para>
        /// <para>Alibaba Cloud OS security hardening. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables Alibaba Cloud OS security hardening.</description></item>
        /// <item><description><c>false</c>: Does not enable Alibaba Cloud OS security hardening.</description></item>
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
        /// <para>A ServiceAccount is the access credential used for communication between a Pod and the cluster API Server. The <c>service-account-issuer</c> is the issuer identity in the <c>serviceaccount token</c>, which is the <c>iss</c> field in the <c>token payload</c>.</para>
        /// <para>For more information about <c>ServiceAccount</c>, see <a href="https://help.aliyun.com/document_detail/160384.html">Deploy service account token volume projection</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes.default.svc</para>
        /// </summary>
        [NameInMap("service_account_issuer")]
        [Validation(Required=false)]
        public string ServiceAccountIssuer { get; set; }

        /// <summary>
        /// <para>The CIDR block for the Service network. Valid ranges: 10.0.0.0/16-24, 172.16-31.0.0/16-24, and 192.168.0.0/16-24. The CIDR block cannot overlap with the VPC CIDR block 10.1.0.0/21 or CIDR blocks used by existing Kubernetes clusters in the VPC. This value cannot be modified after the cluster is created.</para>
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
        /// <para><b>[Deprecated]</b> The service discovery type within the cluster, used to specify the service discovery method in <c>ACK Serverless</c> clusters.</para>
        /// <list type="bullet">
        /// <item><description><c>CoreDNS</c>: Uses the Kubernetes-native standard service discovery component CoreDNS. A set of containers must be deployed in the cluster for DNS resolution. By default, two ECI instances with 0.25 Core and 512 MiB specifications are used.</description></item>
        /// <item><description><c>PrivateZone</c>: Uses Alibaba Cloud PrivateZone to provide service discovery capabilities. The PrivateZone service must be activated.</description></item>
        /// </list>
        /// <para>Default value: not enabled.</para>
        /// </summary>
        [NameInMap("service_discovery_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> ServiceDiscoveryTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to configure SNAT for the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Automatic creation of a NAT gateway and automatic configuration of SNAT rules. Settings this to <c>true</c> if nodes and applications in the cluster need to access the Internet.</description></item>
        /// <item><description><c>false</c>: Does not create a NAT gateway or SNAT rules. Nodes and applications in the cluster cannot access the Internet.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this is not enabled during cluster creation and Internet access is required later, you can <a href="https://help.aliyun.com/document_detail/178480.html">manually enable it</a>.</para>
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
        /// <para><b>[Deprecated]</b> For cluster control plane node configurations, use the <c>soc_enabled</c> parameter under <c>control_plane_config</c> instead. For node pool configurations, use the <c>soc_enabled</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>MLPS 2.0 security hardening. For more information, see [China Chinese China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("soc_enabled")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? SocEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public network SSH logon. This parameter is used to log on to the master nodes of ACK dedicated clusters. This parameter does not take effect for managed clusters.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enabled.</description></item>
        /// <item><description><c>false</c>: Not enabled.</description></item>
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
        /// <para>The node tags. Tag definition rules:</para>
        /// <list type="bullet">
        /// <item><description>Tags are case-sensitive key-value pairs. You can settings up to 20 tags.</description></item>
        /// <item><description>Tag keys cannot be duplicated and can be up to 64 characters in length. Tag values can be empty and can be up to 128 characters in length. Tag keys and tag values cannot start with &quot;aliyun&quot;, &quot;acs:&quot;, &quot;https://&quot;, or &quot;http://&quot;. For details, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the taints parameter under kubernetes_config in nodepool instead.</para>
        /// <para>The node taint information. Taints and tolerations work together to prevent Pods from being allocated to inappropriate nodes. For more information, see <a href="https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/">taint-and-toleration</a>.</para>
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        [Obsolete]
        public List<Taint> Taints { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> When cluster creation fails, the system does not perform a rollback by default. You must manually clean up the failed cluster.</para>
        /// <para>The cluster creation timeout period, in minutes.</para>
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
        /// <para>The VPC used by the cluster. You must provide a VPC when creating a cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zeik9h3ahvv2zz95****</para>
        /// </summary>
        [NameInMap("vpcid")]
        [Validation(Required=false)]
        public string Vpcid { get; set; }

        /// <summary>
        /// <para>The vSwitches where the cluster nodes reside. This parameter is required when creating a zero-node managed cluster.</para>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> For node pool configuration, use the auto_renew parameter under scaling_group in nodepool instead.</para>
        /// <para>Specifies whether to enable auto-renewal for worker nodes. This parameter takes effect only when <c>worker_instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables auto-renewal.</description></item>
        /// <item><description><c>false</c>: Does not enable auto-renewal.</description></item>
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
        /// <para><b>[Deprecated]</b> For node pool configuration, use the auto_renew_period parameter under scaling_group in nodepool instead.</para>
        /// <para>The Unified Auto Renewal Cycle for worker nodes. This parameter takes effect and is required only when the subscription billing method is selected.</para>
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
        /// <para><b>[Deprecated]</b> Use the data_disks parameter under scaling_group in nodepool instead for node pool configurations.</para>
        /// <para>The combination of data cloud disk type, size, and other configurations for worker nodes.</para>
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        [Obsolete]
        public List<CreateClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class CreateClusterRequestWorkerDataDisks : Darabonba.Model {
            /// <summary>
            /// <para>The data cloud disk type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt data cloud disks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Encrypts data cloud disks.</description></item>
            /// <item><description><c>false</c>: Does not encrypt data cloud disks.</description></item>
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
            /// <para>The performance level (PL) of node data cloud disks. This parameter takes effect only for <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("performance_level")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The data cloud disk size. Valid values: 40 to 32767. Unit: GiB.</para>
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
        /// <para><b>[Deprecated]</b> Use the instance_charge_type parameter under scaling_group in nodepool instead for node pool configurations.</para>
        /// <para>The billing method for worker nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PrePaid</c>: subscription.</description></item>
        /// <item><description><c>PostPaid</c>: pay-as-you-go.</description></item>
        /// </list>
        /// <para>Default value: pay-as-you-go.</para>
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
        /// <para><b>[Deprecated]</b> Use the instance_types parameter under scaling_group in nodepool instead for node pool configurations.</para>
        /// <para>The instance configurations for worker nodes.</para>
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the period parameter under scaling_group in nodepool instead for node pool configurations.</para>
        /// <para>The subscription duration for worker nodes. This parameter takes effect and is required only when <c>worker_instance_charge_type</c> is set to <c>PrePaid</c>.</para>
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
        /// <para><b>[Deprecated]</b> Use the period_unit parameter under scaling_group in nodepool instead for node pool configurations.</para>
        /// <para>The billing period unit for worker nodes. This parameter is required when the billing method is <c>PrePaid</c>.</para>
        /// <para>Valid values: <c>Month</c>. Currently, only monthly billing is supported.</para>
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
        /// <para><b>[Deprecated]</b> Use the system_disk_category parameter under scaling_group in nodepool instead for node pool configurations.</para>
        /// <para>The system cloud disk type for worker nodes. For more information, see <a href="https://help.aliyun.com/document_detail/63136.html">Block storage overview</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cloud_efficiency</c>: ultra cloud disk.</description></item>
        /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
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
        /// <para><b>[Deprecated]</b> Use the system_disk_performance_level parameter under scaling_group in nodepool instead for node pool configurations.</para>
        /// <para>The performance level (PL) of the system cloud disk when the system cloud disk is an ESSD. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
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
        /// <para><b>[Deprecated]</b> Use the system_disk_size parameter under scaling_group in nodepool instead for node pool configurations.</para>
        /// <para>The system cloud disk size for worker nodes. Unit: GiB.</para>
        /// <para>Valid values: [40,500\].</para>
        /// <para>The value of this parameter must be greater than or equal to max{40, ImageSize}.</para>
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
        /// <para><b>[Deprecated]</b> Use the system_disk_snapshot_policy_id parameter under scaling_group in nodepool instead for node pool configurations.</para>
        /// <para>The ID of the automatic snapshot policy used by the system cloud disks of worker nodes.</para>
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
        /// <para><b>[Deprecated]</b> Use the vswitch_ids parameter under scaling_group in nodepool instead for node pool configurations.</para>
        /// <para>The list of vSwitches used by cluster nodes. Each node corresponds to one value.</para>
        /// <para>When you create a managed cluster with zero nodes, the <c>worker_vswitch_ids</c> field is not required, but you must provide <c>vswitch_ids</c>.</para>
        /// </summary>
        [NameInMap("worker_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerVswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the <c>zone_ids</c> parameter instead.</para>
        /// <para>The active zone ID of the region to which the cluster belongs. This parameter is specific to ACK managed clusters.</para>
        /// <para>When you create an ACK managed cluster without specifying <c>vpc_id</c> and <c>vswitch_ids</c>, you must specify <c>zone_id</c> for the cluster to automatically create a VPC and related network resources in the specified zone. This parameter is ignored when <c>vpc_id</c> and <c>vswitch_ids</c> are specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beiji****</para>
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The IDs of multiple zones in the region to which the cluster belongs. This parameter is specific to ACK managed clusters.</para>
        /// </summary>
        [NameInMap("zone_ids")]
        [Validation(Required=false)]
        public List<string> ZoneIds { get; set; }

    }

}

