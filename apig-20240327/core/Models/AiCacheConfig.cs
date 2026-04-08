// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiCacheConfig : TeaModel {
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
        public AiCacheConfigEmbeddingConfig EmbeddingConfig { get; set; }
        public class AiCacheConfigEmbeddingConfig : TeaModel {
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

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("redisConfig")]
        [Validation(Required=false)]
        public AiPolicyRedisConfig RedisConfig { get; set; }

        [NameInMap("vectorConfig")]
        [Validation(Required=false)]
        public AiCacheConfigVectorConfig VectorConfig { get; set; }
        public class AiCacheConfigVectorConfig : TeaModel {
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

}
