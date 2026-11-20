// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BillingDetailRowDTO : TeaModel {
        /// <summary>
        /// <para>The actual amount paid after discounts, rounded to eight decimal places.</para>
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
        /// <para>The name of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default key</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The number of cache creation tokens for explicit cache writes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("cacheCreationTokens")]
        [Validation(Required=false)]
        public double? CacheCreationTokens { get; set; }

        /// <summary>
        /// <para>The number of cache hit tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("cachedTokens")]
        [Validation(Required=false)]
        public double? CachedTokens { get; set; }

        /// <summary>
        /// <para>The department ID. A value of 0 indicates that the request does not belong to any department.</para>
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
        /// <para>The discount factor. A value of 1.0 indicates no discount.</para>
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
        /// <para>The user ID of the member. For department rows, the value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001</para>
        /// </summary>
        [NameInMap("memberUserId")]
        [Validation(Required=false)]
        public long? MemberUserId { get; set; }

        /// <summary>
        /// <para>The name of the member. For department rows, the value is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John Doe</para>
        /// </summary>
        [NameInMap("memberUserName")]
        [Validation(Required=false)]
        public string MemberUserName { get; set; }

        /// <summary>
        /// <para>The JSON containing other metering field mappings, such as video duration and number of images. Fields with a value of 0 are not returned.</para>
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
        /// <para>The model symbol, which is the vendor identifier.</para>
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
        /// <para>The unique identifier of the request.</para>
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
        /// <para>The raw JSON of usage details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;input_tokens&quot;: 1024, &quot;output_tokens&quot;: 512}</para>
        /// </summary>
        [NameInMap("usageDetail")]
        [Validation(Required=false)]
        public string UsageDetail { get; set; }

    }

}
