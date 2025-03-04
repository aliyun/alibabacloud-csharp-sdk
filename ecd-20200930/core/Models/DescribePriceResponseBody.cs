// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price information.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>Indicates whether a free enterprise drive is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FreeCdsQuota")]
            [Validation(Required=false)]
            public bool? FreeCdsQuota { get; set; }

            /// <summary>
            /// <para>The free capacity provided by the enterprise drive. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FreeCdsSize")]
            [Validation(Required=false)]
            public long? FreeCdsSize { get; set; }

            /// <summary>
            /// <para>The price.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribePriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// <para>The unit of currency (USD).</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The discounted amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// <para>The orders.</para>
                /// </summary>
                [NameInMap("OrderLines")]
                [Validation(Required=false)]
                public Dictionary<string, string> OrderLines { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.796</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The promotions.</para>
                /// </summary>
                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoPricePromotions> Promotions { get; set; }
                public class DescribePriceResponseBodyPriceInfoPricePromotions : TeaModel {
                    /// <summary>
                    /// <para>The description of the promotion rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    /// <summary>
                    /// <para>The description of the promotion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Get started with new services with a discount.</para>
                    /// </summary>
                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// <para>The promotion ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    /// <summary>
                    /// <para>The promotion name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Special Offer</para>
                    /// </summary>
                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether an item is selected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

                /// <summary>
                /// <para>The price under an effective savings plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50.00</para>
                /// </summary>
                [NameInMap("SpPrice")]
                [Validation(Required=false)]
                public long? SpPrice { get; set; }

                /// <summary>
                /// <para>The actual price. The original price minus the discounted amount equals the actual price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.796</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// <para>The details of the promotion rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class DescribePriceResponseBodyPriceInfoRules : TeaModel {
                /// <summary>
                /// <para>The description of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Receive a 15% discount on a one-year subscription.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>587</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B1175630-3C44-4389-A3C1-15639FFC8EBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
