// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListToolsRequest : TeaModel {
        /// <summary>
        /// <para>当前页码，从 1 开始</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>每页返回的工具数量，用于分页查询</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>按工具类型过滤，可选值：MCP、FUNCTIONCALL、SKILL</para>
        /// 
        /// <b>Example:</b>
        /// <para>MCP</para>
        /// </summary>
        [NameInMap("toolType")]
        [Validation(Required=false)]
        public string ToolType { get; set; }

        /// <summary>
        /// <para>按工作空间ID过滤，查询指定工作空间下的工具</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-xyz789</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ws1,ws2</para>
        /// </summary>
        [NameInMap("workspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

    }

}
