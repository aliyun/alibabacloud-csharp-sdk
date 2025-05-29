// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class GetQuotaInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetQuotaInfoResponseBodyData Data { get; set; }
        public class GetQuotaInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("activeLicenseCount")]
            [Validation(Required=false)]
            public long? ActiveLicenseCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("durationType")]
            [Validation(Required=false)]
            public int? DurationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("licenseCount")]
            [Validation(Required=false)]
            public long? LicenseCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("maxQps")]
            [Validation(Required=false)]
            public int? MaxQps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>el3SzmCU2p0x4RBc</para>
            /// </summary>
            [NameInMap("productKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("purchaseModel")]
            [Validation(Required=false)]
            public int? PurchaseModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>51505222</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("tokenNumber")]
            [Validation(Required=false)]
            public long? TokenNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B0FC4BC-9E4B-5AD7-9D35-6559BDC0788E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
