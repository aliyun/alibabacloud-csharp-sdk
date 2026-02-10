// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiPolicyConfigs : TeaModel {
        /// <summary>
        /// <para>AiCacheConfig</para>
        /// </summary>
        [NameInMap("aiCacheConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsAiCacheConfig AiCacheConfig { get; set; }
        public class HttpApiPolicyConfigsAiCacheConfig : TeaModel {
            /// <summary>
            /// <para>Strategy for generating cache keys</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("cacheKeyStrategy")]
            [Validation(Required=false)]
            public string CacheKeyStrategy { get; set; }

            /// <summary>
            /// <para>Cache mode type</para>
            /// 
            /// <b>Example:</b>
            /// <para>exact</para>
            /// </summary>
            [NameInMap("cacheMode")]
            [Validation(Required=false)]
            public string CacheMode { get; set; }

            /// <summary>
            /// <para>Cache time-to-live in seconds</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("cacheTTL")]
            [Validation(Required=false)]
            public int? CacheTTL { get; set; }

            /// <summary>
            /// <para>Embedding Config</para>
            /// </summary>
            [NameInMap("embeddingConfig")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiCacheConfigEmbeddingConfig EmbeddingConfig { get; set; }
            public class HttpApiPolicyConfigsAiCacheConfigEmbeddingConfig : TeaModel {
                /// <summary>
                /// <para>Embedding model name</para>
                /// 
                /// <b>Example:</b>
                /// <para>model-1</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>Embedding service ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>svc-1</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>Embedding service request timeout in milliseconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>Embedding service provider type</para>
                /// 
                /// <b>Example:</b>
                /// <para>dashscope</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>pluginStatus</para>
            /// </summary>
            [NameInMap("pluginStatus")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiCacheConfigPluginStatus PluginStatus { get; set; }
            public class HttpApiPolicyConfigsAiCacheConfigPluginStatus : TeaModel {
                /// <summary>
                /// <para>errorLogs</para>
                /// </summary>
                [NameInMap("errorLogs")]
                [Validation(Required=false)]
                public Dictionary<string, string> ErrorLogs { get; set; }

                /// <summary>
                /// <para>pluginId</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-123456</para>
                /// </summary>
                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// <para>serviceHealthy</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("serviceHealthy")]
                [Validation(Required=false)]
                public bool? ServiceHealthy { get; set; }

            }

            /// <summary>
            /// <para>Redis configuration for cache storage</para>
            /// </summary>
            [NameInMap("redisConfig")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiCacheConfigRedisConfig RedisConfig { get; set; }
            public class HttpApiPolicyConfigsAiCacheConfigRedisConfig : TeaModel {
                /// <summary>
                /// <para>Redis database number</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("databaseNumber")]
                [Validation(Required=false)]
                public int? DatabaseNumber { get; set; }

                /// <summary>
                /// <para>Redis host</para>
                /// 
                /// <b>Example:</b>
                /// <para>redis.example.com</para>
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>Redis password</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>Redis port</para>
                /// 
                /// <b>Example:</b>
                /// <para>6379</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>Redis timeout</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>Redis username</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>vectorConfig</para>
            /// </summary>
            [NameInMap("vectorConfig")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiCacheConfigVectorConfig VectorConfig { get; set; }
            public class HttpApiPolicyConfigsAiCacheConfigVectorConfig : TeaModel {
                /// <summary>
                /// <para>Vector database API key for authentication</para>
                /// 
                /// <b>Example:</b>
                /// <para>vec-api-key-123</para>
                /// </summary>
                [NameInMap("apiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>Vector database collection ID for storing vector embeddings</para>
                /// 
                /// <b>Example:</b>
                /// <para>col-1</para>
                /// </summary>
                [NameInMap("collectionId")]
                [Validation(Required=false)]
                public string CollectionId { get; set; }

                /// <summary>
                /// <para>Vector database service host address</para>
                /// 
                /// <b>Example:</b>
                /// <para>vec.example.com</para>
                /// </summary>
                [NameInMap("serviceHost")]
                [Validation(Required=false)]
                public string ServiceHost { get; set; }

                /// <summary>
                /// <para>Similarity threshold for semantic matching</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

                /// <summary>
                /// <para>Vector database request timeout in milliseconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>Vector database service type</para>
                /// 
                /// <b>Example:</b>
                /// <para>dashvector</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>AiFallbackConfig</para>
        /// </summary>
        [NameInMap("aiFallbackConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsAiFallbackConfig AiFallbackConfig { get; set; }
        public class HttpApiPolicyConfigsAiFallbackConfig : TeaModel {
            /// <summary>
            /// <para>Only trigger fallback when backend returns 4xx/5xx status codes</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("onlyRedirectUpstreamCode")]
            [Validation(Required=false)]
            public bool? OnlyRedirectUpstreamCode { get; set; }

            /// <summary>
            /// <para>Whether the policy is generated from route embedded configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("routeEmbedded")]
            [Validation(Required=false)]
            public bool? RouteEmbedded { get; set; }

            /// <summary>
            /// <para>List of fallback service configurations</para>
            /// </summary>
            [NameInMap("serviceConfigs")]
            [Validation(Required=false)]
            public List<HttpApiPolicyConfigsAiFallbackConfigServiceConfigs> ServiceConfigs { get; set; }
            public class HttpApiPolicyConfigsAiFallbackConfigServiceConfigs : TeaModel {
                /// <summary>
                /// <para>Service name for frontend display</para>
                /// 
                /// <b>Example:</b>
                /// <para>azure.ai</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Whether to pass through the original model name</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("passThroughModelName")]
                [Validation(Required=false)]
                public bool? PassThroughModelName { get; set; }

                /// <summary>
                /// <para>Fallback service ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>svc-123456</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>Target model name for fallback</para>
                /// 
                /// <b>Example:</b>
                /// <para>kimi-fallback-test</para>
                /// </summary>
                [NameInMap("targetModelName")]
                [Validation(Required=false)]
                public string TargetModelName { get; set; }

            }

        }

        /// <summary>
        /// <para>AiNetworkSearchConfig</para>
        /// </summary>
        [NameInMap("aiNetworkSearchConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsAiNetworkSearchConfig AiNetworkSearchConfig { get; set; }
        public class HttpApiPolicyConfigsAiNetworkSearchConfig : TeaModel {
            /// <summary>
            /// <para>Default enable</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("defaultEnable")]
            [Validation(Required=false)]
            public bool? DefaultEnable { get; set; }

            /// <summary>
            /// <para>Default search language code</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("defaultLang")]
            [Validation(Required=false)]
            public string DefaultLang { get; set; }

            /// <summary>
            /// <para>Add reference sources in answer</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("needReference")]
            [Validation(Required=false)]
            public bool? NeedReference { get; set; }

            /// <summary>
            /// <para>pluginStatus</para>
            /// </summary>
            [NameInMap("pluginStatus")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiNetworkSearchConfigPluginStatus PluginStatus { get; set; }
            public class HttpApiPolicyConfigsAiNetworkSearchConfigPluginStatus : TeaModel {
                /// <summary>
                /// <para>errorLogs</para>
                /// </summary>
                [NameInMap("errorLogs")]
                [Validation(Required=false)]
                public Dictionary<string, string> ErrorLogs { get; set; }

                /// <summary>
                /// <para>pluginId</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-123456</para>
                /// </summary>
                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// <para>serviceHealthy</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("serviceHealthy")]
                [Validation(Required=false)]
                public bool? ServiceHealthy { get; set; }

            }

            /// <summary>
            /// <para>Reference format</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reference: %s</para>
            /// </summary>
            [NameInMap("referenceFormat")]
            [Validation(Required=false)]
            public string ReferenceFormat { get; set; }

            /// <summary>
            /// <para>Reference location</para>
            /// 
            /// <b>Example:</b>
            /// <para>head</para>
            /// </summary>
            [NameInMap("referenceLocation")]
            [Validation(Required=false)]
            public string ReferenceLocation { get; set; }

            /// <summary>
            /// <para>Search engine configuration</para>
            /// </summary>
            [NameInMap("searchEngineConfig")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiNetworkSearchConfigSearchEngineConfig SearchEngineConfig { get; set; }
            public class HttpApiPolicyConfigsAiNetworkSearchConfigSearchEngineConfig : TeaModel {
                /// <summary>
                /// <para>Search engine API key</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("apiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>Content mode</para>
                /// 
                /// <b>Example:</b>
                /// <para>summary</para>
                /// </summary>
                [NameInMap("contentMode")]
                [Validation(Required=false)]
                public string ContentMode { get; set; }

                /// <summary>
                /// <para>Result count</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>Search engine endpoint</para>
                /// 
                /// <b>Example:</b>
                /// <para>******-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>Industry</para>
                /// 
                /// <b>Example:</b>
                /// <para>tech</para>
                /// </summary>
                [NameInMap("industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                /// <summary>
                /// <para>Additional parameters</para>
                /// </summary>
                [NameInMap("optionArgs")]
                [Validation(Required=false)]
                public Dictionary<string, string> OptionArgs { get; set; }

                /// <summary>
                /// <para>Result offset</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public int? Start { get; set; }

                /// <summary>
                /// <para>Time range</para>
                /// 
                /// <b>Example:</b>
                /// <para>7d</para>
                /// </summary>
                [NameInMap("timeRange")]
                [Validation(Required=false)]
                public string TimeRange { get; set; }

                /// <summary>
                /// <para>API call timeout in milliseconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("timeoutMillisecond")]
                [Validation(Required=false)]
                public int? TimeoutMillisecond { get; set; }

                /// <summary>
                /// <para>Search engine type: Bing/aliyunQuark</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bing</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Search engine list</para>
            /// </summary>
            [NameInMap("searchFrom")]
            [Validation(Required=false)]
            public List<HttpApiPolicyConfigsAiNetworkSearchConfigSearchFrom> SearchFrom { get; set; }
            public class HttpApiPolicyConfigsAiNetworkSearchConfigSearchFrom : TeaModel {
                /// <summary>
                /// <para>Search engine API key</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("apiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>Content mode</para>
                /// 
                /// <b>Example:</b>
                /// <para>summary</para>
                /// </summary>
                [NameInMap("contentMode")]
                [Validation(Required=false)]
                public string ContentMode { get; set; }

                /// <summary>
                /// <para>Result count</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>Search engine endpoint</para>
                /// 
                /// <b>Example:</b>
                /// <para>******-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>Industry</para>
                /// 
                /// <b>Example:</b>
                /// <para>tech</para>
                /// </summary>
                [NameInMap("industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                /// <summary>
                /// <para>Additional parameters</para>
                /// </summary>
                [NameInMap("optionArgs")]
                [Validation(Required=false)]
                public Dictionary<string, string> OptionArgs { get; set; }

                /// <summary>
                /// <para>Result offset</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public int? Start { get; set; }

                /// <summary>
                /// <para>Time range</para>
                /// 
                /// <b>Example:</b>
                /// <para>7d</para>
                /// </summary>
                [NameInMap("timeRange")]
                [Validation(Required=false)]
                public string TimeRange { get; set; }

                /// <summary>
                /// <para>API call timeout in milliseconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("timeoutMillisecond")]
                [Validation(Required=false)]
                public int? TimeoutMillisecond { get; set; }

                /// <summary>
                /// <para>Search engine type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bing</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Search rewrite configuration</para>
            /// </summary>
            [NameInMap("searchRewrite")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiNetworkSearchConfigSearchRewrite SearchRewrite { get; set; }
            public class HttpApiPolicyConfigsAiNetworkSearchConfigSearchRewrite : TeaModel {
                /// <summary>
                /// <para>Enable search rewrite</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>Max rewrite count (1-5)</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("maxCount")]
                [Validation(Required=false)]
                public int? MaxCount { get; set; }

                /// <summary>
                /// <para>Model name</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-turbo</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>Service ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>svc-123456</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>Timeout in milliseconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("timeoutMillisecond")]
                [Validation(Required=false)]
                public int? TimeoutMillisecond { get; set; }

            }

        }

        /// <summary>
        /// <para>AiSecurityGuardConfig</para>
        /// </summary>
        [NameInMap("aiSecurityGuardConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsAiSecurityGuardConfig AiSecurityGuardConfig { get; set; }
        public class HttpApiPolicyConfigsAiSecurityGuardConfig : TeaModel {
            /// <summary>
            /// <para>Buffer limit for content checking</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("bufferLimit")]
            [Validation(Required=false)]
            public int? BufferLimit { get; set; }

            /// <summary>
            /// <para>Enable request content checking</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("checkRequest")]
            [Validation(Required=false)]
            public bool? CheckRequest { get; set; }

            /// <summary>
            /// <para>Enable request image checking</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("checkRequestImage")]
            [Validation(Required=false)]
            public bool? CheckRequestImage { get; set; }

            /// <summary>
            /// <para>Enable response content checking</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("checkResponse")]
            [Validation(Required=false)]
            public bool? CheckResponse { get; set; }

            /// <summary>
            /// <para>Enable response image checking</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("checkResponseImage")]
            [Validation(Required=false)]
            public bool? CheckResponseImage { get; set; }

            /// <summary>
            /// <para>consumerRequestCheckService</para>
            /// </summary>
            [NameInMap("consumerRequestCheckService")]
            [Validation(Required=false)]
            public List<HttpApiPolicyConfigsAiSecurityGuardConfigConsumerRequestCheckService> ConsumerRequestCheckService { get; set; }
            public class HttpApiPolicyConfigsAiSecurityGuardConfigConsumerRequestCheckService : TeaModel {
                /// <summary>
                /// <para>Match type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exact</para>
                /// </summary>
                [NameInMap("matchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <para>Modality type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Text</para>
                /// </summary>
                [NameInMap("modalityType")]
                [Validation(Required=false)]
                public string ModalityType { get; set; }

                /// <summary>
                /// <para>Consumer name</para>
                /// 
                /// <b>Example:</b>
                /// <para>consumer-1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>requestCheckService</para>
                /// 
                /// <b>Example:</b>
                /// <para>query_security_check</para>
                /// </summary>
                [NameInMap("requestCheckService")]
                [Validation(Required=false)]
                public string RequestCheckService { get; set; }

                /// <summary>
                /// <para>requestImageCheckService</para>
                /// 
                /// <b>Example:</b>
                /// <para>nsfw-image-detector</para>
                /// </summary>
                [NameInMap("requestImageCheckService")]
                [Validation(Required=false)]
                public string RequestImageCheckService { get; set; }

            }

            /// <summary>
            /// <para>consumerResponseCheckService</para>
            /// </summary>
            [NameInMap("consumerResponseCheckService")]
            [Validation(Required=false)]
            public List<HttpApiPolicyConfigsAiSecurityGuardConfigConsumerResponseCheckService> ConsumerResponseCheckService { get; set; }
            public class HttpApiPolicyConfigsAiSecurityGuardConfigConsumerResponseCheckService : TeaModel {
                /// <summary>
                /// <para>Match type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exact</para>
                /// </summary>
                [NameInMap("matchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <para>Modality type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Text</para>
                /// </summary>
                [NameInMap("modalityType")]
                [Validation(Required=false)]
                public string ModalityType { get; set; }

                /// <summary>
                /// <para>Consumer name</para>
                /// 
                /// <b>Example:</b>
                /// <para>consumer-1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>responseCheckService</para>
                /// 
                /// <b>Example:</b>
                /// <para>response_security_check</para>
                /// </summary>
                [NameInMap("responseCheckService")]
                [Validation(Required=false)]
                public string ResponseCheckService { get; set; }

                /// <summary>
                /// <para>responseImageCheckService</para>
                /// 
                /// <b>Example:</b>
                /// <para>watermark-detector</para>
                /// </summary>
                [NameInMap("responseImageCheckService")]
                [Validation(Required=false)]
                public string ResponseImageCheckService { get; set; }

            }

            /// <summary>
            /// <para>consumerRiskLevel</para>
            /// </summary>
            [NameInMap("consumerRiskLevel")]
            [Validation(Required=false)]
            public List<HttpApiPolicyConfigsAiSecurityGuardConfigConsumerRiskLevel> ConsumerRiskLevel { get; set; }
            public class HttpApiPolicyConfigsAiSecurityGuardConfigConsumerRiskLevel : TeaModel {
                /// <summary>
                /// <para>Risk level</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>Match type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exact</para>
                /// </summary>
                [NameInMap("matchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <para>Consumer name</para>
                /// 
                /// <b>Example:</b>
                /// <para>consumer-1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Risk type</para>
                /// 
                /// <b>Example:</b>
                /// <para>ContentModeration</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>pluginStatus</para>
            /// </summary>
            [NameInMap("pluginStatus")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiSecurityGuardConfigPluginStatus PluginStatus { get; set; }
            public class HttpApiPolicyConfigsAiSecurityGuardConfigPluginStatus : TeaModel {
                /// <summary>
                /// <para>errorLogs</para>
                /// </summary>
                [NameInMap("errorLogs")]
                [Validation(Required=false)]
                public Dictionary<string, string> ErrorLogs { get; set; }

                /// <summary>
                /// <para>pluginId</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-123456</para>
                /// </summary>
                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// <para>serviceHealthy</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("serviceHealthy")]
                [Validation(Required=false)]
                public bool? ServiceHealthy { get; set; }

            }

            /// <summary>
            /// <para>Request text check service type</para>
            /// 
            /// <b>Example:</b>
            /// <para>content-moderation-service</para>
            /// </summary>
            [NameInMap("requestCheckService")]
            [Validation(Required=false)]
            public string RequestCheckService { get; set; }

            /// <summary>
            /// <para>Request image check service type</para>
            /// 
            /// <b>Example:</b>
            /// <para>image-moderation-service</para>
            /// </summary>
            [NameInMap("requestImageCheckService")]
            [Validation(Required=false)]
            public string RequestImageCheckService { get; set; }

            /// <summary>
            /// <para>Response text check service type</para>
            /// 
            /// <b>Example:</b>
            /// <para>output-moderation-service</para>
            /// </summary>
            [NameInMap("responseCheckService")]
            [Validation(Required=false)]
            public string ResponseCheckService { get; set; }

            /// <summary>
            /// <para>Response image check service type</para>
            /// 
            /// <b>Example:</b>
            /// <para>generated-image-scanner</para>
            /// </summary>
            [NameInMap("responseImageCheckService")]
            [Validation(Required=false)]
            public string ResponseImageCheckService { get; set; }

            /// <summary>
            /// <para>Global risk alert level</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("riskAlertLevel")]
            [Validation(Required=false)]
            public string RiskAlertLevel { get; set; }

            /// <summary>
            /// <para>RiskConfig</para>
            /// </summary>
            [NameInMap("riskConfig")]
            [Validation(Required=false)]
            public List<HttpApiPolicyConfigsAiSecurityGuardConfigRiskConfig> RiskConfig { get; set; }
            public class HttpApiPolicyConfigsAiSecurityGuardConfigRiskConfig : TeaModel {
                /// <summary>
                /// <para>consumerRules</para>
                /// </summary>
                [NameInMap("consumerRules")]
                [Validation(Required=false)]
                public HttpApiPolicyConfigsAiSecurityGuardConfigRiskConfigConsumerRules ConsumerRules { get; set; }
                public class HttpApiPolicyConfigsAiSecurityGuardConfigRiskConfigConsumerRules : TeaModel {
                    /// <summary>
                    /// <para>matchType</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Exact</para>
                    /// </summary>
                    [NameInMap("matchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    /// <summary>
                    /// <para>pattern</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/chat/*</para>
                    /// </summary>
                    [NameInMap("pattern")]
                    [Validation(Required=false)]
                    public string Pattern { get; set; }

                }

                /// <summary>
                /// <para>Risk level</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>Risk type</para>
                /// 
                /// <b>Example:</b>
                /// <para>ContentModeration</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Security guard service endpoint URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://api.example.com/v1">https://api.example.com/v1</a></para>
            /// </summary>
            [NameInMap("serviceAddress")]
            [Validation(Required=false)]
            public string ServiceAddress { get; set; }

        }

        /// <summary>
        /// <para>AiStatisticsConfig</para>
        /// </summary>
        [NameInMap("aiStatisticsConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsAiStatisticsConfig AiStatisticsConfig { get; set; }
        public class HttpApiPolicyConfigsAiStatisticsConfig : TeaModel {
            /// <summary>
            /// <para>Log request content</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("logRequestContent")]
            [Validation(Required=false)]
            public bool? LogRequestContent { get; set; }

            /// <summary>
            /// <para>Log response content</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("logResponseContent")]
            [Validation(Required=false)]
            public bool? LogResponseContent { get; set; }

        }

        /// <summary>
        /// <para>AiTokenRateLimitConfig</para>
        /// </summary>
        [NameInMap("aiTokenRateLimitConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsAiTokenRateLimitConfig AiTokenRateLimitConfig { get; set; }
        public class HttpApiPolicyConfigsAiTokenRateLimitConfig : TeaModel {
            /// <summary>
            /// <para>Enable global rate limit rules</para>
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
            public List<HttpApiPolicyConfigsAiTokenRateLimitConfigGlobalRules> GlobalRules { get; set; }
            public class HttpApiPolicyConfigsAiTokenRateLimitConfigGlobalRules : TeaModel {
                /// <summary>
                /// <para>Limit mode</para>
                /// 
                /// <b>Example:</b>
                /// <para>TokenPerSecond</para>
                /// </summary>
                [NameInMap("limitMode")]
                [Validation(Required=false)]
                public string LimitMode { get; set; }

                /// <summary>
                /// <para>Limit type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Global</para>
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
                public string LimitValue { get; set; }

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
                /// <para>Exact</para>
                /// </summary>
                [NameInMap("matchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <para>Match value</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("matchValue")]
                [Validation(Required=false)]
                public string MatchValue { get; set; }

            }

            /// <summary>
            /// <para>pluginStatus</para>
            /// </summary>
            [NameInMap("pluginStatus")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiTokenRateLimitConfigPluginStatus PluginStatus { get; set; }
            public class HttpApiPolicyConfigsAiTokenRateLimitConfigPluginStatus : TeaModel {
                /// <summary>
                /// <para>Array of plugin execution error logs</para>
                /// </summary>
                [NameInMap("errorLogs")]
                [Validation(Required=false)]
                public Dictionary<string, string> ErrorLogs { get; set; }

                /// <summary>
                /// <para>Plugin instance unique identifier</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-123456</para>
                /// </summary>
                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// <para>Health status of the cache service</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("serviceHealthy")]
                [Validation(Required=false)]
                public bool? ServiceHealthy { get; set; }

            }

            /// <summary>
            /// <para>Redis Config</para>
            /// </summary>
            [NameInMap("redisConfig")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiTokenRateLimitConfigRedisConfig RedisConfig { get; set; }
            public class HttpApiPolicyConfigsAiTokenRateLimitConfigRedisConfig : TeaModel {
                /// <summary>
                /// <para>Redis database number</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("databaseNumber")]
                [Validation(Required=false)]
                public int? DatabaseNumber { get; set; }

                /// <summary>
                /// <para>Redis host</para>
                /// 
                /// <b>Example:</b>
                /// <para>redis.example.com</para>
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>Redis password</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>Redis port</para>
                /// 
                /// <b>Example:</b>
                /// <para>6379</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>Redis timeout</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>Redis username</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>List of rate limit rules</para>
            /// </summary>
            [NameInMap("rules")]
            [Validation(Required=false)]
            public List<HttpApiPolicyConfigsAiTokenRateLimitConfigRules> Rules { get; set; }
            public class HttpApiPolicyConfigsAiTokenRateLimitConfigRules : TeaModel {
                /// <summary>
                /// <para>Limit mode</para>
                /// 
                /// <b>Example:</b>
                /// <para>TokenPerSecond</para>
                /// </summary>
                [NameInMap("limitMode")]
                [Validation(Required=false)]
                public string LimitMode { get; set; }

                /// <summary>
                /// <para>Limit type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Header</para>
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
                public string LimitValue { get; set; }

                /// <summary>
                /// <para>Match key</para>
                /// 
                /// <b>Example:</b>
                /// <para>x-api-key</para>
                /// </summary>
                [NameInMap("matchKey")]
                [Validation(Required=false)]
                public string MatchKey { get; set; }

                /// <summary>
                /// <para>Match type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exact</para>
                /// </summary>
                [NameInMap("matchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <para>Match value</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-value</para>
                /// </summary>
                [NameInMap("matchValue")]
                [Validation(Required=false)]
                public string MatchValue { get; set; }

            }

        }

        /// <summary>
        /// <para>AiToolSelectionConfig</para>
        /// </summary>
        [NameInMap("aiToolSelectionConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsAiToolSelectionConfig AiToolSelectionConfig { get; set; }
        public class HttpApiPolicyConfigsAiToolSelectionConfig : TeaModel {
            /// <summary>
            /// <para>Enable conditions configuration</para>
            /// </summary>
            [NameInMap("enableConditions")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiToolSelectionConfigEnableConditions EnableConditions { get; set; }
            public class HttpApiPolicyConfigsAiToolSelectionConfigEnableConditions : TeaModel {
                /// <summary>
                /// <para>Tool count threshold</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("toolCountThreshold")]
                [Validation(Required=false)]
                public int? ToolCountThreshold { get; set; }

            }

            /// <summary>
            /// <para>Plugin status</para>
            /// </summary>
            [NameInMap("pluginStatus")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiToolSelectionConfigPluginStatus PluginStatus { get; set; }
            public class HttpApiPolicyConfigsAiToolSelectionConfigPluginStatus : TeaModel {
                /// <summary>
                /// <para>errorLogs</para>
                /// </summary>
                [NameInMap("errorLogs")]
                [Validation(Required=false)]
                public Dictionary<string, string> ErrorLogs { get; set; }

                /// <summary>
                /// <para>pluginId</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-123456</para>
                /// </summary>
                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// <para>serviceHealthy</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("serviceHealthy")]
                [Validation(Required=false)]
                public bool? ServiceHealthy { get; set; }

            }

            /// <summary>
            /// <para>Query rewriting configuration</para>
            /// </summary>
            [NameInMap("queryRewriting")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiToolSelectionConfigQueryRewriting QueryRewriting { get; set; }
            public class HttpApiPolicyConfigsAiToolSelectionConfigQueryRewriting : TeaModel {
                /// <summary>
                /// <para>Context selection</para>
                /// </summary>
                [NameInMap("contextSelection")]
                [Validation(Required=false)]
                public HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingContextSelection ContextSelection { get; set; }
                public class HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingContextSelection : TeaModel {
                    /// <summary>
                    /// <para>Context type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>recentMessages</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>Value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public int? Value { get; set; }

                }

                /// <summary>
                /// <para>Enable query rewriting</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>Fallback strategy</para>
                /// 
                /// <b>Example:</b>
                /// <para>skip</para>
                /// </summary>
                [NameInMap("fallbackStrategy")]
                [Validation(Required=false)]
                public string FallbackStrategy { get; set; }

                /// <summary>
                /// <para>Max output tokens</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("maxOutputTokens")]
                [Validation(Required=false)]
                public int? MaxOutputTokens { get; set; }

                /// <summary>
                /// <para>Model service configuration</para>
                /// </summary>
                [NameInMap("modelService")]
                [Validation(Required=false)]
                public HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingModelService ModelService { get; set; }
                public class HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingModelService : TeaModel {
                    /// <summary>
                    /// <para>Model name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen-turbo</para>
                    /// </summary>
                    [NameInMap("modelName")]
                    [Validation(Required=false)]
                    public string ModelName { get; set; }

                    /// <summary>
                    /// <para>Service ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>svc-123456</para>
                    /// </summary>
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    /// <summary>
                    /// <para>Timeout in milliseconds</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5000</para>
                    /// </summary>
                    [NameInMap("timeoutMillisecond")]
                    [Validation(Required=false)]
                    public int? TimeoutMillisecond { get; set; }

                }

                /// <summary>
                /// <para>Prompt configuration</para>
                /// </summary>
                [NameInMap("promptConfig")]
                [Validation(Required=false)]
                public HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingPromptConfig PromptConfig { get; set; }
                public class HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingPromptConfig : TeaModel {
                    /// <summary>
                    /// <para>Custom prompt (required when type=custom)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Custom prompt</para>
                    /// </summary>
                    [NameInMap("customPrompt")]
                    [Validation(Required=false)]
                    public string CustomPrompt { get; set; }

                    /// <summary>
                    /// <para>Prompt type: builtIn/custom</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>builtIn</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Trigger conditions</para>
                /// </summary>
                [NameInMap("triggerConditions")]
                [Validation(Required=false)]
                public HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingTriggerConditions TriggerConditions { get; set; }
                public class HttpApiPolicyConfigsAiToolSelectionConfigQueryRewritingTriggerConditions : TeaModel {
                    /// <summary>
                    /// <para>Message count threshold (≥0)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("messageCountThreshold")]
                    [Validation(Required=false)]
                    public int? MessageCountThreshold { get; set; }

                }

            }

            /// <summary>
            /// <para>Tool reranking configuration</para>
            /// </summary>
            [NameInMap("toolReranking")]
            [Validation(Required=false)]
            public HttpApiPolicyConfigsAiToolSelectionConfigToolReranking ToolReranking { get; set; }
            public class HttpApiPolicyConfigsAiToolSelectionConfigToolReranking : TeaModel {
                /// <summary>
                /// <para>Fallback strategy: skip/error</para>
                /// 
                /// <b>Example:</b>
                /// <para>skip</para>
                /// </summary>
                [NameInMap("fallbackStrategy")]
                [Validation(Required=false)]
                public string FallbackStrategy { get; set; }

                /// <summary>
                /// <para>Filtering method: topK/topN/combined</para>
                /// 
                /// <b>Example:</b>
                /// <para>topK</para>
                /// </summary>
                [NameInMap("filteringMethod")]
                [Validation(Required=false)]
                public string FilteringMethod { get; set; }

                /// <summary>
                /// <para>Model service configuration</para>
                /// </summary>
                [NameInMap("modelService")]
                [Validation(Required=false)]
                public HttpApiPolicyConfigsAiToolSelectionConfigToolRerankingModelService ModelService { get; set; }
                public class HttpApiPolicyConfigsAiToolSelectionConfigToolRerankingModelService : TeaModel {
                    /// <summary>
                    /// <para>Model name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gte-rerank-v2</para>
                    /// </summary>
                    [NameInMap("modelName")]
                    [Validation(Required=false)]
                    public string ModelName { get; set; }

                    /// <summary>
                    /// <para>Service ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>svc-123456</para>
                    /// </summary>
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    /// <summary>
                    /// <para>Timeout in milliseconds</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5000</para>
                    /// </summary>
                    [NameInMap("timeoutMillisecond")]
                    [Validation(Required=false)]
                    public int? TimeoutMillisecond { get; set; }

                }

                /// <summary>
                /// <para>Score threshold (0.0-1.0, 0 means disabled)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("scoreThreshold")]
                [Validation(Required=false)]
                public float? ScoreThreshold { get; set; }

                /// <summary>
                /// <para>TopK percentage (1-100)</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("topKPercent")]
                [Validation(Required=false)]
                public int? TopKPercent { get; set; }

                /// <summary>
                /// <para>TopN count</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("topNCount")]
                [Validation(Required=false)]
                public int? TopNCount { get; set; }

            }

        }

        /// <summary>
        /// <para>Policy Enable</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>SemanticRouterConfig</para>
        /// </summary>
        [NameInMap("semanticRouterConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsSemanticRouterConfig SemanticRouterConfig { get; set; }
        public class HttpApiPolicyConfigsSemanticRouterConfig : TeaModel {
            /// <summary>
            /// <para>Timeout in milliseconds</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("timeoutMillisecond")]
            [Validation(Required=false)]
            public int? TimeoutMillisecond { get; set; }

        }

        /// <summary>
        /// <para>Policy Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>AiCache</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
