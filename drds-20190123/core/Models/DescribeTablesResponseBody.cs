// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeTablesResponseBody : TeaModel {
        /// <summary>
        /// The list of returned tables.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeTablesResponseBodyList> List { get; set; }
        public class DescribeTablesResponseBodyList : TeaModel {
            /// <summary>
            /// Indicates whether full table scanning is allowed.
            /// </summary>
            [NameInMap("AllowFullTableScan")]
            [Validation(Required=false)]
            public bool? AllowFullTableScan { get; set; }

            /// <summary>
            /// Indicates whether the table is a replicated table.
            /// </summary>
            [NameInMap("Broadcast")]
            [Validation(Required=false)]
            public bool? Broadcast { get; set; }

            /// <summary>
            /// The type of the PolarDB-X 1.0 instance. Valid values:
            /// 
            /// *   0: The instance is a dedicated instance.
            /// *   1: The instance is a shard instance.
            /// </summary>
            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public int? DbInstType { get; set; }

            /// <summary>
            /// Indicates whether the table is locked.
            /// </summary>
            [NameInMap("IsLocked")]
            [Validation(Required=false)]
            public bool? IsLocked { get; set; }

            /// <summary>
            /// Indicates whether the table is sharded.
            /// </summary>
            [NameInMap("IsShard")]
            [Validation(Required=false)]
            public bool? IsShard { get; set; }

            /// <summary>
            /// The shard key of the table.
            /// </summary>
            [NameInMap("ShardKey")]
            [Validation(Required=false)]
            public string ShardKey { get; set; }

            /// <summary>
            /// Indicates whether sharding tasks are performed on the table. Valid values:
            /// 
            /// *   0: No sharding task is performed on the table.
            /// *   1: Sharding tasks are performed on the table.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The name of the table.
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

        }

        /// <summary>
        /// The number of returned pages.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of tables returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
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
        /// The total number of returned tables.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
