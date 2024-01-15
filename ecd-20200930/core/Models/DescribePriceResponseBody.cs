// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// The price details.
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("FreeCdsQuota")]
            [Validation(Required=false)]
            public bool? FreeCdsQuota { get; set; }

            [NameInMap("FreeCdsSize")]
            [Validation(Required=false)]
            public long? FreeCdsSize { get; set; }

            /// <summary>
            /// The information about the price.
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribePriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// The unit of the currency.
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// The discounted price.
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                [NameInMap("OrderLines")]
                [Validation(Required=false)]
                public Dictionary<string, string> OrderLines { get; set; }

                /// <summary>
                /// The original price.
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// The details of the promotion.
                /// </summary>
                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoPricePromotions> Promotions { get; set; }
                public class DescribePriceResponseBodyPriceInfoPricePromotions : TeaModel {
                    /// <summary>
                    /// The description of the promotion rule.
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    /// <summary>
                    /// The description of the promotion.
                    /// </summary>
                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// The promotion ID.
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    /// <summary>
                    /// The promotion name.
                    /// </summary>
                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// Indicates whether an item is selected.
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

                [NameInMap("SpPrice")]
                [Validation(Required=false)]
                public long? SpPrice { get; set; }

                /// <summary>
                /// The actual price that is paid. The original price minus the discounted part equals the actual price.
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// The details of the promotion rules.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class DescribePriceResponseBodyPriceInfoRules : TeaModel {
                /// <summary>
                /// The description of the rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The rule ID.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
