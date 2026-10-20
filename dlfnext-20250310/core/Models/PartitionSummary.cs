// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class PartitionSummary : TeaModel {
        /// <summary>
        /// <para>The partition creation time.</para>
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
        /// <para>The last data access time.</para>
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
        /// <para>The partition name.</para>
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
        /// <para>The storage class transition time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764556155852</para>
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
        /// <para>table_name</para>
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
        /// <para>The total number of file accesses in the last 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalFileAccessNum30d")]
        [Validation(Required=false)]
        public long? TotalFileAccessNum30d { get; set; }

        /// <summary>
        /// <para>The total number of file accesses in the last 7 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("totalFileAccessNum7d")]
        [Validation(Required=false)]
        public long? TotalFileAccessNum7d { get; set; }

        /// <summary>
        /// <para>The total number of files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

        /// <summary>
        /// <para>The storage capacity in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public long? TotalFileSizeInBytes { get; set; }

        /// <summary>
        /// <para>The last update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
