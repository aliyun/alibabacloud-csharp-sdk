// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetIdentityProviderSCIMResponseBody : TeaModel {
        /// <summary>
        /// <para>The business result code. Use this code along with the HTTP status code and message for error handling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The SCIM actual configuration, expected synchronization switch, and independent operation status. For the result structure, see the response fields of this operation. The response of an asynchronous write operation indicates that the request is accepted, but does not guarantee that the background task is complete.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIdentityProviderSCIMResponseBodyData Data { get; set; }
        public class GetIdentityProviderSCIMResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual receiving status and URL. The actual SAML configuration is read back on demand only in GetIdentityProvider. SCIM queries and preparations return the actual receiving status and URL.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public GetIdentityProviderSCIMResponseBodyDataConfiguration Configuration { get; set; }
            public class GetIdentityProviderSCIMResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>The URL configured for the external provisioning system. The presence of a URL does not indicate that external configuration is complete or that AC synchronization is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/scim/v2">https://example.com/scim/v2</a></para>
                /// </summary>
                [NameInMap("baseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                /// <summary>
                /// <para>The AgentIdentity receiving status. Enabled indicates that SCIM receiving is enabled. Disabled indicates that it is disabled. This is not equivalent to the expected value of syncEnabled for AC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The status of the most recent SCIM operation task. This status is independent of the SAML logon binding status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PENDING: Waiting for execution.</description></item>
            /// <item><description>RUNNING: Executing.</description></item>
            /// <item><description>PAUSED: Paused.</description></item>
            /// <item><description>SUCCESS: Succeeded.</description></item>
            /// <item><description>FAILED: Failed.</description></item>
            /// <item><description>CANCELED: Canceled.
            /// If there are no tasks, it returns null or is not returned. This status only represents the most recent SCIM switch and the initial full import task when enabled. It does not indicate credential issuance, external provisioning connection tests, or continuous incremental synchronization health. Clients poll this operation when the status is PENDING or RUNNING.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("operationStatus")]
            [Validation(Required=false)]
            public string OperationStatus { get; set; }

            /// <summary>
            /// <para>The independent SCIM configuration status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>UNCONFIGURED: Preparation is not complete.</description></item>
            /// <item><description>WAITING_CONFIGURATION: Receiving is enabled, a valid HTTPS URL and at least one valid token are available, waiting for external configuration and enablement confirmation.</description></item>
            /// <item><description>UPDATING: The enablement or disablement task is PENDING or RUNNING.</description></item>
            /// <item><description>READY: Synchronization is enabled and the current enablement task succeeded, and the receiving end, URL, and token are still available.</description></item>
            /// <item><description>DISABLED: The disablement task succeeded, and the configuration, credentials, and users are retained.</description></item>
            /// <item><description>UPDATE_FAILED: The operation failed, was paused, was canceled, or the configuration and credentials are unavailable when enablement is expected.
            /// This status is independent of the SAML or OIDC status. READY does not prove that Matrix execution or the continuous incremental link has been accepted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Specifies whether local synchronization is expected. You must determine whether it takes effect based on the actual configuration and task records. Do not set this parameter to true during CustomSSO initialization. You can only update it later by calling UpdateIdentityProviderSCIM, and determine the result based on operationStatus.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the current request. This code indicates the processing status of the request and is not equivalent to the final result of the background task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Task result message. It indicates that the request is accepted or provides an error message. For asynchronous tasks, you must check task results by calling the corresponding query operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. It is used to associate the current call with troubleshooting. Retain this ID when a failure occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current request is successful. A value of true indicates that the request is processed successfully. For asynchronous write operations, you must continue to query the task results.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
