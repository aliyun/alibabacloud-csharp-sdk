// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersV1ResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The list of cluster information.</para>
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersV1ResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersV1ResponseBodyClusters : Darabonba.Model {
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
            /// <para>The cluster specifications.</para>
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
            /// <para>The Pod network CIDR block for Flannel network configuration.</para>
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
            /// <para>Specifies whether deletion protection is enabled for the cluster to prevent accidental deletion through the console or API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Deletion protection is enabled. The cluster cannot be deleted through the console or API.</description></item>
            /// <item><description>false: Deletion protection is disabled. The cluster can be deleted through the console or API.</description></item>
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
            /// <para>The Docker version used by the cluster.</para>
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
            /// <para>The ID of the Server Load Balancer (SLB) instance for the Ingress in the cluster.</para>
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
            /// <para>The initial version of the cluster. For the Kubernetes versions supported by ACK, refer to <a href="https://help.aliyun.com/document_detail/185269.html">Overview of Kubernetes versions</a>.</para>
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
            /// <item><description>ipv4: Creates a cluster that supports only the IPv4 protocol stack.</description></item>
            /// <item><description>dual: Creates a cluster that supports both IPv4 and IPv6 protocol stacks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("ip_stack")]
            [Validation(Required=false)]
            public string IpStack { get; set; }

            /// <summary>
            /// <para>The maintenance window of the cluster. This feature takes effect only in ACK managed clusters and ACK Serverless clusters.</para>
            /// </summary>
            [NameInMap("maintenance_window")]
            [Validation(Required=false)]
            public MaintenanceWindow MaintenanceWindow { get; set; }

            /// <summary>
            /// <para>The access endpoints of the cluster API server, including the internal network access address and the public network access address.</para>
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
            /// <para>The cluster name. Fuzzy match is supported.</para>
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
            /// <item><description>classic: classic network</description></item>
            /// <item><description>vpc: VPC</description></item>
            /// <item><description>overlay: overlay network</description></item>
            /// <item><description>calico: Calico network</description></item>
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
            /// <para>The automated O&amp;M policy of the cluster.</para>
            /// </summary>
            [NameInMap("operation_policy")]
            [Validation(Required=false)]
            public DescribeClustersV1ResponseBodyClustersOperationPolicy OperationPolicy { get; set; }
            public class DescribeClustersV1ResponseBodyClustersOperationPolicy : Darabonba.Model {
                /// <summary>
                /// <para>The auto-upgrade settings for the cluster.</para>
                /// </summary>
                [NameInMap("cluster_auto_upgrade")]
                [Validation(Required=false)]
                public DescribeClustersV1ResponseBodyClustersOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
                public class DescribeClustersV1ResponseBodyClustersOperationPolicyClusterAutoUpgrade : Darabonba.Model {
                    /// <summary>
                    /// <para>The auto-upgrade channel for the cluster. For more information, refer to <a href="https://help.aliyun.com/document_detail/2712866.html">Upgrade channels</a>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>patch: The latest patch version.</description></item>
                    /// <item><description>stable: The second latest minor version.</description></item>
                    /// <item><description>rapid: The latest minor version.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>patch</para>
                    /// </summary>
                    [NameInMap("channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    /// <summary>
                    /// <para>Specifies whether auto-upgrade is enabled for the cluster.</para>
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
            /// <item><description>true: Private Zone is enabled.</description></item>
            /// <item><description>false: Private Zone is disabled.</description></item>
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
            /// <para>The kube-proxy mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>iptables: The mature and stable kube-proxy mode. Service discovery and load balancing for Kubernetes services are configured by using iptables rules. This mode provides average performance and is affected by the cluster scale. It is suitable for clusters with a small number of services.</description></item>
            /// <item><description>ipvs: The high-performance kube-proxy mode. Service discovery and load balancing for Kubernetes services are configured by using the Linux IPVS module. This mode is suitable for clusters with a large number of services and scenarios that require high-performance load balancing.</description></item>
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
            /// <para>The CIDR block of the service network.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.21.xx.xx/20</para>
            /// </summary>
            [NameInMap("service_cidr")]
            [Validation(Required=false)]
            public string ServiceCidr { get; set; }

            /// <summary>
            /// <para>The current number of nodes in the cluster, including the master node and worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The running status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>initial: The cluster is being created.</description></item>
            /// <item><description>failed: The cluster failed to be created.</description></item>
            /// <item><description>running: The cluster is running.</description></item>
            /// <item><description>updating: The cluster is being updated.</description></item>
            /// <item><description>upgrading: The cluster is being upgraded.</description></item>
            /// <item><description>removing: Nodes are being removed.</description></item>
            /// <item><description>draining: Nodes are being drained.</description></item>
            /// <item><description>scaling: The cluster is being scaled.</description></item>
            /// <item><description>inactive: The cluster is inactive.</description></item>
            /// <item><description>unavailable: The cluster is unavailable.</description></item>
            /// <item><description>deleting: The cluster is being deleted.</description></item>
            /// <item><description>deleted: The cluster is deleted.</description></item>
            /// <item><description>delete_failed: The cluster failed to be deleted.</description></item>
            /// <item><description>waiting: The cluster is waiting for the accessed state.</description></item>
            /// <item><description>disconnected: The cluster is disconnected.</description></item>
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
            /// <para><b>[Deprecated]</b> Use container_cidr to obtain the Pod network CIDR block.</para>
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
            /// <para>The ID of the virtual private cloud (VPC) where the cluster is deployed.</para>
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
            /// <para>The ID of the vSwitch used by the cluster.</para>
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
            /// <para>The name of the worker RAM role, which authorizes ECS instances to serve as worker nodes in the cluster.</para>
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
            /// <para>The ID of the zone to which the cluster belongs.</para>
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
        public class DescribeClustersV1ResponseBodyPageInfo : Darabonba.Model {
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

