// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// The description of the account. The value must be 2 to 256 characters in length. The value can contain letters, digits, underscores (\_), and hyphens (-), and must start with a letter.
        /// 
        /// > : The name cannot start with http:// or https://.
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// The username of the account.
        /// 
        /// *   The value must be unique.
        /// 
        /// *   The value must start with a lowercase letter, and end with a lowercase letter or a digit.
        /// 
        /// *   The value can contain lowercase letters, digits, and underscores (\_).
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
        /// *   For more information about invalid characters, see [Forbidden keywords table](~~26317~~).
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
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// The account type. Valid values:
        /// 
        /// *   **Normal**: standard account (default).
        /// *   **Super**: privileged account.
        /// *   **Sysadmin**: system admin account. The account type is available only for ApsaraDB RDS for SQL Server instances.
        /// 
        /// Before you create a system admin account, check whether the RDS instance meets all prerequisites. For more information, see [Create a system admin account](~~170736~~).
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
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
