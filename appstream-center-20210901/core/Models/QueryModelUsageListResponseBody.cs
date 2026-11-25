// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryModelUsageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The model usage details on the current page. If no models match or the page number exceeds the result range, an empty list is returned. For 24h or 1d queries without specified start and end dates, an empty list is also returned when no statistical results are available. For other windows or custom date ranges, no valid list data is provided when no statistical results are available. The absence of statistical results does not directly indicate that no actual calls were made.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;LlmCode&quot;:&quot;qwen3-max-2026-01-23&quot;,&quot;ModelName&quot;:&quot;Qwen3 Max&quot;,&quot;CallCount&quot;:12480,&quot;FailureCount&quot;:180,&quot;PointsConsumption&quot;:100,&quot;InputPointsRate&quot;:0.739,&quot;OutputPointsRate&quot;:0.261,&quot;SuccessRate&quot;:0.98557692,&quot;AvgTtftMs&quot;:620,&quot;CacheHitRate&quot;:0.86}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryModelUsageListResponseBodyData> Data { get; set; }
        public class QueryModelUsageListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The average time to first token (TTFT) latency, which is the total duration of valid TTFT samples divided by the number of samples, in milliseconds, rounded to the nearest integer. This field is empty when no valid samples are available. It does not represent the total time taken for a complete response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>620</para>
            /// </summary>
            [NameInMap("AvgTtftMs")]
            [Validation(Required=false)]
            public long? AvgTtftMs { get; set; }

            /// <summary>
            /// <para>The proportion of cached input usage to the total input usage, expressed as a decimal between 0 and 1. For example, 0.86 indicates 86%. It is not the proportion of requests that hit the cache. This field is empty when the base usage is incomplete or the total input usage is 0. The return value is rounded to a maximum of 8 decimal places.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.86</para>
            /// </summary>
            [NameInMap("CacheHitRate")]
            [Validation(Required=false)]
            public double? CacheHitRate { get; set; }

            /// <summary>
            /// <para>The total number of model calls within the query range, including both successful and failed calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12480</para>
            /// </summary>
            [NameInMap("CallCount")]
            [Validation(Required=false)]
            public long? CallCount { get; set; }

            /// <summary>
            /// <para>The maximum context length of the model, in tokens. This field is empty when no model information is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("ContextWindow")]
            [Validation(Required=false)]
            public long? ContextWindow { get; set; }

            /// <summary>
            /// <para>The display range of the credit consumption multiplier, in multiples. It is used to display price hints and is not used to recalculate the PointsConsumption returned by this API operation.</para>
            /// <list type="bullet">
            /// <item><description>If Min and Max are equal: fixed multiplier.</description></item>
            /// <item><description>If Max is greater than Min: multiplier range.</description></item>
            /// <item><description>If Max is empty: starts from the Min multiplier.</description></item>
            /// <item><description>If the entire object is empty: the model does not participate in credit billing, or no multiplier information is available. An empty value for this field alone cannot determine whether actual charges apply.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Min&quot;:1,&quot;Max&quot;:3}</para>
            /// </summary>
            [NameInMap("CreditMultiplier")]
            [Validation(Required=false)]
            public QueryModelUsageListResponseBodyDataCreditMultiplier CreditMultiplier { get; set; }
            public class QueryModelUsageListResponseBodyDataCreditMultiplier : TeaModel {
                /// <summary>
                /// <para>The upper limit of the credit multiplier, in multiples. If it is empty, it indicates that the multiplier starts from Min and no maximum multiplier is specified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public float? Max { get; set; }

                /// <summary>
                /// <para>The lower limit of the credit multiplier, in multiples. If it is equal to Max, it indicates a fixed multiplier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public float? Min { get; set; }

            }

            /// <summary>
            /// <para>The description of the model. The display language is affected by Language. This field is empty when no description is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen large language model</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The proportion of explicit cache creation credits to the total credits. This field is empty when it cannot be calculated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.115</para>
            /// </summary>
            [NameInMap("ExplicitCacheCreationPointsRate")]
            [Validation(Required=false)]
            public double? ExplicitCacheCreationPointsRate { get; set; }

            /// <summary>
            /// <para>The proportion of explicit cache hit credits to the total credits. This field is empty when it cannot be calculated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.043</para>
            /// </summary>
            [NameInMap("ExplicitCacheHitPointsRate")]
            [Validation(Required=false)]
            public double? ExplicitCacheHitPointsRate { get; set; }

            /// <summary>
            /// <para>The number of failed calls within the query range, including failed calls that are throttled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("FailureCount")]
            [Validation(Required=false)]
            public long? FailureCount { get; set; }

            /// <summary>
            /// <para>The list of model capability tags. The display language is affected by Language. Capabilities without a configured display name retain their original codes. An empty list is returned when no capability information is available. Tags are extensible, not a fixed enumeration, and do not imply that all capabilities can be called through this API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;Text generation&quot;,&quot;Tool calling&quot;]</para>
            /// </summary>
            [NameInMap("FeatureList")]
            [Validation(Required=false)]
            public List<string> FeatureList { get; set; }

            /// <summary>
            /// <para>The URL of the model brand icon. This field is empty when no brand icon is available. The example URL only illustrates the URL format and is not a fixed download address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/qwen.png">https://example.com/qwen.png</a></para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <para>The proportion of implicit cache hit credits to the total credits. This field is empty when it cannot be calculated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.171</para>
            /// </summary>
            [NameInMap("ImplicitCacheHitPointsRate")]
            [Validation(Required=false)]
            public double? ImplicitCacheHitPointsRate { get; set; }

            /// <summary>
            /// <para>The proportion of input credits to the total consumed credits, expressed as a decimal between 0 and 1. For example, 0.739 indicates 73.9%. This field is provided only when the input and output credit details are complete, the values are valid, and the total credits are greater than 0. Otherwise, it is empty.</para>
            /// <para>The proportion is rounded to a maximum of 8 decimal places. The sum of input and output credits may be less than the total credits. Additionally, adding this value to OutputPointsRate may result in minor rounding errors. Do not calculate other credits or verify bills based solely on the sum of the proportions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.739</para>
            /// </summary>
            [NameInMap("InputPointsRate")]
            [Validation(Required=false)]
            public double? InputPointsRate { get; set; }

            /// <summary>
            /// <para>The new model tag. The current version does not provide this tag. Ignore this field and do not use it to determine whether a model is newly released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("IsNew")]
            [Validation(Required=false)]
            public bool? IsNew { get; set; }

            /// <summary>
            /// <para>The identifier or code of the model, used to identify the model and associate usage and model information. The return value is an open string and should not be hardcoded as an enumeration on the client side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-max-2026-01-23</para>
            /// </summary>
            [NameInMap("LlmCode")]
            [Validation(Required=false)]
            public string LlmCode { get; set; }

            /// <summary>
            /// <para>The maximum output length for a single generation of the model, in tokens. This field is empty when no model information is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65536</para>
            /// </summary>
            [NameInMap("MaxOutput")]
            [Validation(Required=false)]
            public long? MaxOutput { get; set; }

            /// <summary>
            /// <para>The display name of the model brand. The display language is affected by Language. This field is empty when no brand information is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen</para>
            /// </summary>
            [NameInMap("ModelBrandName")]
            [Validation(Required=false)]
            public string ModelBrandName { get; set; }

            /// <summary>
            /// <para>The display name of the model. The display language is affected by Language. If no name is available, LlmCode is returned. The name may change, so the model code should be used when associating data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen3 Max</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The proportion of normal input credits to the total credits. This field is empty when it cannot be calculated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.329</para>
            /// </summary>
            [NameInMap("NormalInputPointsRate")]
            [Validation(Required=false)]
            public double? NormalInputPointsRate { get; set; }

            /// <summary>
            /// <para>The proportion of output credits to the total consumed credits, expressed as a decimal between 0 and 1. For example, 0.261 indicates 26.1%. This field is provided only when the input and output credit details are complete, the values are valid, and the total credits are greater than 0. Otherwise, it is empty. The proportion is rounded to a maximum of 8 decimal places, and adding this value to InputPointsRate may result in minor rounding errors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.261</para>
            /// </summary>
            [NameInMap("OutputPointsRate")]
            [Validation(Required=false)]
            public double? OutputPointsRate { get; set; }

            /// <summary>
            /// <para>The actual credits consumed within the query range. The return value can be displayed directly without further conversion. CreditMultiplier is only used to display the multiplier and should not be multiplied by this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PointsConsumption")]
            [Validation(Required=false)]
            public double? PointsConsumption { get; set; }

            /// <summary>
            /// <para>The number of successful calls divided by the total number of calls, expressed as a decimal between 0 and 1, not a percentage. This field is empty when the number of calls is 0. Multiply this value by 100 to display it as a percentage. The return value is rounded to a maximum of 8 decimal places.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.98557692</para>
            /// </summary>
            [NameInMap("SuccessRate")]
            [Validation(Required=false)]
            public double? SuccessRate { get; set; }

            /// <summary>
            /// <para>The proportion of tool calling credits to the total credits. This field is empty when it cannot be calculated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ToolCallPointsRate")]
            [Validation(Required=false)]
            public double? ToolCallPointsRate { get; set; }

            /// <summary>
            /// <para>The 95th percentile value of the time to first token (TTFT) latency, in milliseconds. This field is provided only when corresponding data exists within a fixed statistical window. <b>It is empty when custom start and end dates are passed, even if the start and end dates are the same.</b> The value 700 in the field table is an example under a fixed statistical window and does not apply to custom date ranges.</para>
            /// 
            /// <b>Example:</b>
            /// <para>700</para>
            /// </summary>
            [NameInMap("TtftP95Ms")]
            [Validation(Required=false)]
            public long? TtftP95Ms { get; set; }

        }

        /// <summary>
        /// <para>The page number for this query, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size used for this query. The actual number of returned entries may be less than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier for this request, used to locate and troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of models used for pagination. When statistical results are available, this field returns the number of models that meet the model type and keyword conditions. This may include models with 0 calls within the selected date range, so it is not necessarily equal to ActiveModelCount.</para>
        /// <para><b>When no statistical results are available within the query range, this value returns 0. You cannot determine that the business has no models or no actual calls based solely on TotalCount=0.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
