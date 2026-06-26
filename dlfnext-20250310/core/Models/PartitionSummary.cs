// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class PartitionSummary : TeaModel {
        /// <summary>
        /// <para>The creation timestamp for the partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The last access timestamp for the partition\&quot;s data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("lastAccessTime")]
        [Validation(Required=false)]
        public long? LastAccessTime { get; set; }

        /// <summary>
        /// <para>The last requester.</para>
        /// </summary>
        [NameInMap("lastRequester")]
        [Validation(Required=false)]
        public string LastRequester { get; set; }

        /// <summary>
        /// <para>The name of the partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hh=18</para>
        /// </summary>
        [NameInMap("partitionName")]
        [Validation(Required=false)]
        public string PartitionName { get; set; }

        /// <summary>
        /// <para>The storage action parameters.</para>
        /// </summary>
        [NameInMap("storageActionParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> StorageActionParams { get; set; }

        /// <summary>
        /// <para>The storage action timestamp.</para>
        /// </summary>
        [NameInMap("storageActionTimestamp")]
        [Validation(Required=false)]
        public long? StorageActionTimestamp { get; set; }

        /// <summary>
        /// <para>The storage class.</para>
        /// </summary>
        [NameInMap("storageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The top requester.</para>
        /// </summary>
        [NameInMap("topRequester")]
        [Validation(Required=false)]
        public string TopRequester { get; set; }

        /// <summary>
        /// <para>Total file access count.</para>
        /// </summary>
        [NameInMap("totalFileAccessNum")]
        [Validation(Required=false)]
        public long? TotalFileAccessNum { get; set; }

        /// <summary>
        /// <para>Total file access count over the last 30 days.</para>
        /// </summary>
        [NameInMap("totalFileAccessNum30d")]
        [Validation(Required=false)]
        public long? TotalFileAccessNum30d { get; set; }

        /// <summary>
        /// <para>Total file access count over the last 7 days.</para>
        /// </summary>
        [NameInMap("totalFileAccessNum7d")]
        [Validation(Required=false)]
        public long? TotalFileAccessNum7d { get; set; }

        /// <summary>
        /// <para>The total number of files in the partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

        /// <summary>
        /// <para>The total size, in bytes, of all files in the partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public long? TotalFileSizeInBytes { get; set; }

        /// <summary>
        /// <para>The last update timestamp for the partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
