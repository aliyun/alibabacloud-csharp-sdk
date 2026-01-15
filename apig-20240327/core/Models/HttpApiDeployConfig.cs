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

        /// <summary>
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

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
                [NameInMap("serviceConfigs")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiFallbackConfigServiceConfigs> ServiceConfigs { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiFallbackConfigServiceConfigs : TeaModel {
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    [NameInMap("targetModelName")]
                    [Validation(Required=false)]
                    public string TargetModelName { get; set; }

                }

            }

            [NameInMap("aiSecurityGuardConfig")]
            [Validation(Required=false)]
            public HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfig AiSecurityGuardConfig { get; set; }
            public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfig : TeaModel {
                [NameInMap("bufferLimit")]
                [Validation(Required=false)]
                public int? BufferLimit { get; set; }

                [NameInMap("checkRequest")]
                [Validation(Required=false)]
                public bool? CheckRequest { get; set; }

                [NameInMap("checkRequestImage")]
                [Validation(Required=false)]
                public bool? CheckRequestImage { get; set; }

                [NameInMap("checkResponse")]
                [Validation(Required=false)]
                public bool? CheckResponse { get; set; }

                [NameInMap("checkResponseImage")]
                [Validation(Required=false)]
                public bool? CheckResponseImage { get; set; }

                [NameInMap("consumerRequestCheckService")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerRequestCheckService> ConsumerRequestCheckService { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerRequestCheckService : TeaModel {
                    [NameInMap("matchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    [NameInMap("modalityType")]
                    [Validation(Required=false)]
                    public string ModalityType { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("requestCheckService")]
                    [Validation(Required=false)]
                    public string RequestCheckService { get; set; }

                    [NameInMap("requestImageCheckService")]
                    [Validation(Required=false)]
                    public string RequestImageCheckService { get; set; }

                }

                [NameInMap("consumerResponseCheckService")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerResponseCheckService> ConsumerResponseCheckService { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerResponseCheckService : TeaModel {
                    [NameInMap("matchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    [NameInMap("modalityType")]
                    [Validation(Required=false)]
                    public string ModalityType { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("responseCheckService")]
                    [Validation(Required=false)]
                    public string ResponseCheckService { get; set; }

                    [NameInMap("responseImageCheckService")]
                    [Validation(Required=false)]
                    public string ResponseImageCheckService { get; set; }

                }

                [NameInMap("consumerRiskLevel")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerRiskLevel> ConsumerRiskLevel { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerRiskLevel : TeaModel {
                    [NameInMap("level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("matchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("requestCheckService")]
                [Validation(Required=false)]
                public string RequestCheckService { get; set; }

                [NameInMap("requestImageCheckService")]
                [Validation(Required=false)]
                public string RequestImageCheckService { get; set; }

                [NameInMap("responseCheckService")]
                [Validation(Required=false)]
                public string ResponseCheckService { get; set; }

                [NameInMap("responseImageCheckService")]
                [Validation(Required=false)]
                public string ResponseImageCheckService { get; set; }

                [NameInMap("riskAlertLevel")]
                [Validation(Required=false)]
                public string RiskAlertLevel { get; set; }

                [NameInMap("riskConfig")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigRiskConfig> RiskConfig { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigRiskConfig : TeaModel {
                    [NameInMap("consumerRules")]
                    [Validation(Required=false)]
                    public HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigRiskConfigConsumerRules ConsumerRules { get; set; }
                    public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigRiskConfigConsumerRules : TeaModel {
                        [NameInMap("matchType")]
                        [Validation(Required=false)]
                        public string MatchType { get; set; }

                        [NameInMap("pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                    }

                    [NameInMap("level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("serviceAddress")]
                [Validation(Required=false)]
                public string ServiceAddress { get; set; }

            }

            [NameInMap("aiTokenRateLimitConfig")]
            [Validation(Required=false)]
            public HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfig AiTokenRateLimitConfig { get; set; }
            public class HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfig : TeaModel {
                [NameInMap("enableGlobalRules")]
                [Validation(Required=false)]
                public bool? EnableGlobalRules { get; set; }

                [NameInMap("globalRules")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfigGlobalRules> GlobalRules { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfigGlobalRules : TeaModel {
                    [NameInMap("limitMode")]
                    [Validation(Required=false)]
                    public string LimitMode { get; set; }

                    [NameInMap("limitType")]
                    [Validation(Required=false)]
                    public string LimitType { get; set; }

                    [NameInMap("limitValue")]
                    [Validation(Required=false)]
                    public int? LimitValue { get; set; }

                    [NameInMap("matchKey")]
                    [Validation(Required=false)]
                    public string MatchKey { get; set; }

                    [NameInMap("matchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    [NameInMap("matchValue")]
                    [Validation(Required=false)]
                    public string MatchValue { get; set; }

                }

                [NameInMap("rules")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfigRules> Rules { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfigRules : TeaModel {
                    [NameInMap("limitMode")]
                    [Validation(Required=false)]
                    public string LimitMode { get; set; }

                    [NameInMap("limitType")]
                    [Validation(Required=false)]
                    public string LimitType { get; set; }

                    [NameInMap("limitValue")]
                    [Validation(Required=false)]
                    public int? LimitValue { get; set; }

                    [NameInMap("matchKey")]
                    [Validation(Required=false)]
                    public string MatchKey { get; set; }

                    [NameInMap("matchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    [NameInMap("matchValue")]
                    [Validation(Required=false)]
                    public string MatchValue { get; set; }

                }

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
            [NameInMap("intentCode")]
            [Validation(Required=false)]
            public string IntentCode { get; set; }

            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpApiBackendMatchConditions Match { get; set; }

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
