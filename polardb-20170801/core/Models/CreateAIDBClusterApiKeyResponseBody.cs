// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAIDBClusterApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The API key.</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public CreateAIDBClusterApiKeyResponseBodyApiKey ApiKey { get; set; }
        public class CreateAIDBClusterApiKeyResponseBodyApiKey : TeaModel {
            /// <summary>
            /// <para>The API key for the model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6c4b1f0317cd4fd7a5b446d3503d**</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <para>The time is displayed in ISO 8601 format in the UTC time zone (format: YYYY-MM-DDTHH:mm:ssZ).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-12T03:41:53Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The API key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>393</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The status of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2281C6C9-CBAB-1AFD-8400-670750CF6025_2212</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
