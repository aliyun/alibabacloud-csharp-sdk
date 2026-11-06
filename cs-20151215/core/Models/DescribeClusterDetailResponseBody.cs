// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The auto mode configuration.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyAutoMode AutoMode { get; set; }
        public class DescribeClusterDetailResponseBodyAutoMode : TeaModel {
            /// <summary>
            /// <para>Specifies whether auto mode is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The local domain name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster.local</para>
        /// </summary>
        [NameInMap("cluster_domain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c82e6987e2961451182edacd74faf****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The specifications of the cluster when cluster_type is set to ManagedKubernetes and profile is configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ack.standard: Basic Edition. This is the default value if this parameter is left empty.</description></item>
        /// <item><description>ack.pro.small: Pro Edition.</description></item>
        /// <item><description>ack.pro.xlarge: Pro XL.</description></item>
        /// <item><description>ack.pro.2xlarge: Pro 2XL.</description></item>
        /// <item><description>ack.pro.4xlarge: Pro 4XL. You must contact customer service to apply for whitelist access.</description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are the three tiers provided by the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>. By pre-allocating and dedicating control plane resources, these tiers ensure consistently high levels of API concurrency and pod scheduling capabilities. They are suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For more information about the cluster management fees for Pro Edition and provisioned control plane editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Kubernetes: ACK dedicated cluster.</description></item>
        /// <item><description>ManagedKubernetes: ACK ACK cluster, including ACK ACK clusters (Pro Edition and Basic Edition), ACK Serverless clusters (Pro Edition and Basic Edition), ACK Edge clusters (Pro Edition and Basic Edition), and ACK Lingjun clusters (Pro Edition).</description></item>
        /// <item><description>ExternalKubernetes: registered cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The Pod CIDR block for Flannel network configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.xx.xx/16</para>
        /// </summary>
        [NameInMap("container_cidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        /// <summary>
        /// <para>The control plane configuration for an ACK dedicated cluster.</para>
        /// </summary>
        [NameInMap("control_plane_config")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyControlPlaneConfig ControlPlaneConfig { get; set; }
        public class DescribeClusterDetailResponseBodyControlPlaneConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether auto-renewal is enabled for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal period for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The billing method for the control plane node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("charge_type")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Specifies whether CloudMonitor is installed on the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cloud_monitor_flags")]
            [Validation(Required=false)]
            public bool? CloudMonitorFlags { get; set; }

            /// <summary>
            /// <para>The CPU management policy for the node.</para>
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
            /// <para>aliyun_3_x64_20G_alibase_20240819</para>
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
            /// <para>The metadata access configuration for the ECS instance.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>The instance types of the node.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The name of the key pair. You must specify either this parameter or login_password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>The service port range for nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("node_port_range")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>The subscription period for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription period for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The name of the container runtime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>Specifies whether Alibaba Cloud OS security hardening is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <para>Specifies whether MLPS 2.0 security hardening is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether performance bursting is enabled for the system cloud disk of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The category of the system cloud disk for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the system cloud disk for the node. This parameter takes effect only for ESSDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read and write IOPS for the system cloud disk of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk for the node. The minimum value is 40.</para>
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
        /// <para>The connection configuration of the cluster.</para>
        /// </summary>
        [NameInMap("control_plane_endpoints_config")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyControlPlaneEndpointsConfig ControlPlaneEndpointsConfig { get; set; }
        public class DescribeClusterDetailResponseBodyControlPlaneEndpointsConfig : TeaModel {
            /// <summary>
            /// <para>The internal DNS configuration of the cluster, which applies to ACK managed clusters. The internal domain name is used by node-side system components such as kubelet and kube-proxy to access the API server. If internal domain name access is not enabled, node-side system components access the API server by using the CLB IP address.</para>
            /// </summary>
            [NameInMap("internal_dns_config")]
            [Validation(Required=false)]
            public DescribeClusterDetailResponseBodyControlPlaneEndpointsConfigInternalDnsConfig InternalDnsConfig { get; set; }
            public class DescribeClusterDetailResponseBodyControlPlaneEndpointsConfigInternalDnsConfig : TeaModel {
                /// <summary>
                /// <para>The VPCs where the resolution of the internal domain name records takes effect. By default, this includes the VPC where the cluster is deployed.</para>
                /// </summary>
                [NameInMap("bind_vpcs")]
                [Validation(Required=false)]
                public List<string> BindVpcs { get; set; }

                /// <summary>
                /// <para>Specifies whether internal domain name access is enabled for the cluster. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>true: Internal domain name access is enabled. Node-side components such as kubelet and kube-proxy access the API server by using the internal domain name.</description></item>
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
            public List<DescribeClusterDetailResponseBodyControlPlaneEndpointsConfigLoadBalancersConfig> LoadBalancersConfig { get; set; }
            public class DescribeClusterDetailResponseBodyControlPlaneEndpointsConfigLoadBalancersConfig : TeaModel {
                /// <summary>
                /// <para>The endpoint address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nlb-0ogk9aaxxxxxxx.cn-hangzhou.nlb.aliyuncsslb.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

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
                /// <para>The Server Load Balancer (SLB) instance associated with the endpoint.</para>
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
        /// <para>The time when the cluster was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-07T09:57:26+08:00</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// <para>The current version of the cluster. For more information about the Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Overview of Kubernetes versions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("current_version")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether deletion protection is enabled for the cluster to prevent accidental deletion through the console or API calls. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Deletion protection is enabled. The cluster cannot be deleted through the console or API calls.</description></item>
        /// <item><description><c>false</c>: Deletion protection is disabled. The cluster can be deleted through the console or API calls.</description></item>
        /// </list>
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
        /// <para>The Docker version in the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19.03.5</para>
        /// </summary>
        [NameInMap("docker_version")]
        [Validation(Required=false)]
        [Obsolete]
        public string DockerVersion { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The instance ID of the Ingress LB for the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2zehc05z3b8dwiifh****</para>
        /// </summary>
        [NameInMap("external_loadbalancer_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string ExternalLoadbalancerId { get; set; }

        /// <summary>
        /// <para>The custom Subject Alternative Names (SANs) for the API server certificate.</para>
        /// </summary>
        [NameInMap("extra_sans")]
        [Validation(Required=false)]
        public List<string> ExtraSans { get; set; }

        /// <summary>
        /// <para>The initial version of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("init_version")]
        [Validation(Required=false)]
        public string InitVersion { get; set; }

        /// <summary>
        /// <para>The IP protocol stack of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ipv4: The cluster supports only the IPv4 protocol stack.</description></item>
        /// <item><description>dual: The cluster supports both IPv4 and IPv6 protocol stacks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("ip_stack")]
        [Validation(Required=false)]
        public string IpStack { get; set; }

        /// <summary>
        /// <para>The maintenance window configuration of the cluster. This parameter takes effect only for managed clusters, namely ACK Pro clusters.</para>
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// <para>The access endpoint of the cluster, including the internal network access endpoint and the public network access endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;intranet_api_server_endpoint\&quot;:\&quot;<a href="https://192.168.xx.xx:6443%5C%5C%22***%7D">https://192.168.xx.xx:6443\\&quot;***}</a></para>
        /// </summary>
        [NameInMap("master_url")]
        [Validation(Required=false)]
        public string MasterUrl { get; set; }

        /// <summary>
        /// <para>The metadata of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;Addons\&quot;:***</para>
        /// </summary>
        [NameInMap("meta_data")]
        [Validation(Required=false)]
        public string MetaData { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
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
        /// <para>The network type of the cluster, such as VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("network_mode")]
        [Validation(Required=false)]
        [Obsolete]
        public string NetworkMode { get; set; }

        /// <summary>
        /// <para>The version to which the cluster can be upgraded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.xx.x-aliyun.1</para>
        /// </summary>
        [NameInMap("next_version")]
        [Validation(Required=false)]
        public string NextVersion { get; set; }

        /// <summary>
        /// <para>The size of the subnet mask allocated to nodes, which determines the number of IP addresses that can be allocated to each node. This parameter applies only to the Flannel network plugin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("node_cidr_mask")]
        [Validation(Required=false)]
        public string NodeCidrMask { get; set; }

        /// <summary>
        /// <para>The automatic O&amp;M policy of the cluster.</para>
        /// </summary>
        [NameInMap("operation_policy")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyOperationPolicy OperationPolicy { get; set; }
        public class DescribeClusterDetailResponseBodyOperationPolicy : TeaModel {
            /// <summary>
            /// <para>The automatic upgrade configuration of the cluster.</para>
            /// </summary>
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public DescribeClusterDetailResponseBodyOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class DescribeClusterDetailResponseBodyOperationPolicyClusterAutoUpgrade : TeaModel {
                /// <summary>
                /// <para>The automatic upgrade channel of the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/2712866.html">Upgrade channels</a>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>patch: the latest patch version.</description></item>
                /// <item><description>stable: the second latest minor version.</description></item>
                /// <item><description>rapid: the latest minor version.</description></item>
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
        /// <para>The collection of Resource Orchestration Service (ROS) parameters for the cluster.</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, string> Parameters { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to enable PrivateZone for the cluster. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enabled.</description></item>
        /// <item><description><c>false</c>: disabled.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("private_zone")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? PrivateZone { get; set; }

        /// <summary>
        /// <para>The subtype of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Default</c>: ACK managed cluster, including ACK cluster Pro and ACK cluster Basic.</para>
        /// </description></item>
        /// <item><description><para><c>Edge</c>: ACK Edge cluster, including ACK Edge cluster Pro and ACK Edge cluster Basic.</para>
        /// </description></item>
        /// <item><description><para><c>Serverless</c>: ACK Serverless cluster, including ACK Serverless cluster Pro and ACK Serverless cluster Basic.</para>
        /// </description></item>
        /// <item><description><para><c>Lingjun</c>: ACK Lingjun cluster, which provides only the Pro edition.</para>
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
        /// <para>The kube-proxy mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>iptables</c>: the mature and stable kube-proxy mode. Service discovery and load balancing for Kubernetes Services are configured by using iptables rules. This mode provides average performance and is significantly affected by the cluster scale. It is suitable for clusters with a small number of Services.</description></item>
        /// <item><description><c>ipvs</c>: the high-performance kube-proxy mode. Service discovery and load balancing for Kubernetes Services are configured by using the Linux IPVS module. This mode is suitable for clusters with a large number of Services and scenarios that require high-performance load balancing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipvs</para>
        /// </summary>
        [NameInMap("proxy_mode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// <para>The ID of the region where the cluster is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The RAM Roles for Service Accounts (RRSA) configuration.</para>
        /// </summary>
        [NameInMap("rrsa_config")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyRrsaConfig RrsaConfig { get; set; }
        public class DescribeClusterDetailResponseBodyRrsaConfig : TeaModel {
            /// <summary>
            /// <para>The default audience of the OpenID Connect (OIDC) token. If multiple values are specified, they are separated by commas (,). The values are used as an array for the <c>aud</c> field in the OIDC token.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://kubernetes.default.svc,https://example.***.com">https://kubernetes.default.svc,https://example.***.com</a></para>
            /// </summary>
            [NameInMap("audience")]
            [Validation(Required=false)]
            public string Audience { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable RRSA.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The issuer of the OIDC token. If multiple values are specified, they are separated by commas (,). The first value is used as the <c>iss</c> field in the OIDC token and the issuer URL of the OIDC identity provider (IdP).</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oidc-ack-***,https://kubernetes.default.svc">https://oidc-ack-***,https://kubernetes.default.svc</a></para>
            /// </summary>
            [NameInMap("issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The URL of the OIDC public key.</para>
            /// </summary>
            [NameInMap("jwks_url")]
            [Validation(Required=false)]
            public string JwksUrl { get; set; }

            /// <summary>
            /// <para>The maximum validity period that can be configured for the OIDC token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12h</para>
            /// </summary>
            [NameInMap("max_oidc_token_expiration")]
            [Validation(Required=false)]
            public string MaxOidcTokenExpiration { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the OIDC IdP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1138***:oidc-provider/ack-rrsa-***</para>
            /// </summary>
            [NameInMap("oidc_arn")]
            [Validation(Required=false)]
            public string OidcArn { get; set; }

            /// <summary>
            /// <para>The name of the OIDC IdP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-rrsa-***</para>
            /// </summary>
            [NameInMap("oidc_name")]
            [Validation(Required=false)]
            public string OidcName { get; set; }

            /// <summary>
            /// <para>The URL of the OIDC configuration document.</para>
            /// </summary>
            [NameInMap("open_api_configuration_url")]
            [Validation(Required=false)]
            public string OpenApiConfigurationUrl { get; set; }

        }

        /// <summary>
        /// <para>The ID of the security group to which the cluster belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-25yq****</para>
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The CIDR block of the Service network.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.21.xx.xx/20</para>
        /// </summary>
        [NameInMap("service_cidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// <para>The number of nodes in the cluster, including master nodes and worker nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The cluster status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>initial</c>: The cluster is being created.</description></item>
        /// <item><description><c>failed</c>: The cluster creation failed.</description></item>
        /// <item><description><c>running</c>: The cluster is running.</description></item>
        /// <item><description><c>updating</c>: The cluster is being updated.</description></item>
        /// <item><description><c>upgrading</c>: The cluster is being upgraded.</description></item>
        /// <item><description><c>removing</c>: Nodes are being removed.</description></item>
        /// <item><description><c>draining</c>: Nodes are being drained.</description></item>
        /// <item><description><c>scaling</c>: The cluster is being scaled.</description></item>
        /// <item><description><c>inactive</c>: The cluster is inactive.</description></item>
        /// <item><description><c>unavailable</c>: The cluster is unavailable.</description></item>
        /// <item><description><c>deleting</c>: The cluster is being deleted.</description></item>
        /// <item><description><c>deleted</c>: The cluster is deleted.</description></item>
        /// <item><description><c>delete_failed</c>: The cluster deletion failed.</description></item>
        /// <item><description><c>waiting</c>: The cluster is waiting for the accessed state.</description></item>
        /// <item><description><c>disconnected</c>: The cluster is disconnected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use container_cidr to obtain the Pod CIDR block. The Pod CIDR block. It must be a valid private CIDR block, specifically one of the following CIDR blocks or their subnets: 10.0.0.0/8, 172.16.0.0/12 to 172.31.0.0/16, and 192.168.0.0/16. It cannot overlap with the CIDR block of the VPC or the CIDR blocks used by existing Kubernetes clusters in the VPC. It cannot be modified after the cluster is created. For more information about cluster network planning, see <a href="https://help.aliyun.com/document_detail/~~86500~~">Plan CIDR blocks for Kubernetes clusters in a VPC</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.xx.xx/16</para>
        /// </summary>
        [NameInMap("subnet_cidr")]
        [Validation(Required=false)]
        [Obsolete]
        public string SubnetCidr { get; set; }

        /// <summary>
        /// <para>The cluster version support policy. The value is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: Standard support.</description></item>
        /// <item><description>Extended: Extended support. After the standard support period ends, the cluster enters the extended support period and continues to receive CVE patch updates.
        /// If this policy is not set for an existing cluster, Standard is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Extended</para>
        /// </summary>
        [NameInMap("support_policy")]
        [Validation(Required=false)]
        public string SupportPolicy { get; set; }

        /// <summary>
        /// <para>The cluster resource tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>The time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The time when the cluster was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-10T13:28:09+08:00</para>
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public string Updated { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) where the cluster is deployed. This parameter is required when you create a cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zecuu62b9zw7a7qn****</para>
        /// </summary>
        [NameInMap("vpc_id")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> To query the vSwitches for the control plane, use vswitch_ids. To query the vSwitches for the data plane, use the vswitch_ids of the node pool. The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zete8s4qocqg0mf6****,vsw-2zete8s4qocqg0mf6****</para>
        /// </summary>
        [NameInMap("vswitch_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string VswitchId { get; set; }

        /// <summary>
        /// <para>The vSwitches for the cluster control plane.</para>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <summary>
        /// <para>The name of the RAM role for worker nodes. It is used to authorize ECS instances as worker nodes in the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KubernetesWorkerRole-ec87d15b-edca-4302-933f-c8a16bf0****</para>
        /// </summary>
        [NameInMap("worker_ram_role_name")]
        [Validation(Required=false)]
        public string WorkerRamRoleName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the zone where the cluster is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-a</para>
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string ZoneId { get; set; }

    }

}
