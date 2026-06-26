// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableCompactionHistory : TeaModel {
        /// <summary>
        /// <para>The number of files after compaction.</para>
        /// </summary>
        [NameInMap("afterFilesCount")]
        [Validation(Required=false)]
        public long? AfterFilesCount { get; set; }

        /// <summary>
        /// <para>The total size of files after compaction.</para>
        /// </summary>
        [NameInMap("afterFilesSize")]
        [Validation(Required=false)]
        public long? AfterFilesSize { get; set; }

        /// <summary>
        /// <para>The number of files before compaction.</para>
        /// </summary>
        [NameInMap("beforeFilesCount")]
        [Validation(Required=false)]
        public long? BeforeFilesCount { get; set; }

        /// <summary>
        /// <para>The creation time of the last file before compaction.</para>
        /// </summary>
        [NameInMap("beforeFilesLastCreationTime")]
        [Validation(Required=false)]
        public long? BeforeFilesLastCreationTime { get; set; }

        /// <summary>
        /// <para>The total size of files before compaction.</para>
        /// </summary>
        [NameInMap("beforeFilesSize")]
        [Validation(Required=false)]
        public long? BeforeFilesSize { get; set; }

        /// <summary>
        /// <para>The catalog ID.</para>
        /// </summary>
        [NameInMap("catalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// <para>The compaction commit time.</para>
        /// </summary>
        [NameInMap("commitTime")]
        [Validation(Required=false)]
        public long? CommitTime { get; set; }

        /// <summary>
        /// <para>The snapshot ID.</para>
        /// </summary>
        [NameInMap("snapshotId")]
        [Validation(Required=false)]
        public long? SnapshotId { get; set; }

        /// <summary>
        /// <para>The table ID.</para>
        /// </summary>
        [NameInMap("tableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// <para>The time when the record was last updated.</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>The user who updated the record.</para>
        /// </summary>
        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

    }

}
