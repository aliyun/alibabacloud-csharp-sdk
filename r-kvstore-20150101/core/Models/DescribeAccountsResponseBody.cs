// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// Details about returned accounts of the instance.
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
                /// The description of the account.
                /// </summary>
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                /// <summary>
                /// The name of the account.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// The state of the account. Valid values:
                /// 
                /// *   **Unavailable**: The account is unavailable.
                /// *   **Available**: The account is available.
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// The type of the account. Valid values:
                /// 
                /// *   **Normal**: standard account
                /// *   **Super**: super account
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// Details about account permissions.
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
                        /// The permission of the account. Default value: RoleReadWrite. Valid values:
                        /// 
                        /// *   **RoleReadOnly**: The account has the read-only permissions.
                        /// *   **RoleReadWrite**: The account has the read and write permissions.
                        /// </summary>
                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

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
