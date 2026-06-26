// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableSummary : TeaModel {
        /// <summary>
        /// <para>The timestamp, in milliseconds, indicating when the table was created.</para>
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
        /// <para>The generation date of the storage summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-01</para>
        /// </summary>
        [NameInMap("generatedDate")]
        [Validation(Required=false)]
        public string GeneratedDate { get; set; }

        /// <summary>
        /// <para>The timestamp, in milliseconds, indicating when the table data was last accessed.</para>
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
        /// <para>The total size of data files in the Archive storage class, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeArchiveSize")]
        [Validation(Required=false)]
        public long? ObjTypeArchiveSize { get; set; }

        /// <summary>
        /// <para>The total size of data files in the Cold Archive storage class, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeColdArchiveSize")]
        [Validation(Required=false)]
        public long? ObjTypeColdArchiveSize { get; set; }

        /// <summary>
        /// <para>The total size of data files in the Infrequent Access storage class, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeIaSize")]
        [Validation(Required=false)]
        public long? ObjTypeIaSize { get; set; }

        /// <summary>
        /// <para>The total size of data files in the Standard storage class, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeStandardSize")]
        [Validation(Required=false)]
        public long? ObjTypeStandardSize { get; set; }

        /// <summary>
        /// <para>The total number of partitions in the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public long? PartitionCount { get; set; }

        /// <summary>
        /// <para>The storage location of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://clg-xxxx/db-xxxx/tbl-xxxx</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The storage action parameters.</para>
        /// </summary>
        [NameInMap("storageActionParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> StorageActionParams { get; set; }

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
        /// <para>The total number of files in the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

        /// <summary>
        /// <para>The total storage capacity of the table, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public long? TotalFileSizeInBytes { get; set; }

        /// <summary>
        /// <para>The total number of metadata files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalMetaFileCount")]
        [Validation(Required=false)]
        public long? TotalMetaFileCount { get; set; }

        /// <summary>
        /// <para>The total size of metadata files, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("totalMetaSizeInBytes")]
        [Validation(Required=false)]
        public long? TotalMetaSizeInBytes { get; set; }

        /// <summary>
        /// <para>The number of Standard or Infrequent Access partitions unaccessed in the last 180 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("unaccessedStdIaPartitionCount180d")]
        [Validation(Required=false)]
        public long? UnaccessedStdIaPartitionCount180d { get; set; }

        /// <summary>
        /// <para>The number of Standard partitions unaccessed in the last 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("unaccessedStdPartitionCount30d")]
        [Validation(Required=false)]
        public long? UnaccessedStdPartitionCount30d { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
