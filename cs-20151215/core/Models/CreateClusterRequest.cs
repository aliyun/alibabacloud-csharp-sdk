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
        /// <para>[<b>This field is deprecated</b>] Registered cluster API Server SLB access control list.</para>
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// <para>List of cluster components. Specify the components to install when creating a cluster through <c>addons</c>.</para>
        /// <para><b>Network component</b>: Required. Choose between Flannel and Terway network types when creating a cluster:</para>
        /// <list type="bullet">
        /// <item><description>Flannel network: [{&quot;name&quot;:&quot;flannel&quot;,&quot;config&quot;:&quot;&quot;}].</description></item>
        /// <item><description>Terway network: [{&quot;name&quot;: &quot;terway-eniip&quot;,&quot;config&quot;: &quot;&quot;}] .</description></item>
        /// </list>
        /// <para><b>Storage component</b>: Optional. Only the <c>csi</c> type is supported:</para>
        /// <para><c>csi</c>: [{&quot;name&quot;:&quot;csi-plugin&quot;,&quot;config&quot;: &quot;&quot;},{&quot;name&quot;: &quot;csi-provisioner&quot;,&quot;config&quot;: &quot;&quot;}].</para>
        /// <para><b>Log component</b>: Optional. Recommended to enable. If Log Service is not enabled, the cluster audit feature will be unavailable.</para>
        /// <list type="bullet">
        /// <item><description>Use an existing <c>SLS Project</c>: [{&quot;name&quot;: &quot;loongcollector&quot;,&quot;config&quot;: &quot;{\&quot;IngressDashboardEnabled\&quot;:\&quot;true\&quot;,\&quot;sls_project_name\&quot;:\&quot;your_sls_project_name\&quot;}&quot;}] .</description></item>
        /// <item><description>Create a new <c>SLS Project</c>: [{&quot;name&quot;: &quot;loongcollector&quot;,&quot;config&quot;: &quot;{\&quot;IngressDashboardEnabled\&quot;:\&quot;true\&quot;}&quot;}] .</description></item>
        /// </list>
        /// <para><b>Ingress component</b>: Optional. ACK dedicated clusters install the Ingress component <c>nginx-ingress-controller</c> by default.</para>
        /// <list type="bullet">
        /// <item><description>Install Ingress with public network access: [{&quot;name&quot;:&quot;nginx-ingress-controller&quot;,&quot;config&quot;:&quot;{\&quot;IngressSlbNetworkType\&quot;:\&quot;internet\&quot;}&quot;}] .</description></item>
        /// <item><description>Disable default Ingress installation: [{&quot;name&quot;: &quot;nginx-ingress-controller&quot;,&quot;config&quot;: &quot;&quot;,&quot;disabled&quot;: true}] .</description></item>
        /// </list>
        /// <para><b>Event center</b>: Optional. Enabled by default.</para>
        /// <para>The event center provides capabilities for storing, querying, and alerting on Kubernetes events. The Logstore associated with the Kubernetes event center is free for 90 days. For more information about the free policy, see <a href="https://help.aliyun.com/document_detail/150476.html">Create and use the Kubernetes event center</a>.</para>
        /// <para>Example of enabling the event center: [{&quot;name&quot;:&quot;ack-node-problem-detector&quot;,&quot;config&quot;:&quot;{\&quot;sls_project_name\&quot;:\&quot;your_sls_project_name\&quot;}&quot;}].</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<Addon> Addons { get; set; }

        /// <summary>
        /// <para>ServiceAccount is the access credential for communication between Pods and the cluster API Server. <c>api-audiences</c> defines the valid request <c>token</c> identities used by the <c>apiserver</c> to verify whether the request <c>token</c> is legitimate. Multiple <c>audience</c> values can be configured, separated by commas (,).</para>
        /// <para>For more details about <c>ServiceAccount</c>, see <a href="https://help.aliyun.com/document_detail/160384.html">Deploy service account token volume projection</a>.</para>
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
            /// <para>Whether to enable the cluster audit log feature.</para>
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
            /// <para>The <a href="https://help.aliyun.com/document_detail/48873.html">SLS Project</a> where the cluster audit log <a href="https://help.aliyun.com/document_detail/48873.html">Logstore</a> is located.</para>
            /// <list type="bullet">
            /// <item><description><para>Default value: <c>k8s-log-{clusterid}</c>.</para>
            /// </description></item>
            /// <item><description><para>After enabling the cluster audit log feature, a corresponding Logstore will be created under the specified SLS Project.</para>
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
        /// <para><a href="https://help.aliyun.com/document_detail/2938898.html">Intelligent managed mode</a> configuration.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public CreateClusterRequestAutoMode AutoMode { get; set; }
        public class CreateClusterRequestAutoMode : TeaModel {
            /// <summary>
            /// <para>Whether to enable intelligent managed mode.</para>
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
        /// <para>[<b>This field is deprecated</b>]</para>
        /// <para>Whether to enable auto-renewal. Only takes effect when <c>charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enable auto-renewal.</description></item>
        /// <item><description><c>false</c>: Disable auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>This field was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on CreateCluster API parameter behavior changes</a>.</para>
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
        /// <para>[<b>This field is deprecated</b>]</para>
        /// <para>Auto-renewal period. Only takes effect when subscription and auto-renewal are selected. When <c>PeriodUnit=Month</c>, valid values: {1, 2, 3, 6, 12}.</para>
        /// <para>Default value: 1.</para>
        /// <para>This field was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on CreateCluster API parameter behavior changes</a>.</para>
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
        /// <para>[<b>This field is deprecated</b>]</para>
        /// <para>Billing type of the CLB instance used by the API Server. Default value: PostPaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: Pay-as-you-go.</description></item>
        /// <item><description>PrePaid: Subscription. This billing type is no longer supported for newly created CLB instances. Existing instances are not affected.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This field was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on CreateCluster API parameter behavior changes</a>.</description></item>
        /// <item><description>Starting from December 1, 2024, newly created CLB instances no longer support the subscription billing type, and instance fees will be charged.</notice>
        /// <props="china">For details, see [Product announcement on canceling subscription billing for cluster API Server CLB](https://help.aliyun.com/document_detail/2851191.html) and [CLB billing adjustment announcement](https://help.aliyun.com/document_detail/2839797.html).
        /// <props="intl">For details, see [CLB billing adjustment announcement](https://help.aliyun.com/document_detail/2839797.html).</description></item>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>security_hardening_os</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>security_hardening_os</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane node configuration, use the <c>cloud_monitor_flags</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>cms_enabled</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead.</para>
        /// <para>Whether to install the CloudMonitor agent in the cluster. Valid values:</para>
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
        /// <para>Cluster local domain name.</para>
        /// <para>Naming rules: The domain name consists of one or more parts separated by periods (.). Each part can be up to 63 characters long and can contain lowercase letters, digits, and hyphens (-). Each part must start and end with a lowercase letter or digit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster.local</para>
        /// </summary>
        [NameInMap("cluster_domain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// <para>After selecting <c>cluster_type</c> as <c>ManagedKubernetes</c> and configuring <c>profile</c>, you can further specify the cluster specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ack.standard</c>: Basic edition (selected by default when the value is empty)</description></item>
        /// <item><description><c>ack.pro.small</c>: Pro edition</description></item>
        /// <item><description><c>ack.pro.xlarge</c>: Pro XL</description></item>
        /// <item><description><c>ack.pro.2xlarge</c>: Pro 2XL</description></item>
        /// <item><description><c>ack.pro.4xlarge</c>: Pro 4XL (requires contacting customer service to enable allowlisting)</description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are three tiers provided by &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>. They pre-allocate and fix control plane resources to ensure that API concurrency and Pod scheduling capabilities always remain at a determined high level, suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For the cluster management fees of Pro edition and provisioned control plane editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>.</para>
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
        /// <item><description><c>ManagedKubernetes</c>: ACK managed cluster types, including ACK managed cluster (Pro and Basic editions), ACK Serverless cluster (Pro and Basic editions), ACK Edge cluster (Pro and Basic editions), and ACK Lingjun cluster (Pro edition).</description></item>
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
        /// <para>Pod network CIDR block. Must be a valid private CIDR block, specifically the following CIDR blocks and their subnets: 10.0.0.0/8, 172.16-31.0.0/12-16, 192.168.0.0/16. Cannot overlap with the VPC or CIDR blocks used by existing Kubernetes clusters in the VPC. Cannot be modified after creation.</para>
        /// <para>For cluster network planning, see <a href="https://help.aliyun.com/document_detail/86500.html">ACK managed cluster network planning</a>.</para>
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
        /// <para>ACK dedicated cluster control plane configuration.</para>
        /// </summary>
        [NameInMap("control_plane_config")]
        [Validation(Required=false)]
        public CreateClusterRequestControlPlaneConfig ControlPlaneConfig { get; set; }
        public class CreateClusterRequestControlPlaneConfig : TeaModel {
            /// <summary>
            /// <para>Whether to enable auto-renewal for control plane nodes. Valid when the billing type is <c>PrePaid</c>.</para>
            /// <list type="bullet">
            /// <item><description>true: Enable auto-renewal.</description></item>
            /// <item><description>false: Disable auto-renewal.</description></item>
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
            /// <para>Auto-renewal duration for control plane nodes.</para>
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
            /// <para>Control plane node billing type.</para>
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
            /// <para>Whether to install CloudMonitor on nodes.</para>
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
            /// <item><description><para>static: Allows enhancing CPU affinity and exclusivity for Pods with certain resource characteristics on the node.</para>
            /// </description></item>
            /// <item><description><para>none: Enables the existing default CPU affinity scheme.</para>
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
            /// <para>OS image type.</para>
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
            /// <para>Key pair name. Mutually exclusive with login_password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>SSH login password. The password must be 8 to 30 characters in length and contain at least three of the following: uppercase letters, lowercase letters, digits, and special characters. Mutually exclusive with key_pair.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>[<b>This field is deprecated</b>] Node service port range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("node_port_range")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>Subscription duration for control plane nodes. Valid and required when the billing type is <c>PrePaid</c>.</para>
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
            /// <para>Subscription period unit for control plane nodes. Valid and required when the billing type is <c>PrePaid</c>.</para>
            /// <para>Valid value: <c>Month</c>. Currently, only month-based periods are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>[<b>This field is deprecated</b>] Control plane node runtime name. Valid value:</para>
            /// <para>containerd: Containerd runtime, supported by all cluster versions.</para>
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
            /// <para>Whether to enable classified protection security hardening.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable classified protection hardening.</para>
            /// </description></item>
            /// <item><description><para>false: Disable classified protection hardening.</para>
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
            /// <para>Whether to enable burst (performance burst) for the node system disk.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable.</para>
            /// </description></item>
            /// <item><description><para>false: Disable.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is only supported when <c>system_disk_category</c> is set to <c>cloud_auto</c>.</para>
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
            /// <item><description><c>cloud_efficiency</c>: Ultra disk.</description></item>
            /// <item><description><c>cloud_ssd</c>: SSD disk.</description></item>
            /// <item><description><c>cloud_essd</c>: ESSD disk.</description></item>
            /// <item><description><c>cloud_auto</c>: ESSD AutoPL disk.</description></item>
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry disk.</description></item>
            /// </list>
            /// <para>Default value: <c>cloud_ssd</c>. The default value may vary across availability zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>Node system disk performance level. Only takes effect for ESSD disks.</para>
            /// <para>The performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD disk</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>Pre-provisioned read/write IOPS for the node system disk.</para>
            /// <para>Valid values: 0 to min{50,000, 1000<em>capacity - baseline performance}. Baseline performance = min{1,800 + 50</em>capacity, 50000}.</para>
            /// <para>This parameter is only supported when <c>system_disk_category</c> is set to <c>cloud_auto</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>Node system disk size.</para>
            /// <para>Valid values: [40, 500\]. Unit: GiB.</para>
            /// <para>Default value: <c>120</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>Node automatic snapshot backup policy.</para>
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
            /// <para>Internal DNS configuration for the cluster, applicable to ACK managed clusters. The internal DNS is used by node-side system components such as kubelet and kube-proxy to access the API Server. When internal DNS access is not enabled, node-side system components will access via CLB IP.</para>
            /// </summary>
            [NameInMap("internal_dns_config")]
            [Validation(Required=false)]
            public CreateClusterRequestControlPlaneEndpointsConfigInternalDnsConfig InternalDnsConfig { get; set; }
            public class CreateClusterRequestControlPlaneEndpointsConfigInternalDnsConfig : TeaModel {
                /// <summary>
                /// <para>VPCs where the internal DNS record resolution takes effect.</para>
                /// </summary>
                [NameInMap("bind_vpcs")]
                [Validation(Required=false)]
                public List<string> BindVpcs { get; set; }

            }

        }

        /// <summary>
        /// <para>List of component names, specifying which control plane components\&quot; logs to collect.</para>
        /// <para>By default, logs are collected from kube-apiserver, kube-controller-manager, kube-scheduler, and cloud-controller-manager.</para>
        /// </summary>
        [NameInMap("controlplane_log_components")]
        [Validation(Required=false)]
        public List<string> ControlplaneLogComponents { get; set; }

        /// <summary>
        /// <para>Log Service project for control plane component logs. You can use an existing project for log storage or let the system automatically create a project. If you choose to auto-create a Log Service project, a project named <c>k8s-log-{ClusterID}</c> will be automatically created.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>cpu_policy</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>cpu_policy</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead.</para>
        /// <para>Node CPU management policy. The following two policies are supported when the cluster version is 1.12.6 or later:</para>
        /// <list type="bullet">
        /// <item><description><c>static</c>: Allows enhancing CPU affinity and exclusivity for Pods with certain resource characteristics on the node.</description></item>
        /// <item><description><c>none</c>: Enables the existing default CPU affinity scheme.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] Use the <c>extra_sans</c> parameter instead.</para>
        /// <para>Custom certificate SAN. Multiple IPs or domain names are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs.aliyun.com</para>
        /// </summary>
        [NameInMap("custom_san")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustomSan { get; set; }

        /// <summary>
        /// <para>Cluster deletion protection, which prevents accidental cluster deletion through the console or API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enable cluster deletion protection. The cluster cannot be deleted through the console or API.</description></item>
        /// <item><description><c>false</c>: Disable cluster deletion protection. The cluster can be deleted through the console or API.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] By default, no rollback is performed when cluster creation fails. You need to clean up the failed cluster yourself.</para>
        /// <para>Whether to roll back when cluster creation fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Roll back when cluster creation fails.</description></item>
        /// <item><description><c>false</c>: Do not roll back when cluster creation fails.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] Use the <c>rrsa_config</c> parameter instead.</para>
        /// <para>Whether to enable the RRSA feature.</para>
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
        /// <para>KMS key ID. This key is used to encrypt data disks. For more details, see <a href="https://help.aliyun.com/document_detail/28935.html">Key Management Service</a>.</para>
        /// <remarks>
        /// <para>This feature only takes effect in professional managed clusters (ACK Pro clusters).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0fe64791-55eb-4fc7-84c5-c6c7cdca****</para>
        /// </summary>
        [NameInMap("encryption_provider_key")]
        [Validation(Required=false)]
        public string EncryptionProviderKey { get; set; }

        /// <summary>
        /// <para>Whether to enable public access. Expose the API Server through an EIP to enable public access to the cluster.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enable public access.</description></item>
        /// <item><description><c>false</c>: Disable public access. When disabled, the cluster API Server cannot be accessed from the Internet.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] Selecting existing nodes when creating a cluster is no longer supported. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> API.</para>
        /// <para>Whether to mount data disks on instances when creating a cluster with existing instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Store containers and images on the data disk. Existing data on the data disk will be lost. Please back up your data.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Do not store containers and images on the data disk.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>Data disk mounting rules:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS instance already has data disks mounted and the file system of the last data disk is not initialized, the system will automatically format the data disk as ext4 to store /var/lib/docker and /var/lib/kubelet.</description></item>
        /// <item><description>If the ECS instance has no data disks mounted, no new data disk will be mounted.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>image_id</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>image_id</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Custom node image. The system image is used by default. When a custom image is selected, it replaces the default system image. See <a href="https://help.aliyun.com/document_detail/146647.html">Custom images</a>.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>image_type</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>image_type</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>OS distribution type. It is recommended to use this field to specify the node OS. Valid values:</para>
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
        /// <para>[<b>This field is deprecated</b>] Selecting existing nodes when creating a cluster is no longer supported. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> API.</para>
        /// <para>When creating a cluster with existing nodes, you need to specify a list of ECS instances. These instances will join the cluster as Worker nodes.</para>
        /// <remarks>
        /// <para>This field is required when creating a cluster with existing instances.</para>
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
        /// <para>Automatically create an enterprise security group. Takes effect when <c>security_group_id</c> is empty.</para>
        /// <remarks>
        /// <para>When using a basic security group, the total number of nodes and Terway Pods in the cluster cannot exceed 2000. Therefore, when creating a Terway network type cluster, it is recommended to use an enterprise security group.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Create and use an enterprise security group.</description></item>
        /// <item><description><c>false</c>: Use a basic security group.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] Selecting existing nodes when creating a cluster is no longer supported. To add existing nodes to a cluster, create a node pool first and call the <a href="https://help.aliyun.com/document_detail/2667920.html">AttachInstancesToNodePool</a> API.</para>
        /// <para>Whether to retain instance names when creating a cluster with existing instances.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Retain.</description></item>
        /// <item><description><c>false</c>: Do not retain. Names will be replaced using system rules.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>key_pair</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>key_pair</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Key pair name. Mutually exclusive with <c>login_password</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>security-key</para>
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        [Obsolete]
        public string KeyPair { get; set; }

        /// <summary>
        /// <para>Cluster version, consistent with the Kubernetes community baseline version. We recommend selecting the latest version. If not specified, the latest version is used by default.</para>
        /// <para>You can create clusters of the three most recent versions. You can query supported cluster versions through the <a href="https://help.aliyun.com/document_detail/2667899.html">DescribeKubernetesVersionMetadata</a> API.</para>
        /// <para>For Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Kubernetes version release overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>Specify the CLB instance ID for API Server access. When this parameter is specified, an API Server CLB will not be automatically created.</para>
        /// <remarks>
        /// <para>Ensure that the CLB instance has no other dependencies (such as listeners or backend servers). Shared and public-network CLB instances are not supported.</para>
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
        /// <para>[<b>This parameter is deprecated</b>] CLB is billed by usage. This parameter does not take effect.</para>
        /// <para>Load balancer specification. Valid values:</para>
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
        /// <para>[<b>This field is deprecated</b>] Enable Log Service for the cluster. Only takes effect for ACK Serverless clusters, and the value must be <c>SLS</c>.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>login_password</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>login_password</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>SSH login password. Mutually exclusive with <c>key_pair</c>. The password must be 8 to 30 characters in length and contain at least three of the following: uppercase letters, lowercase letters, digits, and special characters.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>auto_renew</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Whether to enable auto-renewal for Master nodes. Only takes effect when <c>master_instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enable auto-renewal.</description></item>
        /// <item><description><c>false</c>: Disable auto-renewal.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>auto_renew_period</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Master node auto-renewal period. Only takes effect when subscription billing type is selected, and is a required value.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>size</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Number of Master nodes. Valid values: <c>3</c> or <c>5</c>.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>instance_charge_type</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Master node billing type. Valid values:</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>instance_types</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Master node instance types. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>.</para>
        /// </summary>
        [NameInMap("master_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MasterInstanceTypes { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>unit</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Master node subscription duration. Valid and required when <c>master_instance_charge_type</c> is set to <c>PrePaid</c>.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>period_unit</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Master node billing period. Must be specified when the billing type is <c>PrePaid</c>.</para>
        /// <para>Valid value: <c>Month</c>. Currently, only month-based periods are supported.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>system_disk_category</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Master node system disk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cloud_efficiency</c>: Ultra disk.</description></item>
        /// <item><description><c>cloud_ssd</c>: SSD disk.</description></item>
        /// <item><description><c>cloud_essd</c>: ESSD disk.</description></item>
        /// </list>
        /// <para>Default value: <c>cloud_ssd</c>. The default value may vary across availability zones.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>system_disk_performance_level</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Cluster Master node system disk performance level. Only takes effect for ESSD disks. The performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD disk</a>.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>system_disk_size</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Master node system disk size. Valid values: [40, 500\]. Unit: GiB.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>system_disk_snapshot_policy_id</c> parameter under <c>control_plane_config</c> instead.</para>
        /// <para>Automatic snapshot policy ID for the Master node system disk.</para>
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
        /// <para>[<b>This field is deprecated</b>] Use the <c>vswitch_ids</c> parameter instead.</para>
        /// <para>List of Master node vSwitch IDs. The number of vSwitches ranges from [1, 3\]. To ensure high availability of the cluster, it is recommended to select 3 vSwitches distributed in different availability zones.</para>
        /// <para>The number of specified instance types must be consistent with <c>master_count</c> and correspond one-to-one with the elements in <c>master_vswitch_ids</c>.</para>
        /// </summary>
        [NameInMap("master_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MasterVswitchIds { get; set; }

        /// <summary>
        /// <para>Custom cluster name. Consists of digits, Chinese characters, English characters, or hyphens (-), with a length of 1 to 63 characters, and cannot start with a hyphen (-).</para>
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
        /// <para>[<b>This field is deprecated</b>] Use the <c>snat_entry</c> parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("nat_gateway")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? NatGateway { get; set; }

        /// <summary>
        /// <para>Number of node IPs, determined by specifying the network CIDR. Only takes effect for Flannel network type clusters.</para>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>node_name_mode</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead.</para>
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
        /// <para>Node service ports. Valid port range: [30000, 65535\].</para>
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
        /// <para>Node pool list.</para>
        /// </summary>
        [NameInMap("nodepools")]
        [Validation(Required=false)]
        public List<Nodepool> Nodepools { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>desired_size</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Number of Worker nodes. Range: [0, 100\].</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("num_of_nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public long? NumOfNodes { get; set; }

        /// <summary>
        /// <para>Cluster automatic O&amp;M policy.</para>
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
                /// <item><description>patch: Automatically upgrade to an available patch version of the current minor version. The new Kubernetes version will not contain breaking changes.</description></item>
                /// <item><description>stable: Automatically upgrade to the latest patch version of the second-newest minor version. The new Kubernetes version may involve API and feature changes, but its stability has been widely verified.</description></item>
                /// <item><description>rapid: Automatically upgrade to the latest patch version of the latest minor version to get new features from the Kubernetes community faster.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane node configuration, use the <c>image_type</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>image_type</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>OS platform type. Valid values:</para>
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
        /// <para>[<b>This field is deprecated</b>]</para>
        /// <para>Purchase duration. Subscription duration. Valid and required when charge_type is set to PrePaid.</para>
        /// <para>Valid values: {1, 2, 3, 6, 12, 24, 36, 48, 60}.</para>
        /// <para>Default value: 1.</para>
        /// <para>This field was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on CreateCluster API parameter behavior changes</a>.</para>
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
        /// <para>[<b>This field is deprecated</b>]</para>
        /// <para>Billing period. Must be specified when the billing type is PrePaid.</para>
        /// <para>Valid value: Month. Currently, only month-based periods are supported.</para>
        /// <para>This field was changed on October 15, 2024. For more information, see <a href="https://help.aliyun.com/document_detail/2849194.html">Announcement on CreateCluster API parameter behavior changes</a>.</para>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>platform</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>OS distribution. Valid values:</para>
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
        /// <para>[<b>This field is deprecated</b>] When using the Terway network plugin, you need to specify vSwitches for Pod IP allocation. Each Pod vSwitch corresponds to a Worker node vSwitch, and the availability zones of Pod vSwitches and Worker node vSwitches must be consistent.</para>
        /// <remarks>
        /// <para>The CIDR mask of Pod vSwitches should not exceed 19 and must not exceed 25; otherwise, the available Pod IP addresses in the cluster network will be very limited, affecting normal cluster usage.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("pod_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// <para>When <c>cluster_type</c> is set to <c>ManagedKubernetes</c>, you can further specify the cluster subtype.</para>
        /// <list type="bullet">
        /// <item><description><c>Default</c>: ACK managed cluster, including ACK cluster (Pro and Basic editions).</description></item>
        /// <item><description><c>Edge</c>: ACK Edge cluster, including ACK Edge cluster (Pro and Basic editions).</description></item>
        /// <item><description><c>Serverless</c>: ACK Serverless cluster, including ACK Serverless cluster (Pro and Basic editions).</description></item>
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
        /// <para>kube-proxy mode</para>
        /// <list type="bullet">
        /// <item><description><c>iptables</c>: A mature and stable kube-proxy mode. Kubernetes Service discovery and load balancing are configured using iptables rules. Performance is average and significantly affected by scale, suitable for clusters with a small number of Services.</description></item>
        /// <item><description><c>ipvs</c>: A high-performance kube-proxy mode. Kubernetes Service discovery and load balancing are configured using the Linux IPVS module, suitable for clusters with a large number of Services that require high-performance load balancing.</description></item>
        /// <item><description><c>nftables</c>: Next-generation kube-proxy mode based on Linux nftables for Service discovery and load balancing. It is a modern replacement for iptables. Compared to iptables, nftables performs better in network performance, rule update efficiency, and large-scale Service scenarios.<br>Only supported for clusters of version 1.35 and above. The Kubernetes community deprecated IPVS starting from version 1.35. It is recommended to use nftables for new clusters for longer-term community support.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>rds_instances</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>List of RDS instances. Select the RDS instances you want to add to the whitelist. It is recommended to add the container Pod CIDR block and Node CIDR block in RDS. Setting RDS instances may fail to pop up due to non-running instance status.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// <para>The region ID where the cluster is located. For details, see <a href="https://help.aliyun.com/document_detail/216938.html">Regions supported by Container Service</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID to which the cluster belongs, used for isolating different resources.</para>
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
            /// <para>Whether to enable the RRSA feature.</para>
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
        /// <para>Container runtime in the cluster. Supports containerd, sandboxed containers, and Docker.</para>
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
        /// <para>Specify the security group ID when creating a cluster with an existing security group. Mutually exclusive with <c>is_enterprise_security_group</c>. Cluster nodes are automatically added to this security group.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane configuration, use the <c>security_hardening_os</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>security_hardening_os</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
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
        [Obsolete]
        public bool? SecurityHardeningOs { get; set; }

        /// <summary>
        /// <para>ServiceAccount is the access credential for communication between Pods and the cluster API Server. <c>service-account-issuer</c> is the issuer identity in the <c>serviceaccount token</c>, i.e., the <c>iss</c> field in the <c>token payload</c>.</para>
        /// <para>For more details about <c>ServiceAccount</c>, see <a href="https://help.aliyun.com/document_detail/160384.html">Deploy service account token volume projection</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes.default.svc</para>
        /// </summary>
        [NameInMap("service_account_issuer")]
        [Validation(Required=false)]
        public string ServiceAccountIssuer { get; set; }

        /// <summary>
        /// <para>Service network CIDR block. Valid ranges: 10.0.0.0/16-24, 172.16-31.0.0/16-24, 192.168.0.0/16-24. Cannot overlap with VPC CIDR block 10.1.0.0/21 or CIDR blocks used by existing Kubernetes clusters in the VPC. Cannot be modified after creation.</para>
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
        /// <para>[<b>This field is deprecated</b>] Service discovery type within the cluster, used to specify the service discovery method in <c>ACK Serverless</c> clusters.</para>
        /// <list type="bullet">
        /// <item><description><c>CoreDNS</c>: Uses the Kubernetes native standard service discovery component CoreDNS. A set of containers needs to be deployed in the cluster for DNS resolution. By default, two ECI instances with 0.25 Core 512 MiB specifications are used.</description></item>
        /// <item><description><c>PrivateZone</c>: Uses the Alibaba Cloud PrivateZone product for service discovery capabilities. The PrivateZone service needs to be enabled.</description></item>
        /// </list>
        /// <para>Default value: Not enabled.</para>
        /// </summary>
        [NameInMap("service_discovery_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> ServiceDiscoveryTypes { get; set; }

        /// <summary>
        /// <para>Configure SNAT for the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Automatically create a NAT gateway and configure SNAT rules. Set to <c>true</c> if nodes and applications in the cluster need to access the Internet.</description></item>
        /// <item><description><c>false</c>: Do not create a NAT gateway or SNAT rules. Nodes and applications in the cluster will not be able to access the Internet.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If not enabled during cluster creation and the business later requires Internet access, you can <a href="https://help.aliyun.com/document_detail/178480.html">manually enable it</a>.</para>
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
        /// <para>[<b>This field is deprecated</b>] For cluster control plane node configuration, use the <c>soc_enabled</c> parameter under <c>control_plane_config</c> instead. For node pool configuration, use the <c>soc_enabled</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Classified protection hardening. For more information, see <a href="https://help.aliyun.com/document_detail/196148.html">ACK classified protection hardening user guide</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enable classified protection hardening.</description></item>
        /// <item><description><c>false</c>: Disable classified protection hardening.</description></item>
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
        /// <para>Whether to enable public SSH login. Used for logging in to Master nodes of ACK dedicated clusters. This parameter does not take effect in managed clusters.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enable.</description></item>
        /// <item><description><c>false</c>: Disable.</description></item>
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
        /// <para>Node tags. Tag definition rules:</para>
        /// <list type="bullet">
        /// <item><description>Tags consist of case-sensitive key-value pairs. You can set up to 20 tags.</description></item>
        /// <item><description>Tag keys cannot be duplicated, with a maximum length of 64 characters; tag values can be empty, with a maximum length of 128 characters. Neither tag keys nor tag values can start with “aliyun”, “acs:”, “https://”, or “http://”. For details, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>taints</c> parameter under <c>kubernetes_config</c> in <c>nodepool</c> instead.</para>
        /// <para>Node taint information. Taints and tolerations work together to prevent Pods from being scheduled on inappropriate nodes. For more information, see <a href="https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/">taint-and-toleration</a>.</para>
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        [Obsolete]
        public List<Taint> Taints { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[<b>This field is deprecated</b>] By default, no rollback is performed when cluster creation fails. You need to clean up the failed cluster yourself.</para>
        /// <para>Cluster creation timeout. Unit: minutes.</para>
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
        /// <para>The timezone used by the cluster. See <a href="https://help.aliyun.com/document_detail/354879.html">Supported timezones</a>.</para>
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
        /// <para>[<b>This field is deprecated</b>] Custom node data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFD****</para>
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        [Obsolete]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The VPC used by the cluster. Must be provided when creating a cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zeik9h3ahvv2zz95****</para>
        /// </summary>
        [NameInMap("vpcid")]
        [Validation(Required=false)]
        public string Vpcid { get; set; }

        /// <summary>
        /// <para>vSwitches for cluster nodes. This field is required when creating a zero-node managed cluster.</para>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>auto_renew</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Whether to enable auto-renewal for Worker nodes. Only takes effect when <c>worker_instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enable auto-renewal.</description></item>
        /// <item><description><c>false</c>: Disable auto-renewal.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>auto_renew_period</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Worker node auto-renewal period. Only takes effect when subscription billing type is selected, and is a required value.</para>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>data_disks</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Combination of Worker node data disk type, size, and other configurations.</para>
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
            /// <item><description><c>true</c>: Encrypt the data disk.</description></item>
            /// <item><description><c>false</c>: Do not encrypt the data disk.</description></item>
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
            /// <para>Node data disk performance level. Only takes effect for <a href="https://help.aliyun.com/document_detail/122389.html">ESSD disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("performance_level")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>Data disk size. Valid values: 40 to 32767. Unit: GiB.</para>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>instance_charge_type</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Worker node billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PrePaid</c>: Subscription.</description></item>
        /// <item><description><c>PostPaid</c>: Pay-as-you-go.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>instance_types</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Worker node instance configuration.</para>
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>period</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Worker node subscription duration. Valid and required when <c>worker_instance_charge_type</c> is set to <c>PrePaid</c>.</para>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>period_unit</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Worker node billing period. Must be specified when the billing type is <c>PrePaid</c>.</para>
        /// <para>Valid value: <c>Month</c>. Currently, only month-based periods are supported.</para>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>system_disk_category</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Worker node system disk type. For more information, see <a href="https://help.aliyun.com/document_detail/63136.html">Block storage overview</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cloud_efficiency</c>: Ultra disk.</description></item>
        /// <item><description><c>cloud_ssd</c>: SSD disk.</description></item>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>system_disk_performance_level</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>When the system disk is an ESSD disk, you can set the Performance Level (PL) of the ESSD disk. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD disk</a>.</para>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>system_disk_size</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Worker node system disk size. Unit: GiB.</para>
        /// <para>Valid values: [40, 500\].</para>
        /// <para>The value must be greater than or equal to max{40, ImageSize}.</para>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>system_disk_snapshot_policy_id</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>Automatic snapshot policy ID for the Worker node system disk.</para>
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
        /// <para>[<b>This field is deprecated</b>] For node pool configuration, use the <c>vswitch_ids</c> parameter under <c>scaling_group</c> in <c>nodepool</c> instead.</para>
        /// <para>List of vSwitches used by cluster nodes. One node corresponds to one value.</para>
        /// <para>When creating a zero-node managed cluster, the <c>worker_vswitch_ids</c> field is not required, but <c>vswitch_ids</c> must be provided.</para>
        /// </summary>
        [NameInMap("worker_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerVswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[<b>This field is deprecated</b>] Use the <c>zone_ids</c> parameter instead.</para>
        /// <para>Availability zone ID of the region where the cluster is located. This parameter is specific to ACK managed cluster types.</para>
        /// <para>When creating an ACK managed cluster, if <c>vpc_id</c> and <c>vswitch_ids</c> are not specified, <c>zone_id</c> must be specified for the cluster to automatically create VPC network resources in this availability zone. This parameter is ignored when <c>vpc_id</c> and <c>vswitch_ids</c> are specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beiji****</para>
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>Multiple availability zone IDs of the region where the cluster is located. This parameter is specific to ACK managed cluster types.</para>
        /// </summary>
        [NameInMap("zone_ids")]
        [Validation(Required=false)]
        public List<string> ZoneIds { get; set; }

    }

}
