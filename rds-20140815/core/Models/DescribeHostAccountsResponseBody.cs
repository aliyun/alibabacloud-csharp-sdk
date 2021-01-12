// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHostAccountsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeHostAccountsResponseBodyAccounts Accounts { get; set; }
        public class DescribeHostAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribeHostAccountsResponseBodyAccountsAccounts> Accounts { get; set; }
            public class DescribeHostAccountsResponseBodyAccountsAccounts : TeaModel {
                public string AccountName { get; set; }
                public string AccountType { get; set; }
                public string AccountDescription { get; set; }
                public string AccountStatus { get; set; }
                public string DBInstanceId { get; set; }
            }
        };

    }

}
