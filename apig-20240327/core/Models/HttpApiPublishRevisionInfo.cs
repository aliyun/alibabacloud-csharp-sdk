// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiPublishRevisionInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SingleService</para>
        /// </summary>
        [NameInMap("backendScene")]
        [Validation(Required=false)]
        public string BackendScene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Service</para>
        /// </summary>
        [NameInMap("backendType")]
        [Validation(Required=false)]
        public string BackendType { get; set; }

        [NameInMap("cloudProductConfig")]
        [Validation(Required=false)]
        public HttpApiPublishRevisionInfoCloudProductConfig CloudProductConfig { get; set; }
        public class HttpApiPublishRevisionInfoCloudProductConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>FC</para>
            /// </summary>
            [NameInMap("cloudProductType")]
            [Validation(Required=false)]
            public string CloudProductType { get; set; }

            [NameInMap("containerServiceConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPublishRevisionInfoCloudProductConfigContainerServiceConfigs> ContainerServiceConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigContainerServiceConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>gs-xxx</para>
                /// </summary>
                [NameInMap("gatewayServiceId")]
                [Validation(Required=false)]
                public string GatewayServiceId { get; set; }

                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpApiBackendMatchConditions Match { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo-service</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

            [NameInMap("functionConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPublishRevisionInfoCloudProductConfigFunctionConfigs> FunctionConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigFunctionConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>gs-xxx</para>
                /// </summary>
                [NameInMap("gatewayServiceId")]
                [Validation(Required=false)]
                public string GatewayServiceId { get; set; }

                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpApiBackendMatchConditions Match { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo-function</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LATEST</para>
                /// </summary>
                [NameInMap("qualifier")]
                [Validation(Required=false)]
                public string Qualifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            [NameInMap("mseNacosConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPublishRevisionInfoCloudProductConfigMseNacosConfigs> MseNacosConfigs { get; set; }
            public class HttpApiPublishRevisionInfoCloudProductConfigMseNacosConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>gs-xxx</para>
                /// </summary>
                [NameInMap("gatewayServiceId")]
                [Validation(Required=false)]
                public string GatewayServiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEFAULT_GROUP</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpApiBackendMatchConditions Match { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>spring-demo</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1718807057927</para>
        /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>env-xxx</para>
        /// </summary>
        [NameInMap("environmentInfo")]
        [Validation(Required=false)]
        public HttpApiPublishRevisionInfoEnvironmentInfo EnvironmentInfo { get; set; }
        public class HttpApiPublishRevisionInfoEnvironmentInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>env-xxx</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public HttpApiPublishRevisionInfoEnvironmentInfoGatewayInfo GatewayInfo { get; set; }
            public class HttpApiPublishRevisionInfoEnvironmentInfoGatewayInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-xxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>实例1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isCurrentVersion")]
        [Validation(Required=false)]
        public bool? IsCurrentVersion { get; set; }

        [NameInMap("operations")]
        [Validation(Required=false)]
        public List<HttpApiOperationInfo> Operations { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>apr-xxx</para>
        /// </summary>
        [NameInMap("revisionId")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPublishRevisionInfoServiceConfigs> ServiceConfigs { get; set; }
        public class HttpApiPublishRevisionInfoServiceConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>gs-xxx</para>
            /// </summary>
            [NameInMap("gatewayServiceId")]
            [Validation(Required=false)]
            public string GatewayServiceId { get; set; }

            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpApiBackendMatchConditions Match { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>env-xxx.com</para>
        /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

    }

}
