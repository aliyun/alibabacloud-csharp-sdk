// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnsRequest : TeaModel {
        /// <summary>
        /// The name of the field. You can call the [ListColumns](~~141870~~) operation to query the name of the field.
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// The ID of the database. You can call the [SearchDatabase](~~141876~~) operation to query the ID of the database.
        /// 
        /// >  You can also call the [ListDatabases](~~141873~~) operation to query the ID of the physical database and the [ListLogicDatabases](~~141874~~) operation to query the ID of a logical database.
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
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the database. You can call the [SearchDatabase](~~141876~~) operation to query the name of the database.
        /// 
        /// >  You can also call the [ListDatabases](~~141873~~) operation to query the name of a physical database and the [ListLogicDatabases](~~141874~~) operation to query the name of a logical database.
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
        /// The name of the table. You can call the [ListTables](~~141878~~) operation to query the ID of the table.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the "View information about the current tenant" section of the [Manage DMS tenants](~~181330~~) topic.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
