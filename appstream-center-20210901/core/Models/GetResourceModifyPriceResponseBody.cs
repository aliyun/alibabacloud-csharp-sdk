// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourceModifyPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The quote for the resource scale-out of the delivery group, which includes the pricing details and pricing calculation rules.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResourceModifyPriceResponseBodyData Data { get; set; }
        public class GetResourceModifyPriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pricing details of the scale-out. For the currency of the amounts, see Currency. For the coupon selection status, see Promotions.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public GetResourceModifyPriceResponseBodyDataPrice Price { get; set; }
            public class GetResourceModifyPriceResponseBodyDataPrice : TeaModel {
                /// <summary>
                /// <para>The currency code of the price amount. CNY indicates Chinese Yuan. Refer to this field to understand the amounts of OriginalPrice, DiscountPrice, and TradePrice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The discount amount that can be deducted from the scale-out price, not the discount percentage.</para>
                /// <para>The discounted price TradePrice is obtained by subtracting this field from the original price OriginalPrice. For the currency of the amount, see Currency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.00</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public double? DiscountPrice { get; set; }

                /// <summary>
                /// <para>The original price of the scale-out, which is the amount before discounts. For the currency of the amount, see Currency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11.00</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public double? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The list of optional coupons returned in the quote. Each item includes the coupon ID, name, description, and selection status.</para>
                /// </summary>
                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<GetResourceModifyPriceResponseBodyDataPricePromotions> Promotions { get; set; }
                public class GetResourceModifyPriceResponseBodyDataPricePromotions : TeaModel {
                    /// <summary>
                    /// <para>The option code of the coupon, which identifies the coupon returned in the quote together with PromotionId.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>coupon****</para>
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    /// <summary>
                    /// <para>The description of the coupon, which is used to display the information about the discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>**Discount during the promotion</para>
                    /// </summary>
                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// <para>The ID of the coupon, which is used to identify the coupon returned in the quote.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17440009****</para>
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    /// <summary>
                    /// <para>The name of the coupon, which is used to display the optional discount in the current quote.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>**Discount</para>
                    /// </summary>
                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the coupon is selected in the quote. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Selected. The coupon is applied in the quote.</description></item>
                    /// <item><description>false: Not selected. The coupon is not applied in the quote.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

                /// <summary>
                /// <para>The discounted price of the scale-out.</para>
                /// <para>Calculation relationship: TradePrice = OriginalPrice - DiscountPrice. For the currency of the amount, see Currency. This operation returns only a quote and does not execute payment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.00</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public double? TradePrice { get; set; }

            }

            /// <summary>
            /// <para>The list of pricing calculation rules for the quote, which is used to describe the applicable pricing or discount rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetResourceModifyPriceResponseBodyDataRules> Rules { get; set; }
            public class GetResourceModifyPriceResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The description of the pricing calculation rule, such as the user discount applicable to the current quote.</para>
                /// 
                /// <b>Example:</b>
                /// <para>User discount</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the pricing calculation rule, which is used to identify the rule applied in the quote.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102002100393****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique ID of the request, which is used to locate and troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
