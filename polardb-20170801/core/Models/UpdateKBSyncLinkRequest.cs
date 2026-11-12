// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKBSyncLinkRequest : TeaModel {
        /// <summary>
        /// <para>The client identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cli_xxxxxxbe8</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The client secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-client-secret</para>
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The validity period of the successful snapshot of Lark group members for fallback reuse, in seconds. This parameter can be explicitly set only for FEISHU synchronization links. A value of -1 indicates that the snapshot never expires. A value of 0 disables snapshot fallback reuse. A positive integer indicates the maximum age of the snapshot allowed for reuse. If this parameter is omitted, the original value is retained. Explicitly passing -1 restores the default behavior.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("FeishuChatMemberStaleTtlSeconds")]
        [Validation(Required=false)]
        public int? FeishuChatMemberStaleTtlSeconds { get; set; }

        /// <summary>
        /// <para>The unique identifier of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkb-xxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The ID of the synchronization link.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkbl-xxxxx</para>
        /// </summary>
        [NameInMap("LinkId")]
        [Validation(Required=false)]
        public string LinkId { get; set; }

        /// <summary>
        /// <para>The endpoint of the DingTalk Docs MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://mcp-gw.dingtalk.com/server/1a2b3cxxxxxx789?key=d5e6fxxxxxx876">https://mcp-gw.dingtalk.com/server/1a2b3cxxxxxx789?key=d5e6fxxxxxx876</a></para>
        /// </summary>
        [NameInMap("McpEndpoint")]
        [Validation(Required=false)]
        public string McpEndpoint { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The endpoint of the DingTalk Sheets MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://mcp-gw.dingtalk.com/server/1a2b3cxxxxxx567?key=d5e6fxxxxxx543">https://mcp-gw.dingtalk.com/server/1a2b3cxxxxxx567?key=d5e6fxxxxxx543</a></para>
        /// </summary>
        [NameInMap("SheetMcpEndpoint")]
        [Validation(Required=false)]
        public string SheetMcpEndpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic synchronization. This parameter can only be modified individually and cannot be changed along with other configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SyncEnabled")]
        [Validation(Required=false)]
        public bool? SyncEnabled { get; set; }

        /// <summary>
        /// <para>The automatic synchronization interval, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SyncIntervalMinutes")]
        [Validation(Required=false)]
        public int? SyncIntervalMinutes { get; set; }

        /// <summary>
        /// <para>The new Lark user access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-user-access-token</para>
        /// </summary>
        [NameInMap("UserAccessToken")]
        [Validation(Required=false)]
        public string UserAccessToken { get; set; }

        /// <summary>
        /// <para>The ID of the DingTalk user who performs the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***56</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The new Lark user refresh token. Pass this parameter together with UserAccessToken. Passing empty strings for both parameters deletes the tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-user-refresh-token</para>
        /// </summary>
        [NameInMap("UserRefreshToken")]
        [Validation(Required=false)]
        public string UserRefreshToken { get; set; }

    }

}
