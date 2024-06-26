// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class UpdateEthereumNodeConfigurationRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IP")]
        [Validation(Required=false)]
        public string IP { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodePub")]
        [Validation(Required=false)]
        public string NodePub { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("P2pPort")]
        [Validation(Required=false)]
        public int? P2pPort { get; set; }

        [NameInMap("RaftPort")]
        [Validation(Required=false)]
        public int? RaftPort { get; set; }

        [NameInMap("RpcPort")]
        [Validation(Required=false)]
        public int? RpcPort { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TMPort")]
        [Validation(Required=false)]
        public int? TMPort { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TMPub")]
        [Validation(Required=false)]
        public string TMPub { get; set; }

        [NameInMap("WSPort")]
        [Validation(Required=false)]
        public int? WSPort { get; set; }

    }

}
