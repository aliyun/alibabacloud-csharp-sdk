// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyImageAttributeRequest : TeaModel {
        /// <summary>
        /// The new boot mode of the image. Valid values:
        /// 
        /// *   BIOS: Basic Input/Output System (BIOS)
        /// *   UEFI: Unified Extensible Firmware Interface (UEFI)
        /// *   UEFI-Preferred: BIOS and UEFI
        /// 
        /// >  Before you change the boot mode, we recommend that you obtain the boot modes supported by the image. If you specify an unsupported boot mode for the image, ECS instances that use the image cannot start as expected. If you do not know which boot modes are supported by the image, we recommend that you use the image check feature to perform a check. For information about the image check feature, see [Overview](https://help.aliyun.com/document_detail/439819.html).
        /// 
        /// >  For information about the UEFI-Preferred boot mode, see [Best practices for ECS instance boot modes](https://help.aliyun.com/document_detail/2244655.html).
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// The new description of the custom image. The description must be 2 to 256 characters in length It cannot start with [http:// or https://.](http://https://。)
        /// 
        /// This parameter is empty by default, which specifies that the original description is retained.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The attributes of the custom image.
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public ModifyImageAttributeRequestFeatures Features { get; set; }
        public class ModifyImageAttributeRequestFeatures : TeaModel {
            /// <summary>
            /// Specifies whether to support the Non-Volatile Memory Express (NVMe) protocol. Valid values:
            /// 
            /// *   supported: The image supports NVMe. Instances created from this image also support NVMe.
            /// *   unsupported: The image does not support NVMe. Instances created from this image do not support NVMe.
            /// </summary>
            [NameInMap("NvmeSupport")]
            [Validation(Required=false)]
            public string NvmeSupport { get; set; }

        }

        /// <summary>
        /// The name of the image family. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with acs: or aliyun. [It cannot contain http:// or https://. It can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).](http://https://。、（.）、（:）、（_）（-）。)
        /// 
        /// By default, this parameter is empty.
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// The ID of the custom image.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The name of the custom image. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with acs: or aliyun. [It cannot contain http:// or https://. It can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).](http://https://。、（.）、（:）、（_）（-）。)
        /// 
        /// By default, this parameter is empty. In this case, the original name is retained.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The type of the license that is used to activate the operating system after the image is imported. Set the value to BYOL.
        /// 
        /// BYOL: The license that comes with the source operating system is used. When you use the BYOL license, make sure that your license key is supported by Alibaba Cloud.
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the custom image. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The new state of the custom image. Valid values:
        /// 
        /// *   Deprecated: puts the image into the Deprecated state. If the custom image is shared, you must unshare it before you can put it into the Deprecated state. Images in the Deprecated state cannot be shared or copied, but can be used to create instances or replace system disks.
        /// *   Available: puts the image into the Available state. You can restore an image from the Deprecated state to the Available state.
        /// 
        /// > If you want to roll back a custom image in the image family to a previous version, you can put the latest available custom image into the Deprecated state. If no custom images are in the Available state within the image family, an image family cannot be used to create instances. Proceed with caution if only a single custom image is in the Available state within the image family.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
