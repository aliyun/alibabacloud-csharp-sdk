// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetTier2CouponApprovalDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTier2CouponApprovalDetailResponseBodyData Data { get; set; }
        public class GetTier2CouponApprovalDetailResponseBodyData : TeaModel {
            [NameInMap("ApplicantInfo")]
            [Validation(Required=false)]
            public GetTier2CouponApprovalDetailResponseBodyDataApplicantInfo ApplicantInfo { get; set; }
            public class GetTier2CouponApprovalDetailResponseBodyDataApplicantInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>UNIVERSAL</para>
                /// </summary>
                [NameInMap("ApplicableProducts")]
                [Validation(Required=false)]
                public string ApplicableProducts { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-01-21 11:24</para>
                /// </summary>
                [NameInMap("ApplicationTime")]
                [Validation(Required=false)]
                public string ApplicationTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALL,BILLING</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test account</para>
                /// </summary>
                [NameInMap("T2PartnerName")]
                [Validation(Required=false)]
                public string T2PartnerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5248516846402795</para>
                /// </summary>
                [NameInMap("T2PartnerUid")]
                [Validation(Required=false)]
                public long? T2PartnerUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-01-21 ~ 2199-12-31</para>
                /// </summary>
                [NameInMap("ValidUntil")]
                [Validation(Required=false)]
                public string ValidUntil { get; set; }

            }

            [NameInMap("ApplicationReason")]
            [Validation(Required=false)]
            public string ApplicationReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0b9a079e17691387754512757e6a1b</para>
            /// </summary>
            [NameInMap("ApplicationSheetId")]
            [Validation(Required=false)]
            public string ApplicationSheetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ApprovalStatus")]
            [Validation(Required=false)]
            public string ApprovalStatus { get; set; }

            [NameInMap("CouponReceiptUidList")]
            [Validation(Required=false)]
            public List<GetTier2CouponApprovalDetailResponseBodyDataCouponReceiptUidList> CouponReceiptUidList { get; set; }
            public class GetTier2CouponApprovalDetailResponseBodyDataCouponReceiptUidList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("NominalValue")]
                [Validation(Required=false)]
                public string NominalValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1703016242044705</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20.00</para>
            /// </summary>
            [NameInMap("RemainingQuota")]
            [Validation(Required=false)]
            public string RemainingQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100.00</para>
            /// </summary>
            [NameInMap("TotalAmount")]
            [Validation(Required=false)]
            public string TotalAmount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0b9a079e17691387754512757e6a1b</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
