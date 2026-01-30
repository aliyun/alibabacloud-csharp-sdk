// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiPolicyConfigs : TeaModel {
        [NameInMap("aiCacheConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsAiCacheConfig AiCacheConfig { get; set; }
        public class HttpApiPolicyConfigsAiCacheConfig : TeaModel {
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
            public HttpApiPolicyConfigsAiCacheConfigEmbeddingConfig EmbeddingConfig { get; set; }
            public class HttpApiPolicyConfigsAiCacheConfigEmbeddingConfig : TeaModel {
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
            public HttpApiPolicyConfigsAiCacheConfigPluginStatus PluginStatus { get; set; }
            public class HttpApiPolicyConfigsAiCacheConfigPluginStatus : TeaModel {
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
            public HttpApiPolicyConfigsAiCacheConfigRedisConfig RedisConfig { get; set; }
            public class HttpApiPolicyConfigsAiCacheConfigRedisConfig : TeaModel {
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
            public HttpApiPolicyConfigsAiCacheConfigVectorConfig VectorConfig { get; set; }
            public class HttpApiPolicyConfigsAiCacheConfigVectorConfig : TeaModel {
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
        public HttpApiPolicyConfigsAiFallbackConfig AiFallbackConfig { get; set; }
        public class HttpApiPolicyConfigsAiFallbackConfig : TeaModel {
            [NameInMap("onlyRedirectUpstreamCode")]
            [Validation(Required=false)]
            public bool? OnlyRedirectUpstreamCode { get; set; }

            [NameInMap("routeEmbedded")]
            [Validation(Required=false)]
            public bool? RouteEmbedded { get; set; }

            [NameInMap("serviceConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPolicyConfigsAiFallbackConfigServiceConfigs> ServiceConfigs { get; set; }
            public class HttpApiPolicyConfigsAiFallbackConfigServiceConfigs : TeaModel {
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
        public HttpApiPolicyConfigsAiNetworkSearchConfig AiNetworkSearchConfig { get; set; }
        public class HttpApiPolicyConfigsAiNetworkSearchConfig : TeaModel {
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
            public HttpApiPolicyConfigsAiNetworkSearchConfigPluginStatus PluginStatus { get; set; }
            public class HttpApiPolicyConfigsAiNetworkSearchConfigPluginStatus : TeaModel {
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
            public HttpApiPolicyConfigsAiNetworkSearchConfigSearchEngineConfig SearchEngineConfig { get; set; }
            public class HttpApiPolicyConfigsAiNetworkSearchConfigSearchEngineConfig : TeaModel {
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
            public List<HttpApiPolicyConfigsAiNetworkSearchConfigSearchFrom> SearchFrom { get; set; }
            public class HttpApiPolicyConfigsAiNetworkSearchConfigSearchFrom : TeaModel {
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
            public HttpApiPolicyConfigsAiNetworkSearchConfigSearchRewrite SearchRewrite { get; set; }
            public class HttpApiPolicyConfigsAiNetworkSearchConfigSearchRewrite : TeaModel {
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
        public HttpApiPolicyConfigsAiSecurityGuardConfig AiSecurityGuardConfig { get; set; }
        public class HttpApiPolicyConfigsAiSecurityGuardConfig : TeaModel {
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
            public List<HttpApiPolicyConfigsAiSecurityGuardConfigConsumerRequestCheckService> ConsumerRequestCheckService { get; set; }
            public class HttpApiPolicyConfigsAiSecurityGuardConfigConsumerRequestCheckService : TeaModel {
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
            public List<HttpApiPolicyConfigsAiSecurityGuardConfigConsumerResponseCheckService> ConsumerResponseCheckService { get; set; }
            public class HttpApiPolicyConfigsAiSecurityGuardConfigConsumerResponseCheckService : TeaModel {
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
            public List<HttpApiPolicyConfigsAiSecurityGuardConfigConsumerRiskLevel> ConsumerRiskLevel { get; set; }
            public class HttpApiPolicyConfigsAiSecurityGuardConfigConsumerRiskLevel : TeaModel {
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
            public HttpApiPolicyConfigsAiSecurityGuardConfigPluginStatus PluginStatus { get; set; }
            public class HttpApiPolicyConfigsAiSecurityGuardConfigPluginStatus : TeaModel {
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
            public List<HttpApiPolicyConfigsAiSecurityGuardConfigRiskConfig> RiskConfig { get; set; }
            public class HttpApiPolicyConfigsAiSecurityGuardConfigRiskConfig : TeaModel {
                [NameInMap("consumerRules")]
                [Validation(Required=false)]
                public HttpApiPolicyConfigsAiSecurityGuardConfigRiskConfigConsumerRules ConsumerRules { get; set; }
                public class HttpApiPolicyConfigsAiSecurityGuardConfigRiskConfigConsumerRules : TeaModel {
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
        public HttpApiPolicyConfigsAiStatisticsConfig AiStatisticsConfig { get; set; }
        public class HttpApiPolicyConfigsAiStatisticsConfig : TeaModel {
            [NameInMap("logRequestContent")]
            [Validation(Required=false)]
            public bool? LogRequestContent { get; set; }

            [NameInMap("logResponseContent")]
            [Validation(Required=false)]
            public bool? LogResponseContent { get; set; }

        }

        [NameInMap("aiTokenRateLimitConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsAiTokenRateLimitConfig AiTokenRateLimitConfig { get; set; }
        public class HttpApiPolicyConfigsAiTokenRateLimitConfig : TeaModel {
            [NameInMap("enableGlobalRules")]
            [Validation(Required=false)]
            public bool? EnableGlobalRules { get; set; }

            [NameInMap("globalRules")]
            [Validation(Required=false)]
            public List<HttpApiPolicyConfigsAiTokenRateLimitConfigGlobalRules> GlobalRules { get; set; }
            public class HttpApiPolicyConfigsAiTokenRateLimitConfigGlobalRules : TeaModel {
                [NameInMap("limitMode")]
                [Validation(Required=false)]
                public string LimitMode { get; set; }

                [NameInMap("limitType")]
                [Validation(Required=false)]
                public string LimitType { get; set; }

                [NameInMap("limitValue")]
                [Validation(Required=false)]
                public string LimitValue { get; set; }

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
            public HttpApiPolicyConfigsAiTokenRateLimitConfigPluginStatus PluginStatus { get; set; }
            public class HttpApiPolicyConfigsAiTokenRateLimitConfigPluginStatus : TeaModel {
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
            public HttpApiPolicyConfigsAiTokenRateLimitConfigRedisConfig RedisConfig { get; set; }
            public class HttpApiPolicyConfigsAiTokenRateLimitConfigRedisConfig : TeaModel {
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
            public List<HttpApiPolicyConfigsAiTokenRateLimitConfigRules> Rules { get; set; }
            public class HttpApiPolicyConfigsAiTokenRateLimitConfigRules : TeaModel {
                [NameInMap("limitMode")]
                [Validation(Required=false)]
                public string LimitMode { get; set; }

                [NameInMap("limitType")]
                [Validation(Required=false)]
                public string LimitType { get; set; }

                [NameInMap("limitValue")]
                [Validation(Required=false)]
                public string LimitValue { get; set; }

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
        public HttpApiPolicyConfigsAiToolSelectionConfig AiToolSelectionConfig { get; set; }
        public class HttpApiPolicyConfigsAiToolSelectionConfig : TeaModel {
            [NameInMap("enableConditions")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiToolSelectionConfigEnableConditions EnableConditions { get; set; }
            public class HttpApiPolicyConfigsAiToolSelectionConfigEnableConditions : TeaModel {
                [NameInMap("toolCountThreshold")]
                [Validation(Required=false)]
                public int? ToolCountThreshold { get; set; }

            }

            [NameInMap("pluginStatus")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiToolSelectionConfigPluginStatus PluginStatus { get; set; }
            public class HttpApiPolicyConfigsAiToolSelectionConfigPluginStatus : TeaModel {
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
            public HttpApiPolicyConfigsAiToolSelectionConfigQueryRewriting QueryRewriting { get; set; }
            public class HttpApiPolicyConfigsAiToolSelectionConfigQueryRewriting : TeaModel {
                [NameInMap("contextSelection")]
                [Validation(Required=false)]
                public HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingContextSelection ContextSelection { get; set; }
                public class HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingContextSelection : TeaModel {
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
                public HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingModelService ModelService { get; set; }
                public class HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingModelService : TeaModel {
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
                public HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingPromptConfig PromptConfig { get; set; }
                public class HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingPromptConfig : TeaModel {
                    [NameInMap("customPrompt")]
                    [Validation(Required=false)]
                    public string CustomPrompt { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("triggerConditions")]
                [Validation(Required=false)]
                public HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingTriggerConditions TriggerConditions { get; set; }
                public class HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingTriggerConditions : TeaModel {
                    [NameInMap("messageCountThreshold")]
                    [Validation(Required=false)]
                    public int? MessageCountThreshold { get; set; }

                }

            }

            [NameInMap("toolReranking")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiToolSelectionConfigToolReranking ToolReranking { get; set; }
            public class HttpApiPolicyConfigsAiToolSelectionConfigToolReranking : TeaModel {
                [NameInMap("fallbackStrategy")]
                [Validation(Required=false)]
                public string FallbackStrategy { get; set; }

                [NameInMap("filteringMethod")]
                [Validation(Required=false)]
                public string FilteringMethod { get; set; }

                [NameInMap("modelService")]
                [Validation(Required=false)]
                public HttpApiPolicyConfigsAiToolSelectionConfigToolRerankingModelService ModelService { get; set; }
                public class HttpApiPolicyConfigsAiToolSelectionConfigToolRerankingModelService : TeaModel {
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
        public HttpApiPolicyConfigsSemanticRouterConfig SemanticRouterConfig { get; set; }
        public class HttpApiPolicyConfigsSemanticRouterConfig : TeaModel {
            [NameInMap("timeoutMillisecond")]
            [Validation(Required=false)]
            public int? TimeoutMillisecond { get; set; }

        }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
