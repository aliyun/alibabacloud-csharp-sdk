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

        /// <summary>
        /// <para>Creation timestamp in milliseconds</para>
        /// </summary>
        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public long? PartitionCount { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

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

    }

}
