// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetProductResponseBody : TeaModel {
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
        public GetProductResponseBodyData Data { get; set; }
        public class GetProductResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Agent-related configurations of the API product. The agentAPIConfig member includes agentProtocols, which is a list of protocols supported by the agent, and routes, which is a list of routes.</para>
            /// </summary>
            [NameInMap("agentConfig")]
            [Validation(Required=false)]
            public HiMarketAgentConfig AgentConfig { get; set; }

            /// <summary>
            /// <para>Indicates whether subscription requests for the product are automatically approved.</para>
            /// </summary>
            [NameInMap("autoApprove")]
            [Validation(Required=false)]
            public bool? AutoApprove { get; set; }

            /// <summary>
            /// <para>The description of the API product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An API product that provides weather query capabilities</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The documentation content of the API product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The invocation methods, parameters, and billing instructions for this product</para>
            /// </summary>
            [NameInMap("document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            /// <summary>
            /// <para>The capability configurations of the API product. Currently, this includes only the modelFeature member for model capabilities, which contains model, maxTokens, temperature, streaming, webSearch, enableThinking, and enableMultiModal.</para>
            /// </summary>
            [NameInMap("feature")]
            [Validation(Required=false)]
            public HiMarketProductFeature Feature { get; set; }

            /// <summary>
            /// <para>The icon configurations of the API product, which consist of two fields: type for the icon type and value for the icon information.</para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public HiMarketIcon Icon { get; set; }

            /// <summary>
            /// <para>The MCP-related configurations of the API product. The members include mcpServerName for the MCP server name, tools, mcpServerConfig for the path and domains, and meta for the protocol.</para>
            /// </summary>
            [NameInMap("mcpConfig")]
            [Validation(Required=false)]
            public HiMarketMcpConfig McpConfig { get; set; }

            /// <summary>
            /// <para>The model API-related configurations of the API product. The modelAPIConfig member includes modelCategory for the AI model category, aiProtocols for the list of AI API protocols, and routes for the list of routes.</para>
            /// </summary>
            [NameInMap("modelConfig")]
            [Validation(Required=false)]
            public HiMarketModelConfig ModelConfig { get; set; }

            /// <summary>
            /// <para>The name of the API product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>weather-query-api</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the API product, which is the primary ID of the API product resource. You can use this ID to locate the product in operations such as GetProduct, UpdateProduct, DeleteProduct, PublishProduct, SetProductCategories, and GetProductRef.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-xxxxxxxx</para>
            /// </summary>
            [NameInMap("productId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The ID of the region to which the API product belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the API product. Valid values: Pending, Ready, and Published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Published</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the API product. The set of valid values is not declared in the API definition. Refer to the types displayed in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

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
