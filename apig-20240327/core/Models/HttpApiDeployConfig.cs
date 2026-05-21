// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiDeployConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic deployment.</para>
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

        [NameInMap("builtinRouteNames")]
        [Validation(Required=false)]
        public List<string> BuiltinRouteNames { get; set; }

        /// <summary>
        /// <para>The IDs of the custom domain names.</para>
        /// </summary>
        [NameInMap("customDomainIds")]
        [Validation(Required=false)]
        public List<string> CustomDomainIds { get; set; }

        /// <summary>
        /// <para>The information about the custom domain names.</para>
        /// </summary>
        [NameInMap("customDomainInfos")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigCustomDomainInfos> CustomDomainInfos { get; set; }
        public class HttpApiDeployConfigCustomDomainInfos : TeaModel {
            /// <summary>
            /// <para>The domain name ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-cshee6dlhtgkf4muio3g</para>
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

        [NameInMap("envDomainIds")]
        [Validation(Required=false)]
        public List<string> EnvDomainIds { get; set; }

        [NameInMap("envDomainInfos")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigEnvDomainInfos> EnvDomainInfos { get; set; }
        public class HttpApiDeployConfigEnvDomainInfos : TeaModel {
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
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The instance information.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("gatewayInfo")]
        [Validation(Required=false)]
        public GatewayInfo GatewayInfo { get; set; }

        /// <summary>
        /// <para>网关类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The Mock settings.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("mock")]
        [Validation(Required=false)]
        public HttpApiMockContract Mock { get; set; }

        /// <summary>
        /// <para>The policy configurations.</para>
        /// </summary>
        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPolicyConfigs> PolicyConfigs { get; set; }

        /// <summary>
        /// <para>routeBackend</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("routeBackend")]
        [Validation(Required=false)]
        public Backend RouteBackend { get; set; }

        /// <summary>
        /// <para>The service configurations.</para>
        /// </summary>
        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigServiceConfigs> ServiceConfigs { get; set; }
        public class HttpApiDeployConfigServiceConfigs : TeaModel {
            /// <summary>
            /// <para>Legacy gateway service ID for backward compatibility</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-svc-abc123</para>
            /// </summary>
            [NameInMap("gatewayServiceId")]
            [Validation(Required=false)]
            public string GatewayServiceId { get; set; }

            /// <summary>
            /// <para>Intent classification code</para>
            /// 
            /// <b>Example:</b>
            /// <para>INQUIRY</para>
            /// </summary>
            [NameInMap("intentCode")]
            [Validation(Required=false)]
            public string IntentCode { get; set; }

            /// <summary>
            /// <para>Match conditions</para>
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
            /// <para>Multi-service routing strategy type</para>
            /// 
            /// <b>Example:</b>
            /// <para>ByWeight</para>
            /// </summary>
            [NameInMap("multiServiceRouteStrategy")]
            [Validation(Required=false)]
            public string MultiServiceRouteStrategy { get; set; }

            /// <summary>
            /// <para>Service display name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen-Max-Service</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Observability metrics-based routing config</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("observabilityRouteConfig")]
            [Validation(Required=false)]
            public HttpApiDeployConfigServiceConfigsObservabilityRouteConfig ObservabilityRouteConfig { get; set; }
            public class HttpApiDeployConfigServiceConfigsObservabilityRouteConfig : TeaModel {
                /// <summary>
                /// <para>Routing mode</para>
                /// 
                /// <b>Example:</b>
                /// <para>LeastBusy</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>Queue size</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("queueSize")]
                [Validation(Required=false)]
                public int? QueueSize { get; set; }

                /// <summary>
                /// <para>Max traffic ratio per single service</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("rateLimit")]
                [Validation(Required=false)]
                public float? RateLimit { get; set; }

            }

            /// <summary>
            /// <para>Service port number</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>Service protocol</para>
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
            /// <para>Service version tag for tag-based routing scenarios</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
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
        /// <para>The information about the sub-domain names.</para>
        /// </summary>
        [NameInMap("subDomains")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigSubDomains> SubDomains { get; set; }
        public class HttpApiDeployConfigSubDomains : TeaModel {
            /// <summary>
            /// <para>The domain name ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-csmn42um1hksudfk9eng</para>
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
