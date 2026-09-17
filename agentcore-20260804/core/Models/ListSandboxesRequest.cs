// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListSandboxesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of records per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for querying the next page. When paginating, keep workspaceId, agentId, searchText, sessionId, and maxResults unchanged.</para>
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
        /// <para>Performs a case-insensitive fuzzy search by active session ID fragment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-a</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
