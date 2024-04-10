// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagesResponseBody : TeaModel {
        /// <summary>
        /// The information of the images.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeImagesResponseBodyImages Images { get; set; }
        public class DescribeImagesResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeImagesResponseBodyImagesImage> Image { get; set; }
            public class DescribeImagesResponseBodyImagesImage : TeaModel {
                /// <summary>
                /// The architecture of the image. Valid values:
                /// 
                /// *   i386
                /// *   x86\_64
                /// *   arm64
                /// </summary>
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                /// <summary>
                /// The boot mode of the image. Valid values:
                /// 
                /// *   BIOS: Basic Input/Output System (BIOS)
                /// *   UEFI: Unified Extensible Firmware Interface (UEFI)
                /// </summary>
                [NameInMap("BootMode")]
                [Validation(Required=false)]
                public string BootMode { get; set; }

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
                /// Details about the check performed on the image.
                /// </summary>
                [NameInMap("DetectionOptions")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageDetectionOptions DetectionOptions { get; set; }
                public class DescribeImagesResponseBodyImagesImageDetectionOptions : TeaModel {
                    /// <summary>
                    /// The check items.
                    /// </summary>
                    [NameInMap("Items")]
                    [Validation(Required=false)]
                    public DescribeImagesResponseBodyImagesImageDetectionOptionsItems Items { get; set; }
                    public class DescribeImagesResponseBodyImagesImageDetectionOptionsItems : TeaModel {
                        [NameInMap("Item")]
                        [Validation(Required=false)]
                        public List<DescribeImagesResponseBodyImagesImageDetectionOptionsItemsItem> Item { get; set; }
                        public class DescribeImagesResponseBodyImagesImageDetectionOptionsItemsItem : TeaModel {
                            /// <summary>
                            /// The name of the check item.
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// The risk that the check item may have.
                            /// </summary>
                            [NameInMap("RiskCode")]
                            [Validation(Required=false)]
                            public string RiskCode { get; set; }

                            /// <summary>
                            /// The severity of the risk that the check item of the imported custom image has. If the check item is at risk, this parameter is returned. If the check item is not at risk, this parameter is not returned.
                            /// 
                            /// Valid values:
                            /// 
                            /// *   High: The check item is a high-risk item that may affect the startup of the instance. We recommend that you handle the risk.
                            /// *   Medium: The check item is a medium-risk item that may affect the startup performance or configurations of the instance. We recommend that you handle the risk.
                            /// </summary>
                            [NameInMap("RiskLevel")]
                            [Validation(Required=false)]
                            public string RiskLevel { get; set; }

                            /// <summary>
                            /// The result of the check item.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// The state of the image check task. Valid values:
                    /// 
                    /// *   Processing
                    /// *   Finished
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The mappings between disks and snapshots in the image.
                /// </summary>
                [NameInMap("DiskDeviceMappings")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageDiskDeviceMappings DiskDeviceMappings { get; set; }
                public class DescribeImagesResponseBodyImagesImageDiskDeviceMappings : TeaModel {
                    [NameInMap("DiskDeviceMapping")]
                    [Validation(Required=false)]
                    public List<DescribeImagesResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                    public class DescribeImagesResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping : TeaModel {
                        /// <summary>
                        /// The device name of the disk. Example: /dev/xvdb.
                        /// 
                        /// >  This parameter will be removed in the future. To ensure compatibility, we recommend that you use other parameters.
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
                        /// The Object Storage Service (OSS) bucket that contains the imported image file.
                        /// </summary>
                        [NameInMap("ImportOSSBucket")]
                        [Validation(Required=false)]
                        public string ImportOSSBucket { get; set; }

                        /// <summary>
                        /// The OSS object that corresponds to the imported image file.
                        /// </summary>
                        [NameInMap("ImportOSSObject")]
                        [Validation(Required=false)]
                        public string ImportOSSObject { get; set; }

                        /// <summary>
                        /// The progress of the image copy task.
                        /// </summary>
                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public string Progress { get; set; }

                        /// <summary>
                        /// The remaining time of the image copy task. Unit: seconds.
                        /// </summary>
                        [NameInMap("RemainTime")]
                        [Validation(Required=false)]
                        public int? RemainTime { get; set; }

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
                /// The attributes of the image.
                /// </summary>
                [NameInMap("Features")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageFeatures Features { get; set; }
                public class DescribeImagesResponseBodyImagesImageFeatures : TeaModel {
                    /// <summary>
                    /// Indicates whether the image supports the Non-Volatile Memory Express (NVMe) protocol. Valid values:
                    /// 
                    /// *   supported: The image supports the NVMe protocol. Instances created from the image also support the NVMe protocol.
                    /// *   unsupported: The image does not support the NVMe protocol. Instances created from the image do not support the NVMe protocol.
                    /// </summary>
                    [NameInMap("NvmeSupport")]
                    [Validation(Required=false)]
                    public string NvmeSupport { get; set; }

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
                /// The source of the image. Valid values:
                /// 
                /// *   system: a public image provided by Alibaba Cloud
                /// *   self: a custom image that you created
                /// *   others: a shared image from another Alibaba Cloud account or a community image published by another Alibaba Cloud account
                /// *   marketplace: an Alibaba Cloud Marketplace image
                /// </summary>
                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the image belongs. This parameter takes effect only if you query shared images or community images.
                /// </summary>
                [NameInMap("ImageOwnerId")]
                [Validation(Required=false)]
                public long? ImageOwnerId { get; set; }

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
                /// Indicates whether the image is publicly available. Publicly available images include public images provided by Alibaba Cloud and custom images published as community images. Valid values:
                /// 
                /// *   true: The image is publicly available.
                /// *   false: The image is publicly unavailable.
                /// </summary>
                [NameInMap("IsPublic")]
                [Validation(Required=false)]
                public bool? IsPublic { get; set; }

                /// <summary>
                /// Indicates whether the custom image was shared to other Alibaba Cloud accounts.
                /// </summary>
                [NameInMap("IsSelfShared")]
                [Validation(Required=false)]
                public string IsSelfShared { get; set; }

                /// <summary>
                /// Indicates whether you accepted the Terms of Service of the image service that corresponds to the product code.
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
                /// Indicates whether the image supports logons of non-root users. Valid values:
                /// 
                /// *   true: The image supports logons of non-root users.
                /// *   false: The image does not support logons of non-root users.
                /// </summary>
                [NameInMap("LoginAsNonRootSupported")]
                [Validation(Required=false)]
                public bool? LoginAsNonRootSupported { get; set; }

                /// <summary>
                /// The display name of the operating system in Chinese.
                /// </summary>
                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                /// <summary>
                /// The display name of the operating system in English.
                /// </summary>
                [NameInMap("OSNameEn")]
                [Validation(Required=false)]
                public string OSNameEn { get; set; }

                /// <summary>
                /// The type of the operating system. Valid values:
                /// 
                /// *   windows
                /// *   linux
                /// </summary>
                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                /// <summary>
                /// The operating system platform.
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// The Alibaba Cloud Marketplace product code of the image.
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// The creation progress of the image. Unit: percent (%).
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// The ID of the resource group to which the image belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The size of the image. Unit: GiB.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// The state of the image. Valid values:
                /// 
                /// *   UnAvailable: The image is unavailable.
                /// *   Available: The image is available.
                /// *   Creating: The image is being created.
                /// *   CreateFailed: The image failed to be created.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The name of the supplier that published the community image.
                /// </summary>
                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

                /// <summary>
                /// The tags of the image.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageTags Tags { get; set; }
                public class DescribeImagesResponseBodyImagesImageTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagesResponseBodyImagesImageTagsTag> Tag { get; set; }
                    public class DescribeImagesResponseBodyImagesImageTagsTag : TeaModel {
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
                /// Indicates whether the image was used to create ECS instances. Valid values:
                /// 
                /// *   instance: The image was used to create one or more ECS instances.
                /// *   none: The image was not used to create ECS instances.
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

        }

        /// <summary>
        /// The page number returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the image.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of images.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
