// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class ListApiMcpServerSystemToolsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return on each page. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to start the next query. Set this parameter to the NextToken value returned by the last API call.</para>
        /// <remarks>
        /// <para>Do not specify this parameter for the first query. If a query does not return all results, pass the NextToken value from the previous response to the next query to continue.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAZjtYxxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries to skip.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

    }

}
