// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class GetLongTextTranslateTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the long-text translation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a8f25f25-0b36-4349-857f-e19a43f69e51</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The ID of the Model Studio workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-ep8ba0dr6seiddri</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
