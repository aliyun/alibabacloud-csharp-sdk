// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class ResetApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The API key information.</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public ResetApiKeyResponseBodyApiKey ApiKey { get; set; }
        public class ResetApiKeyResponseBodyApiKey : TeaModel {
            /// <summary>
            /// <para>API Key ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2965964</para>
            /// </summary>
            [NameInMap("apiKeyId")]
            [Validation(Required=false)]
            public long? ApiKeyId { get; set; }

            /// <summary>
            /// <para>The value of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-ws-djI.8O7dkfkW2aICctnid4u4</para>
            /// </summary>
            [NameInMap("apiKeyValue")]
            [Validation(Required=false)]
            public string ApiKeyValue { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-b2d30f148c236908</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>36045E0A-551D-592D-B1BC-4C56596CE59E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
