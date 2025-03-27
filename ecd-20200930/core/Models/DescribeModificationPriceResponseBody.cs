// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeModificationPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price details.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeModificationPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeModificationPriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>The price information.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeModificationPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeModificationPriceResponseBodyPriceInfoPrice : TeaModel {
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
                /// <para>15.8</para>
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
                /// <para>79.0</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The promotion activities.</para>
                /// </summary>
                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<DescribeModificationPriceResponseBodyPriceInfoPricePromotions> Promotions { get; set; }
                public class DescribeModificationPriceResponseBodyPriceInfoPricePromotions : TeaModel {
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
                    /// <para>The promotion description.</para>
                    /// </summary>
                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// <para>The ID of the promotion activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>promo_option</para>
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    /// <summary>
                    /// <para>The name of the promotion activity.</para>
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
                /// <para>The actual price. The actual price is the original price minus the discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>63.2</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// <para>The promotion rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeModificationPriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class DescribeModificationPriceResponseBodyPriceInfoRules : TeaModel {
                /// <summary>
                /// <para>The rule description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14806</para>
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
        /// <para>48174475-5EB2-5F99-A9E9-6F892D645****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
