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
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>库名 - Database name</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>Last profile update date in format yyyyMMdd</para>
        /// </summary>
        [NameInMap("generatedDate")]
        [Validation(Required=false)]
        public string GeneratedDate { get; set; }

        /// <summary>
        /// <para>Storage location URI</para>
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

        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public long? PartitionCount { get; set; }

        /// <summary>
        /// <para>Total storage in bytes</para>
        /// </summary>
        [NameInMap("tableCount")]
        [Validation(Required=false)]
        public long? TableCount { get; set; }

        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

        /// <summary>
        /// <para>Total file count</para>
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
