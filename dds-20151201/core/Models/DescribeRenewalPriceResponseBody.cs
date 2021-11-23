// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRenewalPriceResponseBody : TeaModel {
        [NameInMap("Order")]
        [Validation(Required=false)]
        public DescribeRenewalPriceResponseBodyOrder Order { get; set; }
        public class DescribeRenewalPriceResponseBodyOrder : TeaModel {
            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyOrderCoupons Coupons { get; set; }
            public class DescribeRenewalPriceResponseBodyOrderCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribeRenewalPriceResponseBodyOrderCouponsCoupon> Coupon { get; set; }
                public class DescribeRenewalPriceResponseBodyOrderCouponsCoupon : TeaModel {
                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public string IsSelected { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }
            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyOrderRuleIds RuleIds { get; set; }
            public class DescribeRenewalPriceResponseBodyOrderRuleIds : TeaModel {
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public List<string> RuleId { get; set; }

            }
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public float? TradeAmount { get; set; }
        };

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
                public string Name { get; set; }
                public long? RuleDescId { get; set; }
                public string Title { get; set; }
            }
        };

        [NameInMap("SubOrders")]
        [Validation(Required=false)]
        public DescribeRenewalPriceResponseBodySubOrders SubOrders { get; set; }
        public class DescribeRenewalPriceResponseBodySubOrders : TeaModel {
            [NameInMap("SubOrder")]
            [Validation(Required=false)]
            public List<DescribeRenewalPriceResponseBodySubOrdersSubOrder> SubOrder { get; set; }
            public class DescribeRenewalPriceResponseBodySubOrdersSubOrder : TeaModel {
                public float? DiscountAmount { get; set; }
                public string InstanceId { get; set; }
                public float? OriginalAmount { get; set; }
                public DescribeRenewalPriceResponseBodySubOrdersSubOrderRuleIds RuleIds { get; set; }
                public class DescribeRenewalPriceResponseBodySubOrdersSubOrderRuleIds : TeaModel {
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public List<string> RuleId { get; set; }

                }
                public float? TradeAmount { get; set; }
            }
        };

    }

}
