// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunQuickWritingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Referenced articles</para>
        /// 
        /// <b>Example:</b>
        /// <para>集合</para>
        /// </summary>
        [NameInMap("Articles")]
        [Validation(Required=false)]
        public string ArticlesShrink { get; set; }

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
        public string SearchSourcesShrink { get; set; }

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
