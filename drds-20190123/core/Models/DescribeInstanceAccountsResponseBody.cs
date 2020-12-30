// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstanceAccountsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceAccounts")]
        [Validation(Required=false)]
        public DescribeInstanceAccountsResponseBodyInstanceAccounts InstanceAccounts { get; set; }
        public class DescribeInstanceAccountsResponseBodyInstanceAccounts : TeaModel {
            [NameInMap("InstanceAccount")]
            [Validation(Required=false)]
            public List<DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccount> InstanceAccount { get; set; }
            public class DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccount : TeaModel {
                [NameInMap("DbPrivilege")]
                [Validation(Required=false)]
                public List<DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivilege> DbPrivilege { get; set; }
                public class DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivilege : TeaModel {
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    [NameInMap("Privilege")]
                    [Validation(Required=false)]
                    public string Privilege { get; set; }

                }

            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
