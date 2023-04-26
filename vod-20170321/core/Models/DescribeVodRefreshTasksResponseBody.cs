// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodRefreshTasksResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the returned tasks.
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeVodRefreshTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeVodRefreshTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeVodRefreshTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeVodRefreshTasksResponseBodyTasksTask : TeaModel {
                /// <summary>
                /// The time when the task was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The type of error returned when the refresh or prefetch task failed. Valid values: Valid values:
                /// 
                /// *   **Internal Error**: An internal error occurred.
                /// *   **Origin Timeout**: The response from the origin server timed out.
                /// *   **Origin Return StatusCode 5XX**: The origin server returned an HTTP status code 5xx.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The URL of the object refreshed.
                /// </summary>
                [NameInMap("ObjectPath")]
                [Validation(Required=false)]
                public string ObjectPath { get; set; }

                /// <summary>
                /// The type of the task. Default value: file. Valid values:
                /// 
                /// *   **file**: refreshes one or more files.
                /// *   **directory**: refreshes files in the specified directory.
                /// *   **preload**: prefetches one or more files.
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// The progress of the task in percentage.
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                /// <summary>
                /// The status of the task. Valid values:
                /// 
                /// *   **Complete**: The task is complete.
                /// *   **Refreshing**: The task is in progress.
                /// *   **Failed**: The task failed.
                /// *   **Pending**: The task is pending.
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

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
