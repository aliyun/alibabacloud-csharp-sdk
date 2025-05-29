// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class UpdateQuotaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateQuotaResponseBodyData Data { get; set; }
        public class UpdateQuotaResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>g6RD6uvFYNZv44ky</para>
            /// </summary>
            [NameInMap("orderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2oImhCz4f8XCviiM</para>
            /// </summary>
            [NameInMap("productKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>520539530998273</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

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
        /// <b>Example:</b>
        /// <para>89946BAA-E4E1-5114-8A5E-A542FEDC9B16</para>
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
