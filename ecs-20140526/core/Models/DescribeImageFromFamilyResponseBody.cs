// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageFromFamilyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public DescribeImageFromFamilyResponseBodyImage Image { get; set; }
        public class DescribeImageFromFamilyResponseBodyImage : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
            [NameInMap("IsCopied")]
            [Validation(Required=false)]
            public bool? IsCopied { get; set; }
            [NameInMap("IsSupportIoOptimized")]
            [Validation(Required=false)]
            public bool? IsSupportIoOptimized { get; set; }
            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }
            [NameInMap("IsSupportCloudinit")]
            [Validation(Required=false)]
            public bool? IsSupportCloudinit { get; set; }
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }
            [NameInMap("IsSelfShared")]
            [Validation(Required=false)]
            public string IsSelfShared { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }
            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }
            [NameInMap("IsSubscribed")]
            [Validation(Required=false)]
            public bool? IsSubscribed { get; set; }
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }
            [NameInMap("DiskDeviceMappings")]
            [Validation(Required=false)]
            public DescribeImageFromFamilyResponseBodyImageDiskDeviceMappings DiskDeviceMappings { get; set; }
            public class DescribeImageFromFamilyResponseBodyImageDiskDeviceMappings : TeaModel {
                [NameInMap("DiskDeviceMapping")]
                [Validation(Required=false)]
                public List<DescribeImageFromFamilyResponseBodyImageDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                public class DescribeImageFromFamilyResponseBodyImageDiskDeviceMappingsDiskDeviceMapping : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("ImportOSSBucket")]
                    [Validation(Required=false)]
                    public string ImportOSSBucket { get; set; }

                    [NameInMap("SnapshotId")]
                    [Validation(Required=false)]
                    public string SnapshotId { get; set; }

                    [NameInMap("ImportOSSObject")]
                    [Validation(Required=false)]
                    public string ImportOSSObject { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public string Size { get; set; }

                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }

                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                }

            }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeImageFromFamilyResponseBodyImageTags Tags { get; set; }
            public class DescribeImageFromFamilyResponseBodyImageTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeImageFromFamilyResponseBodyImageTagsTag> Tag { get; set; }
                public class DescribeImageFromFamilyResponseBodyImageTagsTag : TeaModel {
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                }

            }
        };

    }

}
