// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class OperateRetryJobExecutionShrinkRequest : TeaModel {
        [NameInMap("AppGroupId")]
        [Validation(Required=false)]
        public long? AppGroupId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The job execution ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1310630367761285120</para>
        /// </summary>
        [NameInMap("JobExecutionId")]
        [Validation(Required=false)]
        public string JobExecutionId { get; set; }

        /// <summary>
        /// <para>The list of subtask execution IDs (for broadcast jobs).</para>
        /// <remarks>
        /// <para>To rerun a subtask of a broadcast job, set this field to the execution ID of the corresponding subtask.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public string TaskListShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to trigger downstream nodes.</para>
        /// </summary>
        [NameInMap("TriggerChild")]
        [Validation(Required=false)]
        public bool? TriggerChild { get; set; }

    }

}
