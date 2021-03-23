// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccounts Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsAccount> Account { get; set; }
            public class DescribeAccountsResponseBodyAccountsAccount : TeaModel {
                public string InstanceId { get; set; }
                public string AccountName { get; set; }
                public string AccountStatus { get; set; }
                public string AccountType { get; set; }
                public string AccountDescription { get; set; }
                public DescribeAccountsResponseBodyAccountsAccountDatabasePrivileges DatabasePrivileges { get; set; }
                public class DescribeAccountsResponseBodyAccountsAccountDatabasePrivileges : TeaModel {
                    [NameInMap("DatabasePrivilege")]
                    [Validation(Required=false)]
                    public List<DescribeAccountsResponseBodyAccountsAccountDatabasePrivilegesDatabasePrivilege> DatabasePrivilege { get; set; }
                    public class DescribeAccountsResponseBodyAccountsAccountDatabasePrivilegesDatabasePrivilege : TeaModel {
                        [NameInMap("AccountPrivilege")]
                        [Validation(Required=false)]
                        public string AccountPrivilege { get; set; }

                    }

                }
            }
        };

    }

}
