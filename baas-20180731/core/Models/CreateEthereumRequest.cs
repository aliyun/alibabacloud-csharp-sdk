// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateEthereumRequest : TeaModel {
        [NameInMap("Consensus")]
        [Validation(Required=false)]
        public string Consensus { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Difficulty")]
        [Validation(Required=false)]
        public string Difficulty { get; set; }

        [NameInMap("Gas")]
        [Validation(Required=false)]
        public string Gas { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        [NameInMap("Node")]
        [Validation(Required=false)]
        public List<CreateEthereumRequestNode> Node { get; set; }
        public class CreateEthereumRequestNode : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
