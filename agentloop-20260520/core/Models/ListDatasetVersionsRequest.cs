// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListDatasetVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of versions to return per page. Valid values: 1 to 100. Default value: 100. The actual number of returned versions may be less than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. Do not specify this parameter in the first request. To query subsequent pages, pass the nextToken value from the previous response as is, and keep the agent workspace and dataset name unchanged. The example is for demonstration purposes only. Use the actual token returned by the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>umaQfI7x758Ns4TgWrj8yA3fYlnk7dJgsfhMrSViRY8=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
