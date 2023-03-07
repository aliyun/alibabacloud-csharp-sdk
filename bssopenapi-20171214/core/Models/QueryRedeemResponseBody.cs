// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRedeemResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRedeemResponseBodyData Data { get; set; }
        public class QueryRedeemResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The details of the redemption coupon.
            /// </summary>
            [NameInMap("Redeem")]
            [Validation(Required=false)]
            public QueryRedeemResponseBodyDataRedeem Redeem { get; set; }
            public class QueryRedeemResponseBodyDataRedeem : TeaModel {
                [NameInMap("Redeem")]
                [Validation(Required=false)]
                public List<QueryRedeemResponseBodyDataRedeemRedeem> Redeem { get; set; }
                public class QueryRedeemResponseBodyDataRedeemRedeem : TeaModel {
                    /// <summary>
                    /// The services to which the redemption coupon is applicable.
                    /// </summary>
                    [NameInMap("ApplicableProducts")]
                    [Validation(Required=false)]
                    public string ApplicableProducts { get; set; }

                    /// <summary>
                    /// The balance of the redemption coupon.
                    /// </summary>
                    [NameInMap("Balance")]
                    [Validation(Required=false)]
                    public string Balance { get; set; }

                    /// <summary>
                    /// The time when the redemption coupon took effect.
                    /// </summary>
                    [NameInMap("EffectiveTime")]
                    [Validation(Required=false)]
                    public string EffectiveTime { get; set; }

                    /// <summary>
                    /// The time when the redemption coupon expired.
                    /// </summary>
                    [NameInMap("ExpiryTime")]
                    [Validation(Required=false)]
                    public string ExpiryTime { get; set; }

                    /// <summary>
                    /// The time when the redemption coupon was issued.
                    /// </summary>
                    [NameInMap("GrantedTime")]
                    [Validation(Required=false)]
                    public string GrantedTime { get; set; }

                    /// <summary>
                    /// The nominal value of the redemption coupon.
                    /// </summary>
                    [NameInMap("NominalValue")]
                    [Validation(Required=false)]
                    public string NominalValue { get; set; }

                    /// <summary>
                    /// The ID of the redemption coupon.
                    /// </summary>
                    [NameInMap("RedeemId")]
                    [Validation(Required=false)]
                    public string RedeemId { get; set; }

                    /// <summary>
                    /// The number of the redemption coupon.
                    /// </summary>
                    [NameInMap("RedeemNo")]
                    [Validation(Required=false)]
                    public string RedeemNo { get; set; }

                    /// <summary>
                    /// The specifications of the redemption coupon.
                    /// </summary>
                    [NameInMap("Specification")]
                    [Validation(Required=false)]
                    public string Specification { get; set; }

                    /// <summary>
                    /// The status of the redemption coupon. Valid values:
                    /// 
                    /// *   Generated
                    /// *   CallBack
                    /// *   RefundPending
                    /// *   Canceled
                    /// *   Order_Canceled
                    /// *   ActivePending
                    /// *   ActiveSuccess
                    /// *   ExchangePending
                    /// *   ExchangeSuccess
                    /// *   Expired
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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
