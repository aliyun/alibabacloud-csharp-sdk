// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateIdentityProviderSCIMCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The business result code. Combine it with the HTTP status and message for handling upon failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The operation result. For the result structure, see the response fields of this operation. The response of an asynchronous write operation indicates that the request is accepted, but does not guarantee that the background task is completed.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateIdentityProviderSCIMCredentialResponseBodyData Data { get; set; }
        public class CreateIdentityProviderSCIMCredentialResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AgentIdentity reception configuration. The actual SAML configuration is read back on demand only in GetIdentityProvider. SCIM queries and preparations return the actual reception status and URL.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public CreateIdentityProviderSCIMCredentialResponseBodyDataConfiguration Configuration { get; set; }
            public class CreateIdentityProviderSCIMCredentialResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>The URL configured for the external provisioning system. The presence of an address does not mean that the external configuration is completed or AC synchronization is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/scim/v2">https://example.com/scim/v2</a></para>
                /// </summary>
                [NameInMap("baseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                /// <summary>
                /// <para>The AgentIdentity reception status. Enabled indicates that SCIM reception is enabled, and Disabled indicates that it is disabled. This is not equivalent to the expected value of syncEnabled in AC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The current credential summary, including credentialId, status, createTime, and expireTime. It does not include the token, which cannot be retrieved repeatedly.</para>
            /// </summary>
            [NameInMap("credential")]
            [Validation(Required=false)]
            public CreateIdentityProviderSCIMCredentialResponseBodyDataCredential Credential { get; set; }
            public class CreateIdentityProviderSCIMCredentialResponseBodyDataCredential : TeaModel {
                /// <summary>
                /// <para>The creation time returned by AgentIdentity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-26T00:00:00Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The credential ID. It must be non-empty when deleting a credential. Use the ID returned in the credential list, not the plaintext token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>credential-example</para>
                /// </summary>
                [NameInMap("credentialId")]
                [Validation(Required=false)]
                public string CredentialId { get; set; }

                /// <summary>
                /// <para>The expiration time returned by AgentIdentity. Only credentials that are Enabled and have not expired are considered available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2027-10-26T00:00:00Z</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The AgentIdentity credential status. Only credentials that are Enabled and have not expired are considered available. This field is not the operationStatus of a SCIM task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The token. The plaintext is returned only when a new credential is created. It is null when prepare reuses a valid credential. It cannot be retrieved again from the list. If the response is lost, query the list first instead of automatically re-issuing it. Do not write it to logs or frontend persistent cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-scim-token</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the current request. It is not equivalent to the final result of the background task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Task result message, indicating request acceptance or an error. For asynchronous tasks, check task results by using the corresponding query operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. It is used to associate the current call with troubleshooting. Keep it when a failure occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current request is successful. A value of true indicates that the request is processed successfully. For asynchronous writes, you still need to continue querying the task results.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
