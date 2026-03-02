// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class CreateAssetWatchCmd : TeaModel {
        [NameInMap("assetId")]
        [Validation(Required=false)]
        public long? AssetId { get; set; }

        [NameInMap("assetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

    }

}
