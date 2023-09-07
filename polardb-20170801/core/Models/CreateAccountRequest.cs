// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// The description of the account. The description must meet the following requirements:
        /// 
        /// *   It cannot start with `http://` or `https://`.
        /// *   It must be 2 to 256 characters in length.
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// The name of the account. The name must meet the following requirements:
        /// 
        /// *   It must start with a lowercase letter and end with a letter or a digit.
        /// *   It can contain lowercase letters, digits, and underscores (\_).
        /// *   It must be 2 to 16 characters in length.
        /// *   It cannot be root, admin, or another username that is reserved by the system.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password of the account. The password must meet the following requirements:
        /// 
        /// *   It must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
        /// *   It must be 8 to 32 characters in length.
        /// *   Special characters include `! @ # $ % ^ & * ( ) _ + - =`
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// The permissions that are granted to the account. Valid values:
        /// 
        /// *   **ReadWrite**: read and write permissions
        /// *   **ReadOnly**: read-only permissions
        /// *   **DMLOnly**: the permissions to execute only DML statements
        /// *   **DDLOnly**: the permissions to execute only DDL statements
        /// *   **ReadIndex**: the read and index permissions
        /// 
        /// > 
        /// 
        /// *   The `AccountPrivilege` parameter is valid only after you specify the `DBName` parameter.
        /// 
        /// *   If multiple database names are specified by the `DBName` parameter, you must grant permissions on the databases. Separate multiple permissions with commas (,). For example, if you want to grant the account the read and write permissions on DB1 and the read-only permissions on DB2, set `DBName` to `DB1,DB2`, and set `AccountPrivilege` to `ReadWrite,ReadOnly`.
        /// *   This parameter is valid only for standard accounts of PolarDB for MySQL clusters.
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// The type of the account. Valid values:
        /// 
        /// *   **Normal**: standard account
        /// *   **Super**: privileged account
        /// 
        /// > 
        /// 
        /// *   If you leave this parameter empty, the default value **Super** is used.
        /// 
        /// *   You can create multiple privileged accounts for a PolarDB for Oracle or PolarDB for PostgreSQL cluster. A privileged account is granted more permissions than a standard account. For more information about how to create a database account, see [Create a database account](~~68508~~).
        /// *   You can create only one privileged account for a PolarDB for MySQL cluster. A privileged account is granted more permissions than a standard account. For more information about how to create a database account, see [Create a database account](~~68508~~).
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. The token is case-sensitive.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the database that can be accessed by the account. To enter multiple database names, separate the names with commas (,).
        /// 
        /// > This parameter is valid only for standard accounts of PolarDB for MySQL clusters.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PrivForAllDB")]
        [Validation(Required=false)]
        public string PrivForAllDB { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
