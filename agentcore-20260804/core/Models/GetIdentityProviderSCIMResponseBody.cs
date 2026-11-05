// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetIdentityProviderSCIMResponseBody : TeaModel {
        /// <summary>
        /// <para>The business result code. If the request fails, handle the issue based on the HTTP status code and the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result structure. For details, see the response fields of this operation. The response of an asynchronous write operation indicates that the request is accepted, but does not guarantee that the background task is completed.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIdentityProviderSCIMResponseBodyData Data { get; set; }
        public class GetIdentityProviderSCIMResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual SAML configuration is read back on demand only in GetIdentityProvider. SCIM queries and preparations return the actual receiving status and URL.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public GetIdentityProviderSCIMResponseBodyDataConfiguration Configuration { get; set; }
            public class GetIdentityProviderSCIMResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>The URL configured for the external provisioning system. The presence of a URL does not mean that the external configuration is completed or AgentCore synchronization is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/scim/v2">https://example.com/scim/v2</a></para>
                /// </summary>
                [NameInMap("baseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                /// <summary>
                /// <para>A value of Enabled indicates that SCIM receiving is enabled, and Disabled indicates that it is disabled. This is not equivalent to the expected value of syncEnabled in AgentCore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The original status of the most recent independent SCIM operation task. An empty string (&quot;&quot;) is returned if no historical tasks exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("operationStatus")]
            [Validation(Required=false)]
            public string OperationStatus { get; set; }

            /// <summary>
            /// <para>The SCIM independent configuration status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Do not pass true during CustomSSO initialization. It can only be updated later through UpdateIdentityProviderSCIM. Determine the result in combination with operationStatus.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

        }

        /// <summary>
        /// <para>The processing status of the current request, which is not equivalent to the final result of the background task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request acceptance or error message. For asynchronous tasks, check the task result by using the corresponding query operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Used to associate this call with troubleshooting. Keep the ID if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current request is successful. A value of true indicates that the request is processed successfully. For asynchronous writes, you must continue to query the task results.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
