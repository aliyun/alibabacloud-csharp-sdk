// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiPublishRevisionInfo : TeaModel {
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
        /// <para>The cloud service configurations.</para>
        /// </summary>
        [NameInMap("cloudProductConfig")]
        [Validation(Required=false)]
        public HttpApiPublishRevisionInfoCloudProductConfig CloudProductConfig { get; set; }
        public class HttpApiPublishRevisionInfoCloudProductConfig : TeaModel {
            /// <summary>
            /// <para>The type of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FC</para>
            /// </summary>
            [NameInMap("cloudProductType")]
            [Validation(Required=false)]
            public string CloudProductType { get; set; }

            /// <summary>
            /// <para>The ACK configurations.</para>
            /// </summary>
            [NameInMap("containerServiceConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPublishRevisionInfoCloudProductConfigContainerServiceConfigs> ContainerServiceConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigContainerServiceConfigs : TeaModel {
                /// <summary>
                /// <para>The associated service ID.</para>
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
                /// <para>The K8s service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-service</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The K8s namespace.</para>
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
            /// <para>The Function Compute configurations.</para>
            /// </summary>
            [NameInMap("functionConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPublishRevisionInfoCloudProductConfigFunctionConfigs> FunctionConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigFunctionConfigs : TeaModel {
                /// <summary>
                /// <para>The associated service ID.</para>
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
            /// <para>The MSE Nacos configurations.</para>
            /// </summary>
            [NameInMap("mseNacosConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPublishRevisionInfoCloudProductConfigMseNacosConfigs> MseNacosConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigMseNacosConfigs : TeaModel {
                /// <summary>
                /// <para>The associated service ID.</para>
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
                /// <para>The matching conditions.</para>
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
        /// <para>The publishing timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718807057927</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The custom domain names.</para>
        /// </summary>
        [NameInMap("customDomains")]
        [Validation(Required=false)]
        public List<HttpApiDomainInfo> CustomDomains { get; set; }

        /// <summary>
        /// <para>The configurations of DNS domain names. For single-service publishing, only one entry is allowed. For other scenarios, multiple entries are allowed.</para>
        /// </summary>
        [NameInMap("dnsConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPublishRevisionInfoDnsConfigs> DnsConfigs { get; set; }
        public class HttpApiPublishRevisionInfoDnsConfigs : TeaModel {
            /// <summary>
            /// <para>The DNS domain names.</para>
            /// </summary>
            [NameInMap("dnsList")]
            [Validation(Required=false)]
            public List<string> DnsList { get; set; }

            /// <summary>
            /// <para>The matching condition. This condition is valid only in content-based routing.</para>
            /// </summary>
            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpApiBackendMatchConditions Match { get; set; }

            /// <summary>
            /// <para>The weight. Valid values: [1,100]. This parameter is valid only in proportional routing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The environment information.</para>
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
            /// <para>The instance information.</para>
            /// </summary>
            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public HttpApiPublishRevisionInfoEnvironmentInfoGatewayInfo GatewayInfo { get; set; }
            public class HttpApiPublishRevisionInfoEnvironmentInfoGatewayInfo : TeaModel {
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
                /// <para>Instance 1</para>
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
        /// <para>Specifies whether the current version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isCurrentVersion")]
        [Validation(Required=false)]
        public bool? IsCurrentVersion { get; set; }

        /// <summary>
        /// <para>The operations.</para>
        /// </summary>
        [NameInMap("operations")]
        [Validation(Required=false)]
        public List<HttpApiOperationInfo> Operations { get; set; }

        /// <summary>
        /// <para>The published version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apr-xxx</para>
        /// </summary>
        [NameInMap("revisionId")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        /// <summary>
        /// <para>The configurations of existing services. For single-service publishing, only one entry is allowed. For other scenarios, multiple entries are allowed.</para>
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
            /// <para>The matching conditions.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>env-xxx.com</para>
        /// </summary>
        [NameInMap("subDomains")]
        [Validation(Required=false)]
        public List<HttpApiDomainInfo> SubDomains { get; set; }

        /// <summary>
        /// <para>The configurations of fixed IP addresses. For single-service publishing, only one entry is allowed. For other scenarios, multiple entries are allowed.</para>
        /// </summary>
        [NameInMap("vipConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPublishRevisionInfoVipConfigs> VipConfigs { get; set; }
        public class HttpApiPublishRevisionInfoVipConfigs : TeaModel {
            /// <summary>
            /// <para>The IP addresses.</para>
            /// </summary>
            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public List<string> Endpoints { get; set; }

            /// <summary>
            /// <para>The matching condition. This condition is valid only in content-based routing.</para>
            /// </summary>
            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpApiBackendMatchConditions Match { get; set; }

            /// <summary>
            /// <para>The weight. Valid values: [1,100]. This parameter is valid only in proportional routing.</para>
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
