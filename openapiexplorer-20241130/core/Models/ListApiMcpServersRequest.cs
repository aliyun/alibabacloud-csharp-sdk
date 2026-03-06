// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class ListApiMcpServersRequest : TeaModel {
        /// <summary>
        /// <para>The time when the API MCP server was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-30T02:10:13Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the API MCP service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个API MCP服务器。</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the API MCP service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v6ZZ7ftCzEILW***</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The search keyword. Supports fuzzy search by API name and exact search by API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the API reference for the API MCP service. The language of the prompt can affect the response from the AI. Valid values: \<c>ZH_CN\\</c>, \<c>EN_US\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZH_CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page for a paged query. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query. Set this parameter to the \<c>nextToken\\</c> value that was returned from the previous API call.</para>
        /// <remarks>
        /// <para>This parameter is not required for the first query. If a query does not return all results, pass the \<c>nextToken\\</c> value from the previous query to continue.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAZjtYxxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of data entries to skip.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

        /// <summary>
        /// <para>The type of the API MCP service.</para>
        /// <list type="bullet">
        /// <item><description><para>custom: a custom service</para>
        /// </description></item>
        /// <item><description><para>system: a system service</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The time when the API MCP server was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-05T02:27:39Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
