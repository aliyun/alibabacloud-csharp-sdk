// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateMcpServerRequest : TeaModel {
        /// <summary>
        /// <para>Assembled MCP server sources</para>
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
            /// <para>Source MCP server name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-mcp</para>
            /// </summary>
            [NameInMap("mcpServerName")]
            [Validation(Required=false)]
            public string McpServerName { get; set; }

            /// <summary>
            /// <para>List of tool names to include</para>
            /// </summary>
            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<string> Tools { get; set; }

        }

        /// <summary>
        /// <para>Backend configuration</para>
        /// </summary>
        [NameInMap("backendConfig")]
        [Validation(Required=false)]
        public CreateMcpServerRequestBackendConfig BackendConfig { get; set; }
        public class CreateMcpServerRequestBackendConfig : TeaModel {
            /// <summary>
            /// <para>Backend scene type</para>
            /// 
            /// <b>Example:</b>
            /// <para>SingleService</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>List of backend services</para>
            /// </summary>
            [NameInMap("services")]
            [Validation(Required=false)]
            public List<CreateMcpServerRequestBackendConfigServices> Services { get; set; }
            public class CreateMcpServerRequestBackendConfigServices : TeaModel {
                /// <summary>
                /// <para>Service port</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>Service protocol</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>Service ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>svc-crbgq0dlhtgr***</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>Service version</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.1.6</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>Service weight</para>
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
        /// <para>Creation source type</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApiGatewayMcpHosting</para>
        /// </summary>
        [NameInMap("createFromType")]
        [Validation(Required=false)]
        public string CreateFromType { get; set; }

        /// <summary>
        /// <para>MCP server description</para>
        /// 
        /// <b>Example:</b>
        /// <para>mcp tool fetch time</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>List of domain IDs for the MCP server</para>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>Exposed URI path for SSE/StreamableHTTP protocols</para>
        /// 
        /// <b>Example:</b>
        /// <para>/sse</para>
        /// </summary>
        [NameInMap("exposedUriPath")]
        [Validation(Required=false)]
        public string ExposedUriPath { get; set; }

        /// <summary>
        /// <para>Gateway ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtgi6qac0</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Gray route configurations</para>
        /// </summary>
        [NameInMap("grayMcpServerConfigs")]
        [Validation(Required=false)]
        public List<CreateMcpServerRequestGrayMcpServerConfigs> GrayMcpServerConfigs { get; set; }
        public class CreateMcpServerRequestGrayMcpServerConfigs : TeaModel {
            /// <summary>
            /// <para>Backend configuration for gray route</para>
            /// </summary>
            [NameInMap("backendConfig")]
            [Validation(Required=false)]
            public CreateMcpServerRequestGrayMcpServerConfigsBackendConfig BackendConfig { get; set; }
            public class CreateMcpServerRequestGrayMcpServerConfigsBackendConfig : TeaModel {
                /// <summary>
                /// <para>Must be SingleService</para>
                /// 
                /// <b>Example:</b>
                /// <para>SingleService</para>
                /// </summary>
                [NameInMap("scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>Exactly one service</para>
                /// </summary>
                [NameInMap("services")]
                [Validation(Required=false)]
                public List<CreateMcpServerRequestGrayMcpServerConfigsBackendConfigServices> Services { get; set; }
                public class CreateMcpServerRequestGrayMcpServerConfigsBackendConfigServices : TeaModel {
                    /// <summary>
                    /// <para>Service port number</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8080</para>
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>Service protocol type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>Service ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>svc-gray</para>
                    /// </summary>
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    /// <summary>
                    /// <para>Service version</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v2.0.0</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    /// <summary>
                    /// <para>Service weight for load balancing</para>
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
            /// <para>Route matching rules</para>
            /// </summary>
            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpRouteMatch Match { get; set; }

            /// <summary>
            /// <para>Route ID for update operations</para>
            /// 
            /// <b>Example:</b>
            /// <para>gray-route-123</para>
            /// </summary>
            [NameInMap("routeId")]
            [Validation(Required=false)]
            public string RouteId { get; set; }

        }

        /// <summary>
        /// <para>Route matching conditions</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public HttpRouteMatch Match { get; set; }

        /// <summary>
        /// <para>MCP server specification</para>
        /// </summary>
        [NameInMap("mcpServerConfig")]
        [Validation(Required=false)]
        public CreateMcpServerRequestMcpServerConfig McpServerConfig { get; set; }
        public class CreateMcpServerRequestMcpServerConfig : TeaModel {
            /// <summary>
            /// <para>Converted MCP server spec YAML</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-spec.yaml</para>
            /// </summary>
            [NameInMap("mcpServerSpec")]
            [Validation(Required=false)]
            public string McpServerSpec { get; set; }

            /// <summary>
            /// <para>Raw Swagger/OpenAPI document</para>
            /// 
            /// <b>Example:</b>
            /// <para>swagger.yaml</para>
            /// </summary>
            [NameInMap("swaggerConfig")]
            [Validation(Required=false)]
            public string SwaggerConfig { get; set; }

        }

        /// <summary>
        /// <para>Enable MCP statistics</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("mcpStatisticsEnable")]
        [Validation(Required=false)]
        public bool? McpStatisticsEnable { get; set; }

        /// <summary>
        /// <para>MCP server name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fetch-time</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>MCP protocol</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>MCP server type</para>
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
