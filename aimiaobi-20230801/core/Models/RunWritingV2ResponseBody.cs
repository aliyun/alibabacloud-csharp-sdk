// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunWritingV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether this is the final message in the response stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        /// <summary>
        /// <para>The response header.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunWritingV2ResponseBodyHeader Header { get; set; }
        public class RunWritingV2ResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误码</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The type of event. The service returns two types of events: writing events and other events.</para>
            /// <para>The writing event, <c>task-progress-start-generating</c>, indicates that the output contains the complete article information.</para>
            /// <para>Other events, such as <c>writing-instruction-analysis</c> (instruction analysis), <c>task-progress-news-search-end</c> (web search), and <c>result-intent-recognition-end</c> (intent recognition), can be monitored through the <c>payload.output.text</c> field or ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-progress-start-generating</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The parent session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("OriginSessionId")]
            [Validation(Required=false)]
            public string OriginSessionId { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The HTTP status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>全链路ID</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>The response payload.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunWritingV2ResponseBodyPayload Payload { get; set; }
        public class RunWritingV2ResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>The output.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunWritingV2ResponseBodyPayloadOutput Output { get; set; }
            public class RunWritingV2ResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>The reference articles.</para>
                /// </summary>
                [NameInMap("Articles")]
                [Validation(Required=false)]
                public List<RunWritingV2ResponseBodyPayloadOutputArticles> Articles { get; set; }
                public class RunWritingV2ResponseBodyPayloadOutputArticles : TeaModel {
                    /// <summary>
                    /// <para>The author.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>作者</para>
                    /// </summary>
                    [NameInMap("Author")]
                    [Validation(Required=false)]
                    public string Author { get; set; }

                    /// <summary>
                    /// <para>The content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文章内容</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The custom unique ID for the document.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文档-自定义的唯一ID</para>
                    /// </summary>
                    [NameInMap("DocId")]
                    [Validation(Required=false)]
                    public string DocId { get; set; }

                    /// <summary>
                    /// <para>The internal unique identifier for the document.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>98229f6001cf4deeb1668191d4eccc75</para>
                    /// </summary>
                    [NameInMap("DocUuid")]
                    [Validation(Required=false)]
                    public string DocUuid { get; set; }

                    /// <summary>
                    /// <para>The publication time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-08-28 11:38:28</para>
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    /// <summary>
                    /// <para>The source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>央视网</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>The article summary.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文章摘要</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    /// <summary>
                    /// <para>The tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文章标签</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文章标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>The article URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.example.com/aaa.docx">https://www.example.com/aaa.docx</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>A traceability object, returned when the <c>modelSourceTrace</c> parameter is provided.</para>
                /// </summary>
                [NameInMap("GenerateTraceability")]
                [Validation(Required=false)]
                public GenerateTraceability GenerateTraceability { get; set; }

                /// <summary>
                /// <para>A list of refined article snippets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文章精排之后的片段</para>
                /// </summary>
                [NameInMap("MiniDoc")]
                [Validation(Required=false)]
                public List<string> MiniDoc { get; set; }

                /// <summary>
                /// <para>A list of outlines. This field is returned when <c>writingStyle</c> is set to <c>outlineWriting</c> and <c>step</c> is <c>outlineWriting</c>.</para>
                /// </summary>
                [NameInMap("Outlines")]
                [Validation(Required=false)]
                public List<WritingOutline> Outlines { get; set; }

                /// <summary>
                /// <para>The result of the query rewrite.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大模型改变世界</para>
                /// </summary>
                [NameInMap("SearchQuery")]
                [Validation(Required=false)]
                public string SearchQuery { get; set; }

                /// <summary>
                /// <para>The search result. This field is returned when <c>writingStyle</c> is set to <c>outlineWriting</c> and <c>step</c> is <c>OutlineSearch</c>.</para>
                /// </summary>
                [NameInMap("SearchResult")]
                [Validation(Required=false)]
                public OutlineSearchResult SearchResult { get; set; }

                /// <summary>
                /// <para>The generated text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文本生成结果</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The article title. This field is returned when <c>writingStyle</c> is set to <c>outlineWriting</c> and <c>step</c> is <c>outlineWriting</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文章标题</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The token usage statistics.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunWritingV2ResponseBodyPayloadUsage Usage { get; set; }
            public class RunWritingV2ResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>The number of input tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>78</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The number of output tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>A detailed breakdown of token consumption.</para>
                /// </summary>
                [NameInMap("TokenMap")]
                [Validation(Required=false)]
                public Dictionary<string, long?> TokenMap { get; set; }

                /// <summary>
                /// <para>The total number of tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
