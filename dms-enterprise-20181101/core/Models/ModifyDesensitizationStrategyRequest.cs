// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ModifyDesensitizationStrategyRequest : TeaModel {
        /// <summary>
        /// The name of the field. You can call the [ListSensitiveColumns](https://help.aliyun.com/document_detail/188103.html) operation to obtain the field name.
        /// 
        /// >  You can also call the [ListColumns](https://help.aliyun.com/document_detail/141870.html) operation to obtain the field name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// The ID of the database. You can call the [ListDatabases](https://help.aliyun.com/document_detail/141873.html) operation to obtain the ID.
        /// 
        /// This parameter is required.
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
        /// 
        /// This parameter is required.
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
        /// The name of the database. You can call the [ListSensitiveColumns](https://help.aliyun.com/document_detail/188103.html) operation to obtain the database name.
        /// 
        /// > 
        /// 
        /// *   If the database is a physical database, you can call the [ListDatabases](https://help.aliyun.com/document_detail/141873.html) or [SearchDatabase](https://help.aliyun.com/document_detail/141876.html) operation to obtain the database name.
        /// 
        /// *   If the database is a logical database, you can call the [ListLogicDatabases](https://help.aliyun.com/document_detail/141874.html) or [SearchDatabase](https://help.aliyun.com/document_detail/141876.html) operation to obtain the name of the database.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// The name of the table. You can call the [ListSensitiveColumns](https://help.aliyun.com/document_detail/188103.html) operation to obtain the table name.
        /// 
        /// >  You can also call the [ListTables](https://help.aliyun.com/document_detail/141878.html) operation to obtain the table name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](https://help.aliyun.com/document_detail/181330.html) in the topic "Manage DMS tenants."
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
