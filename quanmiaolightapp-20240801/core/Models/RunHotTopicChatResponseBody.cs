// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunHotTopicChatResponseBody : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public RunHotTopicChatResponseBodyHeader Header { get; set; }
        public class RunHotTopicChatResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>InvalidParam</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-finished</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("eventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d3be9981-ca2d-4e17-bf31-1c0a628e9f99</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2150451a17191950923411783e2927</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public RunHotTopicChatResponseBodyPayload Payload { get; set; }
        public class RunHotTopicChatResponseBodyPayload : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public RunHotTopicChatResponseBodyPayloadOutput Output { get; set; }
            public class RunHotTopicChatResponseBodyPayloadOutput : TeaModel {
                [NameInMap("articles")]
                [Validation(Required=false)]
                public List<RunHotTopicChatResponseBodyPayloadOutputArticles> Articles { get; set; }
                public class RunHotTopicChatResponseBodyPayloadOutputArticles : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-09-22 16:45:06</para>
                    /// </summary>
                    [NameInMap("pubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    [NameInMap("score")]
                    [Validation(Required=false)]
                    public double? Score { get; set; }

                    [NameInMap("searchSourceName")]
                    [Validation(Required=false)]
                    public string SearchSourceName { get; set; }

                    [NameInMap("select")]
                    [Validation(Required=false)]
                    public bool? Select { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://xxx">http://xxx</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("hotTopicSummaries")]
                [Validation(Required=false)]
                public List<RunHotTopicChatResponseBodyPayloadOutputHotTopicSummaries> HotTopicSummaries { get; set; }
                public class RunHotTopicChatResponseBodyPayloadOutputHotTopicSummaries : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("customHotValue")]
                    [Validation(Required=false)]
                    public double? CustomHotValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("customTextSummary")]
                    [Validation(Required=false)]
                    public string CustomTextSummary { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("hotTopic")]
                    [Validation(Required=false)]
                    public string HotTopic { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-09-13_08</para>
                    /// </summary>
                    [NameInMap("hotTopicVersion")]
                    [Validation(Required=false)]
                    public string HotTopicVersion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("hotValue")]
                    [Validation(Required=false)]
                    public double? HotValue { get; set; }

                    [NameInMap("images")]
                    [Validation(Required=false)]
                    public List<RunHotTopicChatResponseBodyPayloadOutputHotTopicSummariesImages> Images { get; set; }
                    public class RunHotTopicChatResponseBodyPayloadOutputHotTopicSummariesImages : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="http://xxx">http://xxx</a></para>
                        /// </summary>
                        [NameInMap("url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    [NameInMap("news")]
                    [Validation(Required=false)]
                    public List<RunHotTopicChatResponseBodyPayloadOutputHotTopicSummariesNews> News { get; set; }
                    public class RunHotTopicChatResponseBodyPayloadOutputHotTopicSummariesNews : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="http://xxx">http://xxx</a></para>
                        /// </summary>
                        [NameInMap("url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("textSummary")]
                    [Validation(Required=false)]
                    public string TextSummary { get; set; }

                }

                [NameInMap("multimodalMedias")]
                [Validation(Required=false)]
                public List<RunHotTopicChatResponseBodyPayloadOutputMultimodalMedias> MultimodalMedias { get; set; }
                public class RunHotTopicChatResponseBodyPayloadOutputMultimodalMedias : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://xxxx">http://xxxx</a></para>
                    /// </summary>
                    [NameInMap("fileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>image</para>
                    /// </summary>
                    [NameInMap("mediaType")]
                    [Validation(Required=false)]
                    public string MediaType { get; set; }

                    [NameInMap("sortScore")]
                    [Validation(Required=false)]
                    public double? SortScore { get; set; }

                }

                [NameInMap("recommendQueries")]
                [Validation(Required=false)]
                public List<string> RecommendQueries { get; set; }

                [NameInMap("searchQuery")]
                [Validation(Required=false)]
                public string SearchQuery { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public RunHotTopicChatResponseBodyPayloadUsage Usage { get; set; }
            public class RunHotTopicChatResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>04DA1A52-4E51-56CB-BA64-FDDA0B53BAE8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
