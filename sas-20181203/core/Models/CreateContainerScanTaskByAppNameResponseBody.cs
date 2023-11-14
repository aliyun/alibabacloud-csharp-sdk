// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateContainerScanTaskByAppNameResponseBody : TeaModel {
        /// <summary>
        /// The data returned if the request was successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateContainerScanTaskByAppNameResponseBodyData Data { get; set; }
        public class CreateContainerScanTaskByAppNameResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether you can create more scan tasks. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("CanCreate")]
            [Validation(Required=false)]
            public bool? CanCreate { get; set; }

            /// <summary>
            /// The timestamp generated when the image information was collected. Unit: milliseconds.
            /// </summary>
            [NameInMap("CollectTime")]
            [Validation(Required=false)]
            public long? CollectTime { get; set; }

            /// <summary>
            /// The timestamp generated when the scan task started. Unit: milliseconds.
            /// </summary>
            [NameInMap("ExecTime")]
            [Validation(Required=false)]
            public long? ExecTime { get; set; }

            /// <summary>
            /// The number of container applications that are scanned.
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public int? FinishCount { get; set; }

            /// <summary>
            /// The progress of the scan task in percentage.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// The result of the scan task. Valid values:
            /// 
            /// *   **SUCCESS**: The task is successful.
            /// *   **TASK_NOT_SUPPORT_REGION**: The task is not supported in the region where the image is deployed.
            /// 
            /// >
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// The status of the scan task. Valid values:
            /// 
            /// *   **INIT**: The task is being initialized.
            /// *   **PRE_ANALYZER**: The task is being pre-processed.
            /// *   **SUCCESS**: The task succeeds.
            /// *   **FAIL**: The task fails.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the scan task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The total number of container applications that you want to scan.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
