// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetTopicSelectionPerspectiveAnalysisTaskRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The unique ID of the task.</para>
        /// <remarks>
        /// <para>This parameter is optional. The system automatically generates a task ID. If subsequent tasks have the same TaskId, they are considered part of the same conversation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c9f226b02cca4f42a84c5e955c39dfd2</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
