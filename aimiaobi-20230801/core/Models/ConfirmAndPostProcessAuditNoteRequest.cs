// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ConfirmAndPostProcessAuditNoteRequest : TeaModel {
        /// <summary>
        /// <para>The TaskId obtained from the SubmitAuditNote interface. This is the unique identifier for the custom rule library task index. Store it securely when using it.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx_Default_1241541251241</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud Model Studio workspace unique identifier: Get <a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a></para>
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
