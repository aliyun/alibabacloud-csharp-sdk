// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class NotifyExecutionRequest : TeaModel {
        /// <summary>
        /// The ID of the execution.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The state of the terminated execution. This parameter is valid if you set the NotifyType parameter to CompleteExecution.
        /// </summary>
        [NameInMap("ExecutionStatus")]
        [Validation(Required=false)]
        public string ExecutionStatus { get; set; }

        /// <summary>
        /// The items of the child node in the loop task.
        /// </summary>
        [NameInMap("LoopItem")]
        [Validation(Required=false)]
        public string LoopItem { get; set; }

        /// <summary>
        /// The description for the notification.
        /// </summary>
        [NameInMap("NotifyNote")]
        [Validation(Required=false)]
        public string NotifyNote { get; set; }

        /// <summary>
        /// The type of the notification. Valid values:
        /// 
        /// *   **ExecuteTask**: starts to run a specific task. This value is used if you perform debugging in the Debug mode. If you set this parameter to ExecuteTask, you also need to set the Parameters parameter.
        /// *   **CancelTask**: cancels a current task. This value is used if you perform debugging in the Debug mode.
        /// *   **CompleteExecution**: manually terminates an execution if you perform debugging in the Debug mode. You can specify the state of the terminated execution by using the **ExecutionStatus** parameter.
        /// *   **Approve**: approves an execution. For example, you are aware of the risks of an operation task and agree to approve the execution.
        /// *   **Reject**: rejects an execution. For example, you want to reject the execution of a high-risk operation task.
        /// *   **RetryTask**: retries a failed task whose execution mode is Suspend upon Failure.
        /// *   **SkipTask**: skips a failed task whose execution mode is Suspend upon Failure.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NotifyType")]
        [Validation(Required=false)]
        public string NotifyType { get; set; }

        /// <summary>
        /// The parameters of the subsequent task. This parameter is valid if you set the NotifyType parameter to ExecuteTask.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// The ID of the region in which the execution resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The execution ID of the task.
        /// </summary>
        [NameInMap("TaskExecutionId")]
        [Validation(Required=false)]
        public string TaskExecutionId { get; set; }

        /// <summary>
        /// The execution IDs of the tasks.
        /// </summary>
        [NameInMap("TaskExecutionIds")]
        [Validation(Required=false)]
        public string TaskExecutionIds { get; set; }

        /// <summary>
        /// The name of the subsequent task.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
