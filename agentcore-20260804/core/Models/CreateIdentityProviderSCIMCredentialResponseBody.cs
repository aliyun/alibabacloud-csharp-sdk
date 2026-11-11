// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateIdentityProviderSCIMCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The business result code. If a failure occurs, handle the error based on the HTTP status code and the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The operation result. For the result structure, see the response fields of this operation. The response of an asynchronous write operation indicates that the request is accepted, which does not ensure that the background task is complete.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateIdentityProviderSCIMCredentialResponseBodyData Data { get; set; }
        public class CreateIdentityProviderSCIMCredentialResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual SAML configuration is read on demand only by calling GetIdentityProvider. SCIM query and preparation return the actual receiving status and URL.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public CreateIdentityProviderSCIMCredentialResponseBodyDataConfiguration Configuration { get; set; }
            public class CreateIdentityProviderSCIMCredentialResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>The URL configured for the external provisioning system. The presence of a URL does not indicate that the external configuration is complete or that AgentCore synchronization is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/scim/v2">https://example.com/scim/v2</a></para>
                /// </summary>
                [NameInMap("baseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                /// <summary>
                /// <para>The receiving status of AgentIdentity. Enabled indicates that SCIM receiving is enabled, and Disabled indicates that SCIM receiving is disabled. This status is not equivalent to the expected value of syncEnabled in AgentCore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The current credential summary, including credentialId, status, createTime, and expireTime. The token is not included and cannot be retrieved again.</para>
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
                /// <para>The credential ID. This parameter is required when you delete a credential. Use the ID returned in the credential list, not the plaintext token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>credential-example</para>
                /// </summary>
                [NameInMap("credentialId")]
                [Validation(Required=false)]
                public string CredentialId { get; set; }

                /// <summary>
                /// <para>The expiration time returned by AgentIdentity. Only credentials that are enabled and not expired are considered available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2027-10-26T00:00:00Z</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The credential status of AgentIdentity. Only credentials that are enabled and not expired are considered available. This field is not the operationStatus of a SCIM task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The plaintext token. The plaintext is returned only when a new credential is created. If the prepare operation reuses a valid credential, this value is null. The token cannot be retrieved from the list. If the response is lost, query the list first. The token is not automatically reissued and is not written to logs or frontend persistent cache.</para>
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
        /// <para>The request acceptance or error message. You must verify the result of the asynchronous task by calling the corresponding query operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID to associate the current call with troubleshooting. Keep the ID if a failure occurs.</para>
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
