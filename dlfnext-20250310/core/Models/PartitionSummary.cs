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
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>Database name</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>Total files in partition</para>
        /// </summary>
        [NameInMap("lastAccessTime")]
        [Validation(Required=false)]
        public long? LastAccessTime { get; set; }

        /// <summary>
        /// <para>Partition identifier</para>
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
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>24h access count</para>
        /// </summary>
        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

        /// <summary>
        /// <para>Last data access timestamp in milliseconds</para>
        /// </summary>
        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public long? TotalFileSizeInBytes { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
