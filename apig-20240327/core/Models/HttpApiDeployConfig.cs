// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiDeployConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoDeploy")]
        [Validation(Required=false)]
        public bool? AutoDeploy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SingleService</para>
        /// </summary>
        [NameInMap("backendScene")]
        [Validation(Required=false)]
        public string BackendScene { get; set; }

        [NameInMap("customDomainIds")]
        [Validation(Required=false)]
        public List<string> CustomDomainIds { get; set; }

        [NameInMap("customDomainInfos")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigCustomDomainInfos> CustomDomainInfos { get; set; }
        public class HttpApiDeployConfigCustomDomainInfos : TeaModel {
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
        /// <b>Example:</b>
        /// <para>env-xxx</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-xx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("gatewayInfo")]
        [Validation(Required=false)]
        public GatewayInfo GatewayInfo { get; set; }

        [NameInMap("mock")]
        [Validation(Required=false)]
        public HttpApiMockContract Mock { get; set; }

        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigPolicyConfigs> PolicyConfigs { get; set; }
        public class HttpApiDeployConfigPolicyConfigs : TeaModel {
            [NameInMap("aiFallbackConfig")]
            [Validation(Required=false)]
            public HttpApiDeployConfigPolicyConfigsAiFallbackConfig AiFallbackConfig { get; set; }
            public class HttpApiDeployConfigPolicyConfigsAiFallbackConfig : TeaModel {
                [NameInMap("serviceIds")]
                [Validation(Required=false)]
                public List<string> ServiceIds { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AiFallback</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("routeBackend")]
        [Validation(Required=false)]
        public Backend RouteBackend { get; set; }

        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigServiceConfigs> ServiceConfigs { get; set; }
        public class HttpApiDeployConfigServiceConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-*</para>
            /// </summary>
            [NameInMap("modelNamePattern")]
            [Validation(Required=false)]
            public string ModelNamePattern { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>svc-xxx</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

        }

        [NameInMap("subDomains")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigSubDomains> SubDomains { get; set; }
        public class HttpApiDeployConfigSubDomains : TeaModel {
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

    }

}
