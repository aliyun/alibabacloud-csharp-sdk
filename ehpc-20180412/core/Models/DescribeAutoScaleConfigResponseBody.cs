// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeAutoScaleConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The type of the scheduler. Valid values:
        /// 
        /// *   pbs
        /// *   slurm
        /// *   opengridscheduler
        /// *   deadline
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// Indicates whether auto scale-out is enabled.
        /// </summary>
        [NameInMap("EnableAutoGrow")]
        [Validation(Required=false)]
        public bool? EnableAutoGrow { get; set; }

        /// <summary>
        /// Indicates whether auto scale-in is enabled.
        /// </summary>
        [NameInMap("EnableAutoShrink")]
        [Validation(Required=false)]
        public bool? EnableAutoShrink { get; set; }

        /// <summary>
        /// The list of nodes on which auto scaling is not enabled.
        /// </summary>
        [NameInMap("ExcludeNodes")]
        [Validation(Required=false)]
        public string ExcludeNodes { get; set; }

        /// <summary>
        /// The ratio of added nodes to the original ones. Valid values: 0 to 100.
        /// </summary>
        [NameInMap("ExtraNodesGrowRatio")]
        [Validation(Required=false)]
        public int? ExtraNodesGrowRatio { get; set; }

        /// <summary>
        /// The scale-out interval. The interval at which the compute nodes were scaled out. Valid values: 2 to 10.
        /// </summary>
        [NameInMap("GrowIntervalInMinutes")]
        [Validation(Required=false)]
        public int? GrowIntervalInMinutes { get; set; }

        /// <summary>
        /// The percentage of the added nodes. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("GrowRatio")]
        [Validation(Required=false)]
        public int? GrowRatio { get; set; }

        /// <summary>
        /// The timeout period before the node was started. Valid values: 10 to 60.
        /// </summary>
        [NameInMap("GrowTimeoutInMinutes")]
        [Validation(Required=false)]
        public int? GrowTimeoutInMinutes { get; set; }

        /// <summary>
        /// The maximum number of compute nodes in the cluster. This parameter indicates the largest number of nodes that can be added to the cluster.
        /// </summary>
        [NameInMap("MaxNodesInCluster")]
        [Validation(Required=false)]
        public int? MaxNodesInCluster { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of consecutive idle times of a node during a scale-in check. Valid values: 2 to 5.
        /// </summary>
        [NameInMap("ShrinkIdleTimes")]
        [Validation(Required=false)]
        public int? ShrinkIdleTimes { get; set; }

        /// <summary>
        /// The scale-in interval. The interval at which the compute nodes were scaled in. Valid values: 2 to 10.
        /// </summary>
        [NameInMap("ShrinkIntervalInMinutes")]
        [Validation(Required=false)]
        public int? ShrinkIntervalInMinutes { get; set; }

        /// <summary>
        /// The maximum hourly rate of the instance. The value is accurate to three decimal places. It takes effect only when SpotStrategy is set to SpotWithPriceLimit.
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public string SpotPriceLimit { get; set; }

        /// <summary>
        /// The bidding policy for the compute nodes. Valid values:
        /// 
        /// *   NoSpot: The instance is created as a regular pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is a preemptible one with a user-defined maximum hourly rate.
        /// *   SpotAsPriceGo: The instance is created as a pay-as-you-go instance that is automatically priced based on the Alibaba Cloud Marketplace.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The ID of the user.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
