// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiDeployConfig : TeaModel {
        /// <summary>
        /// <para>Indicates whether auto-deploy is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoDeploy")]
        [Validation(Required=false)]
        public bool? AutoDeploy { get; set; }

        /// <summary>
        /// <para>The publishing scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SingleService</para>
        /// </summary>
        [NameInMap("backendScene")]
        [Validation(Required=false)]
        public string BackendScene { get; set; }

        /// <summary>
        /// <para>The list of built-in route names.</para>
        /// </summary>
        [NameInMap("builtinRouteNames")]
        [Validation(Required=false)]
        public List<string> BuiltinRouteNames { get; set; }

        /// <summary>
        /// <para>The list of custom domain name IDs.</para>
        /// </summary>
        [NameInMap("customDomainIds")]
        [Validation(Required=false)]
        public List<string> CustomDomainIds { get; set; }

        /// <summary>
        /// <para>The list of custom domain name information.</para>
        /// </summary>
        [NameInMap("customDomainInfos")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigCustomDomainInfos> CustomDomainInfos { get; set; }
        public class HttpApiDeployConfigCustomDomainInfos : TeaModel {
            /// <summary>
            /// <para>The domain name ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-cshee6dlhtgk******</para>
            /// </summary>
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello-server.com</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The list of environment domain name IDs. If this parameter is not specified, all environment domain names are bound. An empty array indicates that no environment domain names are bound.</para>
        /// </summary>
        [NameInMap("envDomainIds")]
        [Validation(Required=false)]
        public List<string> EnvDomainIds { get; set; }

        /// <summary>
        /// <para>The list of environment domain name information.</para>
        /// </summary>
        [NameInMap("envDomainInfos")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigEnvDomainInfos> EnvDomainInfos { get; set; }
        public class HttpApiDeployConfigEnvDomainInfos : TeaModel {
            /// <summary>
            /// <para>The domain name ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-env-xxx</para>
            /// </summary>
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api.example.com</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTPS</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-xxx</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The gateway instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The gateway information.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("gatewayInfo")]
        [Validation(Required=false)]
        public GatewayInfo GatewayInfo { get; set; }

        /// <summary>
        /// <para>The gateway type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The mock configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("mock")]
        [Validation(Required=false)]
        public HttpApiMockContract Mock { get; set; }

        /// <summary>
        /// <para>The list of policy configurations.</para>
        /// </summary>
        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPolicyConfigs> PolicyConfigs { get; set; }

        /// <summary>
        /// <para>The backend service information.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("routeBackend")]
        [Validation(Required=false)]
        public Backend RouteBackend { get; set; }

        /// <summary>
        /// <para>The list of service configurations.</para>
        /// </summary>
        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigServiceConfigs> ServiceConfigs { get; set; }
        public class HttpApiDeployConfigServiceConfigs : TeaModel {
            /// <summary>
            /// <para>The gateway service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-svc-abc123</para>
            /// </summary>
            [NameInMap("gatewayServiceId")]
            [Validation(Required=false)]
            public string GatewayServiceId { get; set; }

            /// <summary>
            /// <para>The intent code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INQUIRY</para>
            /// </summary>
            [NameInMap("intentCode")]
            [Validation(Required=false)]
            public string IntentCode { get; set; }

            /// <summary>
            /// <para>The matching condition.</para>
            /// </summary>
            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpApiBackendMatchConditions Match { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The model name matching rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-*</para>
            /// </summary>
            [NameInMap("modelNamePattern")]
            [Validation(Required=false)]
            public string ModelNamePattern { get; set; }

            /// <summary>
            /// <para>The multi-service routing strategy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ByWeight</para>
            /// </summary>
            [NameInMap("multiServiceRouteStrategy")]
            [Validation(Required=false)]
            public string MultiServiceRouteStrategy { get; set; }

            /// <summary>
            /// <para>The service display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen-Max-Service</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The observability-based routing configuration.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("observabilityRouteConfig")]
            [Validation(Required=false)]
            public HttpApiDeployConfigServiceConfigsObservabilityRouteConfig ObservabilityRouteConfig { get; set; }
            public class HttpApiDeployConfigServiceConfigsObservabilityRouteConfig : TeaModel {
                /// <summary>
                /// <para>The routing mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LeastBusy</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The queue size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("queueSize")]
                [Validation(Required=false)]
                public int? QueueSize { get; set; }

                /// <summary>
                /// <para>The maximum traffic ratio for a single service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("rateLimit")]
                [Validation(Required=false)]
                public float? RateLimit { get; set; }

            }

            /// <summary>
            /// <para>The service port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The service protocol (HTTP/HTTPS).</para>
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
            /// <para>The service version label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V2</para>
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
            public long? Weight { get; set; }

        }

        /// <summary>
        /// <para>The list of subdomain information.</para>
        /// </summary>
        [NameInMap("subDomains")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigSubDomains> SubDomains { get; set; }
        public class HttpApiDeployConfigSubDomains : TeaModel {
            /// <summary>
            /// <para>The domain name ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-csmn42um******</para>
            /// </summary>
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Intranet</para>
            /// </summary>
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

    }

}
