// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainTransactionV2ResponseBody : TeaModel {
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
        public DescribeAntChainTransactionV2ResponseBodyResult Result { get; set; }
        public class DescribeAntChainTransactionV2ResponseBodyResult : TeaModel {
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
            public DescribeAntChainTransactionV2ResponseBodyResultTransaction Transaction { get; set; }
            public class DescribeAntChainTransactionV2ResponseBodyResultTransaction : TeaModel {
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
