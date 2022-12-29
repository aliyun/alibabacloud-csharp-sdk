// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRenewalPriceResponseBody : TeaModel {
        /// <summary>
        /// The list of orders.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public DescribeRenewalPriceResponseBodyOrder Order { get; set; }
        public class DescribeRenewalPriceResponseBodyOrder : TeaModel {
            /// <summary>
            /// Details about the coupons.
            /// </summary>
            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyOrderCoupons Coupons { get; set; }
            public class DescribeRenewalPriceResponseBodyOrderCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribeRenewalPriceResponseBodyOrderCouponsCoupon> Coupon { get; set; }
                public class DescribeRenewalPriceResponseBodyOrderCouponsCoupon : TeaModel {
                    /// <summary>
                    /// The coupon number.
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
                    /// Indicates whether the coupon was selected.
                    /// </summary>
                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public string IsSelected { get; set; }

                    /// <summary>
                    /// The name of the coupon.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// The type of the currency. Valid values:
            /// 
            /// *   USD: United States dollar
            /// *   JPY: Japanese Yen
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The discount amount of the order.
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            /// <summary>
            /// The original price of the order.
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            /// <summary>
            /// The IDs of the matched rules.
            /// </summary>
            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyOrderRuleIds RuleIds { get; set; }
            public class DescribeRenewalPriceResponseBodyOrderRuleIds : TeaModel {
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public List<string> RuleId { get; set; }

            }

            /// <summary>
            /// The actual price of the order.
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public float? TradeAmount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about the promotion rules.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribeRenewalPriceResponseBodyRules Rules { get; set; }
        public class DescribeRenewalPriceResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribeRenewalPriceResponseBodyRulesRule> Rule { get; set; }
            public class DescribeRenewalPriceResponseBodyRulesRule : TeaModel {
                /// <summary>
                /// The name of the rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the rule.
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

                /// <summary>
                /// The title of the rule.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// The rules matching the coupons.
        /// </summary>
        [NameInMap("SubOrders")]
        [Validation(Required=false)]
        public DescribeRenewalPriceResponseBodySubOrders SubOrders { get; set; }
        public class DescribeRenewalPriceResponseBodySubOrders : TeaModel {
            [NameInMap("SubOrder")]
            [Validation(Required=false)]
            public List<DescribeRenewalPriceResponseBodySubOrdersSubOrder> SubOrder { get; set; }
            public class DescribeRenewalPriceResponseBodySubOrdersSubOrder : TeaModel {
                /// <summary>
                /// The discount amount of the order.
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public float? DiscountAmount { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The original price of the order.
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                /// <summary>
                /// The IDs of the matched rules.
                /// </summary>
                [NameInMap("RuleIds")]
                [Validation(Required=false)]
                public DescribeRenewalPriceResponseBodySubOrdersSubOrderRuleIds RuleIds { get; set; }
                public class DescribeRenewalPriceResponseBodySubOrdersSubOrderRuleIds : TeaModel {
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public List<string> RuleId { get; set; }

                }

                /// <summary>
                /// The actual price of the order.
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public float? TradeAmount { get; set; }

            }

        }

    }

}
