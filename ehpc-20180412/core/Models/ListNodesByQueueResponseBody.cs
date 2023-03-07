// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesByQueueResponseBody : TeaModel {
        /// <summary>
        /// The list of nodes.
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public ListNodesByQueueResponseBodyNodes Nodes { get; set; }
        public class ListNodesByQueueResponseBodyNodes : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<ListNodesByQueueResponseBodyNodesNodeInfo> NodeInfo { get; set; }
            public class ListNodesByQueueResponseBodyNodesNodeInfo : TeaModel {
                /// <summary>
                /// The time when the node was added to the cluster.
                /// </summary>
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public string AddTime { get; set; }

                /// <summary>
                /// The mode in which the node was added. Valid values:
                /// 
                /// *   manual: The node was manually added.
                /// *   autoscale: The node is automatically added.
                /// </summary>
                [NameInMap("CreateMode")]
                [Validation(Required=false)]
                public string CreateMode { get; set; }

                /// <summary>
                /// Indicates whether the node was created by using E-HPC.
                /// </summary>
                [NameInMap("CreatedByEhpc")]
                [Validation(Required=false)]
                public bool? CreatedByEhpc { get; set; }

                /// <summary>
                /// Indicates whether the subscription node has expired. If the node is a pay-as-you-go node, false is returned.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// The time when the subscription instance expires. If the node is a pay-as-you-go node, a null value is returned.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// Indicates whether Hyper-Threading (HT) is enabled.
                /// </summary>
                [NameInMap("HtEnabled")]
                [Validation(Required=false)]
                public bool? HtEnabled { get; set; }

                /// <summary>
                /// The ID of the ECS instance.
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
                /// The private IP address of the node.
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// The location where the node is deployed. Valid values:
                /// 
                /// *   OnPremise: The node is deployed on a hybrid cloud.
                /// *   PublicCloud: The node is deployed on a public cloud.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The reason why the node is locked. Valid values:
                /// 
                /// *   financial: The node is locked due to overdue payments.
                /// *   security: The node is locked due to security reasons.
                /// *   recycling: The preemptible node is locked and pending release.
                /// *   dedicatedhostfinancial: The node is locked due to the overdue payments of the dedicated host.
                /// 
                /// By default, an empty string is returned.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// The public IP address of the node.
                /// </summary>
                [NameInMap("PublicIpAddress")]
                [Validation(Required=false)]
                public string PublicIpAddress { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The preemption policy for the Elastic Compute Service (ECS) instance. Valid values:
                /// 
                /// *   NoSpot: applies to regular pay-as-you-go instances.
                /// *   SpotWithPriceLimit: The instances of the compute node are preemptible instances. These types of instances have a specified maximum hourly price.
                /// *   SpotAsPriceGo: The instances of the compute node are preemptible instances. The price of these instances is based on the current market price.
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
                /// *   uninit: The node is not initialized.
                /// *   init: The node is being initialized.
                /// *   ready: The node is ready.
                /// *   running: The node is running.
                /// *   exception: An exception has occurred on the node.
                /// *   untracking: The node is not added to the cluster.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The number of all resources in the cluster.
                /// </summary>
                [NameInMap("TotalResources")]
                [Validation(Required=false)]
                public ListNodesByQueueResponseBodyNodesNodeInfoTotalResources TotalResources { get; set; }
                public class ListNodesByQueueResponseBodyNodesNodeInfoTotalResources : TeaModel {
                    /// <summary>
                    /// The number of CPU cores. Unit: cores.
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// The total number of GPU cards. Unit: cards.
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
                public ListNodesByQueueResponseBodyNodesNodeInfoUsedResources UsedResources { get; set; }
                public class ListNodesByQueueResponseBodyNodesNodeInfoUsedResources : TeaModel {
                    /// <summary>
                    /// The number of CPU cores. Unit: cores.
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// The total number of GPU cards. Unit: cards.
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
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The version of the E-HPC client.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

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
