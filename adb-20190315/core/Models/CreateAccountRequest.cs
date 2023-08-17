// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// The description of the database account.
        /// 
        /// *   The description cannot start with `http://` or `https://`.
        /// *   The description can be up to 256 characters in length.
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// The name of the database account.
        /// 
        /// *   The name must start with a lowercase letter and end with a lowercase letter or a digit.
        /// *   The name can contain lowercase letters, digits, and underscores (\_).
        /// *   The name must be 2 to 16 characters in length.
        /// *   Reserved account names such as root, admin, and opsadmin cannot be used.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password of the database account.
        /// 
        /// *   The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
        /// *   Special characters include `! @ # $ % ^ & * ( ) _ + - =`
        /// *   The password must be 8 to 32 characters in length.
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// The type of the database account. Valid values:
        /// 
        /// *   **Normal**: standard account. Up to 256 standard accounts can be created for a cluster.
        /// *   **Super** (default): privileged account. Only a single privileged account can be created for a cluster.
        /// 
        /// >  If a cluster does not have accounts, you can specify this parameter to create a privileged account or standard account. If a cluster has a privileged account, you must set this parameter to Normal to create a standard account. Otherwise, the operation fails. After an account is created, the privileged account has permissions on all databases of the cluster. The standard account does not have permissions and must be granted permissions on specific databases by the privileged account. For more information, see GRANT.
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to view cluster IDs.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

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
