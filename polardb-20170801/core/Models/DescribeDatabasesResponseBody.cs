// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDatabasesResponseBody : TeaModel {
        /// <summary>
        /// Details about databases.
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public DescribeDatabasesResponseBodyDatabases Databases { get; set; }
        public class DescribeDatabasesResponseBodyDatabases : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<DescribeDatabasesResponseBodyDatabasesDatabase> Database { get; set; }
            public class DescribeDatabasesResponseBodyDatabasesDatabase : TeaModel {
                /// <summary>
                /// Details about the accounts.
                /// 
                /// > A PolarDB for MySQL cluster does not support privileged accounts.
                /// </summary>
                [NameInMap("Accounts")]
                [Validation(Required=false)]
                public DescribeDatabasesResponseBodyDatabasesDatabaseAccounts Accounts { get; set; }
                public class DescribeDatabasesResponseBodyDatabasesDatabaseAccounts : TeaModel {
                    [NameInMap("Account")]
                    [Validation(Required=false)]
                    public List<DescribeDatabasesResponseBodyDatabasesDatabaseAccountsAccount> Account { get; set; }
                    public class DescribeDatabasesResponseBodyDatabasesDatabaseAccountsAccount : TeaModel {
                        /// <summary>
                        /// The username of the account.
                        /// 
                        /// > A PolarDB for MySQL cluster does not support privileged accounts.
                        /// </summary>
                        [NameInMap("AccountName")]
                        [Validation(Required=false)]
                        public string AccountName { get; set; }

                        /// <summary>
                        /// The permissions that are granted to the account. Valid values:
                        /// 
                        /// *   **ReadWrite**: read and write permissions
                        /// *   **ReadOnly**: read-only permissions
                        /// *   **DMLOnly**: The account is granted the permissions to execute only DML statements on the database.
                        /// *   **DDLOnly**: The account is granted the permissions to execute only DDL statements on the database.
                        /// *   **ReadIndex**: The account has the read and index permissions on the database.
                        /// </summary>
                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                        /// <summary>
                        /// The state of the account. Valid values:
                        /// 
                        /// *   **Creating**
                        /// *   **Available**
                        /// *   **Deleting**
                        /// </summary>
                        [NameInMap("AccountStatus")]
                        [Validation(Required=false)]
                        public string AccountStatus { get; set; }

                        /// <summary>
                        /// The authorization state of the account. Valid values:
                        /// 
                        /// *   **Empowering**: The system is granting permissions to the account.
                        /// *   **Empowered**: Permissions are granted to the account.
                        /// *   **Removing**: The system is revoking permissions from the account.
                        /// </summary>
                        [NameInMap("PrivilegeStatus")]
                        [Validation(Required=false)]
                        public string PrivilegeStatus { get; set; }

                    }

                }

                /// <summary>
                /// The character set that the database uses. For more information, see [Character set tables](https://help.aliyun.com/document_detail/99716.html).
                /// </summary>
                [NameInMap("CharacterSetName")]
                [Validation(Required=false)]
                public string CharacterSetName { get; set; }

                /// <summary>
                /// The description of the database.
                /// </summary>
                [NameInMap("DBDescription")]
                [Validation(Required=false)]
                public string DBDescription { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// The state of the database. Valid values:
                /// 
                /// *   **Creating**
                /// *   **Running**
                /// *   **Deleting**
                /// </summary>
                [NameInMap("DBStatus")]
                [Validation(Required=false)]
                public string DBStatus { get; set; }

                /// <summary>
                /// The type of the database engine. Valid values:
                /// 
                /// *   **MySQL**
                /// *   **Oracle**
                /// *   **PostgreSQL**
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The ID of the primary node in the cluster of Multi-master Cluster (Database/Table) Edition.
                /// </summary>
                [NameInMap("MasterID")]
                [Validation(Required=false)]
                public string MasterID { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
