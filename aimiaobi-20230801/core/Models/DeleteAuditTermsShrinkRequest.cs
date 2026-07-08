// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class DeleteAuditTermsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>List of rule IDs for user logon audit terms to delete.</para>
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public string IdListShrink { get; set; }

        /// <summary>
        /// <para>Unique identifier for the Alibaba Cloud Model Studio workspace. Get the <a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
