// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePriceResponseBody : TeaModel {
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribePriceResponseBodyPriceInfoPrice : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
