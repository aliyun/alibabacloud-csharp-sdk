// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateAgentIMChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. The value is SUCCESS if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The updated IM channel information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateAgentIMChannelResponseBodyData Data { get; set; }
        public class UpdateAgentIMChannelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-1</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The channel behavior configuration.</para>
            /// </summary>
            [NameInMap("channelConfig")]
            [Validation(Required=false)]
            public UpdateAgentIMChannelResponseBodyDataChannelConfig ChannelConfig { get; set; }
            public class UpdateAgentIMChannelResponseBodyDataChannelConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to display the thinking process in IM messages. Default value: false.</para>
                /// </summary>
                [NameInMap("showThinking")]
                [Validation(Required=false)]
                public bool? ShowThinking { get; set; }

                /// <summary>
                /// <para>Specifies whether to display the tool calling process in IM messages. Default value: false.</para>
                /// </summary>
                [NameInMap("showToolCalls")]
                [Validation(Required=false)]
                public bool? ShowToolCalls { get; set; }

            }

            /// <summary>
            /// <para>The IM channel type. Valid values: DINGTALK (DingTalk), FEISHU (Lark), and WECOM (WeCom).</para>
            /// 
            /// <b>Example:</b>
            /// <para>DINGTALK</para>
            /// </summary>
            [NameInMap("channelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>The creation time in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The channel credential summary. Only non-sensitive fields and configured secret field names are returned. Secret values are not returned.</para>
            /// </summary>
            [NameInMap("credentialSummary")]
            [Validation(Required=false)]
            public UpdateAgentIMChannelResponseBodyDataCredentialSummary CredentialSummary { get; set; }
            public class UpdateAgentIMChannelResponseBodyDataCredentialSummary : TeaModel {
                /// <summary>
                /// <para>The list of configured secret field names. Secret values are not included.</para>
                /// </summary>
                [NameInMap("configuredSecretFields")]
                [Validation(Required=false)]
                public List<string> ConfiguredSecretFields { get; set; }

                /// <summary>
                /// <para>The non-sensitive credential fields and their values.</para>
                /// </summary>
                [NameInMap("nonSecretFields")]
                [Validation(Required=false)]
                public Dictionary<string, string> NonSecretFields { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the IM channel. Default value: true.</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The public network access URL of the attached ServiceEndpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://agent.example.com">https://agent.example.com</a></para>
            /// </summary>
            [NameInMap("endpointUrl")]
            [Validation(Required=false)]
            public string EndpointUrl { get; set; }

            /// <summary>
            /// <para>The IM channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imc-1</para>
            /// </summary>
            [NameInMap("imChannelId")]
            [Validation(Required=false)]
            public string ImChannelId { get; set; }

            /// <summary>
            /// <para>The ID of the bound ServiceEndpoint. The endpoint must belong to the specified agent and its current version, and must be ready and have a public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>se-1</para>
            /// </summary>
            [NameInMap("serviceEndpointId")]
            [Validation(Required=false)]
            public string ServiceEndpointId { get; set; }

            /// <summary>
            /// <para>The IM channel status. Valid values: CREATING (Creating), READY (Ready), UPDATING (Updating), FAILED (Failed), DELETING (Deleting), and DELETE_FAILED (Deletion failed).</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason for the current status of the IM channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AppFlow creation failed</para>
            /// </summary>
            [NameInMap("statusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The update time in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-1</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. The value is 200 if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request processing result message.</para>
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
        /// <para>1a2b3c4d-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
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
