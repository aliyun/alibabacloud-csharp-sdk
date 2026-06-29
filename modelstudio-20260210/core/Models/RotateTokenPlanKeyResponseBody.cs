// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class RotateTokenPlanKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RotateTokenPlanKeyResponseBodyData Data { get; set; }
        public class RotateTokenPlanKeyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The API Key ID, which is system-generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_123456</para>
            /// </summary>
            [NameInMap("ApiKeyId")]
            [Validation(Required=false)]
            public string ApiKeyId { get; set; }

            /// <summary>
            /// <para>The new masked_api_key returned by BaiLian, such as sk_***cdef.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk_***6</para>
            /// </summary>
            [NameInMap("MaskedApiKey")]
            [Validation(Required=false)]
            public string MaskedApiKey { get; set; }

            /// <summary>
            /// <para>The new plaintext API Key returned by BaiLian. This value is returned only once during the reset operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-ws.abc123456</para>
            /// </summary>
            [NameInMap("PlainApiKey")]
            [Validation(Required=false)]
            public string PlainApiKey { get; set; }

            /// <summary>
            /// <para>The time when the API key was reset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-18T03:19:17Z</para>
            /// </summary>
            [NameInMap("ResetAt")]
            [Validation(Required=false)]
            public string ResetAt { get; set; }

            /// <summary>
            /// <para>The source_id returned by BaiLian.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
