// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagesResponseBody : TeaModel {
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeImagesResponseBodyImages Images { get; set; }
        public class DescribeImagesResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeImagesResponseBodyImagesImage> Image { get; set; }
            public class DescribeImagesResponseBodyImagesImage : TeaModel {
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                [NameInMap("BootMode")]
                [Validation(Required=false)]
                public string BootMode { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DetectionOptions")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageDetectionOptions DetectionOptions { get; set; }
                public class DescribeImagesResponseBodyImagesImageDetectionOptions : TeaModel {
                    [NameInMap("Items")]
                    [Validation(Required=false)]
                    public DescribeImagesResponseBodyImagesImageDetectionOptionsItems Items { get; set; }
                    public class DescribeImagesResponseBodyImagesImageDetectionOptionsItems : TeaModel {
                        [NameInMap("Item")]
                        [Validation(Required=false)]
                        public List<DescribeImagesResponseBodyImagesImageDetectionOptionsItemsItem> Item { get; set; }
                        public class DescribeImagesResponseBodyImagesImageDetectionOptionsItemsItem : TeaModel {
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("RiskCode")]
                            [Validation(Required=false)]
                            public string RiskCode { get; set; }

                            [NameInMap("RiskLevel")]
                            [Validation(Required=false)]
                            public string RiskLevel { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                [NameInMap("DiskDeviceMappings")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageDiskDeviceMappings DiskDeviceMappings { get; set; }
                public class DescribeImagesResponseBodyImagesImageDiskDeviceMappings : TeaModel {
                    [NameInMap("DiskDeviceMapping")]
                    [Validation(Required=false)]
                    public List<DescribeImagesResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                    public class DescribeImagesResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping : TeaModel {
                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("ImportOSSBucket")]
                        [Validation(Required=false)]
                        public string ImportOSSBucket { get; set; }

                        [NameInMap("ImportOSSObject")]
                        [Validation(Required=false)]
                        public string ImportOSSObject { get; set; }

                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public string Progress { get; set; }

                        [NameInMap("RemainTime")]
                        [Validation(Required=false)]
                        public int? RemainTime { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public string Size { get; set; }

                        [NameInMap("SnapshotId")]
                        [Validation(Required=false)]
                        public string SnapshotId { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("Features")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageFeatures Features { get; set; }
                public class DescribeImagesResponseBodyImagesImageFeatures : TeaModel {
                    [NameInMap("NvmeSupport")]
                    [Validation(Required=false)]
                    public string NvmeSupport { get; set; }

                }

                [NameInMap("ImageFamily")]
                [Validation(Required=false)]
                public string ImageFamily { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                [NameInMap("ImageOwnerId")]
                [Validation(Required=false)]
                public long? ImageOwnerId { get; set; }

                [NameInMap("ImageVersion")]
                [Validation(Required=false)]
                public string ImageVersion { get; set; }

                [NameInMap("IsCopied")]
                [Validation(Required=false)]
                public bool? IsCopied { get; set; }

                [NameInMap("IsPublic")]
                [Validation(Required=false)]
                public bool? IsPublic { get; set; }

                [NameInMap("IsSelfShared")]
                [Validation(Required=false)]
                public string IsSelfShared { get; set; }

                [NameInMap("IsSubscribed")]
                [Validation(Required=false)]
                public bool? IsSubscribed { get; set; }

                [NameInMap("IsSupportCloudinit")]
                [Validation(Required=false)]
                public bool? IsSupportCloudinit { get; set; }

                [NameInMap("IsSupportIoOptimized")]
                [Validation(Required=false)]
                public bool? IsSupportIoOptimized { get; set; }

                [NameInMap("LoginAsNonRootSupported")]
                [Validation(Required=false)]
                public bool? LoginAsNonRootSupported { get; set; }

                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                [NameInMap("OSNameEn")]
                [Validation(Required=false)]
                public string OSNameEn { get; set; }

                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageTags Tags { get; set; }
                public class DescribeImagesResponseBodyImagesImageTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagesResponseBodyImagesImageTagsTag> Tag { get; set; }
                    public class DescribeImagesResponseBodyImagesImageTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
