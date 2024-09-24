// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterDetailResponseBody : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// After you set `cluster_type` to `ManagedKubernetes` and configure the `profile` parameter, you can further specify the edition of the cluster.
        /// 
        /// *   `ack.pro.small`: Pro.
        /// *   `ack.standard`: Basic. If you leave the parameter empty, the Basic edition is selected.
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// *   `Kubernetes`: ACK dedicated cluster.
        /// *   `ManagedKubernetes`: ACK managed cluster. ACK managed clusters include ACK Basic clusters, ACK Pro clusters, ACK Serverless clusters (Basic and Pro), ACK Edge clusters (Basic and Pro), and ACK Lingjun clusters (Pro).
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
        /// The current Kubernetes version of the cluster. For more information about the Kubernetes versions supported by ACK, see [Release notes for Kubernetes versions](https://help.aliyun.com/document_detail/185269.html).
        /// </summary>
        [NameInMap("current_version")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Indicates whether deletion protection is enabled for the cluster. If deletion protection is enabled, the cluster cannot be deleted in the Container Service console or by calling API operations. Valid values:
        /// 
        /// *   `true`: deletion protection is enabled for the cluster. This way, the cluster cannot be deleted in the Container Service console or by calling API operations.
        /// *   `false`: deletion protection is disabled for the cluster. This way, the cluster can be deleted in the Container Service console or by calling API operations.
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

        [NameInMap("external_loadbalancer_id")]
        [Validation(Required=false)]
        public string ExternalLoadbalancerId { get; set; }

        /// <summary>
        /// The initial Kubernetes version of the cluster.
        /// </summary>
        [NameInMap("init_version")]
        [Validation(Required=false)]
        public string InitVersion { get; set; }

        /// <summary>
        /// The maintenance window of the cluster. This feature is available only in ACK Pro clusters.
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// The endpoints of the cluster, including an internal endpoint and a public endpoint.
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
        /// The name of the cluster.
        /// 
        /// The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). The name cannot start with a hyphen (-).
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("network_mode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        [NameInMap("next_version")]
        [Validation(Required=false)]
        public string NextVersion { get; set; }

        /// <summary>
        /// The ROS parameters of the cluster.
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("private_zone")]
        [Validation(Required=false)]
        public bool? PrivateZone { get; set; }

        /// <summary>
        /// If you set `cluster_type` to `ManagedKubernetes`, an ACK managed cluster is created. In this case, you can further specify the cluster edition.
        /// 
        /// *   `Default`. ACK managed cluster. ACK managed clusters include ACK Basic clusters and ACK Pro clusters.
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
        /// The ID of the security group to which the cluster belongs.
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The number of nodes in the cluster. Master nodes and worker nodes are included.
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
        /// *   `waiting`: The cluster is waiting for connection requests.
        /// *   `disconnected`: The cluster is disconnected.
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
        /// The pod CIDR block cannot overlap with the CIDR block of the VPC or the CIDR blocks of the clusters in the VPC.
        /// 
        /// For more information, see [Plan CIDR blocks for an ACK cluster](https://help.aliyun.com/document_detail/186964.html).
        /// </summary>
        [NameInMap("subnet_cidr")]
        [Validation(Required=false)]
        public string SubnetCidr { get; set; }

        /// <summary>
        /// The resource tags of the cluster.
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
        /// The name of the worker Resource Access Management (RAM) role. The RAM role is assigned to the worker nodes of the cluster to allow the worker nodes to manage Elastic Compute Service (ECS) instances.
        /// </summary>
        [NameInMap("worker_ram_role_name")]
        [Validation(Required=false)]
        public string WorkerRamRoleName { get; set; }

        [NameInMap("zone_id")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
