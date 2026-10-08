// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccounts Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("DBInstanceAccount")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsDBInstanceAccount> DBInstanceAccount { get; set; }
            public class DescribeAccountsResponseBodyAccountsDBInstanceAccount : TeaModel {
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                [NameInMap("BypassRLS")]
                [Validation(Required=false)]
                public string BypassRLS { get; set; }

                [NameInMap("CheckPolicy")]
                [Validation(Required=false)]
                public bool? CheckPolicy { get; set; }

                [NameInMap("CreateDB")]
                [Validation(Required=false)]
                public string CreateDB { get; set; }

                [NameInMap("CreateRole")]
                [Validation(Required=false)]
                public string CreateRole { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DatabasePrivileges")]
                [Validation(Required=false)]
                public DescribeAccountsResponseBodyAccountsDBInstanceAccountDatabasePrivileges DatabasePrivileges { get; set; }
                public class DescribeAccountsResponseBodyAccountsDBInstanceAccountDatabasePrivileges : TeaModel {
                    [NameInMap("DatabasePrivilege")]
                    [Validation(Required=false)]
                    public List<DescribeAccountsResponseBodyAccountsDBInstanceAccountDatabasePrivilegesDatabasePrivilege> DatabasePrivilege { get; set; }
                    public class DescribeAccountsResponseBodyAccountsDBInstanceAccountDatabasePrivilegesDatabasePrivilege : TeaModel {
                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                        [NameInMap("AccountPrivilegeDetail")]
                        [Validation(Required=false)]
                        public string AccountPrivilegeDetail { get; set; }

                        [NameInMap("DBName")]
                        [Validation(Required=false)]
                        public string DBName { get; set; }

                    }

                }

                [NameInMap("PasswordExpireTime")]
                [Validation(Required=false)]
                public string PasswordExpireTime { get; set; }

                [NameInMap("PrivExceeded")]
                [Validation(Required=false)]
                public string PrivExceeded { get; set; }

                [NameInMap("Replication")]
                [Validation(Required=false)]
                public string Replication { get; set; }

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
        /// <para>17F2EA6C-3CA2-528D-A263-DC29707AD652</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The time when the super administrator (SA) account was first activated. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <remarks>
        /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-17T07:51:22Z</para>
        /// </summary>
        [NameInMap("SystemAdminAccountFirstActivationTime")]
        [Validation(Required=false)]
        public string SystemAdminAccountFirstActivationTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the super administrator (SA) account is activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: Activated.</description></item>
        /// <item><description><b>False</b>: Not activated.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only ApsaraDB RDS for SQL Server instances support the <a href="https://help.aliyun.com/document_detail/170736.html">super administrator (SA) account</a>, and this parameter has a return value. For instances of other engines, the return value is empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("SystemAdminAccountStatus")]
        [Validation(Required=false)]
        public string SystemAdminAccountStatus { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
