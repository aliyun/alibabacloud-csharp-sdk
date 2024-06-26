// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateAntChainRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AntChainName")]
        [Validation(Required=false)]
        public string AntChainName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BlockchainRegionId")]
        [Validation(Required=false)]
        public string BlockchainRegionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CipherSuit")]
        [Validation(Required=false)]
        public string CipherSuit { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LiveTime")]
        [Validation(Required=false)]
        public int? LiveTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MerkleTreeSuit")]
        [Validation(Required=false)]
        public string MerkleTreeSuit { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeNum")]
        [Validation(Required=false)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceSize")]
        [Validation(Required=false)]
        public int? ResourceSize { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TlsAlgo")]
        [Validation(Required=false)]
        public string TlsAlgo { get; set; }

    }

}
