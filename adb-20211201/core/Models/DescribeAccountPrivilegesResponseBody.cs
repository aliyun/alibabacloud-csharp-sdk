// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountPrivilegesResponseBody : TeaModel {
        /// <summary>
        /// Details of the permissions.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAccountPrivilegesResponseBodyData> Data { get; set; }
        public class DescribeAccountPrivilegesResponseBodyData : TeaModel {
            /// <summary>
            /// The objects on which the permission takes effect, including databases, tables, columns, and additional descriptions.
            /// </summary>
            [NameInMap("PrivilegeObject")]
            [Validation(Required=false)]
            public DescribeAccountPrivilegesResponseBodyDataPrivilegeObject PrivilegeObject { get; set; }
            public class DescribeAccountPrivilegesResponseBodyDataPrivilegeObject : TeaModel {
                /// <summary>
                /// The name of the column.
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The description of the permission object.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            /// <summary>
            /// The permission level of the permission. Valid values: `Global`, `Database`, `Table`, and `Column`. You can call the `DescribeEnabledPrivileges` parameter to query the permission level of a specific permission.
            /// </summary>
            [NameInMap("PrivilegeType")]
            [Validation(Required=false)]
            public string PrivilegeType { get; set; }

            /// <summary>
            /// The name of the permission. You can call the `DescribeEnabledPrivileges` operation to query the name of the permission.
            /// </summary>
            [NameInMap("Privileges")]
            [Validation(Required=false)]
            public List<string> Privileges { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
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
