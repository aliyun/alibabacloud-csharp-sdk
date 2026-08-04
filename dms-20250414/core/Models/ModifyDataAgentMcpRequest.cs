// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ModifyDataAgentMcpRequest : TeaModel {
        /// <summary>
        /// <para>The brief description of the artifact. This parameter can be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project name pass the check</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the MCP server is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The endpoint of the MCP instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://***.com/mcp</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The request header settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Authorization&quot;:&quot;Bearer ***&quot;}</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public string Headers { get; set; }

        /// <summary>
        /// <para>The ID of the MCP server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6126jk***h2</para>
        /// </summary>
        [NameInMap("McpServerId")]
        [Validation(Required=false)]
        public string McpServerId { get; set; }

        /// <summary>
        /// <para>The MCP name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Efficiency Diagnostics V3</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the Alibaba Cloud UID in the request header.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedUidInHeader")]
        [Validation(Required=false)]
        public bool? NeedUidInHeader { get; set; }

        /// <summary>
        /// <para>The transport channel type. Valid values: streamablehttp, sse.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sse</para>
        /// </summary>
        [NameInMap("TransportType")]
        [Validation(Required=false)]
        public string TransportType { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e3p***v4</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
