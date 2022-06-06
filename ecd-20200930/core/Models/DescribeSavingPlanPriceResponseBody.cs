// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSavingPlanPriceResponseBody : TeaModel {
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeSavingPlanPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeSavingPlanPriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeSavingPlanPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeSavingPlanPriceResponseBodyPriceInfoPrice : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<DescribeSavingPlanPriceResponseBodyPriceInfoPricePromotions> Promotions { get; set; }
                public class DescribeSavingPlanPriceResponseBodyPriceInfoPricePromotions : TeaModel {
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

                [NameInMap("TotalCostPrice")]
                [Validation(Required=false)]
                public float? TotalCostPrice { get; set; }

                [NameInMap("TradeCyclePrice")]
                [Validation(Required=false)]
                public float? TradeCyclePrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeSavingPlanPriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class DescribeSavingPlanPriceResponseBodyPriceInfoRules : TeaModel {
                public string Description { get; set; }
                public long? RuleId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
