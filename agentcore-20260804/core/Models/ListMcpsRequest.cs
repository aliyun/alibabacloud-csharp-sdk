// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListMcpsRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results by custom tags. An exact match with the tags is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Knowledge base</para>
        /// </summary>
        [NameInMap("customTag")]
        [Validation(Required=false)]
        public string CustomTag { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The service name or ID of the MCP service. This parameter is used in conjunction with SearchType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-mcp-server</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-page-token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Filters the results by official usage tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KNOWLEDGE_BASE</para>
        /// </summary>
        [NameInMap("officialTag")]
        [Validation(Required=false)]
        public string OfficialTag { get; set; }

        /// <summary>
        /// <para>The name matching mode. This parameter takes effect only when Name is specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>accurate: Exact match.</description></item>
        /// <item><description>blur: Fuzzy match.
        /// Default value: blur.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>blur</para>
        /// </summary>
        [NameInMap("searchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        /// <summary>
        /// <para>Specifies whether the service is still subject to official template usage constraints.</para>
        /// </summary>
        [NameInMap("usageActive")]
        [Validation(Required=false)]
        public bool? UsageActive { get; set; }

    }

}
