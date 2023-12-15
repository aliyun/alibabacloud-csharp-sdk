// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateAntChainRequest : TeaModel {
        [NameInMap("AntChainName")]
        [Validation(Required=false)]
        public string AntChainName { get; set; }

        [NameInMap("BlockchainRegionId")]
        [Validation(Required=false)]
        public string BlockchainRegionId { get; set; }

        [NameInMap("CipherSuit")]
        [Validation(Required=false)]
        public string CipherSuit { get; set; }

        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        [NameInMap("LiveTime")]
        [Validation(Required=false)]
        public int? LiveTime { get; set; }

        [NameInMap("MerkleTreeSuit")]
        [Validation(Required=false)]
        public string MerkleTreeSuit { get; set; }

        [NameInMap("NodeNum")]
        [Validation(Required=false)]
        public int? NodeNum { get; set; }

        [NameInMap("ResourceSize")]
        [Validation(Required=false)]
        public int? ResourceSize { get; set; }

        [NameInMap("TlsAlgo")]
        [Validation(Required=false)]
        public string TlsAlgo { get; set; }

    }

}
