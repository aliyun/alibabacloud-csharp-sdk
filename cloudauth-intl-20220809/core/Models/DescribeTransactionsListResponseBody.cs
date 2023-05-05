// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DescribeTransactionsListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTransactionsListResponseBodyData Data { get; set; }
        public class DescribeTransactionsListResponseBodyData : TeaModel {
            [NameInMap("In")]
            [Validation(Required=false)]
            public List<DescribeTransactionsListResponseBodyDataIn> In { get; set; }
            public class DescribeTransactionsListResponseBodyDataIn : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Amount")]
                [Validation(Required=false)]
                public float? Amount { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("TxHashList")]
                [Validation(Required=false)]
                public List<string> TxHashList { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("Out")]
            [Validation(Required=false)]
            public List<DescribeTransactionsListResponseBodyDataOut> Out { get; set; }
            public class DescribeTransactionsListResponseBodyDataOut : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Amount")]
                [Validation(Required=false)]
                public float? Amount { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("TxHashList")]
                [Validation(Required=false)]
                public List<string> TxHashList { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

            [NameInMap("TransactionsOnPage")]
            [Validation(Required=false)]
            public long? TransactionsOnPage { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
