// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCashCouponsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCashCouponsResponseBodyData Data { get; set; }
        public class QueryCashCouponsResponseBodyData : TeaModel {
            [NameInMap("CashCoupon")]
            [Validation(Required=false)]
            public List<QueryCashCouponsResponseBodyDataCashCoupon> CashCoupon { get; set; }
            public class QueryCashCouponsResponseBodyDataCashCoupon : TeaModel {
                public long? CashCouponId { get; set; }
                public string CashCouponNo { get; set; }
                public string GrantedTime { get; set; }
                public string EffectiveTime { get; set; }
                public string ExpiryTime { get; set; }
                public string ApplicableProducts { get; set; }
                public string ApplicableScenarios { get; set; }
                public string NominalValue { get; set; }
                public string Balance { get; set; }
                public string Status { get; set; }
            }
        };

    }

}
