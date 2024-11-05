// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRenewalPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of orders.</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public DescribeRenewalPriceResponseBodyOrder Order { get; set; }
        public class DescribeRenewalPriceResponseBodyOrder : TeaModel {
            /// <summary>
            /// <para>Details about the coupons.</para>
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
                    /// <para>The coupon number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>youhuiquan_promotion_option_id_for_blank</para>
                    /// </summary>
                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    /// <summary>
                    /// <para>The description of the coupon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>coupondemo</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the coupon was selected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public string IsSelected { get; set; }

                    /// <summary>
                    /// <para>The name of the coupon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>youhuiquan111</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The type of the currency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>USD: United States dollar</description></item>
            /// <item><description>JPY: Japanese Yen</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The discount amount of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1144.8</para>
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            /// <summary>
            /// <para>The original price of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1144.8</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            /// <summary>
            /// <para>The IDs of the matched rules.</para>
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
            /// <para>The actual price of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public float? TradeAmount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFD65226-08CC-4C4D-B6A4-CB3C382F67B0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details about the promotion rules.</para>
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
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demoname</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11111111</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

                /// <summary>
                /// <para>The title of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <para>The rules matching the coupons.</para>
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
                /// <para>The discount amount of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1144.8</para>
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public float? DiscountAmount { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dds-bp12c5b040dc****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The original price of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1144.8</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                /// <summary>
                /// <para>The IDs of the matched rules.</para>
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
                /// <para>The actual price of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public float? TradeAmount { get; set; }

            }

        }

    }

}
