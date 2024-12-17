// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about returned accounts of the instance.</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccounts Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsAccount> Account { get; set; }
            public class DescribeAccountsResponseBodyAccountsAccount : TeaModel {
                /// <summary>
                /// <para>The description of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testdec</para>
                /// </summary>
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                /// <summary>
                /// <para>The name of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demoaccount</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The state of the account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unavailable</b>: The account is unavailable.</description></item>
                /// <item><description><b>Available</b>: The account is available.</description></item>
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
                /// <item><description><b>Super</b>: super account</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>Details about account permissions.</para>
                /// </summary>
                [NameInMap("DatabasePrivileges")]
                [Validation(Required=false)]
                public DescribeAccountsResponseBodyAccountsAccountDatabasePrivileges DatabasePrivileges { get; set; }
                public class DescribeAccountsResponseBodyAccountsAccountDatabasePrivileges : TeaModel {
                    [NameInMap("DatabasePrivilege")]
                    [Validation(Required=false)]
                    public List<DescribeAccountsResponseBodyAccountsAccountDatabasePrivilegesDatabasePrivilege> DatabasePrivilege { get; set; }
                    public class DescribeAccountsResponseBodyAccountsAccountDatabasePrivilegesDatabasePrivilege : TeaModel {
                        /// <summary>
                        /// <para>The permission of the account. Default value: RoleReadWrite. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>RoleReadOnly</b>: The account has the read-only permissions.</description></item>
                        /// <item><description><b>RoleReadWrite</b>: The account has the read and write permissions.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RoleReadWrite</para>
                        /// </summary>
                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp10noxlhcoim2****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C9E114C-217C-4118-83C0-B4070222****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
