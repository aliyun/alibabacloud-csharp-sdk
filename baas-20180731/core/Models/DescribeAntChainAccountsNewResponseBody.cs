// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeAntChainAccountsNewResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainAccountsNewResponseBodyResult Result { get; set; }
        public class DescribeAntChainAccountsNewResponseBodyResult : TeaModel {
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribeAntChainAccountsNewResponseBodyResultAccounts> Accounts { get; set; }
            public class DescribeAntChainAccountsNewResponseBodyResultAccounts : TeaModel {
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

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

            }

            [NameInMap("ConsortiumAdmin")]
            [Validation(Required=false)]
            public bool? ConsortiumAdmin { get; set; }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainAccountsNewResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainAccountsNewResponseBodyResultPagination : TeaModel {
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

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
