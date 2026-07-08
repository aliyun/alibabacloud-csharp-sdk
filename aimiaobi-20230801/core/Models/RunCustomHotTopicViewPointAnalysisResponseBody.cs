// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunCustomHotTopicViewPointAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>Response header</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunCustomHotTopicViewPointAnalysisResponseBodyHeader Header { get; set; }
        public class RunCustomHotTopicViewPointAnalysisResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>Error code</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误码</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Server-sent event. Valid values: task-started, task-finished, and task-failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-started</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>Parent session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("OriginSessionId")]
            [Validation(Required=false)]
            public string OriginSessionId { get; set; }

            /// <summary>
            /// <para>Session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Trace ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>全链路ID</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>Response body</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunCustomHotTopicViewPointAnalysisResponseBodyPayload Payload { get; set; }
        public class RunCustomHotTopicViewPointAnalysisResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Outputs</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunCustomHotTopicViewPointAnalysisResponseBodyPayloadOutput Output { get; set; }
            public class RunCustomHotTopicViewPointAnalysisResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Reference article list</para>
                /// </summary>
                [NameInMap("Articles")]
                [Validation(Required=false)]
                public List<RunCustomHotTopicViewPointAnalysisResponseBodyPayloadOutputArticles> Articles { get; set; }
                public class RunCustomHotTopicViewPointAnalysisResponseBodyPayloadOutputArticles : TeaModel {
                    /// <summary>
                    /// <para>Author</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>作者</para>
                    /// </summary>
                    [NameInMap("Author")]
                    [Validation(Required=false)]
                    public string Author { get; set; }

                    /// <summary>
                    /// <para>Content</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文章内容</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>Publish time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-09-10 14:17:53</para>
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    /// <summary>
                    /// <para>Source</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>央视网</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>Summary</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文章摘要</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    /// <summary>
                    /// <para>Title</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文章标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>URL title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.example.com/aaa.docx">https://www.example.com/aaa.docx</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>Follow-up question list</para>
                /// </summary>
                [NameInMap("AskUser")]
                [Validation(Required=false)]
                public List<string> AskUser { get; set; }

                /// <summary>
                /// <para>Asynchronous task ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>异步任务ID</para>
                /// </summary>
                [NameInMap("AsyncTaskId")]
                [Validation(Required=false)]
                public string AsyncTaskId { get; set; }

                /// <summary>
                /// <para>Viewpoint of the custom hot topic generated by the model</para>
                /// 
                /// <b>Example:</b>
                /// <para>模型生成的自定义选题视角的观点</para>
                /// </summary>
                [NameInMap("Attitude")]
                [Validation(Required=false)]
                public string Attitude { get; set; }

                /// <summary>
                /// <para>Custom viewpoint ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxxx</para>
                /// </summary>
                [NameInMap("CustomViewPointId")]
                [Validation(Required=false)]
                public string CustomViewPointId { get; set; }

                /// <summary>
                /// <para>Text generation result</para>
                /// 
                /// <b>Example:</b>
                /// <para>文本生成结果</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>Topic ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>话题ID</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public string TopicId { get; set; }

            }

            /// <summary>
            /// <para>Whether the image is running on an ECS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>instance: The image is running and used by an ECS instance.</para>
            /// </description></item>
            /// <item><description><para>none: The image is idle and not currently used by any ECS instance.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunCustomHotTopicViewPointAnalysisResponseBodyPayloadUsage Usage { get; set; }
            public class RunCustomHotTopicViewPointAnalysisResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>Number of input tokens</para>
                /// 
                /// <b>Example:</b>
                /// <para>51</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>Number of output tokens</para>
                /// 
                /// <b>Example:</b>
                /// <para>79</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>Total number of tokens</para>
                /// 
                /// <b>Example:</b>
                /// <para>130</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
