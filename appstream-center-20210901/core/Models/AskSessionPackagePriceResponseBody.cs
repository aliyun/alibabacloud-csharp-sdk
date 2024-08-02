// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AskSessionPackagePriceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AskSessionPackagePriceResponseBodyData> Data { get; set; }
        public class AskSessionPackagePriceResponseBodyData : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public AskSessionPackagePriceResponseBodyDataPrice Price { get; set; }
            public class AskSessionPackagePriceResponseBodyDataPrice : TeaModel {
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

    }

}
