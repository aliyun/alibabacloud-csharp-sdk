// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed pricing information.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>The pricing information.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribePriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// <para>Specifies whether the coupon is selected.</para>
                /// </summary>
                [NameInMap("Coupons")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoPriceCoupons> Coupons { get; set; }
                public class DescribePriceResponseBodyPriceInfoPriceCoupons : TeaModel {
                    /// <summary>
                    /// <para>The coupon code. Default value: <c>youhuiquan_promotion_option_id_for_blank</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>youhuiquan_promotion_option_id_for_blank</para>
                    /// </summary>
                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    /// <summary>
                    /// <para>The custom parameter description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OK</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20.0</para>
                    /// </summary>
                    [NameInMap("DiscountOff")]
                    [Validation(Required=false)]
                    public float? DiscountOff { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the coupon is selected.</para>
                    /// </summary>
                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public bool? IsSelected { get; set; }

                    /// <summary>
                    /// <para>The command name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACS-SWAS-GenerateRsaKeypair-windows.ps1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The promotion ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                }

                /// <summary>
                /// <para>The currency. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CNY: Chinese yuan.</description></item>
                /// <item><description>USD: US dollar.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The detailed pricing information of the configuration.</para>
                /// </summary>
                [NameInMap("DetailInfos")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoPriceDetailInfos> DetailInfos { get; set; }
                public class DescribePriceResponseBodyPriceInfoPriceDetailInfos : TeaModel {
                    /// <summary>
                    /// <para>The resource name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Server</para>
                    /// </summary>
                    [NameInMap("CommodityType")]
                    [Validation(Required=false)]
                    public string CommodityType { get; set; }

                    /// <summary>
                    /// <para>The discounted price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public float? DiscountPrice { get; set; }

                    /// <summary>
                    /// <para>The original price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1850</para>
                    /// </summary>
                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public float? OriginalPrice { get; set; }

                    /// <summary>
                    /// <para>The promotion information matched by the configuration details.</para>
                    /// </summary>
                    [NameInMap("Promotions")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodyPriceInfoPriceDetailInfosPromotions> Promotions { get; set; }
                    public class DescribePriceResponseBodyPriceInfoPriceDetailInfosPromotions : TeaModel {
                        /// <summary>
                        /// <para>The discount amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("DiscountOff")]
                        [Validation(Required=false)]
                        public float? DiscountOff { get; set; }

                        /// <summary>
                        /// <para>The promotion name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Discounted price on the official website for compute-optimized instances</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The promotion rule ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public long? RuleId { get; set; }

                    }

                    /// <summary>
                    /// <para>The transaction price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>267.4</para>
                    /// </summary>
                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public float? TradePrice { get; set; }

                }

                /// <summary>
                /// <para>The discounted price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// <para>Specifies whether a promotion is matched.</para>
                /// </summary>
                [NameInMap("IsContractPromotion")]
                [Validation(Required=false)]
                public bool? IsContractPromotion { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1580</para>
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
                    /// <para>The coupon discount amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20.0</para>
                    /// </summary>
                    [NameInMap("DiscountOff")]
                    [Validation(Required=false)]
                    public float? DiscountOff { get; set; }

                    /// <summary>
                    /// <para>The coupon name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACS-SWAS-ResetPassword-for-linux.sh</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The promotion ID.</para>
                    /// </summary>
                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<long?> RuleIds { get; set; }

                }

                /// <summary>
                /// <para>The discounted price based on the official website discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("StandardDiscountPrice")]
                [Validation(Required=false)]
                public float? StandardDiscountPrice { get; set; }

                /// <summary>
                /// <para>The discounted price on the official website or the discounted price in the direct sales contract.</para>
                /// 
                /// <b>Example:</b>
                /// <para>899</para>
                /// </summary>
                [NameInMap("StandardPrice")]
                [Validation(Required=false)]
                public float? StandardPrice { get; set; }

                /// <summary>
                /// <para>The list of price details.</para>
                /// </summary>
                [NameInMap("SubPrices")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoPriceSubPrices> SubPrices { get; set; }
                public class DescribePriceResponseBodyPriceInfoPriceSubPrices : TeaModel {
                    /// <summary>
                    /// <para>The order discount amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public float? DiscountPrice { get; set; }

                    /// <summary>
                    /// <para>The instance ID of the Simple Application Server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d63a1c00ce14419194ae5bef5e*****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>Specifies whether a promotion is matched.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsContractPromotion")]
                    [Validation(Required=false)]
                    public bool? IsContractPromotion { get; set; }

                    /// <summary>
                    /// <para>The original price of the order (CNY).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>165.0</para>
                    /// </summary>
                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public float? OriginalPrice { get; set; }

                    /// <summary>
                    /// <para>The promotion name.</para>
                    /// </summary>
                    [NameInMap("Promotions")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodyPriceInfoPriceSubPricesPromotions> Promotions { get; set; }
                    public class DescribePriceResponseBodyPriceInfoPriceSubPricesPromotions : TeaModel {
                        /// <summary>
                        /// <para>The coupon discount amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20.0</para>
                        /// </summary>
                        [NameInMap("DiscountOff")]
                        [Validation(Required=false)]
                        public float? DiscountOff { get; set; }

                        /// <summary>
                        /// <para>The name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Discount</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The promotion rule ID.</para>
                        /// </summary>
                        [NameInMap("RuleIds")]
                        [Validation(Required=false)]
                        public List<long?> RuleIds { get; set; }

                    }

                    /// <summary>
                    /// <para>The collection of activity rule IDs.</para>
                    /// </summary>
                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<long?> RuleIds { get; set; }

                    /// <summary>
                    /// <para>The discounted price based on the official website discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>85.0</para>
                    /// </summary>
                    [NameInMap("StandardDiscountPrice")]
                    [Validation(Required=false)]
                    public float? StandardDiscountPrice { get; set; }

                    /// <summary>
                    /// <para>The discounted price on the official website or the discounted price in the direct sales contract.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>899.0</para>
                    /// </summary>
                    [NameInMap("StandardPrice")]
                    [Validation(Required=false)]
                    public float? StandardPrice { get; set; }

                    /// <summary>
                    /// <para>The transaction price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>899.0</para>
                    /// </summary>
                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public float? TradePrice { get; set; }

                }

                /// <summary>
                /// <para>The transaction price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>267.4</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// <para>The activity rule information.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class DescribePriceResponseBodyPriceInfoRules : TeaModel {
                /// <summary>
                /// <para>The custom parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Purchase a one-year subscription to enjoy an xxx discount on the official website price</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>142</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
