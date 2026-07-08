// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunWritingResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the current request is complete.</para>
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
        public RunWritingResponseBodyHeader Header { get; set; }
        public class RunWritingResponseBodyHeader : TeaModel {
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
            /// <para>The Server-Sent Events (SSE) event. Valid values: task-started (the task starts), task-finished (the task is complete), and task-failed (the task failed).</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-started</para>
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
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunWritingResponseBodyPayload Payload { get; set; }
        public class RunWritingResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>The output.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunWritingResponseBodyPayloadOutput Output { get; set; }
            public class RunWritingResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>The reference articles.</para>
                /// </summary>
                [NameInMap("Articles")]
                [Validation(Required=false)]
                public List<RunWritingResponseBodyPayloadOutputArticles> Articles { get; set; }
                public class RunWritingResponseBodyPayloadOutputArticles : TeaModel {
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
                    /// <para>The custom unique ID of the document.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文档-自定义的唯一ID</para>
                    /// </summary>
                    [NameInMap("DocId")]
                    [Validation(Required=false)]
                    public string DocId { get; set; }

                    /// <summary>
                    /// <para>The internal unique ID of the document.</para>
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
                    /// <para>The URL of the article.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.example.com/aaa.docx">https://www.example.com/aaa.docx</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>A list of refined segments from the article.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文章精排之后的片段</para>
                /// </summary>
                [NameInMap("MiniDoc")]
                [Validation(Required=false)]
                public List<string> MiniDoc { get; set; }

                /// <summary>
                /// <para>The rewritten query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大模型改变世界</para>
                /// </summary>
                [NameInMap("SearchQuery")]
                [Validation(Required=false)]
                public string SearchQuery { get; set; }

                /// <summary>
                /// <para>The generated text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文本生成结果</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>The token usage.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunWritingResponseBodyPayloadUsage Usage { get; set; }
            public class RunWritingResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>The number of tokens used for the input.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The number of tokens used for the output.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>The detailed token usage.</para>
                /// </summary>
                [NameInMap("TokenMap")]
                [Validation(Required=false)]
                public Dictionary<string, long?> TokenMap { get; set; }

                /// <summary>
                /// <para>The total number of tokens used in the current call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
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
