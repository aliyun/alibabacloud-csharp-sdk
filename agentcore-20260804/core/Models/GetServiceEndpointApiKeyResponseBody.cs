// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetServiceEndpointApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value is SUCCESS when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The currently active API Key information for the service endpoint.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetServiceEndpointApiKeyResponseBodyData Data { get; set; }
        public class GetServiceEndpointApiKeyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The currently active API Key for the service endpoint. The service reads this value from the gateway consumer in real time. AgentCore does not persist the plaintext. When calling the service endpoint, include this value in the request header specified by apiKeyName. Do not log this value or expose it in public configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-api-key-value</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The API Key fingerprint, which consists of the first 12 lowercase hexadecimal characters of the SHA-256 digest of the API Key. It can be used to identify the key version but cannot replace the API Key for authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b2520bf19231</para>
            /// </summary>
            [NameInMap("apiKeyFingerprint")]
            [Validation(Required=false)]
            public string ApiKeyFingerprint { get; set; }

            /// <summary>
            /// <para>The name of the HTTP request header used to pass the API Key. The value is currently fixed to x-api-key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x-api-key</para>
            /// </summary>
            [NameInMap("apiKeyName")]
            [Validation(Required=false)]
            public string ApiKeyName { get; set; }

            /// <summary>
            /// <para>The location where the API Key is passed. The value is currently fixed to Header, indicating that the API Key is passed through an HTTP request header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Header</para>
            /// </summary>
            [NameInMap("apiKeySource")]
            [Validation(Required=false)]
            public string ApiKeySource { get; set; }

            /// <summary>
            /// <para>The authentication type of the service endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NONE: Authentication is not enabled.</description></item>
            /// <item><description>API_KEY: API Key authentication is used.</description></item>
            /// </list>
            /// <para>This operation succeeds only when the authentication type is API_KEY. Therefore, the value API_KEY is always returned in a successful response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API_KEY</para>
            /// </summary>
            [NameInMap("authenticationType")]
            [Validation(Required=false)]
            public string AuthenticationType { get; set; }

            /// <summary>
            /// <para>The service endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>se-1</para>
            /// </summary>
            [NameInMap("serviceEndpointId")]
            [Validation(Required=false)]
            public string ServiceEndpointId { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the service endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-1</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. The value is 200 when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message. The value is success when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, used for troubleshooting and tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. The value is true when the request succeeds.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
