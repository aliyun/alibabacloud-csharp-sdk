// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetServiceEndpointApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value is SUCCESS if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The active API key information of the service endpoint.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetServiceEndpointApiKeyResponseBodyData Data { get; set; }
        public class GetServiceEndpointApiKeyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The active API key of the service endpoint. The service reads this value in real time from the gateway consumer, and AgentCore does not persist the plaintext. When calling the service endpoint, place this value in the request header specified by apiKeyName. Do not log this value or expose it in public configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-api-key-value</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The API key fingerprint, which consists of the first 12 lowercase hexadecimal characters of the SHA-256 digest of the API key. It can be used to identify the key version but cannot replace the API key for authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b2520bf19231</para>
            /// </summary>
            [NameInMap("apiKeyFingerprint")]
            [Validation(Required=false)]
            public string ApiKeyFingerprint { get; set; }

            /// <summary>
            /// <para>The name of the HTTP request header used to pass the API key. Currently, this is fixed to x-api-key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x-api-key</para>
            /// </summary>
            [NameInMap("apiKeyName")]
            [Validation(Required=false)]
            public string ApiKeyName { get; set; }

            /// <summary>
            /// <para>The delivery location of the API key. Currently, this is fixed to Header, which indicates that the API key is passed through an HTTP request header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Header</para>
            /// </summary>
            [NameInMap("apiKeySource")]
            [Validation(Required=false)]
            public string ApiKeySource { get; set; }

            /// <summary>
            /// <para>The authentication type of the service endpoint. Valid values: NONE (authentication is disabled) and API_KEY (API key authentication is used). This operation succeeds only when the authentication type is API_KEY. Therefore, a successful response always returns API_KEY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API_KEY</para>
            /// </summary>
            [NameInMap("authenticationType")]
            [Validation(Required=false)]
            public string AuthenticationType { get; set; }

            /// <summary>
            /// <para>The ID of the service endpoint.</para>
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
        /// <para>The HTTP status code. The value is 200 if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message. The value is success if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to troubleshoot and trace the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. The value is true if the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
