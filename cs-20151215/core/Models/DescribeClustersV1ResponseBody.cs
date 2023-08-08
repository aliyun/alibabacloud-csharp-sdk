// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersV1ResponseBody : TeaModel {
        /// <summary>
        /// The list of the details of the queried cluster.
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersV1ResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersV1ResponseBodyClusters : TeaModel {
            /// <summary>
            /// The ID of the queried cluster.
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The type of the managed Kubernetes cluster. This parameter is returned for a managed Kubernetes cluster. Valid values:
            /// 
            /// *   `ack.pro.small`: professional managed Kubernetes cluster
            /// *   `ack.standard`: standard managed Kubernetes cluster
            /// </summary>
            [NameInMap("cluster_spec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// The type of the cluster. Valid values:
            /// 
            /// *   `Kubernetes`: dedicated Kubernetes cluster
            /// *   `ManagedKubernetes`: managed Kubernetes cluster
            /// *   `Ask`: ASK cluster
            /// *   `ExternalKubernetes`: registered external cluster
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
            /// Indicates whether deletion protection is enabled for the cluster. After deletion protection is enabled, the cluster cannot be deleted in the console or by calling API operations. Valid values:
            /// 
            /// *   `true`: deletion protection is enabled for the cluster. The cluster cannot be deleted in the ACK console or by calling API operations.
            /// *   `false`: deletion protection is disabled for the cluster. The cluster can be deleted in the ACK console or by calling API operations.
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
            /// The ID of the Server Load Balancer (SLB) instance that is used for the Ingress of the cluster.
            /// 
            /// The default SLB specification is slb.s1.small, which belongs to the high-performance instance type.
            /// </summary>
            [NameInMap("external_loadbalancer_id")]
            [Validation(Required=false)]
            public string ExternalLoadbalancerId { get; set; }

            /// <summary>
            /// The Kubernetes version of the cluster. The Kubernetes versions provided by ACK are consistent with the open source Kubernetes versions. We recommend that you select the latest Kubernetes version. If you do not specify a Kubernetes version, the latest Kubernetes version is used by default.
            /// 
            /// You can create clusters of the latest two Kubernetes versions in the ACK console. You can create ACK clusters of earlier Kubernetes versions by calling API operations. For more information about the Kubernetes versions supported by ACK, see [Release notes for Kubernetes versions](~~185269~~).
            /// </summary>
            [NameInMap("init_version")]
            [Validation(Required=false)]
            public string InitVersion { get; set; }

            /// <summary>
            /// The maintenance window of the cluster. This feature is available only in professional managed Kubernetes clusters.
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
            /// The name of the cluster.
            /// 
            /// The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). It cannot start with a hyphen (-).
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The network mode of the cluster. Valid values:
            /// 
            /// *   `classic`: classic network
            /// *   `vpc`: virtual private cloud (VPC)
            /// *   `overlay`: overlay network
            /// *   `calico`: network powered by Calico
            /// </summary>
            [NameInMap("network_mode")]
            [Validation(Required=false)]
            public string NetworkMode { get; set; }

            /// <summary>
            /// The Kubernetes version to which the cluster can be upgraded.
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
            /// The identifier of the cluster. Valid values:
            /// 
            /// *   `Edge`: The cluster is a managed edge Kubernetes cluster.
            /// *   `Default`: The cluster is not a managed edge Kubernetes cluster.
            /// </summary>
            [NameInMap("profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            /// <summary>
            /// The ID of the region where the cluster is deployed.
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
            /// The ID of the security group to which the instances of the cluster belong.
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
            /// *   `updating`: The cluster is being upgraded.
            /// *   `updating_failed`: The cluster failed to be upgraded.
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
            /// The CIDR block of pods cannot overlap with the CIDR block of the VPC in which the cluster is deployed and the CIDR blocks of existing clusters in the VPC. You cannot modify the pod CIDR block after the cluster is created.
            /// 
            /// For more information about subnetting for ACK clusters, see [Plan CIDR blocks for ACK clusters in a VPC](~~86500~~).
            /// </summary>
            [NameInMap("subnet_cidr")]
            [Validation(Required=false)]
            public string SubnetCidr { get; set; }

            /// <summary>
            /// The labels of the cluster.
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
            /// The ID of the VPC where the cluster is deployed. You must specify a VPC when you create a cluster.
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
            /// The name of the worker Resource Access Management (RAM) role. The RAM role is assigned to the worker nodes that are created on Elastic Compute Service (ECS) instances.
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
        /// The pagination details.
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeClustersV1ResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeClustersV1ResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of the returned page.
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
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
