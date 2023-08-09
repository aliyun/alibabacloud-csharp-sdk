// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeBandwidthLimitationRequest : TeaModel {
        /// <summary>
        /// The preemption policy for the preemptible or pay-as-you-go instance. Valid values:
        /// 
        /// *   NoSpot: The instance is a regular pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is a preemptible instance with user-defined maximum hourly prices.
        /// *   SpotAsPriceGo: The system automatically offers a bid, which is not higher than the pay-as-you-go price for the same instance type.
        /// 
        /// Default value: NoSpot.
        /// 
        /// >  This parameter takes effect only when the InstanceChargeType parameter is set to PostPaid.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// Specifies the operation for which to query the maximum public bandwidth. Valid values:
        /// 
        /// *   Upgrade: upgrades the public bandwidth.
        /// *   Downgrade: downgrades the public bandwidth.
        /// *   Create: creates an ECS instance.
        /// 
        /// Default value: Create.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// 473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E
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
        /// PrePaid
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
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
        /// The ID of the resource.
        /// 
        /// >  This parameter is required when the OperationType parameter is set to Upgrade or Downgrade.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

    }

}
