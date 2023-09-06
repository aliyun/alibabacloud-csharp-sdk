// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListAvailableEcsTypesRequest : TeaModel {
        /// <summary>
        /// The billing method of the ECS instances. Valid values:
        /// 
        /// *   PostPaid: pay-as-you-go
        /// *   PrePaid: subscription
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// Specifies whether the ECS instances are sold out. Valid values:
        /// 
        /// *   false: available
        /// *   true: sold out
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ShowSoldOut")]
        [Validation(Required=false)]
        public bool? ShowSoldOut { get; set; }

        /// <summary>
        /// The preemption policy of the ECS instances. Valid values:
        /// 
        /// *   NoSpot: The ECS instances are pay-as-you-go instances.
        /// *   SpotWithPriceLimit: The ECS instances are preemptible instances that have a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
