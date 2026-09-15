// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListMcpMarketItemsRequest : TeaModel {
        /// <summary>
        /// <para>The keyword used to filter MCP marketplace templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Knowledge</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return in this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The MCP type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CODE_PACKAGE</para>
        /// </summary>
        [NameInMap("mcpType")]
        [Validation(Required=false)]
        public string McpType { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The official usage tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KNOWLEDGE_BASE</para>
        /// </summary>
        [NameInMap("officialTag")]
        [Validation(Required=false)]
        public string OfficialTag { get; set; }

    }

}
