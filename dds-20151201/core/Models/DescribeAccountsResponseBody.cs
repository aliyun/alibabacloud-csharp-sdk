// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccounts Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsAccount> Account { get; set; }
            public class DescribeAccountsResponseBodyAccountsAccount : TeaModel {
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                [NameInMap("CharacterType")]
                [Validation(Required=false)]
                public string CharacterType { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
