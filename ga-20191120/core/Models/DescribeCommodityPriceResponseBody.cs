// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCommodityPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The currency unit.</para>
        /// <list type="bullet">
        /// <item><description>China site: <b>CNY</b>.</description></item>
        /// <item><description>International site: <b>USD</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>The discount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>419.8</para>
        /// </summary>
        [NameInMap("DiscountPrice")]
        [Validation(Required=false)]
        public double? DiscountPrice { get; set; }

        /// <summary>
        /// <para>The details of the commodity module.</para>
        /// </summary>
        [NameInMap("OrderDetails")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceResponseBodyOrderDetails> OrderDetails { get; set; }
        public class DescribeCommodityPriceResponseBodyOrderDetails : TeaModel {
            /// <summary>
            /// <para>The code of the commodity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga_gapluspre_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The name of the commodity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Global Accelerator_Instance Type (Subscription)</para>
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// <para>The discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>419.8</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public double? DiscountPrice { get; set; }

            /// <summary>
            /// <para>The information about the commodity module.</para>
            /// </summary>
            [NameInMap("ModuleDetails")]
            [Validation(Required=false)]
            public List<DescribeCommodityPriceResponseBodyOrderDetailsModuleDetails> ModuleDetails { get; set; }
            public class DescribeCommodityPriceResponseBodyOrderDetailsModuleDetails : TeaModel {
                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40000.0</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public double? DiscountPrice { get; set; }

                /// <summary>
                /// <para>The code of the commodity module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spec</para>
                /// </summary>
                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                /// <summary>
                /// <para>The name of the commodity module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Specification</para>
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200000.0</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public double? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The transaction price, which is equal to the original price minus the discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>160000.0</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public double? TradePrice { get; set; }

            }

            /// <summary>
            /// <para>The original price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2099</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public double? OriginalPrice { get; set; }

            /// <summary>
            /// <para>The details of the discount.</para>
            /// <remarks>
            /// <para> This parameter does not take effect for accounts registered on the China site (aliyun.com).</para>
            /// </remarks>
            /// </summary>
            [NameInMap("PromDetails")]
            [Validation(Required=false)]
            public List<DescribeCommodityPriceResponseBodyOrderDetailsPromDetails> PromDetails { get; set; }
            public class DescribeCommodityPriceResponseBodyOrderDetailsPromDetails : TeaModel {
                /// <summary>
                /// <para>The discounted price.</para>
                /// <remarks>
                /// <para> This parameter does not take effect for accounts registered on the China site (aliyun.com).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.01</para>
                /// </summary>
                [NameInMap("FinalPromFee")]
                [Validation(Required=false)]
                public double? FinalPromFee { get; set; }

                /// <summary>
                /// <para>The code of the discount option.</para>
                /// <remarks>
                /// <para> This parameter does not take effect for accounts registered on the China site (aliyun.com).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>youhui_quan</para>
                /// </summary>
                [NameInMap("OptionCode")]
                [Validation(Required=false)]
                public string OptionCode { get; set; }

                /// <summary>
                /// <para>The sub-type of the discount.</para>
                /// <remarks>
                /// <para> This parameter does not take effect for accounts registered on the China site (aliyun.com).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>deduct</para>
                /// </summary>
                [NameInMap("PromType")]
                [Validation(Required=false)]
                public string PromType { get; set; }

                /// <summary>
                /// <para>The ID of the discount item.</para>
                /// <remarks>
                /// <para> This parameter does not take effect for accounts registered on the China site (aliyun.com).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>50003298014****</para>
                /// </summary>
                [NameInMap("PromotionId")]
                [Validation(Required=false)]
                public string PromotionId { get; set; }

                /// <summary>
                /// <para>The name of the discount item.</para>
                /// <remarks>
                /// <para> This parameter does not take effect for accounts registered on the China site (aliyun.com).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>coupon</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

            }

            /// <summary>
            /// <para>The number of instances that are purchased.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

            /// <summary>
            /// <para>The IDs of discount rules.</para>
            /// </summary>
            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public List<long?> RuleIds { get; set; }

            /// <summary>
            /// <para>The transaction price, which is equal to the original price minus the discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1679.2</para>
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public double? TradePrice { get; set; }

        }

        /// <summary>
        /// <para>The original price.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2099</para>
        /// </summary>
        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public double? OriginalPrice { get; set; }

        /// <summary>
        /// <para>The details of the coupon.</para>
        /// <remarks>
        /// <para> This parameter does not take effect for accounts registered on the China site (aliyun.com).</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Promotions")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceResponseBodyPromotions> Promotions { get; set; }
        public class DescribeCommodityPriceResponseBodyPromotions : TeaModel {
            /// <summary>
            /// <para>The discounted amount.</para>
            /// <remarks>
            /// <para> This parameter does not take effect for accounts registered on the China site (aliyun.com).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CanPromFee")]
            [Validation(Required=false)]
            public double? CanPromFee { get; set; }

            /// <summary>
            /// <para>The code of the commodity to which the coupon can be applied.</para>
            /// <remarks>
            /// <para> This parameter does not take effect for accounts registered on the China site (aliyun.com).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>youhui_quan</para>
            /// </summary>
            [NameInMap("OptionCode")]
            [Validation(Required=false)]
            public string OptionCode { get; set; }

            /// <summary>
            /// <para>The name of the coupon.</para>
            /// <remarks>
            /// <para> This parameter does not take effect for accounts registered on the China site (aliyun.com).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>youhuiquan_promotion_option_id_for_blank</para>
            /// </summary>
            [NameInMap("PromotionName")]
            [Validation(Required=false)]
            public string PromotionName { get; set; }

            /// <summary>
            /// <para>The code of the coupon.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><c>youhuiquan_promotion_option_id_for_blank</c> indicates coupons that cannot be applied to the commodity.</description></item>
            /// <item><description>This parameter does not take effect for accounts registered on the China site (aliyun.com).</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50003298014****</para>
            /// </summary>
            [NameInMap("PromotionOptionNo")]
            [Validation(Required=false)]
            public string PromotionOptionNo { get; set; }

            /// <summary>
            /// <para>Indicates whether the coupon was selected.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter does not take effect for accounts registered on the China site (aliyun.com).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Selected")]
            [Validation(Required=false)]
            public bool? Selected { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about the discount rules.</para>
        /// </summary>
        [NameInMap("RuleDetails")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceResponseBodyRuleDetails> RuleDetails { get; set; }
        public class DescribeCommodityPriceResponseBodyRuleDetails : TeaModel {
            /// <summary>
            /// <para>The ID of the discount rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102104100786****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the discount rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GA New Customers Small II Specification Monthly Subscription - 20% Discount</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// <para>The transaction price, which is equal to the original price minus the discount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1679.2</para>
        /// </summary>
        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public double? TradePrice { get; set; }

    }

}
