// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopSpecRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the auto-payment feature.
        /// 
        /// Default value: true. Valid values:
        /// 
        /// *   true: enables the auto-payment feature.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     Make sure that you have sufficient balance in your Alibaba Cloud account. Otherwise, an exception occurs on your order.
        /// 
        ///     <!-- -->
        /// 
        /// *   false: disables the auto-payment feature. In this case, an order is generated, and no payment is automatically made.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     You can log on to the WUYING Workspace console and complete the payment based on the order ID on the Orders page.
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The ID of a cloud computer.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The destination instance type. You can call the [DescribeDesktopTypes](~~188882~~) operation to query the instance types supported by cloud computers.
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// The ID of the promotional activity.
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

        /// <summary>
        /// The size of the new system disk. Unit: GiB. Valid values: 80 to 500 GiB. The value must be a multiple of 10.
        /// </summary>
        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        /// <summary>
        /// The performance level (PL) of the data disk. Default value: PL0.
        /// 
        /// Valid values:
        /// 
        /// *   PL1
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   PL0
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   PL3
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   PL2
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

        /// <summary>
        /// The destination data disk size. Unit: GiB.
        /// 
        /// *   The data disk size of a non-graphical cloud computer ranges from 20 to 1020 GiB and must be a multiple of 10.
        /// *   The data disk size of a graphical cloud computer ranges from 40 to 1020 GiB and must be a multiple of 10.
        /// </summary>
        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=false)]
        public int? UserDiskSizeGib { get; set; }

    }

}
