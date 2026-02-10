// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpRoute : TeaModel {
        /// <summary>
        /// <para>The backend configuration</para>
        /// </summary>
        [NameInMap("backend")]
        [Validation(Required=false)]
        public Backend Backend { get; set; }

        /// <summary>
        /// <para>builtin</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("builtin")]
        [Validation(Required=false)]
        public string Builtin { get; set; }

        /// <summary>
        /// <para>The creation timestamp in milliseconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>1726649310593</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The deployment status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deployed</para>
        /// </summary>
        [NameInMap("deployStatus")]
        [Validation(Required=false)]
        public string DeployStatus { get; set; }

        /// <summary>
        /// <para>The description of the route</para>
        /// 
        /// <b>Example:</b>
        /// <para>Route for user management API</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>List of domain information</para>
        /// </summary>
        [NameInMap("domainInfos")]
        [Validation(Required=false)]
        public List<HttpRouteDomainInfos> DomainInfos { get; set; }
        public class HttpRouteDomainInfos : TeaModel {
            /// <summary>
            /// <para>The domain ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-cr3v7dllhtgi9s***</para>
            /// </summary>
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The domain name</para>
            /// 
            /// <b>Example:</b>
            /// <para>itemcenter.dev</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The domain protocol</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The environment information</para>
        /// </summary>
        [NameInMap("environmentInfo")]
        [Validation(Required=false)]
        public HttpRouteEnvironmentInfo EnvironmentInfo { get; set; }
        public class HttpRouteEnvironmentInfo : TeaModel {
            /// <summary>
            /// <para>The environment alias</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The environment ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-crhq1u5lhtgju***</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The gateway information</para>
            /// </summary>
            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public HttpRouteEnvironmentInfoGatewayInfo GatewayInfo { get; set; }
            public class HttpRouteEnvironmentInfoGatewayInfo : TeaModel {
                /// <summary>
                /// <para>The gateway ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-cqoohqtlh***</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The gateway name</para>
                /// 
                /// <b>Example:</b>
                /// <para>itemcenter-gateway</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The environment name</para>
            /// 
            /// <b>Example:</b>
            /// <para>itemcenter-pre</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>List of subdomain information</para>
            /// </summary>
            [NameInMap("subDomains")]
            [Validation(Required=false)]
            public List<HttpRouteEnvironmentInfoSubDomains> SubDomains { get; set; }
            public class HttpRouteEnvironmentInfoSubDomains : TeaModel {
                /// <summary>
                /// <para>The subdomain ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-cqu19hdlhtgjuv4***</para>
                /// </summary>
                [NameInMap("domainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                /// <summary>
                /// <para>The subdomain name</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-crmic3llht***-cn-hangzhou-vpc.alicloudapi.com</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>networkType</para>
                /// 
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("networkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The subdomain protocol</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

        }

        /// <summary>
        /// <para>gatewayStatus</para>
        /// </summary>
        [NameInMap("gatewayStatus")]
        [Validation(Required=false)]
        public Dictionary<string, string> GatewayStatus { get; set; }

        /// <summary>
        /// <para>The route matching rules</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public HttpRouteMatch Match { get; set; }

        /// <summary>
        /// <para>The MCP server information</para>
        /// </summary>
        [NameInMap("mcpServerInfo")]
        [Validation(Required=false)]
        public HttpRouteMcpServerInfo McpServerInfo { get; set; }
        public class HttpRouteMcpServerInfo : TeaModel {
            /// <summary>
            /// <para>The creation type</para>
            /// 
            /// <b>Example:</b>
            /// <para>Nacos</para>
            /// </summary>
            [NameInMap("createFromType")]
            [Validation(Required=false)]
            public string CreateFromType { get; set; }

            /// <summary>
            /// <para>The imported instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>import-001</para>
            /// </summary>
            [NameInMap("importInstanceId")]
            [Validation(Required=false)]
            public string ImportInstanceId { get; set; }

            /// <summary>
            /// <para>The imported Nacos MCP server ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-002</para>
            /// </summary>
            [NameInMap("importMcpServerId")]
            [Validation(Required=false)]
            public string ImportMcpServerId { get; set; }

            /// <summary>
            /// <para>The imported namespace</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("importNamespace")]
            [Validation(Required=false)]
            public string ImportNamespace { get; set; }

            /// <summary>
            /// <para>The MCP route configuration</para>
            /// </summary>
            [NameInMap("mcpRouteConfig")]
            [Validation(Required=false)]
            public HttpRouteMcpServerInfoMcpRouteConfig McpRouteConfig { get; set; }
            public class HttpRouteMcpServerInfoMcpRouteConfig : TeaModel {
                /// <summary>
                /// <para>mcp route path</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mcp</para>
                /// </summary>
                [NameInMap("exposedUriPath")]
                [Validation(Required=false)]
                public string ExposedUriPath { get; set; }

                /// <summary>
                /// <para>The MCP protocol</para>
                /// 
                /// <b>Example:</b>
                /// <para>SSE</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The MCP server configuration content</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;config\&quot;:{}}</para>
            /// </summary>
            [NameInMap("mcpServerConfig")]
            [Validation(Required=false)]
            public string McpServerConfig { get; set; }

        }

        /// <summary>
        /// <para>The name of the route</para>
        /// 
        /// <b>Example:</b>
        /// <para>itemcenter-pre-route</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique identifier of the route</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr-crf5l7tlhtgp91t***</para>
        /// </summary>
        [NameInMap("routeId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

        /// <summary>
        /// <para>The last update timestamp in milliseconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>1726819895636</para>
        /// </summary>
        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
