// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// The details of the account.
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
                /// The name of the database account.
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
                /// *   **Sysadmin**: system admin account, which is supported only for instances running SQL Server
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// Indicates whether the account has the row-level security (RLS) permissions. Valid values:
                /// 
                /// *   **t**: The account has the RLS permissions.
                /// *   **f**: The account does not have the RLS permissions.
                /// 
                /// >  This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("BypassRLS")]
                [Validation(Required=false)]
                public string BypassRLS { get; set; }

                [NameInMap("CheckPolicy")]
                [Validation(Required=false)]
                public bool? CheckPolicy { get; set; }

                /// <summary>
                /// Indicates whether the account has the permissions to create databases. Valid values:
                /// 
                /// *   **t**: The account has the permissions to create databases.
                /// *   **f**: The account does not have the permissions to create databases.
                /// 
                /// >  This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("CreateDB")]
                [Validation(Required=false)]
                public string CreateDB { get; set; }

                /// <summary>
                /// Indicates whether the account has the permissions to create roles. Valid values:
                /// 
                /// *   **t**: The account has the permissions to create roles.
                /// *   **f**: The account does not have the permissions to create roles.
                /// 
                /// >  This parameter is returned only for instances that run PostgreSQL.
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
                /// The details about the permissions that are granted to the account.
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
                        /// *   **ReadWrite**: read and write permissions.
                        /// *   **ReadOnly**: read-only permissions.
                        /// *   **DDLOnly**: DDL-only permissions.
                        /// *   **DMLOnly**: DML-only permissions.
                        /// *   **Custom**: custom permissions. You can modify the permissions of the account by using SQL commands.
                        /// </summary>
                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                        /// <summary>
                        /// The permissions that are granted to the account. For more information, see [Account permissions](https://help.aliyun.com/document_detail/146395.html).
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

                [NameInMap("PasswordExpireTime")]
                [Validation(Required=false)]
                public string PasswordExpireTime { get; set; }

                /// <summary>
                /// Indicates whether the number of databases that are managed by the account exceeds the upper limit. Valid values:
                /// 
                /// *   **1**: The number of databases that are managed by the account exceeds the upper limit.
                /// *   **0**: The number of databases that are managed by the account does not exceed the upper limit.
                /// </summary>
                [NameInMap("PrivExceeded")]
                [Validation(Required=false)]
                public string PrivExceeded { get; set; }

                /// <summary>
                /// Indicates whether the account has the replication permissions. Valid values:
                /// 
                /// *   **t**: The account has the replication permissions.
                /// *   **f**: The account does not have the replication permissions.
                /// 
                /// >  This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("Replication")]
                [Validation(Required=false)]
                public string Replication { get; set; }

                /// <summary>
                /// The expiration time of the password. Valid values:
                /// 
                /// *   **infinity**: The password never expires.
                /// *   **Empty**: The expiration time is not specified.
                /// *   **Actual expiration time**: in the format of *yyyy-MM-dd*T*HH:mm:ss*Z in UTC. Example: 2022-10-01T00:00:00Z.
                /// 
                /// >  This parameter is returned only for instances that run PostgreSQL.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The first time when the system admin account was enabled. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// 
        /// >  This parameter is returned only for instances that run SQL Server.
        /// </summary>
        [NameInMap("SystemAdminAccountFirstActivationTime")]
        [Validation(Required=false)]
        public string SystemAdminAccountFirstActivationTime { get; set; }

        /// <summary>
        /// Indicates whether the system admin account was enabled. Valid values:
        /// 
        /// *   **true**: The system admin account was enabled.
        /// *   **false**: The system admin account was disabled.
        /// 
        /// >  The [system admin account](https://help.aliyun.com/document_detail/170736.html) is supported only for the instances that run SQL Server. If the instance runs SQL Server, a value is returned for this parameter. If the instance runs a different database engine, no value is returned for this parameter.
        /// </summary>
        [NameInMap("SystemAdminAccountStatus")]
        [Validation(Required=false)]
        public string SystemAdminAccountStatus { get; set; }

        /// <summary>
        /// The total number of entries that are returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
