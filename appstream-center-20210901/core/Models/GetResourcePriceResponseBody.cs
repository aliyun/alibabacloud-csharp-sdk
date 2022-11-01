// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourcePriceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PriceModel")]
        [Validation(Required=false)]
        public GetResourcePriceResponseBodyPriceModel PriceModel { get; set; }
        public class GetResourcePriceResponseBodyPriceModel : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public GetResourcePriceResponseBodyPriceModelPrice Price { get; set; }
            public class GetResourcePriceResponseBodyPriceModelPrice : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public string DiscountPrice { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public string OriginalPrice { get; set; }

                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<GetResourcePriceResponseBodyPriceModelPricePromotions> Promotions { get; set; }
                public class GetResourcePriceResponseBodyPriceModelPricePromotions : TeaModel {
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public string TradePrice { get; set; }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetResourcePriceResponseBodyPriceModelRules> Rules { get; set; }
            public class GetResourcePriceResponseBodyPriceModelRules : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
