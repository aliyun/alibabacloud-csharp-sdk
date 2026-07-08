// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunWritingRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the original conversation to use for regeneration.</para>
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
        public RunWritingRequestReferenceData ReferenceData { get; set; }
        public class RunWritingRequestReferenceData : TeaModel {
            /// <summary>
            /// <para>The reference article data for writing.</para>
            /// </summary>
            [NameInMap("Articles")]
            [Validation(Required=false)]
            public List<RunWritingRequestReferenceDataArticles> Articles { get; set; }
            public class RunWritingRequestReferenceDataArticles : TeaModel {
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
                /// <para>2124ca4d48a542d788aa86151e1a8c8b</para>
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
        /// <para>The ID of the task. You can reuse the same task ID in a multi-turn conversation.</para>
        /// <remarks>
        /// <para>You do not need to specify TaskId. The system generates one automatically. If you use the same TaskId for multiple tasks, they are grouped into a single conversation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The unique ID of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get a Workspace ID</a>.</para>
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
        public RunWritingRequestWritingConfig WritingConfig { get; set; }
        public class RunWritingRequestWritingConfig : TeaModel {
            /// <summary>
            /// <para>The writing domain.</para>
            /// <list type="bullet">
            /// <item><description><para>media: Media</para>
            /// </description></item>
            /// <item><description><para>government: Government</para>
            /// </description></item>
            /// <item><description><para>market: Marketing</para>
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
            /// <para>The prompt assistant.</para>
            /// </summary>
            [NameInMap("PromptTag")]
            [Validation(Required=false)]
            public RunWritingRequestWritingConfigPromptTag PromptTag { get; set; }
            public class RunWritingRequestWritingConfigPromptTag : TeaModel {
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
                /// <para>The stance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>立场</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                /// <summary>
                /// <para>Negative keywords.</para>
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
            /// <para>Control parameters for writing, such as the style, length, and output language.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<RunWritingRequestWritingConfigTags> Tags { get; set; }
            public class RunWritingRequestWritingConfigTags : TeaModel {
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
                /// <para>The tag of the option. Example: gcNumberSizeTag=10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gcNumberSizeTag</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically add reference materials.</para>
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
