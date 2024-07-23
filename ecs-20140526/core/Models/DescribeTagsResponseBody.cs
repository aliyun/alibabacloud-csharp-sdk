// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B04B8CF3-4489-432D-83BA-6F128E4F2295</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tags that match all filter conditions.</para>
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
                /// <para>The number of resource types.</para>
                /// </summary>
                [NameInMap("ResourceTypeCount")]
                [Validation(Required=false)]
                public DescribeTagsResponseBodyTagsTagResourceTypeCount ResourceTypeCount { get; set; }
                public class DescribeTagsResponseBodyTagsTagResourceTypeCount : TeaModel {
                    /// <summary>
                    /// <para>The number of dedicated hosts to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Ddh")]
                    [Validation(Required=false)]
                    public int? Ddh { get; set; }

                    /// <summary>
                    /// <para>The number of disks to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15</para>
                    /// </summary>
                    [NameInMap("Disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    /// <summary>
                    /// <para>The number of ENIs to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Eni")]
                    [Validation(Required=false)]
                    public int? Eni { get; set; }

                    /// <summary>
                    /// <para>The number of images to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public int? Image { get; set; }

                    /// <summary>
                    /// <para>The number of instances to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>45</para>
                    /// </summary>
                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public int? Instance { get; set; }

                    /// <summary>
                    /// <para>The number of key pairs to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17</para>
                    /// </summary>
                    [NameInMap("KeyPair")]
                    [Validation(Required=false)]
                    public int? KeyPair { get; set; }

                    /// <summary>
                    /// <para>The number of launch templates to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("LaunchTemplate")]
                    [Validation(Required=false)]
                    public int? LaunchTemplate { get; set; }

                    /// <summary>
                    /// <para>The number of reserved instances to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("ReservedInstance")]
                    [Validation(Required=false)]
                    public int? ReservedInstance { get; set; }

                    /// <summary>
                    /// <para>The number of security groups to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Securitygroup")]
                    [Validation(Required=false)]
                    public int? Securitygroup { get; set; }

                    /// <summary>
                    /// <para>The number of snapshots to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15</para>
                    /// </summary>
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public int? Snapshot { get; set; }

                    /// <summary>
                    /// <para>The number of automatic snapshot policies to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("SnapshotPolicy")]
                    [Validation(Required=false)]
                    public int? SnapshotPolicy { get; set; }

                    /// <summary>
                    /// <para>The number of storage volumes to which the tag is added.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
