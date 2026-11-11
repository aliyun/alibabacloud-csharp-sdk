// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListCredentialsRequest : TeaModel {
        /// <summary>
        /// <para>The credential type used for filtering. Valid values: apiKey and mcpHeader.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiKey</para>
        /// </summary>
        [NameInMap("credentialType")]
        [Validation(Required=false)]
        public string CredentialType { get; set; }

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
        /// <para>The credential name used for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credentialxxx</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The keyword used to perform fuzzy matching on credential names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>The cursor used to query the next page. Leave this parameter empty in the first call. In subsequent calls, specify the nextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
