// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnsDetailResponseBody : TeaModel {
        /// <summary>
        /// WB01053274
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The name of the field. You can call the [ListSensitiveColumns](~~188103~~) operation to obtain the name of the field.
        /// 
        /// >  You can also call the [ListColumns](~~141870~~) operation to obtain the name of the field.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The data type of the field.
        /// </summary>
        [NameInMap("SensitiveColumnsDetailList")]
        [Validation(Required=false)]
        public ListSensitiveColumnsDetailResponseBodySensitiveColumnsDetailList SensitiveColumnsDetailList { get; set; }
        public class ListSensitiveColumnsDetailResponseBodySensitiveColumnsDetailList : TeaModel {
            [NameInMap("SensitiveColumnsDetail")]
            [Validation(Required=false)]
            public List<ListSensitiveColumnsDetailResponseBodySensitiveColumnsDetailListSensitiveColumnsDetail> SensitiveColumnsDetail { get; set; }
            public class ListSensitiveColumnsDetailResponseBodySensitiveColumnsDetailListSensitiveColumnsDetail : TeaModel {
                /// <summary>
                /// $.parameters[6].schema.description
                /// </summary>
                [NameInMap("ColumnDescription")]
                [Validation(Required=false)]
                public string ColumnDescription { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// $.parameters[7].schema.description
                /// </summary>
                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                /// <summary>
                /// Indicates whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The database is a logical database.
                /// *   **false**: The database is not a logical database.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// $.parameters[6].schema.enumValueTitles
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// ListSensitiveColumnsDetail
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// $.parameters[7].schema.example
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// $.parameters[7].schema.enumValueTitles
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// Queries the details of a sensitive field.
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                /// <summary>
                /// $.parameters[6].schema.example
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
