// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListSandboxesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return per page. Default value: 20. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The cursor for querying the next page. When paginating, keep <c>workspaceId</c>, <c>agentId</c>, <c>searchText</c>, <c>sessionId</c>, and <c>maxResults</c> unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The fragment of the Sandbox ID for a case-insensitive fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2f360</para>
        /// </summary>
        [NameInMap("searchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        /// <summary>
        /// <para>省略或传空白时查询智能体 latest 运行单元；传入时该服务端点必须属于本智能体且目标类型为 AGENT_VERSION，否则返回 Resource.NotFound。独立运行的服务端点只返回其自身运行单元的 Sandbox；DEFAULT 服务端点尚未接管独立运行时回落到 latest 运行单元；非 DEFAULT 且未独立运行时返回 ServiceEndpointTargetNotReady。运行单元尚未创建时返回空列表且 totalCount 为 0，不报错。</para>
        /// 
        /// <b>Example:</b>
        /// <para>se-7f3a92c1</para>
        /// </summary>
        [NameInMap("serviceEndpointId")]
        [Validation(Required=false)]
        public string ServiceEndpointId { get; set; }

        /// <summary>
        /// <para>The fragment of the current valid session ID for a case-insensitive fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-a</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
