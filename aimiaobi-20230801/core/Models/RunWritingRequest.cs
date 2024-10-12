// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunWritingRequest : TeaModel {
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
        public RunWritingRequestReferenceData ReferenceData { get; set; }
        public class RunWritingRequestReferenceData : TeaModel {
            [NameInMap("Articles")]
            [Validation(Required=false)]
            public List<RunWritingRequestReferenceDataArticles> Articles { get; set; }
            public class RunWritingRequestReferenceDataArticles : TeaModel {
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
                /// <para>2124ca4d48a542d788aa86151e1a8c8b</para>
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
        public RunWritingRequestWritingConfig WritingConfig { get; set; }
        public class RunWritingRequestWritingConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>写作领域，media:传媒,government:政务,market:营销</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("PromptTag")]
            [Validation(Required=false)]
            public RunWritingRequestWritingConfigPromptTag PromptTag { get; set; }
            public class RunWritingRequestWritingConfigPromptTag : TeaModel {
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

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<RunWritingRequestWritingConfigTags> Tags { get; set; }
            public class RunWritingRequestWritingConfigTags : TeaModel {
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
