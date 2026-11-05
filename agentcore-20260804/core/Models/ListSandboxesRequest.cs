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
