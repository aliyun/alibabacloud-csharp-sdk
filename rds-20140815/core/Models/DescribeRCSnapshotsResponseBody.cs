// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DAC759A-F4F0-5D02-8335-BC458C0CCB94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The snapshot information.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeRCSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeRCSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <para>Indicates whether the snapshot can be used to create cloud disks, roll back cloud disks, or share snapshots. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Available.</description></item>
            /// <item><description>false: Not available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Available")]
            [Validation(Required=false)]
            public bool? Available { get; set; }

            /// <summary>
            /// <para>The snapshot type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: standard snapshot.</description></item>
            /// <item><description>Flash: local snapshot. This value will be deprecated. Local snapshots have been replaced by the instant access feature.</description></item>
            /// <item><description>archive: archived snapshot.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The creation time. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-18T09:37:14Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zd_test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the snapshot is encrypted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Encrypted.</description></item>
            /// <item><description>false: Not encrypted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This parameter is deprecated and does not need to be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("InstantAccess")]
            [Validation(Required=false)]
            public bool? InstantAccess { get; set; }

            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// <para>The progress of snapshot creation, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rc-t8q22a87745hf8****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The snapshot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rcds-hc1zg51xobdg4****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The snapshot name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>csw-37-SystemDisk</para>
            /// </summary>
            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            /// <summary>
            /// <para>The type of automatic creation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>auto or timer: automatic snapshot.</description></item>
            /// <item><description>user: manual snapshot.</description></item>
            /// <item><description>all: all automatic creation types.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("SnapshotType")]
            [Validation(Required=false)]
            public string SnapshotType { get; set; }

            /// <summary>
            /// <para>The ID of the source cloud disk. This field is retained even if the source cloud disk of the snapshot has been released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rcd-bp67acfmxazb4ph****</para>
            /// </summary>
            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            /// <summary>
            /// <para>The capacity of the source cloud disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("SourceDiskSize")]
            [Validation(Required=false)]
            public long? SourceDiskSize { get; set; }

            /// <summary>
            /// <para>The type of the source cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM: system cloud disk.</description></item>
            /// <item><description>DATA: data cloud disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>data</para>
            /// </summary>
            [NameInMap("SourceDiskType")]
            [Validation(Required=false)]
            public string SourceDiskType { get; set; }

            /// <summary>
            /// <para>The type of the source cloud disk.</para>
            /// <remarks>
            /// <para>This parameter will be deprecated. To ensure compatibility, use other parameters instead.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>disk</para>
            /// </summary>
            [NameInMap("SourceStorageType")]
            [Validation(Required=false)]
            public string SourceStorageType { get; set; }

            /// <summary>
            /// <para>The snapshot status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>progressing: The snapshot is being created.</description></item>
            /// <item><description>accomplished: The snapshot is created.</description></item>
            /// <item><description>failed: The snapshot failed to be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>progressing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag details.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeRCSnapshotsResponseBodySnapshotsTag> Tag { get; set; }
            public class DescribeRCSnapshotsResponseBodySnapshotsTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testRC</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test01</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the snapshot has been used to create images or cloud disks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>image: The snapshot has been used to create custom images.</description></item>
            /// <item><description>disk: The snapshot has been used to create cloud disks.</description></item>
            /// <item><description>image_disk: The snapshot has been used to create both data cloud disks and custom images.</description></item>
            /// <item><description>none: The snapshot has not been used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
