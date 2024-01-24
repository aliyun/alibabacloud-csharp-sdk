// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBroadcastTablesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the database is sharded.
        /// </summary>
        [NameInMap("IsShard")]
        [Validation(Required=false)]
        public bool? IsShard { get; set; }

        /// <summary>
        /// Indicates information about broadcast tables.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeBroadcastTablesResponseBodyList> List { get; set; }
        public class DescribeBroadcastTablesResponseBodyList : TeaModel {
            /// <summary>
            /// Indicates whether a table is a broadcast table.
            /// </summary>
            [NameInMap("Broadcast")]
            [Validation(Required=false)]
            public bool? Broadcast { get; set; }

            /// <summary>
            /// Indicates the type of the broadcast table. Valid values:
            /// 
            /// *   **1**: multi-write mode
            /// *   **2**: synchronous mode
            /// </summary>
            [NameInMap("BroadcastType")]
            [Validation(Required=false)]
            public string BroadcastType { get; set; }

            /// <summary>
            /// Indicates the storage type of the database. Valid values:
            /// 
            /// *   **0**: RDS
            /// *   **4**: PolarDB
            /// </summary>
            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public int? DbInstType { get; set; }

            /// <summary>
            /// Indicates whether the broadcast table was sharded.
            /// </summary>
            [NameInMap("IsShard")]
            [Validation(Required=false)]
            public bool? IsShard { get; set; }

            /// <summary>
            /// Indicates the activation state of the broadcast table. Valid values:
            /// 
            /// *   **1**: The broadcast table is activated.
            /// *   **2**: The broadcast table is being activated.
            /// *   **3**: An exception occurs when the broadcast table is being activated.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// Indicates the name of the table.
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

        }

        /// <summary>
        /// Indicates the page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Indicates the number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Indicates the ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Indicates the total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
