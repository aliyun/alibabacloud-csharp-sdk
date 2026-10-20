// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableSnapshot : TeaModel {
        /// <summary>
        /// <para>The number of files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63</para>
        /// </summary>
        [NameInMap("fileCount")]
        [Validation(Required=false)]
        public long? FileCount { get; set; }

        /// <summary>
        /// <para>The file size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>645631581</para>
        /// </summary>
        [NameInMap("fileSizeInBytes")]
        [Validation(Required=false)]
        public long? FileSizeInBytes { get; set; }

        /// <summary>
        /// <para>The creation time of the latest file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1761704112024</para>
        /// </summary>
        [NameInMap("lastFileCreationTime")]
        [Validation(Required=false)]
        public long? LastFileCreationTime { get; set; }

        /// <summary>
        /// <para>The number of partitions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public long? PartitionCount { get; set; }

        /// <summary>
        /// <para>The number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16627</para>
        /// </summary>
        [NameInMap("recordCount")]
        [Validation(Required=false)]
        public long? RecordCount { get; set; }

        /// <summary>
        /// <para>The name of the snapshot.</para>
        /// </summary>
        [NameInMap("snapshot")]
        [Validation(Required=false)]
        public Snapshot Snapshot { get; set; }

        /// <summary>
        /// <para>The total number of buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("totalBuckets")]
        [Validation(Required=false)]
        public int? TotalBuckets { get; set; }

    }

}
