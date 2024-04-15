// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateNetworkPackageRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the automatic payment feature.
        /// 
        /// Valid values:
        /// 
        /// *   true (default): enables the auto-payment feature.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     Make sure that your account has sufficient balance. Otherwise, no order is generated.
        /// 
        ///     <!-- -->
        /// 
        /// *   false: disables the auto-payment feature. In this case, an order is generated but you need to make the payment manually.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     To make the payment, log on to the WUYING Workspace console, go to the Orders page, and find the order based on the order ID.
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the premium bandwidth plan.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The bandwidth provided by the premium bandwidth plan. Unit: Mbit/s.
        /// 
        /// *   Valid values if the premium bandwidth plan is a subscription plan: 2 to 1000.
        /// *   Valid values if the premium bandwidth plan is a pay-as-you-go plan that charges by data transfer (PayByTraffic): 2 to 200.
        /// *   Valid values if the premium bandwidth plan is a pay-as-you-go plan that charges by fixed bandwidth (PayByBandwidth): 2 to 1000.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The charge type of the premium bandwidth plan.
        /// 
        /// *   Valid value when the `PayType` parameter is set to `PrePaid`:
        /// 
        ///     *   PayByBandwidth: charges by fixed bandwidth.
        /// 
        /// *   Valid values when the `PayType` parameter is set to `PostPaid`:
        /// 
        ///     *   PayByTraffic: charges by data transfer.
        ///     *   PayByBandwidth: charges by fixed bandwidth.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The office network ID.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The billing method of the premium bandwidth plan.
        /// 
        /// Valid values:
        /// 
        /// *   PostPaid: pay-as-you-go
        /// *   PrePaid: subscription
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The subscription duration of the premium bandwidth plan. This parameter takes effect and is required only when the `PayType` parameter is set to `PrePaid`. The valid values of this parameter vary based on the `PeriodUnit` value.
        /// 
        /// *   Valid value when the `PeriodUnit` parameter is set to `Week`: 1
        /// *   Valid values when the `PeriodUnit` parameter is set to `Month`: 1, 2, 3, and 6
        /// *   Valid values when the `PeriodUnit` parameter is set to `Year`: 1, 2, and 3
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration of the premium bandwidth plan. This parameter takes effect and is required only when the `PayType` parameter is set to `PrePaid`.
        /// 
        /// Valid values:
        /// 
        /// *   Month
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   Year
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   Week
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The ID of the sales promotion.
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
