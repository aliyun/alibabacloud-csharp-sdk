// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeBandwidthPriceResponseBody : TeaModel {
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeBandwidthPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeBandwidthPriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Order")]
            [Validation(Required=false)]
            public DescribeBandwidthPriceResponseBodyPriceInfoOrder Order { get; set; }
            public class DescribeBandwidthPriceResponseBodyPriceInfoOrder : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                [NameInMap("RuleIdSet")]
                [Validation(Required=false)]
                public DescribeBandwidthPriceResponseBodyPriceInfoOrderRuleIdSet RuleIdSet { get; set; }
                public class DescribeBandwidthPriceResponseBodyPriceInfoOrderRuleIdSet : TeaModel {
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public List<string> RuleId { get; set; }

                }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public DescribeBandwidthPriceResponseBodyPriceInfoRules Rules { get; set; }
            public class DescribeBandwidthPriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<DescribeBandwidthPriceResponseBodyPriceInfoRulesRule> Rule { get; set; }
                public class DescribeBandwidthPriceResponseBodyPriceInfoRulesRule : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
