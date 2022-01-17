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
                public float? CanPromFee { get; set; }
                public string CouponDesc { get; set; }
                public string CouponName { get; set; }
                public string CouponOptionCode { get; set; }
                public string CouponOptionNo { get; set; }
                public bool? IsSelected { get; set; }
            }
        };

        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("Cuxiao")]
        [Validation(Required=false)]
        public bool? Cuxiao { get; set; }

        [NameInMap("Cycle")]
        [Validation(Required=false)]
        public string Cycle { get; set; }

        [NameInMap("DiscountPrice")]
        [Validation(Required=false)]
        public float? DiscountPrice { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("ExpressionCode")]
        [Validation(Required=false)]
        public string ExpressionCode { get; set; }

        [NameInMap("ExpressionMessage")]
        [Validation(Required=false)]
        public string ExpressionMessage { get; set; }

        [NameInMap("InfoTitle")]
        [Validation(Required=false)]
        public string InfoTitle { get; set; }

        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

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
                public string Name { get; set; }
                public string RuleId { get; set; }
                public string Title { get; set; }
            }
        };

        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

    }

}
