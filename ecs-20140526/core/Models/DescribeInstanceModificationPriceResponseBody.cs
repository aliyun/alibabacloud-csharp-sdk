// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceModificationPriceResponseBody : TeaModel {
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeInstanceModificationPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeInstanceModificationPriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeInstanceModificationPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeInstanceModificationPriceResponseBodyPriceInfoPrice : TeaModel {
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

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public DescribeInstanceModificationPriceResponseBodyPriceInfoRules Rules { get; set; }
            public class DescribeInstanceModificationPriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<DescribeInstanceModificationPriceResponseBodyPriceInfoRulesRule> Rule { get; set; }
                public class DescribeInstanceModificationPriceResponseBodyPriceInfoRulesRule : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
