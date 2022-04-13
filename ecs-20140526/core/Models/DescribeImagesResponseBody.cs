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
                public string Architecture { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
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
                public string ImageFamily { get; set; }
                public string ImageId { get; set; }
                public string ImageName { get; set; }
                public string ImageOwnerAlias { get; set; }
                public long? ImageOwnerId { get; set; }
                public string ImageVersion { get; set; }
                public bool? IsCopied { get; set; }
                public bool? IsPublic { get; set; }
                public string IsSelfShared { get; set; }
                public bool? IsSubscribed { get; set; }
                public bool? IsSupportCloudinit { get; set; }
                public bool? IsSupportIoOptimized { get; set; }
                public bool? LoginAsNonRootSupported { get; set; }
                public string OSName { get; set; }
                public string OSNameEn { get; set; }
                public string OSType { get; set; }
                public string Platform { get; set; }
                public string ProductCode { get; set; }
                public string Progress { get; set; }
                public string ResourceGroupId { get; set; }
                public int? Size { get; set; }
                public string Status { get; set; }
                public string SupplierName { get; set; }
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
                public string Usage { get; set; }
            }
        };

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
