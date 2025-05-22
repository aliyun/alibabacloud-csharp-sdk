// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetAITaskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the TaskOutput parameter. The TaskOutput parameter specifies the outputs of the AI task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled</description></item>
        /// <item><description>Disabled (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> The value of TaskOutput may be excessively long. If you do not require the outputs of the task, we recommend that you set OutputOption to Disabled to improve the response speed of the API operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("OutputOption")]
        [Validation(Required=false)]
        public string OutputOption { get; set; }

        /// <summary>
        /// <para>The ID of the AI task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-asasas*****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
