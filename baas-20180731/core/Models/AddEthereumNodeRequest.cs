// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class AddEthereumNodeRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EthereumId")]
        [Validation(Required=false)]
        public string EthereumId { get; set; }

        [NameInMap("ExternalNode")]
        [Validation(Required=false)]
        public bool? ExternalNode { get; set; }

        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

    }

}
