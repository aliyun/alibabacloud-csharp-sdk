// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeAntChainSubnetListResponseBody : TeaModel {
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
        public DescribeAntChainSubnetListResponseBodyResult Result { get; set; }
        public class DescribeAntChainSubnetListResponseBodyResult : TeaModel {
            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }

            [NameInMap("BlockchainName")]
            [Validation(Required=false)]
            public string BlockchainName { get; set; }

            [NameInMap("BlockchainSubnetList")]
            [Validation(Required=false)]
            public List<DescribeAntChainSubnetListResponseBodyResultBlockchainSubnetList> BlockchainSubnetList { get; set; }
            public class DescribeAntChainSubnetListResponseBodyResultBlockchainSubnetList : TeaModel {
                [NameInMap("AntChainId")]
                [Validation(Required=false)]
                public string AntChainId { get; set; }

                [NameInMap("BlockHeight")]
                [Validation(Required=false)]
                public long? BlockHeight { get; set; }

                [NameInMap("ConsortiumMember")]
                [Validation(Required=false)]
                public bool? ConsortiumMember { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Monitor")]
                [Validation(Required=false)]
                public bool? Monitor { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NodeSum")]
                [Validation(Required=false)]
                public int? NodeSum { get; set; }

                [NameInMap("Rest")]
                [Validation(Required=false)]
                public string Rest { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TransactionSum")]
                [Validation(Required=false)]
                public long? TransactionSum { get; set; }

            }

            [NameInMap("ConsortiumAdmin")]
            [Validation(Required=false)]
            public bool? ConsortiumAdmin { get; set; }

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
