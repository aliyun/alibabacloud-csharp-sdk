// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ChangeColumnSecLevelRequest : TeaModel {
        /// <summary>
        /// The name of the field. You can call the [ListSensitiveColumns](~~188103~~) operation to obtain the name of the field.
        /// 
        /// > You can also call the [ListColumns](~~141870~~) operation to obtain the name of the field.
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// The ID of the database. You can call the [SearchDatabase](~~141876~~) operation to obtain the ID of the database.
        /// 
        /// > You can also call the [ListDatabases](~~141873~~) operation to obtain the ID of a physical database and the [ListLogicDatabases](~~141874~~) operation to obtain the ID of a logical database.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// Specifies whether the database is a logical database. Valid values:
        /// 
        /// *   true: The database is a physical database.
        /// *   false: The database is a logical database.
        /// </summary>
        [NameInMap("IsLogic")]
        [Validation(Required=false)]
        public bool? IsLogic { get; set; }

        /// <summary>
        /// The new sensitivity level of the field that you want to specify. Valid values:
        /// 
        /// *   INNER: low sensitivity level
        /// *   SENSITIVE: medium sensitivity level
        /// *   CONFIDENTIAL: high sensitivity level
        /// </summary>
        [NameInMap("NewLevel")]
        [Validation(Required=false)]
        public string NewLevel { get; set; }

        /// <summary>
        /// The name of the database. You can call the [ListSensitiveColumns](~~188103~~) operation to obtain the name of the database.
        /// 
        /// *   You can also call the [SearchDatabase](~~141876~~) operation to obtain the name of the database.
        /// *   You can also call the [ListDatabases](~~141873~~) operation to obtain the name of a physical database and the [ListLogicDatabases](~~141874~~) operation to obtain the name of a logical database.
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// The name of the table. You can call the [ListSensitiveColumns](~~188103~~) operation to obtain the name of the table.
        /// 
        /// > You can also call the [ListTables](~~141878~~) operation to obtain the name of the table.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](~~181330~~).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
