// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiCacheConfig : TeaModel {
        /// <summary>
        /// <para>The cache key generation strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("cacheKeyStrategy")]
        [Validation(Required=false)]
        public string CacheKeyStrategy { get; set; }

        /// <summary>
        /// <para>The cache mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exact</para>
        /// </summary>
        [NameInMap("cacheMode")]
        [Validation(Required=false)]
        public string CacheMode { get; set; }

        /// <summary>
        /// <para>The cache expiration time, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("cacheTTL")]
        [Validation(Required=false)]
        public int? CacheTTL { get; set; }

        /// <summary>
        /// <para>The embedding service configuration.</para>
        /// </summary>
        [NameInMap("embeddingConfig")]
        [Validation(Required=false)]
        public AiCacheConfigEmbeddingConfig EmbeddingConfig { get; set; }
        public class AiCacheConfigEmbeddingConfig : TeaModel {
            /// <summary>
            /// <para>The embedding model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-embedding-v2</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The embedding service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>svc-xxx</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The request timeout period, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The embedding service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dashscope</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The plugin running status.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <para>The Redis configuration for exact cache count storage.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("redisConfig")]
        [Validation(Required=false)]
        public AiPolicyRedisConfig RedisConfig { get; set; }

        /// <summary>
        /// <para>The vector database configuration.</para>
        /// </summary>
        [NameInMap("vectorConfig")]
        [Validation(Required=false)]
        public AiCacheConfigVectorConfig VectorConfig { get; set; }
        public class AiCacheConfigVectorConfig : TeaModel {
            /// <summary>
            /// <para>The API key of the vector database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-xxx</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The vector collection ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col-xxx</para>
            /// </summary>
            [NameInMap("collectionId")]
            [Validation(Required=false)]
            public string CollectionId { get; set; }

            /// <summary>
            /// <para>The service address of the vector database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vdb-xxx.dashvector.aliyuncs.com</para>
            /// </summary>
            [NameInMap("serviceHost")]
            [Validation(Required=false)]
            public string ServiceHost { get; set; }

            /// <summary>
            /// <para>The similarity threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.95</para>
            /// </summary>
            [NameInMap("threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

            /// <summary>
            /// <para>The request timeout period, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The vector database type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dashvector</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
