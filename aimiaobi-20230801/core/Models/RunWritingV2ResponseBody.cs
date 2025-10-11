// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunWritingV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunWritingV2ResponseBodyHeader Header { get; set; }
        public class RunWritingV2ResponseBodyHeader : TeaModel {
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
            [NameInMap("OriginSessionId")]
            [Validation(Required=false)]
            public string OriginSessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>全链路ID</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunWritingV2ResponseBodyPayload Payload { get; set; }
        public class RunWritingV2ResponseBodyPayload : TeaModel {
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunWritingV2ResponseBodyPayloadOutput Output { get; set; }
            public class RunWritingV2ResponseBodyPayloadOutput : TeaModel {
                [NameInMap("Articles")]
                [Validation(Required=false)]
                public List<RunWritingV2ResponseBodyPayloadOutputArticles> Articles { get; set; }
                public class RunWritingV2ResponseBodyPayloadOutputArticles : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>作者</para>
                    /// </summary>
                    [NameInMap("Author")]
                    [Validation(Required=false)]
                    public string Author { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>文章内容</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>文档-自定义的唯一ID</para>
                    /// </summary>
                    [NameInMap("DocId")]
                    [Validation(Required=false)]
                    public string DocId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>98229f6001cf4deeb1668191d4eccc75</para>
                    /// </summary>
                    [NameInMap("DocUuid")]
                    [Validation(Required=false)]
                    public string DocUuid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-08-28 11:38:28</para>
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>央视网</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>文章摘要</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>文章标签</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>文章标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://www.example.com/aaa.docx">https://www.example.com/aaa.docx</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("GenerateTraceability")]
                [Validation(Required=false)]
                public GenerateTraceability GenerateTraceability { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文章精排之后的片段</para>
                /// </summary>
                [NameInMap("MiniDoc")]
                [Validation(Required=false)]
                public List<string> MiniDoc { get; set; }

                [NameInMap("Outlines")]
                [Validation(Required=false)]
                public List<WritingOutline> Outlines { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>大模型改变世界</para>
                /// </summary>
                [NameInMap("SearchQuery")]
                [Validation(Required=false)]
                public string SearchQuery { get; set; }

                [NameInMap("SearchResult")]
                [Validation(Required=false)]
                public OutlineSearchResult SearchResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文本生成结果</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunWritingV2ResponseBodyPayloadUsage Usage { get; set; }
            public class RunWritingV2ResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>78</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                [NameInMap("TokenMap")]
                [Validation(Required=false)]
                public Dictionary<string, long?> TokenMap { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>38</para>
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
