// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunWritingV2Request : TeaModel {
        [NameInMap("Articles")]
        [Validation(Required=false)]
        public List<RunWritingV2RequestArticles> Articles { get; set; }
        public class RunWritingV2RequestArticles : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-25 14:25:59</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>QuarkCommonNews</para>
            /// </summary>
            [NameInMap("SearchSourceName")]
            [Validation(Required=false)]
            public string SearchSourceName { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DistributeWriting")]
        [Validation(Required=false)]
        public bool? DistributeWriting { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GcNumberSize")]
        [Validation(Required=false)]
        public int? GcNumberSize { get; set; }

        [NameInMap("GcNumberSizeTag")]
        [Validation(Required=false)]
        public string GcNumberSizeTag { get; set; }

        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("MiniDocs")]
        [Validation(Required=false)]
        public List<RunWritingV2RequestMiniDocs> MiniDocs { get; set; }
        public class RunWritingV2RequestMiniDocs : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public string Index { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Star")]
            [Validation(Required=false)]
            public bool? Star { get; set; }

        }

        [NameInMap("Outlines")]
        [Validation(Required=false)]
        public List<RunWritingV2RequestOutlines> Outlines { get; set; }
        public class RunWritingV2RequestOutlines : TeaModel {
            [NameInMap("Articles")]
            [Validation(Required=false)]
            public List<RunWritingV2RequestOutlinesArticles> Articles { get; set; }
            public class RunWritingV2RequestOutlinesArticles : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Outline")]
            [Validation(Required=false)]
            public string Outline { get; set; }

        }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Template</para>
        /// </summary>
        [NameInMap("PromptMode")]
        [Validation(Required=false)]
        public string PromptMode { get; set; }

        [NameInMap("SearchSources")]
        [Validation(Required=false)]
        public List<RunWritingV2RequestSearchSources> SearchSources { get; set; }
        public class RunWritingV2RequestSearchSources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SystemSearch</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>QuarkCommonNews</para>
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
        /// <para>Writing</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public string Step { get; set; }

        [NameInMap("Summarization")]
        [Validation(Required=false)]
        public List<RunWritingV2RequestSummarization> Summarization { get; set; }
        public class RunWritingV2RequestSummarization : TeaModel {
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseSearch")]
        [Validation(Required=false)]
        public bool? UseSearch { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WritingParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> WritingParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>media</para>
        /// </summary>
        [NameInMap("WritingScene")]
        [Validation(Required=false)]
        public string WritingScene { get; set; }

        [NameInMap("WritingStyle")]
        [Validation(Required=false)]
        public string WritingStyle { get; set; }

    }

}
