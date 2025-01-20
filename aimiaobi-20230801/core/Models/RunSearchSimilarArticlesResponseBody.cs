// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunSearchSimilarArticlesResponseBody : TeaModel {
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunSearchSimilarArticlesResponseBodyHeader Header { get; set; }
        public class RunSearchSimilarArticlesResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>错误码</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-started</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunSearchSimilarArticlesResponseBodyPayload Payload { get; set; }
        public class RunSearchSimilarArticlesResponseBodyPayload : TeaModel {
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunSearchSimilarArticlesResponseBodyPayloadOutput Output { get; set; }
            public class RunSearchSimilarArticlesResponseBodyPayloadOutput : TeaModel {
                [NameInMap("Articles")]
                [Validation(Required=false)]
                public List<RunSearchSimilarArticlesResponseBodyPayloadOutputArticles> Articles { get; set; }
                public class RunSearchSimilarArticlesResponseBodyPayloadOutputArticles : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>a26c2c1</para>
                    /// </summary>
                    [NameInMap("DocUuid")]
                    [Validation(Required=false)]
                    public string DocUuid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-01-16 18:07:22</para>
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    [NameInMap("SearchSourceName")]
                    [Validation(Required=false)]
                    public string SearchSourceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx.com</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://xxx">https://xxx</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文本生成结果</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunSearchSimilarArticlesResponseBodyPayloadUsage Usage { get; set; }
            public class RunSearchSimilarArticlesResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>81</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
