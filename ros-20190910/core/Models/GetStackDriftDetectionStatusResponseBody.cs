// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackDriftDetectionStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the drift detection operation.
        /// </summary>
        [NameInMap("DriftDetectionId")]
        [Validation(Required=false)]
        public string DriftDetectionId { get; set; }

        /// <summary>
        /// The drift detection status. Valid values:
        /// 
        /// *   DETECTION_COMPLETE: The drift detection operation has been completed for all resources that support drift detection in the stack.
        /// *   DETECTION_FAILED: The stack drift detection operation has failed for at least one resource in the stack.
        /// *   DETECTION_IN_PROGRESS: The stack drift detection operation is in progress.
        /// </summary>
        [NameInMap("DriftDetectionStatus")]
        [Validation(Required=false)]
        public string DriftDetectionStatus { get; set; }

        /// <summary>
        /// The reason why the stack drift detection operation has its current status.
        /// </summary>
        [NameInMap("DriftDetectionStatusReason")]
        [Validation(Required=false)]
        public string DriftDetectionStatusReason { get; set; }

        /// <summary>
        /// The time when the stack drift detection operation was initiated.
        /// </summary>
        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        /// <summary>
        /// The total number of stack resources that have drifted.
        /// </summary>
        [NameInMap("DriftedStackResourceCount")]
        [Validation(Required=false)]
        public int? DriftedStackResourceCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The drift status of the stack. Valid values:
        /// 
        /// *   DRIFTED: The actual configuration of the stack differs, or has drifted, from its expected template configuration. A stack is considered to have drifted if one or more of its resources have drifted.
        /// *   NOT_CHECKED: Resource Orchestration Service (ROS) has not checked whether the actual configuration of the resource differs from its expected template configuration.
        /// *   IN_SYNC: The current configuration of each supported resource matches its expected template configuration. A stack with no resources that support drift detection also has a status of IN_SYNC.
        /// </summary>
        [NameInMap("StackDriftStatus")]
        [Validation(Required=false)]
        public string StackDriftStatus { get; set; }

        /// <summary>
        /// The ID of the stack.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
