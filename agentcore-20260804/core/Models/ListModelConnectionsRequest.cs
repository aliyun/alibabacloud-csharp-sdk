// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListModelConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the summary of associated models in each model connection. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("includeModels")]
        [Validation(Required=false)]
        public bool? IncludeModels { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page. Valid values: 0 to 100. Default value: 10. If this parameter is not specified or is set to 0, the default value is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the model connection. The name must be 1 to 128 non-whitespace characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token. Pass the token returned in the previous response to query the next page. If the response is empty, no more pages are available.</para>
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
        /// <para>The name matching mode. This parameter takes effect only when Name is specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>accurate: exact match</description></item>
        /// <item><description>blur: fuzzy match
        /// Default value: blur.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>blur</para>
        /// </summary>
        [NameInMap("searchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

    }

}
