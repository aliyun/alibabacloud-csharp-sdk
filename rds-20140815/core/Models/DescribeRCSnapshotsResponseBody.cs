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
        /// <para>The list of snapshots.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeRCSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeRCSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <para>Specifies whether the snapshot can be used to create cloud disks, roll back cloud disks, and share snapshots. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The snapshot is available.</description></item>
            /// <item><description>false: The snapshot is unavailable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Available")]
            [Validation(Required=false)]
            public bool? Available { get; set; }

            /// <summary>
            /// <para>The snapshot category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: Standard snapshot.</description></item>
            /// <item><description>Flash: Local snapshot. This value will be deprecated. Local snapshots are replaced by the instant access feature.</description></item>
            /// <item><description>archive: Archive snapshot.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The creation time. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format in accordance with the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard. The time is displayed in UTC.</para>
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
            /// <para>Specifies whether the snapshot is encrypted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The snapshot is encrypted.</description></item>
            /// <item><description>false: The snapshot is not encrypted.</description></item>
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

            /// <summary>
            /// <para>The last modified time of the snapshot. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format in accordance with the ISO 8601 standard. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// <para>The creation progress of the snapshot, in percentage.</para>
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
            /// <para>csw-37-system cloud disk</para>
            /// </summary>
            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            /// <summary>
            /// <para>The automatic creation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>auto or timer: Automatic snapshot.</description></item>
            /// <item><description>user: Manual snapshot.</description></item>
            /// <item><description>all: All automatic creation types.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("SnapshotType")]
            [Validation(Required=false)]
            public string SnapshotType { get; set; }

            /// <summary>
            /// <para>The ID of the source cloud disk. If the source cloud disk of the snapshot has been released, this field is still retained.</para>
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
            /// <item><description>SYSTEM: System cloud disk.</description></item>
            /// <item><description>DATA: Data cloud disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>data</para>
            /// </summary>
            [NameInMap("SourceDiskType")]
            [Validation(Required=false)]
            public string SourceDiskType { get; set; }

            /// <summary>
            /// <para>The category of the source cloud disk.</para>
            /// <remarks>
            /// <para>This parameter will be deprecated. To improve compatibility, use other parameters.</para>
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
            /// <item><description>progressing: snapshot being created</description></item>
            /// <item><description>accomplished: successfully created snapshot</description></item>
            /// <item><description>failed: snapshot that failed to be created</description></item>
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
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testRC</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test01</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The usage of the snapshot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>image: The snapshot is used to create a custom image.</description></item>
            /// <item><description>disk: The snapshot is used to create a cloud disk.</description></item>
            /// <item><description>image_disk: The snapshot is used to create a data cloud disk and a custom image.</description></item>
            /// <item><description>none: The snapshot is not used.</description></item>
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
