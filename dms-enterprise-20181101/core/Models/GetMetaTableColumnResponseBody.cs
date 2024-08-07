// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetMetaTableColumnResponseBody : TeaModel {
        /// <summary>
        /// The details about fields in the table.
        /// </summary>
        [NameInMap("ColumnList")]
        [Validation(Required=false)]
        public List<GetMetaTableColumnResponseBodyColumnList> ColumnList { get; set; }
        public class GetMetaTableColumnResponseBodyColumnList : TeaModel {
            /// <summary>
            /// Indicates whether the column is an auto-increment column. Valid values:
            /// 
            /// *   **true**: The column is an auto-increment column.
            /// *   **false**: The column is not an auto-increment column.
            /// </summary>
            [NameInMap("AutoIncrement")]
            [Validation(Required=false)]
            public bool? AutoIncrement { get; set; }

            /// <summary>
            /// The ID of the column.
            /// </summary>
            [NameInMap("ColumnId")]
            [Validation(Required=false)]
            public string ColumnId { get; set; }

            /// <summary>
            /// The name of the column.
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// The data type of the column.
            /// 
            /// > The return value of a column is not unique, such as **bigint** or **int**.
            /// </summary>
            [NameInMap("ColumnType")]
            [Validation(Required=false)]
            public string ColumnType { get; set; }

            /// <summary>
            /// The length of the field.
            /// </summary>
            [NameInMap("DataLength")]
            [Validation(Required=false)]
            public long? DataLength { get; set; }

            /// <summary>
            /// The precision of the field.
            /// </summary>
            [NameInMap("DataPrecision")]
            [Validation(Required=false)]
            public int? DataPrecision { get; set; }

            /// <summary>
            /// The number of decimal places for the field.
            /// </summary>
            [NameInMap("DataScale")]
            [Validation(Required=false)]
            public int? DataScale { get; set; }

            /// <summary>
            /// The description of the column.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the field can be empty. Valid values:
            /// 
            /// *   **true**: The field can be empty.
            /// *   **false**: The field cannot be empty.
            /// </summary>
            [NameInMap("Nullable")]
            [Validation(Required=false)]
            public bool? Nullable { get; set; }

            /// <summary>
            /// The position of the field in the table.
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public int? Position { get; set; }

            /// <summary>
            /// Indicates whether the field is the primary key. Valid values:
            /// 
            /// *   **true**: The field is the primary key.
            /// *   **false**: The field is not the primary key.
            /// </summary>
            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            /// <summary>
            /// The sensitivity level of the column. Valid values:
            /// 
            /// *   **INNER**: The column is not sensitive.
            /// *   **SENSITIVE**: The column is sensitive.
            /// *   **CONFIDENTIAL**: The column is confidential.
            /// 
            /// > For more information, see [Sensitivity levels of columns](https://help.aliyun.com/document_detail/66091.html).
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public string SecurityLevel { get; set; }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
