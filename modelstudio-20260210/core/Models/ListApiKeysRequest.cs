// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class ListApiKeysRequest : TeaModel {
        /// <summary>
        /// <para>Exact search by API Key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3076140</para>
        /// </summary>
        [NameInMap("apiKeyId")]
        [Validation(Required=false)]
        public long? ApiKeyId { get; set; }

        /// <summary>
        /// <para>Fuzzy search by description keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Used to return more results. This parameter is not required for the first query. The token required for subsequent queries can be obtained from the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w9Z+S5+TZyw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Exact search by workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-ac3ef438bec22dc5</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
