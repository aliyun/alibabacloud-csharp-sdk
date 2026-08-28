// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListAgentIMChannelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of SUCCESS indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The IM channel list.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListAgentIMChannelsResponseBodyItems> Items { get; set; }
        public class ListAgentIMChannelsResponseBodyItems : TeaModel {
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
            public ListAgentIMChannelsResponseBodyItemsChannelConfig ChannelConfig { get; set; }
            public class ListAgentIMChannelsResponseBodyItemsChannelConfig : TeaModel {
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
            /// <para>The IM channel type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DINGTALK: DingTalk.</description></item>
            /// <item><description>FEISHU: Lark.</description></item>
            /// <item><description>WECOM: WeCom.</description></item>
            /// </list>
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
            public ListAgentIMChannelsResponseBodyItemsCredentialSummary CredentialSummary { get; set; }
            public class ListAgentIMChannelsResponseBodyItemsCredentialSummary : TeaModel {
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
            /// <para>Indicates whether the IM channel is enabled. Default value upon creation: true.</para>
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
            /// <para>The ID of the bound ServiceEndpoint. The endpoint must belong to the specified agent and its current version, be in the ready state, and have a public network address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>se-1</para>
            /// </summary>
            [NameInMap("serviceEndpointId")]
            [Validation(Required=false)]
            public string ServiceEndpointId { get; set; }

            /// <summary>
            /// <para>The IM channel status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATING: being created.</description></item>
            /// <item><description>READY: ready.</description></item>
            /// <item><description>UPDATING: being updated.</description></item>
            /// <item><description>FAILED: failed.</description></item>
            /// <item><description>DELETING: being deleted.</description></item>
            /// <item><description>DELETE_FAILED: deletion failed.</description></item>
            /// </list>
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
        /// <para>The maximum number of entries returned per page for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next page. An empty value indicates that the last page has been reached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
