// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableSummary : TeaModel {
        /// <summary>
        /// <para>Latest snapshot storage size</para>
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

        [NameInMap("generatedDate")]
        [Validation(Required=false)]
        public string GeneratedDate { get; set; }

        [NameInMap("lastAccessTime")]
        [Validation(Required=false)]
        public long? LastAccessTime { get; set; }

        [NameInMap("objTypeArchiveSize")]
        [Validation(Required=false)]
        public long? ObjTypeArchiveSize { get; set; }

        [NameInMap("objTypeColdArchiveSize")]
        [Validation(Required=false)]
        public long? ObjTypeColdArchiveSize { get; set; }

        [NameInMap("objTypeIaSize")]
        [Validation(Required=false)]
        public long? ObjTypeIaSize { get; set; }

        [NameInMap("objTypeStandardSize")]
        [Validation(Required=false)]
        public long? ObjTypeStandardSize { get; set; }

        /// <summary>
        /// <para>Creation timestamp in milliseconds</para>
        /// </summary>
        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public long? PartitionCount { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

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
        /// <para>30-day access count</para>
        /// </summary>
        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public long? TotalFileSizeInBytes { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
