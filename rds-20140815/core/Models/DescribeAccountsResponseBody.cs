// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// The details of the accounts.
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccounts Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("DBInstanceAccount")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsDBInstanceAccount> DBInstanceAccount { get; set; }
            public class DescribeAccountsResponseBodyAccountsDBInstanceAccount : TeaModel {
                /// <summary>
                /// The description of the account.
                /// </summary>
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                /// <summary>
                /// The username of the account.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// The status of the account. Valid values:
                /// 
                /// *   **Unavailable**
                /// *   **Available**
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// The type of the account. Valid values:
                /// 
                /// *   **Normal**: standard account
                /// *   **Super**: privileged account
                /// *   **Sysadmin**: superuser account that has the system administrator permissions
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// Indicates whether the account has the row-level security (RLS) permissions. Valid values:
                /// 
                /// *   **t**: yes
                /// *   **f**: no
                /// 
                /// > This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("BypassRLS")]
                [Validation(Required=false)]
                public string BypassRLS { get; set; }

                /// <summary>
                /// Indicates whether the account has the permissions to create databases. Valid values:
                /// 
                /// *   **t**: yes
                /// *   **f**: no
                /// 
                /// > This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("CreateDB")]
                [Validation(Required=false)]
                public string CreateDB { get; set; }

                /// <summary>
                /// Indicates whether the account has the permissions to create roles. Valid values:
                /// 
                /// *   **t**: yes
                /// *   **f**: no
                /// 
                /// > This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("CreateRole")]
                [Validation(Required=false)]
                public string CreateRole { get; set; }

                /// <summary>
                /// The ID of the instance to which the account belongs.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The details of the permissions that are granted to the account.
                /// </summary>
                [NameInMap("DatabasePrivileges")]
                [Validation(Required=false)]
                public DescribeAccountsResponseBodyAccountsDBInstanceAccountDatabasePrivileges DatabasePrivileges { get; set; }
                public class DescribeAccountsResponseBodyAccountsDBInstanceAccountDatabasePrivileges : TeaModel {
                    [NameInMap("DatabasePrivilege")]
                    [Validation(Required=false)]
                    public List<DescribeAccountsResponseBodyAccountsDBInstanceAccountDatabasePrivilegesDatabasePrivilege> DatabasePrivilege { get; set; }
                    public class DescribeAccountsResponseBodyAccountsDBInstanceAccountDatabasePrivilegesDatabasePrivilege : TeaModel {
                        /// <summary>
                        /// The type of the permissions. Valid values:
                        /// 
                        /// *   **ReadWrite**: read and write permissions
                        /// *   **ReadOnly**: read-only permissions
                        /// *   **DDLOnly**: DDL-only permissions
                        /// *   **DMLOnly**: DML-only permissions
                        /// *   **Custom**: custom permissions (You can modify the permissions of the account by using SQL commands.)
                        /// </summary>
                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                        /// <summary>
                        /// The permissions that are granted to the account. For more information, see [Account permissions](~~146395~~).
                        /// </summary>
                        [NameInMap("AccountPrivilegeDetail")]
                        [Validation(Required=false)]
                        public string AccountPrivilegeDetail { get; set; }

                        /// <summary>
                        /// The name of the database.
                        /// </summary>
                        [NameInMap("DBName")]
                        [Validation(Required=false)]
                        public string DBName { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether the number of databases that are managed by the account exceeds the upper limit. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("PrivExceeded")]
                [Validation(Required=false)]
                public string PrivExceeded { get; set; }

                /// <summary>
                /// Indicates whether the account has the replication permissions. Valid values:
                /// 
                /// *   **t**: yes
                /// *   **f**: no
                /// 
                /// > This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("Replication")]
                [Validation(Required=false)]
                public string Replication { get; set; }

                /// <summary>
                /// The expiration time of the password. Valid values:
                /// 
                /// *   **infinity**: The password never expires.
                /// *   **Empty**: The expiration time is not specified.
                /// *   **Actual expiration time** in the format of *yyyy-MM-dd*T*HH:mm:ss*Z in UTC. Example: 2022-10-01T00:00:00Z.
                /// 
                /// > This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("ValidUntil")]
                [Validation(Required=false)]
                public string ValidUntil { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The first time when the superuser account was enabled. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("SystemAdminAccountFirstActivationTime")]
        [Validation(Required=false)]
        public string SystemAdminAccountFirstActivationTime { get; set; }

        /// <summary>
        /// Indicates whether the superuser account is enabled.
        /// </summary>
        [NameInMap("SystemAdminAccountStatus")]
        [Validation(Required=false)]
        public string SystemAdminAccountStatus { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
