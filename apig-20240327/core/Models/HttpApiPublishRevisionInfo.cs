// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiPublishRevisionInfo : TeaModel {
        [NameInMap("backendScene")]
        [Validation(Required=false)]
        public string BackendScene { get; set; }

        [NameInMap("backendType")]
        [Validation(Required=false)]
        public string BackendType { get; set; }

        [NameInMap("cloudProductConfig")]
        [Validation(Required=false)]
        public HttpApiPublishRevisionInfoCloudProductConfig CloudProductConfig { get; set; }
        public class HttpApiPublishRevisionInfoCloudProductConfig : TeaModel {
            [NameInMap("cloudProductType")]
            [Validation(Required=false)]
            public string CloudProductType { get; set; }

            [NameInMap("containerServiceConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPublishRevisionInfoCloudProductConfigContainerServiceConfigs> ContainerServiceConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigContainerServiceConfigs : TeaModel {
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
                public string Weight { get; set; }

            }

            [NameInMap("functionConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPublishRevisionInfoCloudProductConfigFunctionConfigs> FunctionConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigFunctionConfigs : TeaModel {
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
            public List<HttpApiPublishRevisionInfoCloudProductConfigMseNacosConfigs> MseNacosConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigMseNacosConfigs : TeaModel {
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

        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("customDomains")]
        [Validation(Required=false)]
        public List<HttpApiDomainInfo> CustomDomains { get; set; }

        [NameInMap("dnsConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPublishRevisionInfoDnsConfigs> DnsConfigs { get; set; }
        public class HttpApiPublishRevisionInfoDnsConfigs : TeaModel {
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

        [NameInMap("environmentInfo")]
        [Validation(Required=false)]
        public HttpApiPublishRevisionInfoEnvironmentInfo EnvironmentInfo { get; set; }
        public class HttpApiPublishRevisionInfoEnvironmentInfo : TeaModel {
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public HttpApiPublishRevisionInfoEnvironmentInfoGatewayInfo GatewayInfo { get; set; }
            public class HttpApiPublishRevisionInfoEnvironmentInfoGatewayInfo : TeaModel {
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

        }

        [NameInMap("isCurrentVersion")]
        [Validation(Required=false)]
        public bool? IsCurrentVersion { get; set; }

        [NameInMap("operations")]
        [Validation(Required=false)]
        public List<HttpApiOperationInfo> Operations { get; set; }

        [NameInMap("revisionId")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPublishRevisionInfoServiceConfigs> ServiceConfigs { get; set; }
        public class HttpApiPublishRevisionInfoServiceConfigs : TeaModel {
            [NameInMap("gatewayServiceId")]
            [Validation(Required=false)]
            public string GatewayServiceId { get; set; }

            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpApiBackendMatchConditions Match { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

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

        [NameInMap("subDomains")]
        [Validation(Required=false)]
        public List<HttpApiDomainInfo> SubDomains { get; set; }

        [NameInMap("vipConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPublishRevisionInfoVipConfigs> VipConfigs { get; set; }
        public class HttpApiPublishRevisionInfoVipConfigs : TeaModel {
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

}
