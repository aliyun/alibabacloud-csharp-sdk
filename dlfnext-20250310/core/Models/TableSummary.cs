// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableSummary : TeaModel {
        /// <summary>
        /// <para>The table creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The update date of the storage overview data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-01</para>
        /// </summary>
        [NameInMap("generatedDate")]
        [Validation(Required=false)]
        public string GeneratedDate { get; set; }

        /// <summary>
        /// <para>The last data access time of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("lastAccessTime")]
        [Validation(Required=false)]
        public long? LastAccessTime { get; set; }

        /// <summary>
        /// <para>The last requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("lastRequester")]
        [Validation(Required=false)]
        public string LastRequester { get; set; }

        /// <summary>
        /// <para>The storage size of the latest snapshot, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("latestSnapshotDataSizeInBytes")]
        [Validation(Required=false)]
        public long? LatestSnapshotDataSizeInBytes { get; set; }

        /// <summary>
        /// <para>The storage size of archive data files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeArchiveSize")]
        [Validation(Required=false)]
        public long? ObjTypeArchiveSize { get; set; }

        /// <summary>
        /// <para>The storage size of cold archive data files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeColdArchiveSize")]
        [Validation(Required=false)]
        public long? ObjTypeColdArchiveSize { get; set; }

        /// <summary>
        /// <para>The storage size of infrequent access data files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeIaSize")]
        [Validation(Required=false)]
        public long? ObjTypeIaSize { get; set; }

        /// <summary>
        /// <para>The storage size of standard data files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeStandardSize")]
        [Validation(Required=false)]
        public long? ObjTypeStandardSize { get; set; }

        /// <summary>
        /// <para>The total number of partitions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public long? PartitionCount { get; set; }

        /// <summary>
        /// <para>The storage location.</para>
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

        /// <summary>
        /// <para>The storage class transition time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1767491579459</para>
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
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The top requester of the day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("topRequester")]
        [Validation(Required=false)]
        public string TopRequester { get; set; }

        /// <summary>
        /// <para>The total number of file accesses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalFileAccessNum")]
        [Validation(Required=false)]
        public long? TotalFileAccessNum { get; set; }

        /// <summary>
        /// <para>The total number of file accesses in the last 7 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalFileAccessNum30d")]
        [Validation(Required=false)]
        public long? TotalFileAccessNum30d { get; set; }

        /// <summary>
        /// <para>The total number of file accesses in the last 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("totalFileAccessNum7d")]
        [Validation(Required=false)]
        public long? TotalFileAccessNum7d { get; set; }

        /// <summary>
        /// <para>The total number of table files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

        /// <summary>
        /// <para>The table storage capacity, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public long? TotalFileSizeInBytes { get; set; }

        /// <summary>
        /// <para>The number of metadata files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalMetaFileCount")]
        [Validation(Required=false)]
        public long? TotalMetaFileCount { get; set; }

        /// <summary>
        /// <para>The storage size of metadata files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("totalMetaSizeInBytes")]
        [Validation(Required=false)]
        public long? TotalMetaSizeInBytes { get; set; }

        /// <summary>
        /// <para>The number of standard or infrequent access partitions that have not been accessed in the last 180 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("unaccessedStdIaPartitionCount180d")]
        [Validation(Required=false)]
        public long? UnaccessedStdIaPartitionCount180d { get; set; }

        /// <summary>
        /// <para>The number of standard storage partitions that have not been accessed in the last 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("unaccessedStdPartitionCount30d")]
        [Validation(Required=false)]
        public long? UnaccessedStdPartitionCount30d { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764555981383</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
