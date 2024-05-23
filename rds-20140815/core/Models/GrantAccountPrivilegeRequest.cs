// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class GrantAccountPrivilegeRequest : TeaModel {
        /// <summary>
        /// The username of the account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The permissions that you want to grant to the account. The number of permissions must be the same as the number of databases that you specify for the DBName parameter. You can specify this parameter based on your business requirements. Valid values:
        /// 
        /// *   **ReadWrite**: read and write permissions
        /// *   **ReadOnly**: read-only permissions
        /// *   **DDLOnly**: DDL-only permissions
        /// *   **DMLOnly**: DML-only permissions
        /// *   **DBOwner**: database owner permissions
        /// 
        /// > 
        /// 
        /// *   If the instance runs MySQL or MariaDB, you can set this parameter to **ReadWrite**, **ReadOnly**, **DDLOnly**, or **DMLOnly**.
        /// 
        /// *   If the instance runs SQL Server, you can set this parameter to **ReadWrite**, **ReadOnly**, or **DBOwner**.
        /// *   If the instance runs PostgreSQL and uses cloud disks, you can set this parameter to **DBOwner**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The name of the database on which you want to grant permissions. Separate multiple database names with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
