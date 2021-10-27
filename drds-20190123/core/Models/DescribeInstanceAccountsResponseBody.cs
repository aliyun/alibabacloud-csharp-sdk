// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstanceAccountsResponseBody : TeaModel {
        [NameInMap("InstanceAccounts")]
        [Validation(Required=false)]
        public DescribeInstanceAccountsResponseBodyInstanceAccounts InstanceAccounts { get; set; }
        public class DescribeInstanceAccountsResponseBodyInstanceAccounts : TeaModel {
            [NameInMap("InstanceAccount")]
            [Validation(Required=false)]
            public List<DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccount> InstanceAccount { get; set; }
            public class DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccount : TeaModel {
                public string AccountName { get; set; }
                public int? AccountType { get; set; }
                public DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivileges DbPrivileges { get; set; }
                public class DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivileges : TeaModel {
                    [NameInMap("DbPrivilege")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivilegesDbPrivilege> DbPrivilege { get; set; }
                    public class DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivilegesDbPrivilege : TeaModel {
                        [NameInMap("DbName")]
                        [Validation(Required=false)]
                        public string DbName { get; set; }

                        [NameInMap("Privilege")]
                        [Validation(Required=false)]
                        public string Privilege { get; set; }

                    }

                }
                public string Description { get; set; }
                public string Host { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
