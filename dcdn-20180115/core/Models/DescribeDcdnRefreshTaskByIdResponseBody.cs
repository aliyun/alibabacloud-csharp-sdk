// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRefreshTaskByIdResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// A list of prefetch or refresh tasks.
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribeDcdnRefreshTaskByIdResponseBodyTasks> Tasks { get; set; }
        public class DescribeDcdnRefreshTaskByIdResponseBodyTasks : TeaModel {
            /// <summary>
            /// The time when the task was created. The time follows the ISO8601 standard in the YYYY-MM-DDThh:mmZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The error returned when the refresh or prefetch task failed. Valid values:
            /// 
            /// *   **Internal Error**: An internal error occurred.
            /// *   **Origin Timeout**: The response from the origin server timed out.
            /// *   **Origin Return StatusCode 5XX**: The origin server returned a 5XX error.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The path of the refresh or prefetch object.
            /// </summary>
            [NameInMap("ObjectPath")]
            [Validation(Required=false)]
            public string ObjectPath { get; set; }

            /// <summary>
            /// The type of the refresh or prefetch task. Valid values:
            /// 
            /// *   **file**: refreshes an individual file.
            /// *   **directory**: refreshes files under the specified directory.
            /// *   **preload**: prefetches an individual file.
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// The progress of the task, in percentage.
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            /// <summary>
            /// The task status. Valid values:
            /// 
            /// *   **Complete**: The task is complete.
            /// *   **Pending**: The task is pending.
            /// *   **Refreshing**: The task is running.
            /// *   **Failed**: The task failed.
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

        }

        /// <summary>
        /// The total number of tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
