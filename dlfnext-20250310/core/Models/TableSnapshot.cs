// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableSnapshot : TeaModel {
        /// <summary>
        /// <para>The total number of files in the snapshot.</para>
        /// </summary>
        [NameInMap("fileCount")]
        [Validation(Required=false)]
        public long? FileCount { get; set; }

        /// <summary>
        /// <para>The total size of all files in the snapshot, in bytes.</para>
        /// </summary>
        [NameInMap("fileSizeInBytes")]
        [Validation(Required=false)]
        public long? FileSizeInBytes { get; set; }

        /// <summary>
        /// <para>The creation time of the most recent file in the snapshot, as a Unix timestamp in milliseconds.</para>
        /// </summary>
        [NameInMap("lastFileCreationTime")]
        [Validation(Required=false)]
        public long? LastFileCreationTime { get; set; }

        /// <summary>
        /// <para>The total number of partitions in the table.</para>
        /// </summary>
        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public long? PartitionCount { get; set; }

        /// <summary>
        /// <para>The total number of records in the snapshot.</para>
        /// </summary>
        [NameInMap("recordCount")]
        [Validation(Required=false)]
        public long? RecordCount { get; set; }

        /// <summary>
        /// <para>Contains detailed information about the snapshot.</para>
        /// </summary>
        [NameInMap("snapshot")]
        [Validation(Required=false)]
        public Snapshot Snapshot { get; set; }

        /// <summary>
        /// <para>The total number of buckets in the table.</para>
        /// </summary>
        [NameInMap("totalBuckets")]
        [Validation(Required=false)]
        public int? TotalBuckets { get; set; }

    }

}
