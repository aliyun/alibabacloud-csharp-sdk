// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeModificationPriceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeModificationPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeModificationPriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeModificationPriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class DescribeModificationPriceResponseBodyPriceInfoRules : TeaModel {
                public string Description { get; set; }
                public long? RuleId { get; set; }
            }
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeModificationPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeModificationPriceResponseBodyPriceInfoPrice : TeaModel {
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<DescribeModificationPriceResponseBodyPriceInfoPricePromotions> Promotions { get; set; }
                public class DescribeModificationPriceResponseBodyPriceInfoPricePromotions : TeaModel {
                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                }

            }
        };

    }

}
