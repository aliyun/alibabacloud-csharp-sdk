// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitDocClusterTaskRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>A list of documents.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Documents")]
        [Validation(Required=false)]
        public List<SubmitDocClusterTaskRequestDocuments> Documents { get; set; }
        public class SubmitDocClusterTaskRequestDocuments : TeaModel {
            /// <summary>
            /// <para>The content of the document.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文档内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The document ID. It is used to identify the document in the returned cluster results. If you do not provide an ID for any document, the array index is used instead. An error is reported if you provide IDs for only some of the documents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文档ID。用于在返回聚类文章时标识文章。如果文章列表中都不传则使用数组索引作为ID。如果部分传则会报错</para>
            /// </summary>
            [NameInMap("DocId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            /// <summary>
            /// <para>The title of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文档标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The character limit for the generated cluster summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("SummaryLength")]
        [Validation(Required=false)]
        public int? SummaryLength { get; set; }

        /// <summary>
        /// <para>The character limit for the generated cluster title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69</para>
        /// </summary>
        [NameInMap("TitleLength")]
        [Validation(Required=false)]
        public int? TitleLength { get; set; }

        /// <summary>
        /// <para>The maximum number of clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TopicCount")]
        [Validation(Required=false)]
        public int? TopicCount { get; set; }

    }

}
