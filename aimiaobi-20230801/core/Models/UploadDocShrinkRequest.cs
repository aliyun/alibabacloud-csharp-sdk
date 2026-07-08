// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UploadDocShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Folder where the document resides. If no value is provided, it defaults to &quot;default&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>Document</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Docs")]
        [Validation(Required=false)]
        public string DocsShrink { get; set; }

        /// <summary>
        /// <para>Unique identifier (UUID) of the Alibaba Cloud Model Studio workspace: obtain the <a href="https://help.aliyun.com/document_detail/2587495.html">Workspace ID</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-yigtrrjl377rcbab</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
