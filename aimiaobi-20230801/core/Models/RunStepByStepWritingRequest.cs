// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunStepByStepWritingRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("OriginSessionId")]
        [Validation(Required=false)]
        public string OriginSessionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>提示词</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("ReferenceData")]
        [Validation(Required=false)]
        public RunStepByStepWritingRequestReferenceData ReferenceData { get; set; }
        public class RunStepByStepWritingRequestReferenceData : TeaModel {
            [NameInMap("Articles")]
            [Validation(Required=false)]
            public List<RunStepByStepWritingRequestReferenceDataArticles> Articles { get; set; }
            public class RunStepByStepWritingRequestReferenceDataArticles : TeaModel {
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
                /// <para>8a20e007a6174522af4d6a2657d5526f</para>
                /// </summary>
                [NameInMap("DocUuid")]
                [Validation(Required=false)]
                public string DocUuid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">http://www.example.com</a></para>
                /// </summary>
                [NameInMap("MediaUrl")]
                [Validation(Required=false)]
                public string MediaUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-09-10 14:17:54</para>
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

            [NameInMap("MiniDoc")]
            [Validation(Required=false)]
            public List<string> MiniDoc { get; set; }

            [NameInMap("Outlines")]
            [Validation(Required=false)]
            public List<RunStepByStepWritingRequestReferenceDataOutlines> Outlines { get; set; }
            public class RunStepByStepWritingRequestReferenceDataOutlines : TeaModel {
                [NameInMap("Articles")]
                [Validation(Required=false)]
                public List<RunStepByStepWritingRequestReferenceDataOutlinesArticles> Articles { get; set; }
                public class RunStepByStepWritingRequestReferenceDataOutlinesArticles : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>文章内容</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>文章标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>文章链接</para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>大纲</para>
                /// </summary>
                [NameInMap("Outline")]
                [Validation(Required=false)]
                public string Outline { get; set; }

            }

            [NameInMap("Summarization")]
            [Validation(Required=false)]
            public List<string> Summarization { get; set; }

        }

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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WritingConfig")]
        [Validation(Required=false)]
        public RunStepByStepWritingRequestWritingConfig WritingConfig { get; set; }
        public class RunStepByStepWritingRequestWritingConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>media</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            [NameInMap("PromptTag")]
            [Validation(Required=false)]
            public RunStepByStepWritingRequestWritingConfigPromptTag PromptTag { get; set; }
            public class RunStepByStepWritingRequestWritingConfigPromptTag : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>必要提示</para>
                /// </summary>
                [NameInMap("NecessaryTips")]
                [Validation(Required=false)]
                public string NecessaryTips { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>立场</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>反向词</para>
                /// </summary>
                [NameInMap("ReverseWords")]
                [Validation(Required=false)]
                public string ReverseWords { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>主题</para>
                /// </summary>
                [NameInMap("Theme")]
                [Validation(Required=false)]
                public string Theme { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>分步骤写作场景，传媒写作支持的写作场景:新闻写作(默认),新闻评论,通用文体，公文写作支持的写作场景:通知(默认),通告,通报,请示,决定,函,通用文体</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Writing</para>
            /// </summary>
            [NameInMap("Step")]
            [Validation(Required=false)]
            public string Step { get; set; }

            [NameInMap("SummaryReturnType")]
            [Validation(Required=false)]
            public string SummaryReturnType { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<RunStepByStepWritingRequestWritingConfigTags> Tags { get; set; }
            public class RunStepByStepWritingRequestWritingConfigTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Keyword")]
                [Validation(Required=false)]
                public string Keyword { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gcNumberSizeTag</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseSearch")]
            [Validation(Required=false)]
            public bool? UseSearch { get; set; }

        }

    }

}
