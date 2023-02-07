// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySkuPriceListShrinkRequest : TeaModel {
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PriceEntityCode")]
        [Validation(Required=false)]
        public string PriceEntityCode { get; set; }

        [NameInMap("PriceFactorConditionMap")]
        [Validation(Required=false)]
        public string PriceFactorConditionMapShrink { get; set; }

    }

}
