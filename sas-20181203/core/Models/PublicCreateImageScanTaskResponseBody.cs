// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicCreateImageScanTaskResponseBody : TeaModel {
        /// <summary>
        /// The data returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PublicCreateImageScanTaskResponseBodyData Data { get; set; }
        public class PublicCreateImageScanTaskResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether you can create more image scan tasks. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// 
            /// > By default, a maximum of 10 image scan tasks can be running at the same time. If 10 image scan tasks are running, you cannot create an image scan task by calling this operation. You must wait for at least one of the 10 existing image scan tasks to complete before you can create an image scan task.
            /// </summary>
            [NameInMap("CanCreate")]
            [Validation(Required=false)]
            public bool? CanCreate { get; set; }

            /// <summary>
            /// The timestamp when the image information was collected. Unit: milliseconds.
            /// </summary>
            [NameInMap("CollectTime")]
            [Validation(Required=false)]
            public long? CollectTime { get; set; }

            /// <summary>
            /// The timestamp when the image scan task started to run. Unit: milliseconds.
            /// </summary>
            [NameInMap("ExecTime")]
            [Validation(Required=false)]
            public long? ExecTime { get; set; }

            /// <summary>
            /// The number of images that have been scanned.
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public int? FinishCount { get; set; }

            /// <summary>
            /// The progress of the image scan task in percentage.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// The result of the image scan task. Valid values:
            /// 
            /// *   **SUCCESS**: The task is successful.
            /// *   **TASK_NOT_SUPPORT_REGION**: The images are deployed in a region that is not supported by container image scan.
            /// 
            /// > For more information about the regions supported by container image scan, see the "Regions supported by container image scan" section in this topic.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// The status of the image scan task. Valid values:
            /// 
            /// *   **INIT**: The task is being initialized.
            /// *   **PRE_ANALYZER**: The task is being pre-processed.
            /// *   **SUCCESS**: The task is successful.
            /// *   **FAIL**: The task fails.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the image scan task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The total number of images to scan.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
