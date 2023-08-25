// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountAllPrivilegesResponseBody : TeaModel {
        /// <summary>
        /// Details of the permissions.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAccountAllPrivilegesResponseBodyData Data { get; set; }
        public class DescribeAccountAllPrivilegesResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates the position where the results are truncated. When a value of `true` is returned for the `Truncated` parameter, this parameter is present and contains the value to use for the Marker parameter in a subsequent call.
            /// </summary>
            [NameInMap("Marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// The permissions.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeAccountAllPrivilegesResponseBodyDataResult> Result { get; set; }
            public class DescribeAccountAllPrivilegesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The objects on which the permission takes effect, including databases, tables, and columns. If Global is returned for the PrivilegeType parameter, an empty string is returned for this parameter.
                /// </summary>
                [NameInMap("PrivilegeObject")]
                [Validation(Required=false)]
                public DescribeAccountAllPrivilegesResponseBodyDataResultPrivilegeObject PrivilegeObject { get; set; }
                public class DescribeAccountAllPrivilegesResponseBodyDataResultPrivilegeObject : TeaModel {
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
                /// The permission level of the database account. You can call the `DescribeEnabledPrivileges` operation to query the permission level of the database account.
                /// </summary>
                [NameInMap("PrivilegeType")]
                [Validation(Required=false)]
                public string PrivilegeType { get; set; }

                /// <summary>
                /// The name of the permission, which is the same as the permission name returned by the `DescribeEnabledPrivileges` operation.
                /// </summary>
                [NameInMap("Privileges")]
                [Validation(Required=false)]
                public List<string> Privileges { get; set; }

            }

            /// <summary>
            /// Indicates whether the results are truncated. If the results are truncated, a value of `true` is returned. In this case, you must call this operation again to obtain all the results until a value of `false` is returned for this parameter.
            /// </summary>
            [NameInMap("Truncated")]
            [Validation(Required=false)]
            public bool? Truncated { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
