// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The description of the task.
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public DescribeTaskInfoResponseBodyTaskInfo TaskInfo { get; set; }
        public class DescribeTaskInfoResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// The start time of the task. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format.
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// The end time of the task. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// The progress of the task. Unit: %.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The status of the task.
            /// 
            /// *   Waiting
            /// *   Running
            /// *   Finished
            /// *   Failed
            /// *   Closed
            /// *   Cancel
            /// *   Retry
            /// *   Pause
            /// *   Stop
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

        }

    }

}
