// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdp20210402.Models
{
    public class QueryScaleUpPriceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryScaleUpPriceResponseBodyData Data { get; set; }
        public class QueryScaleUpPriceResponseBodyData : TeaModel {
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            [NameInMap("EcsPriceInfo")]
            [Validation(Required=false)]
            public QueryScaleUpPriceResponseBodyDataEcsPriceInfo EcsPriceInfo { get; set; }
            public class QueryScaleUpPriceResponseBodyDataEcsPriceInfo : TeaModel {
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

            [NameInMap("SoftPriceInfo")]
            [Validation(Required=false)]
            public QueryScaleUpPriceResponseBodyDataSoftPriceInfo SoftPriceInfo { get; set; }
            public class QueryScaleUpPriceResponseBodyDataSoftPriceInfo : TeaModel {
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

            [NameInMap("SumPrice")]
            [Validation(Required=false)]
            public float? SumPrice { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
