// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMcpServersRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The next page token from a previous response. Use this token to retrieve the next page of results. Leave this parameter empty for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search keyword for a fuzzy search on MCP Server names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mcp</para>
        /// </summary>
        [NameInMap("Q")]
        [Validation(Required=false)]
        public string Q { get; set; }

        /// <summary>
        /// <para>The visibility level for filtering the results.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public List<string> Visibility { get; set; }

    }

}
