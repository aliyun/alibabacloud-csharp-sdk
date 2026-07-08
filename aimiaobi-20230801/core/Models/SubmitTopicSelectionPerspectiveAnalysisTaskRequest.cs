// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitTopicSelectionPerspectiveAnalysisTaskRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the workspace: <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The list of documents to be analyzed. (Provide at least one of documents or topic)</para>
        /// </summary>
        [NameInMap("Documents")]
        [Validation(Required=false)]
        public List<SubmitTopicSelectionPerspectiveAnalysisTaskRequestDocuments> Documents { get; set; }
        public class SubmitTopicSelectionPerspectiveAnalysisTaskRequestDocuments : TeaModel {
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
            /// <para>Content list</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public List<SubmitTopicSelectionPerspectiveAnalysisTaskRequestDocumentsComments> Comments { get; set; }
            public class SubmitTopicSelectionPerspectiveAnalysisTaskRequestDocumentsComments : TeaModel {
                /// <summary>
                /// <para>Content</para>
                /// 
                /// <b>Example:</b>
                /// <para>内容</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>Username</para>
                /// 
                /// <b>Example:</b>
                /// <para>用户名</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>Content</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Publication time. Format: YYYY-MM-dd HH:mm:ss</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-22 10:29:00</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <para>Article source</para>
            /// 
            /// <b>Example:</b>
            /// <para>新浪</para>
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
            /// <para>Article URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/aaa.docx">https://www.example.com/aaa.docx</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The topic selection perspective tasks to be analyzed. By default, this parameter is empty, which means all tasks are analyzed. (TopicSummary: Topic event summary, HotViewPoints: Hot topic selection perspectives, TimedViewPoints: Timeliness topic selection perspectives, WebReviewPoints: Online review topic selection perspectives, FreshViewPoints: Novel topic selection perspectives)</para>
        /// 
        /// <b>Example:</b>
        /// <para>TimedViewPoints</para>
        /// </summary>
        [NameInMap("PerspectiveTypes")]
        [Validation(Required=false)]
        public List<string> PerspectiveTypes { get; set; }

        /// <summary>
        /// <para>The name of the topic to be analyzed. (Provide at least one of documents or topic)</para>
        /// 
        /// <b>Example:</b>
        /// <para>待分析的主题名（documents与topic二者至少传一个）</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
