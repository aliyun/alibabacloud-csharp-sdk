// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListMcpServersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMcpServersResponseBodyData Data { get; set; }
        public class ListMcpServersResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListMcpServersResponseBodyDataItems> Items { get; set; }
            public class ListMcpServersResponseBodyDataItems : TeaModel {
                [NameInMap("apiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("assembledSources")]
                [Validation(Required=false)]
                public List<ListMcpServersResponseBodyDataItemsAssembledSources> AssembledSources { get; set; }
                public class ListMcpServersResponseBodyDataItemsAssembledSources : TeaModel {
                    /// <summary>
                    /// <para>MCP Server ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-adfef2334fa</para>
                    /// </summary>
                    [NameInMap("mcpServerId")]
                    [Validation(Required=false)]
                    public string McpServerId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-mcp</para>
                    /// </summary>
                    [NameInMap("mcpServerName")]
                    [Validation(Required=false)]
                    public string McpServerName { get; set; }

                    [NameInMap("tools")]
                    [Validation(Required=false)]
                    public List<string> Tools { get; set; }

                }

                [NameInMap("backend")]
                [Validation(Required=false)]
                public Backend Backend { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ApiGatewayHttpToMCP</para>
                /// </summary>
                [NameInMap("createFromType")]
                [Validation(Required=false)]
                public string CreateFromType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Deployed</para>
                /// </summary>
                [NameInMap("deployStatus")]
                [Validation(Required=false)]
                public string DeployStatus { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("domainIds")]
                [Validation(Required=false)]
                public List<string> DomainIds { get; set; }

                [NameInMap("domainInfos")]
                [Validation(Required=false)]
                public List<HttpApiDomainInfo> DomainInfos { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/sse</para>
                /// </summary>
                [NameInMap("exposedUriPath")]
                [Validation(Required=false)]
                public string ExposedUriPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-cpv54p5***</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpRouteMatch Match { get; set; }

                [NameInMap("mcpServerConfig")]
                [Validation(Required=false)]
                public string McpServerConfig { get; set; }

                /// <summary>
                /// <para>MCP Server ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>mcp-feaff34va</para>
                /// </summary>
                [NameInMap("mcpServerId")]
                [Validation(Required=false)]
                public string McpServerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/mcp-servers/test-mcp</para>
                /// </summary>
                [NameInMap("mcpServerPath")]
                [Validation(Required=false)]
                public string McpServerPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("mcpStatisticsEnable")]
                [Validation(Required=false)]
                public bool? McpStatisticsEnable { get; set; }

                [NameInMap("nacosMcpSyncInfo")]
                [Validation(Required=false)]
                public ListMcpServersResponseBodyDataItemsNacosMcpSyncInfo NacosMcpSyncInfo { get; set; }
                public class ListMcpServersResponseBodyDataItemsNacosMcpSyncInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mse-faefrefxz</para>
                    /// </summary>
                    [NameInMap("importInstanceId")]
                    [Validation(Required=false)]
                    public string ImportInstanceId { get; set; }

                    [NameInMap("importMcpServerId")]
                    [Validation(Required=false)]
                    public string ImportMcpServerId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-ns</para>
                    /// </summary>
                    [NameInMap("importNamespace")]
                    [Validation(Required=false)]
                    public string ImportNamespace { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>itemcenter-dev-cluster</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hr-d11cj86m1hkvop6mp42g</para>
                /// </summary>
                [NameInMap("routeId")]
                [Validation(Required=false)]
                public string RouteId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>585657D2-1C20-5B8A-AF17-D727C6490BE4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
