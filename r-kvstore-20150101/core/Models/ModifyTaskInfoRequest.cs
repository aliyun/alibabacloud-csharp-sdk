// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyTaskInfoRequest : TeaModel {
        /// <summary>
        /// <para>The parameters related to the action, in JSON format.
        /// If <b>TaskAction</b> is set to <b>modifySwitchTime</b>, set this parameter to <c>{&quot;recoverMode&quot;: &quot;xxx&quot;, &quot;recoverTime&quot;: &quot;xxx&quot;}</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>recoverMode</b>: the recovery mode of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>imePoint</b>: executes the task at a specified point in time.</description></item>
        /// <item><description><b>immediate</b>: executes the task immediately.</description></item>
        /// <item><description><b>maintainTime</b>: executes the task during the O&amp;M window.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>recoverTime</b>: the specified point in time. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. This parameter is required when <b>recoverMode</b> is set to <b>timePoint</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;recoverMode&quot;:&quot;immediate&quot;}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
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
        /// <para>The name of the current execution step. You can call the <a href="https://help.aliyun.com/document_detail/2400077.html">DescribeHistoryTasks</a> operation to query the current execution step of a specified task. A common value is <b>do_pause</b>, which indicates that the task is waiting to be executed at a preset time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>do_pause</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

        /// <summary>
        /// <para>The operation name. Valid value: <b>modifySwitchTime</b>, which indicates modifying the switchover time or recovery time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modifySwitchTime</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>The task ID. Separate multiple task IDs with commas (,). A maximum of 30 task IDs are supported.</para>
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
