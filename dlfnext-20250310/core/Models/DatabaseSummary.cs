// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class DatabaseSummary : TeaModel {
        /// <summary>
        /// <para>Creation timestamp in milliseconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>库名 - Database name</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>Last profile update date in format yyyyMMdd</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-01</para>
        /// </summary>
        [NameInMap("generatedDate")]
        [Validation(Required=false)]
        public string GeneratedDate { get; set; }

        /// <summary>
        /// <para>Storage location URI</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://clg-paimon-xxx/db-xxx</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

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
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public long? PartitionCount { get; set; }

        /// <summary>
        /// <para>Total storage in bytes</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("tableCount")]
        [Validation(Required=false)]
        public long? TableCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

        /// <summary>
        /// <para>Total file count</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048576</para>
        /// </summary>
        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public long? TotalFileSizeInBytes { get; set; }

        [NameInMap("totalMetaFileCount")]
        [Validation(Required=false)]
        public long? TotalMetaFileCount { get; set; }

        [NameInMap("totalMetaSizeInBytes")]
        [Validation(Required=false)]
        public long? TotalMetaSizeInBytes { get; set; }

    }

}
