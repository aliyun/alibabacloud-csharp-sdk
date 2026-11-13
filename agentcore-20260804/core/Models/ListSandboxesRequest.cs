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
        /// <para>The cursor for querying the next page. When you turn the page, you must keep workspaceId, agentId, searchText, sessionId, and maxResults unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Performs a case-insensitive fuzzy search by sandbox ID fragment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2f360</para>
        /// </summary>
        [NameInMap("searchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        /// <summary>
        /// <para>If omitted or left blank, queries the latest running unit of the agent. If specified, the service endpoint must belong to the agent and the target type must be AGENT_VERSION. Otherwise, Resource.NotFound is returned. An independently running service endpoint returns only the sandboxes of its own running unit. If the DEFAULT service endpoint has not taken over independent running, it falls back to the latest running unit. If a non-DEFAULT service endpoint is not running independently, ServiceEndpointTargetNotReady is returned. If the running unit has not been created, an empty list is returned and totalCount is 0, without reporting an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>se-7f3a92c1</para>
        /// </summary>
        [NameInMap("serviceEndpointId")]
        [Validation(Required=false)]
        public string ServiceEndpointId { get; set; }

        /// <summary>
        /// <para>Performs a case-insensitive fuzzy search by current valid session ID fragment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-a</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
