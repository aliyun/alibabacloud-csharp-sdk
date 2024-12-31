// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bss20140714.Models
{
    public class DescribeCouponListResponseBody : TeaModel {
        [NameInMap("Coupons")]
        [Validation(Required=false)]
        public DescribeCouponListResponseBodyCoupons Coupons { get; set; }
        public class DescribeCouponListResponseBodyCoupons : TeaModel {
            [NameInMap("Coupon")]
            [Validation(Required=false)]
            public List<DescribeCouponListResponseBodyCouponsCoupon> Coupon { get; set; }
            public class DescribeCouponListResponseBodyCouponsCoupon : TeaModel {
                [NameInMap("Application")]
                [Validation(Required=false)]
                public string Application { get; set; }

                [NameInMap("BalanceAmount")]
                [Validation(Required=false)]
                public string BalanceAmount { get; set; }

                [NameInMap("CouponNumber")]
                [Validation(Required=false)]
                public string CouponNumber { get; set; }

                [NameInMap("CouponTemplateId")]
                [Validation(Required=false)]
                public long? CouponTemplateId { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DeliveryTime")]
                [Validation(Required=false)]
                public string DeliveryTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpiredAmount")]
                [Validation(Required=false)]
                public string ExpiredAmount { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("FrozenAmount")]
                [Validation(Required=false)]
                public string FrozenAmount { get; set; }

                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                [NameInMap("PriceLimit")]
                [Validation(Required=false)]
                public string PriceLimit { get; set; }

                [NameInMap("ProductCodes")]
                [Validation(Required=false)]
                public DescribeCouponListResponseBodyCouponsCouponProductCodes ProductCodes { get; set; }
                public class DescribeCouponListResponseBodyCouponsCouponProductCodes : TeaModel {
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public List<string> ProductCode { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalAmount")]
                [Validation(Required=false)]
                public string TotalAmount { get; set; }

                [NameInMap("TradeTypes")]
                [Validation(Required=false)]
                public DescribeCouponListResponseBodyCouponsCouponTradeTypes TradeTypes { get; set; }
                public class DescribeCouponListResponseBodyCouponsCouponTradeTypes : TeaModel {
                    [NameInMap("TradeType")]
                    [Validation(Required=false)]
                    public List<string> TradeType { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
