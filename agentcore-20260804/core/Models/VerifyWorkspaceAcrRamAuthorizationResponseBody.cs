// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class VerifyWorkspaceAcrRamAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public VerifyWorkspaceAcrRamAuthorizationResponseBodyData Data { get; set; }
        public class VerifyWorkspaceAcrRamAuthorizationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ACR Enterprise instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-1234567890abcdef</para>
            /// </summary>
            [NameInMap("acrInstanceId")]
            [Validation(Required=false)]
            public string AcrInstanceId { get; set; }

            /// <summary>
            /// <para>The policy attachment status for the target repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UNAUTHORIZED</para>
            /// </summary>
            [NameInMap("authorizationStatus")]
            [Validation(Required=false)]
            public string AuthorizationStatus { get; set; }

            /// <summary>
            /// <para>The prerequisite status for access. This is not the Secret Ready status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ELIGIBLE</para>
            /// </summary>
            [NameInMap("eligibilityStatus")]
            [Validation(Required=false)]
            public string EligibilityStatus { get; set; }

            /// <summary>
            /// <para>The stable reason code for unauthorized or unmet conditions. This field is omitted when no reason exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AcrRamUnauthorized</para>
            /// </summary>
            [NameInMap("reasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The human-readable reason. This field is omitted when no reason exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Authorize the Workspace role for this ACR instance.</para>
            /// </summary>
            [NameInMap("reasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            /// <summary>
            /// <para>The shared role name selected by the backend. This value is not editable on the frontend.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunAgentCoreWorkspace-ws-1234567890abcdef12345</para>
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The source of the shared role. This does not indicate that authorization is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WORKSPACE_SHARED</para>
            /// </summary>
            [NameInMap("roleSource")]
            [Validation(Required=false)]
            public string RoleSource { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-1234567890abcdef12345</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

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
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789012</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
