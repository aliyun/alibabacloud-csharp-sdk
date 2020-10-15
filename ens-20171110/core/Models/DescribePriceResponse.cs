// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePriceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PriceInfo")]
        [Validation(Required=true)]
        public DescribePriceResponsePriceInfo PriceInfo { get; set; }
        public class DescribePriceResponsePriceInfo : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=true)]
            public DescribePriceResponsePriceInfoPrice Price { get; set; }
            public class DescribePriceResponsePriceInfoPrice : TeaModel {
                [NameInMap("DiscountPrice")]
                [Validation(Required=true)]
                public float? DiscountPrice { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=true)]
                public float? OriginalPrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=true)]
                public float? TradePrice { get; set; }

                [NameInMap("Currency")]
                [Validation(Required=true)]
                public string Currency { get; set; }

            }
        };

    }

}
