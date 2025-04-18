// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SendDocumentAskQuestionRequest : TeaModel {
        /// <summary>
        /// <para>Folder ID, used to specify the range of documents for the query. If it is empty, it indicates that all documents under the tenant will be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a851c4a-1d65-11ef-99a7-ssfsfdd</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The question queried by the user</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Total carbon emissions in 2023</para>
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>Q&amp;A session ID, used to record multiple Q&amp;A interactions of the same user. If it is empty, it indicates that sessions are not distinguished.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bfce2248-1546-4298-8bcf-70ac26e69646</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
