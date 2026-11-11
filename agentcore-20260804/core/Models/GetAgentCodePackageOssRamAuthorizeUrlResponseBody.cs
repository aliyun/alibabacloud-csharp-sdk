// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetAgentCodePackageOssRamAuthorizeUrlResponseBody : TeaModel {
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
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAgentCodePackageOssRamAuthorizeUrlResponseBodyData Data { get; set; }
        public class GetAgentCodePackageOssRamAuthorizeUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The RAM authorization URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://ram.console.aliyun.com/authorize?request=%7B%22referrer%22%3A%22AgentCore%22%2C%22payloads%22%3A%5B%7B%22missionId%22%3A%22AgentCore.CustomRoleForOSSObjectRestore%22%2C%22roleName%22%3A%22AliyunAgentCoreWorkspace-ws-a1b2c3d4e5f6%22%2C%22rolePolicies%22%3A%5B%7B%22policyName%22%3A%22agentcore-oss-mount-policy-my-agent-bucket%22%2C%22policyType%22%3A%22Custom%22%2C%22templateId%22%3A%22OSSObjectRestoreCustom%22%2C%22templateValue%22%3A%7B%22ossBucket%22%3A%22acs%3Aoss%3A%2A%3A1234567890123456%3Amy-agent-bucket%22%2C%22ossBucketObject%22%3A%22acs%3Aoss%3A%2A%3A1234567890123456%3Amy-agent-bucket%2F%2A%22%7D%7D%5D%7D%5D%7D">https://ram.console.aliyun.com/authorize?request=%7B%22referrer%22%3A%22AgentCore%22%2C%22payloads%22%3A%5B%7B%22missionId%22%3A%22AgentCore.CustomRoleForOSSObjectRestore%22%2C%22roleName%22%3A%22AliyunAgentCoreWorkspace-ws-a1b2c3d4e5f6%22%2C%22rolePolicies%22%3A%5B%7B%22policyName%22%3A%22agentcore-oss-mount-policy-my-agent-bucket%22%2C%22policyType%22%3A%22Custom%22%2C%22templateId%22%3A%22OSSObjectRestoreCustom%22%2C%22templateValue%22%3A%7B%22ossBucket%22%3A%22acs%3Aoss%3A%2A%3A1234567890123456%3Amy-agent-bucket%22%2C%22ossBucketObject%22%3A%22acs%3Aoss%3A%2A%3A1234567890123456%3Amy-agent-bucket%2F%2A%22%7D%7D%5D%7D%5D%7D</a></para>
            /// </summary>
            [NameInMap("authorizeUrl")]
            [Validation(Required=false)]
            public string AuthorizeUrl { get; set; }

            /// <summary>
            /// <para>The name of the authorized source OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-bucket</para>
            /// </summary>
            [NameInMap("ossBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <para>The name of the workspace role selected by the backend.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunAgentCoreWorkspace-ws-a1b2c3d4e5f6</para>
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-a1b2c3d4e5f6</para>
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
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
