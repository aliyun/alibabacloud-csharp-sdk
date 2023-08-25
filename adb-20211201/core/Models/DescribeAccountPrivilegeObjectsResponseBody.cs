// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountPrivilegeObjectsResponseBody : TeaModel {
        /// <summary>
        /// The permissions.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAccountPrivilegeObjectsResponseBodyData> Data { get; set; }
        public class DescribeAccountPrivilegeObjectsResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the column. This parameter is returned when PrivilegeType is set to Column.
            /// </summary>
            [NameInMap("Column")]
            [Validation(Required=false)]
            public string Column { get; set; }

            /// <summary>
            /// The name of the database. This parameter is returned when PrivilegeType is set to Database, Table, or Column.
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// The description that is specified when you create a table or column. This parameter is returned only when PrivilegeType is set to Database or Table, indicating the database description or table description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the table. This parameter is returned when PrivilegeType is set to Table or Column.
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
        public long? TotalCount { get; set; }

    }

}
