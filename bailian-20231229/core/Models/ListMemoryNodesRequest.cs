// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListMemoryNodesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token returned from a previous request. If specified, the query results are paginated based on the previous request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc270401186b433f975d7e1faaa34e0e</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
