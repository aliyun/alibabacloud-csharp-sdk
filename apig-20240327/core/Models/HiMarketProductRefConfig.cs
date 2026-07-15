// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketProductRefConfig : TeaModel {
        /// <summary>
        /// <para>The APIG resource reference configuration.</para>
        /// </summary>
        [NameInMap("apigRefConfig")]
        [Validation(Required=false)]
        public HiMarketProductRefConfigApigRefConfig ApigRefConfig { get; set; }
        public class HiMarketProductRefConfigApigRefConfig : TeaModel {
            /// <summary>
            /// <para>The associated Agent API ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-xxx</para>
            /// </summary>
            [NameInMap("agentApiId")]
            [Validation(Required=false)]
            public string AgentApiId { get; set; }

            /// <summary>
            /// <para>The Agent API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-api</para>
            /// </summary>
            [NameInMap("agentApiName")]
            [Validation(Required=false)]
            public string AgentApiName { get; set; }

            /// <summary>
            /// <para>The associated MCP route ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>route-xxx</para>
            /// </summary>
            [NameInMap("mcpRouteId")]
            [Validation(Required=false)]
            public string McpRouteId { get; set; }

            /// <summary>
            /// <para>The associated MCP Server ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-xxx</para>
            /// </summary>
            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

            /// <summary>
            /// <para>The MCP Server name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-mcp-server</para>
            /// </summary>
            [NameInMap("mcpServerName")]
            [Validation(Required=false)]
            public string McpServerName { get; set; }

            /// <summary>
            /// <para>The associated Model API ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-yyy</para>
            /// </summary>
            [NameInMap("modelApiId")]
            [Validation(Required=false)]
            public string ModelApiId { get; set; }

            /// <summary>
            /// <para>The Model API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-model-api</para>
            /// </summary>
            [NameInMap("modelApiName")]
            [Validation(Required=false)]
            public string ModelApiName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the associated gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

    }

}
