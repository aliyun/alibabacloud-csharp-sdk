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

        /// <summary>
        /// <para>The information about the snapshot-consistent groups.</para>
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
                /// <para>The creation time. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-23T10:58:48Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the snapshot-consistent group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the instance to which the snapshot-consistent group belongs. This parameter has a value only when all disk snapshots in the snapshot-consistent group belong to the same instance. If disk snapshots in the snapshot-consistent group belong to different instances, you can check the response parameters that start with <c>Snapshots.Snapshot.Tags.</c> to determine the ID of the instance to which each snapshot in the snapshot-consistent group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-j6ca469urv8ei629****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the snapshot-consistent group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ProgressStatus")]
                [Validation(Required=false)]
                public string ProgressStatus { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the snapshot-consistent group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot-consistent group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ssg-j6ciyh3k52qp7ovm****</para>
                /// </summary>
                [NameInMap("SnapshotGroupId")]
                [Validation(Required=false)]
                public string SnapshotGroupId { get; set; }

                /// <summary>
                /// <para>The information about the snapshots in the snapshot-consistent group.</para>
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
                        /// <para>Indicates whether the snapshot can be shared and be used to create or roll back a disk. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true</description></item>
                        /// <item><description>false</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Available")]
                        [Validation(Required=false)]
                        public bool? Available { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the instant access feature is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: The instant access feature is enabled. By default, the instant access feature is enabled for ESSDs.</description></item>
                        /// <item><description>false: The instant access feature is disabled. The snapshot is a standard snapshot for which the instant access feature is disabled.</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para> This parameter is no longer used. By default, standard snapshots of ESSDs are upgraded to instant access snapshots free of charge without the need for additional configurations. For more information, see <a href="https://help.aliyun.com/document_detail/193667.html">Use the instant access feature</a>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("InstantAccess")]
                        [Validation(Required=false)]
                        public bool? InstantAccess { get; set; }

                        /// <summary>
                        /// <para>The validity period of the instant access feature. When the validity period ends, the instant access snapshot is automatically released.</para>
                        /// <remarks>
                        /// <para> This parameter is no longer used. By default, standard snapshots of ESSDs are upgraded to instant access snapshots free of charge without the need for additional configurations. For more information, see <a href="https://help.aliyun.com/document_detail/193667.html">Use the instant access feature</a>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("InstantAccessRetentionDays")]
                        [Validation(Required=false)]
                        public int? InstantAccessRetentionDays { get; set; }

                        /// <summary>
                        /// <para>The progress of the snapshot creation task. Unit: percent (%).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100%</para>
                        /// </summary>
                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public string Progress { get; set; }

                        /// <summary>
                        /// <para>The ID of the snapshot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>s-j6cbzmrlbf09w72q****</para>
                        /// </summary>
                        [NameInMap("SnapshotId")]
                        [Validation(Required=false)]
                        public string SnapshotId { get; set; }

                        /// <summary>
                        /// <para>The ID of the source disk. This parameter is retained even after the source disk of the snapshot is released.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d-j6c3ogynmvpi6wy7****</para>
                        /// </summary>
                        [NameInMap("SourceDiskId")]
                        [Validation(Required=false)]
                        public string SourceDiskId { get; set; }

                        /// <summary>
                        /// <para>The type of the source disk. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>system: system disk</description></item>
                        /// <item><description>data: data disk</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>system</para>
                        /// </summary>
                        [NameInMap("SourceDiskType")]
                        [Validation(Required=false)]
                        public string SourceDiskType { get; set; }

                        /// <summary>
                        /// <para>The tags of the snapshot. The default values contain snapshot source information.</para>
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
                                /// <para>The tag key of the snapshot. The default values of Key and Value contain snapshot source information.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>acs:ecs:createFrom</para>
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// <para>The tag value of the snapshot. The default values of Key and Value contain snapshot source information.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>i-bp11qm0o3dk4iuc****</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// <para>The state of the snapshot-consistent group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>progressing: The snapshot-consistent group was being created.</description></item>
                /// <item><description>accomplished: The snapshot-consistent group was created.</description></item>
                /// <item><description>failed: The snapshot-consistent group failed to be created.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>accomplished</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags of the snapshot-consistent group.</para>
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
                        /// <para>The tag key of the snapshot-consistent group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value of the snapshot-consistent group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
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
