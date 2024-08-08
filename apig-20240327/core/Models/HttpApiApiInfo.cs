// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiApiInfo : TeaModel {
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("environments")]
        [Validation(Required=false)]
        public List<HttpApiApiInfoEnvironments> Environments { get; set; }
        public class HttpApiApiInfoEnvironments : TeaModel {
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("backendScene")]
            [Validation(Required=false)]
            public string BackendScene { get; set; }

            [NameInMap("backendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

            [NameInMap("cloudProductConfig")]
            [Validation(Required=false)]
            public HttpApiApiInfoEnvironmentsCloudProductConfig CloudProductConfig { get; set; }
            public class HttpApiApiInfoEnvironmentsCloudProductConfig : TeaModel {
                [NameInMap("cloudProductType")]
                [Validation(Required=false)]
                public string CloudProductType { get; set; }

                [NameInMap("containerServiceConfigs")]
                [Validation(Required=false)]
                public List<HttpApiApiInfoEnvironmentsCloudProductConfigContainerServiceConfigs> ContainerServiceConfigs { get; set; }
                public class HttpApiApiInfoEnvironmentsCloudProductConfigContainerServiceConfigs : TeaModel {
                    [NameInMap("gatewayServiceId")]
                    [Validation(Required=false)]
                    public string GatewayServiceId { get; set; }

                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpApiBackendMatchConditions Match { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                [NameInMap("functionConfigs")]
                [Validation(Required=false)]
                public List<HttpApiApiInfoEnvironmentsCloudProductConfigFunctionConfigs> FunctionConfigs { get; set; }
                public class HttpApiApiInfoEnvironmentsCloudProductConfigFunctionConfigs : TeaModel {
                    [NameInMap("gatewayServiceId")]
                    [Validation(Required=false)]
                    public string GatewayServiceId { get; set; }

                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpApiBackendMatchConditions Match { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("qualifier")]
                    [Validation(Required=false)]
                    public string Qualifier { get; set; }

                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                [NameInMap("mseNacosConfigs")]
                [Validation(Required=false)]
                public List<HttpApiApiInfoEnvironmentsCloudProductConfigMseNacosConfigs> MseNacosConfigs { get; set; }
                public class HttpApiApiInfoEnvironmentsCloudProductConfigMseNacosConfigs : TeaModel {
                    [NameInMap("gatewayServiceId")]
                    [Validation(Required=false)]
                    public string GatewayServiceId { get; set; }

                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpApiBackendMatchConditions Match { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

            }

            [NameInMap("customDomains")]
            [Validation(Required=false)]
            public List<HttpApiDomainInfo> CustomDomains { get; set; }

            [NameInMap("dnsConfigs")]
            [Validation(Required=false)]
            public List<HttpApiApiInfoEnvironmentsDnsConfigs> DnsConfigs { get; set; }
            public class HttpApiApiInfoEnvironmentsDnsConfigs : TeaModel {
                [NameInMap("dnsList")]
                [Validation(Required=false)]
                public List<string> DnsList { get; set; }

                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpApiBackendMatchConditions Match { get; set; }

                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public HttpApiApiInfoEnvironmentsGatewayInfo GatewayInfo { get; set; }
            public class HttpApiApiInfoEnvironmentsGatewayInfo : TeaModel {
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

            [NameInMap("publishStatus")]
            [Validation(Required=false)]
            public string PublishStatus { get; set; }

            [NameInMap("serviceConfigs")]
            [Validation(Required=false)]
            public List<HttpApiApiInfoEnvironmentsServiceConfigs> ServiceConfigs { get; set; }
            public class HttpApiApiInfoEnvironmentsServiceConfigs : TeaModel {
                [NameInMap("gatewayServiceId")]
                [Validation(Required=false)]
                public string GatewayServiceId { get; set; }

                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpApiBackendMatchConditions Match { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            [NameInMap("vipConfigs")]
            [Validation(Required=false)]
            public List<HttpApiApiInfoEnvironmentsVipConfigs> VipConfigs { get; set; }
            public class HttpApiApiInfoEnvironmentsVipConfigs : TeaModel {
                [NameInMap("endpoints")]
                [Validation(Required=false)]
                public List<string> Endpoints { get; set; }

                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpApiBackendMatchConditions Match { get; set; }

                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        [NameInMap("httpApiId")]
        [Validation(Required=false)]
        public string HttpApiId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        [NameInMap("versionInfo")]
        [Validation(Required=false)]
        public HttpApiVersionInfo VersionInfo { get; set; }

    }

}
