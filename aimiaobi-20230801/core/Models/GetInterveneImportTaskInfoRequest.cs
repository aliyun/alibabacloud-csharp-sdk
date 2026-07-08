// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetInterveneImportTaskInfoRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67c520d1fa43455ea44fb69fa402d54d_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The unique identifier of the task.</para>
        /// <remarks>
        /// <para>This parameter is optional. The system automatically generates a task ID if you do not specify this parameter. Tasks that have the same \<c>TaskId\\</c> belong to the same conversation group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>19162157</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
