// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically complete the payment of the bandwidth plan. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// 
        /// If you set the parameter to false, go to Billing Management to complete the payment after you call this operation. The instance is created only after you complete the payment.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable the auto-renewal feature. Valid values:
        /// 
        /// *   **true**: enables auto-renewal.
        /// *   **false** (default): disables auto-renewal.
        /// 
        /// > Only subscription bandwidth plans support auto-renewal.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal duration. Unit: months. Valid values: **0** to **2147483647**. Default value: **1**.
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// The maximum bandwidth value of the bandwidth plan. Unit: Mbit/s. Valid values: **2** to **10000**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The billing method of the bandwidth plan. Set the value to **PREPAY**, which indicates that the billing method is pay-as-you-go.
        /// </summary>
        [NameInMap("BandwidthPackageChargeType")]
        [Validation(Required=false)]
        public string BandwidthPackageChargeType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the bandwidth plan.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The area where the network instance is deployed. Valid values:
        /// 
        /// *   **China**: Chinese mainland
        /// *   **North-America**: North America
        /// *   **Asia-Pacific**: Asia Pacific
        /// *   **Europe**: Europe
        /// *   **Australia**: Australia
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GeographicRegionAId")]
        [Validation(Required=false)]
        public string GeographicRegionAId { get; set; }

        /// <summary>
        /// The area where the other network instance is deployed. Valid values: Valid values:
        /// 
        /// *   **China**: Chinese mainland
        /// *   **North-America**: North America
        /// *   **Asia-Pacific**: Asia Pacific
        /// *   **Europe**: Europe
        /// *   **Australia**: Australia
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GeographicRegionBId")]
        [Validation(Required=false)]
        public string GeographicRegionBId { get; set; }

        /// <summary>
        /// The name of the bandwidth plan.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter and cannot start with `http://` or `https://`.
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
        /// The subscription duration of the bandwidth plan. Default value: 1.
        /// 
        /// *   If **PricingCycle** is set to **Month**, set **Period** to a value from **1** to **3** or **6**.
        /// *   If **PricingCycle** is set to **Year**, set **Period** to a value from **1** to **3**.
        /// 
        /// > This parameter is required when **BandwidthPackageChargeType** is set to **PREPAY**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The billing cycle of the bandwidth plan. Valid values:
        /// 
        /// *   **Month** (default): billed on a monthly basis.
        /// *   **Year**: billed on an annual basis.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The information about the tags.
        /// 
        /// You can specify at most 20 tags in each call.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCenBandwidthPackageRequestTag> Tag { get; set; }
        public class CreateCenBandwidthPackageRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// 
            /// The tag keys cannot be an empty string. The tag key can be up to 64 characters in length, and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// 
            /// You can specify at most 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// 
            /// The tag value can be 0 to 128 characters in length, and cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.
            /// 
            /// Each tag key must have a unique tag value. You can specify at most 20 tag values in each call.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
