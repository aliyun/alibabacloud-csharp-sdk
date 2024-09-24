// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the account.</para>
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
                /// <para>The description of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test account</para>
                /// </summary>
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                /// <summary>
                /// <para>The name of the database account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The status of the account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unavailable</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// <para>The type of the account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: standard account</description></item>
                /// <item><description><b>Super</b>: privileged account</description></item>
                /// <item><description><b>Sysadmin</b>: system admin account, which is supported only for instances running SQL Server</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>Indicates whether the account has the row-level security (RLS) permissions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>t</b>: The account has the RLS permissions.</description></item>
                /// <item><description><b>f</b>: The account does not have the RLS permissions.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run PostgreSQL.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>f</para>
                /// </summary>
                [NameInMap("BypassRLS")]
                [Validation(Required=false)]
                public string BypassRLS { get; set; }

                /// <summary>
                /// <para>Indicates whether the password policy is applied.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CheckPolicy")]
                [Validation(Required=false)]
                public bool? CheckPolicy { get; set; }

                /// <summary>
                /// <para>Indicates whether the account has the permissions to create databases. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>t</b>: The account has the permissions to create databases.</description></item>
                /// <item><description><b>f</b>: The account does not have the permissions to create databases.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run PostgreSQL.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>t</para>
                /// </summary>
                [NameInMap("CreateDB")]
                [Validation(Required=false)]
                public string CreateDB { get; set; }

                /// <summary>
                /// <para>Indicates whether the account has the permissions to create roles. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>t</b>: The account has the permissions to create roles.</description></item>
                /// <item><description><b>f</b>: The account does not have the permissions to create roles.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run PostgreSQL.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>t</para>
                /// </summary>
                [NameInMap("CreateRole")]
                [Validation(Required=false)]
                public string CreateRole { get; set; }

                /// <summary>
                /// <para>The ID of the instance to which the account belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5*****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The details about the permissions that are granted to the account.</para>
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
                        /// <para>The type of the permissions. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>ReadWrite</b>: read and write permissions.</description></item>
                        /// <item><description><b>ReadOnly</b>: read-only permissions.</description></item>
                        /// <item><description><b>DDLOnly</b>: DDL-only permissions.</description></item>
                        /// <item><description><b>DMLOnly</b>: DML-only permissions.</description></item>
                        /// <item><description><b>Custom</b>: custom permissions. You can modify the permissions of the account by using SQL commands.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ReadWrite</para>
                        /// </summary>
                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                        /// <summary>
                        /// <para>The permissions that are granted to the account. For more information, see <a href="https://help.aliyun.com/document_detail/146395.html">Account permissions</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SELECT,INSERT</para>
                        /// </summary>
                        [NameInMap("AccountPrivilegeDetail")]
                        [Validation(Required=false)]
                        public string AccountPrivilegeDetail { get; set; }

                        /// <summary>
                        /// <para>The name of the database.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test1</para>
                        /// </summary>
                        [NameInMap("DBName")]
                        [Validation(Required=false)]
                        public string DBName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The expiration time of the password.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-21</para>
                /// </summary>
                [NameInMap("PasswordExpireTime")]
                [Validation(Required=false)]
                public string PasswordExpireTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the number of databases that are managed by the account exceeds the upper limit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The number of databases that are managed by the account exceeds the upper limit.</description></item>
                /// <item><description><b>0</b>: The number of databases that are managed by the account does not exceed the upper limit.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PrivExceeded")]
                [Validation(Required=false)]
                public string PrivExceeded { get; set; }

                /// <summary>
                /// <para>Indicates whether the account has the replication permissions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>t</b>: The account has the replication permissions.</description></item>
                /// <item><description><b>f</b>: The account does not have the replication permissions.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run PostgreSQL.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>t</para>
                /// </summary>
                [NameInMap("Replication")]
                [Validation(Required=false)]
                public string Replication { get; set; }

                /// <summary>
                /// <para>The expiration time of the password. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>infinity</b>: The password never expires.</description></item>
                /// <item><description><b>Empty</b>: The expiration time is not specified.</description></item>
                /// <item><description><b>Actual expiration time</b>: in the format of <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z in UTC. Example: 2022-10-01T00:00:00Z.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run PostgreSQL.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("ValidUntil")]
                [Validation(Required=false)]
                public string ValidUntil { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2E94301-D07F-4457-9B49-6AA2BB388C85</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The first time when the system admin account was enabled. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// <remarks>
        /// <para> This parameter is returned only for instances that run SQL Server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-06T11:00:00Z</para>
        /// </summary>
        [NameInMap("SystemAdminAccountFirstActivationTime")]
        [Validation(Required=false)]
        public string SystemAdminAccountFirstActivationTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the system admin account was enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system admin account was enabled.</description></item>
        /// <item><description><b>false</b>: The system admin account was disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The <a href="https://help.aliyun.com/document_detail/170736.html">system admin account</a> is supported only for the instances that run SQL Server. If the instance runs SQL Server, a value is returned for this parameter. If the instance runs a different database engine, no value is returned for this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("SystemAdminAccountStatus")]
        [Validation(Required=false)]
        public string SystemAdminAccountStatus { get; set; }

        /// <summary>
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
