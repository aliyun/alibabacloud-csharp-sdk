// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListProductsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProductsResponseBodyData Data { get; set; }
        public class ListProductsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of API products. The list element is named productInfo, and each element contains the information of an API product.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<ListProductsResponseBodyDataContent> Content { get; set; }
            public class ListProductsResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The agent-related configurations of the API product. The agentAPIConfig member includes agentProtocols (the list of protocols supported by the agent) and routes (the list of routes).</para>
                /// </summary>
                [NameInMap("agentConfig")]
                [Validation(Required=false)]
                public HiMarketAgentConfig AgentConfig { get; set; }

                /// <summary>
                /// <para>Specifies whether subscription requests for the API product are automatically approved. This is the AutoApprove property of the API product resource.</para>
                /// </summary>
                [NameInMap("autoApprove")]
                [Validation(Required=false)]
                public bool? AutoApprove { get; set; }

                /// <summary>
                /// <para>The list of product categories to which the API product belongs. The list element is named category.</para>
                /// </summary>
                [NameInMap("categories")]
                [Validation(Required=false)]
                public List<HiMarketProductCategory> Categories { get; set; }

                /// <summary>
                /// <para>The description of the API product, which is the Description property of the API product resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An API product that provides weather query capabilities</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The documentation of the API product, which is the Document property of the API product resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The invocation methods, parameters, and billing instructions for this product</para>
                /// </summary>
                [NameInMap("document")]
                [Validation(Required=false)]
                public string Document { get; set; }

                /// <summary>
                /// <para>The capability configurations of the API product. Currently, it includes only the modelFeature (model capabilities) member, which contains model, maxTokens, temperature, streaming, webSearch, enableThinking, and enableMultiModal.</para>
                /// </summary>
                [NameInMap("feature")]
                [Validation(Required=false)]
                public HiMarketProductFeature Feature { get; set; }

                /// <summary>
                /// <para>The icon of the API product, which is the Icon property of the API product resource. It consists of two fields: type (the icon type) and value (the icon information).</para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public HiMarketIcon Icon { get; set; }

                /// <summary>
                /// <para>The MCP-related configurations of the API product. The members include mcpServerName (the MCP server name), tools, mcpServerConfig (path and domains), and meta (protocol).</para>
                /// </summary>
                [NameInMap("mcpConfig")]
                [Validation(Required=false)]
                public HiMarketMcpConfig McpConfig { get; set; }

                /// <summary>
                /// <para>The model API-related configurations of the API product. The modelAPIConfig member includes modelCategory (the AI model category), aiProtocols (the list of AI API protocols), and routes (the list of routes).</para>
                /// </summary>
                [NameInMap("modelConfig")]
                [Validation(Required=false)]
                public HiMarketModelConfig ModelConfig { get; set; }

                /// <summary>
                /// <para>The name of the API product, which is the Name property of the API product resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>weather-query-api</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the API product, which is the primary ID of the API product resource. You can use it to locate the product in operations such as GetProduct, UpdateProduct, DeleteProduct, PublishProduct, SetProductCategories, and ListProductPublications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product-xxxxxxxx</para>
                /// </summary>
                [NameInMap("productId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <para>The status of the API product, which is the Status property of the API product resource. Valid values: Pending, Ready, and Published.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Published</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the API product, which is the Type property of the API product resource. The valid values are not declared in the API definition. Refer to the types displayed in the console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>API</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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
        /// <para>The cursor token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-xxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
