// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateHttpApiRouteRequest : TeaModel {
        /// <summary>
        /// <para>The backend service configurations of the route.</para>
        /// </summary>
        [NameInMap("backendConfig")]
        [Validation(Required=false)]
        public UpdateHttpApiRouteRequestBackendConfig BackendConfig { get; set; }
        public class UpdateHttpApiRouteRequestBackendConfig : TeaModel {
            /// <summary>
            /// <para>The backend service scenario.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SingleService</description></item>
            /// <item><description>MultiServiceByRatio</description></item>
            /// <item><description>Redirect</description></item>
            /// <item><description>Mock</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SingleService</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The backend services.</para>
            /// </summary>
            [NameInMap("services")]
            [Validation(Required=false)]
            public List<UpdateHttpApiRouteRequestBackendConfigServices> Services { get; set; }
            public class UpdateHttpApiRouteRequestBackendConfigServices : TeaModel {
                /// <summary>
                /// <para>The service port. If you want to use a dynamic port, do not pass this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HTTP</description></item>
                /// <item><description>HTTPS</description></item>
                /// </list>
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
                /// <para>svc-cr6pk4tlhtgm58e***</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

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
                /// <para>The percentage value of traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The route description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test route</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The domain IDs.</para>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>The environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cquqsollhtgid***</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The rules for matching the route.</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public HttpRouteMatch Match { get; set; }

        [NameInMap("mcpRouteConfig")]
        [Validation(Required=false)]
        public UpdateHttpApiRouteRequestMcpRouteConfig McpRouteConfig { get; set; }
        public class UpdateHttpApiRouteRequestMcpRouteConfig : TeaModel {
            [NameInMap("exposedUriPath")]
            [Validation(Required=false)]
            public string ExposedUriPath { get; set; }

            [NameInMap("mcpStatisticsEnable")]
            [Validation(Required=false)]
            public bool? McpStatisticsEnable { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<UpdateHttpApiRouteRequestPolicyConfigs> PolicyConfigs { get; set; }
        public class UpdateHttpApiRouteRequestPolicyConfigs : TeaModel {
            [NameInMap("aiCacheConfig")]
            [Validation(Required=false)]
            public UpdateHttpApiRouteRequestPolicyConfigsAiCacheConfig AiCacheConfig { get; set; }
            public class UpdateHttpApiRouteRequestPolicyConfigsAiCacheConfig : TeaModel {
                [NameInMap("cacheKeyStrategy")]
                [Validation(Required=false)]
                public string CacheKeyStrategy { get; set; }

                [NameInMap("cacheMode")]
                [Validation(Required=false)]
                public string CacheMode { get; set; }

                [NameInMap("cacheTTL")]
                [Validation(Required=false)]
                public int? CacheTTL { get; set; }

                [NameInMap("embeddingConfig")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiCacheConfigEmbeddingConfig EmbeddingConfig { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiCacheConfigEmbeddingConfig : TeaModel {
                    [NameInMap("modelName")]
                    [Validation(Required=false)]
                    public string ModelName { get; set; }

                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    [NameInMap("timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("pluginStatus")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiCacheConfigPluginStatus PluginStatus { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiCacheConfigPluginStatus : TeaModel {
                    [NameInMap("errorLogs")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ErrorLogs { get; set; }

                    [NameInMap("pluginId")]
                    [Validation(Required=false)]
                    public string PluginId { get; set; }

                    [NameInMap("serviceHealthy")]
                    [Validation(Required=false)]
                    public bool? ServiceHealthy { get; set; }

                }

                [NameInMap("redisConfig")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiCacheConfigRedisConfig RedisConfig { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiCacheConfigRedisConfig : TeaModel {
                    [NameInMap("databaseNumber")]
                    [Validation(Required=false)]
                    public int? DatabaseNumber { get; set; }

                    [NameInMap("host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                [NameInMap("vectorConfig")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiCacheConfigVectorConfig VectorConfig { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiCacheConfigVectorConfig : TeaModel {
                    [NameInMap("apiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    [NameInMap("collectionId")]
                    [Validation(Required=false)]
                    public string CollectionId { get; set; }

                    [NameInMap("serviceHost")]
                    [Validation(Required=false)]
                    public string ServiceHost { get; set; }

                    [NameInMap("threshold")]
                    [Validation(Required=false)]
                    public float? Threshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>6000</para>
                    /// </summary>
                    [NameInMap("timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("aiFallbackConfig")]
            [Validation(Required=false)]
            public UpdateHttpApiRouteRequestPolicyConfigsAiFallbackConfig AiFallbackConfig { get; set; }
            public class UpdateHttpApiRouteRequestPolicyConfigsAiFallbackConfig : TeaModel {
                [NameInMap("onlyRedirectUpstreamCode")]
                [Validation(Required=false)]
                public bool? OnlyRedirectUpstreamCode { get; set; }

                [NameInMap("routeEmbedded")]
                [Validation(Required=false)]
                public bool? RouteEmbedded { get; set; }

                [NameInMap("serviceConfigs")]
                [Validation(Required=false)]
                public List<UpdateHttpApiRouteRequestPolicyConfigsAiFallbackConfigServiceConfigs> ServiceConfigs { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiFallbackConfigServiceConfigs : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("passThroughModelName")]
                    [Validation(Required=false)]
                    public bool? PassThroughModelName { get; set; }

                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    [NameInMap("targetModelName")]
                    [Validation(Required=false)]
                    public string TargetModelName { get; set; }

                }

            }

            [NameInMap("aiNetworkSearchConfig")]
            [Validation(Required=false)]
            public UpdateHttpApiRouteRequestPolicyConfigsAiNetworkSearchConfig AiNetworkSearchConfig { get; set; }
            public class UpdateHttpApiRouteRequestPolicyConfigsAiNetworkSearchConfig : TeaModel {
                [NameInMap("defaultEnable")]
                [Validation(Required=false)]
                public bool? DefaultEnable { get; set; }

                [NameInMap("defaultLang")]
                [Validation(Required=false)]
                public string DefaultLang { get; set; }

                [NameInMap("needReference")]
                [Validation(Required=false)]
                public bool? NeedReference { get; set; }

                [NameInMap("pluginStatus")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiNetworkSearchConfigPluginStatus PluginStatus { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiNetworkSearchConfigPluginStatus : TeaModel {
                    [NameInMap("errorLogs")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ErrorLogs { get; set; }

                    [NameInMap("pluginId")]
                    [Validation(Required=false)]
                    public string PluginId { get; set; }

                    [NameInMap("serviceHealthy")]
                    [Validation(Required=false)]
                    public bool? ServiceHealthy { get; set; }

                }

                [NameInMap("referenceFormat")]
                [Validation(Required=false)]
                public string ReferenceFormat { get; set; }

                [NameInMap("referenceLocation")]
                [Validation(Required=false)]
                public string ReferenceLocation { get; set; }

                [NameInMap("searchEngineConfig")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiNetworkSearchConfigSearchEngineConfig SearchEngineConfig { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiNetworkSearchConfigSearchEngineConfig : TeaModel {
                    [NameInMap("apiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    [NameInMap("contentMode")]
                    [Validation(Required=false)]
                    public string ContentMode { get; set; }

                    [NameInMap("count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    [NameInMap("industry")]
                    [Validation(Required=false)]
                    public string Industry { get; set; }

                    [NameInMap("optionArgs")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> OptionArgs { get; set; }

                    [NameInMap("start")]
                    [Validation(Required=false)]
                    public int? Start { get; set; }

                    [NameInMap("timeRange")]
                    [Validation(Required=false)]
                    public string TimeRange { get; set; }

                    [NameInMap("timeoutMillisecond")]
                    [Validation(Required=false)]
                    public int? TimeoutMillisecond { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("searchFrom")]
                [Validation(Required=false)]
                public List<UpdateHttpApiRouteRequestPolicyConfigsAiNetworkSearchConfigSearchFrom> SearchFrom { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiNetworkSearchConfigSearchFrom : TeaModel {
                    [NameInMap("apiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    [NameInMap("contentMode")]
                    [Validation(Required=false)]
                    public string ContentMode { get; set; }

                    [NameInMap("count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    [NameInMap("industry")]
                    [Validation(Required=false)]
                    public string Industry { get; set; }

                    [NameInMap("optionArgs")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> OptionArgs { get; set; }

                    [NameInMap("start")]
                    [Validation(Required=false)]
                    public int? Start { get; set; }

                    [NameInMap("timeRange")]
                    [Validation(Required=false)]
                    public string TimeRange { get; set; }

                    [NameInMap("timeoutMillisecond")]
                    [Validation(Required=false)]
                    public int? TimeoutMillisecond { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("searchRewrite")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiNetworkSearchConfigSearchRewrite SearchRewrite { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiNetworkSearchConfigSearchRewrite : TeaModel {
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    [NameInMap("maxCount")]
                    [Validation(Required=false)]
                    public int? MaxCount { get; set; }

                    [NameInMap("modelName")]
                    [Validation(Required=false)]
                    public string ModelName { get; set; }

                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    [NameInMap("timeoutMillisecond")]
                    [Validation(Required=false)]
                    public int? TimeoutMillisecond { get; set; }

                }

            }

            [NameInMap("aiSecurityGuardConfig")]
            [Validation(Required=false)]
            public UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfig AiSecurityGuardConfig { get; set; }
            public class UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfig : TeaModel {
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
                public List<UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigConsumerRequestCheckService> ConsumerRequestCheckService { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigConsumerRequestCheckService : TeaModel {
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
                public List<UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigConsumerResponseCheckService> ConsumerResponseCheckService { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigConsumerResponseCheckService : TeaModel {
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
                public List<UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigConsumerRiskLevel> ConsumerRiskLevel { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigConsumerRiskLevel : TeaModel {
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

                [NameInMap("pluginStatus")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigPluginStatus PluginStatus { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigPluginStatus : TeaModel {
                    [NameInMap("errorLogs")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ErrorLogs { get; set; }

                    [NameInMap("pluginId")]
                    [Validation(Required=false)]
                    public string PluginId { get; set; }

                    [NameInMap("serviceHealthy")]
                    [Validation(Required=false)]
                    public bool? ServiceHealthy { get; set; }

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
                public List<UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigRiskConfig> RiskConfig { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigRiskConfig : TeaModel {
                    [NameInMap("consumerRules")]
                    [Validation(Required=false)]
                    public UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigRiskConfigConsumerRules ConsumerRules { get; set; }
                    public class UpdateHttpApiRouteRequestPolicyConfigsAiSecurityGuardConfigRiskConfigConsumerRules : TeaModel {
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

            [NameInMap("aiStatisticsConfig")]
            [Validation(Required=false)]
            public UpdateHttpApiRouteRequestPolicyConfigsAiStatisticsConfig AiStatisticsConfig { get; set; }
            public class UpdateHttpApiRouteRequestPolicyConfigsAiStatisticsConfig : TeaModel {
                [NameInMap("logRequestContent")]
                [Validation(Required=false)]
                public bool? LogRequestContent { get; set; }

                [NameInMap("logResponseContent")]
                [Validation(Required=false)]
                public bool? LogResponseContent { get; set; }

            }

            [NameInMap("aiTokenRateLimitConfig")]
            [Validation(Required=false)]
            public UpdateHttpApiRouteRequestPolicyConfigsAiTokenRateLimitConfig AiTokenRateLimitConfig { get; set; }
            public class UpdateHttpApiRouteRequestPolicyConfigsAiTokenRateLimitConfig : TeaModel {
                [NameInMap("enableGlobalRules")]
                [Validation(Required=false)]
                public bool? EnableGlobalRules { get; set; }

                [NameInMap("globalRules")]
                [Validation(Required=false)]
                public List<UpdateHttpApiRouteRequestPolicyConfigsAiTokenRateLimitConfigGlobalRules> GlobalRules { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiTokenRateLimitConfigGlobalRules : TeaModel {
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

                [NameInMap("pluginStatus")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiTokenRateLimitConfigPluginStatus PluginStatus { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiTokenRateLimitConfigPluginStatus : TeaModel {
                    [NameInMap("errorLogs")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ErrorLogs { get; set; }

                    [NameInMap("pluginId")]
                    [Validation(Required=false)]
                    public string PluginId { get; set; }

                    [NameInMap("serviceHealthy")]
                    [Validation(Required=false)]
                    public bool? ServiceHealthy { get; set; }

                }

                [NameInMap("redisConfig")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiTokenRateLimitConfigRedisConfig RedisConfig { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiTokenRateLimitConfigRedisConfig : TeaModel {
                    [NameInMap("databaseNumber")]
                    [Validation(Required=false)]
                    public int? DatabaseNumber { get; set; }

                    [NameInMap("host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                [NameInMap("rules")]
                [Validation(Required=false)]
                public List<UpdateHttpApiRouteRequestPolicyConfigsAiTokenRateLimitConfigRules> Rules { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiTokenRateLimitConfigRules : TeaModel {
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

            [NameInMap("aiToolSelectionConfig")]
            [Validation(Required=false)]
            public UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfig AiToolSelectionConfig { get; set; }
            public class UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfig : TeaModel {
                [NameInMap("enableConditions")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigEnableConditions EnableConditions { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigEnableConditions : TeaModel {
                    [NameInMap("toolCountThreshold")]
                    [Validation(Required=false)]
                    public int? ToolCountThreshold { get; set; }

                }

                [NameInMap("pluginStatus")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigPluginStatus PluginStatus { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigPluginStatus : TeaModel {
                    [NameInMap("errorLogs")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ErrorLogs { get; set; }

                    [NameInMap("pluginId")]
                    [Validation(Required=false)]
                    public string PluginId { get; set; }

                    [NameInMap("serviceHealthy")]
                    [Validation(Required=false)]
                    public bool? ServiceHealthy { get; set; }

                }

                [NameInMap("queryRewriting")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigQueryRewriting QueryRewriting { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigQueryRewriting : TeaModel {
                    [NameInMap("contextSelection")]
                    [Validation(Required=false)]
                    public UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigQueryRewritingContextSelection ContextSelection { get; set; }
                    public class UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigQueryRewritingContextSelection : TeaModel {
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public int? Value { get; set; }

                    }

                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("fallbackStrategy")]
                    [Validation(Required=false)]
                    public string FallbackStrategy { get; set; }

                    [NameInMap("maxOutputTokens")]
                    [Validation(Required=false)]
                    public int? MaxOutputTokens { get; set; }

                    [NameInMap("modelService")]
                    [Validation(Required=false)]
                    public UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigQueryRewritingModelService ModelService { get; set; }
                    public class UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigQueryRewritingModelService : TeaModel {
                        [NameInMap("modelName")]
                        [Validation(Required=false)]
                        public string ModelName { get; set; }

                        [NameInMap("serviceId")]
                        [Validation(Required=false)]
                        public string ServiceId { get; set; }

                        [NameInMap("timeoutMillisecond")]
                        [Validation(Required=false)]
                        public int? TimeoutMillisecond { get; set; }

                    }

                    [NameInMap("promptConfig")]
                    [Validation(Required=false)]
                    public UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigQueryRewritingPromptConfig PromptConfig { get; set; }
                    public class UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigQueryRewritingPromptConfig : TeaModel {
                        [NameInMap("customPrompt")]
                        [Validation(Required=false)]
                        public string CustomPrompt { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("triggerConditions")]
                    [Validation(Required=false)]
                    public UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigQueryRewritingTriggerConditions TriggerConditions { get; set; }
                    public class UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigQueryRewritingTriggerConditions : TeaModel {
                        [NameInMap("messageCountThreshold")]
                        [Validation(Required=false)]
                        public int? MessageCountThreshold { get; set; }

                    }

                }

                [NameInMap("toolReranking")]
                [Validation(Required=false)]
                public UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigToolReranking ToolReranking { get; set; }
                public class UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigToolReranking : TeaModel {
                    [NameInMap("fallbackStrategy")]
                    [Validation(Required=false)]
                    public string FallbackStrategy { get; set; }

                    [NameInMap("filteringMethod")]
                    [Validation(Required=false)]
                    public string FilteringMethod { get; set; }

                    [NameInMap("modelService")]
                    [Validation(Required=false)]
                    public UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigToolRerankingModelService ModelService { get; set; }
                    public class UpdateHttpApiRouteRequestPolicyConfigsAiToolSelectionConfigToolRerankingModelService : TeaModel {
                        [NameInMap("modelName")]
                        [Validation(Required=false)]
                        public string ModelName { get; set; }

                        [NameInMap("serviceId")]
                        [Validation(Required=false)]
                        public string ServiceId { get; set; }

                        [NameInMap("timeoutMillisecond")]
                        [Validation(Required=false)]
                        public int? TimeoutMillisecond { get; set; }

                    }

                    [NameInMap("scoreThreshold")]
                    [Validation(Required=false)]
                    public float? ScoreThreshold { get; set; }

                    [NameInMap("topKPercent")]
                    [Validation(Required=false)]
                    public int? TopKPercent { get; set; }

                    [NameInMap("topNCount")]
                    [Validation(Required=false)]
                    public int? TopNCount { get; set; }

                }

            }

            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("semanticRouterConfig")]
            [Validation(Required=false)]
            public UpdateHttpApiRouteRequestPolicyConfigsSemanticRouterConfig SemanticRouterConfig { get; set; }
            public class UpdateHttpApiRouteRequestPolicyConfigsSemanticRouterConfig : TeaModel {
                [NameInMap("timeoutMillisecond")]
                [Validation(Required=false)]
                public int? TimeoutMillisecond { get; set; }

            }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
