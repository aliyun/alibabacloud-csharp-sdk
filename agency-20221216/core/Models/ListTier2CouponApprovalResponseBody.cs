// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ListTier2CouponApprovalResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTier2CouponApprovalResponseBodyData> Data { get; set; }
        public class ListTier2CouponApprovalResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>d54ca949-9b88-4514-add3-c6029c4027f4</para>
            /// </summary>
            [NameInMap("ApplicationSheetId")]
            [Validation(Required=false)]
            public string ApplicationSheetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-21 11:24</para>
            /// </summary>
            [NameInMap("ApplicationTime")]
            [Validation(Required=false)]
            public string ApplicationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApprovalStatus")]
            [Validation(Required=false)]
            public string ApprovalStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test account</para>
            /// </summary>
            [NameInMap("T2PartnerName")]
            [Validation(Required=false)]
            public string T2PartnerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5248516956402795</para>
            /// </summary>
            [NameInMap("T2PartnerUid")]
            [Validation(Required=false)]
            public long? T2PartnerUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("TotalAmount")]
            [Validation(Required=false)]
            public string TotalAmount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
