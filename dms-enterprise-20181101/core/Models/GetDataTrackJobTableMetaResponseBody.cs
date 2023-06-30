// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataTrackJobTableMetaResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
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

        /// <summary>
        /// The metadata of tables.
        /// </summary>
        [NameInMap("TableMetaList")]
        [Validation(Required=false)]
        public List<GetDataTrackJobTableMetaResponseBodyTableMetaList> TableMetaList { get; set; }
        public class GetDataTrackJobTableMetaResponseBodyTableMetaList : TeaModel {
            /// <summary>
            /// The information about columns.
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<GetDataTrackJobTableMetaResponseBodyTableMetaListColumns> Columns { get; set; }
            public class GetDataTrackJobTableMetaResponseBodyTableMetaListColumns : TeaModel {
                /// <summary>
                /// The name of the character set.
                /// </summary>
                [NameInMap("Charset")]
                [Validation(Required=false)]
                public string Charset { get; set; }

                /// <summary>
                /// The name of the column.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// The position of the column.
                /// </summary>
                [NameInMap("ColumnPosition")]
                [Validation(Required=false)]
                public int? ColumnPosition { get; set; }

                /// <summary>
                /// The data type of the column. Examples: BIGINT, INT, and VARCHAR.
                /// </summary>
                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                /// <summary>
                /// Indicates whether the column is a virtual column. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Fictive")]
                [Validation(Required=false)]
                public bool? Fictive { get; set; }

            }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// The name of the table.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

    }

}
