// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKBSyncLinkRequest : TeaModel {
        /// <summary>
        /// <para>The client ID.</para>
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
        /// <hr>
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

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
        /// <para>The synchronization link ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkbl-xxxxx</para>
        /// </summary>
        [NameInMap("LinkId")]
        [Validation(Required=false)]
        public string LinkId { get; set; }

        /// <summary>
        /// <para>The MCP Server address for DingTalk documents.</para>
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
        /// <para>The MCP Server address for DingTalk spreadsheets.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://mcp-gw.dingtalk.com/server/1a2b3cxxxxxx567?key=d5e6fxxxxxx543">https://mcp-gw.dingtalk.com/server/1a2b3cxxxxxx567?key=d5e6fxxxxxx543</a></para>
        /// </summary>
        [NameInMap("SheetMcpEndpoint")]
        [Validation(Required=false)]
        public string SheetMcpEndpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic synchronization. This parameter can only be modified independently and cannot be changed together with other configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SyncEnabled")]
        [Validation(Required=false)]
        public bool? SyncEnabled { get; set; }

        /// <summary>
        /// <para>20</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SyncIntervalMinutes")]
        [Validation(Required=false)]
        public int? SyncIntervalMinutes { get; set; }

        /// <summary>
        /// <para>The DingTalk user ID for the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***56</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
