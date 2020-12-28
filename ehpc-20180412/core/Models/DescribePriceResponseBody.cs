// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribePriceResponseBody : TeaModel {
        [NameInMap("Prices")]
        [Validation(Required=false)]
        public List<DescribePriceResponseBodyPrices> Prices { get; set; }
        public class DescribePriceResponseBodyPrices : TeaModel {
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

        }

        [NameInMap("TotalTradePrice")]
        [Validation(Required=false)]
        public float? TotalTradePrice { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
