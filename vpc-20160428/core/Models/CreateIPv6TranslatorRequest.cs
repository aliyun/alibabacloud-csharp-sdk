// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateIPv6TranslatorRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values: **true and false**.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The bandwidth of the IPv6 Translation Service instance. Unit: Mbit/s. Valid values: **1** to **200**. If you do not specify the bandwidth for the mapping entry, the bandwidth is shared with the mapping entry.
        /// 
        /// > If you do not specify this parameter, the default bandwidth is 10 Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The subscription duration.
        /// 
        /// *   If the billing cycle is **Month**, valid values are **1** to **9**.
        /// *   If the billing cycle is **Year**, set the value to **3**.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The name of the IPv6 Translation Service instance. The default name is the instance ID. It must be 2 to 100 characters in length and must start with a letter. It can contain letters, digits, periods (.), underscores (\_), and hyphens (-). It cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing method of the IPv6 Translation Service instance. Valid values:
        /// 
        /// *   **PREPAY**: subscription
        /// *   **POSTPAY**: pay-as-you-go
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The billing cycle of the subscription. Valid values:
        /// 
        /// *   **Month** (default)
        /// *   **Year**
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The region of the IPv6 Translation Service instance. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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
        /// The specification of the IPv6 Translation Service instance. Set the value to **small**.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
