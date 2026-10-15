// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCashCouponsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCashCouponsResponseBodyData Data { get; set; }
        public class QueryCashCouponsResponseBodyData : TeaModel {
            [NameInMap("CashCoupon")]
            [Validation(Required=false)]
            public List<QueryCashCouponsResponseBodyDataCashCoupon> CashCoupon { get; set; }
            public class QueryCashCouponsResponseBodyDataCashCoupon : TeaModel {
                [NameInMap("ApplicableProducts")]
                [Validation(Required=false)]
                public string ApplicableProducts { get; set; }

                [NameInMap("ApplicableScenarios")]
                [Validation(Required=false)]
                public string ApplicableScenarios { get; set; }

                [NameInMap("Balance")]
                [Validation(Required=false)]
                public string Balance { get; set; }

                [NameInMap("CashCouponId")]
                [Validation(Required=false)]
                public long? CashCouponId { get; set; }

                [NameInMap("CashCouponNo")]
                [Validation(Required=false)]
                public string CashCouponNo { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EffectiveTime")]
                [Validation(Required=false)]
                public string EffectiveTime { get; set; }

                [NameInMap("ExpiryTime")]
                [Validation(Required=false)]
                public string ExpiryTime { get; set; }

                [NameInMap("GrantedTime")]
                [Validation(Required=false)]
                public string GrantedTime { get; set; }

                [NameInMap("NominalValue")]
                [Validation(Required=false)]
                public string NominalValue { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The execution result message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>147B566E-DB4C-4E43-BDBB-5DB1D9D268DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values: true (the call is successful) and false (the call fails).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
