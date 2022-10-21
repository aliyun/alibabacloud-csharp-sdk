// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class PriceInfo : TeaModel {
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("DiscountPrice")]
        [Validation(Required=false)]
        public string DiscountPrice { get; set; }

        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public string OriginalPrice { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("PromotionResults")]
        [Validation(Required=false)]
        public List<PromotionInfo> PromotionResults { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("SpotInstanceTypeOriginalPrice")]
        [Validation(Required=false)]
        public string SpotInstanceTypeOriginalPrice { get; set; }

        [NameInMap("SpotInstanceTypePrice")]
        [Validation(Required=false)]
        public string SpotInstanceTypePrice { get; set; }

        [NameInMap("SpotOriginalPrice")]
        [Validation(Required=false)]
        public string SpotOriginalPrice { get; set; }

        [NameInMap("SpotPrice")]
        [Validation(Required=false)]
        public string SpotPrice { get; set; }

        [NameInMap("TaxPrice")]
        [Validation(Required=false)]
        public string TaxPrice { get; set; }

        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public string TradePrice { get; set; }

    }

}
