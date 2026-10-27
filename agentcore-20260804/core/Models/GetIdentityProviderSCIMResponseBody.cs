// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetIdentityProviderSCIMResponseBody : TeaModel {
        /// <summary>
        /// <para>If the request fails, handle the error based on the HTTP status code and the message.</para>
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
                /// <para>The URL configured for the external provisioning system. The presence of a URL does not mean that the external configuration is complete or that AC synchronization is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/scim/v2">https://example.com/scim/v2</a></para>
                /// </summary>
                [NameInMap("baseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                /// <summary>
                /// <para>The receiving status of AgentIdentity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enabled: SCIM receiving is enabled.</description></item>
                /// <item><description>Disabled: SCIM receiving is disabled.
                /// This is not equivalent to the expected value of syncEnabled for AC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Independent of the SAML logon binding status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PENDING: Waiting to be executed.</description></item>
            /// <item><description>RUNNING: Being executed.</description></item>
            /// <item><description>PAUSED: Paused.</description></item>
            /// <item><description>SUCCESS: Succeeded.</description></item>
            /// <item><description>FAILED: Failed.</description></item>
            /// <item><description>CANCELED: Canceled.
            /// If there are no tasks, null is returned or this parameter is not returned. This parameter only indicates the most recent SCIM switch and the first full import task when it is enabled. It does not indicate credential issuance, external provisioning connection tests, or the health of continuous incremental synchronization. The client polls this operation when the status is PENDING or RUNNING.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("operationStatus")]
            [Validation(Required=false)]
            public string OperationStatus { get; set; }

            /// <summary>
            /// <para>UNCONFIGURED：尚未准备完成；WAITING_CONFIGURATION：接收 Enabled、有效 HTTPS URL 和至少一个有效 Token 均已具备，等待外部配置并确认启用；UPDATING：启用或停用任务 PENDING/RUNNING；READY：同步已启用且本次启用任务成功，接收、URL 和 Token 仍可用；DISABLED：停用任务成功，保留配置、凭据和用户；UPDATE_FAILED：操作失败、暂停、取消，或期望启用时配置／凭据不可用。与 SAML/OIDC 状态独立，READY 不证明 Matrix 执行或持续增量链路已验收。</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Specifies whether local synchronization is expected. Do not set this parameter to true during CustomSSO initialization. You can only update this parameter by calling UpdateIdentityProviderSCIM. Determine the result based on operationStatus.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

        }

        /// <summary>
        /// <para>The processing status of the current request. This is not equivalent to the final result of the background task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request acceptance or error message. For the results of an asynchronous task, check the corresponding query operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Used to associate the current call with troubleshooting. Retain this parameter when a failure occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current request is successful. A value of true indicates that the current request is processed successfully. For asynchronous writes, you still need to continue querying the task results.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
