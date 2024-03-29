// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeBandwidthLimitationRequest : TeaModel {
        /// <summary>
        /// The billing method of the instance. For more information, see [Billing overview](~~25398~~). Valid values:
        /// 
        /// *   PrePaid: subscription
        /// *   PostPaid: pay-as-you-go
        /// 
        /// Default value: PostPaid.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The instance type. For information about the values, see [Instance families](~~25378~~).
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies the operation for which to query the maximum public bandwidth. Valid values:
        /// 
        /// *   Upgrade: upgrades the public bandwidth.
        /// *   Downgrade: downgrades the public bandwidth.
        /// *   Create: creates an ECS instance.
        /// 
        /// Default value: Create.
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~DescribeRegions~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource.
        /// 
        /// >  This parameter is required when the OperationType parameter is set to Upgrade or Downgrade.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The bidding policy for the pay-as-you-go instance. Valid values:
        /// 
        /// *   NoSpot: The instance is a regular pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is a preemptible instance with user-defined maximum hourly prices.
        /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bid price. The market price can be up to the pay-as-you-go price.
        /// 
        /// Default value: NoSpot.
        /// 
        /// >  The SpotStrategy parameter takes effect only when the InstanceChargeType parameter is set to PostPaid.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

    }

}
