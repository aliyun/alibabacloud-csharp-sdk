// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceIndexUsageResponseBody : TeaModel {
        /// <summary>
        /// The queried index usage.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceIndexUsageResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceIndexUsageResponseBodyItems : TeaModel {
            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The definition of the index.
            /// </summary>
            [NameInMap("IndexDef")]
            [Validation(Required=false)]
            public string IndexDef { get; set; }

            /// <summary>
            /// The name of the index.
            /// </summary>
            [NameInMap("IndexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

            /// <summary>
            /// The number of index scans.
            /// </summary>
            [NameInMap("IndexScanTimes")]
            [Validation(Required=false)]
            public long? IndexScanTimes { get; set; }

            /// <summary>
            /// The size of the index. Unit: bytes.
            /// </summary>
            [NameInMap("IndexSize")]
            [Validation(Required=false)]
            public string IndexSize { get; set; }

            /// <summary>
            /// Indicates whether the table is a partitioned table. Valid values:
            /// 
            /// *   **true**: The table is a partitioned table.
            /// *   **false**: The table is not a partitioned table.
            /// </summary>
            [NameInMap("IsPartitionTable")]
            [Validation(Required=false)]
            public bool? IsPartitionTable { get; set; }

            /// <summary>
            /// The name of the parent table.
            /// </summary>
            [NameInMap("ParentTableName")]
            [Validation(Required=false)]
            public string ParentTableName { get; set; }

            /// <summary>
            /// The name of the schema.
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// The name of the table.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// The time when the table was last deleted, inserted, or updated.
            /// </summary>
            [NameInMap("TimeLastUpdated")]
            [Validation(Required=false)]
            public string TimeLastUpdated { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
