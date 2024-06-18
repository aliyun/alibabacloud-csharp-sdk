// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// The order parameters.
        /// 
        /// >  If the **OrderParamOut** parameter is set to **true**, the value of the OrderParams parameter is returned.
        /// </summary>
        [NameInMap("OrderParams")]
        [Validation(Required=false)]
        public string OrderParams { get; set; }

        /// <summary>
        /// The price information.
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// The information about the promotion.
            /// </summary>
            [NameInMap("ActivityInfo")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoActivityInfo ActivityInfo { get; set; }
            public class DescribePriceResponseBodyPriceInfoActivityInfo : TeaModel {
                /// <summary>
                /// The returned message.
                /// </summary>
                [NameInMap("CheckErrMsg")]
                [Validation(Required=false)]
                public string CheckErrMsg { get; set; }

                /// <summary>
                /// The error code that is returned.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// Indicates whether the request was successful.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public string Success { get; set; }

            }

            /// <summary>
            /// The information about the coupon.
            /// </summary>
            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoCoupons Coupons { get; set; }
            public class DescribePriceResponseBodyPriceInfoCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoCouponsCoupon> Coupon { get; set; }
                public class DescribePriceResponseBodyPriceInfoCouponsCoupon : TeaModel {
                    /// <summary>
                    /// The coupon ID.
                    /// </summary>
                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    /// <summary>
                    /// The description of the coupon.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// Indicates whether the coupon is selected.
                    /// </summary>
                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public string IsSelected { get; set; }

                    /// <summary>
                    /// The coupon name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// The currency unit.
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The discount.
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// The order information.
            /// </summary>
            [NameInMap("OrderLines")]
            [Validation(Required=false)]
            public string OrderLines { get; set; }

            /// <summary>
            /// The original price.
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            /// <summary>
            /// An array that consists of the ID of the promotion rule.
            /// </summary>
            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoRuleIds RuleIds { get; set; }
            public class DescribePriceResponseBodyPriceInfoRuleIds : TeaModel {
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public List<string> RuleId { get; set; }

            }

            /// <summary>
            /// The estimated hourly cost that is calculated based on the maximum number of RCUs you specify.
            /// </summary>
            [NameInMap("TradeMaxRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMaxRCUAmount { get; set; }

            /// <summary>
            /// The estimated hourly cost that is calculated based on the minimum number of RCUs you specify.
            /// </summary>
            [NameInMap("TradeMinRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMinRCUAmount { get; set; }

            /// <summary>
            /// The transaction price, which is equal to the original price minus the discount.
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the promotion rule.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyRules Rules { get; set; }
        public class DescribePriceResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyRulesRule> Rule { get; set; }
            public class DescribePriceResponseBodyRulesRule : TeaModel {
                /// <summary>
                /// The description of the promotion rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the promotion rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the promotion rule.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        /// <summary>
        /// The pricing information about a serverless RDS instance.
        /// </summary>
        [NameInMap("ServerlessPrice")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyServerlessPrice ServerlessPrice { get; set; }
        public class DescribePriceResponseBodyServerlessPrice : TeaModel {
            /// <summary>
            /// The discount amount of the maximum number of RCUs.
            /// </summary>
            [NameInMap("RCUDiscountMaxAmount")]
            [Validation(Required=false)]
            public float? RCUDiscountMaxAmount { get; set; }

            /// <summary>
            /// The discount amount of the minimum number of RCUs.
            /// </summary>
            [NameInMap("RCUDiscountMinAmount")]
            [Validation(Required=false)]
            public float? RCUDiscountMinAmount { get; set; }

            /// <summary>
            /// The price of the maximum number of RCUs.
            /// </summary>
            [NameInMap("RCUOriginalMaxAmount")]
            [Validation(Required=false)]
            public float? RCUOriginalMaxAmount { get; set; }

            /// <summary>
            /// The price of the minimum number of RCUs.
            /// </summary>
            [NameInMap("RCUOriginalMinAmount")]
            [Validation(Required=false)]
            public float? RCUOriginalMinAmount { get; set; }

            /// <summary>
            /// The original price of the disk capacity.
            /// </summary>
            [NameInMap("StorageOriginalAmount")]
            [Validation(Required=false)]
            public float? StorageOriginalAmount { get; set; }

            /// <summary>
            /// The maximum total price before the discount.
            /// </summary>
            [NameInMap("TotalOriginalMaxAmount")]
            [Validation(Required=false)]
            public float? TotalOriginalMaxAmount { get; set; }

            /// <summary>
            /// The minimum total price before the discount.
            /// </summary>
            [NameInMap("TotalOriginalMinAmount")]
            [Validation(Required=false)]
            public float? TotalOriginalMinAmount { get; set; }

            /// <summary>
            /// The transaction price of the maximum number of RCUs.
            /// </summary>
            [NameInMap("TradeMaxRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMaxRCUAmount { get; set; }

            /// <summary>
            /// The transaction price of the minimum number of RCUs.
            /// </summary>
            [NameInMap("TradeMinRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMinRCUAmount { get; set; }

            /// <summary>
            /// The discounted price of the disk capacity.
            /// </summary>
            [NameInMap("storageDiscountAmount")]
            [Validation(Required=false)]
            public float? StorageDiscountAmount { get; set; }

        }

        /// <summary>
        /// Indicates whether discounts can be used.
        /// </summary>
        [NameInMap("ShowDiscount")]
        [Validation(Required=false)]
        public bool? ShowDiscount { get; set; }

        /// <summary>
        /// The estimated hourly fee that is calculated based on the maximum number of RCUs.
        /// </summary>
        [NameInMap("TradeMaxRCUAmount")]
        [Validation(Required=false)]
        public float? TradeMaxRCUAmount { get; set; }

        /// <summary>
        /// The estimated hourly fee that is calculated based on the minimum number of RCUs.
        /// </summary>
        [NameInMap("TradeMinRCUAmount")]
        [Validation(Required=false)]
        public float? TradeMinRCUAmount { get; set; }

    }

}
