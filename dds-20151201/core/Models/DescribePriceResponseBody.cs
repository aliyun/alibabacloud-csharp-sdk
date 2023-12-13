// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// The order.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyOrder Order { get; set; }
        public class DescribePriceResponseBodyOrder : TeaModel {
            /// <summary>
            /// The information of coupons.
            /// </summary>
            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderCoupons Coupons { get; set; }
            public class DescribePriceResponseBodyOrderCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyOrderCouponsCoupon> Coupon { get; set; }
                public class DescribePriceResponseBodyOrderCouponsCoupon : TeaModel {
                    /// <summary>
                    /// The activity type of the coupon. Valid values:
                    /// 
                    /// *   **payondemand**: subscription
                    /// *   **payasyougo**: pay-as-you-go
                    /// </summary>
                    [NameInMap("ActivityCategory")]
                    [Validation(Required=false)]
                    public string ActivityCategory { get; set; }

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
                    /// Indicates whether the coupon was selected. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
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

                    /// <summary>
                    /// The code of the coupon.
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    /// <summary>
                    /// The promotional option code.
                    /// </summary>
                    [NameInMap("PromotionOptionCode")]
                    [Validation(Required=false)]
                    public string PromotionOptionCode { get; set; }

                    /// <summary>
                    /// Details about the rules that match the coupon.
                    /// </summary>
                    [NameInMap("PromotionRuleIdList")]
                    [Validation(Required=false)]
                    public DescribePriceResponseBodyOrderCouponsCouponPromotionRuleIdList PromotionRuleIdList { get; set; }
                    public class DescribePriceResponseBodyOrderCouponsCouponPromotionRuleIdList : TeaModel {
                        [NameInMap("PromotionRuleId")]
                        [Validation(Required=false)]
                        public List<long?> PromotionRuleId { get; set; }

                    }

                }

            }

            /// <summary>
            /// The currency.
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The discount amount of the order.
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public string DiscountAmount { get; set; }

            /// <summary>
            /// The original price of the order.
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public string OriginalAmount { get; set; }

            /// <summary>
            /// The rules of the order.
            /// </summary>
            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderRuleIds RuleIds { get; set; }
            public class DescribePriceResponseBodyOrderRuleIds : TeaModel {
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public List<string> RuleId { get; set; }

            }

            /// <summary>
            /// Indicates whether the information of the discount is displayed.
            /// </summary>
            [NameInMap("ShowDiscountInfo")]
            [Validation(Required=false)]
            public bool? ShowDiscountInfo { get; set; }

            /// <summary>
            /// The final price of the order.
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public string TradeAmount { get; set; }

        }

        /// <summary>
        /// The order parameters.
        /// 
        /// > This parameter is returned only when the **OrderParamOut** parameter is set to **true**.
        /// </summary>
        [NameInMap("OrderParams")]
        [Validation(Required=false)]
        public string OrderParams { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The promotion rules.
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
                /// The rule name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The rule ID.
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

                /// <summary>
                /// The rule title.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// The coupon rules.
        /// </summary>
        [NameInMap("SubOrders")]
        [Validation(Required=false)]
        public DescribePriceResponseBodySubOrders SubOrders { get; set; }
        public class DescribePriceResponseBodySubOrders : TeaModel {
            [NameInMap("SubOrder")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodySubOrdersSubOrder> SubOrder { get; set; }
            public class DescribePriceResponseBodySubOrdersSubOrder : TeaModel {
                /// <summary>
                /// The discount amount of the order.
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public string DiscountAmount { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The list price of the order.
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public string OriginalAmount { get; set; }

                /// <summary>
                /// The promotion rules.
                /// </summary>
                [NameInMap("RuleIds")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderRuleIds RuleIds { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderRuleIds : TeaModel {
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public List<string> RuleId { get; set; }

                }

                /// <summary>
                /// The actual price of the order.
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public string TradeAmount { get; set; }

            }

        }

        /// <summary>
        /// The ID of the trace.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
