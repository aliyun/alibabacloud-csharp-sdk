// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class IncreaseNodesRequest : TeaModel {
        /// <summary>
        /// The configurations of the applications. Valid values of N: 1 to 1000.
        /// </summary>
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ApplicationConfig> ApplicationConfigs { get; set; }

        /// <summary>
        /// Indicates whether to automatically pay for the orders involved in the scale-out operation. This parameter takes effect only when the PaymentType parameter is set to Subscription. Valid values:
        /// 
        /// *   true: automatically pays for the order involved in this operation.
        /// *   false: does not automatically pay for the orders involved in this operation.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("AutoPayOrder")]
        [Validation(Required=false)]
        public bool? AutoPayOrder { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The number of nodes. The number of incremental nodes for this scale-out. Valid values: 1 to 500.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IncreaseNodeCount")]
        [Validation(Required=false)]
        public int? IncreaseNodeCount { get; set; }

        /// <summary>
        /// The minimum number of nodes that can be added. Valid values: 1 to 500.
        /// 
        /// *   If you configure this parameter, and the number of available Elastic Compute Service (ECS) instances is less than the value of the IncreaseNodeCount parameter, the system tries to add nodes based on the number specified by the `MinIncreaseNodeCount` parameter. If the minimum number of nodes are added, the scale-out status is `PARTIAL_COMPLETED`.
        /// *   If you do not configure this parameter, and the number of available ECS instances is less than the value of the IncreaseNodeCount parameter, the scale-out process fails. The scale-out status is `FAILED`.
        /// </summary>
        [NameInMap("MinIncreaseNodeCount")]
        [Validation(Required=false)]
        public int? MinIncreaseNodeCount { get; set; }

        /// <summary>
        /// The ID of the node group. The target node group to which you want to scale out the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// The subscription duration. Valid values when the PaymentDurationUnit value is Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.
        /// </summary>
        [NameInMap("PaymentDuration")]
        [Validation(Required=false)]
        public int? PaymentDuration { get; set; }

        /// <summary>
        /// The unit of the subscription duration. Valid values:
        /// 
        /// *   Month
        /// </summary>
        [NameInMap("PaymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        /// <summary>
        /// The ID of the region in which you want to create the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
