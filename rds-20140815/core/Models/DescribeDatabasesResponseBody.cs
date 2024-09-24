// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDatabasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the databases.</para>
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
                /// <para>The information about the account. Each account has specific permissions on the database.</para>
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
                        /// <para>The account username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Account")]
                        [Validation(Required=false)]
                        public string Account { get; set; }

                        /// <summary>
                        /// <para>The permissions that the account has on the database. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>ReadWrite</b>: read and write permissions</description></item>
                        /// <item><description><b>ReadOnly</b>: read-only permissions</description></item>
                        /// <item><description><b>DMLOnly</b>: DML-only permissions</description></item>
                        /// <item><description><b>DDLOnly</b>: DDL-only permissions</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DMLOnly</para>
                        /// </summary>
                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                        /// <summary>
                        /// <para>The permission that the account has on the database.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SELECT</para>
                        /// </summary>
                        [NameInMap("AccountPrivilegeDetail")]
                        [Validation(Required=false)]
                        public string AccountPrivilegeDetail { get; set; }

                    }

                }

                /// <summary>
                /// <para>The advanced information about the database.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
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
                /// <para>The basic information about the database.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
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
                /// <para>The name of the character set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utf8</para>
                /// </summary>
                [NameInMap("CharacterSetName")]
                [Validation(Required=false)]
                public string CharacterSetName { get; set; }

                /// <summary>
                /// <para>The collation of the character set. The example value C indicates localization.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run PostgreSQL.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>C</para>
                /// </summary>
                [NameInMap("Collate")]
                [Validation(Required=false)]
                public string Collate { get; set; }

                /// <summary>
                /// <para>The limit on the number of concurrent requests. The value -1 indicates that the number of concurrent requests is unlimited.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run PostgreSQL.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("ConnLimit")]
                [Validation(Required=false)]
                public string ConnLimit { get; set; }

                /// <summary>
                /// <para>The type of the character set.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run PostgreSQL.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>en_US.utf8</para>
                /// </summary>
                [NameInMap("Ctype")]
                [Validation(Required=false)]
                public string Ctype { get; set; }

                /// <summary>
                /// <para>The description of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testdb</para>
                /// </summary>
                [NameInMap("DBDescription")]
                [Validation(Required=false)]
                public string DBDescription { get; set; }

                /// <summary>
                /// <para>The ID of the instance to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDB01</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The database status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Creating</b></description></item>
                /// <item><description><b>Running</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// <item><description><b>Cold</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Creating</para>
                /// </summary>
                [NameInMap("DBStatus")]
                [Validation(Required=false)]
                public string DBStatus { get; set; }

                /// <summary>
                /// <para>The database engine of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The page number of the page to return.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                /// <summary>
                /// <para>The number of entries per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The runtime information about the database.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
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
                /// <para>The database tablespace.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run PostgreSQL.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>pg_default</para>
                /// </summary>
                [NameInMap("Tablespace")]
                [Validation(Required=false)]
                public string Tablespace { get; set; }

                /// <summary>
                /// <para>The total number of entries returned.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2603CA96-B17D-4903-BC04-61A2C829CD94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
