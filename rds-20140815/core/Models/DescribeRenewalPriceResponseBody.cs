// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRenewalPriceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribeRenewalPriceResponseBodyRules Rules { get; set; }
        public class DescribeRenewalPriceResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribeRenewalPriceResponseBodyRulesRule> Rule { get; set; }
            public class DescribeRenewalPriceResponseBodyRulesRule : TeaModel {
                public string Description { get; set; }
                public string Name { get; set; }
                public long? RuleId { get; set; }
            }
        };

        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeRenewalPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeRenewalPriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyPriceInfoCoupons Coupons { get; set; }
            public class DescribeRenewalPriceResponseBodyPriceInfoCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribeRenewalPriceResponseBodyPriceInfoCouponsCoupon> Coupon { get; set; }
                public class DescribeRenewalPriceResponseBodyPriceInfoCouponsCoupon : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public string IsSelected { get; set; }

                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }
            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyPriceInfoRuleIds RuleIds { get; set; }
            public class DescribeRenewalPriceResponseBodyPriceInfoRuleIds : TeaModel {
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public List<string> RuleId { get; set; }

            }
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }
            [NameInMap("ActivityInfo")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyPriceInfoActivityInfo ActivityInfo { get; set; }
            public class DescribeRenewalPriceResponseBodyPriceInfoActivityInfo : TeaModel {
                [NameInMap("CheckErrMsg")]
                [Validation(Required=false)]
                public string CheckErrMsg { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public string Success { get; set; }

            }
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }
        };

    }

}
