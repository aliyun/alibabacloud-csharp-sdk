// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunTextPolishingRequest : TeaModel {
        /// <summary>
        /// <para>Text content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>文本内容</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Original article.</para>
        /// 
        /// <b>Example:</b>
        /// <para>原始文章内容</para>
        /// </summary>
        [NameInMap("OriginContent")]
        [Validation(Required=false)]
        public string OriginContent { get; set; }

        /// <summary>
        /// <para>Custom polishing requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>自定义的润色要求</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The task ID. The same task ID shares a session. The task timeout is 12 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>taskld-xxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Alibaba Cloud Model Studio workspace. Obtain the <a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a>.</para>
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
