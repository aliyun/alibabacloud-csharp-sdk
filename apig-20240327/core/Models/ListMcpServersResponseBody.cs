// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListMcpServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response payload.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMcpServersResponseBodyData Data { get; set; }
        public class ListMcpServersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of MCP servers.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListMcpServersResponseBodyDataItems> Items { get; set; }
            public class ListMcpServersResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The API ID.</para>
                /// </summary>
                [NameInMap("apiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The list of assembly sources. This parameter is required when the type parameter is set to AssemblyMCP.</para>
                /// </summary>
                [NameInMap("assembledSources")]
                [Validation(Required=false)]
                public List<ListMcpServersResponseBodyDataItemsAssembledSources> AssembledSources { get; set; }
                public class ListMcpServersResponseBodyDataItemsAssembledSources : TeaModel {
                    /// <summary>
                    /// <para>The MCP server ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-adfef2334fa</para>
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
                /// <para>The type of source for MCP server creation. Valid values: </para>
                /// <para>ApiGatewayHttpToMCP 
                /// ApiGatewayMcpHosting 
                /// ApiGatewayAssembly 
                /// NacosHttpToMCP 
                /// NacosMcpHosting</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApiGatewayHttpToMCP</para>
                /// </summary>
                [NameInMap("createFromType")]
                [Validation(Required=false)]
                public string CreateFromType { get; set; }

                /// <summary>
                /// <para>The publishing status of the API in the current environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deployed</para>
                /// </summary>
                [NameInMap("deployStatus")]
                [Validation(Required=false)]
                public string DeployStatus { get; set; }

                /// <summary>
                /// <para>The description.</para>
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
                /// <para>The list of domain information.</para>
                /// </summary>
                [NameInMap("domainInfos")]
                [Validation(Required=false)]
                public List<HttpApiDomainInfo> DomainInfos { get; set; }

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
                /// <para>The exposed URI path. This parameter is required when the protocol parameter is set to SSE or StreamableHTTP, and the type parameter is set to RealMCP.</para>
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
                /// <para>gw-cpv54p5***</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The route match rule.</para>
                /// </summary>
                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpRouteMatch Match { get; set; }

                /// <summary>
                /// <para>The HTTP-to-MCP configurations.</para>
                /// </summary>
                [NameInMap("mcpServerConfig")]
                [Validation(Required=false)]
                public string McpServerConfig { get; set; }

                /// <summary>
                /// <para>The MCP server ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mcp-feaff34va</para>
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
                /// <para>Indicates whether MCP observability is enabled. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("mcpStatisticsEnable")]
                [Validation(Required=false)]
                public bool? McpStatisticsEnable { get; set; }

                /// <summary>
                /// <para>The MCP information synchronized and managed by Nacos.</para>
                /// </summary>
                [NameInMap("nacosMcpSyncInfo")]
                [Validation(Required=false)]
                public ListMcpServersResponseBodyDataItemsNacosMcpSyncInfo NacosMcpSyncInfo { get; set; }
                public class ListMcpServersResponseBodyDataItemsNacosMcpSyncInfo : TeaModel {
                    /// <summary>
                    /// <para>The Nacos instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mse-faefrefxz</para>
                    /// </summary>
                    [NameInMap("importInstanceId")]
                    [Validation(Required=false)]
                    public string ImportInstanceId { get; set; }

                    /// <summary>
                    /// <para>The synchronized MCP server ID.</para>
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
                /// <para>The name of the MCP server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>itemcenter-dev-cluster</para>
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
                /// <para>The ID of the MCP server associated route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hr-d11cj86m1hkvop6mp42g</para>
                /// </summary>
                [NameInMap("routeId")]
                [Validation(Required=false)]
                public string RouteId { get; set; }

                /// <summary>
                /// <para>The type of the MCP server. Valid values: RealMCP and AssemblyMCP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RealMCP</para>
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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The status message.</para>
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
        /// <para>585657D2-1C20-5B8A-AF17-D727C6490BE4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
