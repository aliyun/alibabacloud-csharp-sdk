// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class RevokeUserPermissionRequest : TeaModel {
        /// <summary>
        /// Specifies whether the database is a logical database. Valid values:
        /// 
        /// *   **true**: The database is a logical database.
        /// *   **false**: The database is a physical database.
        /// 
        /// > 
        /// *   If the database is a logical database, set this parameter to **true**.
        /// *   If the database is a physical database, set this parameter to **false**.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public string DbId { get; set; }

        /// <summary>
        /// The ID of the database. The database can be a physical database or a logical database.
        /// 
        /// *   To query the ID of a physical database, call the [ListDatabases](~~141873~~) or [SearchDatabase](~~141876~~) operation.
        /// *   To query the ID of a logical database, call the [ListLogicDatabases](~~141874~~) or [SearchDatabase](~~141876~~) operation.
        /// </summary>
        [NameInMap("DsType")]
        [Validation(Required=false)]
        public string DsType { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// The type of the permission. Valid values:
        /// 
        /// *   **QUERY**: the data query permission
        /// *   **EXPORT**: the data export permission
        /// *   **CORRECT**: the data change permission
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PermTypes")]
        [Validation(Required=false)]
        public string PermTypes { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to query the tenant ID.
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// The ID of the database instance. You must specify this parameter when you revoke a permission from the database instance. You can call the [ListInstances](~~141936~~) or [GetInstance](~~141567~~) operation to query the database instance ID.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// Revokes a permission on a resource from a user.
        /// </summary>
        [NameInMap("UserAccessId")]
        [Validation(Required=false)]
        public string UserAccessId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **RevokeUserPermission**.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
