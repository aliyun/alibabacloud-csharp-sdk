// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyTaskInfoRequest : TeaModel {
        /// <summary>
        /// <para>The JSON-formatted parameters related to the action. Set this parameter to <c>{&quot;recoverMode&quot;: &quot;xxx&quot;, &quot;recoverTime&quot;: &quot;xxx&quot;}</c> if the <b>TaskAction</b> parameter is set to <b>modifySwitchTime</b>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>recoverMode</b>: specifies the restoration mode for the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>timePoint</b>: performs the task at the specified point in time.</description></item>
        /// <item><description><b>immediate</b>: performs the task immediately.</description></item>
        /// <item><description><b>maintainTime</b>: performs the task within the maintenance window.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>recoverTime</b>: specifies the point in time for restoration. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. This parameter is required if the <b>recoverMode</b> parameter is set to <b>timePoint</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;recoverMode\&quot;:\&quot;immediate\&quot;}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The name of the current step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec_task</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

        /// <summary>
        /// <para>The action name. Set the value to <b>modifySwitchTime</b>. The value specifies that you want to change the switching time or restoration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modifySwitchTime</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>The task ID. Separate multiple task IDs with commas (,). You can specify up to 30 task IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-0mq3kfhn8i1nlt****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
