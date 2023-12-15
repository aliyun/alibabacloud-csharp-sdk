// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeEthereumNodesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeEthereumNodesResponseBodyResult> Result { get; set; }
        public class DescribeEthereumNodesResponseBodyResult : TeaModel {
            [NameInMap("Consensus")]
            [Validation(Required=false)]
            public string Consensus { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EthereumId")]
            [Validation(Required=false)]
            public string EthereumId { get; set; }

            [NameInMap("EthereumName")]
            [Validation(Required=false)]
            public string EthereumName { get; set; }

            [NameInMap("External")]
            [Validation(Required=false)]
            public bool? External { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public long? NetworkId { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("PublicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RpcPort")]
            [Validation(Required=false)]
            public string RpcPort { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Validator")]
            [Validation(Required=false)]
            public bool? Validator { get; set; }

            [NameInMap("WsPort")]
            [Validation(Required=false)]
            public string WsPort { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
