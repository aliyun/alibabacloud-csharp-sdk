// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDatabaseRequest : TeaModel {
        /// <summary>
        /// The name of the account that is authorized to access the database. You can call the [DescribeAccounts](~~98107~~) operation to query account information.
        /// >- You can specify only a standard account. By default, privileged accounts have all permissions on all databases. You do not need to grant privileged accounts the permissions to access the database.
        /// >- This parameter is required for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters. This parameter is optional for PolarDB for MySQL clusters.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The permissions that are granted to the account. Valid values:
        /// 
        /// *   **ReadWrite**: read and write permissions.
        /// *   **ReadOnly**: read-only permissions.
        /// *   **DMLOnly**: the permissions to execute only DML statements.
        /// *   **DDLOnly**: the permissions to execute only DDL statements.
        /// *   **ReadIndex**: the read-only and index permissions.
        /// 
        /// If you leave this parameter empty, the default value **ReadWrite** is used.
        /// 
        /// >- This parameter is valid only if you specify **AccountName**.
        /// >- This parameter is required for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.
        /// >- This parameter is optional for PolarDB for MySQL clusters.
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// The character set that is used by the cluster. For more information, see [Character set tables](~~99716~~).
        /// </summary>
        [NameInMap("CharacterSetName")]
        [Validation(Required=false)]
        public string CharacterSetName { get; set; }

        /// <summary>
        /// The language that indicates the collation of the databases that are created.
        /// 
        /// > 
        /// 
        /// *   The language must be compatible with the character set that is specified by **CharacterSetName**.
        /// 
        /// *   This parameter is required for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters. This parameter is not supported by PolarDB for MySQL clusters.
        /// 
        /// To view the valid values for this parameter, perform the following steps: Log on to the PolarDB console and click the ID of a cluster. In the left-side navigation pane, choose **Settings and Management** > **Databases**. Then, click **Create Database**.
        /// </summary>
        [NameInMap("Collate")]
        [Validation(Required=false)]
        public string Collate { get; set; }

        /// <summary>
        /// The language that indicates the character type of the database.
        /// 
        /// >- The language must be compatible with the character set that is specified by **CharacterSetName**.
        /// >- The value that you specify must be the same as the value of **Collate**.
        /// >- This parameter is required for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters. This parameter is optional for PolarDB for MySQL clusters.
        /// 
        /// To view the valid values for this parameter, perform the following steps: Log on to the PolarDB console and click the ID of a cluster. In the left-side navigation pane, choose **Settings and Management** > **Databases**. Then, click **Create Database**.
        /// </summary>
        [NameInMap("Ctype")]
        [Validation(Required=false)]
        public string Ctype { get; set; }

        /// <summary>
        /// The ID of cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The description of the database. The description must meet the following requirements:
        /// 
        /// *   It cannot start with `http://` or `https://`.
        /// *   It must be 2 to 256 characters in length.
        /// 
        /// > This parameter is required for a PolarDB for Oracle or PolarDB for PostgreSQL cluster. This parameter is optional for a PolarDB for MySQL cluster.
        /// </summary>
        [NameInMap("DBDescription")]
        [Validation(Required=false)]
        public string DBDescription { get; set; }

        /// <summary>
        /// The name of the database. The name must meet the following requirements:
        /// 
        /// *   The name can contain lowercase letters, digits, hyphens (-), and underscores (\_).
        /// *   The name must start with a lowercase letter and end with a lowercase letter or a digit. The name must be 1 to 64 characters in length.
        /// 
        /// > Do not use reserved words as database names, such as `test` or `mysql`.
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
