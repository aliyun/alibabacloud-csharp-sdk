// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class UpdateEthereumNodeConfigurationRequest : TeaModel {
        [NameInMap("IP")]
        [Validation(Required=false)]
        public string IP { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("NodePub")]
        [Validation(Required=false)]
        public string NodePub { get; set; }

        [NameInMap("P2pPort")]
        [Validation(Required=false)]
        public int? P2pPort { get; set; }

        [NameInMap("RaftPort")]
        [Validation(Required=false)]
        public int? RaftPort { get; set; }

        [NameInMap("RpcPort")]
        [Validation(Required=false)]
        public int? RpcPort { get; set; }

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

}
