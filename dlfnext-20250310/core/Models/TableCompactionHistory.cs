// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableCompactionHistory : TeaModel {
        /// <summary>
        /// <para>The total number of files after the merge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("afterFilesCount")]
        [Validation(Required=false)]
        public long? AfterFilesCount { get; set; }

        /// <summary>
        /// <para>The total size of the files after the merge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("afterFilesSize")]
        [Validation(Required=false)]
        public long? AfterFilesSize { get; set; }

        /// <summary>
        /// <para>The total number of files before the merge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("beforeFilesCount")]
        [Validation(Required=false)]
        public long? BeforeFilesCount { get; set; }

        /// <summary>
        /// <para>The latest creation time of the files before the merge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744969200000</para>
        /// </summary>
        [NameInMap("beforeFilesLastCreationTime")]
        [Validation(Required=false)]
        public long? BeforeFilesLastCreationTime { get; set; }

        /// <summary>
        /// <para>The total size of the files before the merge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("beforeFilesSize")]
        [Validation(Required=false)]
        public long? BeforeFilesSize { get; set; }

        /// <summary>
        /// <para>The ID of the data catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clg-paimon-d13*****</para>
        /// </summary>
        [NameInMap("catalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// <para>The commit time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1765890111419</para>
        /// </summary>
        [NameInMap("commitTime")]
        [Validation(Required=false)]
        public long? CommitTime { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("snapshotId")]
        [Validation(Required=false)]
        public long? SnapshotId { get; set; }

        /// <summary>
        /// <para>The ID of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tbl-*****</para>
        /// </summary>
        [NameInMap("tableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// <para>The time when the record was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>The user who updated the record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

    }

}
