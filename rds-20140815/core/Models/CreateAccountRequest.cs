// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// The description of the account. The value must be 2 to 256 characters in length. The value can contain letters, digits, underscores (_), and hyphens (-), and must start with a letter.
        /// 
        /// > : The name cannot start with http:// or https://.
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// The name of the database account.
        /// 
        /// 
        /// *   The name must be unique.
        /// 
        /// *   The name can contain lowercase letters, digits, and underscores (_). For MySQL databases, the name can contain uppercase letters.
        /// 
        /// *   The name must start with a letter and end with a letter or digit.
        /// 
        /// *   For MySQL databases, the name of the privileged account cannot be the same as that of the standard account. For example, if the name of the privileged account is `Test1`, the name of the standard account cannot be `test1`.
        /// 
        /// *   The length of the value must meet the following requirements:
        /// 
        ///     *   If the instance runs MySQL 5.7 or MySQL 8.0, the value must be 2 to 32 characters in length.
        ///     *   If the instance runs MySQL 5.6, the value must be 2 to 16 characters in length.
        ///     *   If the instance runs SQL Server, the value must be 2 to 64 characters in length.
        ///     *   If the instance runs PostgreSQL with cloud disks, the value must be 2 to 63 characters in length.
        ///     *   If the instance runs PostgreSQL with local disks, the value must be 2 to 16 characters in length.
        ///     *   If the instance runs MariaDB, the value must be 2 to 16 characters in length.
        /// 
        /// *   For more information about invalid characters, see [Forbidden keywords](https://help.aliyun.com/document_detail/26317.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password of the account.
        ///  
        /// 
        /// *   The value must be 8 to 32 characters in length.
        /// 
        /// *   The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
        /// 
        /// *   Special characters include `! @ # $ % ^ & * ( ) _ + - =`
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// The account type. Valid values:
        /// 
        /// *   **Normal** (default): standard account.
        /// *   **Super**: privileged account.
        /// *   **Sysadmin**: system admin account. The account type is available only for ApsaraDB RDS for SQL Server instances.
        /// 
        /// Before you create a system admin account, check whether the instance meets all prerequisites. For more information, see [Create a system admin account](https://help.aliyun.com/document_detail/170736.html).
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
