// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetTier2CouponApprovalDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success. Other values indicate error codes. For more information, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTier2CouponApprovalDetailResponseBodyData Data { get; set; }
        public class GetTier2CouponApprovalDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The basic information of the application.</para>
            /// </summary>
            [NameInMap("ApplicantInfo")]
            [Validation(Required=false)]
            public GetTier2CouponApprovalDetailResponseBodyDataApplicantInfo ApplicantInfo { get; set; }
            public class GetTier2CouponApprovalDetailResponseBodyDataApplicantInfo : TeaModel {
                /// <summary>
                /// <para>The applicable products. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>UNIVERSAL: All products.</description></item>
                /// <item><description>A specific commodity code.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UNIVERSAL</para>
                /// </summary>
                [NameInMap("ApplicableProducts")]
                [Validation(Required=false)]
                public string ApplicableProducts { get; set; }

                /// <summary>
                /// <para>The timestamp when the application was submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-21 11:24</para>
                /// </summary>
                [NameInMap("ApplicationTime")]
                [Validation(Required=false)]
                public string ApplicationTime { get; set; }

                /// <summary>
                /// <para>The order type for which the coupon is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ALL: Alibaba Cloud subscription.</description></item>
                /// <item><description>BILLING: Alibaba Cloud pay-as-you-go bills.</description></item>
                /// <item><description>ALL,BILLING: Alibaba Cloud subscription and pay-as-you-go bills.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALL,BILLING</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <para>The name of the tier-2 distributor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test account</para>
                /// </summary>
                [NameInMap("T2PartnerName")]
                [Validation(Required=false)]
                public string T2PartnerName { get; set; }

                /// <summary>
                /// <para>The UID of the tier-2 distributor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5248516846402795</para>
                /// </summary>
                [NameInMap("T2PartnerUid")]
                [Validation(Required=false)]
                public long? T2PartnerUid { get; set; }

                /// <summary>
                /// <para>The validity period, which can be a number of valid days or a valid time range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-21 ~ 2199-12-31</para>
                /// </summary>
                [NameInMap("ValidUntil")]
                [Validation(Required=false)]
                public string ValidUntil { get; set; }

            }

            /// <summary>
            /// <para>The reason for the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reason for application</para>
            /// </summary>
            [NameInMap("ApplicationReason")]
            [Validation(Required=false)]
            public string ApplicationReason { get; set; }

            /// <summary>
            /// <para>The ID of the application form.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0b9a079e17691387754512757e6a1b</para>
            /// </summary>
            [NameInMap("ApplicationSheetId")]
            [Validation(Required=false)]
            public string ApplicationSheetId { get; set; }

            /// <summary>
            /// <para>The approval status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Revoked.</description></item>
            /// <item><description>2: Under review.</description></item>
            /// <item><description>3: Rejected.</description></item>
            /// <item><description>4: Approved.</description></item>
            /// <item><description>5: Approved but issuance failed.</description></item>
            /// <item><description>8: Pending.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ApprovalStatus")]
            [Validation(Required=false)]
            public string ApprovalStatus { get; set; }

            /// <summary>
            /// <para>The list of customer UIDs that receive the coupons.</para>
            /// </summary>
            [NameInMap("CouponReceiptUidList")]
            [Validation(Required=false)]
            public List<GetTier2CouponApprovalDetailResponseBodyDataCouponReceiptUidList> CouponReceiptUidList { get; set; }
            public class GetTier2CouponApprovalDetailResponseBodyDataCouponReceiptUidList : TeaModel {
                /// <summary>
                /// <para>The denomination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("NominalValue")]
                [Validation(Required=false)]
                public string NominalValue { get; set; }

                /// <summary>
                /// <para>The UID of the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1703016242044705</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

            }

            /// <summary>
            /// <para>The estimated remaining quota of PoC coupon benefits for new partner customers after the coupons are issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20.00</para>
            /// </summary>
            [NameInMap("RemainingQuota")]
            [Validation(Required=false)]
            public string RemainingQuota { get; set; }

            /// <summary>
            /// <para>The requested amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.00</para>
            /// </summary>
            [NameInMap("TotalAmount")]
            [Validation(Required=false)]
            public string TotalAmount { get; set; }

        }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b9a079e17691387754512757e6a1b</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
