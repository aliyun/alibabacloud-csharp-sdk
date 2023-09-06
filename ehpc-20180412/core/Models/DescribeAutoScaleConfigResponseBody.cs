// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeAutoScaleConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the associated cluster.
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
        /// Specifies whether to enable auto scale-out.
        /// </summary>
        [NameInMap("EnableAutoGrow")]
        [Validation(Required=false)]
        public bool? EnableAutoGrow { get; set; }

        /// <summary>
        /// Specifies whether to enable auto scale-in.
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
        /// The percentage of extra compute nodes. Valid values: 0 to 100.
        /// </summary>
        [NameInMap("ExtraNodesGrowRatio")]
        [Validation(Required=false)]
        public int? ExtraNodesGrowRatio { get; set; }

        /// <summary>
        /// The interval between two consecutive rounds of scale-in. Valid values: 2 to 10.
        /// </summary>
        [NameInMap("GrowIntervalInMinutes")]
        [Validation(Required=false)]
        public int? GrowIntervalInMinutes { get; set; }

        /// <summary>
        /// The percentage of each round of scale-out. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("GrowRatio")]
        [Validation(Required=false)]
        public int? GrowRatio { get; set; }

        /// <summary>
        /// The timeout period before the scale-out nodes were started. Valid values: 10 to 60.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of consecutive idle times of a node during the resource shrink check. Valid values: 2 to 5.
        /// </summary>
        [NameInMap("ShrinkIdleTimes")]
        [Validation(Required=false)]
        public int? ShrinkIdleTimes { get; set; }

        /// <summary>
        /// The interval between two consecutive rounds of scale-out. Valid values: 2 to 10.
        /// </summary>
        [NameInMap("ShrinkIntervalInMinutes")]
        [Validation(Required=false)]
        public int? ShrinkIntervalInMinutes { get; set; }

        /// <summary>
        /// The maximum hourly price of the new ECS instance. The value is accurate to three decimal places. It takes effect only when SpotStrategy is set to SpotWithPriceLimit.
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public string SpotPriceLimit { get; set; }

        /// <summary>
        /// The bidding method of the compute nodes. Valid values:
        /// 
        /// *   NoSpot: The instances of the compute node are pay-as-you-go instances.
        /// *   SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
