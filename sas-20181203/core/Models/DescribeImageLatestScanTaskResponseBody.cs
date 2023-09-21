// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageLatestScanTaskResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the information about the task.
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public List<DescribeImageLatestScanTaskResponseBodyTask> Task { get; set; }
        public class DescribeImageLatestScanTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// The time when the task was created. The time is in the yyyy-MM-dd HH:mm:ss format.
            /// </summary>
            [NameInMap("Create")]
            [Validation(Required=false)]
            public string Create { get; set; }

            /// <summary>
            /// The number of images that are scanned.
            /// </summary>
            [NameInMap("Finish")]
            [Validation(Required=false)]
            public int? Finish { get; set; }

            /// <summary>
            /// The end time of the task. A value is returned only when the task is in the Finished state. Otherwise, the returned value is empty.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The time when the task was last modified. The time is in the yyyy-MM-dd HH:mm:ss format.
            /// </summary>
            [NameInMap("Modified")]
            [Validation(Required=false)]
            public string Modified { get; set; }

            /// <summary>
            /// The name of the task.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The method in which the task was created. A task can be created in the Security Center console or by calling an API operation. Valid values:
            /// 
            /// *   **console_batch**: The task was created in the Security Center console.
            /// *   **openapi**: The task was created by calling an API operation.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The start time of the task.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The status of the task. Valid value:
            /// 
            /// *   **PROCESSING**: The task is running.
            /// *   **START**: The task is being started.
            /// *   **MESSAGE_SEND**: The scan task is sent.
            /// *   **PRE_ANALYZER**: The image is in precheck.
            /// *   **SUCCESS**: The task was successful.
            /// *   **FAIL**: The task failed.
            /// *   **TIMOUT**: The task timed out.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The digest value of the image.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// The type of the scanned asset. Valid value:
            /// 
            /// *   **IMAGE**
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The ID of the scan task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The type of the task. Valid value:
            /// 
            /// *   **IMAGE_SCAN**
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
