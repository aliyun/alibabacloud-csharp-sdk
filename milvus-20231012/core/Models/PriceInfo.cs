// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class PriceInfo : TeaModel {
        [NameInMap("currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("discountAmount")]
        [Validation(Required=false)]
        public string DiscountAmount { get; set; }

        [NameInMap("optionalPromotions")]
        [Validation(Required=false)]
        public List<PromotionInfo> OptionalPromotions { get; set; }

        [NameInMap("originalAmount")]
        [Validation(Required=false)]
        public string OriginalAmount { get; set; }

        [NameInMap("priceModules")]
        [Validation(Required=false)]
        public List<PriceInfoPriceModules> PriceModules { get; set; }
        public class PriceInfoPriceModules : TeaModel {
            [NameInMap("originalAmount")]
            [Validation(Required=false)]
            public string OriginalAmount { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<PriceInfoRules> Rules { get; set; }
        public class PriceInfoRules : TeaModel {
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

        [NameInMap("taxAmount")]
        [Validation(Required=false)]
        public string TaxAmount { get; set; }

        [NameInMap("tradeAmount")]
        [Validation(Required=false)]
        public string TradeAmount { get; set; }

    }

}
