// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("Documents")]
        [Validation(Required=false)]
        public List<SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequestDocuments> Documents { get; set; }
        public class SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequestDocuments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>作者</para>
            /// </summary>
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-22 10:29:00</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>新浪</para>
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>自定义观点的输入Prompt</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>待分析的主题名（documents与topic二者至少传一个）</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
