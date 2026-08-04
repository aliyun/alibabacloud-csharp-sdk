// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DeleteDataAgentMcpShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of MCP Server IDs to delete.</para>
        /// </summary>
        [NameInMap("McpServerIds")]
        [Validation(Required=false)]
        public string McpServerIdsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the Data Agent workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atvx***xmz</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
