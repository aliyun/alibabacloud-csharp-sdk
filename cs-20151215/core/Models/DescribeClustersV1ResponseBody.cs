// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersV1ResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cluster information.</para>
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersV1ResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersV1ResponseBodyClusters : TeaModel {
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
            /// <para>c3fb96524f9274b4495df0f12a6b5****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster specification.</para>
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
            /// <para>The pod CIDR block, which is the Flannel network configuration.</para>
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
            /// <para>Indicates whether deletion protection is enabled for the cluster. This prevents accidental deletion of the cluster through the console or API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Deletion protection is enabled. The cluster cannot be deleted through the console or API.</description></item>
            /// <item><description><c>false</c>: Deletion protection is not enabled. The cluster can be deleted through the console or API.</description></item>
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
            /// <para>The ID of the Server Load Balancer (SLB) instance for the Ingress of the cluster.</para>
            /// <para>Default instance type: guaranteed-performance instance (slb.s1.small).</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-2vcrbmlevo6kjpgch****</para>
            /// </summary>
            [NameInMap("external_loadbalancer_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string ExternalLoadbalancerId { get; set; }

            /// <summary>
            /// <para>The cluster version. For Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Kubernetes version release overview</a>.</para>
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
            /// <item><description>ipv4: creates a cluster that supports only the IPv4 protocol stack.</description></item>
            /// <item><description>dual: creates a cluster that supports the IPv4/IPv6 dual stack.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("ip_stack")]
            [Validation(Required=false)]
            public string IpStack { get; set; }

            /// <summary>
            /// <para>The maintenance window of the cluster. This feature takes effect only for ACK managed clusters and ACK Serverless clusters.</para>
            /// </summary>
            [NameInMap("maintenance_window")]
            [Validation(Required=false)]
            public MaintenanceWindow MaintenanceWindow { get; set; }

            /// <summary>
            /// <para>The access addresses of the cluster API server, including the internal network access address and the public network access address.</para>
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
            /// <para>The cluster name.</para>
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
            /// <item><description><c>classic</c>: classic network.</description></item>
            /// <item><description><c>vpc</c>: virtual private cloud (VPC).</description></item>
            /// <item><description><c>overlay</c>: overlay network.</description></item>
            /// <item><description><c>calico</c>: Calico network.</description></item>
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
            /// <para>The automatic O&amp;M policy of the cluster.</para>
            /// </summary>
            [NameInMap("operation_policy")]
            [Validation(Required=false)]
            public DescribeClustersV1ResponseBodyClustersOperationPolicy OperationPolicy { get; set; }
            public class DescribeClustersV1ResponseBodyClustersOperationPolicy : TeaModel {
                /// <summary>
                /// <para>The automatic cluster upgrade configuration.</para>
                /// </summary>
                [NameInMap("cluster_auto_upgrade")]
                [Validation(Required=false)]
                public DescribeClustersV1ResponseBodyClustersOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
                public class DescribeClustersV1ResponseBodyClustersOperationPolicyClusterAutoUpgrade : TeaModel {
                    /// <summary>
                    /// <para>The frequency of automatic cluster upgrades. For more information, see <a href="https://help.aliyun.com/document_detail/2712866.html">Upgrade frequency</a>.</para>
                    /// <para>Valid values:</para>
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
            /// <para>The Private Zone configuration of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Private Zone is enabled.</description></item>
            /// <item><description><c>false</c>: Private Zone is not enabled.</description></item>
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
            /// <para>The cluster subtype.</para>
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
            /// <item><description><c>iptables</c>: a mature and stable kube-proxy mode. Uses iptables rules for service discovery and load balancing of Kubernetes Services. Performance is moderate and affected by scale. Suitable for clusters with a small number of Services.</description></item>
            /// <item><description><c>ipvs</c>: a high-performance kube-proxy mode. Uses the Linux IPVS module for service discovery and load balancing of Kubernetes Services. Suitable for clusters with a large number of Services that require high-performance load balancing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ipvs</para>
            /// </summary>
            [NameInMap("proxy_mode")]
            [Validation(Required=false)]
            public string ProxyMode { get; set; }

            /// <summary>
            /// <para>The region ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjm****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The security group ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2vcgwsrwgt5mp0yi****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The service CIDR block.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.21.xx.xx/20</para>
            /// </summary>
            [NameInMap("service_cidr")]
            [Validation(Required=false)]
            public string ServiceCidr { get; set; }

            /// <summary>
            /// <para>The current number of nodes in the cluster, including master nodes and worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The running state of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>initial</c>: The cluster is being created.</description></item>
            /// <item><description><c>failed</c>: The cluster failed to be created.</description></item>
            /// <item><description><c>running</c>: The cluster is running.</description></item>
            /// <item><description><c>updating</c>: The cluster is being updated.</description></item>
            /// <item><description><c>upgrading</c>: The cluster is being upgraded.</description></item>
            /// <item><description><c>removing</c>: Nodes are being removed.</description></item>
            /// <item><description><c>draining</c>: Nodes are being drained.</description></item>
            /// <item><description><c>scaling</c>: The cluster is being scaled.</description></item>
            /// <item><description><c>inactive</c>: The cluster is inactive.</description></item>
            /// <item><description><c>unavailable</c>: The cluster is unavailable.</description></item>
            /// <item><description><c>deleting</c>: The cluster is being deleted.</description></item>
            /// <item><description><c>deleted</c>: The cluster has been deleted.</description></item>
            /// <item><description><c>delete_failed</c>: The cluster failed to be deleted.</description></item>
            /// <item><description><c>waiting</c>: The cluster is in the accessed state, waiting to be connected.</description></item>
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
            /// <para>[This field is deprecated] Use container_cidr to obtain the pod CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("subnet_cidr")]
            [Validation(Required=false)]
            [Obsolete]
            public string SubnetCidr { get; set; }

            /// <summary>
            /// <para>The resource tags of the cluster.</para>
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
            /// <para>The time when the cluster was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-07T09:57:26+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// <para>The VPC ID of the cluster.</para>
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
            /// <para>The vSwitch ID of the cluster.</para>
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
            /// <para>The name of the worker RAM role that authorizes ECS instances to serve as cluster worker nodes.</para>
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
            /// <para>The zone ID of the cluster.</para>
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
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of results.</para>
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
