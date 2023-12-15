// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateBlockchainApplicationRequest : TeaModel {
        [NameInMap("Bizid")]
        [Validation(Required=false)]
        public string Bizid { get; set; }

        [NameInMap("BlockchainRegionId")]
        [Validation(Required=false)]
        public string BlockchainRegionId { get; set; }

        [NameInMap("BlockchainType")]
        [Validation(Required=false)]
        public string BlockchainType { get; set; }

        [NameInMap("CipherSuit")]
        [Validation(Required=false)]
        public string CipherSuit { get; set; }

        [NameInMap("LiveTime")]
        [Validation(Required=false)]
        public int? LiveTime { get; set; }

        [NameInMap("MachineNum")]
        [Validation(Required=false)]
        public int? MachineNum { get; set; }

        [NameInMap("MerkleTreeSuit")]
        [Validation(Required=false)]
        public string MerkleTreeSuit { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("TlsAlgo")]
        [Validation(Required=false)]
        public string TlsAlgo { get; set; }

    }

}
