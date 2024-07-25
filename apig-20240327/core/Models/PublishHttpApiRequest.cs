// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PublishHttpApiRequest : TeaModel {
        [NameInMap("allowOverwrite")]
        [Validation(Required=false)]
        public bool? AllowOverwrite { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("environment")]
        [Validation(Required=false)]
        public PublishHttpApiRequestEnvironment Environment { get; set; }
        public class PublishHttpApiRequestEnvironment : TeaModel {
            [NameInMap("backendScene")]
            [Validation(Required=false)]
            public string BackendScene { get; set; }

            [NameInMap("backendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

            [NameInMap("cloudProductConfig")]
            [Validation(Required=false)]
            public PublishHttpApiRequestEnvironmentCloudProductConfig CloudProductConfig { get; set; }
            public class PublishHttpApiRequestEnvironmentCloudProductConfig : TeaModel {
                [NameInMap("cloudProductType")]
                [Validation(Required=false)]
                public string CloudProductType { get; set; }

                [NameInMap("containerServiceConfigs")]
                [Validation(Required=false)]
                public List<PublishHttpApiRequestEnvironmentCloudProductConfigContainerServiceConfigs> ContainerServiceConfigs { get; set; }
                public class PublishHttpApiRequestEnvironmentCloudProductConfigContainerServiceConfigs : TeaModel {
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
                public List<PublishHttpApiRequestEnvironmentCloudProductConfigFunctionConfigs> FunctionConfigs { get; set; }
                public class PublishHttpApiRequestEnvironmentCloudProductConfigFunctionConfigs : TeaModel {
                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpApiBackendMatchConditions Match { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("quanlifer")]
                    [Validation(Required=false)]
                    public string Quanlifer { get; set; }

                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                [NameInMap("mseNacosConfigs")]
                [Validation(Required=false)]
                public List<PublishHttpApiRequestEnvironmentCloudProductConfigMseNacosConfigs> MseNacosConfigs { get; set; }
                public class PublishHttpApiRequestEnvironmentCloudProductConfigMseNacosConfigs : TeaModel {
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
                    public string Weight { get; set; }

                }

            }

            [NameInMap("customDomainIds")]
            [Validation(Required=false)]
            public List<string> CustomDomainIds { get; set; }

            [NameInMap("dnsConfigs")]
            [Validation(Required=false)]
            public List<PublishHttpApiRequestEnvironmentDnsConfigs> DnsConfigs { get; set; }
            public class PublishHttpApiRequestEnvironmentDnsConfigs : TeaModel {
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

            [NameInMap("serviceConfigs")]
            [Validation(Required=false)]
            public List<PublishHttpApiRequestEnvironmentServiceConfigs> ServiceConfigs { get; set; }
            public class PublishHttpApiRequestEnvironmentServiceConfigs : TeaModel {
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

            [NameInMap("vipConfigs")]
            [Validation(Required=false)]
            public List<PublishHttpApiRequestEnvironmentVipConfigs> VipConfigs { get; set; }
            public class PublishHttpApiRequestEnvironmentVipConfigs : TeaModel {
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

        [NameInMap("revisionId")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

    }

}
