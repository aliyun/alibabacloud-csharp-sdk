// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListToolsRequest : TeaModel {
        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Tool Name, supports fuzzy search</para>
        /// 
        /// <b>Example:</b>
        /// <para>tool-1</para>
        /// </summary>
        [NameInMap("toolName")]
        [Validation(Required=false)]
        public string ToolName { get; set; }

        /// <summary>
        /// <para>Tool type</para>
        /// 
        /// <b>Example:</b>
        /// <para>MCP</para>
        /// </summary>
        [NameInMap("toolType")]
        [Validation(Required=false)]
        public string ToolType { get; set; }

        /// <summary>
        /// <para>Workspace ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-xyz789</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>List of workspace IDs, separated by commas</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws1,ws2</para>
        /// </summary>
        [NameInMap("workspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

    }

}
