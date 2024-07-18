// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceDataBloatResponseBody : TeaModel {
        /// <summary>
        /// The queried data bloat.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceDataBloatResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceDataBloatResponseBodyItems : TeaModel {
            /// <summary>
            /// The coefficient of data bloat. It is calculated by using the following formula:
            /// 
            /// Bloat coefficient = Number of dead rows/Number of active rows.
            /// </summary>
            [NameInMap("BloatCeoff")]
            [Validation(Required=false)]
            public string BloatCeoff { get; set; }

            /// <summary>
            /// The bloat size of the table. It indicates the amount of space that can be released.
            /// </summary>
            [NameInMap("BloatSize")]
            [Validation(Required=false)]
            public string BloatSize { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The expected size of the table.
            /// 
            /// It indicates the size of the table that has no data bloat.
            /// </summary>
            [NameInMap("ExpectTableSize")]
            [Validation(Required=false)]
            public string ExpectTableSize { get; set; }

            /// <summary>
            /// The actual size of the table.
            /// </summary>
            [NameInMap("RealTableSize")]
            [Validation(Required=false)]
            public string RealTableSize { get; set; }

            /// <summary>
            /// The name of the schema.
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// The sequence number.
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// The storage type of the table. Valid values:
            /// 
            /// *   **Heap Table**
            /// *   **Append-Only Heap Table**
            /// *   **Append-Only Columnar Table**
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// This parameter is not returned.
            /// </summary>
            [NameInMap("SuggestedAction")]
            [Validation(Required=false)]
            public string SuggestedAction { get; set; }

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

            /// <summary>
            /// The time when the table was last vacuumed. The time is displayed in UTC.
            /// </summary>
            [NameInMap("TimeLastVacuumed")]
            [Validation(Required=false)]
            public string TimeLastVacuumed { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
