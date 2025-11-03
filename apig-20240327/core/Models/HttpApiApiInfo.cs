// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiApiInfo : TeaModel {
        [NameInMap("aiProtocols")]
        [Validation(Required=false)]
        public List<string> AiProtocols { get; set; }

        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/v1</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        [NameInMap("deployCntMap")]
        [Validation(Required=false)]
        public Dictionary<string, HttpApiApiInfoDeployCntMapValue> DeployCntMap { get; set; }

        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("enabelAuth")]
        [Validation(Required=false)]
        public bool? EnabelAuth { get; set; }

        [NameInMap("environments")]
        [Validation(Required=false)]
        public List<HttpApiApiInfoEnvironments> Environments { get; set; }
        public class HttpApiApiInfoEnvironments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SingleService</para>
            /// </summary>
            [NameInMap("backendScene")]
            [Validation(Required=false)]
            public string BackendScene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Service</para>
            /// </summary>
            [NameInMap("backendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

            [NameInMap("customDomains")]
            [Validation(Required=false)]
            public List<HttpApiDomainInfo> CustomDomains { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("deployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>env-xxx</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public HttpApiApiInfoEnvironmentsGatewayInfo GatewayInfo { get; set; }
            public class HttpApiApiInfoEnvironmentsGatewayInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-xxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("serviceConfigs")]
            [Validation(Required=false)]
            public List<HttpApiApiInfoEnvironmentsServiceConfigs> ServiceConfigs { get; set; }
            public class HttpApiApiInfoEnvironmentsServiceConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>gs-xxx</para>
                /// </summary>
                [NameInMap("gatewayServiceId")]
                [Validation(Required=false)]
                public string GatewayServiceId { get; set; }

                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpApiBackendMatchConditions Match { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo-service</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>svc-xxx</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            [NameInMap("subDomains")]
            [Validation(Required=false)]
            public List<HttpApiApiInfoEnvironmentsSubDomains> SubDomains { get; set; }
            public class HttpApiApiInfoEnvironmentsSubDomains : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>d-xxx</para>
                /// </summary>
                [NameInMap("domainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

        }

        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>api-xxx</para>
        /// </summary>
        [NameInMap("httpApiId")]
        [Validation(Required=false)]
        public string HttpApiId { get; set; }

        [NameInMap("ingressInfo")]
        [Validation(Required=false)]
        public HttpApiApiInfoIngressInfo IngressInfo { get; set; }
        public class HttpApiApiInfoIngressInfo : TeaModel {
            [NameInMap("environmentInfo")]
            [Validation(Required=false)]
            public HttpApiApiInfoIngressInfoEnvironmentInfo EnvironmentInfo { get; set; }
            public class HttpApiApiInfoIngressInfoEnvironmentInfo : TeaModel {
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

            }

            [NameInMap("ingressClass")]
            [Validation(Required=false)]
            public string IngressClass { get; set; }

            [NameInMap("k8sClusterInfo")]
            [Validation(Required=false)]
            public HttpApiApiInfoIngressInfoK8sClusterInfo K8sClusterInfo { get; set; }
            public class HttpApiApiInfoIngressInfoK8sClusterInfo : TeaModel {
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

            }

            [NameInMap("overrideIngressIp")]
            [Validation(Required=false)]
            public bool? OverrideIngressIp { get; set; }

            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            [NameInMap("watchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        [NameInMap("modelCategory")]
        [Validation(Required=false)]
        public string ModelCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Rest</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("versionInfo")]
        [Validation(Required=false)]
        public HttpApiVersionInfo VersionInfo { get; set; }

    }

}
