// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListAiModelSourceModelsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListAiModelSourceModelsResponseBodyData Data { get; set; }
        public class ListAiModelSourceModelsResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListAiModelSourceModelsResponseBodyDataItems> Items { get; set; }
            public class ListAiModelSourceModelsResponseBodyDataItems : TeaModel {
                [NameInMap("availablePaths")]
                [Validation(Required=false)]
                public List<ListAiModelSourceModelsResponseBodyDataItemsAvailablePaths> AvailablePaths { get; set; }
                public class ListAiModelSourceModelsResponseBodyDataItemsAvailablePaths : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/v1/chat/completions</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OpenAI/v1</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("credit")]
                [Validation(Required=false)]
                public ListAiModelSourceModelsResponseBodyDataItemsCredit Credit { get; set; }
                public class ListAiModelSourceModelsResponseBodyDataItemsCredit : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.1</para>
                    /// </summary>
                    [NameInMap("cacheCost")]
                    [Validation(Required=false)]
                    public float? CacheCost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("inputCost")]
                    [Validation(Required=false)]
                    public float? InputCost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("outputCost")]
                    [Validation(Required=false)]
                    public float? OutputCost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>fixed</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;nativeStreaming&quot;:true}</para>
                /// </summary>
                [NameInMap("features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-d00000000000000000000</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("meta")]
                [Validation(Required=false)]
                public ListAiModelSourceModelsResponseBodyDataItemsMeta Meta { get; set; }
                public class ListAiModelSourceModelsResponseBodyDataItemsMeta : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>32768</para>
                    /// </summary>
                    [NameInMap("maxInputTokens")]
                    [Validation(Required=false)]
                    public long? MaxInputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8192</para>
                    /// </summary>
                    [NameInMap("maxOutputTokens")]
                    [Validation(Required=false)]
                    public long? MaxOutputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>40960</para>
                    /// </summary>
                    [NameInMap("maxTokens")]
                    [Validation(Required=false)]
                    public long? MaxTokens { get; set; }

                    [NameInMap("supportedInputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedInputModalities { get; set; }

                    [NameInMap("supportedOutputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedOutputModalities { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>msc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen</para>
                /// </summary>
                [NameInMap("modelProvider")]
                [Validation(Required=false)]
                public string ModelProvider { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ms-d00000000000000000000</para>
                /// </summary>
                [NameInMap("modelSourceId")]
                [Validation(Required=false)]
                public string ModelSourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>百炼模型源</para>
                /// </summary>
                [NameInMap("modelSourceName")]
                [Validation(Required=false)]
                public string ModelSourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("modelSourceVersion")]
                [Validation(Required=false)]
                public long? ModelSourceVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Ready</para>
                /// </summary>
                [NameInMap("pricingStatus")]
                [Validation(Required=false)]
                public string PricingStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>svc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-11-12T00:00:00Z</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eyJvZmZzZXQiOjIwfQ==</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
