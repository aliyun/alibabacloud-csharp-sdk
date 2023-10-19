// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class QueryOrderPriceResponseBody : TeaModel {
        [NameInMap("discount_price")]
        [Validation(Required=false)]
        public double? DiscountPrice { get; set; }

        [NameInMap("original_price")]
        [Validation(Required=false)]
        public double? OriginalPrice { get; set; }

        [NameInMap("trade_price")]
        [Validation(Required=false)]
        public double? TradePrice { get; set; }

    }

}
