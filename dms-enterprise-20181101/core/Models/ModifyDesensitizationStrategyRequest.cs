// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ModifyDesensitizationStrategyRequest : TeaModel {
        /// <summary>
        /// The name of the field. You can call the [ListSensitiveColumns](~~188103~~) operation to obtain the field name.
        /// 
        /// >  You can also call the [ListColumns](~~141870~~) operation to obtain the field name.
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// The ID of the database. You can call the [ListDatabases](~~141873~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        /// <summary>
        /// The desensitization algorithm of the field setting. The default value is false. The values are as follows:
        /// 
        /// - **true**: default desensitization algorithm.
        /// 
        /// - **false** :semi-desensitization algorithm.
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Specifies whether the database is a logical database. Valid values:
        /// 
        /// *   **true**: The database is a physical database.
        /// *   **false**: The database is a logical database.
        /// </summary>
        [NameInMap("IsLogic")]
        [Validation(Required=false)]
        public bool? IsLogic { get; set; }

        /// <summary>
        /// Specifies whether to reset the masking rule. Valid value:
        /// 
        /// *   **true**: Reset the masking rule.
        /// *   **false**: Do not reset the masking rule. This is the default value.
        /// </summary>
        [NameInMap("IsReset")]
        [Validation(Required=false)]
        public bool? IsReset { get; set; }

        /// <summary>
        /// The ID of the masking rule.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public int? RuleId { get; set; }

        /// <summary>
        /// The name of the database. You can call the [ListSensitiveColumns](~~188103~~) operation to obtain the database name.
        /// 
        /// > 
        /// 
        /// *   If the database is a physical database, you can call the [ListDatabases](~~141873~~) or [SearchDatabase](~~141876~~) operation to obtain the database name.
        /// 
        /// *   If the database is a logical database, you can call the [ListLogicDatabases](~~141874~~) or [SearchDatabase](~~141876~~) operation to obtain the name of the database.
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// The name of the table. You can call the [ListSensitiveColumns](~~188103~~) operation to obtain the table name.
        /// 
        /// >  You can also call the [ListTables](~~141878~~) operation to obtain the table name.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](~~181330~~) in the topic "Manage DMS tenants."
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
