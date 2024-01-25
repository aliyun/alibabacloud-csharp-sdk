// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdp20210402.Models
{
    public class QueryPriceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPriceResponseBodyData Data { get; set; }
        public class QueryPriceResponseBodyData : TeaModel {
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public double? DiscountPrice { get; set; }

            [NameInMap("EcsPriceInfo")]
            [Validation(Required=false)]
            public QueryPriceResponseBodyDataEcsPriceInfo EcsPriceInfo { get; set; }
            public class QueryPriceResponseBodyDataEcsPriceInfo : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public double? DiscountPrice { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public double? OriginalPrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public double? TradePrice { get; set; }

            }

            [NameInMap("SoftPriceInfo")]
            [Validation(Required=false)]
            public QueryPriceResponseBodyDataSoftPriceInfo SoftPriceInfo { get; set; }
            public class QueryPriceResponseBodyDataSoftPriceInfo : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public double? DiscountPrice { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public double? OriginalPrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public double? TradePrice { get; set; }

            }

            [NameInMap("SumPrice")]
            [Validation(Required=false)]
            public double? SumPrice { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
