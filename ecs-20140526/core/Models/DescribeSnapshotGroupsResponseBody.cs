// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token used to start the next query.</para>
        /// <remarks>
        /// <para>If the return value is empty, no more data exists.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F9A4CC4-362F-469A-B9EF-B3204EF8AA3A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotGroups")]
        [Validation(Required=false)]
        public DescribeSnapshotGroupsResponseBodySnapshotGroups SnapshotGroups { get; set; }
        public class DescribeSnapshotGroupsResponseBodySnapshotGroups : TeaModel {
            [NameInMap("SnapshotGroup")]
            [Validation(Required=false)]
            public List<DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroup> SnapshotGroup { get; set; }
            public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroup : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ProgressStatus")]
                [Validation(Required=false)]
                public string ProgressStatus { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SnapshotGroupId")]
                [Validation(Required=false)]
                public string SnapshotGroupId { get; set; }

                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshots Snapshots { get; set; }
                public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshots : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshot> Snapshot { get; set; }
                    public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshot : TeaModel {
                        [NameInMap("Available")]
                        [Validation(Required=false)]
                        public bool? Available { get; set; }

                        [NameInMap("InstantAccess")]
                        [Validation(Required=false)]
                        public bool? InstantAccess { get; set; }

                        [NameInMap("InstantAccessRetentionDays")]
                        [Validation(Required=false)]
                        public int? InstantAccessRetentionDays { get; set; }

                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public string Progress { get; set; }

                        [NameInMap("SnapshotId")]
                        [Validation(Required=false)]
                        public string SnapshotId { get; set; }

                        [NameInMap("SourceDiskId")]
                        [Validation(Required=false)]
                        public string SourceDiskId { get; set; }

                        [NameInMap("SourceDiskType")]
                        [Validation(Required=false)]
                        public string SourceDiskType { get; set; }

                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshotTags Tags { get; set; }
                        public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshotTags : TeaModel {
                            [NameInMap("Tag")]
                            [Validation(Required=false)]
                            public List<DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshotTagsTag> Tag { get; set; }
                            public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshotTagsTag : TeaModel {
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                    }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupTags Tags { get; set; }
                public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupTagsTag> Tag { get; set; }
                    public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

    }

}
