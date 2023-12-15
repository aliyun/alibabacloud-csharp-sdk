// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeTransactionFor2CBrowserResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeTransactionFor2CBrowserResponseBodyResult Result { get; set; }
        public class DescribeTransactionFor2CBrowserResponseBodyResult : TeaModel {
            [NameInMap("BlockHash")]
            [Validation(Required=false)]
            public string BlockHash { get; set; }

            [NameInMap("BlockHeight")]
            [Validation(Required=false)]
            public long? BlockHeight { get; set; }

            [NameInMap("BlockVersion")]
            [Validation(Required=false)]
            public int? BlockVersion { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("ContentHash")]
            [Validation(Required=false)]
            public string ContentHash { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }

            [NameInMap("KeyName")]
            [Validation(Required=false)]
            public string KeyName { get; set; }

            [NameInMap("KeyWrap")]
            [Validation(Required=false)]
            public string KeyWrap { get; set; }

            [NameInMap("Nonce")]
            [Validation(Required=false)]
            public string Nonce { get; set; }

            [NameInMap("ReferenceCount")]
            [Validation(Required=false)]
            public int? ReferenceCount { get; set; }

            [NameInMap("ReferenceList")]
            [Validation(Required=false)]
            public List<string> ReferenceList { get; set; }

            [NameInMap("TransTypeV6")]
            [Validation(Required=false)]
            public string TransTypeV6 { get; set; }

            [NameInMap("TransactionV10")]
            [Validation(Required=false)]
            public DescribeTransactionFor2CBrowserResponseBodyResultTransactionV10 TransactionV10 { get; set; }
            public class DescribeTransactionFor2CBrowserResponseBodyResultTransactionV10 : TeaModel {
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

                [NameInMap("SignatureList")]
                [Validation(Required=false)]
                public List<string> SignatureList { get; set; }

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
