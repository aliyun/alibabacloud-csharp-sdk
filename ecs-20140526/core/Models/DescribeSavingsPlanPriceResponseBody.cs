// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSavingsPlanPriceResponseBody : TeaModel {
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeSavingsPlanPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeSavingsPlanPriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeSavingsPlanPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeSavingsPlanPriceResponseBodyPriceInfoPrice : TeaModel {
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
            public List<DescribeSavingsPlanPriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class DescribeSavingsPlanPriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
