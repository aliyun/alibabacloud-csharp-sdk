// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAdbMySqlColumnsResponseBody : TeaModel {
        /// <summary>
        /// The total number of columns.
        /// </summary>
        [NameInMap("ColumnCount")]
        [Validation(Required=false)]
        public int? ColumnCount { get; set; }

        /// <summary>
        /// Details of the columns.
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<DescribeAdbMySqlColumnsResponseBodyColumns> Columns { get; set; }
        public class DescribeAdbMySqlColumnsResponseBodyColumns : TeaModel {
            /// <summary>
            /// The comments of the column.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The name of the column.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The data type of the column.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The message returned for the operation. Valid values:
        /// 
        /// *   **Success** is returned if the operation is successful.
        /// *   An error message is returned if the operation fails.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// Indicates whether the operation is successful. Valid values:
        /// 
        /// *   **true**: The operation is successful.
        /// *   **false**: The operation fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The name of the table.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
