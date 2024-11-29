// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetCouponTemplateDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCouponTemplateDetailResponseBodyData Data { get; set; }
        public class GetCouponTemplateDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>UNIVERSAL</para>
            /// </summary>
            [NameInMap("ApplicableProducts")]
            [Validation(Required=false)]
            public string ApplicableProducts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun_poc</para>
            /// </summary>
            [NameInMap("CostBearer")]
            [Validation(Required=false)]
            public string CostBearer { get; set; }

            [NameInMap("CouponDescription")]
            [Validation(Required=false)]
            public string CouponDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-21 18:18:22</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Denomination")]
            [Validation(Required=false)]
            public double? Denomination { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LimitPerPerson")]
            [Validation(Required=false)]
            public int? LimitPerPerson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALL,BILLING</para>
            /// </summary>
            [NameInMap("PurchaseType")]
            [Validation(Required=false)]
            public string PurchaseType { get; set; }

            [NameInMap("ReasonForApplication")]
            [Validation(Required=false)]
            public string ReasonForApplication { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>APPROVED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1576</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ValidUntil")]
            [Validation(Required=false)]
            public string ValidUntil { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ValidUntilType")]
            [Validation(Required=false)]
            public string ValidUntilType { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
