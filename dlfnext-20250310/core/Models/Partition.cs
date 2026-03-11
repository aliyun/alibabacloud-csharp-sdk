// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Partition : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1747120676378</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("done")]
        [Validation(Required=false)]
        public bool? Done { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("fileCount")]
        [Validation(Required=false)]
        public long? FileCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("fileSizeInBytes")]
        [Validation(Required=false)]
        public long? FileSizeInBytes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1741701564261</para>
        /// </summary>
        [NameInMap("lastFileCreationTime")]
        [Validation(Required=false)]
        public long? LastFileCreationTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("recordCount")]
        [Validation(Required=false)]
        public long? RecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;year&quot;:&quot;2025&quot;}</para>
        /// </summary>
        [NameInMap("spec")]
        [Validation(Required=false)]
        public Dictionary<string, object> Spec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("storageAction")]
        [Validation(Required=false)]
        public string StorageAction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1758189669915</para>
        /// </summary>
        [NameInMap("storageActionTimestamp")]
        [Validation(Required=false)]
        public long? StorageActionTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("storageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        [NameInMap("totalBuckets")]
        [Validation(Required=false)]
        public int? TotalBuckets { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

    }

}
