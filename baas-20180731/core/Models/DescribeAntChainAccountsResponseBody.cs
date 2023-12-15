// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeAntChainAccountsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainAccountsResponseBodyResult Result { get; set; }
        public class DescribeAntChainAccountsResponseBodyResult : TeaModel {
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribeAntChainAccountsResponseBodyResultAccounts> Accounts { get; set; }
            public class DescribeAntChainAccountsResponseBodyResultAccounts : TeaModel {
                [NameInMap("Account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                [NameInMap("AccountPublicKey")]
                [Validation(Required=false)]
                public string AccountPublicKey { get; set; }

                [NameInMap("AccountRecoveryKey")]
                [Validation(Required=false)]
                public string AccountRecoveryKey { get; set; }

                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                [NameInMap("AntChainId")]
                [Validation(Required=false)]
                public string AntChainId { get; set; }

            }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainAccountsResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainAccountsResponseBodyResultPagination : TeaModel {
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

    }

}
