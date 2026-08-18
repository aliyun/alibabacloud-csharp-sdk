// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BillingDetailRowDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0.00012800</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("apiKeyId")]
        [Validation(Required=false)]
        public long? ApiKeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>默认密钥</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("cacheCreationTokens")]
        [Validation(Required=false)]
        public double? CacheCreationTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("cachedTokens")]
        [Validation(Required=false)]
        public double? CachedTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>研发部</para>
        /// </summary>
        [NameInMap("clientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("discount")]
        [Validation(Required=false)]
        public double? Discount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("inputTokens")]
        [Validation(Required=false)]
        public double? InputTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30001</para>
        /// </summary>
        [NameInMap("memberUserId")]
        [Validation(Required=false)]
        public long? MemberUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("memberUserName")]
        [Validation(Required=false)]
        public string MemberUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>通义千问-Plus</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("modelSymbol")]
        [Validation(Required=false)]
        public string ModelSymbol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Chat</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("modelVersion")]
        [Validation(Required=false)]
        public int? ModelVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("outputTokens")]
        [Validation(Required=false)]
        public double? OutputTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("reasoningTokens")]
        [Validation(Required=false)]
        public double? ReasoningTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chatcmpl-abc123def456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("requestTime")]
        [Validation(Required=false)]
        public long? RequestTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1536</para>
        /// </summary>
        [NameInMap("totalTokens")]
        [Validation(Required=false)]
        public double? TotalTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;input_tokens&quot;: 1024, &quot;output_tokens&quot;: 512}</para>
        /// </summary>
        [NameInMap("usageDetail")]
        [Validation(Required=false)]
        public string UsageDetail { get; set; }

    }

}
