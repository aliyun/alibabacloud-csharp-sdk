// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTrademarkPriceResponseBody : TeaModel {
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("DiscountPrice")]
        [Validation(Required=false)]
        public float? DiscountPrice { get; set; }

        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        [NameInMap("Prices")]
        [Validation(Required=false)]
        public QueryTrademarkPriceResponseBodyPrices Prices { get; set; }
        public class QueryTrademarkPriceResponseBodyPrices : TeaModel {
            [NameInMap("Prices")]
            [Validation(Required=false)]
            public List<QueryTrademarkPriceResponseBodyPricesPrices> Prices { get; set; }
            public class QueryTrademarkPriceResponseBodyPricesPrices : TeaModel {
                [NameInMap("ClassificationCode")]
                [Validation(Required=false)]
                public string ClassificationCode { get; set; }

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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

    }

}
