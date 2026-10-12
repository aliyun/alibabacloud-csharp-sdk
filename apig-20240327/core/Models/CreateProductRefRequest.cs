// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateProductRefRequest : TeaModel {
        /// <summary>
        /// <para>The API configuration associated with the API product.</para>
        /// </summary>
        [NameInMap("apigRefConfig")]
        [Validation(Required=false)]
        public CreateProductRefRequestApigRefConfig ApigRefConfig { get; set; }
        public class CreateProductRefRequestApigRefConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the associated agent API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-xxxxxxxx</para>
            /// </summary>
            [NameInMap("agentApiId")]
            [Validation(Required=false)]
            public string AgentApiId { get; set; }

            /// <summary>
            /// <para>The name of the associated agent API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>petstore</para>
            /// </summary>
            [NameInMap("agentApiName")]
            [Validation(Required=false)]
            public string AgentApiName { get; set; }

            /// <summary>
            /// <para>The ID of the associated API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-xxx</para>
            /// </summary>
            [NameInMap("apiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The name of the associated API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>petstore</para>
            /// </summary>
            [NameInMap("apiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The ID of the associated MCP route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hr-xxxxxxxx</para>
            /// </summary>
            [NameInMap("mcpRouteId")]
            [Validation(Required=false)]
            public string McpRouteId { get; set; }

            /// <summary>
            /// <para>The ID of the associated MCP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-adfefz24afg</para>
            /// </summary>
            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

            /// <summary>
            /// <para>The name of the associated MCP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-mcp</para>
            /// </summary>
            [NameInMap("mcpServerName")]
            [Validation(Required=false)]
            public string McpServerName { get; set; }

            /// <summary>
            /// <para>The ID of the associated model API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-xxxxxxxx</para>
            /// </summary>
            [NameInMap("modelApiId")]
            [Validation(Required=false)]
            public string ModelApiId { get; set; }

            /// <summary>
            /// <para>The name of the associated model API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>petstore</para>
            /// </summary>
            [NameInMap("modelApiName")]
            [Validation(Required=false)]
            public string ModelApiName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-123456</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

    }

}
