// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiApiInfo : TeaModel {
        /// <summary>
        /// <para>The list of agent protocols.</para>
        /// </summary>
        [NameInMap("agentProtocols")]
        [Validation(Required=false)]
        public List<string> AgentProtocols { get; set; }

        /// <summary>
        /// <para>The list of AI protocols.</para>
        /// </summary>
        [NameInMap("aiProtocols")]
        [Validation(Required=false)]
        public List<string> AiProtocols { get; set; }

        /// <summary>
        /// <para>The authentication configuration.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The API base path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/v1</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The API operation deployment status.</para>
        /// </summary>
        [NameInMap("deployCntMap")]
        [Validation(Required=false)]
        public Dictionary<string, HttpApiApiInfoDeployCntMapValue> DeployCntMap { get; set; }

        /// <summary>
        /// <para>The list of API deployment configurations.</para>
        /// </summary>
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The API description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test API</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>The publish environment context of the API.</para>
        /// </summary>
        [NameInMap("environments")]
        [Validation(Required=false)]
        public List<HttpApiApiInfoEnvironments> Environments { get; set; }
        public class HttpApiApiInfoEnvironments : TeaModel {
            /// <summary>
            /// <para>The environment alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The deployment scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SingleService</para>
            /// </summary>
            [NameInMap("backendScene")]
            [Validation(Required=false)]
            public string BackendScene { get; set; }

            /// <summary>
            /// <para>The backend type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service</para>
            /// </summary>
            [NameInMap("backendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

            /// <summary>
            /// <para>The domain name information published by the user.</para>
            /// </summary>
            [NameInMap("customDomains")]
            [Validation(Required=false)]
            public List<HttpApiDomainInfo> CustomDomains { get; set; }

            /// <summary>
            /// <para>The deployment status of the API in the current environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("deployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

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
            /// <para>The gateway instance information for the current environment.</para>
            /// </summary>
            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public HttpApiApiInfoEnvironmentsGatewayInfo GatewayInfo { get; set; }
            public class HttpApiApiInfoEnvironmentsGatewayInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>MultiTenantServerless</para>
                /// </summary>
                [NameInMap("gatewayEdition")]
                [Validation(Required=false)]
                public string GatewayEdition { get; set; }

                /// <summary>
                /// <para>The gateway instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The gateway instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The environment name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The existing service configurations.</para>
            /// </summary>
            [NameInMap("serviceConfigs")]
            [Validation(Required=false)]
            public List<HttpApiApiInfoEnvironmentsServiceConfigs> ServiceConfigs { get; set; }
            public class HttpApiApiInfoEnvironmentsServiceConfigs : TeaModel {
                /// <summary>
                /// <para>The service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gs-xxx</para>
                /// </summary>
                [NameInMap("gatewayServiceId")]
                [Validation(Required=false)]
                public string GatewayServiceId { get; set; }

                /// <summary>
                /// <para>The match condition.</para>
                /// </summary>
                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpApiBackendMatchConditions Match { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-service</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The service port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The protocol.</para>
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
                /// <para>The service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The list of default domain names for the environment.</para>
            /// </summary>
            [NameInMap("subDomains")]
            [Validation(Required=false)]
            public List<HttpApiApiInfoEnvironmentsSubDomains> SubDomains { get; set; }
            public class HttpApiApiInfoEnvironmentsSubDomains : TeaModel {
                /// <summary>
                /// <para>The domain name ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-xxx</para>
                /// </summary>
                [NameInMap("domainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("networkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The access protocol.</para>
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
        /// <para>The ID of the gateway instance to which the API belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cpv4sqdl****</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>HTTP API ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-xxx</para>
        /// </summary>
        [NameInMap("httpApiId")]
        [Validation(Required=false)]
        public string HttpApiId { get; set; }

        /// <summary>
        /// <para>The HTTP Ingress API information.</para>
        /// </summary>
        [NameInMap("ingressInfo")]
        [Validation(Required=false)]
        public HttpApiApiInfoIngressInfo IngressInfo { get; set; }
        public class HttpApiApiInfoIngressInfo : TeaModel {
            /// <summary>
            /// <para>The environment context.</para>
            /// </summary>
            [NameInMap("environmentInfo")]
            [Validation(Required=false)]
            public HttpApiApiInfoIngressInfoEnvironmentInfo EnvironmentInfo { get; set; }
            public class HttpApiApiInfoIngressInfoEnvironmentInfo : TeaModel {
                /// <summary>
                /// <para>The environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-xxx</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

            }

            /// <summary>
            /// <para>The monitored Ingress Class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse</para>
            /// </summary>
            [NameInMap("ingressClass")]
            [Validation(Required=false)]
            public string IngressClass { get; set; }

            /// <summary>
            /// <para>The Kubernetes cluster information.</para>
            /// </summary>
            [NameInMap("k8sClusterInfo")]
            [Validation(Required=false)]
            public HttpApiApiInfoIngressInfoK8sClusterInfo K8sClusterInfo { get; set; }
            public class HttpApiApiInfoIngressInfoK8sClusterInfo : TeaModel {
                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca435c77cba1547cca9311957bcxxxxxx</para>
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to update the address in Ingress Status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("overrideIngressIp")]
            [Validation(Required=false)]
            public bool? OverrideIngressIp { get; set; }

            /// <summary>
            /// <para>The source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>src-xxx</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>The monitored namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("watchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        /// <summary>
        /// <para>The model category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("modelCategory")]
        [Validation(Required=false)]
        public string ModelCategory { get; set; }

        /// <summary>
        /// <para>The API name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of API protocols.</para>
        /// </summary>
        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The API type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rest</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The API version control information.</para>
        /// </summary>
        [NameInMap("versionInfo")]
        [Validation(Required=false)]
        public HttpApiVersionInfo VersionInfo { get; set; }

    }

}
