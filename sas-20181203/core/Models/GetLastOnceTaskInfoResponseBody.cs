// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLastOnceTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the latest task.
        /// </summary>
        [NameInMap("CollectTime")]
        [Validation(Required=false)]
        public long? CollectTime { get; set; }

        [NameInMap("FinishCount")]
        [Validation(Required=false)]
        public int? FinishCount { get; set; }

        /// <summary>
        /// The status of the task. Valid values:
        /// 
        /// *   **INIT**: The task is not started.
        /// *   **START**: The task is started.
        /// *   **SUCCESS**: The task is complete.
        /// *   **TIMEOUT**: The task timed out.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the scan task. Valid values:
        /// 
        /// *   **SUCCESS**: The task is successful.
        /// *   **TASK\_NOT\_SUPPORT_REGION**: The images are deployed in a region that is not supported by container image scan.
        /// *   **TASK\_NOT_EXISTS**: The task does not exist.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public GetLastOnceTaskInfoResponseBodyTaskInfo TaskInfo { get; set; }
        public class GetLastOnceTaskInfoResponseBodyTaskInfo : TeaModel {
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The progress of the task in percentage.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
