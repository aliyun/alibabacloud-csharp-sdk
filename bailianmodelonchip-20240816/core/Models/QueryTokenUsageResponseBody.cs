// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class QueryTokenUsageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryTokenUsageResponseBodyData> Data { get; set; }
        public class QueryTokenUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>oqYVtK7DnaVj4JpbFtghJV2CZy7HwhOI0do3mf8twx9TGCMNNXYBptJ0+ULqO3xD</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("inputToken")]
            [Validation(Required=false)]
            public long? InputToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("outputToken")]
            [Validation(Required=false)]
            public long? OutputToken { get; set; }

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
            /// <para>2025-04-01</para>
            /// </summary>
            [NameInMap("usageTime")]
            [Validation(Required=false)]
            public string UsageTime { get; set; }

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
        /// <para>B08AAA14-AD93-51F6-82AE-82AFAE9375B6</para>
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
