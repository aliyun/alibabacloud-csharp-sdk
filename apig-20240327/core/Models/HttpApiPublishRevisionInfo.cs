// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiPublishRevisionInfo : TeaModel {
        /// <summary>
        /// <para>The API publish scenario.</para>
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
        /// <para>The cloud product configuration.</para>
        /// </summary>
        [NameInMap("cloudProductConfig")]
        [Validation(Required=false)]
        public HttpApiPublishRevisionInfoCloudProductConfig CloudProductConfig { get; set; }
        public class HttpApiPublishRevisionInfoCloudProductConfig : TeaModel {
            /// <summary>
            /// <para>The cloud product type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FC</para>
            /// </summary>
            [NameInMap("cloudProductType")]
            [Validation(Required=false)]
            public string CloudProductType { get; set; }

            /// <summary>
            /// <para>The container service configuration.</para>
            /// </summary>
            [NameInMap("containerServiceConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPublishRevisionInfoCloudProductConfigContainerServiceConfigs> ContainerServiceConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigContainerServiceConfigs : TeaModel {
                /// <summary>
                /// <para>The ID of the associated service.</para>
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
                /// <para>The Kubernetes service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-service</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The Kubernetes service namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The service port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The service protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The service weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

            /// <summary>
            /// <para>The Function Compute (FC) configuration.</para>
            /// </summary>
            [NameInMap("functionConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPublishRevisionInfoCloudProductConfigFunctionConfigs> FunctionConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigFunctionConfigs : TeaModel {
                /// <summary>
                /// <para>The ID of the associated service.</para>
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
                /// <para>The function name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-function</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The function version or alias.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LATEST</para>
                /// </summary>
                [NameInMap("qualifier")]
                [Validation(Required=false)]
                public string Qualifier { get; set; }

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
            /// <para>The MSE Nacos configuration.</para>
            /// </summary>
            [NameInMap("mseNacosConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPublishRevisionInfoCloudProductConfigMseNacosConfigs> MseNacosConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigMseNacosConfigs : TeaModel {
                /// <summary>
                /// <para>The ID of the associated service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gs-xxx</para>
                /// </summary>
                [NameInMap("gatewayServiceId")]
                [Validation(Required=false)]
                public string GatewayServiceId { get; set; }

                /// <summary>
                /// <para>The service group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT_GROUP</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The match condition.</para>
                /// </summary>
                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpApiBackendMatchConditions Match { get; set; }

                /// <summary>
                /// <para>The Nacos service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spring-demo</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The Nacos namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

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

        }

        /// <summary>
        /// <para>The publish timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718807057927</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The list of custom domain names.</para>
        /// </summary>
        [NameInMap("customDomains")]
        [Validation(Required=false)]
        public List<HttpApiDomainInfo> CustomDomains { get; set; }

        /// <summary>
        /// <para>The DNS domain name configuration. In the single-service scenario, only one entry can be configured. In the by-ratio or by-content scenario, multiple entries can be configured.</para>
        /// </summary>
        [NameInMap("dnsConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPublishRevisionInfoDnsConfigs> DnsConfigs { get; set; }
        public class HttpApiPublishRevisionInfoDnsConfigs : TeaModel {
            /// <summary>
            /// <para>The list of DNS domain names.</para>
            /// </summary>
            [NameInMap("dnsList")]
            [Validation(Required=false)]
            public List<string> DnsList { get; set; }

            /// <summary>
            /// <para>The match condition. This parameter is valid only in the by-content scenario.</para>
            /// </summary>
            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpApiBackendMatchConditions Match { get; set; }

            /// <summary>
            /// <para>The weight. Valid values: 1 to 100. This parameter is valid only in the by-ratio scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The environment context.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-xxx</para>
        /// </summary>
        [NameInMap("environmentInfo")]
        [Validation(Required=false)]
        public HttpApiPublishRevisionInfoEnvironmentInfo EnvironmentInfo { get; set; }
        public class HttpApiPublishRevisionInfoEnvironmentInfo : TeaModel {
            /// <summary>
            /// <para>The environment alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

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
            /// <para>The gateway instance information.</para>
            /// </summary>
            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public HttpApiPublishRevisionInfoEnvironmentInfoGatewayInfo GatewayInfo { get; set; }
            public class HttpApiPublishRevisionInfoEnvironmentInfoGatewayInfo : TeaModel {
                /// <summary>
                /// <para>The gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The gateway name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Instance1</para>
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

        }

        /// <summary>
        /// <para>Indicates whether this is the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isCurrentVersion")]
        [Validation(Required=false)]
        public bool? IsCurrentVersion { get; set; }

        /// <summary>
        /// <para>The list of API operations.</para>
        /// </summary>
        [NameInMap("operations")]
        [Validation(Required=false)]
        public List<HttpApiOperationInfo> Operations { get; set; }

        /// <summary>
        /// <para>The version number of the published API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apr-xxx</para>
        /// </summary>
        [NameInMap("revisionId")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        /// <summary>
        /// <para>The existing service configurations. In a single-service scenario, only one entry can be configured. In proportion-based, content-based, or tag-based scenarios, multiple entries can be configured.</para>
        /// </summary>
        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPublishRevisionInfoServiceConfigs> ServiceConfigs { get; set; }
        public class HttpApiPublishRevisionInfoServiceConfigs : TeaModel {
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
            /// <para>The service port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The service protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

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
        /// 
        /// <b>Example:</b>
        /// <para>env-xxx.com</para>
        /// </summary>
        [NameInMap("subDomains")]
        [Validation(Required=false)]
        public List<HttpApiDomainInfo> SubDomains { get; set; }

        /// <summary>
        /// <para>The static address configurations. In a single-service scenario, only one entry can be configured. In proportion-based or content-based scenarios, multiple entries can be configured.</para>
        /// </summary>
        [NameInMap("vipConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPublishRevisionInfoVipConfigs> VipConfigs { get; set; }
        public class HttpApiPublishRevisionInfoVipConfigs : TeaModel {
            /// <summary>
            /// <para>The list of static addresses.</para>
            /// </summary>
            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public List<string> Endpoints { get; set; }

            /// <summary>
            /// <para>The match condition. This parameter is valid only in the by-content scenario.</para>
            /// </summary>
            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpApiBackendMatchConditions Match { get; set; }

            /// <summary>
            /// <para>The weight. Valid values: 1 to 100. This parameter is valid only in the by-ratio scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

    }

}
