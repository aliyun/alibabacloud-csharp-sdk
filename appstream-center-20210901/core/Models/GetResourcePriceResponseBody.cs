// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourcePriceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParameter.ProductType</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The parameter ProductType is invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PriceList")]
        [Validation(Required=false)]
        public List<GetResourcePriceResponseBodyPriceList> PriceList { get; set; }
        public class GetResourcePriceResponseBodyPriceList : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public GetResourcePriceResponseBodyPriceListPrice Price { get; set; }
            public class GetResourcePriceResponseBodyPriceListPrice : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>999.0</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public string DiscountPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6700</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public string OriginalPrice { get; set; }

                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<GetResourcePriceResponseBodyPriceListPricePromotions> Promotions { get; set; }
                public class GetResourcePriceResponseBodyPriceListPricePromotions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>coupon****</para>
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1847709****</para>
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5278.0</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public string TradePrice { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Standby</para>
            /// </summary>
            [NameInMap("PriceType")]
            [Validation(Required=false)]
            public string PriceType { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetResourcePriceResponseBodyPriceListRules> Rules { get; set; }
            public class GetResourcePriceResponseBodyPriceListRules : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>260904273633****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        [NameInMap("PriceModel")]
        [Validation(Required=false)]
        public GetResourcePriceResponseBodyPriceModel PriceModel { get; set; }
        public class GetResourcePriceResponseBodyPriceModel : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public GetResourcePriceResponseBodyPriceModelPrice Price { get; set; }
            public class GetResourcePriceResponseBodyPriceModelPrice : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.00</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public string DiscountPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11.00</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public string OriginalPrice { get; set; }

                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<GetResourcePriceResponseBodyPriceModelPricePromotions> Promotions { get; set; }
                public class GetResourcePriceResponseBodyPriceModelPricePromotions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>coupon****</para>
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>17440009****</para>
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.00</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public string TradePrice { get; set; }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetResourcePriceResponseBodyPriceModelRules> Rules { get; set; }
            public class GetResourcePriceResponseBodyPriceModelRules : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>102002100393****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
