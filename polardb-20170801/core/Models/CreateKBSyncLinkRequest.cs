// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateKBSyncLinkRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint of the DingTalk AI table MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://mcp-gw.dingtalk.com/server/example">https://mcp-gw.dingtalk.com/server/example</a></para>
        /// </summary>
        [NameInMap("AiTableMcpEndpoint")]
        [Validation(Required=false)]
        public string AiTableMcpEndpoint { get; set; }

        /// <summary>
        /// <para>The TTL of a successful snapshot of chat members for fallback reuse, in seconds. This parameter applies to DINGTALK and FEISHU synchronization links. If this parameter is explicitly configured, it takes precedence. If it is not configured, Feishu uses the value of FeishuChatMemberStaleTtlSeconds. A value of -1 indicates that the snapshot never expires. A value of 0 indicates that snapshot fallback reuse is disabled. A positive integer indicates the maximum age of a successful snapshot in the same workspace, enterprise, and chat group allowed for reuse. If this parameter is omitted, Feishu uses the legacy dedicated field. If neither is configured, the default value is -1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("ChatMemberStaleTtlSeconds")]
        [Validation(Required=false)]
        public int? ChatMemberStaleTtlSeconds { get; set; }

        /// <summary>
        /// <para>The client identifier.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cli_xxxxxxbe8</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The client secret.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-client-secret</para>
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The description of the synchronization link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of a successful snapshot of Feishu chat members for fallback reuse, in seconds. This parameter can be explicitly set only for FEISHU synchronization links. A value of -1 indicates that the snapshot never expires. A value of 0 indicates that snapshot fallback reuse is disabled. A positive integer indicates the maximum age of a snapshot allowed for reuse. Default value: -1. If this parameter is omitted, the default value -1 takes effect.</para>
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
        /// <para>The name of the synchronization link.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("LinkName")]
        [Validation(Required=false)]
        public string LinkName { get; set; }

        /// <summary>
        /// <para>The endpoint of the DingTalk document MCP server.</para>
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
        /// <para>The synchronization scope mode. This parameter applies only to DINGTALK sources and must be set together with SelectionRules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL: Synchronizes files in the source directory that are not excluded by excludes. The includes array must be empty.</description></item>
        /// <item><description>SELECTED: Synchronizes only files that match includes and are not excluded by excludes. If includes is empty, no files are selected.
        /// New configurations take effect starting from the next synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SELECTED</para>
        /// </summary>
        [NameInMap("SelectionMode")]
        [Validation(Required=false)]
        public string SelectionMode { get; set; }

        /// <summary>
        /// <para>The file path filtering rules in JSON format. This parameter contains only two required string arrays: includes and excludes. Paths are relative to SourceDir, and exclusion rules take precedence. GLOB is supported: * and ? do not cross directories, and ** matches zero or more directory levels when it occupies a path segment alone. The two arrays can contain a maximum of 256 entries in total. Each entry must be 1 to 512 characters in length. The maximum size of the JSON text is 65,536 UTF-8 bytes. After a file is removed from the synchronization scope, the corresponding document imported by this synchronization link is cleaned up, without affecting the source file or documents of other synchronization links.</para>
        /// </summary>
        [NameInMap("SelectionRules")]
        [Validation(Required=false)]
        public string SelectionRules { get; set; }

        /// <summary>
        /// <para>The endpoint of the DingTalk sheet MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://mcp-gw.dingtalk.com/server/1a2b3cxxxxxx567?key=d5e6fxxxxxx543">https://mcp-gw.dingtalk.com/server/1a2b3cxxxxxx567?key=d5e6fxxxxxx543</a></para>
        /// </summary>
        [NameInMap("SheetMcpEndpoint")]
        [Validation(Required=false)]
        public string SheetMcpEndpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable synchronization for source deletions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceDeleteSyncEnabled")]
        [Validation(Required=false)]
        public bool? SourceDeleteSyncEnabled { get; set; }

        /// <summary>
        /// <para>The address of the source directory for synchronization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.feishu.cn/wiki/space/xxxxxx">https://example.feishu.cn/wiki/space/xxxxxx</a></para>
        /// </summary>
        [NameInMap("SourceDir")]
        [Validation(Required=false)]
        public string SourceDir { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values: OSS, DINGTALK, FEISHU, and SHAREPOINT.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEISHU</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The synchronization interval, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("SyncIntervalMinutes")]
        [Validation(Required=false)]
        public int? SyncIntervalMinutes { get; set; }

        /// <summary>
        /// <para>The ID of the source tenant. This parameter is required and must be set to the Entra tenant ID when SourceType is set to SHAREPOINT, the tenant_key when SourceType is set to FEISHU, or the corpId when SourceType is set to DINGTALK. This parameter is not required when SourceType is set to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63eexxxx-xxxx-xxxx-xxxx-xxxxxx090f82</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The Feishu user access token. This token is used only when the application identity cannot expand chat members because the bot is not in the chat group.</para>
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
        /// <para>The Feishu user refresh token. This token must be provided together with UserAccessToken to automatically rotate the fallback identity for expanding chat members.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-user-refresh-token</para>
        /// </summary>
        [NameInMap("UserRefreshToken")]
        [Validation(Required=false)]
        public string UserRefreshToken { get; set; }

    }

}
