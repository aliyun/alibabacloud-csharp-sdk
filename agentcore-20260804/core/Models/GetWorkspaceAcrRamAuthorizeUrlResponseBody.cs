// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetWorkspaceAcrRamAuthorizeUrlResponseBody : TeaModel {
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
        public GetWorkspaceAcrRamAuthorizeUrlResponseBodyData Data { get; set; }
        public class GetWorkspaceAcrRamAuthorizeUrlResponseBodyData : TeaModel {
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
            /// <para>The RAM authorization URL used to create or append target ACR permissions for the shared role.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://ram.console.aliyun.com/authorize?request=%7B%22referrer%22%3A%22AgentCore%22%2C%22payloads%22%3A%5B%7B%22missionId%22%3A%22AgentCore.CustomRoleForOSSObjectRestore%22%2C%22roleName%22%3A%22AliyunAgentCoreWorkspace-ws-1234567890abcdef12345%22%2C%22rolePolicies%22%3A%5B%7B%22policyName%22%3A%22AgentCoreAcrPull-63373f3802583663d49465d8061e410a899d8f2936b8fc0cb9ec905b71f273c6%22%2C%22policyType%22%3A%22Custom%22%2C%22templateId%22%3A%22CrPullInstanceImage%22%2C%22templateValue%22%3A%7B%22crInstance%22%3A%22acs%3Acr%3Acn-hangzhou%3A1234567890123456%3Ainstance%2Fcri-1234567890abcdef%22%2C%22crRepository%22%3A%22acs%3Acr%3Acn-hangzhou%3A1234567890123456%3Arepository%2Fcri-1234567890abcdef%2Fexample%2Fagent-image%22%7D%7D%5D%7D%5D%7D">https://ram.console.aliyun.com/authorize?request=%7B%22referrer%22%3A%22AgentCore%22%2C%22payloads%22%3A%5B%7B%22missionId%22%3A%22AgentCore.CustomRoleForOSSObjectRestore%22%2C%22roleName%22%3A%22AliyunAgentCoreWorkspace-ws-1234567890abcdef12345%22%2C%22rolePolicies%22%3A%5B%7B%22policyName%22%3A%22AgentCoreAcrPull-63373f3802583663d49465d8061e410a899d8f2936b8fc0cb9ec905b71f273c6%22%2C%22policyType%22%3A%22Custom%22%2C%22templateId%22%3A%22CrPullInstanceImage%22%2C%22templateValue%22%3A%7B%22crInstance%22%3A%22acs%3Acr%3Acn-hangzhou%3A1234567890123456%3Ainstance%2Fcri-1234567890abcdef%22%2C%22crRepository%22%3A%22acs%3Acr%3Acn-hangzhou%3A1234567890123456%3Arepository%2Fcri-1234567890abcdef%2Fexample%2Fagent-image%22%7D%7D%5D%7D%5D%7D</a></para>
            /// </summary>
            [NameInMap("authorizeUrl")]
            [Validation(Required=false)]
            public string AuthorizeUrl { get; set; }

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
