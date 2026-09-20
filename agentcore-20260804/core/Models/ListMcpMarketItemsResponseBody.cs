// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListMcpMarketItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of query results.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListMcpMarketItemsResponseBodyItems> Items { get; set; }
        public class ListMcpMarketItemsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The category of the MCP marketplace template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>knowledge</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The description of the MCP service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An MCP service for querying knowledge bases</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display metadata of the template.</para>
            /// </summary>
            [NameInMap("displayMetadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> DisplayMetadata { get; set; }

            /// <summary>
            /// <para>The multilingual display content organized by BCP-47 language tags. Falls back to default fields if the specified language is not matched.</para>
            /// </summary>
            [NameInMap("i18n")]
            [Validation(Required=false)]
            public Dictionary<string, ItemsI18nValue> I18n { get; set; }

            /// <summary>
            /// <para>The icon URL of the MCP marketplace template.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/mcp-icon.png">https://example.com/mcp-icon.png</a></para>
            /// </summary>
            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <para>The number of times the template has been installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("installCount")]
            [Validation(Required=false)]
            public long? InstallCount { get; set; }

            /// <summary>
            /// <para>The ID of the MCP marketplace template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>market-1</para>
            /// </summary>
            [NameInMap("marketItemId")]
            [Validation(Required=false)]
            public string MarketItemId { get; set; }

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
            /// <para>The name of the MCP marketplace template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Knowledge</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The official usage tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOWLEDGE_BASE</para>
            /// </summary>
            [NameInMap("officialTag")]
            [Validation(Required=false)]
            public string OfficialTag { get; set; }

            /// <summary>
            /// <para>The MCP protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StreamableHTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The usage instructions of the MCP marketplace template.</para>
            /// 
            /// <b>Example:</b>
            /// <h1>Knowledge\nKnowledge base query service</h1>
            /// </summary>
            [NameInMap("readme")]
            [Validation(Required=false)]
            public string Readme { get; set; }

            /// <summary>
            /// <para>The schema version of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("schemaVersion")]
            [Validation(Required=false)]
            public string SchemaVersion { get; set; }

            /// <summary>
            /// <para>The template input schema, represented as a JSON Schema string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;addresses&quot;:{&quot;type&quot;:&quot;array&quot;,&quot;items&quot;:{&quot;type&quot;:&quot;string&quot;}}}}</para>
            /// </summary>
            [NameInMap("templateInputSchema")]
            [Validation(Required=false)]
            public string TemplateInputSchema { get; set; }

            /// <summary>
            /// <para>The version of the MCP marketplace template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("templateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

        }

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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that match the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
