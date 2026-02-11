// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiDeployConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoDeploy")]
        [Validation(Required=false)]
        public bool? AutoDeploy { get; set; }

        /// <summary>
        /// <para>The publishing scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SingleService</para>
        /// </summary>
        [NameInMap("backendScene")]
        [Validation(Required=false)]
        public string BackendScene { get; set; }

        /// <summary>
        /// <para>The IDs of the custom domain names.</para>
        /// </summary>
        [NameInMap("customDomainIds")]
        [Validation(Required=false)]
        public List<string> CustomDomainIds { get; set; }

        /// <summary>
        /// <para>The information about the custom domain names.</para>
        /// </summary>
        [NameInMap("customDomainInfos")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigCustomDomainInfos> CustomDomainInfos { get; set; }
        public class HttpApiDeployConfigCustomDomainInfos : TeaModel {
            /// <summary>
            /// <para>The domain name ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-cshee6dlhtgkf4muio3g</para>
            /// </summary>
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello-server.com</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

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
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The instance information.</para>
        /// </summary>
        [NameInMap("gatewayInfo")]
        [Validation(Required=false)]
        public GatewayInfo GatewayInfo { get; set; }

        /// <summary>
        /// <para>网关类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The Mock settings.</para>
        /// </summary>
        [NameInMap("mock")]
        [Validation(Required=false)]
        public HttpApiMockContract Mock { get; set; }

        /// <summary>
        /// <para>The policy configurations.</para>
        /// </summary>
        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigPolicyConfigs> PolicyConfigs { get; set; }
        public class HttpApiDeployConfigPolicyConfigs : TeaModel {
            /// <summary>
            /// <para>The fallback configurations</para>
            /// </summary>
            [NameInMap("aiFallbackConfig")]
            [Validation(Required=false)]
            public HttpApiDeployConfigPolicyConfigsAiFallbackConfig AiFallbackConfig { get; set; }
            public class HttpApiDeployConfigPolicyConfigsAiFallbackConfig : TeaModel {
                /// <summary>
                /// <para>List of fallback service configurations</para>
                /// </summary>
                [NameInMap("serviceConfigs")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiFallbackConfigServiceConfigs> ServiceConfigs { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiFallbackConfigServiceConfigs : TeaModel {
                    /// <summary>
                    /// <para>Service ID for fallback</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>svc-******</para>
                    /// </summary>
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    /// <summary>
                    /// <para>targetModelName</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gpt-4/llama3-70b</para>
                    /// </summary>
                    [NameInMap("targetModelName")]
                    [Validation(Required=false)]
                    public string TargetModelName { get; set; }

                }

            }

            /// <summary>
            /// <para>AI Security Guard configuration</para>
            /// </summary>
            [NameInMap("aiSecurityGuardConfig")]
            [Validation(Required=false)]
            public HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfig AiSecurityGuardConfig { get; set; }
            public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfig : TeaModel {
                /// <summary>
                /// <para>bufferLimit</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("bufferLimit")]
                [Validation(Required=false)]
                public int? BufferLimit { get; set; }

                /// <summary>
                /// <para>Whether to check request content</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("checkRequest")]
                [Validation(Required=false)]
                public bool? CheckRequest { get; set; }

                /// <summary>
                /// <para>Whether to check request content</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("checkRequestImage")]
                [Validation(Required=false)]
                public bool? CheckRequestImage { get; set; }

                /// <summary>
                /// <para>Whether to check response content</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("checkResponse")]
                [Validation(Required=false)]
                public bool? CheckResponse { get; set; }

                /// <summary>
                /// <para>Whether to check response content</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("checkResponseImage")]
                [Validation(Required=false)]
                public bool? CheckResponseImage { get; set; }

                /// <summary>
                /// <para>Consumer-specific request check configs</para>
                /// </summary>
                [NameInMap("consumerRequestCheckService")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerRequestCheckService> ConsumerRequestCheckService { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerRequestCheckService : TeaModel {
                    /// <summary>
                    /// <para>Match type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>exact/prefix</para>
                    /// </summary>
                    [NameInMap("matchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    /// <summary>
                    /// <para>Modality type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text/image</para>
                    /// </summary>
                    [NameInMap("modalityType")]
                    [Validation(Required=false)]
                    public string ModalityType { get; set; }

                    /// <summary>
                    /// <para>Consumer name for matching</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>API</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Request check service name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://checker.example.com/validate">https://checker.example.com/validate</a></para>
                    /// </summary>
                    [NameInMap("requestCheckService")]
                    [Validation(Required=false)]
                    public string RequestCheckService { get; set; }

                    /// <summary>
                    /// <para>requestImageCheckService</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://image-check.example.com/scan">https://image-check.example.com/scan</a></para>
                    /// </summary>
                    [NameInMap("requestImageCheckService")]
                    [Validation(Required=false)]
                    public string RequestImageCheckService { get; set; }

                }

                /// <summary>
                /// <para>Consumer-specific Response check configs</para>
                /// </summary>
                [NameInMap("consumerResponseCheckService")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerResponseCheckService> ConsumerResponseCheckService { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerResponseCheckService : TeaModel {
                    /// <summary>
                    /// <para>Match type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>term</para>
                    /// </summary>
                    [NameInMap("matchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    /// <summary>
                    /// <para>Modality type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text/image</para>
                    /// </summary>
                    [NameInMap("modalityType")]
                    [Validation(Required=false)]
                    public string ModalityType { get; set; }

                    /// <summary>
                    /// <para>Consumer name for matching</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AI_API</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Response check service name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://checker.example.com/validate-response">https://checker.example.com/validate-response</a></para>
                    /// </summary>
                    [NameInMap("responseCheckService")]
                    [Validation(Required=false)]
                    public string ResponseCheckService { get; set; }

                    /// <summary>
                    /// <para>responseImageCheckService</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://image-check.example.com/scan-response">https://image-check.example.com/scan-response</a></para>
                    /// </summary>
                    [NameInMap("responseImageCheckService")]
                    [Validation(Required=false)]
                    public string ResponseImageCheckService { get; set; }

                }

                /// <summary>
                /// <para>Consumer-specific risk level configs</para>
                /// </summary>
                [NameInMap("consumerRiskLevel")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerRiskLevel> ConsumerRiskLevel { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigConsumerRiskLevel : TeaModel {
                    /// <summary>
                    /// <para>Risk alert level</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Critical</para>
                    /// </summary>
                    [NameInMap("level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>Match type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>term</para>
                    /// </summary>
                    [NameInMap("matchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    /// <summary>
                    /// <para>Consumer name for matching</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>APIG-UI</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Risk type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>K8S</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Request check service name</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://checker.example.com/validate-request">https://checker.example.com/validate-request</a></para>
                /// </summary>
                [NameInMap("requestCheckService")]
                [Validation(Required=false)]
                public string RequestCheckService { get; set; }

                /// <summary>
                /// <para>Request check service name</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://image-checker.example.com/scan">https://image-checker.example.com/scan</a></para>
                /// </summary>
                [NameInMap("requestImageCheckService")]
                [Validation(Required=false)]
                public string RequestImageCheckService { get; set; }

                /// <summary>
                /// <para>Response check service name</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://checker.example.com/validate-response">https://checker.example.com/validate-response</a></para>
                /// </summary>
                [NameInMap("responseCheckService")]
                [Validation(Required=false)]
                public string ResponseCheckService { get; set; }

                /// <summary>
                /// <para>Response check service name</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://image-checker.example.com/scan-response">https://image-checker.example.com/scan-response</a></para>
                /// </summary>
                [NameInMap("responseImageCheckService")]
                [Validation(Required=false)]
                public string ResponseImageCheckService { get; set; }

                /// <summary>
                /// <para>Risk alert level for content moderation</para>
                /// 
                /// <b>Example:</b>
                /// <para>low/medium/high</para>
                /// </summary>
                [NameInMap("riskAlertLevel")]
                [Validation(Required=false)]
                public string RiskAlertLevel { get; set; }

                /// <summary>
                /// <para>riskConfig</para>
                /// </summary>
                [NameInMap("riskConfig")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigRiskConfig> RiskConfig { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigRiskConfig : TeaModel {
                    /// <summary>
                    /// <para>Consumer-specific rules</para>
                    /// </summary>
                    [NameInMap("consumerRules")]
                    [Validation(Required=false)]
                    public HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigRiskConfigConsumerRules ConsumerRules { get; set; }
                    public class HttpApiDeployConfigPolicyConfigsAiSecurityGuardConfigRiskConfigConsumerRules : TeaModel {
                        /// <summary>
                        /// <para>Match type</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>term</para>
                        /// </summary>
                        [NameInMap("matchType")]
                        [Validation(Required=false)]
                        public string MatchType { get; set; }

                        /// <summary>
                        /// <para>Pattern for matching</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>first</para>
                        /// </summary>
                        [NameInMap("pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                    }

                    /// <summary>
                    /// <para>Risk alert level</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Critical</para>
                    /// </summary>
                    [NameInMap("level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>Risk type identifier</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>K8S</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Security guard service address</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://api.example.com/v1">https://api.example.com/v1</a></para>
                /// </summary>
                [NameInMap("serviceAddress")]
                [Validation(Required=false)]
                public string ServiceAddress { get; set; }

            }

            /// <summary>
            /// <para>AI Token Rate Limit configuration</para>
            /// </summary>
            [NameInMap("aiTokenRateLimitConfig")]
            [Validation(Required=false)]
            public HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfig AiTokenRateLimitConfig { get; set; }
            public class HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfig : TeaModel {
                /// <summary>
                /// <para>Whether to enable global rate limit rules</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableGlobalRules")]
                [Validation(Required=false)]
                public bool? EnableGlobalRules { get; set; }

                /// <summary>
                /// <para>List of global rate limit rules</para>
                /// </summary>
                [NameInMap("globalRules")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfigGlobalRules> GlobalRules { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfigGlobalRules : TeaModel {
                    /// <summary>
                    /// <para>Limit mode for global rules</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>local</para>
                    /// </summary>
                    [NameInMap("limitMode")]
                    [Validation(Required=false)]
                    public string LimitMode { get; set; }

                    /// <summary>
                    /// <para>Limit type for global rules</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>request</para>
                    /// </summary>
                    [NameInMap("limitType")]
                    [Validation(Required=false)]
                    public string LimitType { get; set; }

                    /// <summary>
                    /// <para>Limit value for global rules</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("limitValue")]
                    [Validation(Required=false)]
                    public int? LimitValue { get; set; }

                    /// <summary>
                    /// <para>Match key</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user_id</para>
                    /// </summary>
                    [NameInMap("matchKey")]
                    [Validation(Required=false)]
                    public string MatchKey { get; set; }

                    /// <summary>
                    /// <para>Match type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>term</para>
                    /// </summary>
                    [NameInMap("matchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    /// <summary>
                    /// <para>Match value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user123</para>
                    /// </summary>
                    [NameInMap("matchValue")]
                    [Validation(Required=false)]
                    public string MatchValue { get; set; }

                }

                /// <summary>
                /// <para>List of rate limit rules</para>
                /// </summary>
                [NameInMap("rules")]
                [Validation(Required=false)]
                public List<HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfigRules> Rules { get; set; }
                public class HttpApiDeployConfigPolicyConfigsAiTokenRateLimitConfigRules : TeaModel {
                    /// <summary>
                    /// <para>Limit mode</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>local</para>
                    /// </summary>
                    [NameInMap("limitMode")]
                    [Validation(Required=false)]
                    public string LimitMode { get; set; }

                    /// <summary>
                    /// <para>Limit type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>request/token</para>
                    /// </summary>
                    [NameInMap("limitType")]
                    [Validation(Required=false)]
                    public string LimitType { get; set; }

                    /// <summary>
                    /// <para>Limit value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("limitValue")]
                    [Validation(Required=false)]
                    public int? LimitValue { get; set; }

                    /// <summary>
                    /// <para>Match key</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user_id/api_path</para>
                    /// </summary>
                    [NameInMap("matchKey")]
                    [Validation(Required=false)]
                    public string MatchKey { get; set; }

                    /// <summary>
                    /// <para>Match type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>term</para>
                    /// </summary>
                    [NameInMap("matchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    /// <summary>
                    /// <para>Match value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user123</para>
                    /// </summary>
                    [NameInMap("matchValue")]
                    [Validation(Required=false)]
                    public string MatchValue { get; set; }

                }

            }

            /// <summary>
            /// <para>Specifies whether to enable the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The type of the policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>AiFallback</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>routeBackend</para>
        /// </summary>
        [NameInMap("routeBackend")]
        [Validation(Required=false)]
        public Backend RouteBackend { get; set; }

        /// <summary>
        /// <para>The service configurations.</para>
        /// </summary>
        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigServiceConfigs> ServiceConfigs { get; set; }
        public class HttpApiDeployConfigServiceConfigs : TeaModel {
            /// <summary>
            /// <para>Legacy gateway service ID for backward compatibility</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-svc-abc123</para>
            /// </summary>
            [NameInMap("gatewayServiceId")]
            [Validation(Required=false)]
            public string GatewayServiceId { get; set; }

            /// <summary>
            /// <para>Intent classification code</para>
            /// 
            /// <b>Example:</b>
            /// <para>INQUIRY</para>
            /// </summary>
            [NameInMap("intentCode")]
            [Validation(Required=false)]
            public string IntentCode { get; set; }

            /// <summary>
            /// <para>Match conditions</para>
            /// </summary>
            [NameInMap("match")]
            [Validation(Required=false)]
            public HttpApiBackendMatchConditions Match { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The model name matching rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-*</para>
            /// </summary>
            [NameInMap("modelNamePattern")]
            [Validation(Required=false)]
            public string ModelNamePattern { get; set; }

            /// <summary>
            /// <para>Multi-service routing strategy type</para>
            /// 
            /// <b>Example:</b>
            /// <para>ByWeight</para>
            /// </summary>
            [NameInMap("multiServiceRouteStrategy")]
            [Validation(Required=false)]
            public string MultiServiceRouteStrategy { get; set; }

            /// <summary>
            /// <para>Service display name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen-Max-Service</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Observability metrics-based routing config</para>
            /// </summary>
            [NameInMap("observabilityRouteConfig")]
            [Validation(Required=false)]
            public HttpApiDeployConfigServiceConfigsObservabilityRouteConfig ObservabilityRouteConfig { get; set; }
            public class HttpApiDeployConfigServiceConfigsObservabilityRouteConfig : TeaModel {
                /// <summary>
                /// <para>Routing mode</para>
                /// 
                /// <b>Example:</b>
                /// <para>LeastBusy</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>Queue size</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("queueSize")]
                [Validation(Required=false)]
                public int? QueueSize { get; set; }

                /// <summary>
                /// <para>Max traffic ratio per single service</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("rateLimit")]
                [Validation(Required=false)]
                public float? RateLimit { get; set; }

            }

            /// <summary>
            /// <para>Service port number</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>Service protocol</para>
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
            /// <para>Service version tag for tag-based routing scenarios</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
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
            public long? Weight { get; set; }

        }

        /// <summary>
        /// <para>The information about the sub-domain names.</para>
        /// </summary>
        [NameInMap("subDomains")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfigSubDomains> SubDomains { get; set; }
        public class HttpApiDeployConfigSubDomains : TeaModel {
            /// <summary>
            /// <para>The domain name ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-csmn42um1hksudfk9eng</para>
            /// </summary>
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Intranet</para>
            /// </summary>
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

    }

}
