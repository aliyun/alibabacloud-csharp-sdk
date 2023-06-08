// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRefreshTasksResponseBody : TeaModel {
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
        /// Details about tasks.
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeRefreshTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeRefreshTasksResponseBodyTasks : TeaModel {
            [NameInMap("CDNTask")]
            [Validation(Required=false)]
            public List<DescribeRefreshTasksResponseBodyTasksCDNTask> CDNTask { get; set; }
            public class DescribeRefreshTasksResponseBodyTasksCDNTask : TeaModel {
                /// <summary>
                /// The time when the task was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The type of the error returned when the refresh or prefetch task failed. Valid values:
                /// 
                /// *   **InternalError**: An internal error occurred.
                /// *   **OriginTimeout**: The response from the origin server timed out.
                /// *   **OriginReturnStatusCode 5XX**: The origin server returned a 5XX error.
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
                /// The type of the task.
                /// 
                /// *   **file**: refreshes one or more files.
                /// *   **directory**: refreshes files in the specified directories.
                /// *   **regex**: refreshes content based on a regular expression.
                /// *   **preload**: prefetches one or more files.
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
                /// *   **Complete**: The task has completed.
                /// *   **Refreshing**: The task is in progress.
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

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
