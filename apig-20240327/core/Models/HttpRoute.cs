// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpRoute : TeaModel {
        [NameInMap("backend")]
        [Validation(Required=false)]
        public Backend Backend { get; set; }

        [NameInMap("builtin")]
        [Validation(Required=false)]
        public string Builtin { get; set; }

        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("deployStatus")]
        [Validation(Required=false)]
        public string DeployStatus { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domainInfos")]
        [Validation(Required=false)]
        public List<HttpRouteDomainInfos> DomainInfos { get; set; }
        public class HttpRouteDomainInfos : TeaModel {
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        [NameInMap("environmentInfo")]
        [Validation(Required=false)]
        public HttpRouteEnvironmentInfo EnvironmentInfo { get; set; }
        public class HttpRouteEnvironmentInfo : TeaModel {
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public HttpRouteEnvironmentInfoGatewayInfo GatewayInfo { get; set; }
            public class HttpRouteEnvironmentInfoGatewayInfo : TeaModel {
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("subDomains")]
            [Validation(Required=false)]
            public List<HttpRouteEnvironmentInfoSubDomains> SubDomains { get; set; }
            public class HttpRouteEnvironmentInfoSubDomains : TeaModel {
                [NameInMap("domainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("networkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

        }

        [NameInMap("gatewayStatus")]
        [Validation(Required=false)]
        public Dictionary<string, string> GatewayStatus { get; set; }

        [NameInMap("match")]
        [Validation(Required=false)]
        public HttpRouteMatch Match { get; set; }

        [NameInMap("mcpServerInfo")]
        [Validation(Required=false)]
        public HttpRouteMcpServerInfo McpServerInfo { get; set; }
        public class HttpRouteMcpServerInfo : TeaModel {
            [NameInMap("createFromType")]
            [Validation(Required=false)]
            public string CreateFromType { get; set; }

            [NameInMap("importInstanceId")]
            [Validation(Required=false)]
            public string ImportInstanceId { get; set; }

            [NameInMap("importMcpServerId")]
            [Validation(Required=false)]
            public string ImportMcpServerId { get; set; }

            [NameInMap("importNamespace")]
            [Validation(Required=false)]
            public string ImportNamespace { get; set; }

            [NameInMap("mcpRouteConfig")]
            [Validation(Required=false)]
            public HttpRouteMcpServerInfoMcpRouteConfig McpRouteConfig { get; set; }
            public class HttpRouteMcpServerInfoMcpRouteConfig : TeaModel {
                [NameInMap("exposedUriPath")]
                [Validation(Required=false)]
                public string ExposedUriPath { get; set; }

                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            [NameInMap("mcpServerConfig")]
            [Validation(Required=false)]
            public string McpServerConfig { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("routeId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
