// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class SearchAssetsShrinkRequest : TeaModel {
        [NameInMap("assetIndustrys")]
        [Validation(Required=false)]
        public string AssetIndustrysShrink { get; set; }

        [NameInMap("assetName")]
        [Validation(Required=false)]
        public string AssetName { get; set; }

        [NameInMap("assetTypes")]
        [Validation(Required=false)]
        public string AssetTypesShrink { get; set; }

        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
