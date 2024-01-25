// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdp20210402.Models
{
    public class QueryRenewPriceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRenewPriceResponseBodyData Data { get; set; }
        public class QueryRenewPriceResponseBodyData : TeaModel {
            [NameInMap("CdpSoftPriceInfo")]
            [Validation(Required=false)]
            public QueryRenewPriceResponseBodyDataCdpSoftPriceInfo CdpSoftPriceInfo { get; set; }
            public class QueryRenewPriceResponseBodyDataCdpSoftPriceInfo : TeaModel {
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

            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            [NameInMap("EcsPriceInfo")]
            [Validation(Required=false)]
            public QueryRenewPriceResponseBodyDataEcsPriceInfo EcsPriceInfo { get; set; }
            public class QueryRenewPriceResponseBodyDataEcsPriceInfo : TeaModel {
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
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
