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

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public DescribeSnapshotsResponseBodySnapshots Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("Snapshot")]
            [Validation(Required=false)]
            public List<DescribeSnapshotsResponseBodySnapshotsSnapshot> Snapshot { get; set; }
            public class DescribeSnapshotsResponseBodySnapshotsSnapshot : TeaModel {
                [NameInMap("CompletedTime")]
                [Validation(Required=false)]
                public string CompletedTime { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public int? EncryptType { get; set; }

                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("RemainTime")]
                [Validation(Required=false)]
                public int? RemainTime { get; set; }

                [NameInMap("RetentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                [NameInMap("SnapshotName")]
                [Validation(Required=false)]
                public string SnapshotName { get; set; }

                [NameInMap("SnapshotType")]
                [Validation(Required=false)]
                public string SnapshotType { get; set; }

                [NameInMap("SourceFileSystemId")]
                [Validation(Required=false)]
                public string SourceFileSystemId { get; set; }

                [NameInMap("SourceFileSystemSize")]
                [Validation(Required=false)]
                public long? SourceFileSystemSize { get; set; }

                [NameInMap("SourceFileSystemVersion")]
                [Validation(Required=false)]
                public string SourceFileSystemVersion { get; set; }

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
