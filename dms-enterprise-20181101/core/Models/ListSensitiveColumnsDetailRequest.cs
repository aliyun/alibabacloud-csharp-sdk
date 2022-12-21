// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnsDetailRequest : TeaModel {
        /// <summary>
        /// The name of the field. You can call the [ListSensitiveColumns](~~188103~~) operation to obtain the name of the field.
        /// 
        /// >  You can also call the [ListColumns](~~141870~~) operation to obtain the name of the field.
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// The ID of the database. The database can be a physical database or a logical database.
        /// 
        /// *   To obtain the ID of a physical database, call the [ListDatabases](~~141873~~) or [SearchDatabase](~~141876~~) operation.
        /// *   To obtain the ID of a logical database, call the [ListLogicDatabases](~~141874~~) or [SearchDatabase](~~141876~~) operation.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// Specifies whether the database is a logical database. Valid values:
        /// 
        /// *   **true**: The database is a logical database.
        /// *   **false**: The database is a physical database.
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// The name of the database. You can call the [ListSensitiveColumns](~~188103~~) operation to obtain the name of the database.
        /// 
        /// > 
        /// *   You can also call the [ListDatabases](~~141873~~) or [SearchDatabase](~~141876~~) operation to obtain the name of a physical database.
        /// *   You can also call the [ListLogicDatabases](~~141874~~) or [SearchDatabase](~~141876~~) operation to obtain the name of a logical database.
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// The name of the table. You can call the [ListSensitiveColumns](~~188103~~) operation to obtain the name of the table.
        /// 
        /// >  You can also call the [ListTables](~~141878~~) operation to obtain the name of the table.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
