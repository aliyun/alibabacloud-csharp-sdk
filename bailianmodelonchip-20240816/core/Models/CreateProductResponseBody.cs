// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class CreateProductResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateProductResponseBodyData Data { get; set; }
        public class CreateProductResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>v7+7WMzYjHhyhb0c6IDL3e1rwCcphld19XzLYcwredVkHOht9et5GhPV45AqCzX7</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>el3SzmCU2p0x4RBc</para>
            /// </summary>
            [NameInMap("productKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10bcac8989aed3f1047b71e6c06ef3ab</para>
            /// </summary>
            [NameInMap("productSecret")]
            [Validation(Required=false)]
            public string ProductSecret { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>503041545</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0abb7ee317248118358433637e749a</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
