// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetMcpServerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMcpServerResponseBodyData Data { get; set; }
        public class GetMcpServerResponseBodyData : TeaModel {
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
            public List<GetMcpServerResponseBodyDataDomainInfos> DomainInfos { get; set; }
            public class GetMcpServerResponseBodyDataDomainInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.abc.com">www.abc.com</a></para>
                /// </summary>
                [NameInMap("domainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>verifyicket</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTTP,HTTPS</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

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
            /// <para>gw-cq2vundlhtg***</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;product_code\&quot;:\&quot;apigw\&quot;}</para>
            /// </summary>
            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpRouteMatch Match { get; set; }

            [NameInMap("mcpServerConfig")]
            [Validation(Required=false)]
            public string McpServerConfig { get; set; }

            /// <summary>
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
            public GetMcpServerResponseBodyDataNacosMcpSyncInfo NacosMcpSyncInfo { get; set; }
            public class GetMcpServerResponseBodyDataNacosMcpSyncInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>mse-xxxxx</para>
                /// </summary>
                [NameInMap("importInstanceId")]
                [Validation(Required=false)]
                public string ImportInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-mcp</para>
                /// </summary>
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
            /// <para>test-mcp</para>
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
            /// <para>hr-cr82undlhtgrlej***</para>
            /// </summary>
            [NameInMap("routeId")]
            [Validation(Required=false)]
            public string RouteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RealMCP</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
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
