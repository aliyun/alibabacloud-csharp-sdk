// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotGroupsResponseBody : TeaModel {
        /// <summary>
        /// The token used to start the next query.
        /// 
        /// > If the return value is empty, no more data exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of the snapshot-consistent groups.
        /// </summary>
        [NameInMap("SnapshotGroups")]
        [Validation(Required=false)]
        public DescribeSnapshotGroupsResponseBodySnapshotGroups SnapshotGroups { get; set; }
        public class DescribeSnapshotGroupsResponseBodySnapshotGroups : TeaModel {
            [NameInMap("SnapshotGroup")]
            [Validation(Required=false)]
            public List<DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroup> SnapshotGroup { get; set; }
            public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroup : TeaModel {
                /// <summary>
                /// The time when the snapshot-consistent group was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the snapshot-consistent group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the instance to which the snapshot-consistent group belongs. This parameter has a value only when all disk snapshots in the snapshot-consistent group belong to the same instance. If disk snapshots in the snapshot-consistent group belong to different instances, you can check the response parameters that start with `Snapshots.Snapshot.Tags.` to determine the ID of the instance to which each snapshot in the snapshot-consistent group belongs.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the snapshot-consistent group.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// >  This parameter is not publicly available.
                /// </summary>
                [NameInMap("ProgressStatus")]
                [Validation(Required=false)]
                public string ProgressStatus { get; set; }

                /// <summary>
                /// The ID of the resource group to which the snapshot-consistent group belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the snapshot-consistent group.
                /// </summary>
                [NameInMap("SnapshotGroupId")]
                [Validation(Required=false)]
                public string SnapshotGroupId { get; set; }

                /// <summary>
                /// Details of the snapshots in the snapshot-consistent group.
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshots Snapshots { get; set; }
                public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshots : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshot> Snapshot { get; set; }
                    public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshot : TeaModel {
                        /// <summary>
                        /// Indicates whether the snapshot can be used to create or roll back disks. Valid values:
                        /// 
                        /// *   true
                        /// *   false
                        /// </summary>
                        [NameInMap("Available")]
                        [Validation(Required=false)]
                        public bool? Available { get; set; }

                        /// <summary>
                        /// Indicates whether the instant access feature is enabled. Valid values:
                        /// 
                        /// *   true: The instant access feature is enabled. By default, the instant access feature is enabled for ESSDs.
                        /// *   false: The instant access feature is disabled. The snapshot is a normal snapshot for which the instant access feature is disabled.
                        /// </summary>
                        [NameInMap("InstantAccess")]
                        [Validation(Required=false)]
                        public bool? InstantAccess { get; set; }

                        /// <summary>
                        /// The retention period of the instant access feature. After the retention period ends, the snapshot is automatically released.
                        /// 
                        /// >  This parameter is deprecated. The normal snapshots of enhanced SSDs (ESSDs) are upgraded to support the instant access feature by default. No additional configurations are required to enable the feature and you are not charged for the feature. For more information, see [Use the instant access feature](https://help.aliyun.com/document_detail/193667.html).
                        /// </summary>
                        [NameInMap("InstantAccessRetentionDays")]
                        [Validation(Required=false)]
                        public int? InstantAccessRetentionDays { get; set; }

                        /// <summary>
                        /// The progress of the snapshot creation task. Unit: percent (%).
                        /// </summary>
                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public string Progress { get; set; }

                        /// <summary>
                        /// The ID of the snapshot.
                        /// </summary>
                        [NameInMap("SnapshotId")]
                        [Validation(Required=false)]
                        public string SnapshotId { get; set; }

                        /// <summary>
                        /// The ID of the source disk. This parameter is retained even after the source disk of the snapshot is released.
                        /// </summary>
                        [NameInMap("SourceDiskId")]
                        [Validation(Required=false)]
                        public string SourceDiskId { get; set; }

                        /// <summary>
                        /// The type of the source disk. Valid values:
                        /// 
                        /// *   system: system disk
                        /// *   data: data disk
                        /// </summary>
                        [NameInMap("SourceDiskType")]
                        [Validation(Required=false)]
                        public string SourceDiskType { get; set; }

                        /// <summary>
                        /// The tags of the snapshot. The default values contain snapshot source information.
                        /// </summary>
                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshotTags Tags { get; set; }
                        public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshotTags : TeaModel {
                            [NameInMap("Tag")]
                            [Validation(Required=false)]
                            public List<DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshotTagsTag> Tag { get; set; }
                            public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshotTagsTag : TeaModel {
                                /// <summary>
                                /// The tag key of the snapshot. The default values of Key and Value contain snapshot source information.
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// The tag value of the snapshot. The default values of Key and Value contain snapshot source information.
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// The state of the snapshot-consistent group. Valid values:
                /// 
                /// *   progressing: The snapshot-consistent group was being created.
                /// *   accomplished: The snapshot-consistent group was created.
                /// *   failed: The snapshot-consistent group failed to be created.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags of the snapshot-consistent group.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupTags Tags { get; set; }
                public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupTagsTag> Tag { get; set; }
                    public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the snapshot-consistent group.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value of the snapshot-consistent group.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

    }

}
