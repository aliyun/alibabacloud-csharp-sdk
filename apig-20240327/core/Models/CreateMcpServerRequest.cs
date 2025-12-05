// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateMcpServerRequest : TeaModel {
        /// <summary>
        /// <para>The list of assembly sources. This parameter is required when the type parameter is set to AssemblyMCP.</para>
        /// </summary>
        [NameInMap("assembledSources")]
        [Validation(Required=false)]
        public List<CreateMcpServerRequestAssembledSources> AssembledSources { get; set; }
        public class CreateMcpServerRequestAssembledSources : TeaModel {
            /// <summary>
            /// <para>The MCP server ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-sdfa3qgavz</para>
            /// </summary>
            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

            /// <summary>
            /// <para>The name of the MCP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-mcp</para>
            /// </summary>
            [NameInMap("mcpServerName")]
            [Validation(Required=false)]
            public string McpServerName { get; set; }

            /// <summary>
            /// <para>The list of the MCP tools.</para>
            /// </summary>
            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<string> Tools { get; set; }

        }

        /// <summary>
        /// <para>The backend service configurations for the route.</para>
        /// </summary>
        [NameInMap("backendConfig")]
        [Validation(Required=false)]
        public CreateMcpServerRequestBackendConfig BackendConfig { get; set; }
        public class CreateMcpServerRequestBackendConfig : TeaModel {
            /// <summary>
            /// <para>The scenario of the backend service.</para>
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
                /// <item><description>HTTP</description></item>
                /// <item><description>HTTPS</description></item>
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
        /// <para>Creates the MCP server from the specified type.</para>
        /// </summary>
        [NameInMap("createFromType")]
        [Validation(Required=false)]
        public string CreateFromType { get; set; }

        /// <summary>
        /// <para>The MCP server description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mcp tool fetch time</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The domain IDs.</para>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>The exposed URI path. This parameter is required when the protocol parameter is set to SSE or StreamableHTTP, and the type parameter is set to RealMCP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/sse</para>
        /// </summary>
        [NameInMap("exposedUriPath")]
        [Validation(Required=false)]
        public string ExposedUriPath { get; set; }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtgi6qac0</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("grayMcpServerConfigs")]
        [Validation(Required=false)]
        public List<CreateMcpServerRequestGrayMcpServerConfigs> GrayMcpServerConfigs { get; set; }
        public class CreateMcpServerRequestGrayMcpServerConfigs : TeaModel {
            [NameInMap("backendConfig")]
            [Validation(Required=false)]
            public CreateMcpServerRequestGrayMcpServerConfigsBackendConfig BackendConfig { get; set; }
            public class CreateMcpServerRequestGrayMcpServerConfigsBackendConfig : TeaModel {
                [NameInMap("scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("services")]
                [Validation(Required=false)]
                public List<CreateMcpServerRequestGrayMcpServerConfigsBackendConfigServices> Services { get; set; }
                public class CreateMcpServerRequestGrayMcpServerConfigsBackendConfigServices : TeaModel {
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

            }

            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpRouteMatch Match { get; set; }

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
        /// <para>Specifies whether MCP observability is enabled. Default: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("mcpStatisticsEnable")]
        [Validation(Required=false)]
        public bool? McpStatisticsEnable { get; set; }

        /// <summary>
        /// <para>The name of the MCP server. The name must match the regular expression ^<a href="%5B-a-z0-9%5D%5C*%5Ba-z0-9%5D">a-z0-9</a>?(.<a href="%5B-a-z0-9%5D%5C*%5Ba-z0-9%5D">a-z0-9</a>?)\*$ and can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fetch-time</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values: HTTP, HTTPS, SSE, and StreamableHTTP</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The type. Valid value:</para>
        /// <para>RealMCP: regular MCP service</para>
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
