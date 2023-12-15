// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeAntChainTransactionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainTransactionResponseBodyResult Result { get; set; }
        public class DescribeAntChainTransactionResponseBodyResult : TeaModel {
            [NameInMap("BlockHash")]
            [Validation(Required=false)]
            public string BlockHash { get; set; }

            [NameInMap("BlockHeight")]
            [Validation(Required=false)]
            public long? BlockHeight { get; set; }

            [NameInMap("BlockVersion")]
            [Validation(Required=false)]
            public string BlockVersion { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }

            [NameInMap("Transaction")]
            [Validation(Required=false)]
            public DescribeAntChainTransactionResponseBodyResultTransaction Transaction { get; set; }
            public class DescribeAntChainTransactionResponseBodyResultTransaction : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                [NameInMap("Extentions")]
                [Validation(Required=false)]
                public List<string> Extentions { get; set; }

                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                [NameInMap("Gas")]
                [Validation(Required=false)]
                public string Gas { get; set; }

                [NameInMap("Hash")]
                [Validation(Required=false)]
                public string Hash { get; set; }

                [NameInMap("Nonce")]
                [Validation(Required=false)]
                public string Nonce { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                [NameInMap("Signatures")]
                [Validation(Required=false)]
                public List<string> Signatures { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

                [NameInMap("TxType")]
                [Validation(Required=false)]
                public string TxType { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
