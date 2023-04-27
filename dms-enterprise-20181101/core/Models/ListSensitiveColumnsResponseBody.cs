// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnsResponseBody : TeaModel {
        /// <summary>
        /// The sensitivity level of the field. Valid values:
        /// 
        /// *   SENSITIVE
        /// *   CONFIDENTIAL
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The sensitive fields.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The number of sensitive fields.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of the de-identification algorithm. Valid values:
        /// 
        /// *   DEFAULT: All characters are masked. This is the default value.
        /// *   FIX_POS: The characters at specific positions are masked.
        /// *   FIX_CHAR: Specific characters are masked.
        /// </summary>
        [NameInMap("SensitiveColumnList")]
        [Validation(Required=false)]
        public ListSensitiveColumnsResponseBodySensitiveColumnList SensitiveColumnList { get; set; }
        public class ListSensitiveColumnsResponseBodySensitiveColumnList : TeaModel {
            [NameInMap("SensitiveColumn")]
            [Validation(Required=false)]
            public List<ListSensitiveColumnsResponseBodySensitiveColumnListSensitiveColumn> SensitiveColumn { get; set; }
            public class ListSensitiveColumnsResponseBodySensitiveColumnListSensitiveColumn : TeaModel {
                /// <summary>
                /// Queries sensitive fields in a table of a database.
                /// </summary>
                [NameInMap("ColumnCount")]
                [Validation(Required=false)]
                public long? ColumnCount { get; set; }

                /// <summary>
                /// The name of the field. You can call the [ListColumns](~~141870~~) operation to query the name of the field.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("FunctionType")]
                [Validation(Required=false)]
                public string FunctionType { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// The name of the field.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the "View information about the current tenant" section of the [Manage DMS tenants](~~181330~~) topic.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
