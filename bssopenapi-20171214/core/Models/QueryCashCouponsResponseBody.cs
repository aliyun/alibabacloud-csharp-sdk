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

        /// <summary>
        /// <para>The data returned.</para>
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
                /// <para>The service to which the voucher is applicable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>All Alibaba Cloud services</para>
                /// </summary>
                [NameInMap("ApplicableProducts")]
                [Validation(Required=false)]
                public string ApplicableProducts { get; set; }

                /// <summary>
                /// <para>The scenario to which the voucher is applicable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pay for the pay-as-you-go bills of Alibaba Cloud services or purchase an instance of an Alibaba Cloud service</para>
                /// </summary>
                [NameInMap("ApplicableScenarios")]
                [Validation(Required=false)]
                public string ApplicableScenarios { get; set; }

                /// <summary>
                /// <para>The remaining quota of the voucher.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("Balance")]
                [Validation(Required=false)]
                public string Balance { get; set; }

                /// <summary>
                /// <para>The ID of the voucher.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34534253254325</para>
                /// </summary>
                [NameInMap("CashCouponId")]
                [Validation(Required=false)]
                public long? CashCouponId { get; set; }

                /// <summary>
                /// <para>The code of the voucher.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Q-b1485def8f04a</para>
                /// </summary>
                [NameInMap("CashCouponNo")]
                [Validation(Required=false)]
                public string CashCouponNo { get; set; }

                /// <summary>
                /// <para>The description of the voucher.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This voucher is used for testing product function</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the voucher took effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-08-02T15:15:50Z</para>
                /// </summary>
                [NameInMap("EffectiveTime")]
                [Validation(Required=false)]
                public string EffectiveTime { get; set; }

                /// <summary>
                /// <para>The time when the voucher expired.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-29T15:15:50Z</para>
                /// </summary>
                [NameInMap("ExpiryTime")]
                [Validation(Required=false)]
                public string ExpiryTime { get; set; }

                /// <summary>
                /// <para>The time when the voucher was released.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-08-02T15:15:50Z</para>
                /// </summary>
                [NameInMap("GrantedTime")]
                [Validation(Required=false)]
                public string GrantedTime { get; set; }

                /// <summary>
                /// <para>The denomination of the voucher.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("NominalValue")]
                [Validation(Required=false)]
                public string NominalValue { get; set; }

                /// <summary>
                /// <para>The state of the voucher. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Available: The voucher is valid.</description></item>
                /// <item><description>Expired: The voucher has expired.</description></item>
                /// <item><description>Cancelled: The voucher is canceled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>147B566E-DB4C-4E43-BDBB-5DB1D9D268DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
