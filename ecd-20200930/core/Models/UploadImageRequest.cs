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
        /// The description of the custom image. The description must be 2 to 256 characters in length. It cannot start with `http://` or `https://`.
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
        /// The type of the pre-installed GPU driver. Valid values:
        /// 
        /// *   gpu_grid9: This value is applicable to a Graphics cloud desktop that uses 4 vCores, 23 GB memory, and 4 GB GPU memory and a Graphics cloud desktop that uses 10 vCores, 46 GB memory, and 8 GB GPU memory
        /// *   gpu_grid12: This value is applicable to a cloud desktop other than a Graphics cloud desktop that uses 4 vCores, 23 GB memory, and 4 GB GPU memory and a Graphics cloud desktop that uses 10 vCores, 46 GB memory, and 8 GB GPU memory.
        /// *   gpu_custom: You can install a driver later.
        /// </summary>
        [NameInMap("GpuDriverType")]
        [Validation(Required=false)]
        public string GpuDriverType { get; set; }

        /// <summary>
        /// The name of the custom image. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (\_), and hyphens (-). The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-). The name must start with a letter and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The type of the license that you want to use to activate the OS after the image is imported. Valid values:
        /// 
        /// *   Auto: Elastic Desktop Service (EDS) checks the source OS of the image and allocates a license to the OS. EDS first checks whether the OS distribution that is specified by `Platform` has a license allocated by using an official Alibaba Cloud channel. If yes, the allocated license is used. If no, the license of the source OS is used.
        /// *   Aliyun: The license allocated by using an official Alibaba Cloud channel is used for the OS distribution that is specified by `Platform`.
        /// *   BYOL: The license of the source OS is used. In this case, make sure that your license key can be used in Alibaba Cloud.
        /// 
        /// Default value: Auto.
        /// 
        /// > Windows 10 cannot be activated by using a license that is allocated by using an official Alibaba Cloud channel. In this case, you must set `LicenseType` to BYOL.
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// The type of the OS. Valid values:
        /// 
        /// *   Windows
        /// *   Linux
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// The URL of the image object that you want to upload in Object Storage Service (OSS).
        /// </summary>
        [NameInMap("OssObjectPath")]
        [Validation(Required=false)]
        public string OssObjectPath { get; set; }

        /// <summary>
        /// The type of the protocol. Valid value: ASP.
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
