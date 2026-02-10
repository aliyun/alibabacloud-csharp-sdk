// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiApiInfo : TeaModel {
        /// <summary>
        /// <para>Agent protocol list</para>
        /// </summary>
        [NameInMap("agentProtocols")]
        [Validation(Required=false)]
        public List<string> AgentProtocols { get; set; }

        /// <summary>
        /// <para>The AI protocols.</para>
        /// </summary>
        [NameInMap("aiProtocols")]
        [Validation(Required=false)]
        public List<string> AiProtocols { get; set; }

        /// <summary>
        /// <para>The authentication configurations.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The base path of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/v1</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The API publishing status.</para>
        /// </summary>
        [NameInMap("deployCntMap")]
        [Validation(Required=false)]
        public Dictionary<string, HttpApiApiInfoDeployCntMapValue> DeployCntMap { get; set; }

        /// <summary>
        /// <para>The API deployment configurations.</para>
        /// </summary>
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The API description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>for test only</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authentication.</para>
        /// </summary>
        [NameInMap("enabelAuth")]
        [Validation(Required=false)]
        public bool? EnabelAuth { get; set; }

        /// <summary>
        /// <para>The API environment information.</para>
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
            /// <para>The publishing scenario.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SingleService</description></item>
            /// <item><description>MultiServiceByRatio</description></item>
            /// <item><description>MultiServiceByContent</description></item>
            /// <item><description>MultiServiceByTag</description></item>
            /// <item><description>Mock</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SingleService</para>
            /// </summary>
            [NameInMap("backendScene")]
            [Validation(Required=false)]
            public string BackendScene { get; set; }

            /// <summary>
            /// <para>The type of the backend service.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DNS: a DNS domain name</description></item>
            /// <item><description>Service: an existing service</description></item>
            /// <item><description>VIP: a fixed IP address</description></item>
            /// <item><description>CloudProduct: a cloud service</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Service</para>
            /// </summary>
            [NameInMap("backendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

            /// <summary>
            /// <para>The custom domain names.</para>
            /// </summary>
            [NameInMap("customDomains")]
            [Validation(Required=false)]
            public List<HttpApiDomainInfo> CustomDomains { get; set; }

            /// <summary>
            /// <para>The publishing status of the API in the current environment.</para>
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
            /// <para>The information about the gateway instance to which the environment belongs.</para>
            /// </summary>
            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public HttpApiApiInfoEnvironmentsGatewayInfo GatewayInfo { get; set; }
            public class HttpApiApiInfoEnvironmentsGatewayInfo : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
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
            /// <para>The configurations of an existing service.</para>
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
                /// <para>The matching conditions.</para>
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
                /// <para>The version of the microservice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
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
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The default domain names of the environment.</para>
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
                /// <para>The communication protocol.</para>
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
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cpv4sqdl****</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The HTTP API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-xxx</para>
        /// </summary>
        [NameInMap("httpApiId")]
        [Validation(Required=false)]
        public string HttpApiId { get; set; }

        /// <summary>
        /// <para>The information about the HTTP Ingress API.</para>
        /// </summary>
        [NameInMap("ingressInfo")]
        [Validation(Required=false)]
        public HttpApiApiInfoIngressInfo IngressInfo { get; set; }
        public class HttpApiApiInfoIngressInfo : TeaModel {
            /// <summary>
            /// <para>The environment information.</para>
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
            /// <para>The Ingress Class for listening.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse</para>
            /// </summary>
            [NameInMap("ingressClass")]
            [Validation(Required=false)]
            public string IngressClass { get; set; }

            /// <summary>
            /// <para>The information about the Kubernetes cluster.</para>
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
            /// <para>The namespace for listening.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("watchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        /// <summary>
        /// <para>Model category</para>
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
        /// <para>The protocols.</para>
        /// </summary>
        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The API type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HttpIngress</description></item>
        /// <item><description>Rest</description></item>
        /// <item><description>Websocket</description></item>
        /// <item><description>AI</description></item>
        /// <item><description>Http</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Rest</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The API versioning information.</para>
        /// </summary>
        [NameInMap("versionInfo")]
        [Validation(Required=false)]
        public HttpApiVersionInfo VersionInfo { get; set; }

    }

}
