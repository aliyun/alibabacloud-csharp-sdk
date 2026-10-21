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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public VerifyWorkspaceAcrRamAuthorizationResponseBodyData Data { get; set; }
        public class VerifyWorkspaceAcrRamAuthorizationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the ACR Enterprise instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-1234567890abcdef</para>
            /// </summary>
            [NameInMap("acrInstanceId")]
            [Validation(Required=false)]
            public string AcrInstanceId { get; set; }

            /// <summary>
            /// <para>The current attachment status of the policy for the target repository.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UNAUTHORIZED</para>
            /// </summary>
            [NameInMap("authorizationStatus")]
            [Validation(Required=false)]
            public string AuthorizationStatus { get; set; }

            /// <summary>
            /// <para>The access prerequisite status, which does not indicate Secret Ready.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ELIGIBLE</para>
            /// </summary>
            [NameInMap("eligibilityStatus")]
            [Validation(Required=false)]
            public string EligibilityStatus { get; set; }

            /// <summary>
            /// <para>The stable reason code for unauthorized or unmet conditions. This field is omitted if no reason exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AcrRamUnauthorized</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("reasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The user-readable reason. This field is omitted if no reason exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Authorize the Workspace role for this ACR instance.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("reasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            /// <summary>
            /// <para>The name of the shared role selected by the backend. This field is not editable on the frontend.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunAgentCoreWorkspace-ws-1234567890abcdef12345</para>
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The source of the shared role. This does not indicate that authorization is complete.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WORKSPACE_SHARED</para>
            /// </summary>
            [NameInMap("roleSource")]
            [Validation(Required=false)]
            public string RoleSource { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789012</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
