// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetMetaTableDetailInfoResponseBody : TeaModel {
        /// <summary>
        /// The details of the table.
        /// </summary>
        [NameInMap("DetailInfo")]
        [Validation(Required=false)]
        public GetMetaTableDetailInfoResponseBodyDetailInfo DetailInfo { get; set; }
        public class GetMetaTableDetailInfoResponseBodyDetailInfo : TeaModel {
            /// <summary>
            /// The columns in the table.
            /// </summary>
            [NameInMap("ColumnList")]
            [Validation(Required=false)]
            public List<GetMetaTableDetailInfoResponseBodyDetailInfoColumnList> ColumnList { get; set; }
            public class GetMetaTableDetailInfoResponseBodyDetailInfoColumnList : TeaModel {
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
                /// The data type of the column. Examples: Bigint, Int, and Varchar.
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
                /// The scale of the column.
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
                /// Indicates whether the column is nullable. Valid values:
                /// 
                /// *   true: The column is nullable.
                /// *   false: The column is not nullable.
                /// </summary>
                [NameInMap("Nullable")]
                [Validation(Required=false)]
                public bool? Nullable { get; set; }

                /// <summary>
                /// The position of the field in the table.
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public string Position { get; set; }

            }

            /// <summary>
            /// The list of indexes.
            /// </summary>
            [NameInMap("IndexList")]
            [Validation(Required=false)]
            public List<GetMetaTableDetailInfoResponseBodyDetailInfoIndexList> IndexList { get; set; }
            public class GetMetaTableDetailInfoResponseBodyDetailInfoIndexList : TeaModel {
                /// <summary>
                /// The index column.
                /// </summary>
                [NameInMap("IndexColumns")]
                [Validation(Required=false)]
                public List<string> IndexColumns { get; set; }

                /// <summary>
                /// The ID of the index.
                /// </summary>
                [NameInMap("IndexId")]
                [Validation(Required=false)]
                public string IndexId { get; set; }

                /// <summary>
                /// The name of the index.
                /// </summary>
                [NameInMap("IndexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                /// <summary>
                /// The type of the index. Examples: Primary, Unique, and Normal.
                /// </summary>
                [NameInMap("IndexType")]
                [Validation(Required=false)]
                public string IndexType { get; set; }

                /// <summary>
                /// Indicates whether the index is unique. Valid values:
                /// 
                /// *   true: The index is unique.
                /// *   false: The index is not unique.
                /// </summary>
                [NameInMap("Unique")]
                [Validation(Required=false)]
                public bool? Unique { get; set; }

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
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
