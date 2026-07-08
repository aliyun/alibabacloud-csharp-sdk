// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunCustomHotTopicAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>The response header.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunCustomHotTopicAnalysisResponseBodyHeader Header { get; set; }
        public class RunCustomHotTopicAnalysisResponseBodyHeader : TeaModel {
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
            /// <para>The Server-Sent Events (SSE) event. Valid values: task-started: The task starts. task-finished: The task is complete. task-failed: The task failed.</para>
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
        public RunCustomHotTopicAnalysisResponseBodyPayload Payload { get; set; }
        public class RunCustomHotTopicAnalysisResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>The output.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunCustomHotTopicAnalysisResponseBodyPayloadOutput Output { get; set; }
            public class RunCustomHotTopicAnalysisResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>The reference articles.</para>
                /// </summary>
                [NameInMap("Articles")]
                [Validation(Required=false)]
                public List<RunCustomHotTopicAnalysisResponseBodyPayloadOutputArticles> Articles { get; set; }
                public class RunCustomHotTopicAnalysisResponseBodyPayloadOutputArticles : TeaModel {
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
                    /// <para>a2103fcfbd5441f1991c72f8834833e3</para>
                    /// </summary>
                    [NameInMap("DocUuid")]
                    [Validation(Required=false)]
                    public string DocUuid { get; set; }

                    /// <summary>
                    /// <para>The publication time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-08-27 14:50:47</para>
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
                /// <para>The list of follow-up questions.</para>
                /// </summary>
                [NameInMap("AskUser")]
                [Validation(Required=false)]
                public List<string> AskUser { get; set; }

                /// <summary>
                /// <para>The ID of the asynchronous task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>异步任务ID</para>
                /// </summary>
                [NameInMap("AsyncTaskId")]
                [Validation(Required=false)]
                public string AsyncTaskId { get; set; }

                /// <summary>
                /// <para>The custom perspective for topic selection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>自定义选题视角</para>
                /// </summary>
                [NameInMap("Attitude")]
                [Validation(Required=false)]
                public string Attitude { get; set; }

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
                /// <para>The text generation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文本生成结果</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The topic ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>话题ID</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public string TopicId { get; set; }

            }

            /// <summary>
            /// <para>The token usage.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunCustomHotTopicAnalysisResponseBodyPayloadUsage Usage { get; set; }
            public class RunCustomHotTopicAnalysisResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>The number of tokens used for the input.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The number of tokens for the output.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>The total number of tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>73</para>
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
