// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCustomImagesResponseBody : TeaModel {
        /// <summary>
        /// The list of custom images and shared images that are supported by the E-HPC.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public ListCustomImagesResponseBodyImages Images { get; set; }
        public class ListCustomImagesResponseBodyImages : TeaModel {
            [NameInMap("ImageInfo")]
            [Validation(Required=false)]
            public List<ListCustomImagesResponseBodyImagesImageInfo> ImageInfo { get; set; }
            public class ListCustomImagesResponseBodyImagesImageInfo : TeaModel {
                /// <summary>
                /// The image tag of the base operating system.
                /// </summary>
                [NameInMap("BaseOsTag")]
                [Validation(Required=false)]
                public ListCustomImagesResponseBodyImagesImageInfoBaseOsTag BaseOsTag { get; set; }
                public class ListCustomImagesResponseBodyImagesImageInfoBaseOsTag : TeaModel {
                    /// <summary>
                    /// The architecture of the operating system. Valid values:
                    /// 
                    /// *   i386
                    /// *   x86\_64
                    /// </summary>
                    [NameInMap("Architecture")]
                    [Validation(Required=false)]
                    public string Architecture { get; set; }

                    /// <summary>
                    /// The image tag of the operating system.
                    /// </summary>
                    [NameInMap("OsTag")]
                    [Validation(Required=false)]
                    public string OsTag { get; set; }

                    /// <summary>
                    /// The release version of the operating system. Valid values:
                    /// 
                    /// *   CentOS
                    /// *   Ubuntu
                    /// *   SUSE
                    /// *   OpenSUSE
                    /// *   Debian
                    /// *   CoreOS
                    /// *   Aliyun
                    /// *   Windows Server 2003
                    /// *   Windows Server 2008
                    /// *   Windows Server 2012
                    /// *   Others Linux
                    /// *   Customized Linux
                    /// </summary>
                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                    /// <summary>
                    /// The version number of the operating system.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// The description of the image.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The name of the image.
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// The type of image. Valid values:
                /// 
                /// *   self: custom image
                /// *   others: shared image
                /// </summary>
                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                /// <summary>
                /// An array of system images that are supported by E-HPC.
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public ListCustomImagesResponseBodyImagesImageInfoOsTag OsTag { get; set; }
                public class ListCustomImagesResponseBodyImagesImageInfoOsTag : TeaModel {
                    /// <summary>
                    /// The architecture of the operating system. Valid values:
                    /// 
                    /// *   i386
                    /// *   x86\_64
                    /// </summary>
                    [NameInMap("Architecture")]
                    [Validation(Required=false)]
                    public string Architecture { get; set; }

                    /// <summary>
                    /// The image tag of the base operating system.
                    /// </summary>
                    [NameInMap("BaseOsTag")]
                    [Validation(Required=false)]
                    public string BaseOsTag { get; set; }

                    /// <summary>
                    /// The image tag of the operating system.
                    /// </summary>
                    [NameInMap("OsTag")]
                    [Validation(Required=false)]
                    public string OsTag { get; set; }

                    /// <summary>
                    /// The platform of the operating system.
                    /// </summary>
                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                    /// <summary>
                    /// The version of the operating system.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// The script that is run after the image is installed.
                /// </summary>
                [NameInMap("PostInstallScript")]
                [Validation(Required=false)]
                public string PostInstallScript { get; set; }

                /// <summary>
                /// The billing unit of the image. Valid values:
                /// 
                /// *   Hour
                /// *   Month
                /// *   Year
                /// </summary>
                [NameInMap("PricingCycle")]
                [Validation(Required=false)]
                public string PricingCycle { get; set; }

                /// <summary>
                /// The product code on Alibaba Cloud Marketplace.
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// The size of the image. Unit: GiB
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// The stock keeping unit (SKU) of the image. Valid values:
                /// 
                /// \-ECS: pay-as-you-go
                /// 
                /// \-package: subscription
                /// </summary>
                [NameInMap("SkuCode")]
                [Validation(Required=false)]
                public string SkuCode { get; set; }

                /// <summary>
                /// The status of the image. Valid values:
                /// 
                /// *   UnAvailable: The image is unavailable.
                /// *   Available: The image is available.
                /// *   Creating: The image is being created.
                /// *   CreateFailed: The image has failed to be created.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The owner of the image.
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
