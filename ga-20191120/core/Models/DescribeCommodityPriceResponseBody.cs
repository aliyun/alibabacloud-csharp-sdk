// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCommodityPriceResponseBody : TeaModel {
        /// <summary>
        /// The currency unit.
        /// 
        /// *   China site: **CNY**.
        /// *   International site: **USD**.
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The discount.
        /// </summary>
        [NameInMap("DiscountPrice")]
        [Validation(Required=false)]
        public double? DiscountPrice { get; set; }

        /// <summary>
        /// The details of the commodity module.
        /// </summary>
        [NameInMap("OrderDetails")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceResponseBodyOrderDetails> OrderDetails { get; set; }
        public class DescribeCommodityPriceResponseBodyOrderDetails : TeaModel {
            /// <summary>
            /// The code of the commodity.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The name of the commodity.
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// The discount.
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public double? DiscountPrice { get; set; }

            /// <summary>
            /// The information about the commodity module.
            /// </summary>
            [NameInMap("ModuleDetails")]
            [Validation(Required=false)]
            public List<DescribeCommodityPriceResponseBodyOrderDetailsModuleDetails> ModuleDetails { get; set; }
            public class DescribeCommodityPriceResponseBodyOrderDetailsModuleDetails : TeaModel {
                /// <summary>
                /// The discount.
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public double? DiscountPrice { get; set; }

                /// <summary>
                /// The code of the commodity module.
                /// </summary>
                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                /// <summary>
                /// The name of the commodity module.
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// The original price.
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public double? OriginalPrice { get; set; }

                /// <summary>
                /// The transaction price, which is equal to the original price minus the discount.
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public double? TradePrice { get; set; }

            }

            /// <summary>
            /// The original price.
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public double? OriginalPrice { get; set; }

            /// <summary>
            /// The details of the discount.
            /// 
            /// >  This parameter does not take effect for accounts registered on the China site (aliyun.com).
            /// </summary>
            [NameInMap("PromDetails")]
            [Validation(Required=false)]
            public List<DescribeCommodityPriceResponseBodyOrderDetailsPromDetails> PromDetails { get; set; }
            public class DescribeCommodityPriceResponseBodyOrderDetailsPromDetails : TeaModel {
                /// <summary>
                /// The discounted price.
                /// 
                /// >  This parameter does not take effect for accounts registered on the China site (aliyun.com).
                /// </summary>
                [NameInMap("FinalPromFee")]
                [Validation(Required=false)]
                public double? FinalPromFee { get; set; }

                /// <summary>
                /// The code of the discount option.
                /// 
                /// >  This parameter does not take effect for accounts registered on the China site (aliyun.com).
                /// </summary>
                [NameInMap("OptionCode")]
                [Validation(Required=false)]
                public string OptionCode { get; set; }

                /// <summary>
                /// The sub-type of the discount.
                /// 
                /// >  This parameter does not take effect for accounts registered on the China site (aliyun.com).
                /// </summary>
                [NameInMap("PromType")]
                [Validation(Required=false)]
                public string PromType { get; set; }

                /// <summary>
                /// The ID of the discount item.
                /// 
                /// >  This parameter does not take effect for accounts registered on the China site (aliyun.com).
                /// </summary>
                [NameInMap("PromotionId")]
                [Validation(Required=false)]
                public string PromotionId { get; set; }

                /// <summary>
                /// The name of the discount item.
                /// 
                /// >  This parameter does not take effect for accounts registered on the China site (aliyun.com).
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

            }

            /// <summary>
            /// The number of instances that are purchased.
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

            /// <summary>
            /// The IDs of discount rules.
            /// </summary>
            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public List<long?> RuleIds { get; set; }

            /// <summary>
            /// The transaction price, which is equal to the original price minus the discount.
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public double? TradePrice { get; set; }

        }

        /// <summary>
        /// The original price.
        /// </summary>
        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public double? OriginalPrice { get; set; }

        /// <summary>
        /// The details of the coupon.
        /// 
        /// >  This parameter does not take effect for accounts registered on the China site (aliyun.com).
        /// </summary>
        [NameInMap("Promotions")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceResponseBodyPromotions> Promotions { get; set; }
        public class DescribeCommodityPriceResponseBodyPromotions : TeaModel {
            /// <summary>
            /// The discounted amount.
            /// 
            /// >  This parameter does not take effect for accounts registered on the China site (aliyun.com).
            /// </summary>
            [NameInMap("CanPromFee")]
            [Validation(Required=false)]
            public double? CanPromFee { get; set; }

            /// <summary>
            /// The code of the commodity to which the coupon can be applied.
            /// 
            /// >  This parameter does not take effect for accounts registered on the China site (aliyun.com).
            /// </summary>
            [NameInMap("OptionCode")]
            [Validation(Required=false)]
            public string OptionCode { get; set; }

            /// <summary>
            /// The name of the coupon.
            /// 
            /// >  This parameter does not take effect for accounts registered on the China site (aliyun.com).
            /// </summary>
            [NameInMap("PromotionName")]
            [Validation(Required=false)]
            public string PromotionName { get; set; }

            /// <summary>
            /// The code of the coupon.
            /// > *   `youhuiquan_promotion_option_id_for_blank` indicates coupons that cannot be applied to the commodity.
            /// > *   This parameter does not take effect for accounts registered on the China site (aliyun.com).
            /// </summary>
            [NameInMap("PromotionOptionNo")]
            [Validation(Required=false)]
            public string PromotionOptionNo { get; set; }

            /// <summary>
            /// Indicates whether the coupon was selected.
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// >  This parameter does not take effect for accounts registered on the China site (aliyun.com).
            /// </summary>
            [NameInMap("Selected")]
            [Validation(Required=false)]
            public bool? Selected { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details about the discount rules.
        /// </summary>
        [NameInMap("RuleDetails")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceResponseBodyRuleDetails> RuleDetails { get; set; }
        public class DescribeCommodityPriceResponseBodyRuleDetails : TeaModel {
            /// <summary>
            /// The ID of the discount rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The name of the discount rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// The transaction price, which is equal to the original price minus the discount.
        /// </summary>
        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public double? TradePrice { get; set; }

    }

}
