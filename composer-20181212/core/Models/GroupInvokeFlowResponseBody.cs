// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class GroupInvokeFlowResponseBody : TeaModel {
        /// <summary>
        /// The number of times of execution that are pending.
        /// </summary>
        [NameInMap("CurrentCount")]
        [Validation(Required=false)]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// The unique identifier of the execution.
        /// </summary>
        [NameInMap("GroupInvocationId")]
        [Validation(Required=false)]
        public string GroupInvocationId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the group. Valid values:
        /// 
        /// *   New: The group is created and waiting to be executed.
        /// *   Started: The group is being executed.
        /// *   Canceled: The group was canceled.
        /// *   Failed: The execution failed.
        /// *   Completed: All the times of execution in the group are complete.
        /// *   Unknown: The group status is uncertain. In this case, a system error may occur.
        /// *   TimedOut: The execution timed out.
        /// *   Paused: The execution was suspended.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the operation was successful.
        /// 
        /// *   **true**: The workflow execution is triggered.
        /// *   **false**: The workflow execution failed to be triggered.
        /// 
        /// > : You can call the **GetInvocationLog** operation to check whether the workflow execution is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
