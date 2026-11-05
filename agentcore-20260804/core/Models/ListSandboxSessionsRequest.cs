// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListSandboxSessionsRequest : TeaModel {
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
        /// <para>The token for the next page. Omit this parameter in the first request. For subsequent requests, use the returned token as is, and keep the workspace, agent, instance, and maxResults unchanged. An empty value indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
