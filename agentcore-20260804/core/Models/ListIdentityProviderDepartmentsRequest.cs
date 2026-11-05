// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListIdentityProviderDepartmentsRequest : TeaModel {
        /// <summary>
        /// <para>The number of departments returned per page. Valid values: 1 to 50. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token returned from the previous page. Do not specify this parameter for the first query. When continuing pagination, keep the identity provider and parentDepartmentId unchanged, and pass the token as is. An empty return value or no return value indicates that there are no subsequent pages at the current level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-next-page-token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the parent department. If you specify this parameter, the direct child departments of this department are queried. If this parameter is not specified or is empty, the root level is queried, and all descendants are not recursively returned. When expanding a node in the list, pass the ID of the node, not its parentId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("parentDepartmentId")]
        [Validation(Required=false)]
        public string ParentDepartmentId { get; set; }

    }

}
