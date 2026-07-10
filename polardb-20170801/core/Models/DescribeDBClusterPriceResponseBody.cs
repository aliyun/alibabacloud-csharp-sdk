// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BUY: new purchase.</description></item>
        /// <item><description>UPGRADE: specification change.</description></item>
        /// <item><description>RENEW: renewal.</description></item>
        /// <item><description>CONVERT: billing method conversion.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The price details.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeDBClusterPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeDBClusterPriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribeDBClusterPriceResponseBodyPriceInfoCoupons Coupons { get; set; }
            public class DescribeDBClusterPriceResponseBodyPriceInfoCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribeDBClusterPriceResponseBodyPriceInfoCouponsCoupon> Coupon { get; set; }
                public class DescribeDBClusterPriceResponseBodyPriceInfoCouponsCoupon : TeaModel {
                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public string IsSelected { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The currency unit.</para>
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
            /// <para>1978.2</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <para>The original price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1099.0</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public DescribeDBClusterPriceResponseBodyPriceInfoRuleIds RuleIds { get; set; }
            public class DescribeDBClusterPriceResponseBodyPriceInfoRuleIds : TeaModel {
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public List<string> RuleId { get; set; }

            }

            /// <summary>
            /// <para>The final price, which is the original price minus the discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>165.0</para>
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E2FE3BB-C677-5FF9-9FC5-XXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribeDBClusterPriceResponseBodyRules Rules { get; set; }
        public class DescribeDBClusterPriceResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribeDBClusterPriceResponseBodyRulesRule> Rule { get; set; }
            public class DescribeDBClusterPriceResponseBodyRulesRule : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether discounts are allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("ShowDiscount")]
        [Validation(Required=false)]
        public bool? ShowDiscount { get; set; }

    }

}
