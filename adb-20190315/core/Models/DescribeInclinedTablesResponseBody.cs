// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeInclinedTablesResponseBody : TeaModel {
        /// <summary>
        /// The monitoring information about tables.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeInclinedTablesResponseBodyItems Items { get; set; }
        public class DescribeInclinedTablesResponseBodyItems : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeInclinedTablesResponseBodyItemsTable> Table { get; set; }
            public class DescribeInclinedTablesResponseBodyItemsTable : TeaModel {
                /// <summary>
                /// Indicates whether data is skewed in partitions of the table. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("IsIncline")]
                [Validation(Required=false)]
                public bool? IsIncline { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// The number of rows in the table.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// The type of the table. Valid values:
                /// 
                /// *   **FactTable**
                /// *   **DimensionTable**
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

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
        public string TotalCount { get; set; }

    }

}
