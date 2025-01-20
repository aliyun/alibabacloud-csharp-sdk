// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
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
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about snapshots.</para>
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
                /// <para>The time when snapshot creation was complete.</para>
                /// <para>The time follows the <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO 8601</a> standard in UTC. The time is displayed in the <c>yyyy-MM-ddThh:mmZ</c> format.</para>
                /// <remarks>
                /// <para> This parameter is valid only when the snapshot is created. During snapshot creation, the value of this parameter is the same as that of CreateTime.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2014-07-24T13:10:52Z</para>
                /// </summary>
                [NameInMap("CompletedTime")]
                [Validation(Required=false)]
                public string CompletedTime { get; set; }

                /// <summary>
                /// <para>The time when the snapshot was created.</para>
                /// <para>The time follows the <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO 8601</a> standard in UTC. The time is displayed in the <c>yyyy-MM-ddThh:mmZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2014-07-24T13:00:52Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the snapshot is encrypted.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The snapshot is not encrypted.</description></item>
                /// <item><description>1: The snapshot is encrypted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public int? EncryptType { get; set; }

                /// <summary>
                /// <para>The type of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>extreme</para>
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// <para>The progress of the snapshot creation. The value of this parameter is expressed as a percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The remaining time that is required to create the snapshot.</para>
                /// <para>Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38</para>
                /// </summary>
                [NameInMap("RemainTime")]
                [Validation(Required=false)]
                public int? RemainTime { get; set; }

                /// <summary>
                /// <para>The retention period of the auto snapshot.</para>
                /// <para>Unit: days.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>\-1: Auto snapshots are permanently retained. After the number of auto snapshots exceeds the upper limit, the earliest auto snapshot is automatically deleted.</description></item>
                /// <item><description>1 to 65536: Auto snapshots are retained for the specified days. After the retention period of auto snapshots expires, the auto snapshots are automatically deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("RetentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

                /// <summary>
                /// <para>The snapshot ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-extreme-snapsho****</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                /// <summary>
                /// <para>The snapshot name.</para>
                /// <para>If you specify a name to create a snapshot, the name of the snapshot is returned. Otherwise, no value is returned for this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("SnapshotName")]
                [Validation(Required=false)]
                public string SnapshotName { get; set; }

                /// <summary>
                /// <para>The snapshot type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>auto: automatically created snapshots</description></item>
                /// <item><description>user: manually created snapshots</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("SnapshotType")]
                [Validation(Required=false)]
                public string SnapshotType { get; set; }

                /// <summary>
                /// <para>The ID of the source file system.</para>
                /// <para>This parameter is retained even if the source file system of the snapshot is deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>extreme-012****</para>
                /// </summary>
                [NameInMap("SourceFileSystemId")]
                [Validation(Required=false)]
                public string SourceFileSystemId { get; set; }

                /// <summary>
                /// <para>The capacity of the source file system.</para>
                /// <para>Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("SourceFileSystemSize")]
                [Validation(Required=false)]
                public long? SourceFileSystemSize { get; set; }

                /// <summary>
                /// <para>The version of the source file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SourceFileSystemVersion")]
                [Validation(Required=false)]
                public string SourceFileSystemVersion { get; set; }

                /// <summary>
                /// <para>The status of the snapshot.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>progressing: The snapshot is being created.</description></item>
                /// <item><description>accomplished: The snapshot is created.</description></item>
                /// <item><description>failed: The snapshot fails to be created.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>accomplished</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of snapshots returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
