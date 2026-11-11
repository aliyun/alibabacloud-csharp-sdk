// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class PrepareIdentityProviderSCIMResponseBody : TeaModel {
        /// <summary>
        /// <para>The business code. If the request fails, troubleshoot the issue based on the HTTP status code and the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The operation result. For the result structure, see the response parameters of this operation. For asynchronous write operations, the response indicates that the request is accepted and does not guarantee that the background task is completed.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public PrepareIdentityProviderSCIMResponseBodyData Data { get; set; }
        public class PrepareIdentityProviderSCIMResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AgentIdentity receiving configuration. The actual SAML configuration is read on demand only by calling GetIdentityProvider. SCIM query and preparation operations return the actual receiving status and URL.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public PrepareIdentityProviderSCIMResponseBodyDataConfiguration Configuration { get; set; }
            public class PrepareIdentityProviderSCIMResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>The URL configured for the external provisioning system. The presence of a URL does not indicate that the external configuration is completed or that AgentCore synchronization is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/scim/v2">https://example.com/scim/v2</a></para>
                /// </summary>
                [NameInMap("baseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                /// <summary>
                /// <para>The receiving status of AgentIdentity. A value of Enabled indicates that SCIM receiving is enabled. A value of Disabled indicates that SCIM receiving is disabled. This value is not equivalent to the expected value of syncEnabled in AgentCore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The summary of the current credential, including credentialId, status, createTime, and expireTime. It does not include the token.</para>
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
                /// <para>The credential ID. This parameter is required and cannot be empty when you delete a credential. Use the ID returned in the credential list, not the plaintext of the token.</para>
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
            /// <para>The plaintext of the newly issued SCIM token, which is returned only in the current response. If an existing valid credential is reused, an empty string (&quot;&quot;) is returned. In this case, use the saved token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-scim-token</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the request. This code indicates the processing status of the current request and does not represent the final result of the background task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned when the request is accepted or a fault occurs. Verify the asynchronous node result by calling the corresponding query operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Retain this ID for troubleshooting if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of true indicates that the request was successful. For asynchronous write operations, you must continue to query the task results.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
