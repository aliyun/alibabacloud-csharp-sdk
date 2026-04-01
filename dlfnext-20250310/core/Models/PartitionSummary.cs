// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class PartitionSummary : TeaModel {
        /// <summary>
        /// <para>Partition creation timestamp in milliseconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>Database name</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>Total files in partition</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("lastAccessTime")]
        [Validation(Required=false)]
        public long? LastAccessTime { get; set; }

        [NameInMap("lastRequester")]
        [Validation(Required=false)]
        public string LastRequester { get; set; }

        /// <summary>
        /// <para>Partition identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>hh=18</para>
        /// </summary>
        [NameInMap("partitionName")]
        [Validation(Required=false)]
        public string PartitionName { get; set; }

        [NameInMap("storageActionParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> StorageActionParams { get; set; }

        [NameInMap("storageActionTimestamp")]
        [Validation(Required=false)]
        public long? StorageActionTimestamp { get; set; }

        [NameInMap("storageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        /// <summary>
        /// <para>Table name</para>
        /// 
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("topRequester")]
        [Validation(Required=false)]
        public string TopRequester { get; set; }

        [NameInMap("totalFileAccessNum")]
        [Validation(Required=false)]
        public long? TotalFileAccessNum { get; set; }

        [NameInMap("totalFileAccessNum30d")]
        [Validation(Required=false)]
        public long? TotalFileAccessNum30d { get; set; }

        [NameInMap("totalFileAccessNum7d")]
        [Validation(Required=false)]
        public long? TotalFileAccessNum7d { get; set; }

        /// <summary>
        /// <para>24h access count</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

        /// <summary>
        /// <para>Last data access timestamp in milliseconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public long? TotalFileSizeInBytes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
