// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRefreshTasksResponseBody : TeaModel {
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
        public DescribeDcdnRefreshTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeDcdnRefreshTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDcdnRefreshTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeDcdnRefreshTasksResponseBodyTasksTask : TeaModel {
                /// <summary>
                /// The time when the task was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The type of error returned when the refresh or prefetch task has failed.
                /// 
                /// *   **InternalError**: An internal error occurred.
                /// *   **OriginTimeout**: The response from the origin server timed out.
                /// *   **OriginReturn StatusCode 5XX**: The origin server returned a 5XX error.
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
                /// *   **file**: URL-based refresh
                /// *   **path**: directory-based refresh
                /// *   **preload**: URL-based prefetch
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
                /// The status of the task.
                /// 
                /// *   **Complete**: The task is complete.
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
        /// The number of tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
