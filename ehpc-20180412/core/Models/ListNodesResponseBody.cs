// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesResponseBody : TeaModel {
        /// <summary>
        /// The list of nodes.
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public ListNodesResponseBodyNodes Nodes { get; set; }
        public class ListNodesResponseBodyNodes : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyNodesNodeInfo> NodeInfo { get; set; }
            public class ListNodesResponseBodyNodesNodeInfo : TeaModel {
                /// <summary>
                /// The time when the node is added to the cluster.
                /// </summary>
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public string AddTime { get; set; }

                /// <summary>
                /// The mode in which the compute nodes are added. Valid values:
                /// 
                /// *   manual: The node is manually added.
                /// *   autoscale: The node is automatically added.
                /// </summary>
                [NameInMap("CreateMode")]
                [Validation(Required=false)]
                public string CreateMode { get; set; }

                /// <summary>
                /// Indicates whether the node is created by using E-HPC.
                /// 
                /// *   true: The node is created by using E-HPC.
                /// *   false: The node is not created by using E-HPC.
                /// </summary>
                [NameInMap("CreatedByEhpc")]
                [Validation(Required=false)]
                public bool? CreatedByEhpc { get; set; }

                /// <summary>
                /// Indicates whether the subscription node expired. For a pay-as-you-go node, false is returned.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// The time when the subscription node expires. For a pay-as-you-go node, a null value is returned.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The name of the task node.
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// Indicates whether hyper-threading is enabled.
                /// </summary>
                [NameInMap("HtEnabled")]
                [Validation(Required=false)]
                public bool? HtEnabled { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The ID of the custom image.
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
                /// The instance types of the node.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The IP address of the node.
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// The location where the node is deployed. Valid values:
                /// 
                /// *   OnPremise: The node is deployed on your data center.
                /// *   PublicCloud: The node is deployed on the public cloud.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The reason why the node is locked. Valid values:
                /// 
                /// *   financial: The instance is locked due to overdue payments.
                /// *   security: The node is locked for security reasons.
                /// *   recycling: The preemptible instance is locked and pending release.
                /// *   dedicatedhostfinancial: The ECS instance is locked due to overdue payments of the dedicated host.
                /// 
                /// By default, an empty string is returned.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// The public IP address of the server.
                /// </summary>
                [NameInMap("PublicIpAddress")]
                [Validation(Required=false)]
                public string PublicIpAddress { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The type of the node. Valid values:
                /// 
                /// *   Scheduler: primary scheduling node
                /// *   SchedulerBackup: secondary scheduling node
                /// *   Account: primary domain server node
                /// *   AccountBackup: secondary domain server node
                /// *   Login: logon node
                /// *   Compute: compute node
                /// 
                /// Scheduling nodes and domain server nodes are management nodes.
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public ListNodesResponseBodyNodesNodeInfoRoles Roles { get; set; }
                public class ListNodesResponseBodyNodesNodeInfoRoles : TeaModel {
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public List<string> Role { get; set; }

                }

                /// <summary>
                /// The bidding method of the compute nodes.
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// The status of the node displayed on the scheduler. The status varies with the scheduler.
                /// </summary>
                [NameInMap("StateInSched")]
                [Validation(Required=false)]
                public string StateInSched { get; set; }

                /// <summary>
                /// The status of the node. Valid values:
                /// 
                /// *   uninit: The node is being installed.
                /// *   exception: An exception occurred on the node.
                /// *   running: The node is running.
                /// *   initing: The node is being initialized.
                /// *   releasing: The node is being released.
                /// *   untracking: The node is not added to the cluster.
                /// *   stopped: The node is stopped.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The statistics of the resources used by the node.
                /// </summary>
                [NameInMap("TotalResources")]
                [Validation(Required=false)]
                public ListNodesResponseBodyNodesNodeInfoTotalResources TotalResources { get; set; }
                public class ListNodesResponseBodyNodesNodeInfoTotalResources : TeaModel {
                    /// <summary>
                    /// The number of vCPUs.
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// The number of GPUs.
                    /// </summary>
                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    /// <summary>
                    /// The memory capacity. Unit: GB.
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }

                /// <summary>
                /// The usage of the compute nodes in the cluster. For other types of nodes, an empty value is returned.
                /// </summary>
                [NameInMap("UsedResources")]
                [Validation(Required=false)]
                public ListNodesResponseBodyNodesNodeInfoUsedResources UsedResources { get; set; }
                public class ListNodesResponseBodyNodesNodeInfoUsedResources : TeaModel {
                    /// <summary>
                    /// The number of vCPUs.
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// The number of GPUs.
                    /// </summary>
                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    /// <summary>
                    /// The memory capacity. Unit: GB.
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The version of the client that is used for the cluster.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// The VPC ID of the node.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The page number returned.
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
        /// The request ID.
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
