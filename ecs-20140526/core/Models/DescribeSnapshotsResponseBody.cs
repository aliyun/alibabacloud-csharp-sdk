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

        /// <summary>
        /// <para>The information about the snapshots.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public DescribeSnapshotsResponseBodySnapshots Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("Snapshot")]
            [Validation(Required=false)]
            public List<DescribeSnapshotsResponseBodySnapshotsSnapshot> Snapshot { get; set; }
            public class DescribeSnapshotsResponseBodySnapshotsSnapshot : TeaModel {
                /// <summary>
                /// <para>Indicates whether the snapshot can be used to create or roll back a disk. Valid values:</para>
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
                /// <para>The category of the snapshot.</para>
                /// <remarks>
                /// <para> This parameter will be removed in the future. We recommend that you use <c>InstantAccess</c> to ensure future compatibility.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The time when the snapshot was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-08-20T14:52:28Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the snapshot is encrypted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>Indicates whether the instant access feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The instant access feature is enabled. By default, the instant access feature is enabled for Enterprise SSDs (ESSDs).</description></item>
                /// <item><description>false: The instant access feature is disabled. The snapshot is a normal snapshot for which the instant access feature is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InstantAccess")]
                [Validation(Required=false)]
                public bool? InstantAccess { get; set; }

                /// <summary>
                /// <para>Indicates the validity period of the instant access feature. When the specified period expires, the instant access feature is automatically disabled.</para>
                /// <para>By default, the value of this parameter is the same as the value of <c>RetentionDays</c>.</para>
                /// <remarks>
                /// <para> This parameter is no longer used. The normal snapshots of ESSDs are upgraded to support the instant access feature by default. No additional configurations are required to enable the feature and you are not charged for the feature. For more information, see <a href="https://help.aliyun.com/document_detail/193667.html">Use the instant access feature</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("InstantAccessRetentionDays")]
                [Validation(Required=false)]
                public int? InstantAccessRetentionDays { get; set; }

                /// <summary>
                /// <para>The ID of the KMS key used for the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The time when the snapshot was last modified. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-08-25T14:18:09Z</para>
                /// </summary>
                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public string LastModifiedTime { get; set; }

                /// <summary>
                /// <para>The product code of the Alibaba Cloud Marketplace image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jxsc000****</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

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
                /// <para>The region ID of the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The amount of remaining time required to create the snapshot. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38</para>
                /// </summary>
                [NameInMap("RemainTime")]
                [Validation(Required=false)]
                public int? RemainTime { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the snapshot belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The retention period of the automatic snapshot. Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("RetentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot chain that is associated with the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sl-bp1grgphbcc9brb5****</para>
                /// </summary>
                [NameInMap("SnapshotLinkId")]
                [Validation(Required=false)]
                public string SnapshotLinkId { get; set; }

                /// <summary>
                /// <para>The name of the snapshot. This parameter is returned only if a snapshot name was specified when the snapshot was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testSnapshotName</para>
                /// </summary>
                [NameInMap("SnapshotName")]
                [Validation(Required=false)]
                public string SnapshotName { get; set; }

                /// <summary>
                /// <para>The serial number of the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64472-116742336-61976****</para>
                /// </summary>
                [NameInMap("SnapshotSN")]
                [Validation(Required=false)]
                public string SnapshotSN { get; set; }

                /// <summary>
                /// <para>The type of the snapshot. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>auto or timer: automatic snapshot</description></item>
                /// <item><description>user: manual snapshot</description></item>
                /// <item><description>all: all snapshot types</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("SnapshotType")]
                [Validation(Required=false)]
                public string SnapshotType { get; set; }

                /// <summary>
                /// <para>The ID of the source disk. This parameter is retained even after the source disk is released.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp67acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("SourceDiskId")]
                [Validation(Required=false)]
                public string SourceDiskId { get; set; }

                /// <summary>
                /// <para>The capacity of the source disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("SourceDiskSize")]
                [Validation(Required=false)]
                public string SourceDiskSize { get; set; }

                /// <summary>
                /// <para>The type of the source disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system</description></item>
                /// <item><description>data</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("SourceDiskType")]
                [Validation(Required=false)]
                public string SourceDiskType { get; set; }

                /// <summary>
                /// <para>The region ID of the source snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("SourceRegionId")]
                [Validation(Required=false)]
                public string SourceRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the source snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("SourceSnapshotId")]
                [Validation(Required=false)]
                public string SourceSnapshotId { get; set; }

                /// <summary>
                /// <para>The category of the source disk.</para>
                /// <remarks>
                /// <para> This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>disk</para>
                /// </summary>
                [NameInMap("SourceStorageType")]
                [Validation(Required=false)]
                public string SourceStorageType { get; set; }

                /// <summary>
                /// <para>The status of the snapshot. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>progressing</description></item>
                /// <item><description>accomplished</description></item>
                /// <item><description>failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>accomplished</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags of the snapshot.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSnapshotsResponseBodySnapshotsSnapshotTags Tags { get; set; }
                public class DescribeSnapshotsResponseBodySnapshotsSnapshotTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSnapshotsResponseBodySnapshotsSnapshotTagsTag> Tag { get; set; }
                    public class DescribeSnapshotsResponseBodySnapshotsSnapshotTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key of the snapshot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value of the snapshot.</para>
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
                /// <para>Indicates whether the snapshot was used to create images or disks. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>image</description></item>
                /// <item><description>disk</description></item>
                /// <item><description>image_disk</description></item>
                /// <item><description>none</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>image</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of snapshots returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
