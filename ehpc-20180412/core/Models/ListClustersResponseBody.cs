// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListClustersResponseBody : TeaModel {
        /// <summary>
        /// The list of clusters.
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public ListClustersResponseBodyClusters Clusters { get; set; }
        public class ListClustersResponseBodyClusters : TeaModel {
            [NameInMap("ClusterInfoSimple")]
            [Validation(Required=false)]
            public List<ListClustersResponseBodyClustersClusterInfoSimple> ClusterInfoSimple { get; set; }
            public class ListClustersResponseBodyClustersClusterInfoSimple : TeaModel {
                /// <summary>
                /// The server type of the account. Valid values:
                /// 
                /// *   nis
                /// *   ldap
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// The operating system tag of the base image. The tag was used only by the management node.
                /// </summary>
                [NameInMap("BaseOsTag")]
                [Validation(Required=false)]
                public string BaseOsTag { get; set; }

                /// <summary>
                /// The version of the client.
                /// </summary>
                [NameInMap("ClientVersion")]
                [Validation(Required=false)]
                public string ClientVersion { get; set; }

                /// <summary>
                /// The maximum hourly price for the ECS instance under the compute node. The return value can be accurate to three decimal places.
                /// </summary>
                [NameInMap("ComputeSpotPriceLimit")]
                [Validation(Required=false)]
                public float? ComputeSpotPriceLimit { get; set; }

                /// <summary>
                /// The bidding method of the compute nodes. Valid values:
                /// 
                /// *   NoSpot: The instances of the compute node are pay-as-you-go instances.
                /// *   SpotWithPriceLimit: The instances of the compute node are preemptible instances. These types of instances have a specified maximum hourly price.
                /// *   SpotAsPriceGo: The instances of the compute node are preemptible instances. The price of these instances is based on the current market price.
                /// </summary>
                [NameInMap("ComputeSpotStrategy")]
                [Validation(Required=false)]
                public string ComputeSpotStrategy { get; set; }

                /// <summary>
                /// The information about compute nodes.
                /// </summary>
                [NameInMap("Computes")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleComputes Computes { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleComputes : TeaModel {
                    /// <summary>
                    /// The number of abnormal nodes.
                    /// </summary>
                    [NameInMap("ExceptionCount")]
                    [Validation(Required=false)]
                    public int? ExceptionCount { get; set; }

                    /// <summary>
                    /// The number of normal nodes.
                    /// </summary>
                    [NameInMap("NormalCount")]
                    [Validation(Required=false)]
                    public int? NormalCount { get; set; }

                    /// <summary>
                    /// The number of nodes that are being used in the queue. This includes those that are being initialized, installed, or released.
                    /// </summary>
                    [NameInMap("OperatingCount")]
                    [Validation(Required=false)]
                    public int? OperatingCount { get; set; }

                    /// <summary>
                    /// The number of stopped nodes.
                    /// </summary>
                    [NameInMap("StoppedCount")]
                    [Validation(Required=false)]
                    public int? StoppedCount { get; set; }

                    /// <summary>
                    /// The total number of nodes.
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                }

                /// <summary>
                /// The number of compute nodes in the cluster.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The time when the instance was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The mode in which the cluster was deployed. Valid values:
                /// 
                /// *   Standard: An account node, a scheduling node, a logon node, and multiple compute nodes are separately deployed.
                /// *   Advanced: Two high availability (HA) account nodes, two HA scheduler nodes, one logon node, and multiple compute nodes are separately deployed.
                /// *   Simple: A management node, a logon node, and multiple compute nodes are deployed. The management node consists of an account node and a scheduling node. The logon node and compute nodes are separately deployed.
                /// *   Tiny: A management node and multiple compute nodes are deployed. The management node consists of an account node, a scheduling node, and a logon node. The compute nodes are separately deployed.
                /// </summary>
                [NameInMap("DeployMode")]
                [Validation(Required=false)]
                public string DeployMode { get; set; }

                /// <summary>
                /// The description of the cluster.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The version of E-HPC.
                /// </summary>
                [NameInMap("EhpcVersion")]
                [Validation(Required=false)]
                public string EhpcVersion { get; set; }

                /// <summary>
                /// Indicates whether plug-ins were used in the cluster. Valid values:
                /// 
                /// *   true: Plug-ins are used.
                /// *   false: Plug-ins are not used.
                /// 
                /// Default value: false
                /// </summary>
                [NameInMap("HasPlugin")]
                [Validation(Required=false)]
                public bool? HasPlugin { get; set; }

                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The ID of the image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The type of the image. Valid values:
                /// 
                /// *   system: public image
                /// *   self: custom image
                /// *   others: shared image
                /// *   marketplace: Alibaba Cloud Marketplace image
                /// </summary>
                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                /// <summary>
                /// The billing method of the nodes in the cluster. Valid values:
                /// 
                /// *   PostPaid: pay-as-you-go
                /// *   PrePaid: subscription
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// The instance type of the compute nodes.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// Indicates whether a scaling group was enabled. Valid values:
                /// 
                /// *   true: A scaling group is enabled.
                /// *   false: No scaling group is enabled.
                /// </summary>
                [NameInMap("IsComputeEss")]
                [Validation(Required=false)]
                public bool? IsComputeEss { get; set; }

                /// <summary>
                /// The location where the cluster was deployed. Valid values:
                /// 
                /// *   OnPremise: The cluster is deployed on a hybrid cloud.
                /// *   PublicCloud: The cluster is deployed on a public cloud.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The list of logon nodes.
                /// </summary>
                [NameInMap("LoginNodes")]
                [Validation(Required=false)]
                public string LoginNodes { get; set; }

                /// <summary>
                /// The list of management nodes.
                /// </summary>
                [NameInMap("Managers")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleManagers Managers { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleManagers : TeaModel {
                    /// <summary>
                    /// The number of abnormal nodes.
                    /// </summary>
                    [NameInMap("ExceptionCount")]
                    [Validation(Required=false)]
                    public int? ExceptionCount { get; set; }

                    /// <summary>
                    /// The number of normal nodes.
                    /// </summary>
                    [NameInMap("NormalCount")]
                    [Validation(Required=false)]
                    public int? NormalCount { get; set; }

                    /// <summary>
                    /// The number of nodes that are being used in the queue. This includes those that are being initialized, installed, or released.
                    /// </summary>
                    [NameInMap("OperatingCount")]
                    [Validation(Required=false)]
                    public int? OperatingCount { get; set; }

                    /// <summary>
                    /// The number of stopped nodes.
                    /// </summary>
                    [NameInMap("StoppedCount")]
                    [Validation(Required=false)]
                    public int? StoppedCount { get; set; }

                    /// <summary>
                    /// The total number of management nodes.
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                }

                /// <summary>
                /// The name of the cluster.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The prefix of the node.
                /// </summary>
                [NameInMap("NodePrefix")]
                [Validation(Required=false)]
                public string NodePrefix { get; set; }

                /// <summary>
                /// The suffix of the node.
                /// </summary>
                [NameInMap("NodeSuffix")]
                [Validation(Required=false)]
                public string NodeSuffix { get; set; }

                /// <summary>
                /// The operating system tag of the image.
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The type of the scheduler. Valid values:
                /// 
                /// *   pbs
                /// *   slurm
                /// *   opengridscheduler
                /// *   deadline
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// The status of the cluster. Valid values:
                /// 
                /// *   uninit: The cluster is not initialized.
                /// *   creating: The cluster is being created.
                /// *   init: The cluster is being initialized.
                /// *   running: The cluster is running.
                /// *   exception: The cluster encounters an exception.
                /// *   releasing: The cluster is being released.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The statistics of all resources in the cluster.
                /// </summary>
                [NameInMap("TotalResources")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleTotalResources TotalResources { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleTotalResources : TeaModel {
                    /// <summary>
                    /// The number of CPU cores. Unit: cores.
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// The number of GPU cards. Unit: cards.
                    /// </summary>
                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    /// <summary>
                    /// The memory size. Unit: MiB.
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }

                /// <summary>
                /// The number of consumed resources in the cluster.
                /// </summary>
                [NameInMap("UsedResources")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleUsedResources UsedResources { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleUsedResources : TeaModel {
                    /// <summary>
                    /// The number of CPU cores. Unit: cores.
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// The number of GPU cards. Unit: cards.
                    /// </summary>
                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    /// <summary>
                    /// The memory size. Unit: MiB.
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC).
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The ID of the zone.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
