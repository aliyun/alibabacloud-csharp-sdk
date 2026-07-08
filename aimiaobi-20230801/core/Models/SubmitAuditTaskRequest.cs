// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitAuditTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the article to be audited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("ArticleId")]
        [Validation(Required=false)]
        public string ArticleId { get; set; }

        /// <summary>
        /// <para>The content to be audited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>待审核的内容</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The content to be audited, in HTML format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>待审核的内容（HTML格式）</para>
        /// </summary>
        [NameInMap("HtmlContent")]
        [Validation(Required=false)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// <para>The title of the article to be audited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>审核时的文章标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
