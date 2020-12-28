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
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
            [NameInMap("IsCopied")]
            [Validation(Required=false)]
            public bool? IsCopied { get; set; }
            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }
            [NameInMap("IsSupportIoOptimized")]
            [Validation(Required=false)]
            public bool? IsSupportIoOptimized { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeImageFromFamilyResponseBodyImageTags> Tags { get; set; }
            public class DescribeImageFromFamilyResponseBodyImageTags : TeaModel {
                public string TagValue { get; set; }
                public string TagKey { get; set; }
            }
            [NameInMap("IsSupportCloudinit")]
            [Validation(Required=false)]
            public bool? IsSupportCloudinit { get; set; }
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }
            [NameInMap("DiskDeviceMappings")]
            [Validation(Required=false)]
            public List<DescribeImageFromFamilyResponseBodyImageDiskDeviceMappings> DiskDeviceMappings { get; set; }
            public class DescribeImageFromFamilyResponseBodyImageDiskDeviceMappings : TeaModel {
                public string Type { get; set; }
                public string ImportOSSBucket { get; set; }
                public string SnapshotId { get; set; }
                public string ImportOSSObject { get; set; }
                public string Size { get; set; }
                public string Device { get; set; }
                public string Format { get; set; }
            }
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
        };

    }

}
