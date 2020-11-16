// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeAccountsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Accounts")]
        [Validation(Required=true)]
        public DescribeAccountsResponseAccounts Accounts { get; set; }
        public class DescribeAccountsResponseAccounts : TeaModel {
            [NameInMap("DBInstanceAccount")]
            [Validation(Required=true)]
            public List<DescribeAccountsResponseAccountsDBInstanceAccount> DBInstanceAccount { get; set; }
            public class DescribeAccountsResponseAccountsDBInstanceAccount : TeaModel {
                public string DBInstanceId { get; set; }
                public string AccountName { get; set; }
                public string AccountStatus { get; set; }
                public string AccountDescription { get; set; }
            }
        };

    }

}
