// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Default value: false. Valid values:
        /// 
        /// *   **false**: disables automatic payment. If you select this option, you must go to the Order Center to complete the payment after an order is generated.
        /// *   **true**: enables automatic payment. Payments are automatically completed.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to use coupons. Default value: false. Valid values:
        /// 
        /// *   **true**: uses coupons.
        /// *   **false**: does not use coupons.
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
        /// *   **Basic**: basic
        /// *   **Enhanced**: enhanced
        /// *   **Advanced**: premium
        /// 
        /// >  You can only upgrade **Basic** bandwidth to **Enhanced** bandwidth. You cannot change **Enhanced** bandwidth or **Advanced** bandwidth to another type.
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
        /// The name of the bandwidth plan.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
