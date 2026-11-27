// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKBSyncLinkRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint of the DingTalk AI Tables MCP server. An empty string indicates deletion.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://mcp-gw.dingtalk.com/server/example">https://mcp-gw.dingtalk.com/server/example</a></para>
        /// </summary>
        [NameInMap("AiTableMcpEndpoint")]
        [Validation(Required=false)]
        public string AiTableMcpEndpoint { get; set; }

        /// <summary>
        /// <para>The validity period of the successful group member snapshot used for fallback reuse, in seconds. This parameter applies to DingTalk and Lark synchronization links. If this field is explicitly configured, it takes precedence. If not configured, Lark uses FeishuChatMemberStaleTtlSeconds. A value of -1 indicates that the snapshot never expires. A value of 0 disables snapshot fallback reuse. A positive integer indicates the maximum age of successful snapshots in the same workspace, enterprise, and group allowed for reuse. If omitted, the original value is retained. Explicitly passing -1 restores the default behavior.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("ChatMemberStaleTtlSeconds")]
        [Validation(Required=false)]
        public int? ChatMemberStaleTtlSeconds { get; set; }

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
        /// <para>The client secret information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-client-secret</para>
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The validity period of the successful Lark group member snapshot used for fallback reuse, in seconds. This parameter can only be explicitly set for Lark synchronization links. A value of -1 indicates that the snapshot never expires. A value of 0 disables snapshot fallback reuse. A positive integer indicates the maximum age of the snapshot allowed for reuse. If omitted, the original value is retained. Explicitly passing -1 restores the default behavior.</para>
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
        /// <para>This parameter applies only to DingTalk sources and must be set together with SelectionRules. Valid values: ALL: Synchronizes files in the source directory that are not excluded by excludes. The includes parameter must be an empty array. SELECTED: Synchronizes only files that match includes and are not excluded by excludes. If includes is empty, no files are selected. If this parameter is not provided, the original configuration is retained. If both parameters are provided, the original rules are replaced. This parameter cannot be modified at the same time as SyncEnabled. The new configuration takes effect starting from the next synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECTED</para>
        /// </summary>
        [NameInMap("SelectionMode")]
        [Validation(Required=false)]
        public string SelectionMode { get; set; }

        /// <summary>
        /// <para>The file path filtering rules in JSON format. It only contains two required string arrays: includes and excludes. Paths are relative to SourceDir, and exclusion rules take precedence. GLOB is supported: * and ? do not cross directories, and ** matches zero or more directory levels when it occupies a path segment alone. The two arrays can contain a maximum of 256 entries in total. Each entry must be 1 to 512 characters in length. The maximum size of the JSON text is 65,536 UTF-8 bytes. After a file is removed from the synchronization scope, the corresponding documents imported by this synchronization link are cleared, without affecting the source files and documents of other synchronization links.</para>
        /// </summary>
        [NameInMap("SelectionRules")]
        [Validation(Required=false)]
        public string SelectionRules { get; set; }

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
        /// <para>Specifies whether to synchronize deletions from the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceDeleteSyncEnabled")]
        [Validation(Required=false)]
        public bool? SourceDeleteSyncEnabled { get; set; }

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
        /// <para>The ID of the DingTalk operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***56</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The new Lark user refresh token. It must be provided together with UserAccessToken. Passing two empty strings indicates deletion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-user-refresh-token</para>
        /// </summary>
        [NameInMap("UserRefreshToken")]
        [Validation(Required=false)]
        public string UserRefreshToken { get; set; }

    }

}
