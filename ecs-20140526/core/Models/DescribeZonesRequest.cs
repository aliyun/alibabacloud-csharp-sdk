// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// The natural language that is used to filter responses. For more information, see [RFC 7231](https://tools.ietf.org/html/rfc7231). Valid values:
        /// 
        /// *   zh-CN
        /// *   en-US
        /// *   ja
        /// 
        /// Default value: zh-CN.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The billing method of resources. For more information, see [Billing overview](~~25398~~). Valid values:
        /// 
        /// *   PrePaid: subscription
        /// *   PostPaid: pay-as-you-go
        /// 
        /// Default value: PostPaid.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The bidding policy for pay-as-you-go instances. You can specify this parameter when the `InstanceChargeType` parameter is set to PostPaid. For more information, see [Preemptible instances](~~52088~~). Valid values:
        /// 
        /// *   NoSpot: The instances are regular pay-as-you-go instances.
        /// *   SpotWithPriceLimit: The instances are preemptible instances with user-defined maximum hourly prices.
        /// *   SpotAsPriceGo: The instances are preemptible instances for which the market price at the time of purchase is automatically used as the bid price. The market price can be up to the pay-as-you-go price.
        /// 
        /// Default value: NoSpot.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// Specifies whether to display detailed information.
        /// 
        /// *   true: displays detailed information.
        /// *   false: does not display detailed information.
        /// 
        /// Default value: true.
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

    }

}
