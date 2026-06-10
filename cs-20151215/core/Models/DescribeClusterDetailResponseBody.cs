// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Smart managed mode configuration.</para>
        /// </summary>
        [NameInMap("auto_mode")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyAutoMode AutoMode { get; set; }
        public class DescribeClusterDetailResponseBodyAutoMode : TeaModel {
            /// <summary>
            /// <para>Indicates whether smart managed mode is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>Local domain name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster.local</para>
        /// </summary>
        [NameInMap("cluster_domain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// <para>Cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c82e6987e2961451182edacd74faf****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Cluster specification when <c>cluster_type</c> is set to <c>ManagedKubernetes</c> and <c>profile</c> is configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ack.standard</c>: Basic Edition (default if left empty)</para>
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
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are three tiers offered by &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>. These tiers pre-allocate and dedicate control plane resources to ensure consistent high performance for API concurrency and pod scheduling, making them suitable for AI training and inference, large-scale clusters, and mission-critical workloads.</para>
        /// <para>For cluster management fees of Pro Edition and provisioned control plane clusters, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>Cluster type.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Kubernetes</c>: ACK dedicated cluster.</para>
        /// </description></item>
        /// <item><description><para><c>ManagedKubernetes</c>: ACK managed clusters, including ACK Pro Edition and Basic Edition clusters, ACK Serverless clusters (Pro and Basic), ACK Edge clusters (Pro and Basic), and ACK LINGJUN clusters (Pro).</para>
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
        /// <para>CIDR block for pod networks, used with Flannel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.xx.xx/16</para>
        /// </summary>
        [NameInMap("container_cidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        /// <summary>
        /// <para>Control plane configuration for dedicated clusters.</para>
        /// </summary>
        [NameInMap("control_plane_config")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyControlPlaneConfig ControlPlaneConfig { get; set; }
        public class DescribeClusterDetailResponseBodyControlPlaneConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether auto-renewal is enabled for nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>Auto-renewal duration for nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>Billing method for control plane nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("charge_type")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Indicates whether Cloud Monitor is installed on nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cloud_monitor_flags")]
            [Validation(Required=false)]
            public bool? CloudMonitorFlags { get; set; }

            /// <summary>
            /// <para>CPU management policy for nodes.</para>
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
            /// <para>aliyun_3_x64_20G_alibase_20240819</para>
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
            /// <para>Metadata access configuration for ECS instances.</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>Instance types for control plane nodes.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>Key pair name. Specify either this parameter or login_password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>Port range for node services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("node_port_range")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>Subscription duration for nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>Time unit for node subscription.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>Runtime name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>Indicates whether Alibaba Cloud OS security hardening is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("security_hardening_os")]
            [Validation(Required=false)]
            public bool? SecurityHardeningOs { get; set; }

            /// <summary>
            /// <para>Number of control plane nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>Indicates whether security hardening for compliance is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether burst performance is enabled for node system disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>System disk category for nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>Disk performance level for node system disks. Applies only to ESSD disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>Provisioned IOPS for node system disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>System disk size for nodes, in GB. Minimum value: 40.</para>
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
        public DescribeClusterDetailResponseBodyControlPlaneEndpointsConfig ControlPlaneEndpointsConfig { get; set; }
        public class DescribeClusterDetailResponseBodyControlPlaneEndpointsConfig : TeaModel {
            /// <summary>
            /// <para>Internal domain name configuration for the cluster, applicable to ACK managed clusters. The internal domain name allows node-side system components such as kubelet and kube-proxy to access the API server. If internal domain name access is disabled, these components access the API server through the CLB IP address.</para>
            /// </summary>
            [NameInMap("internal_dns_config")]
            [Validation(Required=false)]
            public DescribeClusterDetailResponseBodyControlPlaneEndpointsConfigInternalDnsConfig InternalDnsConfig { get; set; }
            public class DescribeClusterDetailResponseBodyControlPlaneEndpointsConfigInternalDnsConfig : TeaModel {
                /// <summary>
                /// <para>VPCs where the internal domain name resolution takes effect. By default, this includes the VPC where the cluster resides.</para>
                /// </summary>
                [NameInMap("bind_vpcs")]
                [Validation(Required=false)]
                public List<string> BindVpcs { get; set; }

                /// <summary>
                /// <para>Indicates whether internal domain name access is enabled.</para>
                /// <list type="bullet">
                /// <item><description>true: Internal domain name access is enabled. Node-side components (kubelet, kube-proxy) access the API server through the internal domain name.</description></item>
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
        /// <para>Time when the cluster was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-07T09:57:26+08:00</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// <para>Current Kubernetes version of the cluster. For supported Kubernetes versions in ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Overview of Kubernetes versions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("current_version")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// <para>Deletion protection for the cluster prevents accidental deletion through the console or API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Deletion protection is enabled. You cannot delete the cluster through the console or API.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Deletion protection is disabled. You can delete the cluster through the console or API.</para>
        /// </description></item>
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
        /// <para>Docker version used in the cluster.</para>
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
        /// <para>ID of the Server Load Balancer instance used for the cluster Ingress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2zehc05z3b8dwiifh****</para>
        /// </summary>
        [NameInMap("external_loadbalancer_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string ExternalLoadbalancerId { get; set; }

        /// <summary>
        /// <para>Custom Subject Alternative Names (SANs) for the API server certificate.</para>
        /// </summary>
        [NameInMap("extra_sans")]
        [Validation(Required=false)]
        public List<string> ExtraSans { get; set; }

        /// <summary>
        /// <para>Initial Kubernetes version of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("init_version")]
        [Validation(Required=false)]
        public string InitVersion { get; set; }

        /// <summary>
        /// <para>IP protocol stack of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ipv4: Creates a cluster that supports IPv4 only.</para>
        /// </description></item>
        /// <item><description><para>dual: Creates a cluster that supports both IPv4 and IPv6.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("ip_stack")]
        [Validation(Required=false)]
        public string IpStack { get; set; }

        /// <summary>
        /// <para>Maintenance window configuration for the cluster. This setting applies only to managed clusters (ACK Pro clusters).</para>
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// <para>Cluster endpoint, including internal and public endpoints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;intranet_api_server_endpoint\&quot;:\&quot;<a href="https://192.168.xx.xx:6443%5C%5C%22***%7D">https://192.168.xx.xx:6443\\&quot;***}</a></para>
        /// </summary>
        [NameInMap("master_url")]
        [Validation(Required=false)]
        public string MasterUrl { get; set; }

        /// <summary>
        /// <para>Metadata of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;Addons\&quot;:***</para>
        /// </summary>
        [NameInMap("meta_data")]
        [Validation(Required=false)]
        public string MetaData { get; set; }

        /// <summary>
        /// <para>Cluster name.</para>
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
        /// <para>Network type used by the cluster, such as VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("network_mode")]
        [Validation(Required=false)]
        [Obsolete]
        public string NetworkMode { get; set; }

        /// <summary>
        /// <para>Next available Kubernetes version for upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.xx.x-aliyun.1</para>
        /// </summary>
        [NameInMap("next_version")]
        [Validation(Required=false)]
        public string NextVersion { get; set; }

        /// <summary>
        /// <para>Applies only to Flannel network plugin.</para>
        /// <para>Subnet mask size allocated to each node, which controls the number of IP addresses assignable to the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("node_cidr_mask")]
        [Validation(Required=false)]
        public string NodeCidrMask { get; set; }

        /// <summary>
        /// <para>Automatic O\&amp;M policy for the cluster.</para>
        /// </summary>
        [NameInMap("operation_policy")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyOperationPolicy OperationPolicy { get; set; }
        public class DescribeClusterDetailResponseBodyOperationPolicy : TeaModel {
            /// <summary>
            /// <para>Automatic cluster upgrade settings.</para>
            /// </summary>
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public DescribeClusterDetailResponseBodyOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class DescribeClusterDetailResponseBodyOperationPolicyClusterAutoUpgrade : TeaModel {
                /// <summary>
                /// <para>Frequency of automatic cluster upgrades. For more information, see <a href="https://help.aliyun.com/document_detail/2712866.html">Upgrade frequency</a>.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>patch: Latest patch version.</para>
                /// </description></item>
                /// <item><description><para>stable: Second latest minor version.</para>
                /// </description></item>
                /// <item><description><para>rapid: Latest minor version.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>patch</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Indicates whether automatic cluster upgrade is enabled.</para>
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
        /// <para>Collection of ROS parameters for the cluster.</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, string> Parameters { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Indicates whether PrivateZone is enabled for the cluster.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disabled.</para>
        /// </description></item>
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
        /// <para>Cluster subtype.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Default</c>: ACK managed cluster, including ACK Pro Edition and Basic Edition.</para>
        /// </description></item>
        /// <item><description><para><c>Edge</c>: ACK Edge cluster, including ACK Edge Pro Edition and Basic Edition.</para>
        /// </description></item>
        /// <item><description><para><c>Serverless</c>: ACK Serverless cluster, including ACK Serverless Pro Edition and Basic Edition.</para>
        /// </description></item>
        /// <item><description><para><c>Lingjun</c>: ACK LINGJUN cluster, available in Pro Edition.</para>
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
        /// <para>kube-proxy proxy mode.</para>
        /// <list type="bullet">
        /// <item><description><para><c>iptables</c>: A mature and stable kube-proxy mode that uses iptables rules for Kubernetes service discovery and load balancing. Performance is moderate and degrades at scale. Suitable for clusters with a small number of services.</para>
        /// </description></item>
        /// <item><description><para><c>ipvs</c>: A high-performance kube-proxy mode that uses the Linux IPVS module for Kubernetes service discovery and load balancing. Suitable for clusters with many services and high load balancing demands.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipvs</para>
        /// </summary>
        [NameInMap("proxy_mode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// <para>Region ID where the cluster is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyvw3wjm****</para>
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>RRSA configuration.</para>
        /// </summary>
        [NameInMap("rrsa_config")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyRrsaConfig RrsaConfig { get; set; }
        public class DescribeClusterDetailResponseBodyRrsaConfig : TeaModel {
            /// <summary>
            /// <para>Default audience for the OIDC token. Multiple values are separated by commas (,). These values appear as an array in the aud field of the OIDC token.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://kubernetes.default.svc,https://example.***.com">https://kubernetes.default.svc,https://example.***.com</a></para>
            /// </summary>
            [NameInMap("audience")]
            [Validation(Required=false)]
            public string Audience { get; set; }

            /// <summary>
            /// <para>Indicates whether RRSA is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Issuer of the OIDC token. Multiple values are separated by commas (,). The first value appears in the iss field of the OIDC token and serves as the issuer URL for the OIDC identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oidc-ack-***,https://kubernetes.default.svc">https://oidc-ack-***,https://kubernetes.default.svc</a></para>
            /// </summary>
            [NameInMap("issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>URL of the OIDC public key information.</para>
            /// </summary>
            [NameInMap("jwks_url")]
            [Validation(Required=false)]
            public string JwksUrl { get; set; }

            /// <summary>
            /// <para>Maximum validity period configurable for the OIDC token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12h</para>
            /// </summary>
            [NameInMap("max_oidc_token_expiration")]
            [Validation(Required=false)]
            public string MaxOidcTokenExpiration { get; set; }

            /// <summary>
            /// <para>ARN of the OIDC identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1138***:oidc-provider/ack-rrsa-***</para>
            /// </summary>
            [NameInMap("oidc_arn")]
            [Validation(Required=false)]
            public string OidcArn { get; set; }

            /// <summary>
            /// <para>Name of the OIDC identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-rrsa-***</para>
            /// </summary>
            [NameInMap("oidc_name")]
            [Validation(Required=false)]
            public string OidcName { get; set; }

            /// <summary>
            /// <para>URL of the OIDC configuration document.</para>
            /// </summary>
            [NameInMap("open_api_configuration_url")]
            [Validation(Required=false)]
            public string OpenApiConfigurationUrl { get; set; }

        }

        /// <summary>
        /// <para>Security group ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-25yq****</para>
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>CIDR block for service networks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.21.xx.xx/20</para>
        /// </summary>
        [NameInMap("service_cidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// <para>Total number of nodes in the cluster, including master and worker nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>Cluster status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>initial</c>: The cluster is being created.</para>
        /// </description></item>
        /// <item><description><para><c>failed</c>: Cluster creation failed.</para>
        /// </description></item>
        /// <item><description><para><c>running</c>: The cluster is running.</para>
        /// </description></item>
        /// <item><description><para><c>updating</c>: The cluster is being updated.</para>
        /// </description></item>
        /// <item><description><para><c>upgrading</c>: The cluster is being upgraded.</para>
        /// </description></item>
        /// <item><description><para><c>removing</c>: Nodes are being removed.</para>
        /// </description></item>
        /// <item><description><para><c>draining</c>: Nodes are being drained.</para>
        /// </description></item>
        /// <item><description><para><c>scaling</c>: The cluster is scaling.</para>
        /// </description></item>
        /// <item><description><para><c>inactive</c>: The cluster is inactive.</para>
        /// </description></item>
        /// <item><description><para><c>unavailable</c>: The cluster is unavailable.</para>
        /// </description></item>
        /// <item><description><para><c>deleting</c>: The cluster is being deleted.</para>
        /// </description></item>
        /// <item><description><para><c>deleted</c>: The cluster has been deleted.</para>
        /// </description></item>
        /// <item><description><para><c>delete_failed</c>: Cluster deletion failed.</para>
        /// </description></item>
        /// <item><description><para><c>waiting</c>: Waiting for access.</para>
        /// </description></item>
        /// <item><description><para><c>disconnected</c>: Disconnected.</para>
        /// </description></item>
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
        /// <para>CIDR block for pod networks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.xx.xx/16</para>
        /// </summary>
        [NameInMap("subnet_cidr")]
        [Validation(Required=false)]
        [Obsolete]
        public string SubnetCidr { get; set; }

        /// <summary>
        /// <para>Tags associated with the cluster.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>Time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>Last time the cluster was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-10T13:28:09+08:00</para>
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public string Updated { get; set; }

        /// <summary>
        /// <para>VPC ID of the cluster. This parameter is required when creating a cluster.</para>
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
        /// <para>vSwitch ID. This field is deprecated. Use vswitch_ids to query control plane vSwitches and node pool vswitch_ids to query data plane vSwitches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zete8s4qocqg0mf6****,vsw-2zete8s4qocqg0mf6****</para>
        /// </summary>
        [NameInMap("vswitch_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string VswitchId { get; set; }

        /// <summary>
        /// <para>vSwitches for the cluster control plane.</para>
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <summary>
        /// <para>Name of the RAM role assigned to ECS instances acting as worker nodes in the cluster.</para>
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
        /// <para>Zone ID within the region where the cluster is deployed.</para>
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
