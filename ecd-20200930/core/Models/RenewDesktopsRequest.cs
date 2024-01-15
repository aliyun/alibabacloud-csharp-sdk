// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RenewDesktopsRequest : TeaModel {
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
        /// *   false: disables the auto-payment feature. In this case, an order is generated, and no payment is automatically made.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     You can log on to the EDS console and complete the payment based on the order number.
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The cloud desktop ID. Only subscription cloud desktops can be renewed.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// The renewal duration. Valid values of this parameter are determined by the value of the `PeriodUnit` parameter.
        /// 
        /// *   Valid values if you set the `PeriodUnit` parameter to `Month`: 1, 2, 3, and 6
        /// *   Valid values if you set the `PeriodUnit` parameter to `Year`: 1, 2, 3, 4, 5, and 6
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the renewal duration that is specified by the Period parameter.
        /// 
        /// Valid values:
        /// 
        /// *   Month (default)
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
        /// The region ID. You can call the [DescribeRegions](~~196646~~) to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
