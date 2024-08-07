// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CommitFileResponseBody : TeaModel {
        [NameInMap("dentry")]
        [Validation(Required=false)]
        public CommitFileResponseBodyDentry Dentry { get; set; }
        public class CommitFileResponseBodyDentry : TeaModel {
            [NameInMap("AppProperties")]
            [Validation(Required=false)]
            public Dictionary<string, List<DentryAppPropertiesValue>> AppProperties { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("ModifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("PartitionType")]
            [Validation(Required=false)]
            public string PartitionType { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public CommitFileResponseBodyDentryProperties Properties { get; set; }
            public class CommitFileResponseBodyDentryProperties : TeaModel {
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("SpaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageDriver")]
            [Validation(Required=false)]
            public string StorageDriver { get; set; }

            [NameInMap("Thumbnail")]
            [Validation(Required=false)]
            public CommitFileResponseBodyDentryThumbnail Thumbnail { get; set; }
            public class CommitFileResponseBodyDentryThumbnail : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
