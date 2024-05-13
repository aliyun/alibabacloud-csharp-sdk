// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListColumnsResponseBody : TeaModel {
        /// <summary>
        /// The details about columns.
        /// </summary>
        [NameInMap("ColumnList")]
        [Validation(Required=false)]
        public ListColumnsResponseBodyColumnList ColumnList { get; set; }
        public class ListColumnsResponseBodyColumnList : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public List<ListColumnsResponseBodyColumnListColumn> Column { get; set; }
            public class ListColumnsResponseBodyColumnListColumn : TeaModel {
                /// <summary>
                /// Indicates whether the column is an auto-increment column. Valid values:
                /// 
                /// *   true: The column is an auto-increment column.
                /// *   false: The column is not an auto-increment column.
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
                /// The number of valid digits for the field.
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
                /// The default value of the column.
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// The description of the column.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The type of the masking algorithm that is used for the field. Valid values:
                /// 
                /// *   null: No masking algorithm is used.
                /// *   DEFAULT: A full masking algorithm is used.
                /// *   FIX_POS: The fixed position is masked.
                /// *   FIX_CHAR: The fixed characters are replaced.
                /// </summary>
                [NameInMap("FunctionType")]
                [Validation(Required=false)]
                public string FunctionType { get; set; }

                /// <summary>
                /// Indicates whether the column can be empty. Valid values:
                /// 
                /// *   **true**: The column can be empty.
                /// *   **false**: The column cannot be empty.
                /// </summary>
                [NameInMap("Nullable")]
                [Validation(Required=false)]
                public bool? Nullable { get; set; }

                /// <summary>
                /// The security level of the column. Valid values:
                /// 
                /// *   INNER: The column is an internal column but not sensitive.
                /// *   SENSITIVE: The column is a sensitive column.
                /// *   CONFIDENTIAL: The column is a confidential column.
                /// 
                /// > For more information, see [Sensitivity levels of fields](https://help.aliyun.com/document_detail/66091.html).
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// Indicates whether the column is a sensitive column. Valid values:
                /// 
                /// *   **true**: The column is a sensitive column.
                /// *   **false**: The column is not a sensitive column.
                /// </summary>
                [NameInMap("Sensitive")]
                [Validation(Required=false)]
                public bool? Sensitive { get; set; }

            }

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
