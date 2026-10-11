// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListCustomAgentsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return per page. Valid values: 1 to 100. If this parameter is omitted or set to 0, the default value 20 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The opaque token used to query the next page. Omit this parameter in the first request. In subsequent requests, pass the nextToken value returned in the previous response as is, and keep the same workspace. Do not construct the token yourself.</para>
        /// 
        /// <b>Example:</b>
        /// <para>djE6YWdlbnRjb3JlLmFnZW50Lmxpc3QuY3VzdG9tOjIw</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
