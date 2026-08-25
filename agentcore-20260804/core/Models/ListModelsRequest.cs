// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListModelsRequest : TeaModel {
        /// <summary>
        /// <para>The model connection ID used to filter models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-1</para>
        /// </summary>
        [NameInMap("connectionId")]
        [Validation(Required=false)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// <para>The number of results per page. Valid values: 0 to 100. If this parameter is not set or set to 0, the default value 10 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The upstream model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The pagination token. Pass the token returned from the previous query. An empty response indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bW9kZWwtbWFuYWdlbWVudC1vZmZzZXQ6bW9kZWw6MTA</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
