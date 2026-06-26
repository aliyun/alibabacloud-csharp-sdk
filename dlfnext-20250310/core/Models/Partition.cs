// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Partition : TeaModel {
        /// <summary>
        /// <para>The time when the partition was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1747120676378</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The creator of the partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>Indicates whether the process is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("done")]
        [Validation(Required=false)]
        public bool? Done { get; set; }

        /// <summary>
        /// <para>The number of files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("fileCount")]
        [Validation(Required=false)]
        public long? FileCount { get; set; }

        /// <summary>
        /// <para>The file size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("fileSizeInBytes")]
        [Validation(Required=false)]
        public long? FileSizeInBytes { get; set; }

        /// <summary>
        /// <para>The time when the latest file was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741701564261</para>
        /// </summary>
        [NameInMap("lastFileCreationTime")]
        [Validation(Required=false)]
        public long? LastFileCreationTime { get; set; }

        /// <summary>
        /// <para>The number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("recordCount")]
        [Validation(Required=false)]
        public long? RecordCount { get; set; }

        /// <summary>
        /// <para>The key-value pairs of the partition values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;year&quot;:&quot;2025&quot;}</para>
        /// </summary>
        [NameInMap("spec")]
        [Validation(Required=false)]
        public Dictionary<string, object> Spec { get; set; }

        /// <summary>
        /// <para>The status of the storage class conversion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("storageAction")]
        [Validation(Required=false)]
        public string StorageAction { get; set; }

        /// <summary>
        /// <para>The storage class conversion time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1758189669915</para>
        /// </summary>
        [NameInMap("storageActionTimestamp")]
        [Validation(Required=false)]
        public long? StorageActionTimestamp { get; set; }

        /// <summary>
        /// <para>The storage class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("storageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        /// <summary>
        /// <para>The total number of buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalBuckets")]
        [Validation(Required=false)]
        public int? TotalBuckets { get; set; }

        /// <summary>
        /// <para>The time when the partition was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>The user who last updated the partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

    }

}
