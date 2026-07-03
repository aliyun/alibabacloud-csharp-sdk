// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetMcpServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
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
        public GetMcpServerResponseBodyData Data { get; set; }
        public class GetMcpServerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>API ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-xxx</para>
            /// </summary>
            [NameInMap("apiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The list of assembly sources. This parameter is required when type is AssemblyMCP.</para>
            /// </summary>
            [NameInMap("assembledSources")]
            [Validation(Required=false)]
            public List<GetMcpServerResponseBodyDataAssembledSources> AssembledSources { get; set; }
            public class GetMcpServerResponseBodyDataAssembledSources : TeaModel {
                /// <summary>
                /// <para>MCP Server ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>mcp-xdafeafzz</para>
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
            /// <para>The backend service of the route.</para>
            /// </summary>
            [NameInMap("backend")]
            [Validation(Required=false)]
            public Backend Backend { get; set; }

            /// <summary>
            /// <para>The creation source type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ApiGatewayHttpToMCP: gateway-managed HTTP-to-MCP conversion.</description></item>
            /// <item><description>ApiGatewayMcpHosting: gateway-managed MCP direct proxy.</description></item>
            /// <item><description>ApiGatewayAssembly: gateway MCP assembly.</description></item>
            /// <item><description>NacosHttpToMCP: gateway-managed Nacos-synced HTTP-to-MCP conversion.</description></item>
            /// <item><description>NacosMcpHosting: gateway-managed Nacos-synced MCP direct proxy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ApiGatewayHttpToMCP</para>
            /// </summary>
            [NameInMap("createFromType")]
            [Validation(Required=false)]
            public string CreateFromType { get; set; }

            /// <summary>
            /// <para>The publish status of the API in the current environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("deployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试专用MCP Server</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of domain name IDs.</para>
            /// </summary>
            [NameInMap("domainIds")]
            [Validation(Required=false)]
            public List<string> DomainIds { get; set; }

            /// <summary>
            /// <para>The list of domain name information.</para>
            /// </summary>
            [NameInMap("domainInfos")]
            [Validation(Required=false)]
            public List<GetMcpServerResponseBodyDataDomainInfos> DomainInfos { get; set; }
            public class GetMcpServerResponseBodyDataDomainInfos : TeaModel {
                /// <summary>
                /// <para>The domain name ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.abc.com">www.abc.com</a></para>
                /// </summary>
                [NameInMap("domainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>verifyicket</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP,HTTPS</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The environment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

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
            /// <para>The gateway instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-cq2vundlhtg***</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The canary release route configurations.</para>
            /// </summary>
            [NameInMap("grayMcpServerConfigs")]
            [Validation(Required=false)]
            public List<GetMcpServerResponseBodyDataGrayMcpServerConfigs> GrayMcpServerConfigs { get; set; }
            public class GetMcpServerResponseBodyDataGrayMcpServerConfigs : TeaModel {
                /// <summary>
                /// <para>The canary release route backend configuration.</para>
                /// </summary>
                [NameInMap("backendConfig")]
                [Validation(Required=false)]
                public GetMcpServerResponseBodyDataGrayMcpServerConfigsBackendConfig BackendConfig { get; set; }
                public class GetMcpServerResponseBodyDataGrayMcpServerConfigsBackendConfig : TeaModel {
                    /// <summary>
                    /// <para>The backend scene.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SingleService</para>
                    /// </summary>
                    [NameInMap("scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The list of service configurations.</para>
                    /// </summary>
                    [NameInMap("services")]
                    [Validation(Required=false)]
                    public List<GetMcpServerResponseBodyDataGrayMcpServerConfigsBackendConfigServices> Services { get; set; }
                    public class GetMcpServerResponseBodyDataGrayMcpServerConfigsBackendConfigServices : TeaModel {
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
                        /// <para>svc-xxx</para>
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
                /// <para>The canary release route match rule.</para>
                /// </summary>
                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpRouteMatch Match { get; set; }

                /// <summary>
                /// <para>The canary release route ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gray-route-xxx</para>
                /// </summary>
                [NameInMap("routeId")]
                [Validation(Required=false)]
                public string RouteId { get; set; }

            }

            /// <summary>
            /// <para>The route match rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;product_code\&quot;:\&quot;apigw\&quot;}</para>
            /// </summary>
            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpRouteMatch Match { get; set; }

            /// <summary>
            /// <para>The HTTP-to-MCP configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MCP Server配置 base64</para>
            /// </summary>
            [NameInMap("mcpServerConfig")]
            [Validation(Required=false)]
            public string McpServerConfig { get; set; }

            /// <summary>
            /// <para>The MCP server plugin configuration attachment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-adfaefwaef</para>
            /// </summary>
            [NameInMap("mcpServerConfigPluginAttachmentId")]
            [Validation(Required=false)]
            public string McpServerConfigPluginAttachmentId { get; set; }

            /// <summary>
            /// <para>MCP Server ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-adfefz24afg</para>
            /// </summary>
            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

            /// <summary>
            /// <para>The MCP server access path provided by the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/mcp-servers/test-mcp</para>
            /// </summary>
            [NameInMap("mcpServerPath")]
            [Validation(Required=false)]
            public string McpServerPath { get; set; }

            /// <summary>
            /// <para>Specifies whether MCP observability is enabled. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("mcpStatisticsEnable")]
            [Validation(Required=false)]
            public bool? McpStatisticsEnable { get; set; }

            /// <summary>
            /// <para>The Nacos-synced managed MCP information.</para>
            /// </summary>
            [NameInMap("nacosMcpSyncInfo")]
            [Validation(Required=false)]
            public GetMcpServerResponseBodyDataNacosMcpSyncInfo NacosMcpSyncInfo { get; set; }
            public class GetMcpServerResponseBodyDataNacosMcpSyncInfo : TeaModel {
                /// <summary>
                /// <para>The Nacos instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse-xxxxx</para>
                /// </summary>
                [NameInMap("importInstanceId")]
                [Validation(Required=false)]
                public string ImportInstanceId { get; set; }

                /// <summary>
                /// <para>The synced MCP server ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-mcp</para>
                /// </summary>
                [NameInMap("importMcpServerId")]
                [Validation(Required=false)]
                public string ImportMcpServerId { get; set; }

                /// <summary>
                /// <para>The Nacos namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-ns</para>
                /// </summary>
                [NameInMap("importNamespace")]
                [Validation(Required=false)]
                public string ImportNamespace { get; set; }

            }

            /// <summary>
            /// <para>The MCP server name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-mcp</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
            /// <para>The route ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hr-cr82undlhtgrlej***</para>
            /// </summary>
            [NameInMap("routeId")]
            [Validation(Required=false)]
            public string RouteId { get; set; }

            /// <summary>
            /// <para>The MCP server type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RealMCP</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A6E90D5-A711-54F4-A489-E33C2021EDDF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
