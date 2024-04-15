// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyNetworkPackageBandwidthRequest : TeaModel {
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
        /// The ID of the premium bandwidth plan.
        /// </summary>
        [NameInMap("NetworkPackageId")]
        [Validation(Required=false)]
        public string NetworkPackageId { get; set; }

        /// <summary>
        /// The promotion ID.
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
