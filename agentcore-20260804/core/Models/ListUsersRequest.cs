// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of records to return per page. Valid values: 1 to 100. If this parameter is not specified, 10 records are returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The filter condition for exact match on the username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-01</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The filter condition for fuzzy match on the username. The value can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>The cursor for querying the next page. Do not specify this parameter in the first call. In subsequent calls, specify the nextToken value returned in the previous call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dXNlci1vZmZzZXQ6MTA</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
