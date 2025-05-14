// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersV1ResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried cluster details.</para>
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
            /// <para>After you set <c>cluster_type</c> to <c>ManagedKubernetes</c> and configure the <c>profile</c> parameter, you can further specify the edition of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>ack.pro.small</c>: ACK Pro cluster.</description></item>
            /// <item><description><c>ack.standard</c>: ACK Basic cluster. If you leave the parameter empty, ACK Basic cluster is selected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ack.standard</para>
            /// </summary>
            [NameInMap("cluster_spec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><c>Kubernetes</c>: ACK dedicated cluster.</description></item>
            /// <item><description><c>ManagedKubernetes</c>: ACK managed cluster. ACK managed clusters include ACK Basic clusters, ACK Pro clusters, ACK Serverless Basic clusters, ACK Serverless Pro clusters, ACK Edge Basic clusters, ACK Edge Pro clusters, and ACK Lingjun Pro clusters.</description></item>
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
            /// <para>The pod CIDR block and the configuration of the Flannel network plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.20.0.0/16</para>
            /// </summary>
            [NameInMap("container_cidr")]
            [Validation(Required=false)]
            public string ContainerCidr { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-08-20T10:51:29+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The Kubernetes version of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.16.9-aliyun.1</para>
            /// </summary>
            [NameInMap("current_version")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable cluster deletion protection. If this option is enabled, the cluster cannot be deleted in the ACK console or by calling API operations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables deletion protection for the cluster. This way, the cluster cannot be deleted in the ACK console or by calling API operations.</description></item>
            /// <item><description><c>false</c>: disables deletion protection for the cluster. This way, the cluster can be deleted in the ACK console or by calling API operations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("deletion_protection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The Docker version that is used by the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19.03.5</para>
            /// </summary>
            [NameInMap("docker_version")]
            [Validation(Required=false)]
            public string DockerVersion { get; set; }

            /// <summary>
            /// <para>The ID of the Server Load Balancer (SLB) instance that is used by the Ingresses of the cluster.</para>
            /// <para>The default SLB specification is slb.s1.small, which belongs to the high-performance instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-2vcrbmlevo6kjpgch****</para>
            /// </summary>
            [NameInMap("external_loadbalancer_id")]
            [Validation(Required=false)]
            public string ExternalLoadbalancerId { get; set; }

            /// <summary>
            /// <para>The Kubernetes version of the cluster. The Kubernetes versions supported by ACK are the same as the Kubernetes versions supported by open source Kubernetes. We recommend that you specify the latest Kubernetes version. If you do not configure this parameter, the latest Kubernetes version is used.</para>
            /// <para>You can create clusters that run the latest two Kubernetes versions in the ACK console. You can call the API operation to create clusters of other Kubernetes versions. For more information about the Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Release notes for Kubernetes versions</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.16.9-aliyun.1</para>
            /// </summary>
            [NameInMap("init_version")]
            [Validation(Required=false)]
            public string InitVersion { get; set; }

            /// <summary>
            /// <para>The IP stack of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ipv4: The cluster is an IPv4 cluster.</description></item>
            /// <item><description>dual: The cluster is a dual-stack cluster.</description></item>
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
            /// <para>The address of the cluster API server. It includes an internal endpoint and a public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;api_server_endpoint\&quot;:\&quot;\&quot;,\&quot;intranet_api_server_endpoint\&quot;:\&quot;<a href="https://192.168.0.251:6443%5C%5C%22%7D">https://192.168.0.251:6443\\&quot;}</a></para>
            /// </summary>
            [NameInMap("master_url")]
            [Validation(Required=false)]
            public string MasterUrl { get; set; }

            /// <summary>
            /// <para>The metadata of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Addons\&quot;:[{\&quot;config\&quot;:***}</para>
            /// </summary>
            [NameInMap("meta_data")]
            [Validation(Required=false)]
            public string MetaData { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// <para>The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). The name cannot start with a hyphen (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster-demo</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network mode of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>classic</c>: classic network.</description></item>
            /// <item><description><c>vpc</c>: virtual private cloud (VPC).</description></item>
            /// <item><description><c>overlay</c>: overlay network.</description></item>
            /// <item><description><c>calico</c>: network powered by Calico.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("network_mode")]
            [Validation(Required=false)]
            public string NetworkMode { get; set; }

            /// <summary>
            /// <para>The Kubernetes version to which the cluster can be updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.18.8-aliyun.1</para>
            /// </summary>
            [NameInMap("next_version")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            /// <summary>
            /// <para>The automatic O\&amp;M policy of the cluster.</para>
            /// </summary>
            [NameInMap("operation_policy")]
            [Validation(Required=false)]
            public DescribeClustersV1ResponseBodyClustersOperationPolicy OperationPolicy { get; set; }
            public class DescribeClustersV1ResponseBodyClustersOperationPolicy : TeaModel {
                /// <summary>
                /// <para>The configurations of auto cluster update.</para>
                /// </summary>
                [NameInMap("cluster_auto_upgrade")]
                [Validation(Required=false)]
                public DescribeClustersV1ResponseBodyClustersOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
                public class DescribeClustersV1ResponseBodyClustersOperationPolicyClusterAutoUpgrade : TeaModel {
                    /// <summary>
                    /// <para>The frequency of auto cluster updates. For more information, see <a href="https://help.aliyun.com/document_detail/2712866.html">Update frequency</a>.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>patch: the latest patch version.</description></item>
                    /// <item><description>stables: the second-latest minor version.</description></item>
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
                    /// <para>Specifies whether to enable auto cluster update.</para>
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
            /// <para>Indicates whether Alibaba Cloud DNS PrivateZone is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Alibaba Cloud DNS PrivateZone is enabled.</description></item>
            /// <item><description><c>false</c>: Alibaba Cloud DNS PrivateZone is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("private_zone")]
            [Validation(Required=false)]
            public bool? PrivateZone { get; set; }

            /// <summary>
            /// <para>The cluster identifier. Valid values:</para>
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
            /// <para>The Kube-proxy mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>iptables</c>: a mature and stable kube-proxy mode that uses iptables rules to conduct Service discovery and load balancing. The performance of this mode is limited by the size of the cluster. This mode is suitable for clusters that run a small number of Services.</description></item>
            /// <item><description><c>ipvs</c>: provides high performance and uses IP Virtual Server (IPVS). This allows you to configure service discovery and load balancing. This mode is suitable for clusters that are required to run a large number of services. We recommend that you use this mode in scenarios that require high load balancing performance.</description></item>
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
            /// <para>The ID of the resource group to which the cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjm****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the security group of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2vcgwsrwgt5mp0yi****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The Service CIDR block.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.21.0.0/20</para>
            /// </summary>
            [NameInMap("service_cidr")]
            [Validation(Required=false)]
            public string ServiceCidr { get; set; }

            /// <summary>
            /// <para>The number of nodes in the cluster, including control planes and worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>initial</c>: The cluster is being created.</description></item>
            /// <item><description><c>failed</c>: The cluster failed to be created.</description></item>
            /// <item><description><c>running</c>: The cluster is running.</description></item>
            /// <item><description><c>upgrading</c>: The cluster is undergoing an upgrade.</description></item>
            /// <item><description><c>updating</c>: Cluster specification changes are being applied.</description></item>
            /// <item><description><c>removing</c>: Nodes are being removed from the node pool.</description></item>
            /// <item><description><c>draining</c>: Node draining is in progress.</description></item>
            /// <item><description><c>scaling</c>: Auto-scaling operation is in progress for the cluster.</description></item>
            /// <item><description><c>stopped</c>: The cluster has stopped running.</description></item>
            /// <item><description><c>deleting</c>: The cluster is being deleted.</description></item>
            /// <item><description><c>deleted</c>: The cluster has been deleted.</description></item>
            /// <item><description><c>delete_failed</c>: The cluster failed to be deleted.</description></item>
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
            /// <para>Tis parameter is deprecated. Use the container_cidr parameter to obtain the pod CIDR block. The pod CIDR block. It must be a valid and private CIDR block, and must be one of the following CIDR blocks or their subnets:</para>
            /// <list type="bullet">
            /// <item><description>10.0.0.0/8</description></item>
            /// <item><description>172.16-31.0.0/12-16</description></item>
            /// <item><description>192.168.0.0/16</description></item>
            /// </list>
            /// <para>The pod CIDR block cannot overlap with the CIDR block of the VPC in which the cluster is deployed and the CIDR blocks of existing clusters in the VPC. You cannot modify the pod CIDR block after you create the cluster.</para>
            /// <para>For more information about the network planning of Container Service for Kubernetes (ACK) clusters, see <a href="https://help.aliyun.com/document_detail/86500.html">Plan CIDR blocks for an ACK cluster</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.21.0.0/16</para>
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
            /// <para>The time zone</para>
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
            /// <para>2020-09-16T11:09:55+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// <para>The ID of the VPC where the cluster is deployed. This parameter is required when you create a cluster.</para>
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
            /// <para>The IDs of the vSwitches. You can select one to three vSwitches when you create a cluster. To ensure the high availability of the cluster, we recommend that you select vSwitches in different zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2vc41xuumx5z2rdma****,vsw-2vc41xuumx5z2rdma****</para>
            /// </summary>
            [NameInMap("vswitch_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The vSwitches of the control planes.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

            /// <summary>
            /// <para>The name of the worker Resource Access Management (RAM) role. The RAM role is assigned to the worker nodes of the cluster to allow the worker nodes to manage ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KubernetesWorkerRole-ec87d15b-edca-4302-933f-c8a16bf0****</para>
            /// </summary>
            [NameInMap("worker_ram_role_name")]
            [Validation(Required=false)]
            public string WorkerRamRoleName { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the cluster is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-b</para>
            /// </summary>
            [NameInMap("zone_id")]
            [Validation(Required=false)]
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
            /// <para>The total number of entries returned.</para>
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
