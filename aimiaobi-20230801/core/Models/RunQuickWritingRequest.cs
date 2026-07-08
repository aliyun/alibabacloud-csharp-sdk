// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunQuickWritingRequest : TeaModel {
        /// <summary>
        /// <para>Referenced articles</para>
        /// 
        /// <b>Example:</b>
        /// <para>集合</para>
        /// </summary>
        [NameInMap("Articles")]
        [Validation(Required=false)]
        public List<RunQuickWritingRequestArticles> Articles { get; set; }
        public class RunQuickWritingRequestArticles : TeaModel {
            /// <summary>
            /// <para>Article content</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Article title</para>
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
        /// <para>Other writing parameters. Choose either prompt or writingParams.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请按英文输出</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>Use the specified search source list.</para>
        /// </summary>
        [NameInMap("SearchSources")]
        [Validation(Required=false)]
        public List<RunQuickWritingRequestSearchSources> SearchSources { get; set; }
        public class RunQuickWritingRequestSearchSources : TeaModel {
            /// <summary>
            /// <para>SystemSearch: system-built-in search. CustomSemanticSearch: custom semantic index search. ThirdSearch: third-party API search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemSearch</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Unique identifier of the data source</para>
            /// 
            /// <b>Example:</b>
            /// <para>QuarkCommonNews</para>
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

        }

        /// <summary>
        /// <para>Task ID. Reuse the same task ID for multi-turn conversations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
