// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RenewNetworkPackagesRequest : TeaModel {
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
        /// The IDs of premium bandwidth plans. You can specify up to 100 IDs.
        /// </summary>
        [NameInMap("NetworkPackageId")]
        [Validation(Required=false)]
        public List<string> NetworkPackageId { get; set; }

        /// <summary>
        /// The subscription duration if you specify subscription as the new billing method for the cloud desktop. The unit of the value is specified by the `PeriodUnit` parameter. This parameter takes effect only when the `ChargeType` parameter is set to `PrePaid`.
        /// 
        /// *   If the `PeriodUnit` parameter is set to `Week`, the valid value of the Period parameter is 1.
        /// *   If the `PeriodUnit` parameter is set to `Month`, the valid values of the Period parameter are 1, 2, 3, and 6.
        /// *   If the `PeriodUnit` parameter is set to `Year`, the valid values of the Period parameter are 1, 2, 3, 4, and 5.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the renewal duration specified by the Period parameter. Valid values:
        /// 
        /// *   Month
        /// *   Year
        /// 
        /// Default value: Month.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

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
