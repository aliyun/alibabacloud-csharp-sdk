// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeAntChainSubnetNodeListResponseBody : TeaModel {
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
        public List<DescribeAntChainSubnetNodeListResponseBodyResult> Result { get; set; }
        public class DescribeAntChainSubnetNodeListResponseBodyResult : TeaModel {
            [NameInMap("ChainNodeInfoList")]
            [Validation(Required=false)]
            public List<DescribeAntChainSubnetNodeListResponseBodyResultChainNodeInfoList> ChainNodeInfoList { get; set; }
            public class DescribeAntChainSubnetNodeListResponseBodyResultChainNodeInfoList : TeaModel {
                [NameInMap("DiskTotal")]
                [Validation(Required=false)]
                public string DiskTotal { get; set; }

                [NameInMap("DiskUse")]
                [Validation(Required=false)]
                public string DiskUse { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeIp")]
                [Validation(Required=false)]
                public string NodeIp { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("NodePort")]
                [Validation(Required=false)]
                public string NodePort { get; set; }

                [NameInMap("NodeSource")]
                [Validation(Required=false)]
                public string NodeSource { get; set; }

                [NameInMap("NodeState")]
                [Validation(Required=false)]
                public string NodeState { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("PublicKey")]
                [Validation(Required=false)]
                public string PublicKey { get; set; }

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
