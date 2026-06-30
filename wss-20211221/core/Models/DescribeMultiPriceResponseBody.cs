// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeMultiPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed price information.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeMultiPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeMultiPriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>The price information.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeMultiPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeMultiPriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// <para>The currency.</para>
                /// <para>China site: CNY.</para>
                /// <para>International site: USD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>534.6</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6800</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <para>A list of price details.</para>
                /// </summary>
                [NameInMap("PriceDetails")]
                [Validation(Required=false)]
                public List<DescribeMultiPriceResponseBodyPriceInfoPricePriceDetails> PriceDetails { get; set; }
                public class DescribeMultiPriceResponseBodyPriceInfoPricePriceDetails : TeaModel {
                    /// <summary>
                    /// <para>A list of pricing module details.</para>
                    /// </summary>
                    [NameInMap("ModuleDetails")]
                    [Validation(Required=false)]
                    public List<DescribeMultiPriceResponseBodyPriceInfoPricePriceDetailsModuleDetails> ModuleDetails { get; set; }
                    public class DescribeMultiPriceResponseBodyPriceInfoPricePriceDetailsModuleDetails : TeaModel {
                        /// <summary>
                        /// <para>The discount amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>734.65</para>
                        /// </summary>
                        [NameInMap("DiscountPrice")]
                        [Validation(Required=false)]
                        public float? DiscountPrice { get; set; }

                        /// <summary>
                        /// <para>The module code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DesktopType</para>
                        /// </summary>
                        [NameInMap("ModuleCode")]
                        [Validation(Required=false)]
                        public string ModuleCode { get; set; }

                        /// <summary>
                        /// <para>The module name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>企业办公型-8C32G</para>
                        /// </summary>
                        [NameInMap("ModuleName")]
                        [Validation(Required=false)]
                        public string ModuleName { get; set; }

                        /// <summary>
                        /// <para>The module value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eds.enterprise_office.8c32g</para>
                        /// </summary>
                        [NameInMap("ModuleValue")]
                        [Validation(Required=false)]
                        public string ModuleValue { get; set; }

                        /// <summary>
                        /// <para>The original price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10900</para>
                        /// </summary>
                        [NameInMap("OriginalPrice")]
                        [Validation(Required=false)]
                        public float? OriginalPrice { get; set; }

                        [NameInMap("SavingPlanDiscountPrice")]
                        [Validation(Required=false)]
                        public float? SavingPlanDiscountPrice { get; set; }

                        /// <summary>
                        /// <para>The trade price, which is the original price minus the discount amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>292.2</para>
                        /// </summary>
                        [NameInMap("TradePrice")]
                        [Validation(Required=false)]
                        public float? TradePrice { get; set; }

                    }

                    /// <summary>
                    /// <para>The sort order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OrderItem")]
                    [Validation(Required=false)]
                    public int? OrderItem { get; set; }

                    /// <summary>
                    /// <para>A breakdown of the price.</para>
                    /// </summary>
                    [NameInMap("PriceDetail")]
                    [Validation(Required=false)]
                    public DescribeMultiPriceResponseBodyPriceInfoPricePriceDetailsPriceDetail PriceDetail { get; set; }
                    public class DescribeMultiPriceResponseBodyPriceInfoPricePriceDetailsPriceDetail : TeaModel {
                        /// <summary>
                        /// <para>The discount amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20.00</para>
                        /// </summary>
                        [NameInMap("DiscountPrice")]
                        [Validation(Required=false)]
                        public float? DiscountPrice { get; set; }

                        /// <summary>
                        /// <para>The original price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100.00</para>
                        /// </summary>
                        [NameInMap("OriginalPrice")]
                        [Validation(Required=false)]
                        public float? OriginalPrice { get; set; }

                        /// <summary>
                        /// <para>The resource type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DurationPackage</para>
                        /// </summary>
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                        [NameInMap("SavingPlanRecommendPrice")]
                        [Validation(Required=false)]
                        public float? SavingPlanRecommendPrice { get; set; }

                        /// <summary>
                        /// <para>The trade price, which is the original price minus the discount amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80.00</para>
                        /// </summary>
                        [NameInMap("TradePrice")]
                        [Validation(Required=false)]
                        public float? TradePrice { get; set; }

                    }

                }

                /// <summary>
                /// <para>A list of promotions.</para>
                /// </summary>
                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<DescribeMultiPriceResponseBodyPriceInfoPricePromotions> Promotions { get; set; }
                public class DescribeMultiPriceResponseBodyPriceInfoPricePromotions : TeaModel {
                    /// <summary>
                    /// <para>The option code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>new</para>
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    /// <summary>
                    /// <para>The promotion description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>促销</para>
                    /// </summary>
                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// <para>The promotion ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>youhuiquan_promotion_option_id_for_blank</para>
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    /// <summary>
                    /// <para>The promotion name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>优惠活动名称</para>
                    /// </summary>
                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the promotion is selected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

                /// <summary>
                /// <para>A map of instance IDs to their corresponding refund amounts.</para>
                /// </summary>
                [NameInMap("RefundInstanceIdPriceMap")]
                [Validation(Required=false)]
                public Dictionary<string, float?> RefundInstanceIdPriceMap { get; set; }

                /// <summary>
                /// <para>The refund amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60.00</para>
                /// </summary>
                [NameInMap("RefundPrice")]
                [Validation(Required=false)]
                public float? RefundPrice { get; set; }

                /// <summary>
                /// <para>The trade price, which is the original price minus the discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>82.6</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// <para>A list of promotion rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeMultiPriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class DescribeMultiPriceResponseBodyPriceInfoRules : TeaModel {
                /// <summary>
                /// <para>The promotion rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>accounts_suspect_users</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The promotion rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hrzdvc</para>
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
        /// <para>833C4D2C-09C7-5CE6-8159-06758B964970</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
