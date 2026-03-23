// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePriceResponseBody : TeaModel {
        [NameInMap("OrderParams")]
        [Validation(Required=false)]
        public string OrderParams { get; set; }

        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("ActivityInfo")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoActivityInfo ActivityInfo { get; set; }
            public class DescribePriceResponseBodyPriceInfoActivityInfo : TeaModel {
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

            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoCoupons Coupons { get; set; }
            public class DescribePriceResponseBodyPriceInfoCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoCouponsCoupon> Coupon { get; set; }
                public class DescribePriceResponseBodyPriceInfoCouponsCoupon : TeaModel {
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

            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            [NameInMap("OrderLines")]
            [Validation(Required=false)]
            public object OrderLines { get; set; }

            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoRuleIds RuleIds { get; set; }
            public class DescribePriceResponseBodyPriceInfoRuleIds : TeaModel {
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public List<string> RuleId { get; set; }

            }

            [NameInMap("TradeMaxRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMaxRCUAmount { get; set; }

            [NameInMap("TradeMinRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMinRCUAmount { get; set; }

            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyRules Rules { get; set; }
        public class DescribePriceResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyRulesRule> Rule { get; set; }
            public class DescribePriceResponseBodyRulesRule : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        [NameInMap("ServerlessPrice")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyServerlessPrice ServerlessPrice { get; set; }
        public class DescribePriceResponseBodyServerlessPrice : TeaModel {
            [NameInMap("RCUDiscountMaxAmount")]
            [Validation(Required=false)]
            public float? RCUDiscountMaxAmount { get; set; }

            [NameInMap("RCUDiscountMinAmount")]
            [Validation(Required=false)]
            public float? RCUDiscountMinAmount { get; set; }

            [NameInMap("RCUOriginalMaxAmount")]
            [Validation(Required=false)]
            public float? RCUOriginalMaxAmount { get; set; }

            [NameInMap("RCUOriginalMinAmount")]
            [Validation(Required=false)]
            public float? RCUOriginalMinAmount { get; set; }

            [NameInMap("StorageOriginalAmount")]
            [Validation(Required=false)]
            public float? StorageOriginalAmount { get; set; }

            [NameInMap("TotalOriginalMaxAmount")]
            [Validation(Required=false)]
            public float? TotalOriginalMaxAmount { get; set; }

            [NameInMap("TotalOriginalMinAmount")]
            [Validation(Required=false)]
            public float? TotalOriginalMinAmount { get; set; }

            [NameInMap("TradeMaxRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMaxRCUAmount { get; set; }

            [NameInMap("TradeMinRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMinRCUAmount { get; set; }

            [NameInMap("storageDiscountAmount")]
            [Validation(Required=false)]
            public float? StorageDiscountAmount { get; set; }

        }

        [NameInMap("ShowDiscount")]
        [Validation(Required=false)]
        public bool? ShowDiscount { get; set; }

        [NameInMap("TradeMaxRCUAmount")]
        [Validation(Required=false)]
        public float? TradeMaxRCUAmount { get; set; }

        [NameInMap("TradeMinRCUAmount")]
        [Validation(Required=false)]
        public float? TradeMinRCUAmount { get; set; }

    }

}
