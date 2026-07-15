// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListAiModelCardsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListAiModelCardsResponseBodyData Data { get; set; }
        public class ListAiModelCardsResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListAiModelCardsResponseBodyDataItems> Items { get; set; }
            public class ListAiModelCardsResponseBodyDataItems : TeaModel {
                [NameInMap("availablePaths")]
                [Validation(Required=false)]
                public List<ListAiModelCardsResponseBodyDataItemsAvailablePaths> AvailablePaths { get; set; }
                public class ListAiModelCardsResponseBodyDataItemsAvailablePaths : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/v1/chat/completions</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OpenAICompatible</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("credit")]
                [Validation(Required=false)]
                public ListAiModelCardsResponseBodyDataItemsCredit Credit { get; set; }
                public class ListAiModelCardsResponseBodyDataItemsCredit : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("cacheCost")]
                    [Validation(Required=false)]
                    public float? CacheCost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("inputCost")]
                    [Validation(Required=false)]
                    public float? InputCost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
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
                /// <para>{&quot;functionCalling&quot;:true,&quot;toolChoice&quot;:true}</para>
                /// </summary>
                [NameInMap("features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-8c13d2b4f8a1</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("meta")]
                [Validation(Required=false)]
                public ListAiModelCardsResponseBodyDataItemsMeta Meta { get; set; }
                public class ListAiModelCardsResponseBodyDataItemsMeta : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>131072</para>
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
                    /// <para>131072</para>
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
                /// <para>mc-8c13d2b4f8a1</para>
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
                /// <para>user</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://https://dashscope-intl.aliyuncs.com">http://https://dashscope-intl.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("sourceURL")]
                [Validation(Required=false)]
                public string SourceURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-07-14 18:30:00</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

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
