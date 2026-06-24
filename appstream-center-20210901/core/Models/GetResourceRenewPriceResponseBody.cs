// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourceRenewPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResourceRenewPriceResponseBodyData Data { get; set; }
        public class GetResourceRenewPriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The price details.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public GetResourceRenewPriceResponseBodyDataPrice Price { get; set; }
            public class GetResourceRenewPriceResponseBodyDataPrice : TeaModel {
                /// <summary>
                /// <para>The currency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The discount amount. The actual price is calculated by subtracting the discount amount from the original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public string DiscountPrice { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public string OriginalPrice { get; set; }

                /// <summary>
                /// <para>The coupon descriptions.</para>
                /// </summary>
                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<GetResourceRenewPriceResponseBodyDataPricePromotions> Promotions { get; set; }
                public class GetResourceRenewPriceResponseBodyDataPricePromotions : TeaModel {
                    /// <summary>
                    /// <para>The coupon code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>coupon****</para>
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    /// <summary>
                    /// <para>The coupon descriptions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>**活动</para>
                    /// </summary>
                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// <para>The coupon ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>139965*****</para>
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    /// <summary>
                    /// <para>The coupon name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>**活动</para>
                    /// </summary>
                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the coupon is selected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

                /// <summary>
                /// <para>The actual price. The actual price is calculated by subtracting the discount amount from the original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public string TradePrice { get; set; }

            }

            /// <summary>
            /// <para>The pricing rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetResourceRenewPriceResponseBodyDataRules> Rules { get; set; }
            public class GetResourceRenewPriceResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The pricing rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>**活动</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The pricing rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20002****</para>
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
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
