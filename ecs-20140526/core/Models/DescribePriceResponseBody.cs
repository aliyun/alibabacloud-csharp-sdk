// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePriceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribePriceResponseBodyPriceInfoPrice : TeaModel {
                [NameInMap("ReservedInstanceHourPrice")]
                [Validation(Required=false)]
                public float? ReservedInstanceHourPrice { get; set; }

                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                [NameInMap("DetailInfos")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoPriceDetailInfos> DetailInfos { get; set; }
                public class DescribePriceResponseBodyPriceInfoPriceDetailInfos : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public string Resource { get; set; }

                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public float? DiscountPrice { get; set; }

                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public float? TradePrice { get; set; }

                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public float? OriginalPrice { get; set; }

                    [NameInMap("SubRules")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodyPriceInfoPriceDetailInfosSubRules> SubRules { get; set; }
                    public class DescribePriceResponseBodyPriceInfoPriceDetailInfosSubRules : TeaModel {
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public long? RuleId { get; set; }

                    }

                }

                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

            }
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class DescribePriceResponseBodyPriceInfoRules : TeaModel {
                public string Description { get; set; }
                public long? RuleId { get; set; }
            }
        };

    }

}
