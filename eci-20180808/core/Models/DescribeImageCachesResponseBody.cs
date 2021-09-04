// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeImageCachesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ImageCaches")]
        [Validation(Required=false)]
        public List<DescribeImageCachesResponseBodyImageCaches> ImageCaches { get; set; }
        public class DescribeImageCachesResponseBodyImageCaches : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("ExpireDateTime")]
            [Validation(Required=false)]
            public string ExpireDateTime { get; set; }

            [NameInMap("LastMatchedTime")]
            [Validation(Required=false)]
            public string LastMatchedTime { get; set; }

            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeImageCachesResponseBodyImageCachesTags> Tags { get; set; }
            public class DescribeImageCachesResponseBodyImageCachesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeImageCachesResponseBodyImageCachesEvents> Events { get; set; }
            public class DescribeImageCachesResponseBodyImageCachesEvents : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

            }

            [NameInMap("ImageCacheId")]
            [Validation(Required=false)]
            public string ImageCacheId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            [NameInMap("FlashSnapshotId")]
            [Validation(Required=false)]
            public string FlashSnapshotId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ImageCacheSize")]
            [Validation(Required=false)]
            public int? ImageCacheSize { get; set; }

            [NameInMap("ImageCacheName")]
            [Validation(Required=false)]
            public string ImageCacheName { get; set; }

        }

    }

}
