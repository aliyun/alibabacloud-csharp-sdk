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
        /// <para>The number of entries returned per page.</para>
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
        /// <para>The details of snapshots.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeRCSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeRCSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <para>Indicates whether the snapshot can be shared and used to create or roll back a cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <item><description>Standard: standard snapshot</description></item>
            /// <item><description>Flash: local snapshot This value will be deprecated. The local snapshot feature is replaced with the instant access feature.</description></item>
            /// <item><description>archive: archived snapshot</description></item>
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
            /// <para>The snapshot description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zd_test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the snapshot was encrypted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
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
            /// <para>The progress of the snapshot creation task in percentage.</para>
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
            /// <para>s-2ze8klip00xcogcwer76</para>
            /// </summary>
            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            /// <summary>
            /// <para>The snapshot type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>auto or timer: automatically created snapshot</description></item>
            /// <item><description>user: manually created snapshot</description></item>
            /// <item><description>all: all snapshot types</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("SnapshotType")]
            [Validation(Required=false)]
            public string SnapshotType { get; set; }

            /// <summary>
            /// <para>The ID of the original disk. This parameter is retained even after the original disk for which the snapshot was created is released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rcd-bp67acfmxazb4ph****</para>
            /// </summary>
            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            /// <summary>
            /// <para>The storage capacity of the original disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("SourceDiskSize")]
            [Validation(Required=false)]
            public long? SourceDiskSize { get; set; }

            /// <summary>
            /// <para>The type of the original disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM: system disk</description></item>
            /// <item><description>DATA: data disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>data</para>
            /// </summary>
            [NameInMap("SourceDiskType")]
            [Validation(Required=false)]
            public string SourceDiskType { get; set; }

            /// <summary>
            /// <para>The type of the source disk.</para>
            /// <remarks>
            /// <para> This parameter will be removed in the future. To ensure future compatibility, we recommend that you use other parameters.</para>
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
            /// <item><description>failed: The snapshot fails to be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>progressing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeRCSnapshotsResponseBodySnapshotsTag> Tag { get; set; }
            public class DescribeRCSnapshotsResponseBodySnapshotsTag : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the snapshot is used to create custom images or disks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>image: The snapshot is used to create custom images.</description></item>
            /// <item><description>disk: The snapshot is used to create disks.</description></item>
            /// <item><description>image_disk: The snapshot is used to create custom images and data disks.</description></item>
            /// <item><description>none: The snapshot is not used to create custom images or disks.</description></item>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
