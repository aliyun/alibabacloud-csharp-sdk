// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class CancelAuditTaskRequest : TeaModel {
        /// <summary>
        /// <para>Article ID. Specify either this parameter or ContentAuditTaskId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("ArticleId")]
        [Validation(Required=false)]
        public string ArticleId { get; set; }

        /// <summary>
        /// <para>Audit task ID. Specify either this parameter or ArticleId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ContentAuditTaskId")]
        [Validation(Required=false)]
        public string ContentAuditTaskId { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
