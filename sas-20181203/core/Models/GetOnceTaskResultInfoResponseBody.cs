// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOnceTaskResultInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the task.
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
        /// *   **TIMEOUT**: The task times out.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public GetOnceTaskResultInfoResponseBodyTaskInfo TaskInfo { get; set; }
        public class GetOnceTaskResultInfoResponseBodyTaskInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
