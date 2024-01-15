// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RenewNetworkPackagesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values:
        /// 
        /// *   true: enables automatic payment. Make sure that you have sufficient balance in your account. Otherwise, abnormal orders are generated.
        /// *   false: generates the order with no payment made. You can log on to the EDS console and complete the payment based on the order number.
        /// 
        /// Default value: true.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The IDs of Internet access packages.
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
        /// The ID of the promotion. You can call the `GetResourcePrice` operation to obtain the ID of the promotion.
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~DescribeRegions~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
