// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCashCouponsResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCashCouponsResponseBodyData Data { get; set; }
        public class QueryCashCouponsResponseBodyData : TeaModel {
            [NameInMap("CashCoupon")]
            [Validation(Required=false)]
            public List<QueryCashCouponsResponseBodyDataCashCoupon> CashCoupon { get; set; }
            public class QueryCashCouponsResponseBodyDataCashCoupon : TeaModel {
                /// <summary>
                /// The service to which the voucher is applicable.
                /// </summary>
                [NameInMap("ApplicableProducts")]
                [Validation(Required=false)]
                public string ApplicableProducts { get; set; }

                /// <summary>
                /// The scenario to which the voucher is applicable.
                /// </summary>
                [NameInMap("ApplicableScenarios")]
                [Validation(Required=false)]
                public string ApplicableScenarios { get; set; }

                /// <summary>
                /// The remaining quota of the voucher.
                /// </summary>
                [NameInMap("Balance")]
                [Validation(Required=false)]
                public string Balance { get; set; }

                /// <summary>
                /// The ID of the voucher.
                /// </summary>
                [NameInMap("CashCouponId")]
                [Validation(Required=false)]
                public long? CashCouponId { get; set; }

                /// <summary>
                /// The code of the voucher.
                /// </summary>
                [NameInMap("CashCouponNo")]
                [Validation(Required=false)]
                public string CashCouponNo { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the voucher took effect.
                /// </summary>
                [NameInMap("EffectiveTime")]
                [Validation(Required=false)]
                public string EffectiveTime { get; set; }

                /// <summary>
                /// The time when the voucher expired.
                /// </summary>
                [NameInMap("ExpiryTime")]
                [Validation(Required=false)]
                public string ExpiryTime { get; set; }

                /// <summary>
                /// The time when the voucher was released.
                /// </summary>
                [NameInMap("GrantedTime")]
                [Validation(Required=false)]
                public string GrantedTime { get; set; }

                /// <summary>
                /// The denomination of the voucher.
                /// </summary>
                [NameInMap("NominalValue")]
                [Validation(Required=false)]
                public string NominalValue { get; set; }

                /// <summary>
                /// The state of the voucher. Valid values:
                /// 
                /// *   Available: The voucher is valid.
                /// *   Expired: The voucher has expired.
                /// *   Cancelled: The voucher is canceled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
