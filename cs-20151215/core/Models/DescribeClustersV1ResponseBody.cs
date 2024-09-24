// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersV1ResponseBody : TeaModel {
        /// <summary>
        /// The details of the clusters.
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersV1ResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersV1ResponseBodyClusters : TeaModel {
            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// After you set `cluster_type` to `ManagedKubernetes` and configure the `profile` parameter, you can further specify the edition of the cluster. Valid values:
            /// 
            /// *   `ack.pro.small`: ACK Pro cluster.
            /// *   `ack.standard`: ACK Basic cluster. If you leave the parameter empty, ACK Basic cluster is selected.
            /// </summary>
            [NameInMap("cluster_spec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// *   `Kubernetes`: ACK dedicated cluster.
            /// *   `ManagedKubernetes`: ACK managed cluster. ACK managed clusters include ACK Basic clusters, ACK Pro clusters, ACK Serverless Basic clusters, ACK Serverless Pro clusters, ACK Edge Basic clusters, ACK Edge Pro clusters, and ACK Lingjun Pro clusters.
            /// *   `ExternalKubernetes`: registered cluster.
            /// </summary>
            [NameInMap("cluster_type")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The time when the cluster was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// The Kubernetes version of the cluster.
            /// </summary>
            [NameInMap("current_version")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// Specifies whether to enable cluster deletion protection. If this option is enabled, the cluster cannot be deleted in the ACK console or by calling API operations. Valid values:
            /// 
            /// *   `true`: enables deletion protection for the cluster. This way, the cluster cannot be deleted in the ACK console or by calling API operations.
            /// *   `false`: disables deletion protection for the cluster. This way, the cluster can be deleted in the ACK console or by calling API operations.
            /// </summary>
            [NameInMap("deletion_protection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// The Docker version that is used by the cluster.
            /// </summary>
            [NameInMap("docker_version")]
            [Validation(Required=false)]
            public string DockerVersion { get; set; }

            /// <summary>
            /// The ID of the Server Load Balancer (SLB) instance that is used by the Ingresses of the cluster.
            /// 
            /// The default SLB specification is slb.s1.small, which belongs to the high-performance instance type.
            /// </summary>
            [NameInMap("external_loadbalancer_id")]
            [Validation(Required=false)]
            public string ExternalLoadbalancerId { get; set; }

            /// <summary>
            /// The Kubernetes version of the cluster. The Kubernetes versions supported by ACK are the same as the Kubernetes versions supported by open source Kubernetes. We recommend that you specify the latest Kubernetes version. If you do not configure this parameter, the latest Kubernetes version is used.
            /// 
            /// You can create clusters that run the latest two Kubernetes versions in the ACK console. You can call the API operation to create clusters of other Kubernetes versions. For more information about the Kubernetes versions supported by ACK, see [Release notes for Kubernetes versions](https://help.aliyun.com/document_detail/185269.html).
            /// </summary>
            [NameInMap("init_version")]
            [Validation(Required=false)]
            public string InitVersion { get; set; }

            /// <summary>
            /// The maintenance window of the cluster. This feature is available only for ACK managed clusters and ACK Serverless clusters.
            /// </summary>
            [NameInMap("maintenance_window")]
            [Validation(Required=false)]
            public MaintenanceWindow MaintenanceWindow { get; set; }

            /// <summary>
            /// The address of the cluster API server. It includes an internal endpoint and a public endpoint.
            /// </summary>
            [NameInMap("master_url")]
            [Validation(Required=false)]
            public string MasterUrl { get; set; }

            /// <summary>
            /// The metadata of the cluster.
            /// </summary>
            [NameInMap("meta_data")]
            [Validation(Required=false)]
            public string MetaData { get; set; }

            /// <summary>
            /// The cluster name.
            /// 
            /// The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). The name cannot start with a hyphen (-).
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The network mode of the cluster. Valid values:
            /// 
            /// *   `classic`: classic network.
            /// *   `vpc`: virtual private cloud (VPC).
            /// *   `overlay`: overlay network.
            /// *   `calico`: network powered by Calico.
            /// </summary>
            [NameInMap("network_mode")]
            [Validation(Required=false)]
            public string NetworkMode { get; set; }

            /// <summary>
            /// The Kubernetes version to which the cluster can be updated.
            /// </summary>
            [NameInMap("next_version")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            /// <summary>
            /// Indicates whether Alibaba Cloud DNS PrivateZone is enabled. Valid values:
            /// 
            /// *   `true`: Alibaba Cloud DNS PrivateZone is enabled.
            /// *   `false`: Alibaba Cloud DNS PrivateZone is disabled.
            /// </summary>
            [NameInMap("private_zone")]
            [Validation(Required=false)]
            public bool? PrivateZone { get; set; }

            /// <summary>
            /// The cluster identifier. Valid values:
            /// 
            /// *   `Default`: ACK managed cluster. ACK managed clusters include ACK Basic clusters and ACK Pro clusters.
            /// *   `Edge`: ACK Edge cluster. ACK Edge clusters include ACK Edge Basic clusters and ACK Edge Pro clusters.
            /// *   `Serverless`: ACK Serverless cluster. ACK Serverless clusters include ACK Serverless Basic clusters and ACK Serverless Pro clusters.
            /// *   `Lingjun`: ACK Lingjun Pro cluster.
            /// </summary>
            [NameInMap("profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            /// <summary>
            /// The region ID of the cluster.
            /// </summary>
            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the cluster belongs.
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The ID of the security group of the cluster.
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The number of nodes in the cluster, including master nodes and worker nodes.
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The status of the cluster. Valid values:
            /// 
            /// *   `initial`: The cluster is being created.
            /// *   `failed`: The cluster failed to be created.
            /// *   `running`: The cluster is running.
            /// *   `updating`: The cluster is being updated.
            /// *   `updating_failed`: The cluster failed to be updated.
            /// *   `scaling`: The cluster is being scaled.
            /// *   `stopped`: The cluster is stopped.
            /// *   `deleting`: The cluster is being deleted.
            /// *   `deleted`: The cluster is deleted.
            /// *   `delete_failed`: The cluster failed to be deleted.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The pod CIDR block. It must be a valid and private CIDR block, and must be one of the following CIDR blocks or their subnets:
            /// 
            /// *   10.0.0.0/8
            /// *   172.16-31.0.0/12-16
            /// *   192.168.0.0/16
            /// 
            /// The pod CIDR block cannot overlap with the CIDR block of the VPC in which the cluster is deployed and the CIDR blocks of existing clusters in the VPC. You cannot modify the pod CIDR block after you create the cluster.
            /// 
            /// For more information about the network planning of ACK clusters, see [Plan CIDR blocks for an ACK cluster](https://help.aliyun.com/document_detail/86500.html).
            /// </summary>
            [NameInMap("subnet_cidr")]
            [Validation(Required=false)]
            public string SubnetCidr { get; set; }

            /// <summary>
            /// The resource labels of the cluster.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// The time when the cluster was updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// The ID of the VPC where the cluster is deployed. This parameter is required when you create a cluster.
            /// </summary>
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The IDs of the vSwitches. You can select one to three vSwitches when you create a cluster. We recommend that you select vSwitches in different zones to ensure high availability.
            /// </summary>
            [NameInMap("vswitch_id")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// The name of the worker Resource Access Management (RAM) role. The RAM role is assigned to the worker nodes of the cluster to allow the worker nodes to manage ECS instances.
            /// </summary>
            [NameInMap("worker_ram_role_name")]
            [Validation(Required=false)]
            public string WorkerRamRoleName { get; set; }

            /// <summary>
            /// The ID of the zone where the cluster is deployed.
            /// </summary>
            [NameInMap("zone_id")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeClustersV1ResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeClustersV1ResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
