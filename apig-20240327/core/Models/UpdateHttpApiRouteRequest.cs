// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateHttpApiRouteRequest : TeaModel {
        /// <summary>
        /// <para>The backend service configurations of the route.</para>
        /// </summary>
        [NameInMap("backendConfig")]
        [Validation(Required=false)]
        public UpdateHttpApiRouteRequestBackendConfig BackendConfig { get; set; }
        public class UpdateHttpApiRouteRequestBackendConfig : TeaModel {
            /// <summary>
            /// <para>The backend service scenario.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SingleService</description></item>
            /// <item><description>MultiServiceByRatio</description></item>
            /// <item><description>Redirect</description></item>
            /// <item><description>Mock</description></item>
            /// </list>
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
            public List<UpdateHttpApiRouteRequestBackendConfigServices> Services { get; set; }
            public class UpdateHttpApiRouteRequestBackendConfigServices : TeaModel {
                /// <summary>
                /// <para>The service port. If you want to use a dynamic port, do not pass this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol. Valid values:</para>
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
                /// <para>The percentage value of traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The route description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test route</para>
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
        /// <para>The environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cquqsollhtgid***</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The rules for matching the route.</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public HttpRouteMatch Match { get; set; }

        [NameInMap("mcpRouteConfig")]
        [Validation(Required=false)]
        public UpdateHttpApiRouteRequestMcpRouteConfig McpRouteConfig { get; set; }
        public class UpdateHttpApiRouteRequestMcpRouteConfig : TeaModel {
            [NameInMap("exposedUriPath")]
            [Validation(Required=false)]
            public string ExposedUriPath { get; set; }

            [NameInMap("mcpStatisticsEnable")]
            [Validation(Required=false)]
            public bool? McpStatisticsEnable { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
