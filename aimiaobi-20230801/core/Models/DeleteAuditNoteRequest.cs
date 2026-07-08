// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class DeleteAuditNoteRequest : TeaModel {
        /// <summary>
        /// <para>Rule library ID. If left blank, the default is used.</para>
        /// </summary>
        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public string NoteId { get; set; }

        /// <summary>
        /// <para>The unique identifier for an Alibaba Cloud Model Studio workspace: Get the <a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a></para>
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
