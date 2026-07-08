// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunSearchSimilarArticlesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response header.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunSearchSimilarArticlesResponseBodyHeader Header { get; set; }
        public class RunSearchSimilarArticlesResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>Error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误码</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message.</para>
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

            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <para>Session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>Response body.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunSearchSimilarArticlesResponseBodyPayload Payload { get; set; }
        public class RunSearchSimilarArticlesResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Output.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunSearchSimilarArticlesResponseBodyPayloadOutput Output { get; set; }
            public class RunSearchSimilarArticlesResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Article list.</para>
                /// </summary>
                [NameInMap("Articles")]
                [Validation(Required=false)]
                public List<RunSearchSimilarArticlesResponseBodyPayloadOutputArticles> Articles { get; set; }
                public class RunSearchSimilarArticlesResponseBodyPayloadOutputArticles : TeaModel {
                    /// <summary>
                    /// <para>UUID of the category</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("CategoryUuid")]
                    [Validation(Required=false)]
                    public string CategoryUuid { get; set; }

                    /// <summary>
                    /// <para>Custom unique document ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("DocId")]
                    [Validation(Required=false)]
                    public string DocId { get; set; }

                    /// <summary>
                    /// <para>Document Type:  </para>
                    /// <list type="bullet">
                    /// <item><description>plainText: plain text; content is required  </description></item>
                    /// <item><description>richText: rich text in HTML format; content is required  </description></item>
                    /// <item><description>text: text file; url is required  </description></item>
                    /// <item><description>pdf: url is required  </description></item>
                    /// <item><description>word: url is required  </description></item>
                    /// <item><description>image: Image; url is required. Supports most common image formats such as GIF, PNG, JPG, and JPEG  </description></item>
                    /// <item><description>video: Video; url is required. Supports most common video formats such as MP4, AVI, WMV, and MOV</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text</para>
                    /// </summary>
                    [NameInMap("DocType")]
                    [Validation(Required=false)]
                    public string DocType { get; set; }

                    /// <summary>
                    /// <para>Article ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a26c2c1</para>
                    /// </summary>
                    [NameInMap("DocUuid")]
                    [Validation(Required=false)]
                    public string DocUuid { get; set; }

                    /// <summary>
                    /// <para>Extension field 1</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Extend1")]
                    [Validation(Required=false)]
                    public string Extend1 { get; set; }

                    /// <summary>
                    /// <para>Extension field 2</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Extend2")]
                    [Validation(Required=false)]
                    public string Extend2 { get; set; }

                    /// <summary>
                    /// <para>Extension field 3</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Extend3")]
                    [Validation(Required=false)]
                    public string Extend3 { get; set; }

                    /// <summary>
                    /// <para>Publication time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01-16 18:07:22</para>
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    /// <summary>
                    /// <para>Search source</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>QuarkCommonNews</para>
                    /// </summary>
                    [NameInMap("SearchSource")]
                    [Validation(Required=false)]
                    public string SearchSource { get; set; }

                    /// <summary>
                    /// <para>Search source name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>互联网搜索</para>
                    /// </summary>
                    [NameInMap("SearchSourceName")]
                    [Validation(Required=false)]
                    public string SearchSourceName { get; set; }

                    /// <summary>
                    /// <para>Type of dataset</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("SearchSourceType")]
                    [Validation(Required=false)]
                    public string SearchSourceType { get; set; }

                    /// <summary>
                    /// <para>Source website.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx.com</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>Summary.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    /// <summary>
                    /// <para>label</para>
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<string> Tags { get; set; }

                    /// <summary>
                    /// <para>Title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://xxx">https://xxx</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>Text generation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文本生成结果</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>instance: The image is running and used by an ECS instance.</para>
            /// <para>none: The image is idle and not used by any ECS instance.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunSearchSimilarArticlesResponseBodyPayloadUsage Usage { get; set; }
            public class RunSearchSimilarArticlesResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>Number of input tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>Number of output tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>Total number of tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
