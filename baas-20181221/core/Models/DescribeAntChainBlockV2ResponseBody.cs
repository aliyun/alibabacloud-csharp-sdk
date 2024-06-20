// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainBlockV2ResponseBody : TeaModel {
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
        public DescribeAntChainBlockV2ResponseBodyResult Result { get; set; }
        public class DescribeAntChainBlockV2ResponseBodyResult : TeaModel {
            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }

            [NameInMap("BlockHash")]
            [Validation(Required=false)]
            public string BlockHash { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            [NameInMap("PreviousHash")]
            [Validation(Required=false)]
            public string PreviousHash { get; set; }

            [NameInMap("RootTxHash")]
            [Validation(Required=false)]
            public string RootTxHash { get; set; }

            [NameInMap("TransSummaryList")]
            [Validation(Required=false)]
            public List<DescribeAntChainBlockV2ResponseBodyResultTransSummaryList> TransSummaryList { get; set; }
            public class DescribeAntChainBlockV2ResponseBodyResultTransSummaryList : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("BlockHash")]
                [Validation(Required=false)]
                public string BlockHash { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public int? Category { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                [NameInMap("GasUsed")]
                [Validation(Required=false)]
                public long? GasUsed { get; set; }

                [NameInMap("Hash")]
                [Validation(Required=false)]
                public string Hash { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                [NameInMap("ReferenceCount")]
                [Validation(Required=false)]
                public int? ReferenceCount { get; set; }

                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

                [NameInMap("TransTypeV10")]
                [Validation(Required=false)]
                public string TransTypeV10 { get; set; }

                [NameInMap("TransTypeV6")]
                [Validation(Required=false)]
                public string TransTypeV6 { get; set; }

            }

            [NameInMap("TransactionSize")]
            [Validation(Required=false)]
            public int? TransactionSize { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

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
