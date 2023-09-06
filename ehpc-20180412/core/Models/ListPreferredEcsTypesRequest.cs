// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListPreferredEcsTypesRequest : TeaModel {
        /// <summary>
        /// The billing method of the ECS instances. Valid values:
        /// 
        /// *   PostPaid
        /// *   PrePaid
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The bidding policy of the ECS instance. Valid values:
        /// 
        /// *   NoSpot: The instance is created as a pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.
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
