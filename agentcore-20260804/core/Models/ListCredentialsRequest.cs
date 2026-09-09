// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListCredentialsRequest : TeaModel {
        /// <summary>
        /// <para>Filters by credential type. Currently, only apiKey is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiKey</para>
        /// </summary>
        [NameInMap("credentialType")]
        [Validation(Required=false)]
        public string CredentialType { get; set; }

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
        /// <para>Filters by credential name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credentialxxx</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The filter condition for fuzzy match by credential name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. Do not specify this parameter for the first request. For subsequent requests, set this parameter to the nextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
