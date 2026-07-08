// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitAuditNoteRequest : TeaModel {
        /// <summary>
        /// <para>The FileKey of your rule library file stored in Alibaba Cloud OSS. For how to generate a FileKey, see <a href="https://next.api.aliyun.com/document/AiMiaoBi/2023-08-01/GenerateUploadConfig?spm=openapi-amp.newDocPublishment.0.0.18fc281fOiiBil">Common APIs: GenerateUploadConfig for File Upload and Download</a>. Your rule library file must be in DOCX, XLSX, or PDF format. If you use XLSX, it must have exactly two columns. The table header must be &quot;Proofreading Basis&quot; and &quot;Source&quot;. XLSX files give the best parsing results. DOCX and PDF files are also parsed automatically.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://default/your/file/key</para>
        /// </summary>
        [NameInMap("FileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        /// <summary>
        /// <para>ID of the rule library. If you omit this parameter, the system uses Default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>note_id_unique</para>
        /// </summary>
        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public string NoteId { get; set; }

        /// <summary>
        /// <para>Unique identifier of your Model Studio workspace. To get this ID, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get the Workspace ID</a>.</para>
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
