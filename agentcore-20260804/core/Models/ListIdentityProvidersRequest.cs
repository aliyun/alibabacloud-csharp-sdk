// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListIdentityProvidersRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of records per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. Do not specify this parameter for the first request. For subsequent requests, specify the nextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aWRlbnRpdHktcHJvdmlkZXItb2Zmc2V0OjEw</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
