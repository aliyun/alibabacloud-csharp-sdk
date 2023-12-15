// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeEthereumNodeConfigurationResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeEthereumNodeConfigurationResponseBodyResult> Result { get; set; }
        public class DescribeEthereumNodeConfigurationResponseBodyResult : TeaModel {
            [NameInMap("GenesisJson")]
            [Validation(Required=false)]
            public string GenesisJson { get; set; }

            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            [NameInMap("NodePub")]
            [Validation(Required=false)]
            public string NodePub { get; set; }

            [NameInMap("P2pPort")]
            [Validation(Required=false)]
            public int? P2pPort { get; set; }

            [NameInMap("PermissionedNodesJson")]
            [Validation(Required=false)]
            public string PermissionedNodesJson { get; set; }

            [NameInMap("RaftPort")]
            [Validation(Required=false)]
            public int? RaftPort { get; set; }

            [NameInMap("RpcPort")]
            [Validation(Required=false)]
            public int? RpcPort { get; set; }

            [NameInMap("StaticNodesJson")]
            [Validation(Required=false)]
            public string StaticNodesJson { get; set; }

            [NameInMap("TMJson")]
            [Validation(Required=false)]
            public string TMJson { get; set; }

            [NameInMap("TMPort")]
            [Validation(Required=false)]
            public int? TMPort { get; set; }

            [NameInMap("TMPub")]
            [Validation(Required=false)]
            public string TMPub { get; set; }

            [NameInMap("WSPort")]
            [Validation(Required=false)]
            public int? WSPort { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
