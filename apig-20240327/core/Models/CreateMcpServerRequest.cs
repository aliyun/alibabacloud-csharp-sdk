// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateMcpServerRequest : TeaModel {
        /// <summary>
        /// <para>The list of assembled sources. This parameter is required when type is set to AssemblyMCP.</para>
        /// </summary>
        [NameInMap("assembledSources")]
        [Validation(Required=false)]
        public List<CreateMcpServerRequestAssembledSources> AssembledSources { get; set; }
        public class CreateMcpServerRequestAssembledSources : TeaModel {
            /// <summary>
            /// <para>MCP Server ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-sdfa3qgavz</para>
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
        public CreateMcpServerRequestBackendConfig BackendConfig { get; set; }
        public class CreateMcpServerRequestBackendConfig : TeaModel {
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
            public List<CreateMcpServerRequestBackendConfigServices> Services { get; set; }
            public class CreateMcpServerRequestBackendConfigServices : TeaModel {
                /// <summary>
                /// <para>The backend node port of the service.</para>
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
                /// <item><description>HTTP.</description></item>
                /// <item><description>HTTPS.</description></item>
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
                /// <para>svc-crbgq0dlhtgr***</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.1.6</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The weight.</para>
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
        /// <para>ApiGatewayHttpToMCP: gateway-managed HTTP-to-MCP conversion.
        /// ApiGatewayProxyMcpHosting: gateway-managed direct MCP proxy.
        /// ApiGatewayAssembly: gateway MCP assembly.
        /// NacosHttpToMCP: gateway-managed Nacos-synced HTTP-to-MCP conversion.
        /// NacosMcpHosting: gateway-managed Nacos-synced direct MCP proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApiGatewayMcpHosting</para>
        /// </summary>
        [NameInMap("createFromType")]
        [Validation(Required=false)]
        public string CreateFromType { get; set; }

        /// <summary>
        /// <para>The description of the MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mcp tool fetch time</para>
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
        /// <para>The exposed URI path. This parameter is required when protocol is set to SSE or StreamableHTTP and type is set to RealMCP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/sse</para>
        /// </summary>
        [NameInMap("exposedUriPath")]
        [Validation(Required=false)]
        public string ExposedUriPath { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtgi6qac0</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The canary release route configurations.</para>
        /// </summary>
        [NameInMap("grayMcpServerConfigs")]
        [Validation(Required=false)]
        public List<CreateMcpServerRequestGrayMcpServerConfigs> GrayMcpServerConfigs { get; set; }
        public class CreateMcpServerRequestGrayMcpServerConfigs : TeaModel {
            /// <summary>
            /// <para>The backend configuration.</para>
            /// </summary>
            [NameInMap("backendConfig")]
            [Validation(Required=false)]
            public CreateMcpServerRequestGrayMcpServerConfigsBackendConfig BackendConfig { get; set; }
            public class CreateMcpServerRequestGrayMcpServerConfigsBackendConfig : TeaModel {
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
                /// <para>The backend services.</para>
                /// </summary>
                [NameInMap("services")]
                [Validation(Required=false)]
                public List<CreateMcpServerRequestGrayMcpServerConfigsBackendConfigServices> Services { get; set; }
                public class CreateMcpServerRequestGrayMcpServerConfigsBackendConfigServices : TeaModel {
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
                    /// <para>svc-gray</para>
                    /// </summary>
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    /// <summary>
                    /// <para>The service version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v2.0.0</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    /// <summary>
                    /// <para>The service weight.</para>
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
            /// <para>gray-route-123</para>
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
        public CreateMcpServerRequestMcpServerConfig McpServerConfig { get; set; }
        public class CreateMcpServerRequestMcpServerConfig : TeaModel {
            /// <summary>
            /// <para>The MCP server spec configuration. This parameter is mutually exclusive with swaggerConfig.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-spec.yaml</para>
            /// </summary>
            [NameInMap("mcpServerSpec")]
            [Validation(Required=false)]
            public string McpServerSpec { get; set; }

            /// <summary>
            /// <para>The Swagger document for HTTP-to-MCP conversion. The document must comply with the OpenAPI 3.0 specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swagger.yaml</para>
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
        /// <para>The MCP server name. The name must match the regular expression ^<a href="%5B-a-z0-9%5D*%5Ba-z0-9%5D">a-z0-9</a>?(\.<a href="%5B-a-z0-9%5D*%5Ba-z0-9%5D">a-z0-9</a>?)*$ and cannot exceed 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fetch-time</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values: HTTP, HTTPS, SSE, and StreamableHTTP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The type. Valid values:</para>
        /// <para>RealMCP: standard MCP service.</para>
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
