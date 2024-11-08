// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class NotifyExecutionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the execution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec-xxx</para>
        /// </summary>
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// <para>The state of the terminated execution. This parameter is valid if you set the NotifyType parameter to CompleteExecution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ExecutionStatus")]
        [Validation(Required=false)]
        public string ExecutionStatus { get; set; }

        /// <summary>
        /// <para>The items of the child node in the loop task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-xxx</para>
        /// </summary>
        [NameInMap("LoopItem")]
        [Validation(Required=false)]
        public string LoopItem { get; set; }

        /// <summary>
        /// <para>The description for the notification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Note</para>
        /// </summary>
        [NameInMap("NotifyNote")]
        [Validation(Required=false)]
        public string NotifyNote { get; set; }

        /// <summary>
        /// <para>The type of the notification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ExecuteTask</b>: starts to run a specific task. This value is used if you perform debugging in the Debug mode. If you set this parameter to ExecuteTask, you also need to set the Parameters parameter.</description></item>
        /// <item><description><b>CancelTask</b>: cancels a current task. This value is used if you perform debugging in the Debug mode.</description></item>
        /// <item><description><b>CompleteExecution</b>: manually terminates an execution if you perform debugging in the Debug mode. You can specify the state of the terminated execution by using the <b>ExecutionStatus</b> parameter.</description></item>
        /// <item><description><b>Approve</b>: approves an execution. For example, you are aware of the risks of an operation task and agree to approve the execution.</description></item>
        /// <item><description><b>Reject</b>: rejects an execution. For example, you want to reject the execution of a high-risk operation task.</description></item>
        /// <item><description><b>RetryTask</b>: retries a failed task whose execution mode is Suspend upon Failure.</description></item>
        /// <item><description><b>SkipTask</b>: skips a failed task whose execution mode is Suspend upon Failure.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Approve</para>
        /// </summary>
        [NameInMap("NotifyType")]
        [Validation(Required=false)]
        public string NotifyType { get; set; }

        /// <summary>
        /// <para>The parameters of the subsequent task. This parameter is valid if you set the NotifyType parameter to ExecuteTask.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the execution resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The execution ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-exec-xxx</para>
        /// </summary>
        [NameInMap("TaskExecutionId")]
        [Validation(Required=false)]
        public string TaskExecutionId { get; set; }

        /// <summary>
        /// <para>The execution IDs of the tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;exec-79c321c11003a97c&quot;,&quot;exec-79c321c11003aqw97cz&quot;]</para>
        /// </summary>
        [NameInMap("TaskExecutionIds")]
        [Validation(Required=false)]
        public string TaskExecutionIds { get; set; }

        /// <summary>
        /// <para>The name of the subsequent task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>describeInstance</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
