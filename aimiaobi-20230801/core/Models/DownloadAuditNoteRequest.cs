// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class DownloadAuditNoteRequest : TeaModel {
        /// <summary>
        /// <para>Rule library ID. If left blank, the default is Default.</para>
        /// </summary>
        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public string NoteId { get; set; }

        /// <summary>
        /// <para>The task ID obtained by calling the SubmitAuditNote API. This is the unique identifier for the custom rule library task index. Store it securely when using it. When using this API, if the input parameters include \<c>taskId\\</c>, you can retrieve the structured rule library that you successfully uploaded via the SubmitAuditNote API but has not undergone post-processing by ConfirmAndProcessAuditNote. If the input parameters do not include \<c>taskId\\</c>, you can retrieve the structured rule library that has undergone post-processing and is available for auditing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx_Default_1241541251241</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Alibaba Cloud Model Studio workspace. Get the <a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a>.</para>
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
