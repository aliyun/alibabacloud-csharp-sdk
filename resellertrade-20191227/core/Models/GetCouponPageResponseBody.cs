// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class GetCouponPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContextMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> ContextMap { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCouponPageResponseBodyData> Data { get; set; }
        public class GetCouponPageResponseBodyData : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public double? Amount { get; set; }

            [NameInMap("CertainMoney")]
            [Validation(Required=false)]
            public double? CertainMoney { get; set; }

            [NameInMap("CouponId")]
            [Validation(Required=false)]
            public long? CouponId { get; set; }

            [NameInMap("CouponType")]
            [Validation(Required=false)]
            public string CouponType { get; set; }

            [NameInMap("Currency")]
            [Validation(Required=false)]
            public GetCouponPageResponseBodyDataCurrency Currency { get; set; }
            public class GetCouponPageResponseBodyDataCurrency : TeaModel {
                [NameInMap("CurrencyCode")]
                [Validation(Required=false)]
                public string CurrencyCode { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DiscountRate")]
            [Validation(Required=false)]
            public double? DiscountRate { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("FrozenAmount")]
            [Validation(Required=false)]
            public double? FrozenAmount { get; set; }

            [NameInMap("FrozenCount")]
            [Validation(Required=false)]
            public int? FrozenCount { get; set; }

            [NameInMap("PromotionId")]
            [Validation(Required=false)]
            public long? PromotionId { get; set; }

            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public long? SellerId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            [NameInMap("UniversalType")]
            [Validation(Required=false)]
            public string UniversalType { get; set; }

            [NameInMap("UpperLimit")]
            [Validation(Required=false)]
            public double? UpperLimit { get; set; }

            [NameInMap("UsageCount")]
            [Validation(Required=false)]
            public int? UsageCount { get; set; }

            [NameInMap("UsedAmount")]
            [Validation(Required=false)]
            public double? UsedAmount { get; set; }

            [NameInMap("UsedCount")]
            [Validation(Required=false)]
            public int? UsedCount { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
