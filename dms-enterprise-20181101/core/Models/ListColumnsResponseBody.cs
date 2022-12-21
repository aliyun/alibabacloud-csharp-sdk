// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListColumnsResponseBody : TeaModel {
        /// <summary>
        /// The information about the columns returned.
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
                /// Indicates whether the field is an auto-increment field. Valid values:
                /// 
                /// *   true: The field is an auto-increment field.
                /// *   false: The field is not an auto-increment field.
                /// </summary>
                [NameInMap("AutoIncrement")]
                [Validation(Required=false)]
                public bool? AutoIncrement { get; set; }

                /// <summary>
                /// The ID of the field.
                /// </summary>
                [NameInMap("ColumnId")]
                [Validation(Required=false)]
                public string ColumnId { get; set; }

                /// <summary>
                /// The name of the field.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// The data type of the field.
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
                /// The default value of the field.
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// The description of the field.
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
                /// Indicates whether the field can be empty. Valid values:
                /// 
                /// *   **true**: The field can be empty.
                /// *   **false**: The field cannot be empty.
                /// </summary>
                [NameInMap("Nullable")]
                [Validation(Required=false)]
                public bool? Nullable { get; set; }

                /// <summary>
                /// The security level of the field. Valid values:
                /// 
                /// *   INNER: The field is an internal field but not sensitive.
                /// *   SENSITIVE: The field is a sensitive field.
                /// *   CONFIDENTIAL: The field is a confidential field.
                /// 
                /// >  For more information, see [Adjust the sensitivity level of one or more fields](~~66091~~).
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// Indicates whether the field is a sensitive field. Valid values:
                /// 
                /// *   **true**: The field is a sensitive field.
                /// *   **false**: The field is not a sensitive field.
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
        /// - **true**: The request was successful.
        /// - **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
