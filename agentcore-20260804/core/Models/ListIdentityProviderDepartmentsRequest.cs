// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListIdentityProviderDepartmentsRequest : TeaModel {
        /// <summary>
        /// <para>The number of departments to return per page. Valid values: 1 to 50. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The next token returned from the previous page. Do not specify this parameter for the first query. To continue pagination, keep the identity provider and parentDepartmentId unchanged and pass the token as is. If the returned value is empty or not returned, it indicates that there are no subsequent pages at the current hierarchy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-next-page-token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the parent department. Specifies the department whose direct child departments you want to query. If this parameter is not specified or is left empty, the root hierarchy is queried without recursively returning all descendants. When expanding a node in the list, specify the ID of the node instead of its parentId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("parentDepartmentId")]
        [Validation(Required=false)]
        public string ParentDepartmentId { get; set; }

    }

}
