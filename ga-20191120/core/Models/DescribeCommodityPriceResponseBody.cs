// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCommodityPriceResponseBody : TeaModel {
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("DiscountPrice")]
        [Validation(Required=false)]
        public double? DiscountPrice { get; set; }

        [NameInMap("OrderDetails")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceResponseBodyOrderDetails> OrderDetails { get; set; }
        public class DescribeCommodityPriceResponseBodyOrderDetails : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public double? DiscountPrice { get; set; }

            [NameInMap("ModuleDetails")]
            [Validation(Required=false)]
            public List<DescribeCommodityPriceResponseBodyOrderDetailsModuleDetails> ModuleDetails { get; set; }
            public class DescribeCommodityPriceResponseBodyOrderDetailsModuleDetails : TeaModel {
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public double? DiscountPrice { get; set; }

                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public double? OriginalPrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public double? TradePrice { get; set; }

            }

            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public double? OriginalPrice { get; set; }

            [NameInMap("PromDetails")]
            [Validation(Required=false)]
            public List<DescribeCommodityPriceResponseBodyOrderDetailsPromDetails> PromDetails { get; set; }
            public class DescribeCommodityPriceResponseBodyOrderDetailsPromDetails : TeaModel {
                [NameInMap("FinalPromFee")]
                [Validation(Required=false)]
                public double? FinalPromFee { get; set; }

                [NameInMap("OptionCode")]
                [Validation(Required=false)]
                public string OptionCode { get; set; }

                [NameInMap("PromType")]
                [Validation(Required=false)]
                public string PromType { get; set; }

                [NameInMap("PromotionId")]
                [Validation(Required=false)]
                public string PromotionId { get; set; }

                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

            }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public List<long?> RuleIds { get; set; }

            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public double? TradePrice { get; set; }

        }

        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public double? OriginalPrice { get; set; }

        [NameInMap("Promotions")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceResponseBodyPromotions> Promotions { get; set; }
        public class DescribeCommodityPriceResponseBodyPromotions : TeaModel {
            [NameInMap("CanPromFee")]
            [Validation(Required=false)]
            public double? CanPromFee { get; set; }

            [NameInMap("OptionCode")]
            [Validation(Required=false)]
            public string OptionCode { get; set; }

            [NameInMap("PromotionName")]
            [Validation(Required=false)]
            public string PromotionName { get; set; }

            [NameInMap("PromotionOptionNo")]
            [Validation(Required=false)]
            public string PromotionOptionNo { get; set; }

            [NameInMap("Selected")]
            [Validation(Required=false)]
            public bool? Selected { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleDetails")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceResponseBodyRuleDetails> RuleDetails { get; set; }
        public class DescribeCommodityPriceResponseBodyRuleDetails : TeaModel {
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public double? TradePrice { get; set; }

    }

}
