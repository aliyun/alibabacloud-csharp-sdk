// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnsRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **ListSensitiveColumns**.
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// 1860
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// Specifies whether the database is a logical database. Valid values:
        /// 
        /// *   true: The database is a logical database.
        /// *   false: The database is a physical database.
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// The sensitivity level of the field. Valid values:
        /// 
        /// *   SENSITIVE: medium sensitivity level
        /// *   CONFIDENTIAL: high sensitivity level
        /// </summary>
        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public string SecurityLevel { get; set; }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The name of the table. You can call the [ListTables](~~141878~~) operation to query the ID of the table.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
