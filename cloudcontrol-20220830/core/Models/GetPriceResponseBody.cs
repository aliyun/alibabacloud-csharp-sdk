// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetPriceResponseBody : TeaModel {
        [NameInMap("price")]
        [Validation(Required=false)]
        public GetPriceResponseBodyPrice Price { get; set; }
        public class GetPriceResponseBodyPrice : TeaModel {
            [NameInMap("currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("discountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            [NameInMap("moduleDetails")]
            [Validation(Required=false)]
            public List<GetPriceResponseBodyPriceModuleDetails> ModuleDetails { get; set; }
            public class GetPriceResponseBodyPriceModuleDetails : TeaModel {
                [NameInMap("costAfterDiscount")]
                [Validation(Required=false)]
                public float? CostAfterDiscount { get; set; }

                [NameInMap("invoiceDiscount")]
                [Validation(Required=false)]
                public float? InvoiceDiscount { get; set; }

                [NameInMap("moduleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                [NameInMap("moduleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                [NameInMap("originalCost")]
                [Validation(Required=false)]
                public float? OriginalCost { get; set; }

                [NameInMap("priceType")]
                [Validation(Required=false)]
                public float? PriceType { get; set; }

            }

            [NameInMap("originalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            [NameInMap("promotionDetails")]
            [Validation(Required=false)]
            public List<GetPriceResponseBodyPricePromotionDetails> PromotionDetails { get; set; }
            public class GetPriceResponseBodyPricePromotionDetails : TeaModel {
                [NameInMap("promotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                [NameInMap("promotionId")]
                [Validation(Required=false)]
                public long? PromotionId { get; set; }

                [NameInMap("promotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

            }

            [NameInMap("tradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
