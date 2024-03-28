// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values:
        /// 
        /// *   **false**: disables automatic payment. This is the default value. If you select this option, you must go to [Order Center](https://usercenter2-intl.aliyun.com/order/list) to complete the payment after an order is generated.
        /// *   **true**: enables automatic payment. Payments are automatically completed.
        /// 
        /// >  This parameter takes effect only if you call the UpdateBandwidthPackage operation to upgrade a bandwidth plan.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to use coupons. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// The bandwidth value of the bandwidth plan. Unit: Mbit/s.
        /// 
        /// Valid values: **2** to **2000**.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The ID of the bandwidth plan that you want to modify.
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// The type of bandwidth. Valid values:
        /// 
        /// *   **Basic**
        /// *   **Enhanced**
        /// *   **Advanced**
        /// 
        /// >  You can upgrade **Basic** bandwidth to **Enhanced** bandwidth or downgrade Enhanced bandwidth to Basic bandwidth. You cannot change **Advanced** bandwidth to another type of bandwidth.
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// The description of the bandwidth plan.
        /// 
        /// The description can be up to 256 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the bandwidth plan. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
