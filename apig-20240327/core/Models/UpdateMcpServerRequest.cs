// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateMcpServerRequest : TeaModel {
        /// <summary>
        /// <para>The list of assembly sources. This parameter is required when the type parameter is set to AssemblyMCP.</para>
        /// </summary>
        [NameInMap("assembledSources")]
        [Validation(Required=false)]
        public List<UpdateMcpServerRequestAssembledSources> AssembledSources { get; set; }
        public class UpdateMcpServerRequestAssembledSources : TeaModel {
            /// <summary>
            /// <para>The MCP server ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-afaefaefaf</para>
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
            /// <para>The MCP tools.</para>
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
                /// <para>The service port (omit for dynamic ports).</para>
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
                /// <para>The traffic weight percentage.</para>
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
        /// <para>Specifies the type of source for MCP server creation.</para>
        /// </summary>
        [NameInMap("createFromType")]
        [Validation(Required=false)]
        public string CreateFromType { get; set; }

        /// <summary>
        /// <para>The description.</para>
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
        /// <para>The exposed URI path. This parameter is required when the protocol parameter is set to SSE or StreamableHTTP and the type parameter is set to RealMCP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/sse</para>
        /// </summary>
        [NameInMap("exposedUriPath")]
        [Validation(Required=false)]
        public string ExposedUriPath { get; set; }

        [NameInMap("grayMcpServerConfigs")]
        [Validation(Required=false)]
        public List<UpdateMcpServerRequestGrayMcpServerConfigs> GrayMcpServerConfigs { get; set; }
        public class UpdateMcpServerRequestGrayMcpServerConfigs : TeaModel {
            [NameInMap("backendConfig")]
            [Validation(Required=false)]
            public UpdateMcpServerRequestGrayMcpServerConfigsBackendConfig BackendConfig { get; set; }
            public class UpdateMcpServerRequestGrayMcpServerConfigsBackendConfig : TeaModel {
                [NameInMap("scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("services")]
                [Validation(Required=false)]
                public List<UpdateMcpServerRequestGrayMcpServerConfigsBackendConfigServices> Services { get; set; }
                public class UpdateMcpServerRequestGrayMcpServerConfigsBackendConfigServices : TeaModel {
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
        /// <para>Specifies if MCP observability is enabled. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("mcpStatisticsEnable")]
        [Validation(Required=false)]
        public bool? McpStatisticsEnable { get; set; }

        /// <summary>
        /// <para>The service protocol. Valid values: HTTP, HTTPS, SSE, and StreamableHTTP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The MCP server type. Valid values: RealMCP and AssemblyMCP.</para>
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
