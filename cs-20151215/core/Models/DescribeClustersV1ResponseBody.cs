// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersV1ResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of clusters.</para>
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersV1ResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersV1ResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The domain name of the cluster.</para>
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
            /// <para>c3fb96524f9274b4495df0f12a6b5****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The edition of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack.standard</para>
            /// </summary>
            [NameInMap("cluster_spec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// <para>The cluster type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Kubernetes</para>
            /// </summary>
            [NameInMap("cluster_type")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The CIDR block of pods. This parameter is applicable to Flannel networks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.20.xx.xx/16</para>
            /// </summary>
            [NameInMap("container_cidr")]
            [Validation(Required=false)]
            public string ContainerCidr { get; set; }

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
            /// <para>The current version of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.32.1-aliyun.1</para>
            /// </summary>
            [NameInMap("current_version")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled. If deletion protection is enabled, you cannot delete the cluster in the console or by calling an API operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Deletion protection is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Deletion protection is disabled.</para>
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
            /// <para>The Docker version of the cluster.</para>
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
            /// <para>The ID of the Server Load Balancer (SLB) instance that is used for the Ingress.</para>
            /// <para>Default instance specification: slb.s1.small (performance-guaranteed).</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-2vcrbmlevo6kjpgch****</para>
            /// </summary>
            [NameInMap("external_loadbalancer_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string ExternalLoadbalancerId { get; set; }

            /// <summary>
            /// <para>The initial version of the cluster. For information about the Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Kubernetes release overview</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.32.1-aliyun.1</para>
            /// </summary>
            [NameInMap("init_version")]
            [Validation(Required=false)]
            public string InitVersion { get; set; }

            /// <summary>
            /// <para>The IP stack of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ipv4</c>: an IPv4-only cluster.</para>
            /// </description></item>
            /// <item><description><para><c>dual</c>: a dual-stack cluster that supports both IPv4 and IPv6.</para>
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
            /// <para>The maintenance window of the cluster. This feature is available only for ACK managed clusters and ACK Serverless clusters.</para>
            /// </summary>
            [NameInMap("maintenance_window")]
            [Validation(Required=false)]
            public MaintenanceWindow MaintenanceWindow { get; set; }

            /// <summary>
            /// <para>The endpoints of the API server. The endpoints include an internal endpoint and a public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;api_server_endpoint\&quot;:\&quot;\&quot;,\&quot;intranet_api_server_endpoint\&quot;:\&quot;<a href="https://192.168.xx.xx:6443%5C%5C%22%7D">https://192.168.xx.xx:6443\\&quot;}</a></para>
            /// </summary>
            [NameInMap("master_url")]
            [Validation(Required=false)]
            public string MasterUrl { get; set; }

            /// <summary>
            /// <para>The metadata of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Addons\&quot;:[{\&quot;config\&quot;:***}}</para>
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
            /// <para>The network mode of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>classic</c>: classic network</para>
            /// </description></item>
            /// <item><description><para><c>vpc</c>: VPC</para>
            /// </description></item>
            /// <item><description><para><c>overlay</c>: overlay network</para>
            /// </description></item>
            /// <item><description><para><c>calico</c>: Calico network</para>
            /// </description></item>
            /// </list>
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
            /// <para>The auto O\&amp;M policy of the cluster.</para>
            /// </summary>
            [NameInMap("operation_policy")]
            [Validation(Required=false)]
            public DescribeClustersV1ResponseBodyClustersOperationPolicy OperationPolicy { get; set; }
            public class DescribeClustersV1ResponseBodyClustersOperationPolicy : TeaModel {
                /// <summary>
                /// <para>The cluster auto-upgrade policy.</para>
                /// </summary>
                [NameInMap("cluster_auto_upgrade")]
                [Validation(Required=false)]
                public DescribeClustersV1ResponseBodyClustersOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
                public class DescribeClustersV1ResponseBodyClustersOperationPolicyClusterAutoUpgrade : TeaModel {
                    /// <summary>
                    /// <para>The upgrade channel. For more information, see <a href="https://help.aliyun.com/document_detail/2712866.html">Upgrade channels</a>.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>patch</c>: Upgrades the cluster to the latest available patch version.</para>
                    /// </description></item>
                    /// <item><description><para><c>stable</c>: Upgrades the cluster to the latest stable minor version. This version is typically the second latest minor version.</para>
                    /// </description></item>
                    /// <item><description><para><c>rapid</c>: Upgrades the cluster to the latest available minor version.</para>
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
                    /// <para>Indicates whether auto-upgrade is enabled for the cluster.</para>
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
            /// <para>Indicates whether PrivateZone is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: PrivateZone is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: PrivateZone is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("private_zone")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? PrivateZone { get; set; }

            /// <summary>
            /// <para>The subtype of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            /// <summary>
            /// <para>The kube-proxy proxy mode.</para>
            /// <list type="bullet">
            /// <item><description><para><c>iptables</c>: a stable and mature proxy mode. The service discovery and load balancing of Kubernetes Services are implemented by using iptables rules. This mode offers moderate performance and is suitable for clusters that have a small number of Services.</para>
            /// </description></item>
            /// <item><description><para><c>ipvs</c>: a high-performance proxy mode. The service discovery and load balancing of Kubernetes Services are implemented by using the Linux IP Virtual Server (IPVS) module. This mode is suitable for clusters that have a large number of Services and require high-performance load balancing.</para>
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
            /// <para>The ID of the security group to which the cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2vcgwsrwgt5mp0yi****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The CIDR block of Services.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.21.xx.xx/20</para>
            /// </summary>
            [NameInMap("service_cidr")]
            [Validation(Required=false)]
            public string ServiceCidr { get; set; }

            /// <summary>
            /// <para>The total number of nodes in the cluster. This includes master nodes and worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The state of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>initial</c>: The cluster is being created.</para>
            /// </description></item>
            /// <item><description><para><c>failed</c>: The cluster failed to be created.</para>
            /// </description></item>
            /// <item><description><para><c>running</c>: The cluster is running.</para>
            /// </description></item>
            /// <item><description><para><c>updating</c>: The cluster is being updated.</para>
            /// </description></item>
            /// <item><description><para><c>upgrading</c>: The cluster is being upgraded.</para>
            /// </description></item>
            /// <item><description><para><c>removing</c>: Nodes are being removed from the cluster.</para>
            /// </description></item>
            /// <item><description><para><c>draining</c>: Nodes in the cluster are being drained.</para>
            /// </description></item>
            /// <item><description><para><c>scaling</c>: The cluster is being scaled.</para>
            /// </description></item>
            /// <item><description><para><c>inactive</c>: The cluster is inactive.</para>
            /// </description></item>
            /// <item><description><para><c>unavailable</c>: The cluster is unavailable.</para>
            /// </description></item>
            /// <item><description><para><c>deleting</c>: The cluster is being deleted.</para>
            /// </description></item>
            /// <item><description><para><c>deleted</c>: The cluster has been deleted.</para>
            /// </description></item>
            /// <item><description><para><c>delete_failed</c>: The cluster failed to be deleted.</para>
            /// </description></item>
            /// <item><description><para><c>waiting</c>: The cluster is awaiting connection.</para>
            /// </description></item>
            /// <item><description><para><c>disconnected</c>: The cluster is disconnected.</para>
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
            /// <para>This parameter is deprecated. Use the <c>container_cidr</c> parameter to obtain the pod CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("subnet_cidr")]
            [Validation(Required=false)]
            [Obsolete]
            public string SubnetCidr { get; set; }

            /// <summary>
            /// <para>The tags of the cluster.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

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
            /// <para>The time when the cluster was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-07T09:57:26+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// <para>The ID of the VPC in which the cluster is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2vcg932hsxsxuqbgl****</para>
            /// </summary>
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The ID of the vSwitch to which the cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2vc41xuumx5z2rdma****,vsw-2vc41xuumx5z2rdma****</para>
            /// </summary>
            [NameInMap("vswitch_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The vSwitches of the cluster control plane.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The name of the worker RAM role. This role is used to authorize Elastic Compute Service (ECS) instances to be used as worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KubernetesWorkerRole-ec87d15b-edca-4302-933f-c8a16bf0****</para>
            /// </summary>
            [NameInMap("worker_ram_role_name")]
            [Validation(Required=false)]
            [Obsolete]
            public string WorkerRamRoleName { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The ID of the zone in which the cluster is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-b</para>
            /// </summary>
            [NameInMap("zone_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeClustersV1ResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeClustersV1ResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries that were returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
