// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class OperateRetryJobExecutionRequest : TeaModel {
        /// <summary>
        /// <para>The Application Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The Cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The Job Execution ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1310630367761285120</para>
        /// </summary>
        [NameInMap("JobExecutionId")]
        [Validation(Required=false)]
        public string JobExecutionId { get; set; }

        /// <summary>
        /// <para>A list of Sub-task execution IDs for a Broadcast Sharding Job.</para>
        /// <remarks>
        /// <para>To retry a specific Sub-task of a Broadcast Sharding Job, set this parameter to the execution ID of that Sub-task.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<string> TaskList { get; set; }

        /// <summary>
        /// <para>Specifies whether to trigger downstream jobs.</para>
        /// </summary>
        [NameInMap("TriggerChild")]
        [Validation(Required=false)]
        public bool? TriggerChild { get; set; }

    }

}
