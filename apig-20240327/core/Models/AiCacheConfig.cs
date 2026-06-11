// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiCacheConfig : TeaModel {
        /// <summary>
        /// <para>The cache key strategy, which determines how the system generates a unique key for each cacheable request. Valid values: <c>DEFAULT</c> and <c>CUSTOM</c>.</para>
        /// </summary>
        [NameInMap("cacheKeyStrategy")]
        [Validation(Required=false)]
        public string CacheKeyStrategy { get; set; }

        /// <summary>
        /// <para>The cache mode, which defines the caching behavior. Valid values are <c>NORMAL</c> for standard key-value caching and <c>SEMANTIC</c> for vector-based similarity caching.</para>
        /// </summary>
        [NameInMap("cacheMode")]
        [Validation(Required=false)]
        public string CacheMode { get; set; }

        /// <summary>
        /// <para>The cache Time-to-Live (TTL) in seconds. This specifies the duration that a cached response remains valid. After the TTL expires, the cache removes the response.</para>
        /// </summary>
        [NameInMap("cacheTTL")]
        [Validation(Required=false)]
        public int? CacheTTL { get; set; }

        /// <summary>
        /// <para>The embedding configuration. Specifies the service that converts text queries into vector embeddings for semantic search.</para>
        /// </summary>
        [NameInMap("embeddingConfig")]
        [Validation(Required=false)]
        public AiCacheConfigEmbeddingConfig EmbeddingConfig { get; set; }
        public class AiCacheConfigEmbeddingConfig : TeaModel {
            /// <summary>
            /// <para>The model name to use for generating embeddings, such as <c>text-embedding-v1</c>.</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The service ID of the deployed embedding model.</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The request timeout in milliseconds. A request to the embedding service fails if it exceeds this duration. Default: <c>10000</c>.</para>
            /// </summary>
            [NameInMap("timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The type of embedding service. For example, specify <c>Tongyi</c> for Alibaba Cloud\&quot;s Tongyi Qwen model series.</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The plugin status. Set to <c>enable</c> to activate the plugin or <c>disable</c> to deactivate it.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <para>The Redis configuration, required if you use a Redis instance as the cache backend.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("redisConfig")]
        [Validation(Required=false)]
        public AiPolicyRedisConfig RedisConfig { get; set; }

        /// <summary>
        /// <para>The vector configuration for semantic caching. This enables the cache to retrieve results based on semantic similarity instead of exact matches.</para>
        /// </summary>
        [NameInMap("vectorConfig")]
        [Validation(Required=false)]
        public AiCacheConfigVectorConfig VectorConfig { get; set; }
        public class AiCacheConfigVectorConfig : TeaModel {
            /// <summary>
            /// <para>The API key to authenticate with the vector database service.</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The unique ID of the collection or index within the vector database for search and storage.</para>
            /// </summary>
            [NameInMap("collectionId")]
            [Validation(Required=false)]
            public string CollectionId { get; set; }

            /// <summary>
            /// <para>The endpoint URL of the vector database service.</para>
            /// </summary>
            [NameInMap("serviceHost")]
            [Validation(Required=false)]
            public string ServiceHost { get; set; }

            /// <summary>
            /// <para>The similarity threshold for a vector search to qualify as a cache hit. The value must be between 0.0 and 1.0. A higher value means a stricter similarity requirement.</para>
            /// </summary>
            [NameInMap("threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

            /// <summary>
            /// <para>The request timeout in milliseconds. A request to the vector service fails if it exceeds this duration. Default: <c>10000</c>.</para>
            /// </summary>
            [NameInMap("timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The type of vector database service. For example, specify <c>DashVector</c> for Alibaba Cloud\&quot;s vector search service.</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
