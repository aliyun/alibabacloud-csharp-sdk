// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateBundleRequest : TeaModel {
        /// <summary>
        /// The name of the desktop template.
        /// </summary>
        [NameInMap("BundleName")]
        [Validation(Required=false)]
        public string BundleName { get; set; }

        /// <summary>
        /// The description of the desktop template.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The type of the cloud desktop. You can call the DescribeBundles operation to query the cloud desktop templates and obtain the supported desktop type from the value of the DesktopType parameter.
        /// 
        /// >  You can select GPU-accelerated desktop types only when you use GPU-accelerated images.
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// The ID of the image.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The language of the OS. This parameter is available only for system images. Valid values:
        /// 
        /// *   zh-CN: Simplified Chinese
        /// *   zh-HK: Traditional Chinese (Hong Kong)
        /// *   en-US: English
        /// *   ja-JP: Japanese
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The performance level (PL) of the system disk. If the cloud desktop type is Graphics or High Frequency, you can set the PL of the system disk. Valid values:
        /// 
        /// *   PL0
        /// *   PL1
        /// *   PL2
        /// *   PL3
        /// 
        /// For more information about the differences between disks at different PLs, see [Enhanced SSDs](~~122389~~).
        /// </summary>
        [NameInMap("RootDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string RootDiskPerformanceLevel { get; set; }

        /// <summary>
        /// The size of the system disk. Unit: GiB.
        /// 
        /// The value of this parameter must be consistent with the system disk size supported by the cloud desktop type. For more information, see [Cloud desktop types](~~188609~~).
        /// </summary>
        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        /// <summary>
        /// The PL of the data disk. If the cloud desktop type is Graphics or High Frequency, you can set the PL of the data disk. Valid values:
        /// 
        /// *   PL0
        /// *   PL1
        /// *   PL2
        /// *   PL3
        /// 
        /// For more information about the differences between disks at different PLs, see [Enhanced SSDs](~~122389~~).
        /// </summary>
        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=false)]
        public List<int?> UserDiskSizeGib { get; set; }

    }

}
