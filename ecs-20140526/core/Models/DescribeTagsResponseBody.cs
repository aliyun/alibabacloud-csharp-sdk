// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeTagsResponseBody : TeaModel {
        /// <summary>
        /// The page number.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tags that match all filter conditions.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeTagsResponseBodyTags Tags { get; set; }
        public class DescribeTagsResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeTagsResponseBodyTagsTag> Tag { get; set; }
            public class DescribeTagsResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The number of resource types.
                /// </summary>
                [NameInMap("ResourceTypeCount")]
                [Validation(Required=false)]
                public DescribeTagsResponseBodyTagsTagResourceTypeCount ResourceTypeCount { get; set; }
                public class DescribeTagsResponseBodyTagsTagResourceTypeCount : TeaModel {
                    /// <summary>
                    /// The number of dedicated hosts to which the tag is added.
                    /// </summary>
                    [NameInMap("Ddh")]
                    [Validation(Required=false)]
                    public int? Ddh { get; set; }

                    /// <summary>
                    /// The number of disks to which the tag is added.
                    /// </summary>
                    [NameInMap("Disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    /// <summary>
                    /// The number of ENIs to which the tag is added.
                    /// </summary>
                    [NameInMap("Eni")]
                    [Validation(Required=false)]
                    public int? Eni { get; set; }

                    /// <summary>
                    /// The number of images to which the tag is added.
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public int? Image { get; set; }

                    /// <summary>
                    /// The number of instances to which the tag is added.
                    /// </summary>
                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public int? Instance { get; set; }

                    /// <summary>
                    /// The number of key pairs to which the tag is added.
                    /// </summary>
                    [NameInMap("KeyPair")]
                    [Validation(Required=false)]
                    public int? KeyPair { get; set; }

                    /// <summary>
                    /// The number of launch templates to which the tag is added.
                    /// </summary>
                    [NameInMap("LaunchTemplate")]
                    [Validation(Required=false)]
                    public int? LaunchTemplate { get; set; }

                    /// <summary>
                    /// The number of reserved instances to which the tag is added.
                    /// </summary>
                    [NameInMap("ReservedInstance")]
                    [Validation(Required=false)]
                    public int? ReservedInstance { get; set; }

                    /// <summary>
                    /// The number of security groups to which the tag is added.
                    /// </summary>
                    [NameInMap("Securitygroup")]
                    [Validation(Required=false)]
                    public int? Securitygroup { get; set; }

                    /// <summary>
                    /// The number of snapshots to which the tag is added.
                    /// </summary>
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public int? Snapshot { get; set; }

                    /// <summary>
                    /// The number of automatic snapshot policies to which the tag is added.
                    /// </summary>
                    [NameInMap("SnapshotPolicy")]
                    [Validation(Required=false)]
                    public int? SnapshotPolicy { get; set; }

                    /// <summary>
                    /// The number of storage volumes to which the tag is added.
                    /// </summary>
                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                }

                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The total number of tags.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
