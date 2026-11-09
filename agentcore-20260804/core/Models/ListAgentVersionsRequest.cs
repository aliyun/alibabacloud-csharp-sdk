// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListAgentVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to query the next page. Pass the nextToken returned in the previous ListAgentVersions response. Do not pass this parameter for the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YWdlbnQtdmVyc2lvbnM6MjA</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
