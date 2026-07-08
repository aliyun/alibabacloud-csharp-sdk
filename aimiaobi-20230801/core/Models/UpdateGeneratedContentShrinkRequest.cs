// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UpdateGeneratedContentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The body of the article in rich text format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>正文</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The body of the article in plain text format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>正文</para>
        /// </summary>
        [NameInMap("ContentText")]
        [Validation(Required=false)]
        public string ContentText { get; set; }

        /// <summary>
        /// <para>The unique identifier of the document.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The keywords.</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string KeywordsShrink { get; set; }

        /// <summary>
        /// <para>The last prompt that was used to generate the content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>创作xx文章</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>文章名称</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
