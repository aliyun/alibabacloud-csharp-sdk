// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDatabasesResponseBody : TeaModel {
        /// <summary>
        /// The information about databases.
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
                /// An array that consists of the details of the accounts. Each account has specific permissions on the database.
                /// </summary>
                [NameInMap("Accounts")]
                [Validation(Required=false)]
                public DescribeDatabasesResponseBodyDatabasesDatabaseAccounts Accounts { get; set; }
                public class DescribeDatabasesResponseBodyDatabasesDatabaseAccounts : TeaModel {
                    [NameInMap("AccountPrivilegeInfo")]
                    [Validation(Required=false)]
                    public List<DescribeDatabasesResponseBodyDatabasesDatabaseAccountsAccountPrivilegeInfo> AccountPrivilegeInfo { get; set; }
                    public class DescribeDatabasesResponseBodyDatabasesDatabaseAccountsAccountPrivilegeInfo : TeaModel {
                        /// <summary>
                        /// The username of the account.
                        /// </summary>
                        [NameInMap("Account")]
                        [Validation(Required=false)]
                        public string Account { get; set; }

                        /// <summary>
                        /// The permissions that the account has on the database. Valid values:
                        /// 
                        /// *   **ReadWrite**: read and write permissions
                        /// *   **ReadOnly**: read-only permissions
                        /// *   **DMLOnly**: DML-only permissions
                        /// *   **DDLOnly**: DDL-only permissions
                        /// </summary>
                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                        /// <summary>
                        /// The details of the permissions that the account has on the database.
                        /// </summary>
                        [NameInMap("AccountPrivilegeDetail")]
                        [Validation(Required=false)]
                        public string AccountPrivilegeDetail { get; set; }

                    }

                }

                /// <summary>
                /// The advanced information about the database.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("AdvancedInfo")]
                [Validation(Required=false)]
                public DescribeDatabasesResponseBodyDatabasesDatabaseAdvancedInfo AdvancedInfo { get; set; }
                public class DescribeDatabasesResponseBodyDatabasesDatabaseAdvancedInfo : TeaModel {
                    [NameInMap("AdvancedDbProperty")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> AdvancedDbProperty { get; set; }

                }

                /// <summary>
                /// The basic information of the database.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("BasicInfo")]
                [Validation(Required=false)]
                public DescribeDatabasesResponseBodyDatabasesDatabaseBasicInfo BasicInfo { get; set; }
                public class DescribeDatabasesResponseBodyDatabasesDatabaseBasicInfo : TeaModel {
                    [NameInMap("BasicDbProperty")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> BasicDbProperty { get; set; }

                }

                /// <summary>
                /// The name of the character set.
                /// </summary>
                [NameInMap("CharacterSetName")]
                [Validation(Required=false)]
                public string CharacterSetName { get; set; }

                /// <summary>
                /// The collation of the character set. The example value C stands for localization.
                /// 
                /// > This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("Collate")]
                [Validation(Required=false)]
                public string Collate { get; set; }

                /// <summary>
                /// The limit on the number of concurrent requests. The value -1 indicates that the number of concurrent requests is unlimited.
                /// 
                /// > This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("ConnLimit")]
                [Validation(Required=false)]
                public string ConnLimit { get; set; }

                /// <summary>
                /// The type of the character set.
                /// 
                /// > This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("Ctype")]
                [Validation(Required=false)]
                public string Ctype { get; set; }

                /// <summary>
                /// The description of the database.
                /// </summary>
                [NameInMap("DBDescription")]
                [Validation(Required=false)]
                public string DBDescription { get; set; }

                /// <summary>
                /// The ID of the instance to which the database belongs.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// The status of the database. Valid values:
                /// 
                /// *   **Creating**
                /// *   **Running**
                /// *   **Deleting**
                /// </summary>
                [NameInMap("DBStatus")]
                [Validation(Required=false)]
                public string DBStatus { get; set; }

                /// <summary>
                /// The database engine of the instance.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The running of the database.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("RuntimeInfo")]
                [Validation(Required=false)]
                public DescribeDatabasesResponseBodyDatabasesDatabaseRuntimeInfo RuntimeInfo { get; set; }
                public class DescribeDatabasesResponseBodyDatabasesDatabaseRuntimeInfo : TeaModel {
                    [NameInMap("RuntimeDbProperty")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> RuntimeDbProperty { get; set; }

                }

                /// <summary>
                /// The tablespace of the database.
                /// 
                /// > This parameter is returned only for instances that run PostgreSQL.
                /// </summary>
                [NameInMap("Tablespace")]
                [Validation(Required=false)]
                public string Tablespace { get; set; }

                /// <summary>
                /// The total number of entries returned.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
