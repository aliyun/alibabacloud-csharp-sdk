// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOnceTaskResultInfoResponseBody : TeaModel {
        /// <summary>
        /// The execution time of the task.
        /// </summary>
        [NameInMap("CollectTime")]
        [Validation(Required=false)]
        public long? CollectTime { get; set; }

        /// <summary>
        /// The number of tasks that were completed.
        /// </summary>
        [NameInMap("FinishCount")]
        [Validation(Required=false)]
        public int? FinishCount { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the scan task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// The information about the task.
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public GetOnceTaskResultInfoResponseBodyTaskInfo TaskInfo { get; set; }
        public class GetOnceTaskResultInfoResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **INIT**: The task is not started.
            /// *   **START**: The task is started.
            /// *   **SUCCESS**: The task is complete.
            /// *   **TIMEOUT**: The task times out.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
