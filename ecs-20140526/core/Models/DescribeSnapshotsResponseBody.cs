// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter will be removed in the future. We recommend that you use NextToken and MaxResults for a paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter will be removed in the future. We recommend that you use NextToken and MaxResults for a paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public DescribeSnapshotsResponseBodySnapshots Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("Snapshot")]
            [Validation(Required=false)]
            public List<DescribeSnapshotsResponseBodySnapshotsSnapshot> Snapshot { get; set; }
            public class DescribeSnapshotsResponseBodySnapshotsSnapshot : TeaModel {
                [NameInMap("Available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                [NameInMap("InstantAccess")]
                [Validation(Required=false)]
                public bool? InstantAccess { get; set; }

                [NameInMap("InstantAccessRetentionDays")]
                [Validation(Required=false)]
                public int? InstantAccessRetentionDays { get; set; }

                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public string LastModifiedTime { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RemainTime")]
                [Validation(Required=false)]
                public int? RemainTime { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("RetentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                [NameInMap("SnapshotLinkId")]
                [Validation(Required=false)]
                public string SnapshotLinkId { get; set; }

                [NameInMap("SnapshotName")]
                [Validation(Required=false)]
                public string SnapshotName { get; set; }

                [NameInMap("SnapshotSN")]
                [Validation(Required=false)]
                public string SnapshotSN { get; set; }

                [NameInMap("SnapshotType")]
                [Validation(Required=false)]
                public string SnapshotType { get; set; }

                [NameInMap("SourceDiskId")]
                [Validation(Required=false)]
                public string SourceDiskId { get; set; }

                [NameInMap("SourceDiskSize")]
                [Validation(Required=false)]
                public string SourceDiskSize { get; set; }

                [NameInMap("SourceDiskType")]
                [Validation(Required=false)]
                public string SourceDiskType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("SourceRegionId")]
                [Validation(Required=false)]
                public string SourceRegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>s-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("SourceSnapshotId")]
                [Validation(Required=false)]
                public string SourceSnapshotId { get; set; }

                [NameInMap("SourceStorageType")]
                [Validation(Required=false)]
                public string SourceStorageType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSnapshotsResponseBodySnapshotsSnapshotTags Tags { get; set; }
                public class DescribeSnapshotsResponseBodySnapshotsSnapshotTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSnapshotsResponseBodySnapshotsSnapshotTagsTag> Tag { get; set; }
                    public class DescribeSnapshotsResponseBodySnapshotsSnapshotTagsTag : TeaModel {
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

        /// <summary>
        /// <para>The total number of snapshots.</para>
        /// <remarks>
        /// <para>When using the <c>MaxResults</c> and <c>NextToken</c> parameters for a paginated query, the returned <c>TotalCount</c> parameter value is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
