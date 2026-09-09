// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListModelConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return associated model summaries for each model connection. By default, model summaries are not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("includeModels")]
        [Validation(Required=false)]
        public bool? IncludeModels { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values: 0 to 100. If this parameter is not set or is set to 0, the default value 10 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The model connection name. The name must be 1 to 128 non-whitespace characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token. Pass the token returned in the previous query. An empty response indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bW9kZWwtbWFuYWdlbWVudC1vZmZzZXQ6bW9kZWwtY29ubmVjdGlvbjoxMA</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The invocation protocol used to filter model connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAI/v1</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The model provider type used to filter model connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("providerType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

        /// <summary>
        /// <para>The name matching mode. Takes effect only when Name is set. Valid values: accurate (exact match), blur (fuzzy match). Default value: blur.</para>
        /// 
        /// <b>Example:</b>
        /// <para>blur</para>
        /// </summary>
        [NameInMap("searchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

    }

}
