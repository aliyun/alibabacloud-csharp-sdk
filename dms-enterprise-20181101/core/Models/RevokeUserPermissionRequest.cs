// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class RevokeUserPermissionRequest : TeaModel {
        /// <summary>
        /// The ID of the database. The database can be a physical database or a logical database.
        /// 
        /// *   To query the ID of a physical database, call the [ListDatabases](https://help.aliyun.com/document_detail/141873.html) or [SearchDatabase](https://help.aliyun.com/document_detail/141876.html) operation.
        /// *   To query the ID of a logical database, call the [ListLogicDatabases](https://help.aliyun.com/document_detail/141874.html) or [SearchDatabase](https://help.aliyun.com/document_detail/141876.html) operation.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public string DbId { get; set; }

        /// <summary>
        /// The object type on which the permission you want to revoke from the user. Valid values:
        /// 
        /// *   **INSTANCE**: database instances
        /// *   **DATABASE**: physical databases
        /// *   **LOGIC_DATABASE**: logical databases
        /// *   **TABLE**: physical tables
        /// *   **LOGIC_TABLE**: logical tables
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DsType")]
        [Validation(Required=false)]
        public string DsType { get; set; }

        /// <summary>
        /// The ID of the database instance. You must specify this parameter when you revoke a permission from the database instance. You can call the [ListInstances](https://help.aliyun.com/document_detail/141936.html) or [GetInstance](https://help.aliyun.com/document_detail/141567.html) operation to query the database instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// Specifies whether the database is a logical database. Valid values:
        /// 
        /// * **true**: The database is a logical database.
        /// * **false**: The database is a physical database.
        /// 
        /// > * If the database is a logical database, set this parameter to **true**.
        /// > * If the database is a physical database, set this parameter to **false**.
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// The type of the permission. Valid values:
        /// 
        /// *   **QUERY**: the data query permission
        /// *   **EXPORT**: the data export permission
        /// *   **CORRECT**: the data change permission
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PermTypes")]
        [Validation(Required=false)]
        public string PermTypes { get; set; }

        /// <summary>
        /// The ID of the table. You must specify this parameter when you revoke a permission from the table. You can call the [ListTables](https://help.aliyun.com/document_detail/141878.html) operation to query the table ID.
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// The name of the table. You can call the [ListTables](https://help.aliyun.com/document_detail/141878.html) operation to query the table name.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The ID of the permission. You can call the [ListUserPermission](https://help.aliyun.com/document_detail/146957.html) operation to query the permission ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserAccessId")]
        [Validation(Required=false)]
        public string UserAccessId { get; set; }

        /// <summary>
        /// The ID of the user. You can call the [ListUsers](https://help.aliyun.com/document_detail/141938.html) or [GetUser](https://help.aliyun.com/document_detail/147098.html) operation to query the user ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
