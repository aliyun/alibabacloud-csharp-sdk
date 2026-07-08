// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunStepByStepWritingRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the original conversation when regenerating content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("OriginSessionId")]
        [Validation(Required=false)]
        public string OriginSessionId { get; set; }

        /// <summary>
        /// <para>The prompt.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>提示词</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The reference article data for writing.</para>
        /// </summary>
        [NameInMap("ReferenceData")]
        [Validation(Required=false)]
        public RunStepByStepWritingRequestReferenceData ReferenceData { get; set; }
        public class RunStepByStepWritingRequestReferenceData : TeaModel {
            /// <summary>
            /// <para>The reference article data for writing.</para>
            /// </summary>
            [NameInMap("Articles")]
            [Validation(Required=false)]
            public List<RunStepByStepWritingRequestReferenceDataArticles> Articles { get; set; }
            public class RunStepByStepWritingRequestReferenceDataArticles : TeaModel {
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
                /// <para>8a20e007a6174522af4d6a2657d5526f</para>
                /// </summary>
                [NameInMap("DocUuid")]
                [Validation(Required=false)]
                public string DocUuid { get; set; }

                /// <summary>
                /// <para>The URL of the original material.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">http://www.example.com</a></para>
                /// </summary>
                [NameInMap("MediaUrl")]
                [Validation(Required=false)]
                public string MediaUrl { get; set; }

                /// <summary>
                /// <para>The publication time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-10 14:17:54</para>
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
            /// <para>The ranked article segments for subsequent model generation.</para>
            /// </summary>
            [NameInMap("MiniDoc")]
            [Validation(Required=false)]
            public List<string> MiniDoc { get; set; }

            /// <summary>
            /// <para>The outline. You can specify a data source to generate the outline.</para>
            /// </summary>
            [NameInMap("Outlines")]
            [Validation(Required=false)]
            public List<RunStepByStepWritingRequestReferenceDataOutlines> Outlines { get; set; }
            public class RunStepByStepWritingRequestReferenceDataOutlines : TeaModel {
                /// <summary>
                /// <para>The specified data source for the outline.</para>
                /// </summary>
                [NameInMap("Articles")]
                [Validation(Required=false)]
                public List<RunStepByStepWritingRequestReferenceDataOutlinesArticles> Articles { get; set; }
                public class RunStepByStepWritingRequestReferenceDataOutlinesArticles : TeaModel {
                    /// <summary>
                    /// <para>The article content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文章内容</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The article title.</para>
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
                    /// <para>文章链接</para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The outline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大纲</para>
                /// </summary>
                [NameInMap("Outline")]
                [Validation(Required=false)]
                public string Outline { get; set; }

            }

            /// <summary>
            /// <para>The summary result from the Large Language Model (LLM).</para>
            /// </summary>
            [NameInMap("Summarization")]
            [Validation(Required=false)]
            public List<string> Summarization { get; set; }

        }

        /// <summary>
        /// <para>The ID of a single-turn conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The task ID. You can reuse the same task ID for a multi-turn conversation.</para>
        /// <remarks>
        /// <para>By default, you do not need to specify this parameter. The system automatically generates a task ID. If you specify the same TaskId for subsequent tasks, the tasks are considered part of the same conversation group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The unique ID of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Obtain a Workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The writing configuration.</para>
        /// </summary>
        [NameInMap("WritingConfig")]
        [Validation(Required=false)]
        public RunStepByStepWritingRequestWritingConfig WritingConfig { get; set; }
        public class RunStepByStepWritingRequestWritingConfig : TeaModel {
            /// <summary>
            /// <para>The writing domain.</para>
            /// <list type="bullet">
            /// <item><description><para>media (default): Media writing.</para>
            /// </description></item>
            /// <item><description><para>government: Official document writing.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>media</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The keywords. This affects article retrieval.</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            /// <summary>
            /// <para>The prompt assistant.</para>
            /// </summary>
            [NameInMap("PromptTag")]
            [Validation(Required=false)]
            public RunStepByStepWritingRequestWritingConfigPromptTag PromptTag { get; set; }
            public class RunStepByStepWritingRequestWritingConfigPromptTag : TeaModel {
                /// <summary>
                /// <para>Necessary tips.</para>
                /// 
                /// <b>Example:</b>
                /// <para>必要提示</para>
                /// </summary>
                [NameInMap("NecessaryTips")]
                [Validation(Required=false)]
                public string NecessaryTips { get; set; }

                /// <summary>
                /// <para>The position or stance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>立场</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                /// <summary>
                /// <para>Reverse the words.</para>
                /// 
                /// <b>Example:</b>
                /// <para>反向词</para>
                /// </summary>
                [NameInMap("ReverseWords")]
                [Validation(Required=false)]
                public string ReverseWords { get; set; }

                /// <summary>
                /// <para>The theme.</para>
                /// 
                /// <b>Example:</b>
                /// <para>主题</para>
                /// </summary>
                [NameInMap("Theme")]
                [Validation(Required=false)]
                public string Theme { get; set; }

            }

            /// <summary>
            /// <para>The step-by-step writing scenario.</para>
            /// <list type="bullet">
            /// <item><description><para>Scenarios supported for media writing: News Writing (default), News Commentary, and General Style.</para>
            /// </description></item>
            /// <item><description><para>Scenarios supported for official document writing: Notification (default), Announcement, Bulletin, Request for Instruction, Decision, Letter, and General Style.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>新闻写作</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The writing step.</para>
            /// <list type="bullet">
            /// <item><description><para>Generate outline: OutlineGenerate</para>
            /// </description></item>
            /// <item><description><para>Generate summary: MiniDocSummary</para>
            /// </description></item>
            /// <item><description><para>Writing (default): Generate article</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Writing</para>
            /// </summary>
            [NameInMap("Step")]
            [Validation(Required=false)]
            public string Step { get; set; }

            /// <summary>
            /// <para>The return type of the summary result.<br></para>
            /// <list type="bullet">
            /// <item><description><para>Structure:
            /// Returns a JSON string in payload.output.text. Example format: <c>{&quot;event&quot;:&quot;{outline}&quot;,&quot;message&quot;:&quot;{message}&quot;}</c></para>
            /// </description></item>
            /// <item><description><para>Content: Returns only the plain text summary content in payload.output.text. Example format:
            /// `Outline: {outline}</para>
            /// </description></item>
            /// </list>
            /// <para>{message}</para>
            /// <para> Outline: {outline}</para>
            /// <para>{message}`</para>
            /// <list type="bullet">
            /// <item><description>Event: Returns only the outline content itself in payload.output.text each time an outline is completed. Typically, six describes are returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Structure</para>
            /// </summary>
            [NameInMap("SummaryReturnType")]
            [Validation(Required=false)]
            public string SummaryReturnType { get; set; }

            /// <summary>
            /// <para>Control parameters for writing, such as style, length, and output language.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<RunStepByStepWritingRequestWritingConfigTags> Tags { get; set; }
            public class RunStepByStepWritingRequestWritingConfigTags : TeaModel {
                /// <summary>
                /// <para>The value of the option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Keyword")]
                [Validation(Required=false)]
                public string Keyword { get; set; }

                /// <summary>
                /// <para>The tag of the option. For example, gcNumberSizeTag=10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gcNumberSizeTag</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically supplement materials.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseSearch")]
            [Validation(Required=false)]
            public bool? UseSearch { get; set; }

        }

    }

}
