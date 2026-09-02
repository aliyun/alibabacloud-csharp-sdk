// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateKBSyncLinkRequest : TeaModel {
        /// <summary>
        /// <para>The client ID.</para>
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
        /// <hr>
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
        /// <para>The DingTalk document MCP Server endpoint.</para>
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
        /// <para>The DingTalk spreadsheet MCP Server endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://mcp-gw.dingtalk.com/server/1a2b3cxxxxxx567?key=d5e6fxxxxxx543">https://mcp-gw.dingtalk.com/server/1a2b3cxxxxxx567?key=d5e6fxxxxxx543</a></para>
        /// </summary>
        [NameInMap("SheetMcpEndpoint")]
        [Validation(Required=false)]
        public string SheetMcpEndpoint { get; set; }

        /// <summary>
        /// <para>The source directory address for synchronization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.feishu.cn/wiki/space/xxxxxx">https://example.feishu.cn/wiki/space/xxxxxx</a></para>
        /// </summary>
        [NameInMap("SourceDir")]
        [Validation(Required=false)]
        public string SourceDir { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values: FEISHU and SHAREPOINT.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEISHU</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The synchronization interval. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("SyncIntervalMinutes")]
        [Validation(Required=false)]
        public int? SyncIntervalMinutes { get; set; }

        /// <summary>
        /// <para>The tenant ID. This parameter is required when SourceType is set to SHAREPOINT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63eexxxx-xxxx-xxxx-xxxx-xxxxxx090f82</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The DingTalk operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***56</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
