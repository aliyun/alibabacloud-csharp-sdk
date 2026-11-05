// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class PrepareIdentityProviderSCIMResponseBody : TeaModel {
        /// <summary>
        /// <para>The business result code. If the call fails, handle the error based on the HTTP status code and the message.</para>
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
        public PrepareIdentityProviderSCIMResponseBodyData Data { get; set; }
        public class PrepareIdentityProviderSCIMResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual SAML configuration is read on demand only by calling GetIdentityProvider. SCIM query and preparation operations return the actual receiving status and URL.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public PrepareIdentityProviderSCIMResponseBodyDataConfiguration Configuration { get; set; }
            public class PrepareIdentityProviderSCIMResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>The URL configured for the external provisioning system. The presence of a URL does not indicate that the external configuration is completed or AgentCore synchronization is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/scim/v2">https://example.com/scim/v2</a></para>
                /// </summary>
                [NameInMap("baseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                /// <summary>
                /// <para>The receiving status of AgentIdentity. A value of Enabled indicates that SCIM receiving is enabled. A value of Disabled indicates that SCIM receiving is disabled. This status is not equivalent to the expected value of syncEnabled in AgentCore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The current credential summary, including credentialId, status, createTime, and expireTime. The token is not included because it cannot be repeatedly obtained.</para>
            /// </summary>
            [NameInMap("credential")]
            [Validation(Required=false)]
            public PrepareIdentityProviderSCIMResponseBodyDataCredential Credential { get; set; }
            public class PrepareIdentityProviderSCIMResponseBodyDataCredential : TeaModel {
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
                /// <para>The credential ID. This parameter is required when you delete a credential. Use the ID returned in the credential list, not the plaintext of the token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>credential-example</para>
                /// </summary>
                [NameInMap("credentialId")]
                [Validation(Required=false)]
                public string CredentialId { get; set; }

                /// <summary>
                /// <para>The expiration time returned by AgentIdentity. Only credentials with the status of Enabled that have not expired are considered available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2027-10-26T00:00:00Z</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The credential status of AgentIdentity. Only credentials with the status of Enabled that have not expired are considered available. This field is not the operationStatus of the SCIM task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The plaintext of the newly issued SCIM token. The plaintext is returned only in the current response. If an existing valid credential is reused, an empty string (&quot;&quot;) is returned. In this case, use the saved token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-scim-token</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <para>The processing status of the current request. This status does not indicate the final result of the background task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request acceptance or error message. For asynchronous tasks, you must check the task result by calling the corresponding query operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID to associate the current call with troubleshooting. Keep the ID if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current request is successful. A value of true indicates that the request is processed successfully. For asynchronous write operations, you must continue to query the task result.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
