// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribePriceResponseBody : TeaModel {
        [NameInMap("Order")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyOrder Order { get; set; }
        public class DescribePriceResponseBodyOrder : TeaModel {
            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderCoupons Coupons { get; set; }
            public class DescribePriceResponseBodyOrderCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyOrderCouponsCoupon> Coupon { get; set; }
                public class DescribePriceResponseBodyOrderCouponsCoupon : TeaModel {
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
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public string OriginalAmount { get; set; }
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public string DiscountAmount { get; set; }
            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderRuleIds RuleIds { get; set; }
            public class DescribePriceResponseBodyOrderRuleIds : TeaModel {
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public List<string> RuleId { get; set; }

            }
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public string TradeAmount { get; set; }
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubOrders")]
        [Validation(Required=false)]
        public DescribePriceResponseBodySubOrders SubOrders { get; set; }
        public class DescribePriceResponseBodySubOrders : TeaModel {
            [NameInMap("SubOrder")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodySubOrdersSubOrder> SubOrder { get; set; }
            public class DescribePriceResponseBodySubOrdersSubOrder : TeaModel {
                public string OriginalAmount { get; set; }
                public string DiscountAmount { get; set; }
                public DescribePriceResponseBodySubOrdersSubOrderRuleIds RuleIds { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderRuleIds : TeaModel {
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public List<string> RuleId { get; set; }

                }
                public string TradeAmount { get; set; }
                public string InstanceId { get; set; }
            }
        };

        [NameInMap("OrderParams")]
        [Validation(Required=false)]
        public string OrderParams { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyRules Rules { get; set; }
        public class DescribePriceResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyRulesRule> Rule { get; set; }
            public class DescribePriceResponseBodyRulesRule : TeaModel {
                public long? RuleDescId { get; set; }
                public string Title { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
