// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RenewDesktopsRequest : TeaModel {
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
        /// The IDs of cloud desktops.
        /// 
        /// Only subscription cloud desktops can be renewed by calling this operation.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// The renewal duration. The valid values of this parameter are determined by the PeriodUnit value.
        /// 
        /// *   If PeriodUnit is set to Month, the valid values of the Period parameter are 1, 2, 3, and 6.
        /// *   If PeriodUnit is set to Year, the valid values of the Period parameter are 1, 2, 3, 4, and 5.
        /// 
        /// Default value: 1.
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
        /// The ID of the sales promotion.
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// The region ID of the cloud desktop.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
