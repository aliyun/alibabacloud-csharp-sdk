// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BillingDetailRowDTO : TeaModel {
        /// <summary>
        /// <para>The actual payment amount (after discount), rounded to 8 decimal places.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.00012800</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// <para>API Key ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("apiKeyId")]
        [Validation(Required=false)]
        public long? ApiKeyId { get; set; }

        /// <summary>
        /// <para>The API key name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default Key</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The number of cache creation tokens (explicit cache writes).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("cacheCreationTokens")]
        [Validation(Required=false)]
        public double? CacheCreationTokens { get; set; }

        /// <summary>
        /// <para>The number of tokens that hit the cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("cachedTokens")]
        [Validation(Required=false)]
        public double? CachedTokens { get; set; }

        /// <summary>
        /// <para>The department ID. A value of 0 indicates that no department is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <para>The department name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D Department</para>
        /// </summary>
        [NameInMap("clientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// <para>The discount coefficient. A value of 1.0 indicates no discount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("discount")]
        [Validation(Required=false)]
        public double? Discount { get; set; }

        /// <summary>
        /// <para>The number of input tokens, including cached tokens and cache creation tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("inputTokens")]
        [Validation(Required=false)]
        public double? InputTokens { get; set; }

        /// <summary>
        /// <para>The member user ID for a member row. The value is 0 for a department row.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001</para>
        /// </summary>
        [NameInMap("memberUserId")]
        [Validation(Required=false)]
        public long? MemberUserId { get; set; }

        /// <summary>
        /// <para>The member name for a member row. The value is empty for a department row.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John</para>
        /// </summary>
        [NameInMap("memberUserName")]
        [Validation(Required=false)]
        public string MemberUserName { get; set; }

        /// <summary>
        /// <para>The JSON of other metering field mapping, such as video duration and image count. Fields with a value of 0 are not included in the output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <para>The model identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <para>The model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen-Plus</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model symbol (provider identifier).</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("modelSymbol")]
        [Validation(Required=false)]
        public string ModelSymbol { get; set; }

        /// <summary>
        /// <para>The model type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chat</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The model version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("modelVersion")]
        [Validation(Required=false)]
        public int? ModelVersion { get; set; }

        /// <summary>
        /// <para>The number of output tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("outputTokens")]
        [Validation(Required=false)]
        public double? OutputTokens { get; set; }

        /// <summary>
        /// <para>The number of reasoning tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("reasoningTokens")]
        [Validation(Required=false)]
        public double? ReasoningTokens { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatcmpl-abc123def456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request time as a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("requestTime")]
        [Validation(Required=false)]
        public long? RequestTime { get; set; }

        /// <summary>
        /// <para>The total number of tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1536</para>
        /// </summary>
        [NameInMap("totalTokens")]
        [Validation(Required=false)]
        public double? TotalTokens { get; set; }

        /// <summary>
        /// <para>The raw JSON of the usage details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;input_tokens&quot;: 1024, &quot;output_tokens&quot;: 512}</para>
        /// </summary>
        [NameInMap("usageDetail")]
        [Validation(Required=false)]
        public string UsageDetail { get; set; }

    }

}
