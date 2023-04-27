// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GrantUserPermissionRequest : TeaModel {
        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public string DbId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **GrantUserPermission**.
        /// </summary>
        [NameInMap("DsType")]
        [Validation(Required=false)]
        public string DsType { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// The ID of the database. You can call the [ListDatabases](~~141873~~) operation to query the ID of a physical database and the [ListLogicDatabases](~~141874~~) operation to query the ID of a logical database.
        /// 
        /// >  The value of the DatabaseId parameter is that of the DbId parameter.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// Specifies whether the database is a logical database. You must specify this parameter if you grant permissions on a database to the user. Valid values:
        /// 
        /// *   true: The database is a logical database.
        /// *   false: The database is a physical database.
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// The ID of the instance. You must specify this parameter if you grant permissions on an instance to the user. You can call the [ListInstances](~~141936~~) or [GetInstance](~~141567~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("PermTypes")]
        [Validation(Required=false)]
        public string PermTypes { get; set; }

        /// <summary>
        /// The permission type. Separate multiple permission types with commas (,). Valid values:
        /// 
        /// *   **QUERY**: the query permissions
        /// *   **EXPORT**: the export permissions
        /// *   **CORRECT**: the change permissions
        /// *   **LOGIN**: the logon permissions
        /// *   **PERF**: the query permissions on the performance details of the instance
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the "View information about the current tenant" section of the [Manage DMS tenants](~~181330~~) topic.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the table. You must specify this parameter if you grant permissions on a table to the user. You can call the [ListTables](~~141878~~) operation to query the table ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
