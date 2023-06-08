// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRefreshTaskByIdResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about tasks.
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribeRefreshTaskByIdResponseBodyTasks> Tasks { get; set; }
        public class DescribeRefreshTaskByIdResponseBodyTasks : TeaModel {
            /// <summary>
            /// The time when the task was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The error returned when the refresh or prefetch task failed. Valid values:
            /// 
            /// *   **Internal Error**
            /// *   **Origin Timeout**
            /// *   **Origin Return StatusCode 5XX**
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The path of the object refreshed by the refresh task.
            /// </summary>
            [NameInMap("ObjectPath")]
            [Validation(Required=false)]
            public string ObjectPath { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   **file**: refreshes an individual file.
            /// *   **directory**: refreshes files in the specified directory.
            /// *   **preload**: prefetches an individual file.
            /// *   **regex**: refreshes content based on a regular expression.
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
            /// The status of the task. Valid values:
            /// 
            /// *   **Complete**
            /// *   **Pending**
            /// *   **Refreshing**
            /// *   **Failed**
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
