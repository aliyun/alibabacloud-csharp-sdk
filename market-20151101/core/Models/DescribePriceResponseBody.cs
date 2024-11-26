// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribePriceResponseBody : TeaModel {
        [NameInMap("Coupons")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyCoupons Coupons { get; set; }
        public class DescribePriceResponseBodyCoupons : TeaModel {
            [NameInMap("Coupon")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyCouponsCoupon> Coupon { get; set; }
            public class DescribePriceResponseBodyCouponsCoupon : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("CanPromFee")]
                [Validation(Required=false)]
                public float? CanPromFee { get; set; }

                [NameInMap("CouponDesc")]
                [Validation(Required=false)]
                public string CouponDesc { get; set; }

                [NameInMap("CouponName")]
                [Validation(Required=false)]
                public string CouponName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ActiveCoupon</para>
                /// </summary>
                [NameInMap("CouponOptionCode")]
                [Validation(Required=false)]
                public string CouponOptionCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3874923111</para>
                /// </summary>
                [NameInMap("CouponOptionNo")]
                [Validation(Required=false)]
                public string CouponOptionNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsSelected")]
                [Validation(Required=false)]
                public bool? IsSelected { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Cuxiao")]
        [Validation(Required=false)]
        public bool? Cuxiao { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MONTH</para>
        /// </summary>
        [NameInMap("Cycle")]
        [Validation(Required=false)]
        public string Cycle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>178.20</para>
        /// </summary>
        [NameInMap("DiscountPrice")]
        [Validation(Required=false)]
        public float? DiscountPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ORDER.NO_REAL_NAME_AUTHENTICATION</para>
        /// </summary>
        [NameInMap("ExpressionCode")]
        [Validation(Required=false)]
        public string ExpressionCode { get; set; }

        [NameInMap("ExpressionMessage")]
        [Validation(Required=false)]
        public string ExpressionMessage { get; set; }

        [NameInMap("InfoTitle")]
        [Validation(Required=false)]
        public string InfoTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>198.00</para>
        /// </summary>
        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cmgj01****</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("PromotionRules")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPromotionRules PromotionRules { get; set; }
        public class DescribePriceResponseBodyPromotionRules : TeaModel {
            [NameInMap("PromotionRule")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyPromotionRulesPromotionRule> PromotionRule { get; set; }
            public class DescribePriceResponseBodyPromotionRulesPromotionRule : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>102112</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>19.80</para>
        /// </summary>
        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

    }

}
