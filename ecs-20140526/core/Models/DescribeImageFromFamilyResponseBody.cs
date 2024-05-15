// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageFromFamilyResponseBody : TeaModel {
        /// <summary>
        /// The image information.
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public DescribeImageFromFamilyResponseBodyImage Image { get; set; }
        public class DescribeImageFromFamilyResponseBodyImage : TeaModel {
            /// <summary>
            /// The image architecture. Valid values:
            /// 
            /// *   i386
            /// *   x86_64
            /// </summary>
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            /// <summary>
            /// The time when the image was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the image.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The mappings between the disks and snapshots under the image.
            /// </summary>
            [NameInMap("DiskDeviceMappings")]
            [Validation(Required=false)]
            public DescribeImageFromFamilyResponseBodyImageDiskDeviceMappings DiskDeviceMappings { get; set; }
            public class DescribeImageFromFamilyResponseBodyImageDiskDeviceMappings : TeaModel {
                [NameInMap("DiskDeviceMapping")]
                [Validation(Required=false)]
                public List<DescribeImageFromFamilyResponseBodyImageDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                public class DescribeImageFromFamilyResponseBodyImageDiskDeviceMappingsDiskDeviceMapping : TeaModel {
                    /// <summary>
                    /// The device name of the disk. Example: /dev/xvdb.
                    /// 
                    /// >  This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
                    /// </summary>
                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }

                    /// <summary>
                    /// The format of the image.
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// The OSS bucket that contains the imported image file.
                    /// </summary>
                    [NameInMap("ImportOSSBucket")]
                    [Validation(Required=false)]
                    public string ImportOSSBucket { get; set; }

                    /// <summary>
                    /// The OSS object corresponding to the imported image file.
                    /// </summary>
                    [NameInMap("ImportOSSObject")]
                    [Validation(Required=false)]
                    public string ImportOSSObject { get; set; }

                    /// <summary>
                    /// The size of the disk. Unit: GiB.
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public string Size { get; set; }

                    /// <summary>
                    /// The ID of the snapshot.
                    /// </summary>
                    [NameInMap("SnapshotId")]
                    [Validation(Required=false)]
                    public string SnapshotId { get; set; }

                    /// <summary>
                    /// The type of the image.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The name of the image family.
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

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
            /// The alias of the image owner. Valid values:
            /// 
            /// - system: public images provided by Alibaba Cloud
            /// - self: your custom images
            /// - others: shared images from other Alibaba Cloud accounts
            /// - marketplace: Alibaba Cloud Marketplace images
            /// </summary>
            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

            /// <summary>
            /// The version of the image.
            /// </summary>
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            /// <summary>
            /// Indicates whether the image is a copy of another image.
            /// </summary>
            [NameInMap("IsCopied")]
            [Validation(Required=false)]
            public bool? IsCopied { get; set; }

            /// <summary>
            /// Indicates whether the image has been shared to other Alibaba Cloud accounts.
            /// </summary>
            [NameInMap("IsSelfShared")]
            [Validation(Required=false)]
            public string IsSelfShared { get; set; }

            /// <summary>
            /// Indicates whether you have subscribed to the image corresponding to the specified product code.
            /// </summary>
            [NameInMap("IsSubscribed")]
            [Validation(Required=false)]
            public bool? IsSubscribed { get; set; }

            /// <summary>
            /// Indicates whether the image supports cloud-init.
            /// </summary>
            [NameInMap("IsSupportCloudinit")]
            [Validation(Required=false)]
            public bool? IsSupportCloudinit { get; set; }

            /// <summary>
            /// Indicates whether the image can be used on I/O optimized instances.
            /// </summary>
            [NameInMap("IsSupportIoOptimized")]
            [Validation(Required=false)]
            public bool? IsSupportIoOptimized { get; set; }

            /// <summary>
            /// The name of the operating system.
            /// </summary>
            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }

            /// <summary>
            /// The type of the operating system. Valid values:
            /// 
            /// - windows
            /// - linux
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            /// <summary>
            /// The platform of the operating system.
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// The product code of the Alibaba Cloud Marketplace image.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The image creation progress. Unit: percent (%).
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The size of the image. Unit: GiB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// The status of the image. Valid values:
            /// 
            /// - UnAvailable: The image is unavailable.
            /// - Available: The image is available.
            /// - Creating: The image is being created.
            /// - CreateFailed: The image failed to be created.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// An array that consists of Tag data.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeImageFromFamilyResponseBodyImageTags Tags { get; set; }
            public class DescribeImageFromFamilyResponseBodyImageTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeImageFromFamilyResponseBodyImageTagsTag> Tag { get; set; }
                public class DescribeImageFromFamilyResponseBodyImageTagsTag : TeaModel {
                    /// <summary>
                    /// The tag key of the image.
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// The tag value of the image.
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

            }

            /// <summary>
            /// Indicates whether the image has been used to create ECS instances. Valid values:
            /// 
            /// - instance: The image has been used to create one or more ECS instances.
            /// - none: The image has not been used to create ECS instances.
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
