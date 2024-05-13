// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GrantUserPermissionRequest : TeaModel {
        /// <summary>
        /// The ID of the database. You can call the [ListDatabases](https://help.aliyun.com/document_detail/141873.html) operation to query the ID of a physical database and the [ListLogicDatabases](https://help.aliyun.com/document_detail/141874.html) operation to query the ID of a logical database.
        /// 
        /// >  The value of the DatabaseId parameter is that of the DbId parameter.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public string DbId { get; set; }

        /// <summary>
        /// The permissions on a specific type of object that you want to grant to the user. Valid values:
        /// 
        /// *   INSTANCE: permissions on instances
        /// *   DATABASE: permissions on physical databases
        /// *   LOGIC_DATABASE: permissions on logical databases
        /// *   TABLE: permissions on physical tables
        /// *   LOGIC_TABLE: permissions on logical tables
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DsType")]
        [Validation(Required=false)]
        public string DsType { get; set; }

        /// <summary>
        /// The time when the permissions expire.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// The ID of the instance. You must specify this parameter if you grant permissions on an instance to the user. You can call the [ListInstances](https://help.aliyun.com/document_detail/141936.html) or [GetInstance](https://help.aliyun.com/document_detail/141567.html) operation to query the ID of the instance.
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
        /// The permission type. Separate multiple permission types with commas (,). Valid values:
        /// 
        /// *   **QUERY**: the query permissions
        /// *   **EXPORT**: the export permissions
        /// *   **CORRECT**: the change permissions
        /// *   **LOGIN**: the logon permissions
        /// *   **PERF**: the query permissions on the performance details of the instance
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PermTypes")]
        [Validation(Required=false)]
        public string PermTypes { get; set; }

        /// <summary>
        /// The ID of the table. You must specify this parameter if you grant permissions on a table to the user. You can call the [ListTables](https://help.aliyun.com/document_detail/141878.html) operation to query the table ID.
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// The name of the table. You must specify this parameter if you grant permissions on a table to the user.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the "View information about the current tenant" section of the [Manage DMS tenants](https://help.aliyun.com/document_detail/181330.html) topic.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The ID of the user. You can call the [GetUser](https://help.aliyun.com/document_detail/147098.html) or [ListUsers](https://help.aliyun.com/document_detail/141938.html) operation to query the ID of the user.
        /// 
        /// >  The user ID is different from the ID of your Alibaba Cloud account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
