// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price details.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>Indicates whether a free enterprise cloud disk is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FreeCdsQuota")]
            [Validation(Required=false)]
            public bool? FreeCdsQuota { get; set; }

            /// <summary>
            /// <para>The free capacity of the enterprise cloud disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FreeCdsSize")]
            [Validation(Required=false)]
            public long? FreeCdsSize { get; set; }

            /// <summary>
            /// <para>The price information.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribePriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// <para>&lt;props=&quot;china&quot;&gt;The currency unit (CNY).
                /// &lt;props=&quot;intl&quot;&gt;The currency unit (USD).</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY/USD</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15.8</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// <para>The order information.</para>
                /// </summary>
                [NameInMap("OrderLines")]
                [Validation(Required=false)]
                public Dictionary<string, string> OrderLines { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>79.0</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The promotion information.</para>
                /// </summary>
                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoPricePromotions> Promotions { get; set; }
                public class DescribePriceResponseBodyPriceInfoPricePromotions : TeaModel {
                    /// <summary>
                    /// <para>The promotion rule description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    /// <summary>
                    /// <para>The promotion description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>New product launch with special discount</para>
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
                    /// <para>Featured deals</para>
                    /// </summary>
                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the promotion is selected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

                /// <summary>
                /// <para>The price under the savings plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50.00</para>
                /// </summary>
                [NameInMap("SpPrice")]
                [Validation(Required=false)]
                public long? SpPrice { get; set; }

                /// <summary>
                /// <para>The actual payment price. The value is the original price minus the discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>63.2</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// <para>The promotion rule information.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class DescribePriceResponseBodyPriceInfoRules : TeaModel {
                /// <summary>
                /// <para>The rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Get 15% off the list price when you purchase for one year or longer</para>
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
