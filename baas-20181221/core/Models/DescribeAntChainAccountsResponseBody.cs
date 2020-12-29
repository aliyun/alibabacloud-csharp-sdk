// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainAccountsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainAccountsResponseBodyResult Result { get; set; }
        public class DescribeAntChainAccountsResponseBodyResult : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainAccountsResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainAccountsResponseBodyResultPagination : TeaModel {
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribeAntChainAccountsResponseBodyResultAccounts> Accounts { get; set; }
            public class DescribeAntChainAccountsResponseBodyResultAccounts : TeaModel {
                public string AccountPublicKey { get; set; }
                public string Account { get; set; }
                public string AccountStatus { get; set; }
                public string AccountRecoveryKey { get; set; }
                public string AntChainId { get; set; }
            }
        };

    }

}
