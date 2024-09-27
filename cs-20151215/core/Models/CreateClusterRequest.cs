// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>The network access control list (ACL) of the SLB instance associated with the API server if the cluster is a registered cluster.</para>
        /// </summary>
        [NameInMap("access_control_list")]
        [Validation(Required=false)]
        public List<string> AccessControlList { get; set; }

        /// <summary>
        /// <para>The components that you want to install in the cluster. When you create a cluster, you can configure the <c>addons</c> parameter to specify the components that you want to install.</para>
        /// <para><b>Network plug-in</b>: required. The Flannel and Terway plug-ins are supported. Select one of the plug-ins for the cluster.</para>
        /// <list type="bullet">
        /// <item><description>If you want to use the Terway component, specify the network plug-in in the [{&quot;name&quot;:&quot;flannel&quot;,&quot;config&quot;:&quot;&quot;}] format.</description></item>
        /// <item><description>If you want to use the Terway component, specify the value network plug-in in the [{&quot;Name&quot;: &quot;terway-eniip&quot;,&quot;Config&quot;: &quot;&quot;}] format.</description></item>
        /// </list>
        /// <para><b>Volume plug-in</b>: optional. Only the <c>Container Storage Interface (CSI)</c> plug-in is supported.</para>
        /// <para>Specify the <c>CSI</c> plug-in in the following format: [{&quot;name&quot;:&quot;csi-plugin&quot;,&quot;config&quot;: &quot;&quot;},{&quot;name&quot;: &quot;csi-provisioner&quot;,&quot;config&quot;: &quot;&quot;}].</para>
        /// <para><b>Simple Log Service component</b>: optional. We recommend that you enable Simple Log Service. If Simple Log Service is disabled, you cannot use the cluster auditing feature.</para>
        /// <list type="bullet">
        /// <item><description>Specify an existing <c>Simple Log Service project</c> in the following format: [{&quot;name&quot;: &quot;logtail-ds&quot;,&quot;config&quot;: &quot;{&quot;IngressDashboardEnabled&quot;:&quot;true&quot;,&quot;sls_project_name&quot;:&quot;your_sls_project_name&quot;}&quot;}].</description></item>
        /// <item><description>To create a <c>Simple Log Service project</c>, specify the component in the following format: [{&quot;name&quot;: &quot;logtail-ds&quot;,&quot;config&quot;: &quot;{&quot;IngressDashboardEnabled&quot;:&quot;true&quot;}&quot;}].</description></item>
        /// </list>
        /// <para><b>Ingress controller</b>: optional. By default, the <c>nginx-ingress-controller</c> component is installed in ACK dedicated clusters.</para>
        /// <list type="bullet">
        /// <item><description>To install nginx-ingress-controller and enable Internet access, specify the Ingress controller in the following format: [{&quot;name&quot;:&quot;nginx-ingress-controller&quot;,&quot;config&quot;:&quot;{&quot;IngressSlbNetworkType&quot;:&quot;internet&quot;}&quot;}].</description></item>
        /// <item><description>To disable the automatic installation of nginx-ingress-controller, specify the Ingress controller in the following format: [{&quot;name&quot;: &quot;nginx-ingress-controller&quot;,&quot;config&quot;: &quot;&quot;,&quot;disabled&quot;: true}].</description></item>
        /// </list>
        /// <para><b>Event center</b>: optional. By default, the event center feature is enabled.</para>
        /// <para>You can use ACK event centers to store and query events and configure alerts. You can use the Logstores that are associated with ACK event centers free of charge within 90 days. For more information, see <a href="https://help.aliyun.com/document_detail/150476.html">Create and use an event center</a>.</para>
        /// <para>To enable the event center feature, specify the event center component in the following format: [{&quot;name&quot;:&quot;ack-node-problem-detector&quot;,&quot;config&quot;:&quot;{&quot;sls_project_name&quot;:&quot;your_sls_project_name&quot;}&quot;}].</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<Addon> Addons { get; set; }

        /// <summary>
        /// <para>Service accounts provide identities for pods when pods communicate with the <c>API server</c> of the cluster. The <c>api-audiences</c> parameter validates <c>tokens</c> and is used by the <c>API server</c> to check whether the <c>tokens</c> of requests are valid. Separate multiple values with commas (,).``</para>
        /// <para>For more information about <c>service accounts</c>, see <a href="https://help.aliyun.com/document_detail/160384.html">Enable service account token volume projection</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes.default.svc</para>
        /// </summary>
        [NameInMap("api_audiences")]
        [Validation(Required=false)]
        public string ApiAudiences { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal, which takes effect only when the <c>charge_type</c> value is set to <c>PrePaid</c>. </para>
        /// <para>Possible values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enable auto-renewal. </description></item>
        /// <item><description><c>false</c>: Do not auto-renew.</description></item>
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
        /// <para>Renewal period, which takes effect only when Prepaid and Auto-Renewal are selected. When <c>PeriodUnit=Month</c>, the value range is {1, 2, 3, 6, 12}.
        /// Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("auto_renew_period")]
        [Validation(Required=false)]
        public long? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The billing method of the cluster. The following resources are billed on a subscription basis:</para>
        /// <para>ECS instances in node pools.</para>
        /// <para>The internal-facing SLB instance associated with the API server.</para>
        /// <para>Valid values:</para>
        /// <para>PrePaid: subscription.</para>
        /// <para>PostPaid: pay-as-you-go.</para>
        /// <para>Default value: PostPaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("charge_type")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use security_hardening_os instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("cis_enabled")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? CisEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to install the CloudMonitor agent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: installs the CloudMonitor agent.</description></item>
        /// <item><description><c>false</c>: does not install the CloudMonitor agent.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        public bool? CloudMonitorFlags { get; set; }

        /// <summary>
        /// <para>The domain name of the cluster.</para>
        /// <para>The domain name can contain one or more parts that are separated by periods (.). Each part cannot exceed 63 characters in length, and can contain lowercase letters, digits, and hyphens (-). Each part must start and end with a lowercase letter or digit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster.local</para>
        /// </summary>
        [NameInMap("cluster_domain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// <para>After you set <c>cluster_type</c> to <c>ManagedKubernetes</c> and configure the <c>profile</c> parameter, you can further specify the cluster edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ack.pro.small</c>: Pro Edition.</description></item>
        /// <item><description><c>ack.standard</c>: Basic Edition. If you leave the parameter empty, an ACK Basic cluster is created.</description></item>
        /// </list>
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
        /// <item><description><c>ManagedKubernetes</c>: ACK managed cluster. ACK managed clusters include ACK Basic clusters, ACK Pro clusters, ACK Serverless clusters (Basic Edition and Pro Edition), ACK Edge clusters (Basic Edition and Pro Edition), and ACK Lingjun clusters (Pro Edition).</description></item>
        /// <item><description><c>ExternalKubernetes</c>: registered cluster.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The pod CIDR block. You can specify 10.0.0.0/8, 172.16-31.0.0/12-16, 192.168.0.0/16, or their subnets as the pod CIDR block. The pod CIDR block cannot overlap with the CIDR block of the VPC in which the cluster is deployed and the CIDR blocks of existing clusters in the VPC. You cannot modify the pod CIDR block after you create the cluster.</para>
        /// <para>For more information about how to plan the network of an ACK cluster, see <a href="https://help.aliyun.com/document_detail/86500.html">Plan the network of an ACK cluster</a>.</para>
        /// <remarks>
        /// <para> This parameter is required if the cluster uses the Flannel plug-in.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.0.0/16</para>
        /// </summary>
        [NameInMap("container_cidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        /// <summary>
        /// <para>The list of control plane components for which you want to enable log collection.</para>
        /// <para>By default, the logs of kube-apiserver, kube-controller-manager, and kube-scheduler are collected.</para>
        /// </summary>
        [NameInMap("controlplane_log_components")]
        [Validation(Required=false)]
        public List<string> ControlplaneLogComponents { get; set; }

        /// <summary>
        /// <para>The Simple Log Service project that is used to store the logs of control plane components. You can use an existing project or create one. If you choose to create a Simple Log Service project, the created project is named in the <c>k8s-log-{ClusterID}</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-log-xxx</para>
        /// </summary>
        [NameInMap("controlplane_log_project")]
        [Validation(Required=false)]
        public string ControlplaneLogProject { get; set; }

        /// <summary>
        /// <para>The retention period of control plane logs in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("controlplane_log_ttl")]
        [Validation(Required=false)]
        public string ControlplaneLogTtl { get; set; }

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
        /// <para>The custom subject alternative names (SANs) for the API server certificate to accept requests from specified IP addresses or domain names. Separate multiple IP addresses and domain names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs.aliyun.com</para>
        /// </summary>
        [NameInMap("custom_san")]
        [Validation(Required=false)]
        public string CustomSan { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cluster deletion protection. If this option is enabled, the cluster cannot be deleted in the ACK console or by calling API operations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables deletion protection for the cluster. This way, the cluster cannot be deleted in the ACK console or by calling API operations.</description></item>
        /// <item><description><c>false</c>: disables deletion protection for the cluster. This way, the cluster can be deleted in the ACK console or by calling API operations.</description></item>
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
        /// <para>Specifies whether to perform a rollback when the cluster fails to be created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: performs a rollback when the cluster fails to be created.</description></item>
        /// <item><description><c>false</c>: does not perform a rollback when the cluster fails to be created.</description></item>
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

        /// <summary>
        /// <para>Specifies whether to enable the RAM Roles for Service Accounts (RRSA) feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable_rrsa")]
        [Validation(Required=false)]
        public bool? EnableRrsa { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key that is used to encrypt the system disk. For more information, see <a href="https://help.aliyun.com/document_detail/28935.html">What is KMS?</a></para>
        /// <remarks>
        /// <para> The key can be used only in ACK Pro clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0fe64791-55eb-4fc7-84c5-c6c7cdca****</para>
        /// </summary>
        [NameInMap("encryption_provider_key")]
        [Validation(Required=false)]
        public string EncryptionProviderKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Internet access for the cluster. You can use an elastic IP address (EIP) to expose the API server. This way, you can access the cluster over the Internet. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables Internet access for the cluster.</description></item>
        /// <item><description><c>false</c>: disables Internet access for the cluster. If you set the value to false, the API server cannot be accessed over the Internet.</description></item>
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
        /// <para>Specifies whether to mount a data disk to a node that is created based on an existing ECS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: stores the data of containers and images on a data disk. The existing data stored on the data disk is lost. Back up the existing data first.</description></item>
        /// <item><description><c>false</c>: does not store the data of containers and images on a data disk.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>How data disks are mounted:</para>
        /// <list type="bullet">
        /// <item><description>If an ECS instance has data disks mounted and the file system of the last data disk is not initialized, the system automatically formats the data disk to ext4. Then, the system mounts the data disk to /var/lib/docker and /var/lib/kubelet.</description></item>
        /// <item><description>If no data disk is mounted to the ECS instance, the system does not purchase a new data disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// <para>The custom image. By default, the image provided by ACK is used. You can select a custom image to replace the default image. For more information, see <a href="https://help.aliyun.com/document_detail/146647.html">Use a custom image to create an ACK cluster</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp16z7xko3vvv8gt****</para>
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The type of OS distribution that you want to use. To specify the node OS, we recommend that you use this parameter. Valid values:</para>
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
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The existing ECS instances that are specified as worker nodes for the cluster.</para>
        /// <remarks>
        /// <para> This parameter is required if you create worker nodes on existing ECS instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>The IP stack of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Optional value: ipv4 (Single stack) or ipv6 (Dual Stack)
        /// Default value: IPV4</para>
        /// </summary>
        [NameInMap("ip_stack")]
        [Validation(Required=false)]
        public string IpStack { get; set; }

        /// <summary>
        /// <para>Specifies whether to create an advanced security group. This parameter takes effect only if <c>security_group_id</c> is not specified.</para>
        /// <remarks>
        /// <para> To use a basic security group, make sure that the sum of the number of nodes in the cluster and the number of pods that use Terway does not exceed 2,000. Therefore, we recommend that you specify an advanced security group for a cluster that uses Terway.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><c>true</c>: creates an advanced security group.</description></item>
        /// <item><description><c>false</c>: does not create an advanced security group.</description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("is_enterprise_security_group")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the names of existing ECS instances that are used in the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: retains the names.</description></item>
        /// <item><description><c>false</c>: does not retain the names. The system assigns new names.</description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        /// <summary>
        /// <para>The name of the key pair. You must specify this parameter or the <c>login_password</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secrity-key</para>
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// <para>The Kubernetes version of the cluster. The Kubernetes versions supported by ACK are the same as the Kubernetes versions supported by open source Kubernetes. We recommend that you specify the latest Kubernetes version. If you do not specify this parameter, the latest Kubernetes version is used.</para>
        /// <para>You can create clusters of the latest two Kubernetes versions in the ACK console. If you want to create clusters that run earlier Kubernetes versions, use the ACK API. For more information about the Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Support for Kubernetes versions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.16.9-aliyun.1</para>
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>Specifies the CLB instance ID for accessing the APIServer. When this parameter is set, an APIServer CLB will no longer be automatically created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-wz9t256gqa3vbouk****</para>
        /// </summary>
        [NameInMap("load_balancer_id")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The specification of the Server Load Balancer (SLB) instance. Valid values:</para>
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
        public string LoadBalancerSpec { get; set; }

        /// <summary>
        /// <para>Enables Simple Log Service for the cluster. This parameter takes effect only for ACK Serverless clusters. Valid value: <c>SLS</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("logging_type")]
        [Validation(Required=false)]
        public string LoggingType { get; set; }

        /// <summary>
        /// <para>The password for SSH logon. You must specify this parameter or <c>key_pair</c>. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello@1234</para>
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for master nodes. This parameter takes effect only when <c>master_instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables auto-renewal.</description></item>
        /// <item><description><c>false</c>: disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("master_auto_renew")]
        [Validation(Required=false)]
        public bool? MasterAutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. This parameter takes effect and is required only when the subscription billing method is selected for master nodes.</para>
        /// <para>Valid values: 1, 2, 3, 6, and 12.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("master_auto_renew_period")]
        [Validation(Required=false)]
        public long? MasterAutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The number of master nodes. Valid values: <c>3</c> and <c>5</c>.</para>
        /// <para>Default value: <c>3</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("master_count")]
        [Validation(Required=false)]
        public long? MasterCount { get; set; }

        /// <summary>
        /// <para>The billing method of master nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PrePaid</c>: subscription.</description></item>
        /// <item><description><c>PostPaid</c>: the pay-as-you-go.</description></item>
        /// </list>
        /// <para>Default value: <c>PostPaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("master_instance_charge_type")]
        [Validation(Required=false)]
        public string MasterInstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance types of master nodes. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</para>
        /// </summary>
        [NameInMap("master_instance_types")]
        [Validation(Required=false)]
        public List<string> MasterInstanceTypes { get; set; }

        /// <summary>
        /// <para>The subscription duration of master nodes. This parameter takes effect and is required only when <c>master_instance_charge_type</c> is set to <c>PrePaid</c>.</para>
        /// <para>Valid values: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("master_period")]
        [Validation(Required=false)]
        public long? MasterPeriod { get; set; }

        /// <summary>
        /// <para>The billing cycle of the master nodes in the cluster. This parameter is required if master_instance_charge_type is set to <c>PrePaid</c>.</para>
        /// <para>Valid value: <c>Month</c>, which indicates that master nodes are billed only on a monthly basis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("master_period_unit")]
        [Validation(Required=false)]
        public string MasterPeriodUnit { get; set; }

        /// <summary>
        /// <para>The system disk type of master nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cloud_efficiency</c>: ultra disk.</description></item>
        /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
        /// <item><description><c>cloud_essd</c>: Enterprise SSD (ESSD).</description></item>
        /// </list>
        /// <para>Default value: <c>cloud_ssd</c>. The default value may vary in different zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("master_system_disk_category")]
        [Validation(Required=false)]
        public string MasterSystemDiskCategory { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the system disk that you want to use for master nodes. This parameter takes effect only for ESSDs. For more information about the relationship between disk PLs and disk sizes, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("master_system_disk_performance_level")]
        [Validation(Required=false)]
        public string MasterSystemDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The system disk size of master nodes. Valid values: 40 to 500. Unit: GiB.</para>
        /// <para>Default value: <c>120</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("master_system_disk_size")]
        [Validation(Required=false)]
        public long? MasterSystemDiskSize { get; set; }

        /// <summary>
        /// <para>The ID of the automatic snapshot policy that is used by the system disk specified for master nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-2zej1nogjvovnz4z****</para>
        /// </summary>
        [NameInMap("master_system_disk_snapshot_policy_id")]
        [Validation(Required=false)]
        public string MasterSystemDiskSnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches that are specified for master nodes. You can specify up to three vSwitches. We recommend that you specify three vSwitches in different zones to ensure high availability.</para>
        /// <para>The number of vSwitches must be the same as the value of the <c>master_count</c> parameter and also the same as the number of vSwitches specified in the <c>master_vswitch_ids</c> parameter.</para>
        /// </summary>
        [NameInMap("master_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> MasterVswitchIds { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// <para>The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). The name cannot start with a hyphen (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a NAT gateway and configure SNAT rules if you create an ACK Serverless cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: automatically creates a NAT gateway and configures SNAT rules. This enables Internet access for the VPC in which the cluster is deployed.</description></item>
        /// <item><description><c>false</c>: does not create a NAT gateway or configure SNAT rules. If you specify this value, the cluster in the VPC cannot access the Internet.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("nat_gateway")]
        [Validation(Required=false)]
        public bool? NatGateway { get; set; }

        /// <summary>
        /// <para>The maximum number of IP addresses that can be assigned to each node. This number is determined by the subnet mask of the specified CIDR block. This parameter takes effect only if the cluster uses the Flannel plug-in.</para>
        /// <para>Default value: <c>26</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("node_cidr_mask")]
        [Validation(Required=false)]
        public string NodeCidrMask { get; set; }

        /// <summary>
        /// <para>The custom node name.</para>
        /// <para>A custom node name consists of a prefix, a node IP address, and a suffix.</para>
        /// <list type="bullet">
        /// <item><description>The prefix and suffix can contain multiple parts that are separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-), and must start and end with a lowercase letter or digit.</description></item>
        /// <item><description>The IP substring length specifies the number of digits to be truncated from the end of the node IP address. The IP substring length ranges from 5 to 12.</description></item>
        /// </list>
        /// <para>For example, if the node IP address is 192.168.0.55, the prefix is aliyun.com, the IP substring length is 5, and the suffix is test, the node name will aliyun.com00055test.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun.com00055test</para>
        /// </summary>
        [NameInMap("node_name_mode")]
        [Validation(Required=false)]
        public string NodeNameMode { get; set; }

        /// <summary>
        /// <para>The node port range. Valid values: 30000 to 65535.</para>
        /// <para>Default value: <c>30000-32767</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000~32767</para>
        /// </summary>
        [NameInMap("node_port_range")]
        [Validation(Required=false)]
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
        /// <para>The type of OS. Valid values:</para>
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
        public string OsType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance. This parameter takes effect and is required only when you set charge_type to PrePaid.</para>
        /// <para>Valid values: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FY2023</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The billing cycle. This parameter is required if charge_type is set to PrePaid.</para>
        /// <para>Set the value to Month. Subscription clusters are billed only on a monthly basis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("period_unit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The OS distribution that is used. Valid values:</para>
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
        public string Platform { get; set; }

        /// <summary>
        /// <para>If you select Terway as the network plug-in, you must allocate vSwitches to pods. For each vSwitch that allocates IP addresses to worker nodes, you must select a vSwitch in the same zone to allocate IP addresses to pods.</para>
        /// <remarks>
        /// <para> We recommend that you select pod vSwitches whose subnet masks that do not exceed 19 bits in length. The maximum subnet mask length of a pod vSwitch is 25 bits. If you select a pod vSwitch whose subnet mask exceeds 25 bits in length, the IP addresses that can be allocated to pods may be insufficient.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("pod_vswitch_ids")]
        [Validation(Required=false)]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// <para>If you set <c>cluster_type</c> to <c>ManagedKubernetes</c>, an ACK managed cluster is created. In this case, you can further specify the cluster edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Default</c>: ACK managed cluster. ACK managed clusters include ACK Basic clusters and ACK Pro clusters.</description></item>
        /// <item><description><c>Edge</c>: ACK Edge cluster. ACK Edge clusters include ACK Edge Basic clusters and ACK Edge Pro clusters.</description></item>
        /// <item><description><c>Serverless</c>: ACK Serverless cluster. ACK Serverless clusters include ACK Serverless Basic clusters and ACK Serverless Pro clusters.</description></item>
        /// <item><description><c>Lingjun</c>: ACK Lingjun Pro cluster.</description></item>
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
        /// <item><description><c>iptables</c>: a mature and stable mode that uses iptables rules to conduct service discovery and load balancing. The performance of this mode is limited by the size of the cluster. This mode is suitable for clusters that run a small number of Services.</description></item>
        /// <item><description><c>ipvs</c>: a mode that provides high performance and uses IP Virtual Server (IPVS) to conduct service discovery and load balancing. This mode is suitable for clusters that run a large number of Services. We recommend that you use this mode in scenarios that require high-performance load balancing.</description></item>
        /// </list>
        /// <para>Default value: <c>ipvs</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipvs</para>
        /// </summary>
        [NameInMap("proxy_mode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// <para>The ApsaraDB RDS instances. The pod CIDR block and node CIDR block are added to the whitelists of the ApsaraDB RDS instances. We recommend that you add the pod CIDR block and node CIDR block to the whitelists of the ApsaraDB RDS instances in the ApsaraDB RDS console. If the RDS instances are not in the Running state, new nodes cannot be added to the cluster.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the cluster is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the cluster belongs. You can use resource groups to isolate clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3mkrure****</para>
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The container runtime. The default container runtime is Docker. containerd and Sandboxed-Container are also supported.</para>
        /// <para>For more information about how to select a proper container runtime, see <a href="https://help.aliyun.com/document_detail/160313.html">Comparison among Docker, containerd, and Sandboxed-Container</a>.</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// <para>The ID of an existing security group. You must specify this parameter or the <c>is_enterprise_security_group</c> parameter. Cluster nodes are automatically added to the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1bdue0qc1g7k****</para>
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Alibaba Cloud Linux Security Hardening. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables Alibaba Cloud Linux Security Hardening.</description></item>
        /// <item><description><c>false</c>: disables Alibaba Cloud Linux Security Hardening.</description></item>
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
        /// <para>Service accounts provide identities for pods when pods communicate with the <c>API server</c> of the cluster. The <c>service-account-issuer</c> parameter specifies the issuer of the <c>service account token</c>, which is specified by using the <c>iss</c> field in the <c>token payload</c>.</para>
        /// <para>For more information about <c>service accounts</c>, see <a href="https://help.aliyun.com/document_detail/160384.html">Enable service account token volume projection</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes.default.svc</para>
        /// </summary>
        [NameInMap("service_account_issuer")]
        [Validation(Required=false)]
        public string ServiceAccountIssuer { get; set; }

        /// <summary>
        /// <para>The Service CIDR block. Valid values: 10.0.0.0/16-24, 172.16-31.0.0/16-24, and 192.168.0.0/16-24. The Service CIDR block cannot overlap with the VPC CIDR block (10.1.0.0/21) or the CIDR blocks of existing clusters in the VPC. You cannot modify the Service CIDR block after the cluster is created.</para>
        /// <para>By default, the Service CIDR block is set to 172.19.0.0/20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.21.0.0/20</para>
        /// </summary>
        [NameInMap("service_cidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// <para>The type of service discovery that is implemented in the <c>ACK Serverless</c> cluster.</para>
        /// <list type="bullet">
        /// <item><description><c>CoreDNS</c>: a standard service discovery plug-in provided by open source Kubernetes. To use DNS resolution, you must provision pods. By default, two elastic container instances are used. The specification of each instance is 0.25 vCPUs and 512 MiB of memory.</description></item>
        /// <item><description><c>PrivateZone</c>: a DNS resolution service provided by Alibaba Cloud. You must activate Alibaba Cloud DNS PrivateZone before you can use it to implement service discovery.</description></item>
        /// </list>
        /// <para>By default, this parameter is not specified.</para>
        /// </summary>
        [NameInMap("service_discovery_types")]
        [Validation(Required=false)]
        public List<string> ServiceDiscoveryTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to configure SNAT rules for the VPC in which your cluster is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: automatically creates a NAT gateway and configures SNAT rules. Set the value to <c>true</c> if nodes and applications in the cluster need to access the Internet.</description></item>
        /// <item><description><c>false</c>: does not create a NAT gateway or configure SNAT rules. In this case, nodes and applications in the cluster cannot access the Internet.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If this feature is disabled when you create the cluster, you can also manually enable this feature after you create the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/178480.html">Enable an existing ACK cluster to access the Internet</a>.</para>
        /// </remarks>
        /// <para>Default value: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("snat_entry")]
        [Validation(Required=false)]
        public bool? SnatEntry { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable security hardening based on Multi-Level Protection Scheme (MLPS). For more information, see <a href="https://help.aliyun.com/document_detail/196148.html">ACK security hardening based on MLPS</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables security hardening based on MLPS.</description></item>
        /// <item><description><c>false</c>: disables security hardening based on MLPS.</description></item>
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
        /// <para>Specifies whether to enable SSH logon. If this parameter is set to true, you can log on to master nodes in an ACK dedicated cluster over the Internet. This parameter does not take effect for ACK managed clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables SSH logon.</description></item>
        /// <item><description><c>false</c>: disables SSH logon.</description></item>
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
        /// <para>The labels that you want to add to nodes. You must add labels based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>A label is a case-sensitive key-value pair. You can add up to 20 labels.</description></item>
        /// <item><description>When you add a label, you must specify a unique key but you can leave the value empty. A key cannot exceed 64 characters in length and a value cannot exceed 128 characters in length. Keys and values cannot start with aliyun, acs:, https://, or http://. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set">Labels and Selectors</a>.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>The taints that you want to add to nodes. Taints can be used together with tolerations to avoid scheduling pods to specific nodes. For more information, see <a href="https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/">taint-and-toleration</a>.</para>
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// <para>Specifies the timeout period of cluster creation. Unit: minutes.</para>
        /// <para>Default value: <c>60</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("timeout_mins")]
        [Validation(Required=false)]
        public long? TimeoutMins { get; set; }

        /// <summary>
        /// <para>The time zone of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The custom Certificate Authority (CA) certificate used by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----****</para>
        /// </summary>
        [NameInMap("user_ca")]
        [Validation(Required=false)]
        public string UserCa { get; set; }

        /// <summary>
        /// <para>The user data of nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IyEvdXNyL2Jpbi9iYXNoCmVjaG8gIkhlbGxvIEFD****</para>
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) in which you want to deploy the cluster. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zeik9h3ahvv2zz95****</para>
        /// </summary>
        [NameInMap("vpcid")]
        [Validation(Required=false)]
        public string Vpcid { get; set; }

        /// <summary>
        /// <para>The vSwitches for nodes in the cluster. This parameter is required if you create an ACK managed cluster that does not contain nodes.</para>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for worker nodes. This parameter takes effect and is required only when <c>worker_instance_charge_type</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables auto-renewal.</description></item>
        /// <item><description><c>false</c>: disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: <c>true</c></para>
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
        /// <para>The auto-renewal duration. This parameter takes effect and is required only when the subscription billing method is selected for worker nodes.</para>
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
        /// <para>The configurations of the data disks that you want to mount to worker nodes. The configurations include the disk type and disk size.</para>
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        [Obsolete]
        public List<CreateClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class CreateClusterRequestWorkerDataDisks : TeaModel {
            /// <summary>
            /// <para>The data disk type.</para>
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
            /// <list type="bullet">
            /// <item><description><c>true</c>: encrypts the data disk.</description></item>
            /// <item><description><c>false</c>: does not encrypt the data disk.</description></item>
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
            /// <para>The PL of the data disk. This parameter takes effect only for ESSDs. You can specify a higher PL if you increase the size of a data disk. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("performance_level")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The data disk size. Valid values: 40 to 32767. Unit: GiB.</para>
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
        /// <para>The billing method of worker nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PrePaid</c>: subscription.</description></item>
        /// <item><description><c>PostPaid</c>: pay-as-you-go.</description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
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
        /// <para>The instance configurations of worker nodes.</para>
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The subscription duration of worker nodes. This parameter takes effect and is required only when <c>worker_instance_charge_type</c> is set to <c>PrePaid</c>.</para>
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
        /// <para>The billing cycle of worker nodes. This parameter is required if worker_instance_charge_type is set to <c>PrePaid</c>.</para>
        /// <para>Set the value to <c>Month</c>. Subscription worker nodes are billed only on a monthly basis.</para>
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
        /// <para>The system disk type of worker nodes. For more information, see <a href="https://help.aliyun.com/document_detail/63136.html">Overview of Block Storage</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cloud_efficiency</c>: ultra disk.</description></item>
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
        /// <para>If the system disk is an ESSD, you can specify the PL of the ESSD. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSDs</a>.</para>
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
        /// <para>The system disk size of worker nodes. Unit: GiB.</para>
        /// <para>Valid values: 40 to 500.</para>
        /// <para>The value of this parameter must be at least 40 and greater than or equal to the image size.</para>
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
        /// <para>The ID of the automatic snapshot policy that is used by the system disk specified for worker nodes.</para>
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
        /// <para>The vSwitches for worker nodes. Each worker node is allocated a vSwitch.</para>
        /// <para><c>worker_vswitch_ids</c> is optional but <c>vswitch_ids</c> is required if you create an ACK managed cluster that does not contain nodes.</para>
        /// </summary>
        [NameInMap("worker_vswitch_ids")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> WorkerVswitchIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the zone to which the cluster belongs. This parameter takes effect only for ACK Serverless clusters.</para>
        /// <para>If you create an ACK Serverless cluster, you must specify <c>zone_id</c> if <c>vpc_id</c> and <c>vswitch_ids</c> are not specified. This way, the system automatically creates a VPC in the specified zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beiji****</para>
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>List of availability zone IDs in the region where the cluster resides. This parameter is specific to ACK managed clusters.
        /// When creating an ACK managed cluster, if <c>vpc_id</c> and <c>vswitch_ids</c> are not specified, specifying <c>zone_ids</c> allows for automatic creation of VPC network resources across multiple availability zones. If <c>vpc_id</c> and <c>vswitch_ids</c> are specified, this parameter becomes ineffective.</para>
        /// </summary>
        [NameInMap("zone_ids")]
        [Validation(Required=false)]
        public List<string> ZoneIds { get; set; }

    }

}
