// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetTaskStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status information of the task.
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public GetTaskStatusResponseBodyTaskStatus TaskStatus { get; set; }
        public class GetTaskStatusResponseBodyTaskStatus : TeaModel {
            /// <summary>
            /// The time when the task ended.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The cause of the task failure.
            /// 
            /// >  This parameter is returned only when the value of `Status` is `Failed`.
            /// </summary>
            [NameInMap("FailureReason")]
            [Validation(Required=false)]
            public string FailureReason { get; set; }

            /// <summary>
            /// The time when the task started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   InProgress: The task is running.
            /// *   Success: The task is successful.
            /// *   Failed: The task failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   ProvisionAccessConfiguration: An access configuration is provisioned.
            /// *   DeprovisionAccessConfiguration: An access configuration is de-provisioned.
            /// *   CreateAccessAssignment: Access permissions on an account in the resource directory are assigned.
            /// *   DeleteAccessAssignment: Access permissions on an account in the resource directory are removed.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
