// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateMcpServerRequest : TeaModel {
        /// <summary>
        /// <para>The list of assembled sources. This parameter is required when type is AssemblyMCP.</para>
        /// </summary>
        [NameInMap("assembledSources")]
        [Validation(Required=false)]
        public List<UpdateMcpServerRequestAssembledSources> AssembledSources { get; set; }
        public class UpdateMcpServerRequestAssembledSources : TeaModel {
            /// <summary>
            /// <para>MCP Server ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-afaefaefaf</para>
            /// </summary>
            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

            /// <summary>
            /// <para>The MCP server name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-mcp</para>
            /// </summary>
            [NameInMap("mcpServerName")]
            [Validation(Required=false)]
            public string McpServerName { get; set; }

            /// <summary>
            /// <para>The list of MCP tools.</para>
            /// </summary>
            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<string> Tools { get; set; }

        }

        /// <summary>
        /// <para>The backend service configuration of the route.</para>
        /// </summary>
        [NameInMap("backendConfig")]
        [Validation(Required=false)]
        public UpdateMcpServerRequestBackendConfig BackendConfig { get; set; }
        public class UpdateMcpServerRequestBackendConfig : TeaModel {
            /// <summary>
            /// <para>The backend service scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SingleService</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The backend services.</para>
            /// </summary>
            [NameInMap("services")]
            [Validation(Required=false)]
            public List<UpdateMcpServerRequestBackendConfigServices> Services { get; set; }
            public class UpdateMcpServerRequestBackendConfigServices : TeaModel {
                /// <summary>
                /// <para>The service port. Do not specify this parameter for dynamic ports.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The service protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TCP</description></item>
                /// <item><description>HTTP</description></item>
                /// <item><description>DUBBO</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>svc-cr6pk4tlhtgm58e***</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The percentage value of the traffic ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>The creation source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ApiGatewayHttpToMCP: gateway-managed HTTP-to-MCP conversion.</description></item>
        /// <item><description>ApiGatewayProxyMcpHosting: gateway-managed MCP direct proxy.</description></item>
        /// <item><description>ApiGatewayAssembly: gateway MCP assembly.</description></item>
        /// <item><description>NacosHttpToMCP: gateway-managed Nacos-synced HTTP-to-MCP conversion.</description></item>
        /// <item><description>NacosMcpHosting: gateway-managed Nacos-synced MCP direct proxy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ApiGatewayMcpHosting</para>
        /// </summary>
        [NameInMap("createFromType")]
        [Validation(Required=false)]
        public string CreateFromType { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>商品中心服务路由</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The domain name IDs.</para>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>The exposed URI path. This parameter is required when protocol is SSE or StreamableHTTP and type is RealMCP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/sse</para>
        /// </summary>
        [NameInMap("exposedUriPath")]
        [Validation(Required=false)]
        public string ExposedUriPath { get; set; }

        /// <summary>
        /// <para>The list of canary release MCP server route configurations.</para>
        /// </summary>
        [NameInMap("grayMcpServerConfigs")]
        [Validation(Required=false)]
        public List<UpdateMcpServerRequestGrayMcpServerConfigs> GrayMcpServerConfigs { get; set; }
        public class UpdateMcpServerRequestGrayMcpServerConfigs : TeaModel {
            /// <summary>
            /// <para>The backend configuration.</para>
            /// </summary>
            [NameInMap("backendConfig")]
            [Validation(Required=false)]
            public UpdateMcpServerRequestGrayMcpServerConfigsBackendConfig BackendConfig { get; set; }
            public class UpdateMcpServerRequestGrayMcpServerConfigsBackendConfig : TeaModel {
                /// <summary>
                /// <para>The backend scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SingleService</para>
                /// </summary>
                [NameInMap("scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The list of backend services.</para>
                /// </summary>
                [NameInMap("services")]
                [Validation(Required=false)]
                public List<UpdateMcpServerRequestGrayMcpServerConfigsBackendConfigServices> Services { get; set; }
                public class UpdateMcpServerRequestGrayMcpServerConfigsBackendConfigServices : TeaModel {
                    /// <summary>
                    /// <para>The service port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8080</para>
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The service protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The service ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gray-svc-123</para>
                    /// </summary>
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    /// <summary>
                    /// <para>The version number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    /// <summary>
                    /// <para>The weight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

            }

            /// <summary>
            /// <para>The route match rule.</para>
            /// </summary>
            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpRouteMatch Match { get; set; }

            /// <summary>
            /// <para>The route ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>route-123</para>
            /// </summary>
            [NameInMap("routeId")]
            [Validation(Required=false)]
            public string RouteId { get; set; }

        }

        /// <summary>
        /// <para>The route match rule.</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public HttpRouteMatch Match { get; set; }

        /// <summary>
        /// <para>The HTTP-to-MCP configuration.</para>
        /// </summary>
        [NameInMap("mcpServerConfig")]
        [Validation(Required=false)]
        public UpdateMcpServerRequestMcpServerConfig McpServerConfig { get; set; }
        public class UpdateMcpServerRequestMcpServerConfig : TeaModel {
            /// <summary>
            /// <para>The MCP server configuration. This parameter is mutually exclusive with swaggerConfig.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-server-spec-yaml</para>
            /// </summary>
            [NameInMap("mcpServerSpec")]
            [Validation(Required=false)]
            public string McpServerSpec { get; set; }

            /// <summary>
            /// <para>The Swagger document for HTTP-to-MCP conversion. The document must comply with the OpenAPI 3.0 specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swagger-content</para>
            /// </summary>
            [NameInMap("swaggerConfig")]
            [Validation(Required=false)]
            public string SwaggerConfig { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable MCP observability. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("mcpStatisticsEnable")]
        [Validation(Required=false)]
        public bool? McpStatisticsEnable { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HTTP: HTTP protocol.</description></item>
        /// <item><description>HTTPS: HTTPS protocol.</description></item>
        /// <item><description>SSE: Server-Sent Events protocol.</description></item>
        /// <item><description>StreamableHTTP: Streamable HTTP protocol.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The MCP server type filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RealMCP</description></item>
        /// <item><description>AssemblyMCP</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RealMCP</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
