// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class UploadImageRequest : TeaModel {
        /// <summary>
        /// The size of the data disk. Valid values: 80 to 500. Unit: GiB.
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public int? DataDiskSize { get; set; }

        /// <summary>
        /// The description of the image. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to enable security check.
        /// </summary>
        [NameInMap("EnableSecurityCheck")]
        [Validation(Required=false)]
        public bool? EnableSecurityCheck { get; set; }

        /// <summary>
        /// Specifies whether the image is a GPU-accelerated image.
        /// </summary>
        [NameInMap("GpuCategory")]
        [Validation(Required=false)]
        public bool? GpuCategory { get; set; }

        /// <summary>
        /// The type of the pre-installed GPU driver.
        /// 
        /// Valid values:
        /// 
        /// *   gpu_grid9: This GPU driver is used on cloud computers of the following two specifications: graphics – 4 vCPUs, 23 GiB memory, 4 GiB GPU memory, and graphics – 10 vCPUs, 46 GiB memory, 8 GiB GPU memory.
        /// *   gpu_custom: You can install the driver later.
        /// *   gpu_grid12: This GPU driver is used on graphical cloud computers of specifications other than the following two specifications: graphics – 4 vCPUs, 23 GiB memory, & 4 GiB GPU memory, and graphics – 10 vCPUs, 46 GiB memory, & 8 GiB GPU memory.
        /// </summary>
        [NameInMap("GpuDriverType")]
        [Validation(Required=false)]
        public string GpuDriverType { get; set; }

        /// <summary>
        /// The name of the image. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The type of the license that is used to activate the operating system after the image is imported. Valid values:
        /// 
        /// *   Auto: WUYING Workspace detects the operating system of the image and allocates a license to the operating system. In this mode, the system first checks whether a license allocated by an official Alibaba Cloud channel is specified in the `Platform`. If a license allocated by an official Alibaba Cloud channel is specified, the system allocates the license to the imported image. If no such license is specified, the BYOL (Bring Your Own License) mode is used.
        /// *   Aliyun: The license that is allocated by an official Alibaba Cloud channel and is specified by `Platform` is used for the operating system distribution.
        /// *   BYOL: The license that comes with the source operating system is used. When you use the BYOL mode, make sure that your license key is supported by Alibaba Cloud.
        /// 
        /// Default value: Auto.
        /// 
        /// >  Windows 10 cannot be activated by Alibaba Cloud. Set the `LicenseType` to BYOL for Windows 10.
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// The type of the operating system.
        /// 
        /// Valid values:
        /// 
        /// *   Linux
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   Windows
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// The object path of the image file in Object Storage Service (OSS).
        /// </summary>
        [NameInMap("OssObjectPath")]
        [Validation(Required=false)]
        public string OssObjectPath { get; set; }

        /// <summary>
        /// The protocol type.
        /// 
        /// Valid values:
        /// 
        /// *   ASP: in-house Adaptive Streaming Protocol (ASP)
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
