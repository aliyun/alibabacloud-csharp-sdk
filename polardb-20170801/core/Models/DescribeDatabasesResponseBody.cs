// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDatabasesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about databases.</para>
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
                /// <para>Details about the accounts.</para>
                /// <remarks>
                /// <para>A PolarDB for MySQL cluster does not support privileged accounts.</para>
                /// </remarks>
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
                        /// <para>The username of the account.</para>
                        /// <remarks>
                        /// <para>A PolarDB for MySQL cluster does not support privileged accounts.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test_acc</para>
                        /// </summary>
                        [NameInMap("AccountName")]
                        [Validation(Required=false)]
                        public string AccountName { get; set; }

                        /// <summary>
                        /// <para>The permissions that are granted to the account. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>ReadWrite</b>: read and write permissions</description></item>
                        /// <item><description><b>ReadOnly</b>: read-only permissions</description></item>
                        /// <item><description><b>DMLOnly</b>: The account is granted the permissions to execute only DML statements on the database.</description></item>
                        /// <item><description><b>DDLOnly</b>: The account is granted the permissions to execute only DDL statements on the database.</description></item>
                        /// <item><description><b>ReadIndex</b>: The account has the read and index permissions on the database.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ReadOnly</para>
                        /// </summary>
                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                        /// <summary>
                        /// <para>The state of the account. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Creating</b></description></item>
                        /// <item><description><b>Available</b></description></item>
                        /// <item><description><b>Deleting</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Available</para>
                        /// </summary>
                        [NameInMap("AccountStatus")]
                        [Validation(Required=false)]
                        public string AccountStatus { get; set; }

                        /// <summary>
                        /// <para>The authorization state of the account. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Empowering</b>: The system is granting permissions to the account.</description></item>
                        /// <item><description><b>Empowered</b>: Permissions are granted to the account.</description></item>
                        /// <item><description><b>Removing</b>: The system is revoking permissions from the account.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Empowered</para>
                        /// </summary>
                        [NameInMap("PrivilegeStatus")]
                        [Validation(Required=false)]
                        public string PrivilegeStatus { get; set; }

                    }

                }

                /// <summary>
                /// <para>The character set that the database uses. For more information, see <a href="https://help.aliyun.com/document_detail/99716.html">Character set tables</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utf8mb4</para>
                /// </summary>
                [NameInMap("CharacterSetName")]
                [Validation(Required=false)]
                public string CharacterSetName { get; set; }

                /// <summary>
                /// <para>The description of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_des</para>
                /// </summary>
                [NameInMap("DBDescription")]
                [Validation(Required=false)]
                public string DBDescription { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_db</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The state of the database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Creating</b></description></item>
                /// <item><description><b>Running</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBStatus")]
                [Validation(Required=false)]
                public string DBStatus { get; set; }

                /// <summary>
                /// <para>The type of the database engine. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>MySQL</b></description></item>
                /// <item><description><b>Oracle</b></description></item>
                /// <item><description><b>PostgreSQL</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The ID of the primary node in the cluster of Multi-master Cluster (Database/Table) Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MasterID")]
                [Validation(Required=false)]
                public string MasterID { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1DF8CA6-2300-448B-9ABF-760C4B******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
