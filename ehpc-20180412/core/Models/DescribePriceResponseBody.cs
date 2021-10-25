// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribePriceResponseBody : TeaModel {
        [NameInMap("TotalTradePrice")]
        [Validation(Required=false)]
        public float? TotalTradePrice { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Prices")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPrices Prices { get; set; }
        public class DescribePriceResponseBodyPrices : TeaModel {
            [NameInMap("PriceInfo")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyPricesPriceInfo> PriceInfo { get; set; }
            public class DescribePriceResponseBodyPricesPriceInfo : TeaModel {
                public float? OriginalPrice { get; set; }
                public string NodeType { get; set; }
                public string Currency { get; set; }
                public float? TradePrice { get; set; }
            }
        };

    }

}
